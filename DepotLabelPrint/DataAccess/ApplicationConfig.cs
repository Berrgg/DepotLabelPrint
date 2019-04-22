using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;


namespace DepotLabelPrint.DataAccess
{
    public class ApplicationConfig
    {
        private readonly NameValueCollection _valueCollection;
        private static Configuration _configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private readonly KeyValueConfigurationCollection _settings;
        private string _sectionName;

        public ApplicationConfig(string sectionName)
        {
            _sectionName = sectionName;
            _valueCollection = ConfigurationManager.GetSection(_sectionName) as NameValueCollection;
            _settings = ((AppSettingsSection)_configFile.GetSection(_sectionName)).Settings;
        }

        public void AddUpdateKey(string keyName, string value)
        {
            try
            {
                if (_settings[keyName] == null)
                {
                    _settings.Add(keyName, value);
                }
                else
                {
                    _settings[keyName].Value = value;
                }
                _configFile.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection(_sectionName);
            }
            catch (ConfigurationErrorsException)
            {
                throw;
            }
        }

        public void RemoveKey(string keyName)
        {
            try
            {
                if (_settings[keyName] != null)
                    _settings.Remove(keyName);

                _configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(_configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw;
            }
        }

        public string GetValue(string keyName)
        {
            return _valueCollection[keyName];
        }

        public NameValueCollection GetKeys()
        {
            return _valueCollection;
        }


    }
}

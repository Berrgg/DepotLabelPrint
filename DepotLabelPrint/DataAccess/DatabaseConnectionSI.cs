using DevExpress.DataAccess.ConnectionParameters;
using DepotLabelPrint.DataAccess;

namespace DepotLabelPrint.DataAccess
{
    public class DatabaseConnectionSI : ISqlDatabaseConnection
    {
        public MsSqlConnectionParameters DatabaseConnection { get ; set; }

        public DatabaseConnectionSI()
        {
            ApplicationConfig config = new ApplicationConfig("GeneralAppSettings");

            DatabaseConnection = new MsSqlConnectionParameters()
            {
                ServerName = config.GetValue(GeneralAppSettings.ServerName),
                DatabaseName = config.GetValue(GeneralAppSettings.DatabaseName),
                UserName = config.GetValue(GeneralAppSettings.UserName),
                Password = config.GetValue(GeneralAppSettings.UserPassword),
                AuthorizationType = MsSqlAuthorizationType.SqlServer
            };
        }


    }
}

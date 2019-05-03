using System;
using System.Data;
using System.Linq;

namespace DepotLabelPrint.DataAccess
{
    public class ReportDataSetTableInfo
    {
        private readonly string _depot;
        private readonly string _depotDate;
        private readonly string _ssccCode;

        public ReportDataSetTableInfo(string depot, string depotDate, string SSCCcode)
        {
            _depot = depot;
            _depotDate = depotDate;
            _ssccCode = SSCCcode;
        }

        public DataTable GetTableInfo()
        {
            DataTable dt = new DataTable("Info");

            dt.Columns.Add("SiteNumber", typeof(string));
            dt.Columns.Add("Site", typeof(string));
            dt.Columns.Add("Company", typeof(string));
            dt.Columns.Add("Depot", typeof(string));
            dt.Columns.Add("DepotDate", typeof(string));
            dt.Columns.Add("BarCode", typeof(string));

            ApplicationConfig config = new ApplicationConfig("GeneralAppSettings");

            var siteNumber = config.GetValue(GeneralAppSettings.SiteNumber);
            var site = config.GetValue(GeneralAppSettings.Site);
            var company = config.GetValue(GeneralAppSettings.Company);
            var depot = _depot;
            var depotDate = _depotDate;
            var barCode = Mod10DigitCheck(config.GetValue(GeneralAppSettings.CustomerCode) + _ssccCode);

            dt.Rows.Add(siteNumber, site, company, depot, depotDate, barCode);

            return dt;
        }

        private string Mod10DigitCheck(string number)
        {
            int totalOdd=0;
            int totalEven=0;

            var numbersList = number.Select(x => Convert.ToInt32(x.ToString())).ToList();
            numbersList.Reverse();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                    totalEven += numbersList[i];
                else
                    totalOdd += numbersList[i];
            }

            totalEven *= 3;

            var total = totalOdd + totalEven;
            var lastDigit = LastDigit(total);

            if (lastDigit == 0)
                return number + 0.ToString();
            else
                return number + (10 - lastDigit).ToString();
        }

        private int LastDigit(int n)
        {
            return (n % 10);
        }
    }
}

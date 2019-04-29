using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotLabelPrint.DataAccess
{
    public class ReportDataSetTableInfo
    {
        private readonly string _depot;
        private readonly string _depotDate;

        public ReportDataSetTableInfo(string depot, string depotDate)
        {
            _depot = depot;
            _depotDate = depotDate;
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

            dt.Rows.Add(siteNumber, site, company, depot, depotDate);

            return dt;
        }
    }
}

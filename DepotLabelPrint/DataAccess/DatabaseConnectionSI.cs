using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DepotLabelPrint.DataAccess;
using DevExpress.DataAccess.Sql.DataApi;
using System;
using System.Data;

namespace DepotLabelPrint.DataAccess
{
    public class DatabaseConnectionSI : ISqlDatabaseConnection
    {
        public MsSqlConnectionParameters DatabaseConnection { get ; private set; }
        public SqlDataSource DataSource { get ; private set ; }
        public string DisplayMember { get; private set; }
        public string ValueMember { get; private set; }


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

        public ITable GetDepotList()
        {
            SqlDataSource ds = new SqlDataSource(DatabaseConnection);
            var query = new MySqlQuery().QueryDepotList();

            ds.Queries.Add(query);
            ds.Fill();

            DisplayMember = "customername";
            ValueMember = "customercode";
            // ds.SaveToXml();

            return ds.Result["DepotList"];
        }

        public ITable GetSsccList(string customerCode, string depotDate)
        {
            SqlDataSource ds = new SqlDataSource(DatabaseConnection);
            var query = new MySqlQuery().QuerySSCCList(customerCode, depotDate);

            ds.Queries.Add(query);
            ds.Fill();

            DisplayMember = "sscc";
            ValueMember = "sscc";

            //ITable src = ds.Result["SSCCList"];
            //DataTable dest = new DataTable("Test");

            //foreach (IColumn column in src.Columns)
            //    dest.Columns.Add(column.Name, column.Type);

            //foreach (IRow rw in src)
            //{
            //    DataRow dr = dest.NewRow();
            //    dr[0] = rw[0];
            //    dr[1] = rw[1];
            //    dest.Rows.Add(dr);
            //}

            return ds.Result["SSCCList"];
        }

        public DataTable GetSsccProducts(string SSCCcode)
        {
            SqlDataSource ds = new SqlDataSource(DatabaseConnection);
            var query = new MySqlQuery().QuerySSCCProducts(SSCCcode);

            ds.Queries.Add(query);
            ds.Fill();

            ITable source = ds.Result[0];
            DataTable dest = new DataTable("Products");

            foreach (IColumn column in source.Columns)
                dest.Columns.Add(column.Name, column.Type);

            foreach (IRow row in source)
            {
                DataRow dr = dest.NewRow();

                for (int i = 0; i < dest.Columns.Count; i++)
                {
                    dr[i] = row[i];
                }

                dest.Rows.Add(dr);
            }

            return dest;
        }
    }
}

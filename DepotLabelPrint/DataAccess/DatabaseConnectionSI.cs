using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DepotLabelPrint.DataAccess;
using DevExpress.DataAccess.Sql.DataApi;

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
    }
}

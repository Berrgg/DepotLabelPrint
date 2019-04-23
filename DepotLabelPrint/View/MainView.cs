using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DepotLabelPrint.DataAccess;

namespace DepotLabelPrint
{
    public partial class DepotLabelPrint : DevExpress.XtraEditors.XtraForm
    {
        public DepotLabelPrint()
        {
            InitializeComponent();

            SetMainView();
        }

        private void SetMainView()
        {
            dateEdit_DepotDate.EditValue = DateTime.Now;
            ActiveControl = labelControl_DepotDate;
            GetDepots();
        }

        public void GetDepots()
        {
            //MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters()
            //{
            //    ServerName = "10.3.1.7",
            //    DatabaseName = "si",
            //    UserName = "siuser",
            //    Password = "si",
            //    AuthorizationType = MsSqlAuthorizationType.SqlServer
            //};

            //SqlDataSource ds = new SqlDataSource(connectionParameters);

            //CustomSqlQuery query = new CustomSqlQuery();
            //query.Name = "queryDepotList";
            //query.Sql = "SELECT customername FROM si_sop_customers WHERE master_customer='msho' and active=-1 and customer_type='D' and payment_type=2";

            //ds.Queries.Add(query);
            //ds.Fill();

            var depotTable = new DatabaseConnectionSI().GetDepotList();

            listBoxControl_Depots.DisplayMember = "customername";
            listBoxControl_Depots.ValueMember = "customername";
            listBoxControl_Depots.DataSource = depotTable;
            //listBoxControl_Depots.DataSource = ds.Result["queryDepotList"];
        }
    }
}

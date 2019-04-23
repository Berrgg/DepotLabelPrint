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
            listBoxControl_SSCC.MultiColumn = true;
            dateEdit_DepotDate.EditValue = DateTime.Now;
            ActiveControl = labelControl_DepotDate;
            GetDepots();
        }

        public void GetDepots()
        {
            var connection = new DatabaseConnectionSI();
            var depotTable = connection.GetDepotList();

            listBoxControl_Depots.DisplayMember = connection.DisplayMember;
            listBoxControl_Depots.ValueMember = connection.ValueMember;
            listBoxControl_Depots.DataSource = depotTable;
        }

        private void listBoxControl_Depots_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBoxControl_Depots.SelectedValue.ToString()); 
        }
    }
}

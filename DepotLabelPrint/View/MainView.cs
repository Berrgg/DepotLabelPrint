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

            gridView_SSCC.Columns[0].Caption = "SSCC number";
            gridView_SSCC.Columns[1].Caption = "Pallet";
        }

        private void GetDepots()
        {
            var connection = new DatabaseConnectionSI();
            var depotTable = connection.GetDepotList();

            listBoxControl_Depots.DisplayMember = connection.DisplayMember;
            listBoxControl_Depots.ValueMember = connection.ValueMember;
            listBoxControl_Depots.DataSource = depotTable;
        }

        private void GetSSCCList()
        {
            var depotDate = Convert.ToDateTime(dateEdit_DepotDate.EditValue);
            string depotName = null;

            if(listBoxControl_Depots.SelectedValue != null)
            {
                depotName = listBoxControl_Depots.SelectedValue.ToString();
            }

            if (depotName != null && depotDate != null)
            {
                var connection = new DatabaseConnectionSI();
                var ssccTable = connection.GetSsccList(depotName, depotDate.ToString("MM/dd/yyyy"));

                gridControl_SSCC.DataSource = ssccTable;
            }
        }

        private void listBoxControl_Depots_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSSCCList();
        }

        private void dateEdit_DepotDate_SelectionChanged(object sender, EventArgs e)
        {
            GetSSCCList();
        }
    }
}

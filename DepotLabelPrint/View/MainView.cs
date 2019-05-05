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
using DepotLabelPrint.Reports;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.XtraReports.UI;

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

        private void simpleButton_Print_Click(object sender, EventArgs e)
        {
            var depotName = listBoxControl_Depots.GetItemText(listBoxControl_Depots.SelectedIndex);
            var depotDate = Convert.ToDateTime(dateEdit_DepotDate.EditValue);
            var sscc = gridView_SSCC.GetRowCellValue(gridView_SSCC.FocusedRowHandle, gridView_SSCC.Columns[0]).ToString();

            var tableInfo = new ReportDataSetTableInfo(depotName, depotDate.ToString("dd/MM/yyyy dddd"), sscc);
            DataTable dtInfo = tableInfo.GetTableInfo();

            var tableProducts = new DatabaseConnectionSI();
            DataTable dtProducts = tableProducts.GetSsccProducts(sscc);

            DataRow dr = dtInfo.Rows[0];
            dr[6] = dtProducts.Rows.Count;

            DataSet ds = new DataSet();
            ds.Tables.Add(dtInfo);
            ds.Tables.Add(dtProducts);

            //ds.WriteXmlSchema(@"d:\ScotbeefSolutions\SSCC.xsd");

            XtraReport report = new SSCCReport();
            report.DataSource = ds;

            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowPreview();

        }
    }
}

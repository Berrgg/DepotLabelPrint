namespace DepotLabelPrint
{
    partial class DepotLabelPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl_DepotDate = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl_Depots = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl_Depot = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Depots)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(12, 58);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(123, 26);
            this.dateEdit1.TabIndex = 0;
            // 
            // labelControl_DepotDate
            // 
            this.labelControl_DepotDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl_DepotDate.Appearance.Options.UseFont = true;
            this.labelControl_DepotDate.Location = new System.Drawing.Point(12, 33);
            this.labelControl_DepotDate.Name = "labelControl_DepotDate";
            this.labelControl_DepotDate.Size = new System.Drawing.Size(83, 19);
            this.labelControl_DepotDate.TabIndex = 1;
            this.labelControl_DepotDate.Text = "Depot date:";
            // 
            // listBoxControl_Depots
            // 
            this.listBoxControl_Depots.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listBoxControl_Depots.Appearance.Options.UseFont = true;
            this.listBoxControl_Depots.Location = new System.Drawing.Point(12, 154);
            this.listBoxControl_Depots.Name = "listBoxControl_Depots";
            this.listBoxControl_Depots.Size = new System.Drawing.Size(151, 243);
            this.listBoxControl_Depots.TabIndex = 2;
            // 
            // labelControl_Depot
            // 
            this.labelControl_Depot.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl_Depot.Appearance.Options.UseFont = true;
            this.labelControl_Depot.Location = new System.Drawing.Point(12, 129);
            this.labelControl_Depot.Name = "labelControl_Depot";
            this.labelControl_Depot.Size = new System.Drawing.Size(55, 19);
            this.labelControl_Depot.TabIndex = 3;
            this.labelControl_Depot.Text = "Depots:";
            // 
            // DepotLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 473);
            this.Controls.Add(this.labelControl_Depot);
            this.Controls.Add(this.listBoxControl_Depots);
            this.Controls.Add(this.labelControl_DepotDate);
            this.Controls.Add(this.dateEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "DepotLabelPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depot Label Pint";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Depots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl_DepotDate;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_Depots;
        private DevExpress.XtraEditors.LabelControl labelControl_Depot;
    }
}


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
            this.dateEdit_DepotDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl_DepotDate = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl_Depots = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl_Depot = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl_SSCC = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl_SSCC = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Print = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DepotDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DepotDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Depots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_SSCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit_DepotDate
            // 
            this.dateEdit_DepotDate.EditValue = null;
            this.dateEdit_DepotDate.Location = new System.Drawing.Point(12, 58);
            this.dateEdit_DepotDate.Name = "dateEdit_DepotDate";
            this.dateEdit_DepotDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEdit_DepotDate.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_DepotDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DepotDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DepotDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEdit_DepotDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_DepotDate.Size = new System.Drawing.Size(123, 26);
            this.dateEdit_DepotDate.TabIndex = 0;
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
            // listBoxControl_SSCC
            // 
            this.listBoxControl_SSCC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listBoxControl_SSCC.Appearance.Options.UseFont = true;
            this.listBoxControl_SSCC.Location = new System.Drawing.Point(252, 154);
            this.listBoxControl_SSCC.Name = "listBoxControl_SSCC";
            this.listBoxControl_SSCC.Size = new System.Drawing.Size(151, 243);
            this.listBoxControl_SSCC.TabIndex = 4;
            // 
            // labelControl_SSCC
            // 
            this.labelControl_SSCC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl_SSCC.Appearance.Options.UseFont = true;
            this.labelControl_SSCC.Location = new System.Drawing.Point(252, 129);
            this.labelControl_SSCC.Name = "labelControl_SSCC";
            this.labelControl_SSCC.Size = new System.Drawing.Size(44, 19);
            this.labelControl_SSCC.TabIndex = 5;
            this.labelControl_SSCC.Text = "SSCC:";
            // 
            // simpleButton_Print
            // 
            this.simpleButton_Print.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton_Print.Appearance.Options.UseFont = true;
            this.simpleButton_Print.Location = new System.Drawing.Point(469, 218);
            this.simpleButton_Print.Name = "simpleButton_Print";
            this.simpleButton_Print.Size = new System.Drawing.Size(140, 61);
            this.simpleButton_Print.TabIndex = 6;
            this.simpleButton_Print.Text = "PRINT";
            // 
            // DepotLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 473);
            this.Controls.Add(this.simpleButton_Print);
            this.Controls.Add(this.labelControl_SSCC);
            this.Controls.Add(this.listBoxControl_SSCC);
            this.Controls.Add(this.labelControl_Depot);
            this.Controls.Add(this.listBoxControl_Depots);
            this.Controls.Add(this.labelControl_DepotDate);
            this.Controls.Add(this.dateEdit_DepotDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "DepotLabelPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depot Label Pint";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DepotDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DepotDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Depots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_SSCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit_DepotDate;
        private DevExpress.XtraEditors.LabelControl labelControl_DepotDate;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_Depots;
        private DevExpress.XtraEditors.LabelControl labelControl_Depot;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_SSCC;
        private DevExpress.XtraEditors.LabelControl labelControl_SSCC;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Print;
    }
}


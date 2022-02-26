
namespace Library.Reports
{
    partial class Frm_R
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
            this.recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            this.designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_GtDT = new DevExpress.XtraEditors.SimpleButton();
            this.Dt_Get = new DevExpress.XtraEditors.DateEdit();
            this.Cry_CustomerActions1 = new Library.Reports.Cry_CustomerActions();
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Get.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Get.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // recentlyUsedItemsComboBox1
            // 
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = true;
            this.recentlyUsedItemsComboBox1.AutoHeight = false;
            this.recentlyUsedItemsComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1";
            // 
            // designRepositoryItemComboBox1
            // 
            this.designRepositoryItemComboBox1.AutoHeight = false;
            this.designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Dt_Get);
            this.panelControl1.Controls.Add(this.Btn_GtDT);
            this.panelControl1.Controls.Add(this.Btn_New);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1218, 45);
            this.panelControl1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.crystalReportViewer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1218, 485);
            this.panelControl2.TabIndex = 13;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Cry_CustomerActions1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1214, 481);
            this.crystalReportViewer1.TabIndex = 11;
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.findcustomers_32x32;
            this.Btn_New.Location = new System.Drawing.Point(222, 4);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(156, 37);
            this.Btn_New.TabIndex = 8;
            this.Btn_New.Text = "Get By Name";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_GtDT
            // 
            this.Btn_GtDT.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_GtDT.Appearance.Options.UseFont = true;
            this.Btn_GtDT.ImageOptions.Image = global::Library.Properties.Resources.findcustomers_32x32;
            this.Btn_GtDT.Location = new System.Drawing.Point(559, 2);
            this.Btn_GtDT.Name = "Btn_GtDT";
            this.Btn_GtDT.Size = new System.Drawing.Size(156, 37);
            this.Btn_GtDT.TabIndex = 9;
            this.Btn_GtDT.Text = "Get By Date";
            this.Btn_GtDT.Click += new System.EventHandler(this.Btn_GtDT_Click);
            // 
            // Dt_Get
            // 
            this.Dt_Get.EditValue = null;
            this.Dt_Get.Location = new System.Drawing.Point(407, 12);
            this.Dt_Get.Name = "Dt_Get";
            this.Dt_Get.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Get.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Dt_Get.Size = new System.Drawing.Size(146, 20);
            this.Dt_Get.TabIndex = 10;
            // 
            // Frm_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 530);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "Frm_R";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_R";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_R_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Get.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Get.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        public DevExpress.XtraEditors.SimpleButton Btn_GtDT;
        private DevExpress.XtraEditors.DateEdit Dt_Get;
        private Cry_CustomerActions Cry_CustomerActions1;
    }
}
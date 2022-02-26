namespace Library.Basic_Forms
{
    partial class JobType
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Job = new DevExpress.XtraEditors.TextEdit();
            this.Panel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Dgd_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Job_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Job_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Job.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgd_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Lbl_ID);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.Txt_Job);
            this.panelControl1.Controls.Add(this.Panel_Buttons);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(595, 118);
            this.panelControl1.TabIndex = 0;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(23, 12);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl_ID.TabIndex = 19;
            this.Lbl_ID.Text = "0";
            this.Lbl_ID.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(135, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Job Type:";
            // 
            // Txt_Job
            // 
            this.Txt_Job.Location = new System.Drawing.Point(195, 24);
            this.Txt_Job.Name = "Txt_Job";
            this.Txt_Job.Properties.Mask.BeepOnError = true;
            this.Txt_Job.Properties.Mask.EditMask = "n0";
            this.Txt_Job.Size = new System.Drawing.Size(246, 20);
            this.Txt_Job.TabIndex = 16;
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.AutoSize = true;
            this.Panel_Buttons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Panel_Buttons.Controls.Add(this.Btn_Exit);
            this.Panel_Buttons.Controls.Add(this.Btn_Del);
            this.Panel_Buttons.Controls.Add(this.Btn_Edit);
            this.Panel_Buttons.Controls.Add(this.Btn_Save);
            this.Panel_Buttons.Controls.Add(this.Btn_New);
            this.Panel_Buttons.Location = new System.Drawing.Point(49, 62);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(509, 54);
            this.Panel_Buttons.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x32;
            this.Btn_Exit.Location = new System.Drawing.Point(410, 8);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(92, 39);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Del.Appearance.Options.UseFont = true;
            this.Btn_Del.ImageOptions.Image = global::Library.Properties.Resources.saveandclose_32x32;
            this.Btn_Del.Location = new System.Drawing.Point(311, 8);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(92, 39);
            this.Btn_Del.TabIndex = 5;
            this.Btn_Del.Text = "Delete";
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Appearance.Options.UseFont = true;
            this.Btn_Edit.ImageOptions.Image = global::Library.Properties.Resources.saveas_32x32;
            this.Btn_Edit.Location = new System.Drawing.Point(211, 7);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(92, 39);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Update";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.ImageOptions.Image = global::Library.Properties.Resources.saveto_32x32;
            this.Btn_Save.Location = new System.Drawing.Point(109, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(92, 39);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.projectdirectory_32x32;
            this.Btn_New.Location = new System.Drawing.Point(7, 8);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(92, 39);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Dgd_Shearch
            // 
            this.Dgd_Shearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgd_Shearch.Location = new System.Drawing.Point(0, 118);
            this.Dgd_Shearch.MainView = this.gridView1;
            this.Dgd_Shearch.Name = "Dgd_Shearch";
            this.Dgd_Shearch.Size = new System.Drawing.Size(595, 354);
            this.Dgd_Shearch.TabIndex = 1;
            this.Dgd_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgd_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgd_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Job_ID,
            this.Job_Name});
            this.gridView1.GridControl = this.Dgd_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Job_ID
            // 
            this.Job_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Job_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Job_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_ID.Caption = "Job_ID";
            this.Job_ID.FieldName = "Job_ID";
            this.Job_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Job_ID.Name = "Job_ID";
            // 
            // Job_Name
            // 
            this.Job_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Job_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Job_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_Name.Caption = "Job Name";
            this.Job_Name.FieldName = "Job_Name";
            this.Job_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Job_Name.Name = "Job_Name";
            this.Job_Name.Visible = true;
            this.Job_Name.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Job_ID";
            this.gridColumn1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "gridColumn1";
            this.gridColumn2.FieldName = "Job_ID";
            this.gridColumn2.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // JobType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.Dgd_Shearch);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.project_32x323;
            this.KeyPreview = true;
            this.Name = "JobType";
            this.Text = "JobType";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JobType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Job.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgd_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.PanelControl Panel_Buttons;
        public DevExpress.XtraEditors.SimpleButton Btn_Exit;
        public DevExpress.XtraEditors.SimpleButton Btn_Del;
        public DevExpress.XtraEditors.SimpleButton Btn_Edit;
        public DevExpress.XtraEditors.SimpleButton Btn_Save;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl Dgd_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Job_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Job_Name;
        public DevExpress.XtraEditors.TextEdit Txt_Job;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
       
        public DevExpress.XtraEditors.LabelControl Lbl_ID;
    }
}
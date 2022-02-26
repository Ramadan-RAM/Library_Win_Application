namespace Library.Basic_Forms
{
    partial class EmpData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpData));
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Cmb_JobTyp = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID_No = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Salry = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Mob = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Emp_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Job_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Job_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_Mobaile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Persoanal_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Basic_Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Salry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(51, 72);
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.Location = new System.Drawing.Point(51, 287);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x321;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Del.Appearance.Options.UseFont = true;
            this.Btn_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Del.ImageOptions.Image")));
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Appearance.Options.UseFont = true;
            this.Btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Edit.ImageOptions.Image")));
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.ImageOptions.Image")));
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.bocustomer_32x324;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Cmb_Shearch
            // 
            this.Cmb_Shearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cmb_Shearch_MouseClick);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.Appearance.Options.UseFont = true;
            this.Btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.ImageOptions.Image")));
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            // 
            // Pnl_BasicData
            // 
            this.Pnl_BasicData.Controls.Add(this.Cmb_JobTyp);
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.labelControl7);
            this.Pnl_BasicData.Controls.Add(this.TxtID_No);
            this.Pnl_BasicData.Controls.Add(this.labelControl8);
            this.Pnl_BasicData.Controls.Add(this.Txt_Salry);
            this.Pnl_BasicData.Controls.Add(this.labelControl5);
            this.Pnl_BasicData.Controls.Add(this.Txt_Mob);
            this.Pnl_BasicData.Controls.Add(this.labelControl4);
            this.Pnl_BasicData.Controls.Add(this.Txt_Phone);
            this.Pnl_BasicData.Controls.Add(this.labelControl3);
            this.Pnl_BasicData.Controls.Add(this.Txt_Address);
            this.Pnl_BasicData.Controls.Add(this.labelControl2);
            this.Pnl_BasicData.Controls.Add(this.Txt_Name);
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 85);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(614, 201);
            this.Pnl_BasicData.TabIndex = 4;
            // 
            // Cmb_JobTyp
            // 
            this.Cmb_JobTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_JobTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_JobTyp.FormattingEnabled = true;
            this.Cmb_JobTyp.Location = new System.Drawing.Point(395, 31);
            this.Cmb_JobTyp.Name = "Cmb_JobTyp";
            this.Cmb_JobTyp.Size = new System.Drawing.Size(200, 21);
            this.Cmb_JobTyp.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(335, 30);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Job Type:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(327, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "ID Number:";
            // 
            // TxtID_No
            // 
            this.TxtID_No.Location = new System.Drawing.Point(395, 165);
            this.TxtID_No.Name = "TxtID_No";
            this.TxtID_No.Properties.Mask.BeepOnError = true;
            this.TxtID_No.Properties.Mask.EditMask = "\\d+";
            this.TxtID_No.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtID_No.Properties.MaxLength = 14;
            this.TxtID_No.Size = new System.Drawing.Size(200, 20);
            this.TxtID_No.TabIndex = 12;
            this.TxtID_No.EditValueChanged += new System.EventHandler(this.TxtID_No_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(38, 172);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "Basic Salary:";
            // 
            // Txt_Salry
            // 
            this.Txt_Salry.Location = new System.Drawing.Point(115, 169);
            this.Txt_Salry.Name = "Txt_Salry";
            this.Txt_Salry.Properties.Mask.BeepOnError = true;
            this.Txt_Salry.Properties.Mask.EditMask = "f";
            this.Txt_Salry.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Salry.Size = new System.Drawing.Size(200, 20);
            this.Txt_Salry.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(343, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Mobaile:";
            // 
            // Txt_Mob
            // 
            this.Txt_Mob.Location = new System.Drawing.Point(395, 112);
            this.Txt_Mob.Name = "Txt_Mob";
            this.Txt_Mob.Properties.Mask.BeepOnError = true;
            this.Txt_Mob.Properties.Mask.EditMask = "\\d+";
            this.Txt_Mob.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Txt_Mob.Properties.MaxLength = 11;
            this.Txt_Mob.Size = new System.Drawing.Size(200, 20);
            this.Txt_Mob.TabIndex = 6;
            this.Txt_Mob.EditValueChanged += new System.EventHandler(this.Txt_Mob_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(71, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Phone:";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(115, 116);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Properties.Mask.BeepOnError = true;
            this.Txt_Phone.Properties.Mask.EditMask = "\\d+";
            this.Txt_Phone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Txt_Phone.Properties.MaxLength = 11;
            this.Txt_Phone.Size = new System.Drawing.Size(200, 20);
            this.Txt_Phone.TabIndex = 4;
            this.Txt_Phone.EditValueChanged += new System.EventHandler(this.Txt_Phone_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(60, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Address:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(115, 75);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(480, 20);
            this.Txt_Address.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Employee Name:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(115, 31);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(200, 20);
            this.Txt_Name.TabIndex = 0;
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Shearch.Location = new System.Drawing.Point(632, 0);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(744, 351);
            this.Dgv_Shearch.TabIndex = 5;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Emp_ID,
            this.Emp_Name,
            this.Job_ID,
            this.Emp_Address,
            this.Job_Name,
            this.Emp_Phone,
            this.Emp_Mobaile,
            this.Persoanal_ID,
            this.Basic_Salary});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Emp_ID
            // 
            this.Emp_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_ID.Caption = "Emp_ID";
            this.Emp_ID.FieldName = "Emp_ID";
            this.Emp_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Emp_ID.Name = "Emp_ID";
            // 
            // Emp_Name
            // 
            this.Emp_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Name.Caption = "Employee Name";
            this.Emp_Name.FieldName = "Emp_Name";
            this.Emp_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Visible = true;
            this.Emp_Name.VisibleIndex = 0;
            // 
            // Job_ID
            // 
            this.Job_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Job_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Job_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_ID.Caption = "Job_ID";
            this.Job_ID.FieldName = "Job_ID";
            this.Job_ID.Name = "Job_ID";
            // 
            // Emp_Address
            // 
            this.Emp_Address.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Address.Caption = "Employee Address";
            this.Emp_Address.FieldName = "Emp_Address";
            this.Emp_Address.Name = "Emp_Address";
            this.Emp_Address.Visible = true;
            this.Emp_Address.VisibleIndex = 3;
            // 
            // Job_Name
            // 
            this.Job_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Job_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Job_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Job_Name.Caption = "Job Type";
            this.Job_Name.FieldName = "Job_Name";
            this.Job_Name.Name = "Job_Name";
            this.Job_Name.Visible = true;
            this.Job_Name.VisibleIndex = 5;
            // 
            // Emp_Phone
            // 
            this.Emp_Phone.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_Phone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Phone.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_Phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Phone.Caption = "Employee Phone";
            this.Emp_Phone.FieldName = "Emp_Phone";
            this.Emp_Phone.Name = "Emp_Phone";
            this.Emp_Phone.Visible = true;
            this.Emp_Phone.VisibleIndex = 1;
            // 
            // Emp_Mobaile
            // 
            this.Emp_Mobaile.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_Mobaile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Mobaile.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_Mobaile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Mobaile.Caption = "Employee Mobaile";
            this.Emp_Mobaile.FieldName = "Emp_Mobaile";
            this.Emp_Mobaile.Name = "Emp_Mobaile";
            this.Emp_Mobaile.Visible = true;
            this.Emp_Mobaile.VisibleIndex = 2;
            // 
            // Persoanal_ID
            // 
            this.Persoanal_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Persoanal_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Persoanal_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Persoanal_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Persoanal_ID.Caption = "Persoanal ID";
            this.Persoanal_ID.FieldName = "Persoanal_ID";
            this.Persoanal_ID.Name = "Persoanal_ID";
            this.Persoanal_ID.Visible = true;
            this.Persoanal_ID.VisibleIndex = 4;
            // 
            // Basic_Salary
            // 
            this.Basic_Salary.AppearanceCell.Options.UseTextOptions = true;
            this.Basic_Salary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Basic_Salary.AppearanceHeader.Options.UseTextOptions = true;
            this.Basic_Salary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Basic_Salary.Caption = "Basic Salary";
            this.Basic_Salary.FieldName = "Basic_Salary";
            this.Basic_Salary.Name = "Basic_Salary";
            this.Basic_Salary.Visible = true;
            this.Basic_Salary.VisibleIndex = 6;
            // 
            // EmpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 351);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.bocustomer_32x322;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EmpData";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.EmpData_Load);
            this.Controls.SetChildIndex(this.Lbl_ID, 0);
            this.Controls.SetChildIndex(this.Pnl_BasicData, 0);
            this.Controls.SetChildIndex(this.Panel_Search, 0);
            this.Controls.SetChildIndex(this.Panel_Buttons, 0);
            this.Controls.SetChildIndex(this.Dgv_Shearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            this.Pnl_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Salry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit Txt_Mob;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_Address;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtID_No;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txt_Salry;
        public System.Windows.Forms.ComboBox Cmb_JobTyp;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Job_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_Address;
        private DevExpress.XtraGrid.Columns.GridColumn Job_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_Mobaile;
        private DevExpress.XtraGrid.Columns.GridColumn Persoanal_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Basic_Salary;
    }
}
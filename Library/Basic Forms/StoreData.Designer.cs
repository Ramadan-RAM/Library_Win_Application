namespace Library.Basic_Forms
{
    partial class StoreData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreData));
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Cmb_MangName = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Notes = new DevExpress.XtraEditors.MemoEdit();
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Store_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Emp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Notes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.Location = new System.Drawing.Point(41, 368);
            this.Panel_Buttons.Size = new System.Drawing.Size(542, 55);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.ImageOptions.Image")));
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
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.boorderitem_32x323;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
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
            this.Pnl_BasicData.Controls.Add(this.Cmb_MangName);
            this.Pnl_BasicData.Controls.Add(this.labelControl4);
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.labelControl3);
            this.Pnl_BasicData.Controls.Add(this.Txt_Address);
            this.Pnl_BasicData.Controls.Add(this.labelControl2);
            this.Pnl_BasicData.Controls.Add(this.Txt_Name);
            this.Pnl_BasicData.Controls.Add(this.Txt_Notes);
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 99);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(608, 243);
            this.Pnl_BasicData.TabIndex = 4;
            // 
            // Cmb_MangName
            // 
            this.Cmb_MangName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_MangName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_MangName.FormattingEnabled = true;
            this.Cmb_MangName.Location = new System.Drawing.Point(387, 30);
            this.Cmb_MangName.Name = "Cmb_MangName";
            this.Cmb_MangName.Size = new System.Drawing.Size(196, 21);
            this.Cmb_MangName.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(314, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Mang Name:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(62, 139);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Notes:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Address:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(103, 75);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(480, 20);
            this.Txt_Address.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name Store:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(103, 31);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(196, 20);
            this.Txt_Name.TabIndex = 0;
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(103, 114);
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(480, 97);
            this.Txt_Notes.TabIndex = 8;
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Shearch.Location = new System.Drawing.Point(659, 0);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(630, 466);
            this.Dgv_Shearch.TabIndex = 8;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Store_ID,
            this.Emp_ID,
            this.Store_Name,
            this.Emp_Name,
            this.Store_Address,
            this.Store_Notes});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Store_ID
            // 
            this.Store_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Store_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Store_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_ID.Caption = "Store_ID";
            this.Store_ID.FieldName = "Store_ID";
            this.Store_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Store_ID.Name = "Store_ID";
            // 
            // Emp_ID
            // 
            this.Emp_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_ID.Caption = "Emp_ID";
            this.Emp_ID.FieldName = "Emp_ID";
            this.Emp_ID.Name = "Emp_ID";
            // 
            // Store_Name
            // 
            this.Store_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Store_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Store_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Name.Caption = "Store Name";
            this.Store_Name.FieldName = "Store_Name";
            this.Store_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Store_Name.Name = "Store_Name";
            this.Store_Name.Visible = true;
            this.Store_Name.VisibleIndex = 3;
            // 
            // Emp_Name
            // 
            this.Emp_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Emp_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Emp_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Emp_Name.Caption = "Mange Name";
            this.Emp_Name.FieldName = "Emp_Name";
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Visible = true;
            this.Emp_Name.VisibleIndex = 2;
            // 
            // Store_Address
            // 
            this.Store_Address.AppearanceCell.Options.UseTextOptions = true;
            this.Store_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Store_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Address.Caption = "Store Address";
            this.Store_Address.FieldName = "Store_Address";
            this.Store_Address.Name = "Store_Address";
            this.Store_Address.Visible = true;
            this.Store_Address.VisibleIndex = 1;
            // 
            // Store_Notes
            // 
            this.Store_Notes.AppearanceCell.Options.UseTextOptions = true;
            this.Store_Notes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Notes.AppearanceHeader.Options.UseTextOptions = true;
            this.Store_Notes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Notes.Caption = "Store Notes";
            this.Store_Notes.FieldName = "Store_Notes";
            this.Store_Notes.Name = "Store_Notes";
            this.Store_Notes.Visible = true;
            this.Store_Notes.VisibleIndex = 0;
            // 
            // StoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 466);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.boorderitem_32x322;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "StoreData";
            this.Text = "Store Data";
            this.Load += new System.EventHandler(this.StoreData_Load);
            this.Controls.SetChildIndex(this.Lbl_ID, 0);
            this.Controls.SetChildIndex(this.Panel_Search, 0);
            this.Controls.SetChildIndex(this.Panel_Buttons, 0);
            this.Controls.SetChildIndex(this.Pnl_BasicData, 0);
            this.Controls.SetChildIndex(this.Dgv_Shearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            this.Pnl_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Notes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_Address;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private DevExpress.XtraEditors.MemoEdit Txt_Notes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public System.Windows.Forms.ComboBox Cmb_MangName;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Store_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Store_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Store_Address;
        private DevExpress.XtraGrid.Columns.GridColumn Store_Notes;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Emp_Name;
    }
}
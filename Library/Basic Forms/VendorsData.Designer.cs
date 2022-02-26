namespace Library.Basic_Forms
{
    partial class VendorsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsData));
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Mob = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Notes = new DevExpress.XtraEditors.MemoEdit();
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ven_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Mobaile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Search)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
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
            this.Lbl_ID.Location = new System.Drawing.Point(43, 58);
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.Location = new System.Drawing.Point(53, 349);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x322;
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
            this.Btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_New.ImageOptions.Image")));
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Panel_Search
            // 
            this.Panel_Search.Location = new System.Drawing.Point(62, 12);
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
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.labelControl5);
            this.Pnl_BasicData.Controls.Add(this.labelControl4);
            this.Pnl_BasicData.Controls.Add(this.Txt_Mob);
            this.Pnl_BasicData.Controls.Add(this.Txt_Phone);
            this.Pnl_BasicData.Controls.Add(this.labelControl3);
            this.Pnl_BasicData.Controls.Add(this.Txt_Address);
            this.Pnl_BasicData.Controls.Add(this.labelControl2);
            this.Pnl_BasicData.Controls.Add(this.Txt_Name);
            this.Pnl_BasicData.Controls.Add(this.Txt_Notes);
            this.Pnl_BasicData.Location = new System.Drawing.Point(-1, 77);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(596, 266);
            this.Pnl_BasicData.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(69, 177);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Notes:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(338, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Mobaile:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Phone:";
            // 
            // Txt_Mob
            // 
            this.Txt_Mob.Location = new System.Drawing.Point(390, 112);
            this.Txt_Mob.Name = "Txt_Mob";
            this.Txt_Mob.Properties.Mask.BeepOnError = true;
            this.Txt_Mob.Properties.Mask.EditMask = "\\d+";
            this.Txt_Mob.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Txt_Mob.Properties.MaxLength = 11;
            this.Txt_Mob.Size = new System.Drawing.Size(200, 20);
            this.Txt_Mob.TabIndex = 6;
            this.Txt_Mob.EditValueChanged += new System.EventHandler(this.Txt_Mob_EditValueChanged);
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(110, 116);
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
            this.labelControl3.Location = new System.Drawing.Point(55, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Address:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(110, 75);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(480, 20);
            this.Txt_Address.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Customer Name:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(110, 31);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(480, 20);
            this.Txt_Name.TabIndex = 0;
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(110, 152);
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(480, 97);
            this.Txt_Notes.TabIndex = 8;
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Shearch.Location = new System.Drawing.Point(635, 0);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(682, 413);
            this.Dgv_Shearch.TabIndex = 7;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ven_ID,
            this.Ven_Address,
            this.Ven_Phone,
            this.Ven_Mobaile,
            this.Ven_Name,
            this.Ven_Notes});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Ven_ID
            // 
            this.Ven_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_ID.Caption = "Ven_ID";
            this.Ven_ID.FieldName = "Ven_ID";
            this.Ven_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Ven_ID.Name = "Ven_ID";
            // 
            // Ven_Address
            // 
            this.Ven_Address.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Address.Caption = "Vendor Address";
            this.Ven_Address.FieldName = "Ven_Address";
            this.Ven_Address.Name = "Ven_Address";
            this.Ven_Address.Visible = true;
            this.Ven_Address.VisibleIndex = 3;
            // 
            // Ven_Phone
            // 
            this.Ven_Phone.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Phone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Phone.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Phone.Caption = "Vendor Phone";
            this.Ven_Phone.FieldName = "Ven_Phone";
            this.Ven_Phone.Name = "Ven_Phone";
            this.Ven_Phone.Visible = true;
            this.Ven_Phone.VisibleIndex = 1;
            // 
            // Ven_Mobaile
            // 
            this.Ven_Mobaile.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Mobaile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Mobaile.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Mobaile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Mobaile.Caption = "Vendor Mobaile";
            this.Ven_Mobaile.FieldName = "Ven_Mobaile";
            this.Ven_Mobaile.Name = "Ven_Mobaile";
            this.Ven_Mobaile.Visible = true;
            this.Ven_Mobaile.VisibleIndex = 2;
            // 
            // Ven_Name
            // 
            this.Ven_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Name.Caption = "Vendor Name";
            this.Ven_Name.FieldName = "Ven_Name";
            this.Ven_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Ven_Name.Name = "Ven_Name";
            this.Ven_Name.Visible = true;
            this.Ven_Name.VisibleIndex = 0;
            // 
            // Ven_Notes
            // 
            this.Ven_Notes.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Notes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Notes.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Notes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Notes.Caption = "Notes";
            this.Ven_Notes.FieldName = "Ven_Notes";
            this.Ven_Notes.Name = "Ven_Notes";
            this.Ven_Notes.Visible = true;
            this.Ven_Notes.VisibleIndex = 4;
            // 
            // VendorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 413);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.customer_32x325;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VendorsData";
            this.Text = "Add Vendors";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.VendorsData_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit Txt_Mob;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_Address;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private DevExpress.XtraEditors.MemoEdit Txt_Notes;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Address;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Mobaile;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Notes;
    }
}
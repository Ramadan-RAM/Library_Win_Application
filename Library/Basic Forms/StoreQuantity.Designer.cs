
namespace Library.Basic_Forms
{
    partial class StoreQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreQuantity));
            this.Cmb_StoreName = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Panel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Quantity = new DevExpress.XtraEditors.TextEdit();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Quan_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_StoreName
            // 
            this.Cmb_StoreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_StoreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_StoreName.FormattingEnabled = true;
            this.Cmb_StoreName.Location = new System.Drawing.Point(90, 12);
            this.Cmb_StoreName.Name = "Cmb_StoreName";
            this.Cmb_StoreName.Size = new System.Drawing.Size(202, 21);
            this.Cmb_StoreName.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Store Name:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(9, 5);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl_ID.TabIndex = 22;
            this.Lbl_ID.Text = "0";
            this.Lbl_ID.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(306, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Item Quantity:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Item Name:";
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.AutoSize = true;
            this.Panel_Buttons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Panel_Buttons.Controls.Add(this.Btn_Exit);
            this.Panel_Buttons.Controls.Add(this.Btn_Del);
            this.Panel_Buttons.Controls.Add(this.Btn_Edit);
            this.Panel_Buttons.Controls.Add(this.Lbl_ID);
            this.Panel_Buttons.Controls.Add(this.Btn_New);
            this.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Buttons.Location = new System.Drawing.Point(2, 93);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(931, 51);
            this.Panel_Buttons.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.ImageOptions.Image")));
            this.Btn_Exit.Location = new System.Drawing.Point(605, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(94, 39);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Del.Appearance.Options.UseFont = true;
            this.Btn_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Del.ImageOptions.Image")));
            this.Btn_Del.Location = new System.Drawing.Point(506, 5);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(93, 39);
            this.Btn_Del.TabIndex = 5;
            this.Btn_Del.Text = "Delete";
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Appearance.Options.UseFont = true;
            this.Btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Edit.ImageOptions.Image")));
            this.Btn_Edit.Location = new System.Drawing.Point(408, 4);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(92, 39);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Update";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_New.ImageOptions.Image")));
            this.Btn_New.Location = new System.Drawing.Point(304, 4);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(100, 39);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Pnl_BasicData
            // 
            this.Pnl_BasicData.Controls.Add(this.Btn_Search);
            this.Pnl_BasicData.Controls.Add(this.Txt_Quantity);
            this.Pnl_BasicData.Controls.Add(this.Cmb_ItemName);
            this.Pnl_BasicData.Controls.Add(this.Cmb_StoreName);
            this.Pnl_BasicData.Controls.Add(this.labelControl3);
            this.Pnl_BasicData.Controls.Add(this.labelControl1);
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.Panel_Buttons);
            this.Pnl_BasicData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(935, 146);
            this.Pnl_BasicData.TabIndex = 3;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.Appearance.Options.UseFont = true;
            this.Btn_Search.ImageOptions.Image = global::Library.Properties.Resources.find_16x16;
            this.Btn_Search.Location = new System.Drawing.Point(298, 12);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(81, 24);
            this.Btn_Search.TabIndex = 41;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_Quantity
            // 
            this.Txt_Quantity.EditValue = "0";
            this.Txt_Quantity.Location = new System.Drawing.Point(395, 51);
            this.Txt_Quantity.Name = "Txt_Quantity";
            this.Txt_Quantity.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Quantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Txt_Quantity.Properties.Mask.BeepOnError = true;
            this.Txt_Quantity.Properties.Mask.EditMask = "f0";
            this.Txt_Quantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Quantity.Size = new System.Drawing.Size(117, 20);
            this.Txt_Quantity.TabIndex = 40;
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(90, 50);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.Size = new System.Drawing.Size(202, 21);
            this.Cmb_ItemName.TabIndex = 39;
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Shearch.Location = new System.Drawing.Point(0, 146);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(935, 356);
            this.Dgv_Shearch.TabIndex = 4;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Quan_ID,
            this.Store_ID,
            this.Item_ID,
            this.Store_Name,
            this.Item_Name,
            this.Item_Quantity});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Quan_ID
            // 
            this.Quan_ID.Caption = "Quan_ID";
            this.Quan_ID.FieldName = "Quan_ID";
            this.Quan_ID.Name = "Quan_ID";
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
            // Item_ID
            // 
            this.Item_ID.Caption = "Item_ID";
            this.Item_ID.FieldName = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            // 
            // Store_Name
            // 
            this.Store_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Store_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Store_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Store_Name.Caption = "Store Name";
            this.Store_Name.FieldName = "Store_Name";
            this.Store_Name.Name = "Store_Name";
            this.Store_Name.Visible = true;
            this.Store_Name.VisibleIndex = 0;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.Caption = "Item Name";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 1;
            // 
            // Item_Quantity
            // 
            this.Item_Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Quantity.Caption = "Item Quantity";
            this.Item_Quantity.FieldName = "Item_Quantity";
            this.Item_Quantity.Name = "Item_Quantity";
            this.Item_Quantity.Visible = true;
            this.Item_Quantity.VisibleIndex = 2;
            // 
            // StoreQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 502);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.addnewdatasource_32x321;
            this.Name = "StoreQuantity";
            this.Text = "Add Quantity Items To Stors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StoreQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            this.Panel_Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            this.Pnl_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox Cmb_StoreName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl Lbl_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.PanelControl Panel_Buttons;
        public DevExpress.XtraEditors.SimpleButton Btn_Exit;
        public DevExpress.XtraEditors.SimpleButton Btn_Del;
        public DevExpress.XtraEditors.SimpleButton Btn_Edit;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        public DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Store_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Store_Name;
        public System.Windows.Forms.ComboBox Cmb_ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Quan_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        public DevExpress.XtraEditors.TextEdit Txt_Quantity;
        public DevExpress.XtraEditors.SimpleButton Btn_Search;
    }
}
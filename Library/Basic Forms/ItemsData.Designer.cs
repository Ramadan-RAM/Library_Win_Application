namespace Library.Basic_Forms
{
    partial class ItemsData
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
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Minimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Store_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Panel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Cmb_BasicStore = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_Cat = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Minimum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Txt_ItemName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Minimum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Shearch.Location = new System.Drawing.Point(0, 193);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(623, 349);
            this.Dgv_Shearch.TabIndex = 3;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Item_ID,
            this.Category_ID,
            this.Store_ID,
            this.Item_Name,
            this.Item_Minimum,
            this.Category_Name,
            this.Store_Name});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Item_ID
            // 
            this.Item_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Item_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_ID.Caption = "Item_ID";
            this.Item_ID.FieldName = "Item_ID";
            this.Item_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Item_ID.Name = "Item_ID";
            // 
            // Category_ID
            // 
            this.Category_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Category_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Category_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_ID.Caption = "Category_ID";
            this.Category_ID.FieldName = "Category_ID";
            this.Category_ID.Name = "Category_ID";
            // 
            // Store_ID
            // 
            this.Store_ID.Caption = "Store_ID";
            this.Store_ID.FieldName = "Store_ID";
            this.Store_ID.Name = "Store_ID";
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
            this.Item_Name.VisibleIndex = 2;
            // 
            // Item_Minimum
            // 
            this.Item_Minimum.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Minimum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Minimum.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Minimum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Minimum.Caption = "Item Minimum";
            this.Item_Minimum.FieldName = "Item_Minimum";
            this.Item_Minimum.Name = "Item_Minimum";
            this.Item_Minimum.Visible = true;
            this.Item_Minimum.VisibleIndex = 3;
            // 
            // Category_Name
            // 
            this.Category_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Category_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Category_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_Name.Caption = "Category Name";
            this.Category_Name.FieldName = "Category_Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Visible = true;
            this.Category_Name.VisibleIndex = 1;
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
            // Panel_Buttons
            // 
            this.Panel_Buttons.AutoSize = true;
            this.Panel_Buttons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.Panel_Buttons.Controls.Add(this.Btn_Exit);
            this.Panel_Buttons.Controls.Add(this.Btn_Del);
            this.Panel_Buttons.Controls.Add(this.Btn_Edit);
            this.Panel_Buttons.Controls.Add(this.Btn_Save);
            this.Panel_Buttons.Controls.Add(this.Btn_New);
            this.Panel_Buttons.Location = new System.Drawing.Point(49, 136);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(511, 56);
            this.Panel_Buttons.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x32;
            this.Btn_Exit.Location = new System.Drawing.Point(410, 8);
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
            this.Btn_Del.ImageOptions.Image = global::Library.Properties.Resources.saveandclose_32x32;
            this.Btn_Del.Location = new System.Drawing.Point(311, 8);
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
            this.Btn_Edit.ImageOptions.Image = global::Library.Properties.Resources.saveas_32x32;
            this.Btn_Edit.Location = new System.Drawing.Point(213, 7);
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
            this.Btn_Save.Location = new System.Drawing.Point(113, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(94, 39);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.newsales_32x321;
            this.Btn_New.Location = new System.Drawing.Point(7, 8);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(100, 39);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Pnl_BasicData
            // 
            this.Pnl_BasicData.Controls.Add(this.Cmb_BasicStore);
            this.Pnl_BasicData.Controls.Add(this.labelControl3);
            this.Pnl_BasicData.Controls.Add(this.Lbl_ID);
            this.Pnl_BasicData.Controls.Add(this.Cmb_Cat);
            this.Pnl_BasicData.Controls.Add(this.labelControl2);
            this.Pnl_BasicData.Controls.Add(this.labelControl1);
            this.Pnl_BasicData.Controls.Add(this.Txt_Minimum);
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.Txt_ItemName);
            this.Pnl_BasicData.Controls.Add(this.Panel_Buttons);
            this.Pnl_BasicData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(623, 193);
            this.Pnl_BasicData.TabIndex = 2;
            this.Pnl_BasicData.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_BasicData_Paint);
            // 
            // Cmb_BasicStore
            // 
            this.Cmb_BasicStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_BasicStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_BasicStore.FormattingEnabled = true;
            this.Cmb_BasicStore.Location = new System.Drawing.Point(409, 82);
            this.Cmb_BasicStore.Name = "Cmb_BasicStore";
            this.Cmb_BasicStore.Size = new System.Drawing.Size(199, 21);
            this.Cmb_BasicStore.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(336, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Basic Store:";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(25, 113);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl_ID.TabIndex = 22;
            this.Lbl_ID.Text = "0";
            this.Lbl_ID.Visible = false;
            // 
            // Cmb_Cat
            // 
            this.Cmb_Cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Cat.FormattingEnabled = true;
            this.Cmb_Cat.Location = new System.Drawing.Point(409, 23);
            this.Cmb_Cat.Name = "Cmb_Cat";
            this.Cmb_Cat.Size = new System.Drawing.Size(199, 21);
            this.Cmb_Cat.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(316, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Item Category:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Item Minimum:";
            // 
            // Txt_Minimum
            // 
            this.Txt_Minimum.Location = new System.Drawing.Point(97, 79);
            this.Txt_Minimum.Name = "Txt_Minimum";
            this.Txt_Minimum.Properties.Mask.BeepOnError = true;
            this.Txt_Minimum.Properties.Mask.EditMask = "n0";
            this.Txt_Minimum.Size = new System.Drawing.Size(202, 20);
            this.Txt_Minimum.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(25, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Item Name:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Item_ID";
            this.gridColumn1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Txt_ItemName
            // 
            this.Txt_ItemName.Location = new System.Drawing.Point(97, 23);
            this.Txt_ItemName.Name = "Txt_ItemName";
            this.Txt_ItemName.Properties.Mask.BeepOnError = true;
            this.Txt_ItemName.Properties.Mask.EditMask = "n0";
            this.Txt_ItemName.Size = new System.Drawing.Size(202, 20);
            this.Txt_ItemName.TabIndex = 16;
            // 
            // ItemsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 542);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.buy_32x321;
            this.Name = "ItemsData";
            this.Text = "Items Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Itemscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            this.Pnl_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Minimum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        public DevExpress.XtraEditors.PanelControl Panel_Buttons;
        public DevExpress.XtraEditors.SimpleButton Btn_Exit;
        public DevExpress.XtraEditors.SimpleButton Btn_Del;
        public DevExpress.XtraEditors.SimpleButton Btn_Edit;
        public DevExpress.XtraEditors.SimpleButton Btn_Save;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        public DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit Txt_Minimum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Category_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Category_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public System.Windows.Forms.ComboBox Cmb_Cat;
        public DevExpress.XtraEditors.LabelControl Lbl_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Minimum;
        private DevExpress.XtraGrid.Columns.GridColumn Store_Name;
        public System.Windows.Forms.ComboBox Cmb_BasicStore;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn Store_ID;
        public DevExpress.XtraEditors.TextEdit Txt_ItemName;
    }
}
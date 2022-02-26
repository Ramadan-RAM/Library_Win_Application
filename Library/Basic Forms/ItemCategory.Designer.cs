namespace Library.Basic_Forms
{
    partial class ItemCategory
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
            this.Category_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pnl_BasicData = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ItemCat = new DevExpress.XtraEditors.TextEdit();
            this.Panel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_New = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).BeginInit();
            this.Pnl_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).BeginInit();
            this.Panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Shearch.Location = new System.Drawing.Point(0, 112);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(595, 360);
            this.Dgv_Shearch.TabIndex = 3;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Dgv_Shearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Shearch_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Category_ID,
            this.Category_Name});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Category_ID
            // 
            this.Category_ID.AppearanceCell.Options.UseTextOptions = true;
            this.Category_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.Category_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_ID.Caption = "Category_ID";
            this.Category_ID.FieldName = "Category_ID";
            this.Category_ID.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Category_ID.Name = "Category_ID";
            // 
            // Category_Name
            // 
            this.Category_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Category_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Category_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category_Name.Caption = "Category Name";
            this.Category_Name.FieldName = "Category_Name";
            this.Category_Name.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Visible = true;
            this.Category_Name.VisibleIndex = 0;
            // 
            // Pnl_BasicData
            // 
            this.Pnl_BasicData.Controls.Add(this.Lbl_ID);
            this.Pnl_BasicData.Controls.Add(this.labelControl6);
            this.Pnl_BasicData.Controls.Add(this.Txt_ItemCat);
            this.Pnl_BasicData.Controls.Add(this.Panel_Buttons);
            this.Pnl_BasicData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BasicData.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BasicData.Name = "Pnl_BasicData";
            this.Pnl_BasicData.Size = new System.Drawing.Size(595, 112);
            this.Pnl_BasicData.TabIndex = 2;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ID.Appearance.Options.UseFont = true;
            this.Lbl_ID.Location = new System.Drawing.Point(12, 25);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(7, 13);
            this.Lbl_ID.TabIndex = 18;
            this.Lbl_ID.Text = "0";
            this.Lbl_ID.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(87, 25);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Item Category:";
            // 
            // Txt_ItemCat
            // 
            this.Txt_ItemCat.Location = new System.Drawing.Point(179, 23);
            this.Txt_ItemCat.Name = "Txt_ItemCat";
            this.Txt_ItemCat.Properties.Mask.BeepOnError = true;
            this.Txt_ItemCat.Properties.Mask.EditMask = "n0";
            this.Txt_ItemCat.Size = new System.Drawing.Size(246, 20);
            this.Txt_ItemCat.TabIndex = 16;
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
            this.Panel_Buttons.Size = new System.Drawing.Size(500, 56);
            this.Panel_Buttons.TabIndex = 3;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Appearance.Options.UseFont = true;
            this.Btn_Exit.ImageOptions.Image = global::Library.Properties.Resources.cancel_32x32;
            this.Btn_Exit.Location = new System.Drawing.Point(410, 8);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(81, 39);
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
            this.Btn_Del.Size = new System.Drawing.Size(81, 39);
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
            this.Btn_Edit.Size = new System.Drawing.Size(81, 39);
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
            this.Btn_Save.Size = new System.Drawing.Size(81, 39);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Appearance.Options.UseFont = true;
            this.Btn_New.ImageOptions.Image = global::Library.Properties.Resources.newdatasource_32x32;
            this.Btn_New.Location = new System.Drawing.Point(7, 8);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(81, 39);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "New";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // ItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.Dgv_Shearch);
            this.Controls.Add(this.Pnl_BasicData);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.documentmap_32x322;
            this.KeyPreview = true;
            this.Name = "ItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_BasicData)).EndInit();
            this.Pnl_BasicData.ResumeLayout(false);
            this.Pnl_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ItemCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Buttons)).EndInit();
            this.Panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Category_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Category_Name;
        public DevExpress.XtraEditors.PanelControl Pnl_BasicData;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.TextEdit Txt_ItemCat;
        public DevExpress.XtraEditors.PanelControl Panel_Buttons;
        public DevExpress.XtraEditors.SimpleButton Btn_Exit;
        public DevExpress.XtraEditors.SimpleButton Btn_Del;
        public DevExpress.XtraEditors.SimpleButton Btn_Edit;
        public DevExpress.XtraEditors.SimpleButton Btn_Save;
        public DevExpress.XtraEditors.SimpleButton Btn_New;
        public DevExpress.XtraEditors.LabelControl Lbl_ID;
        protected DevExpress.XtraGrid.GridControl Dgv_Shearch;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
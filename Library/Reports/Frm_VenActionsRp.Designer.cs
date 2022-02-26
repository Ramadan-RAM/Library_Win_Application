
namespace Library.Reports
{
    partial class Frm_VenActionsRp
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ven_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Payed_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remain_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date_Payed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Purchases_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ven_Debit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Purchases_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnPrint);
            this.layoutControl1.Controls.Add(this.Dgv_Shearch);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(616, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1376, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnPrint
            // 
            this.BtnPrint.ImageOptions.Image = global::Library.Properties.Resources.printer_32x324;
            this.BtnPrint.Location = new System.Drawing.Point(1284, 416);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(80, 22);
            this.BtnPrint.StyleController = this.layoutControl1;
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(1352, 400);
            this.Dgv_Shearch.TabIndex = 9;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ven_Name,
            this.Category_Name,
            this.Item_Name,
            this.Item_Quantity,
            this.Payed_Value,
            this.Remain_Value,
            this.Date_Payed,
            this.Purchases_Price,
            this.Item_Value,
            this.Ven_Debit,
            this.Purchases_Date});
            this.gridView1.GridControl = this.Dgv_Shearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Ven_Name
            // 
            this.Ven_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Name.Caption = "Vendor Name";
            this.Ven_Name.FieldName = "Ven_Name";
            this.Ven_Name.Name = "Ven_Name";
            this.Ven_Name.Visible = true;
            this.Ven_Name.VisibleIndex = 0;
            this.Ven_Name.Width = 251;
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
            this.Category_Name.Width = 115;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.Caption = "Item Name";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 2;
            this.Item_Name.Width = 214;
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
            this.Item_Quantity.VisibleIndex = 6;
            this.Item_Quantity.Width = 87;
            // 
            // Payed_Value
            // 
            this.Payed_Value.AppearanceCell.Options.UseTextOptions = true;
            this.Payed_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Payed_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Payed_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Payed_Value.Caption = "Payed Value";
            this.Payed_Value.FieldName = "Payed_Value";
            this.Payed_Value.Name = "Payed_Value";
            this.Payed_Value.Visible = true;
            this.Payed_Value.VisibleIndex = 4;
            this.Payed_Value.Width = 81;
            // 
            // Remain_Value
            // 
            this.Remain_Value.AppearanceCell.Options.UseTextOptions = true;
            this.Remain_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Remain_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Remain_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Remain_Value.Caption = "Remain Value";
            this.Remain_Value.FieldName = "Remain_Value";
            this.Remain_Value.Name = "Remain_Value";
            this.Remain_Value.Visible = true;
            this.Remain_Value.VisibleIndex = 8;
            this.Remain_Value.Width = 76;
            // 
            // Date_Payed
            // 
            this.Date_Payed.AppearanceCell.Options.UseTextOptions = true;
            this.Date_Payed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date_Payed.AppearanceHeader.Options.UseTextOptions = true;
            this.Date_Payed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date_Payed.Caption = "Date Payed";
            this.Date_Payed.FieldName = "Date_Payed";
            this.Date_Payed.Name = "Date_Payed";
            this.Date_Payed.Visible = true;
            this.Date_Payed.VisibleIndex = 5;
            this.Date_Payed.Width = 144;
            // 
            // Purchases_Price
            // 
            this.Purchases_Price.AppearanceCell.Options.UseTextOptions = true;
            this.Purchases_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Purchases_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Purchases_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Purchases_Price.Caption = "Purchases Price";
            this.Purchases_Price.FieldName = "Purchases_Price";
            this.Purchases_Price.Name = "Purchases_Price";
            this.Purchases_Price.Visible = true;
            this.Purchases_Price.VisibleIndex = 3;
            this.Purchases_Price.Width = 92;
            // 
            // Item_Value
            // 
            this.Item_Value.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Value.Caption = "Item Value";
            this.Item_Value.FieldName = "Item_Value";
            this.Item_Value.Name = "Item_Value";
            this.Item_Value.Visible = true;
            this.Item_Value.VisibleIndex = 7;
            this.Item_Value.Width = 86;
            // 
            // Ven_Debit
            // 
            this.Ven_Debit.AppearanceCell.Options.UseTextOptions = true;
            this.Ven_Debit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Debit.AppearanceHeader.Options.UseTextOptions = true;
            this.Ven_Debit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ven_Debit.Caption = " Debit Vendor";
            this.Ven_Debit.FieldName = "Ven_Debit";
            this.Ven_Debit.Name = "Ven_Debit";
            this.Ven_Debit.Visible = true;
            this.Ven_Debit.VisibleIndex = 10;
            this.Ven_Debit.Width = 95;
            // 
            // Purchases_Date
            // 
            this.Purchases_Date.AppearanceCell.Options.UseTextOptions = true;
            this.Purchases_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Purchases_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.Purchases_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Purchases_Date.Caption = "Purchases Date";
            this.Purchases_Date.FieldName = "Purchases_Date";
            this.Purchases_Date.Name = "Purchases_Date";
            this.Purchases_Date.Visible = true;
            this.Purchases_Date.VisibleIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1376, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Dgv_Shearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1356, 404);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 404);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(1272, 26);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(1272, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1272, 26);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(1272, 404);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(84, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(84, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(84, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Frm_VenActionsRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 450);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.allowuserstoeditranges_32x321;
            this.Name = "Frm_VenActionsRp";
            this.Text = "Vendors Actions";
            this.Load += new System.EventHandler(this.Frm_Repo2tr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Category_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Payed_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Remain_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Date_Payed;
        private DevExpress.XtraGrid.Columns.GridColumn Purchases_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Ven_Debit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Purchases_Date;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
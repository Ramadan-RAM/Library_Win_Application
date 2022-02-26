
namespace Library.Reports
{
    partial class Frm_CustActionsRp
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
            this.Dgv_Shearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCust_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCust_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayed_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemain_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Payed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCust_Debit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Dgv_Shearch);
            this.layoutControl1.Controls.Add(this.BtnPrint);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1237, 510);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Dgv_Shearch
            // 
            this.Dgv_Shearch.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Shearch.MainView = this.gridView1;
            this.Dgv_Shearch.Name = "Dgv_Shearch";
            this.Dgv_Shearch.Size = new System.Drawing.Size(1213, 460);
            this.Dgv_Shearch.TabIndex = 8;
            this.Dgv_Shearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCust_ID,
            this.colCust_Name,
            this.colCategory_Name,
            this.colItem_Name,
            this.colItem_Quantity,
            this.colPayed_Value,
            this.colRemain_Value,
            this.colDate_Payed,
            this.colSales_Price,
            this.colTotal_Value,
            this.colCust_Debit});
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
            // colCust_ID
            // 
            this.colCust_ID.FieldName = "Cust_ID";
            this.colCust_ID.Name = "colCust_ID";
            // 
            // colCust_Name
            // 
            this.colCust_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colCust_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCust_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCust_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCust_Name.Caption = "Customer Name";
            this.colCust_Name.FieldName = "Cust_Name";
            this.colCust_Name.Name = "colCust_Name";
            this.colCust_Name.Visible = true;
            this.colCust_Name.VisibleIndex = 0;
            this.colCust_Name.Width = 251;
            // 
            // colCategory_Name
            // 
            this.colCategory_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colCategory_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategory_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory_Name.Caption = "Category Name";
            this.colCategory_Name.FieldName = "Category_Name";
            this.colCategory_Name.Name = "colCategory_Name";
            this.colCategory_Name.Visible = true;
            this.colCategory_Name.VisibleIndex = 1;
            this.colCategory_Name.Width = 152;
            // 
            // colItem_Name
            // 
            this.colItem_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colItem_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colItem_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem_Name.Caption = "Item Name";
            this.colItem_Name.FieldName = "Item_Name";
            this.colItem_Name.Name = "colItem_Name";
            this.colItem_Name.Visible = true;
            this.colItem_Name.VisibleIndex = 2;
            this.colItem_Name.Width = 139;
            // 
            // colItem_Quantity
            // 
            this.colItem_Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.colItem_Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colItem_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem_Quantity.Caption = "Item Quantity";
            this.colItem_Quantity.FieldName = "Item_Quantity";
            this.colItem_Quantity.Name = "colItem_Quantity";
            this.colItem_Quantity.Visible = true;
            this.colItem_Quantity.VisibleIndex = 3;
            this.colItem_Quantity.Width = 101;
            // 
            // colPayed_Value
            // 
            this.colPayed_Value.AppearanceCell.Options.UseTextOptions = true;
            this.colPayed_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayed_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayed_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayed_Value.Caption = "Payed Value";
            this.colPayed_Value.FieldName = "Payed_Value";
            this.colPayed_Value.Name = "colPayed_Value";
            this.colPayed_Value.Visible = true;
            this.colPayed_Value.VisibleIndex = 4;
            this.colPayed_Value.Width = 84;
            // 
            // colRemain_Value
            // 
            this.colRemain_Value.AppearanceCell.Options.UseTextOptions = true;
            this.colRemain_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemain_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemain_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemain_Value.Caption = "Remain Value";
            this.colRemain_Value.FieldName = "Remain_Value";
            this.colRemain_Value.Name = "colRemain_Value";
            this.colRemain_Value.Visible = true;
            this.colRemain_Value.VisibleIndex = 5;
            this.colRemain_Value.Width = 99;
            // 
            // colDate_Payed
            // 
            this.colDate_Payed.AppearanceCell.Options.UseTextOptions = true;
            this.colDate_Payed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Payed.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate_Payed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate_Payed.Caption = "Date Payed";
            this.colDate_Payed.FieldName = "Date_Payed";
            this.colDate_Payed.Name = "colDate_Payed";
            this.colDate_Payed.Visible = true;
            this.colDate_Payed.VisibleIndex = 6;
            this.colDate_Payed.Width = 109;
            // 
            // colSales_Price
            // 
            this.colSales_Price.AppearanceCell.Options.UseTextOptions = true;
            this.colSales_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.colSales_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_Price.Caption = "Sales Price";
            this.colSales_Price.FieldName = "Sales_Price";
            this.colSales_Price.Name = "colSales_Price";
            this.colSales_Price.Visible = true;
            this.colSales_Price.VisibleIndex = 7;
            this.colSales_Price.Width = 100;
            // 
            // colTotal_Value
            // 
            this.colTotal_Value.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal_Value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Value.Caption = "Total Value";
            this.colTotal_Value.FieldName = "Total_Value";
            this.colTotal_Value.Name = "colTotal_Value";
            this.colTotal_Value.Visible = true;
            this.colTotal_Value.VisibleIndex = 8;
            this.colTotal_Value.Width = 70;
            // 
            // colCust_Debit
            // 
            this.colCust_Debit.AppearanceCell.Options.UseTextOptions = true;
            this.colCust_Debit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCust_Debit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCust_Debit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCust_Debit.Caption = " Debit Customer";
            this.colCust_Debit.FieldName = "Cust_Debit";
            this.colCust_Debit.Name = "colCust_Debit";
            this.colCust_Debit.Visible = true;
            this.colCust_Debit.VisibleIndex = 9;
            this.colCust_Debit.Width = 90;
            // 
            // BtnPrint
            // 
            this.BtnPrint.ImageOptions.Image = global::Library.Properties.Resources.printer_32x322;
            this.BtnPrint.Location = new System.Drawing.Point(1149, 476);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(76, 22);
            this.BtnPrint.StyleController = this.layoutControl1;
            this.BtnPrint.TabIndex = 4;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1237, 510);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnPrint;
            this.layoutControlItem1.Location = new System.Drawing.Point(1137, 464);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Dgv_Shearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1217, 464);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 464);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1137, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Frm_CustActionsRp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 510);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.LargeImage = global::Library.Properties.Resources.meeting_32x321;
            this.Name = "Frm_CustActionsRp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cutomers Actions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Repo1tr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Shearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
     
        private DevExpress.XtraGrid.Columns.GridColumn colCust_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPayed_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colRemain_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Payed;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colCust_Debit;
        public DevExpress.XtraGrid.GridControl Dgv_Shearch;
    }
}
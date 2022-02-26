
namespace Library.Reports
{
    partial class Report_BillPrucheses
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_BillPrucheses));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.ds_Report1 = new Library.Reports.Ds_Report();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.heartLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.thankYouLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaptionCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.summariesTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalCaptionRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDueDateCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDueDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ds_Report1
            // 
            this.ds_Report1.DataSetName = "Ds_Report";
            this.ds_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataSource = typeof(Library.Reports.Ds_Report.BillPurchasesDataTable);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Library.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "VendorsActions";
            storedProcQuery1.StoredProcName = "VendorsActions";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            // 
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(45)))), ((int)(((byte)(187)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(45)))), ((int)(((byte)(187)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.White;
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Library.Properties.Settings.ConnectionString";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery2.Name = "Sp_MainPurchasesSelectMax";
            storedProcQuery2.StoredProcName = "Sp_MainPurchasesSelectMax";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.heartLabel,
            this.thankYouLabel,
            this.detailTable,
            this.headerTable,
            this.summariesTable,
            this.customerTable,
            this.invoiceLabel});
            this.Detail.HeightF = 367.5001F;
            this.Detail.Name = "Detail";
            // 
            // heartLabel
            // 
            this.heartLabel.CanGrow = false;
            this.heartLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.heartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(78)))));
            this.heartLabel.LocationFloat = new DevExpress.Utils.PointFloat(267.7487F, 60.00001F);
            this.heartLabel.Name = "heartLabel";
            this.heartLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.heartLabel.SizeF = new System.Drawing.SizeF(39.54286F, 40F);
            this.heartLabel.StylePriority.UseFont = false;
            this.heartLabel.StylePriority.UseForeColor = false;
            this.heartLabel.StylePriority.UseTextAlignment = false;
            this.heartLabel.Text = "♥";
            this.heartLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.CanGrow = false;
            this.thankYouLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.thankYouLabel.LocationFloat = new DevExpress.Utils.PointFloat(307.2916F, 60.00001F);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thankYouLabel.SizeF = new System.Drawing.SizeF(110.4167F, 40F);
            this.thankYouLabel.StylePriority.UseFont = false;
            this.thankYouLabel.StylePriority.UseTextAlignment = false;
            this.thankYouLabel.Text = "Thank you!";
            this.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // detailTable
            // 
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 331.8751F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(664.9999F, 35F);
            this.detailTable.StylePriority.UseFont = false;
            this.detailTable.StylePriority.UsePadding = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.quantity,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 12.343333333333334D;
            // 
            // productName
            // 
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item_Name]")});
            this.productName.Name = "productName";
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.Text = "ProductName";
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.productName.Weight = 0.71028378654653124D;
            // 
            // quantity
            // 
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item_Quantity]")});
            this.quantity.Name = "quantity";
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.quantity.Weight = 0.62668793796952271D;
            // 
            // unitPrice
            // 
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Purchases_Price]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "ج.م‏ 000";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.58558154408248364D;
            // 
            // lineTotal
            // 
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total_Value]")});
            this.lineTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(78)))));
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "ج.م‏ 000";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.59879104099203351D;
            // 
            // headerTable
            // 
            this.headerTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(194)))));
            this.headerTable.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.headerTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 296.0417F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(664.9999F, 32F);
            this.headerTable.StylePriority.UseBorderColor = false;
            this.headerTable.StylePriority.UseBorders = false;
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UseForeColor = false;
            this.headerTable.StylePriority.UsePadding = false;
            this.headerTable.StylePriority.UseTextAlignment = false;
            this.headerTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productNameCaption,
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaptionCell});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.StylePriority.UseFont = false;
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.Text = "Product Name";
            this.productNameCaption.Weight = 0.70035292588945464D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseFont = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Item Quantity";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.quantityCaption.Weight = 0.617924947872753D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseFont = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "Purchases Price";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.unitPriceCaption.Weight = 0.57718355977821034D;
            // 
            // lineTotalCaptionCell
            // 
            this.lineTotalCaptionCell.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lineTotalCaptionCell.Name = "lineTotalCaptionCell";
            this.lineTotalCaptionCell.StylePriority.UseFont = false;
            this.lineTotalCaptionCell.StylePriority.UseTextAlignment = false;
            this.lineTotalCaptionCell.Text = "Total Value";
            this.lineTotalCaptionCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lineTotalCaptionCell.Weight = 0.59062889787939155D;
            // 
            // summariesTable
            // 
            this.summariesTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(194)))));
            this.summariesTable.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.summariesTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(86)))), ((int)(((byte)(85)))));
            this.summariesTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 181.0417F);
            this.summariesTable.Name = "summariesTable";
            this.summariesTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalCaptionRow,
            this.totalRow});
            this.summariesTable.SizeF = new System.Drawing.SizeF(665F, 115F);
            this.summariesTable.StylePriority.UseBorderColor = false;
            this.summariesTable.StylePriority.UseBorders = false;
            this.summariesTable.StylePriority.UseForeColor = false;
            // 
            // totalCaptionRow
            // 
            this.totalCaptionRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceDueDateCaption,
            this.xrTableCell2,
            this.totalCaption});
            this.totalCaptionRow.Name = "totalCaptionRow";
            this.totalCaptionRow.Weight = 1D;
            // 
            // invoiceDueDateCaption
            // 
            this.invoiceDueDateCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.invoiceDueDateCaption.Name = "invoiceDueDateCaption";
            this.invoiceDueDateCaption.StylePriority.UseFont = false;
            this.invoiceDueDateCaption.StylePriority.UseForeColor = false;
            this.invoiceDueDateCaption.StylePriority.UseTextAlignment = false;
            this.invoiceDueDateCaption.Text = "Purchases Date";
            this.invoiceDueDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.invoiceDueDateCaption.Weight = 1.3920881192728505D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Payed Value";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 1.229225468739064D;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UseForeColor = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "Remain Value";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.totalCaption.TextFormatString = "{0:$0.00}";
            this.totalCaption.Weight = 1.2294916613914029D;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceDueDate,
            this.xrTableCell3,
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 3.6000000584920282D;
            // 
            // invoiceDueDate
            // 
            this.invoiceDueDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Purchases_Date]")});
            this.invoiceDueDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.invoiceDueDate.ForeColor = System.Drawing.Color.Black;
            this.invoiceDueDate.Name = "invoiceDueDate";
            this.invoiceDueDate.StylePriority.UseFont = false;
            this.invoiceDueDate.StylePriority.UseForeColor = false;
            this.invoiceDueDate.StylePriority.UseTextAlignment = false;
            this.invoiceDueDate.Text = "InvoiceDueDate";
            this.invoiceDueDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.invoiceDueDate.TextFormatString = "{0:dddd, dd MMMM, yyyy hh:mm tt}";
            this.invoiceDueDate.Weight = 1.3920881192728505D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Payed_Value]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1.2292254687390638D;
            // 
            // total
            // 
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Remain_Value]")});
            this.total.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(78)))));
            this.total.Name = "total";
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseForeColor = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "ج.م‏ 000";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.total.TextFormatString = "{0:$0.00}";
            this.total.Weight = 1.2294916613914027D;
            // 
            // customerTable
            // 
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(14.99456F, 125.4168F);
            this.customerTable.Name = "customerTable";
            this.customerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.customerNameRow});
            this.customerTable.SizeF = new System.Drawing.SizeF(592.1352F, 25F);
            // 
            // customerNameRow
            // 
            this.customerNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerName,
            this.xrTableCell1});
            this.customerNameRow.Name = "customerNameRow";
            this.customerNameRow.Weight = 1D;
            // 
            // customerName
            // 
            this.customerName.CanShrink = true;
            this.customerName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.customerName.Name = "customerName";
            this.customerName.StylePriority.UseFont = false;
            this.customerName.StylePriority.UsePadding = false;
            this.customerName.Text = "Vendor Name:";
            this.customerName.Weight = 0.80261573993298541D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "  [Ven_Name]")});
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 2.706722200949649D;
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.LocationFloat = new DevExpress.Utils.PointFloat(160.7874F, 0F);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.invoiceLabel.SizeF = new System.Drawing.SizeF(373.366F, 50F);
            this.invoiceLabel.StylePriority.UseFont = false;
            this.invoiceLabel.StylePriority.UseTextAlignment = false;
            this.invoiceLabel.Text = "INVOICE PURCHASES";
            this.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Report_BillPrucheses
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource2});
            this.DataMember = "Sp_MainPurchasesSelectMax";
            this.DataSource = this.sqlDataSource2;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(95, 88, 0, 0);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.GroupFooterBackground3,
            this.PageInfo,
            this.xrControlStyle1});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.ds_Report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private Ds_Report ds_Report1;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel heartLabel;
        private DevExpress.XtraReports.UI.XRLabel thankYouLabel;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaptionCell;
        private DevExpress.XtraReports.UI.XRTable summariesTable;
        private DevExpress.XtraReports.UI.XRTableRow totalCaptionRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDateCaption;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDate;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel invoiceLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    }
}

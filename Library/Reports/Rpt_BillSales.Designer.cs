
namespace Library.Reports
{
    partial class Rpt_BillSales
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_BillSales));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.invoiceLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.summariesTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalCaptionRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDueDateCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDueDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaptionCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.thankYouLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.heartLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceLabel,
            this.customerTable,
            this.summariesTable,
            this.headerTable,
            this.detailTable,
            this.thankYouLabel,
            this.heartLabel});
            this.Detail.HeightF = 367.9167F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 11F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Library.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Sp_MainSalesSelectMax";
            storedProcQuery1.StoredProcName = "Sp_MainSalesSelectMax";
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
            // invoiceLabel
            // 
            this.invoiceLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.LocationFloat = new DevExpress.Utils.PointFloat(187.336F, 0F);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.invoiceLabel.SizeF = new System.Drawing.SizeF(284.3171F, 50F);
            this.invoiceLabel.StylePriority.UseFont = false;
            this.invoiceLabel.StylePriority.UseTextAlignment = false;
            this.invoiceLabel.Text = "INVOICE SALES";
            this.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // customerTable
            // 
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(12.91119F, 125.4168F);
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
            this.customerName.Text = "Customer Name:";
            this.customerName.Weight = 0.96583440913552765D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "  [Cust_Name]")});
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 2.5435035317471062D;
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
            this.summariesTable.SizeF = new System.Drawing.SizeF(663.0001F, 115F);
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
            this.invoiceDueDateCaption.Text = "Sales Date";
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
            this.totalCaption.Weight = 1.2179106456556035D;
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sales_Date]")});
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
            this.total.Weight = 1.2179106456556035D;
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
            this.headerTable.SizeF = new System.Drawing.SizeF(663F, 32F);
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
            this.unitPriceCaption.Text = "Sales Price";
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
            this.lineTotalCaptionCell.Weight = 0.58315238946183423D;
            // 
            // detailTable
            // 
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 331.8751F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(663F, 35F);
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sales_Price]")});
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
            this.lineTotal.Weight = 0.59120851202437186D;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.CanGrow = false;
            this.thankYouLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.thankYouLabel.LocationFloat = new DevExpress.Utils.PointFloat(305.2083F, 60.00001F);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thankYouLabel.SizeF = new System.Drawing.SizeF(110.4167F, 40F);
            this.thankYouLabel.StylePriority.UseFont = false;
            this.thankYouLabel.StylePriority.UseTextAlignment = false;
            this.thankYouLabel.Text = "Thank you!";
            this.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // heartLabel
            // 
            this.heartLabel.CanGrow = false;
            this.heartLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.heartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(102)))), ((int)(((byte)(78)))));
            this.heartLabel.LocationFloat = new DevExpress.Utils.PointFloat(265.6653F, 60.00001F);
            this.heartLabel.Name = "heartLabel";
            this.heartLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.heartLabel.SizeF = new System.Drawing.SizeF(39.54286F, 40F);
            this.heartLabel.StylePriority.UseFont = false;
            this.heartLabel.StylePriority.UseForeColor = false;
            this.heartLabel.StylePriority.UseTextAlignment = false;
            this.heartLabel.Text = "♥";
            this.heartLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Rpt_BillSales
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Sp_MainSalesSelectMax";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(94, 93, 11, 0);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRLabel invoiceLabel;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTable summariesTable;
        private DevExpress.XtraReports.UI.XRTableRow totalCaptionRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDateCaption;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDate;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaptionCell;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRLabel thankYouLabel;
        private DevExpress.XtraReports.UI.XRLabel heartLabel;
    }
}

namespace ProductSaleReports
{
    partial class ProductSaleReports
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSaleReports));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.StartDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.EndDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.UNITPRICE = new DevExpress.XtraReports.UI.XRLabel();
            this.QUANTITY = new DevExpress.XtraReports.UI.XRLabel();
            this.PRODUCTNAME = new DevExpress.XtraReports.UI.XRLabel();
            this.PRODUCTCODE = new DevExpress.XtraReports.UI.XRLabel();
            this.SALEDATE = new DevExpress.XtraReports.UI.XRLabel();
            this.TOTAL = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 3.125F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_ProductSalesDB_Connection 2";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "P_GetProductSales";
            queryParameter1.Name = "@StartDate";
            queryParameter1.Type = typeof(System.DateOnly);
            queryParameter2.Name = "@EndDate";
            queryParameter2.Type = typeof(System.DateOnly);
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "P_GetProductSales";
            columnExpression1.ColumnName = "SALEID";
            table1.Name = "PRODUCTSALES";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "PRODUCTCODE";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "PRODUCTNAME";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "QUANTITY";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "UNITPRICE";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "SALEDATE";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Name = "PRODUCTSALES";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.StartDate,
            this.xrLabel2,
            this.EndDate,
            this.xrLabel3,
            this.xrLabel1});
            this.ReportHeader.HeightF = 186.4583F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.BorderWidth = 10F;
            this.xrPictureBox1.ImageUrl = "C:\\Users\\layvi\\Downloads\\photo_2024-07-10_11-57-19.jpg";
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(286.4583F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(166.4855F, 95.9649F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Cover;
            this.xrPictureBox1.StylePriority.UseBorderWidth = false;
            // 
            // StartDate
            // 
            this.StartDate.Font = new DevExpress.Drawing.DXFont("Khmer OS Siemreap", 14F);
            this.StartDate.LocationFloat = new DevExpress.Utils.PointFloat(114.5833F, 145.125F);
            this.StartDate.Multiline = true;
            this.StartDate.Name = "StartDate";
            this.StartDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.StartDate.SizeF = new System.Drawing.SizeF(171.875F, 31.33334F);
            this.StartDate.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Khmer OS Siemreap", 14F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 145.125F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(114.5834F, 31.33334F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "ចាប់ពីថ្ងៃទី :";
            // 
            // EndDate
            // 
            this.EndDate.Font = new DevExpress.Drawing.DXFont("Khmer OS Siemreap", 14F);
            this.EndDate.LocationFloat = new DevExpress.Utils.PointFloat(615.2084F, 145.125F);
            this.EndDate.Multiline = true;
            this.EndDate.Name = "EndDate";
            this.EndDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.EndDate.SizeF = new System.Drawing.SizeF(158.3333F, 31.33334F);
            this.EndDate.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Khmer OS Siemreap", 14F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(500.625F, 145.125F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(114.5834F, 31.33334F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "ដល់ថ្ងៃទី :";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Khmer OS Siemreap", 14F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(300.4141F, 111.5899F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(140.625F, 31.33334F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "របាយការណ៏ លក់";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.BorderWidth = 1F;
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel4});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.HeightF = 55.20843F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PrintAcrossBands = true;
            this.GroupHeader1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderWidth = 2F;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(132.2917F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(123.9584F, 23F);
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "PRODUCTNAME";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderWidth = 2F;
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(674.0139F, 0F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(87.5F, 23F);
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "TOTAL";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderWidth = 2F;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(492.2431F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(152.257F, 23F);
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "SALEDATE";
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderWidth = 2F;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(382.9167F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(87.5F, 23F);
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "UNITPRICE";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderWidth = 2F;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(286.4584F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(87.5F, 23F);
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "QUANTITY";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderWidth = 2F;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(114.5833F, 23F);
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "PRODUCTCODE";
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TOTAL])")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(674.0139F, 9.999974F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(87.5F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel10.Summary = xrSummary1;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // UNITPRICE
            // 
            this.UNITPRICE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.UNITPRICE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SALEDATE]")});
            this.UNITPRICE.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.UNITPRICE.LocationFloat = new DevExpress.Utils.PointFloat(500.625F, 43.33334F);
            this.UNITPRICE.Multiline = true;
            this.UNITPRICE.Name = "UNITPRICE";
            this.UNITPRICE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.UNITPRICE.SizeF = new System.Drawing.SizeF(143.8751F, 23F);
            this.UNITPRICE.StylePriority.UseBorders = false;
            this.UNITPRICE.StylePriority.UseFont = false;
            this.UNITPRICE.StylePriority.UsePadding = false;
            // 
            // QUANTITY
            // 
            this.QUANTITY.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.QUANTITY.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QUANTITY]")});
            this.QUANTITY.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.QUANTITY.LocationFloat = new DevExpress.Utils.PointFloat(286.4584F, 43.33334F);
            this.QUANTITY.Multiline = true;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.QUANTITY.SizeF = new System.Drawing.SizeF(87.50003F, 23F);
            this.QUANTITY.StylePriority.UseBorders = false;
            this.QUANTITY.StylePriority.UseFont = false;
            this.QUANTITY.StylePriority.UsePadding = false;
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PRODUCTNAME.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PRODUCTNAME]")});
            this.PRODUCTNAME.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.PRODUCTNAME.LocationFloat = new DevExpress.Utils.PointFloat(132.2917F, 43.33334F);
            this.PRODUCTNAME.Multiline = true;
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.PRODUCTNAME.SizeF = new System.Drawing.SizeF(123.9583F, 23F);
            this.PRODUCTNAME.StylePriority.UseBorders = false;
            this.PRODUCTNAME.StylePriority.UseFont = false;
            this.PRODUCTNAME.StylePriority.UsePadding = false;
            // 
            // PRODUCTCODE
            // 
            this.PRODUCTCODE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PRODUCTCODE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PRODUCTCODE]")});
            this.PRODUCTCODE.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.PRODUCTCODE.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 43.33334F);
            this.PRODUCTCODE.Multiline = true;
            this.PRODUCTCODE.Name = "PRODUCTCODE";
            this.PRODUCTCODE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.PRODUCTCODE.SizeF = new System.Drawing.SizeF(114.5833F, 23F);
            this.PRODUCTCODE.StylePriority.UseBorders = false;
            this.PRODUCTCODE.StylePriority.UseFont = false;
            this.PRODUCTCODE.StylePriority.UsePadding = false;
            xrSummary2.TreatStringsAsNumerics = false;
            this.PRODUCTCODE.Summary = xrSummary2;
            // 
            // SALEDATE
            // 
            this.SALEDATE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SALEDATE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UNITPRICE]")});
            this.SALEDATE.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.SALEDATE.LocationFloat = new DevExpress.Utils.PointFloat(382.9167F, 43.33334F);
            this.SALEDATE.Multiline = true;
            this.SALEDATE.Name = "SALEDATE";
            this.SALEDATE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.SALEDATE.SizeF = new System.Drawing.SizeF(70.02719F, 23F);
            this.SALEDATE.StylePriority.UseBorders = false;
            this.SALEDATE.StylePriority.UseFont = false;
            this.SALEDATE.StylePriority.UsePadding = false;
            this.SALEDATE.TextFormatString = "{0:$0.00}";
            // 
            // TOTAL
            // 
            this.TOTAL.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TOTAL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QUANTITY] *[UNITPRICE]")});
            this.TOTAL.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.TOTAL.LocationFloat = new DevExpress.Utils.PointFloat(674.0139F, 43.33334F);
            this.TOTAL.Multiline = true;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.TOTAL.SizeF = new System.Drawing.SizeF(87.5F, 23F);
            this.TOTAL.StylePriority.UseBorders = false;
            this.TOTAL.StylePriority.UseFont = false;
            this.TOTAL.StylePriority.UsePadding = false;
            this.TOTAL.TextFormatString = "{0:$0}";
            // 
            // Detail
            // 
            this.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.Detail.BorderWidth = 1F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TOTAL,
            this.SALEDATE,
            this.PRODUCTCODE,
            this.PRODUCTNAME,
            this.QUANTITY,
            this.UNITPRICE});
            this.Detail.DrillDownExpanded = false;
            this.Detail.HeightF = 81.69645F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PRODUCTCODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.StylePriority.UsePadding = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BorderWidth = 2F;
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(500.625F, 10.00002F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(152.257F, 23F);
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "TOTAL SALE: ";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel11});
            this.ReportFooter.HeightF = 73.51189F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // ProductSaleReports
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.GroupHeader1,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.DataMember = "P_GetProductSales";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            this.Margins = new DevExpress.Drawing.DXMargins(27F, 21F, 3.125F, 0F);
            this.Version = "25.1";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel StartDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel EndDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraReports.UI.XRLabel UNITPRICE;
        private DevExpress.XtraReports.UI.XRLabel QUANTITY;
        private DevExpress.XtraReports.UI.XRLabel PRODUCTNAME;
        private DevExpress.XtraReports.UI.XRLabel PRODUCTCODE;
        private DevExpress.XtraReports.UI.XRLabel SALEDATE;
        private DevExpress.XtraReports.UI.XRLabel TOTAL;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    }
}

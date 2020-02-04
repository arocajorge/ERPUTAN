namespace Cus.Erp.Reports.Cidersus
{
    partial class XRpt_prd_CodigoBarraProductoTerminado
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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.winControlContainer4 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.winControlContainer3 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.winControlContainer2 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.xrPictureBox1 = new System.Windows.Forms.PictureBox();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodigoObra = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 0;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCodigoObra,
            this.winControlContainer4,
            this.winControlContainer3,
            this.winControlContainer2,
            this.winControlContainer1,
            this.xrLabel3,
            this.xrLabel2,
            this.xrBarCode1,
            this.xrLabel1});
            this.Detail.HeightF = 123.3749F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // winControlContainer4
            // 
            this.winControlContainer4.LocationFloat = new DevExpress.Utils.PointFloat(136F, 27.04167F);
            this.winControlContainer4.Name = "winControlContainer4";
            this.winControlContainer4.SizeF = new System.Drawing.SizeF(34F, 12F);
            this.winControlContainer4.WinControl = this.label3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Obra:";
            // 
            // winControlContainer3
            // 
            this.winControlContainer3.LocationFloat = new DevExpress.Utils.PointFloat(136F, 3.041665F);
            this.winControlContainer3.Name = "winControlContainer3";
            this.winControlContainer3.SizeF = new System.Drawing.SizeF(47F, 12F);
            this.winControlContainer3.WinControl = this.label2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // winControlContainer2
            // 
            this.winControlContainer2.LocationFloat = new DevExpress.Utils.PointFloat(136F, 51.04168F);
            this.winControlContainer2.Name = "winControlContainer2";
            this.winControlContainer2.SizeF = new System.Drawing.SizeF(62F, 12F);
            this.winControlContainer2.WinControl = this.label1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prdoducto:";
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(29.79167F, 78.08334F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(186.5417F, 45.29153F);
            this.winControlContainer1.WinControl = this.xrPictureBox1;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.Size = new System.Drawing.Size(179, 43);
            this.xrPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xrPictureBox1.TabIndex = 0;
            this.xrPictureBox1.TabStop = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "obra")});
            this.xrLabel3.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(136F, 39.04168F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(111F, 12F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fa_Cliente")});
            this.xrLabel2.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(136F, 15.04167F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(111F, 12F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CodigoBarra")});
            this.xrBarCode1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(136F, 75.04167F);
            this.xrBarCode1.StylePriority.UseFont = false;
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = qrCodeGenerator1;
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pr_descripcion")});
            this.xrLabel1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(136F, 63.04169F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(111F, 11.99998F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 3.125F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.in_movi_inve_detalle_x_Producto_CusCider_Info);
            // 
            // lblCodigoObra
            // 
            this.lblCodigoObra.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ot_CodObra")});
            this.lblCodigoObra.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoObra.LocationFloat = new DevExpress.Utils.PointFloat(176F, 27.04169F);
            this.lblCodigoObra.Name = "lblCodigoObra";
            this.lblCodigoObra.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lblCodigoObra.SizeF = new System.Drawing.SizeF(54.08334F, 12F);
            this.lblCodigoObra.StylePriority.UseFont = false;
            this.lblCodigoObra.StylePriority.UseTextAlignment = false;
            this.lblCodigoObra.Text = "lblCodigoObra";
            this.lblCodigoObra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XRpt_prd_CodigoBarraProductoTerminado
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataSource = this.bindingSource1;
            this.DefaultPrinterSettingsUsing.UseLandscape = true;
            this.Margins = new System.Drawing.Printing.Margins(5, 10, 0, 3);
            this.PageHeight = 157;
            this.PageWidth = 272;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private System.Windows.Forms.PictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraReports.UI.XRLabel lblCodigoObra;
    }
}

namespace Cus.Erp.Reports.FJ.CuentasxPagar
{
    partial class XCXP_FJ_Rpt001_Rpt
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.idSucursalOrigen = new DevExpress.XtraReports.Parameters.Parameter();
            this.idBodegaOrigen = new DevExpress.XtraReports.Parameters.Parameter();
            this.idTransferencia = new DevExpress.XtraReports.Parameters.Parameter();
            this.idSucursalDest = new DevExpress.XtraReports.Parameters.Parameter();
            this.idBodegaDest = new DevExpress.XtraReports.Parameters.Parameter();
            this.idGuia = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.DEVOLUCION = new DevExpress.XtraReports.UI.XRLabel();
            this.IMPORTACION = new DevExpress.XtraReports.UI.XRLabel();
            this.EXPORTACION = new DevExpress.XtraReports.UI.XRLabel();
            this.OTROS = new DevExpress.XtraReports.UI.XRLabel();
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA = new DevExpress.XtraReports.UI.XRLabel();
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA = new DevExpress.XtraReports.UI.XRLabel();
            this.CONSIGNACION = new DevExpress.XtraReports.UI.XRLabel();
            this.TRANSFORMACION = new DevExpress.XtraReports.UI.XRLabel();
            this.COMPRA = new DevExpress.XtraReports.UI.XRLabel();
            this.VENTA = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRuc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRazonSocialEmpresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel8});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cantidad")});
            this.xrLabel9.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(85.41666F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pr_descripcion")});
            this.xrLabel8.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(350.0001F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(411.4583F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 110.4167F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // idSucursalOrigen
            // 
            this.idSucursalOrigen.Name = "idSucursalOrigen";
            this.idSucursalOrigen.Type = typeof(int);
            this.idSucursalOrigen.Visible = false;
            // 
            // idBodegaOrigen
            // 
            this.idBodegaOrigen.Name = "idBodegaOrigen";
            this.idBodegaOrigen.Type = typeof(int);
            this.idBodegaOrigen.Visible = false;
            // 
            // idTransferencia
            // 
            this.idTransferencia.Name = "idTransferencia";
            this.idTransferencia.Type = typeof(decimal);
            this.idTransferencia.Visible = false;
            // 
            // idSucursalDest
            // 
            this.idSucursalDest.Name = "idSucursalDest";
            this.idSucursalDest.Type = typeof(int);
            this.idSucursalDest.Visible = false;
            // 
            // idBodegaDest
            // 
            this.idBodegaDest.Name = "idBodegaDest";
            this.idBodegaDest.Type = typeof(int);
            this.idBodegaDest.Visible = false;
            // 
            // idGuia
            // 
            this.idGuia.Name = "idGuia";
            this.idGuia.Type = typeof(decimal);
            this.idGuia.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.DEVOLUCION,
            this.IMPORTACION,
            this.EXPORTACION,
            this.OTROS,
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA,
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA,
            this.CONSIGNACION,
            this.TRANSFORMACION,
            this.COMPRA,
            this.VENTA,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.ReportHeader.HeightF = 155.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // DEVOLUCION
            // 
            this.DEVOLUCION.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.DEVOLUCION.LocationFloat = new DevExpress.Utils.PointFloat(629.6458F, 63.49996F);
            this.DEVOLUCION.Name = "DEVOLUCION";
            this.DEVOLUCION.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DEVOLUCION.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.DEVOLUCION.StylePriority.UseFont = false;
            this.DEVOLUCION.StylePriority.UseTextAlignment = false;
            this.DEVOLUCION.Text = "X";
            this.DEVOLUCION.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.DEVOLUCION.Visible = false;
            // 
            // IMPORTACION
            // 
            this.IMPORTACION.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.IMPORTACION.LocationFloat = new DevExpress.Utils.PointFloat(629.6458F, 86.49998F);
            this.IMPORTACION.Name = "IMPORTACION";
            this.IMPORTACION.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.IMPORTACION.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.IMPORTACION.StylePriority.UseFont = false;
            this.IMPORTACION.StylePriority.UseTextAlignment = false;
            this.IMPORTACION.Text = "X";
            this.IMPORTACION.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.IMPORTACION.Visible = false;
            // 
            // EXPORTACION
            // 
            this.EXPORTACION.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.EXPORTACION.LocationFloat = new DevExpress.Utils.PointFloat(629.6459F, 109.5F);
            this.EXPORTACION.Name = "EXPORTACION";
            this.EXPORTACION.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.EXPORTACION.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.EXPORTACION.StylePriority.UseFont = false;
            this.EXPORTACION.StylePriority.UseTextAlignment = false;
            this.EXPORTACION.Text = "X";
            this.EXPORTACION.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.EXPORTACION.Visible = false;
            // 
            // OTROS
            // 
            this.OTROS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.OTROS.LocationFloat = new DevExpress.Utils.PointFloat(629.6458F, 132.5F);
            this.OTROS.Name = "OTROS";
            this.OTROS.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.OTROS.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.OTROS.StylePriority.UseFont = false;
            this.OTROS.StylePriority.UseTextAlignment = false;
            this.OTROS.Text = "X";
            this.OTROS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.OTROS.Visible = false;
            // 
            // TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA
            // 
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.LocationFloat = new DevExpress.Utils.PointFloat(331.7292F, 63.49999F);
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Name = "TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA";
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.StylePriority.UseFont = false;
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.StylePriority.UseTextAlignment = false;
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Text = "X";
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Visible = false;
            // 
            // TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA
            // 
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.LocationFloat = new DevExpress.Utils.PointFloat(331.7292F, 109.5F);
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Name = "TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA";
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.StylePriority.UseFont = false;
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.StylePriority.UseTextAlignment = false;
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Text = "X";
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Visible = false;
            // 
            // CONSIGNACION
            // 
            this.CONSIGNACION.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.CONSIGNACION.LocationFloat = new DevExpress.Utils.PointFloat(95.83334F, 132.5F);
            this.CONSIGNACION.Name = "CONSIGNACION";
            this.CONSIGNACION.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CONSIGNACION.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.CONSIGNACION.StylePriority.UseFont = false;
            this.CONSIGNACION.StylePriority.UseTextAlignment = false;
            this.CONSIGNACION.Text = "X";
            this.CONSIGNACION.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.CONSIGNACION.Visible = false;
            // 
            // TRANSFORMACION
            // 
            this.TRANSFORMACION.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TRANSFORMACION.LocationFloat = new DevExpress.Utils.PointFloat(95.8334F, 109.5F);
            this.TRANSFORMACION.Name = "TRANSFORMACION";
            this.TRANSFORMACION.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TRANSFORMACION.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.TRANSFORMACION.StylePriority.UseFont = false;
            this.TRANSFORMACION.StylePriority.UseTextAlignment = false;
            this.TRANSFORMACION.Text = "X";
            this.TRANSFORMACION.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TRANSFORMACION.Visible = false;
            // 
            // COMPRA
            // 
            this.COMPRA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.COMPRA.LocationFloat = new DevExpress.Utils.PointFloat(95.83334F, 86.50001F);
            this.COMPRA.Name = "COMPRA";
            this.COMPRA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.COMPRA.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.COMPRA.StylePriority.UseFont = false;
            this.COMPRA.StylePriority.UseTextAlignment = false;
            this.COMPRA.Text = "X";
            this.COMPRA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.COMPRA.Visible = false;
            // 
            // VENTA
            // 
            this.VENTA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.VENTA.LocationFloat = new DevExpress.Utils.PointFloat(95.83334F, 63.49999F);
            this.VENTA.Name = "VENTA";
            this.VENTA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.VENTA.SizeF = new System.Drawing.SizeF(21.875F, 23F);
            this.VENTA.StylePriority.UseFont = false;
            this.VENTA.StylePriority.UseTextAlignment = false;
            this.VENTA.Text = "X";
            this.VENTA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.VENTA.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Fecha")});
            this.xrLabel3.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(240.6251F, 34.54164F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(144.7916F, 16.74999F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Fecha_llegada")});
            this.xrLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(240.625F, 16.74999F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(144.7917F, 16.75F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Fecha_Traslado")});
            this.xrLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(240.6251F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(144.7917F, 16.75F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.lblRuc,
            this.lblRazonSocialEmpresa,
            this.xrLabel5,
            this.xrLabel4});
            this.PageHeader.HeightF = 185.4167F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Cedula")});
            this.xrLabel7.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(575.7086F, 87.54164F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(185.7497F, 12.58333F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel7";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Nombre")});
            this.xrLabel6.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(575.7085F, 74.95833F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(185.7499F, 12.58333F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblRuc
            // 
            this.lblRuc.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblRuc.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 87.54164F);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRuc.SizeF = new System.Drawing.SizeF(100F, 12.58334F);
            this.lblRuc.StylePriority.UseFont = false;
            this.lblRuc.StylePriority.UseTextAlignment = false;
            this.lblRuc.Text = "Ruc";
            this.lblRuc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblRazonSocialEmpresa
            // 
            this.lblRazonSocialEmpresa.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblRazonSocialEmpresa.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 74.95833F);
            this.lblRazonSocialEmpresa.Name = "lblRazonSocialEmpresa";
            this.lblRazonSocialEmpresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRazonSocialEmpresa.SizeF = new System.Drawing.SizeF(100F, 12.58333F);
            this.lblRazonSocialEmpresa.StylePriority.UseFont = false;
            this.lblRazonSocialEmpresa.StylePriority.UseTextAlignment = false;
            this.lblRazonSocialEmpresa.Text = "RazonSocial";
            this.lblRazonSocialEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Direc_sucu_Partida")});
            this.xrLabel5.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(129.1667F, 22.99999F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(623.9583F, 16.75F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Direc_sucu_Llegada")});
            this.xrLabel4.Font = new System.Drawing.Font("Verdana", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(129.1667F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(623.9583F, 16.75F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Cus.Erp.Reports.FJ.CuentasxPagar.XCXP_FJ_Rpt001_Info);
            // 
            // XCXP_FJ_Rpt001_Rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 110, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.idSucursalOrigen,
            this.idBodegaOrigen,
            this.idTransferencia,
            this.idSucursalDest,
            this.idBodegaDest,
            this.idGuia});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XCXP_FJ_Rpt001_Rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.Parameters.Parameter idSucursalOrigen;
        private DevExpress.XtraReports.Parameters.Parameter idBodegaOrigen;
        private DevExpress.XtraReports.Parameters.Parameter idTransferencia;
        private DevExpress.XtraReports.Parameters.Parameter idSucursalDest;
        private DevExpress.XtraReports.Parameters.Parameter idBodegaDest;
        private DevExpress.XtraReports.Parameters.Parameter idGuia;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel DEVOLUCION;
        private DevExpress.XtraReports.UI.XRLabel IMPORTACION;
        private DevExpress.XtraReports.UI.XRLabel EXPORTACION;
        private DevExpress.XtraReports.UI.XRLabel OTROS;
        private DevExpress.XtraReports.UI.XRLabel TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA;
        private DevExpress.XtraReports.UI.XRLabel TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA;
        private DevExpress.XtraReports.UI.XRLabel CONSIGNACION;
        private DevExpress.XtraReports.UI.XRLabel TRANSFORMACION;
        private DevExpress.XtraReports.UI.XRLabel COMPRA;
        private DevExpress.XtraReports.UI.XRLabel VENTA;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lblRuc;
        private DevExpress.XtraReports.UI.XRLabel lblRazonSocialEmpresa;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    }
}

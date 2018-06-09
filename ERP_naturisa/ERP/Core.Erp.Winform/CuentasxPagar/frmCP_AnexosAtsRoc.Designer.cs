namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_AnexosAtsRoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_anio = new System.Windows.Forms.ComboBox();
            this.cmb_periodo = new System.Windows.Forms.ComboBox();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCompras = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControlCompras = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSustento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRucCed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseIva0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseIva_dif_0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecRetencion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaEmiRet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlRT = new DevExpress.XtraGrid.GridControl();
            this.gridViewRT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFactura_Prov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colced_ruc_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_baseRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_Porcen_retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_valor_retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPageVentas = new System.Windows.Forms.TabPage();
            this.gridControlVentas = new DevExpress.XtraGrid.GridControl();
            this.gridViewVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentifiacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipoComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbaseNoGraIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbaseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbaseImpGrav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontoIvav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorRetIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorRetRenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompras)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRT)).BeginInit();
            this.tabPageVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // cmb_anio
            // 
            this.cmb_anio.FormattingEnabled = true;
            this.cmb_anio.Location = new System.Drawing.Point(51, 17);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Size = new System.Drawing.Size(105, 21);
            this.cmb_anio.TabIndex = 1;
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.FormattingEnabled = true;
            this.cmb_periodo.Location = new System.Drawing.Point(238, 17);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.Size = new System.Drawing.Size(136, 21);
            this.cmb_periodo.TabIndex = 2;
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(421, 6);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(92, 37);
            this.btn_procesar.TabIndex = 5;
            this.btn_procesar.Text = "Generar ATS";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Periodo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompras);
            this.tabControl1.Controls.Add(this.tabPageVentas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 394);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageCompras
            // 
            this.tabPageCompras.Controls.Add(this.splitContainer1);
            this.tabPageCompras.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompras.Name = "tabPageCompras";
            this.tabPageCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompras.Size = new System.Drawing.Size(1063, 368);
            this.tabPageCompras.TabIndex = 0;
            this.tabPageCompras.Text = "Compras";
            this.tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControlCompras);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1057, 362);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 1;
            // 
            // gridControlCompras
            // 
            this.gridControlCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompras.Location = new System.Drawing.Point(0, 0);
            this.gridControlCompras.MainView = this.gridViewCompras;
            this.gridControlCompras.Name = "gridControlCompras";
            this.gridControlCompras.Size = new System.Drawing.Size(1057, 205);
            this.gridControlCompras.TabIndex = 0;
            this.gridControlCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompras});
            // 
            // gridViewCompras
            // 
            this.gridViewCompras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSustento,
            this.colRucCed,
            this.colTipoCbte,
            this.colCbteVta,
            this.colAutorizacion,
            this.colBaseIva0,
            this.colBaseIva_dif_0,
            this.colMontoIva,
            this.colsecRetencion1,
            this.colfechaEmiRet1});
            this.gridViewCompras.GridControl = this.gridControlCompras;
            this.gridViewCompras.Name = "gridViewCompras";
            this.gridViewCompras.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCompras.OptionsView.ShowGroupPanel = false;
            // 
            // colSustento
            // 
            this.colSustento.Caption = "Sustento";
            this.colSustento.FieldName = "codSustento";
            this.colSustento.Name = "colSustento";
            this.colSustento.Visible = true;
            this.colSustento.VisibleIndex = 0;
            this.colSustento.Width = 153;
            // 
            // colRucCed
            // 
            this.colRucCed.Caption = "Ruc/Ced/Pass";
            this.colRucCed.FieldName = "idProv";
            this.colRucCed.Name = "colRucCed";
            this.colRucCed.Visible = true;
            this.colRucCed.VisibleIndex = 1;
            this.colRucCed.Width = 145;
            // 
            // colTipoCbte
            // 
            this.colTipoCbte.Caption = "Tipo Cbte";
            this.colTipoCbte.FieldName = "tipoComprobante";
            this.colTipoCbte.Name = "colTipoCbte";
            this.colTipoCbte.Visible = true;
            this.colTipoCbte.VisibleIndex = 2;
            this.colTipoCbte.Width = 145;
            // 
            // colCbteVta
            // 
            this.colCbteVta.Caption = "#Comprobante";
            this.colCbteVta.FieldName = "secuencial";
            this.colCbteVta.Name = "colCbteVta";
            this.colCbteVta.Visible = true;
            this.colCbteVta.VisibleIndex = 3;
            this.colCbteVta.Width = 145;
            // 
            // colAutorizacion
            // 
            this.colAutorizacion.Caption = "#Autorizacion";
            this.colAutorizacion.FieldName = "autorizacion";
            this.colAutorizacion.Name = "colAutorizacion";
            this.colAutorizacion.Visible = true;
            this.colAutorizacion.VisibleIndex = 4;
            this.colAutorizacion.Width = 145;
            // 
            // colBaseIva0
            // 
            this.colBaseIva0.Caption = "Base Iva0%";
            this.colBaseIva0.FieldName = "baseNoGraIva";
            this.colBaseIva0.Name = "colBaseIva0";
            this.colBaseIva0.Visible = true;
            this.colBaseIva0.VisibleIndex = 5;
            this.colBaseIva0.Width = 145;
            // 
            // colBaseIva_dif_0
            // 
            this.colBaseIva_dif_0.Caption = "Base Iva Dif. 0%";
            this.colBaseIva_dif_0.FieldName = "baseImponible";
            this.colBaseIva_dif_0.Name = "colBaseIva_dif_0";
            this.colBaseIva_dif_0.Visible = true;
            this.colBaseIva_dif_0.VisibleIndex = 6;
            this.colBaseIva_dif_0.Width = 145;
            // 
            // colMontoIva
            // 
            this.colMontoIva.Caption = "$Iva";
            this.colMontoIva.FieldName = "montoIva";
            this.colMontoIva.Name = "colMontoIva";
            this.colMontoIva.Visible = true;
            this.colMontoIva.VisibleIndex = 7;
            this.colMontoIva.Width = 147;
            // 
            // colsecRetencion1
            // 
            this.colsecRetencion1.Caption = "#Retencion";
            this.colsecRetencion1.FieldName = "secRetencion1";
            this.colsecRetencion1.Name = "colsecRetencion1";
            this.colsecRetencion1.Visible = true;
            this.colsecRetencion1.VisibleIndex = 8;
            // 
            // colfechaEmiRet1
            // 
            this.colfechaEmiRet1.Caption = "fechaEmiRet";
            this.colfechaEmiRet1.FieldName = "fechaEmiRet1";
            this.colfechaEmiRet1.Name = "colfechaEmiRet1";
            this.colfechaEmiRet1.Visible = true;
            this.colfechaEmiRet1.VisibleIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1057, 153);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlRT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1049, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retenciones en la fuente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlRT
            // 
            this.gridControlRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRT.Location = new System.Drawing.Point(3, 3);
            this.gridControlRT.MainView = this.gridViewRT;
            this.gridControlRT.Name = "gridControlRT";
            this.gridControlRT.Size = new System.Drawing.Size(1043, 121);
            this.gridControlRT.TabIndex = 0;
            this.gridControlRT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRT});
            // 
            // gridViewRT
            // 
            this.gridViewRT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFactura_Prov,
            this.colced_ruc_proveedor,
            this.colNumRetencion,
            this.colfechart,
            this.colCodigoSRI,
            this.colre_baseRetencion,
            this.colre_Porcen_retencion,
            this.colre_valor_retencion});
            this.gridViewRT.GridControl = this.gridControlRT;
            this.gridViewRT.Name = "gridViewRT";
            this.gridViewRT.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRT.OptionsView.ShowGroupPanel = false;
            // 
            // colFactura_Prov
            // 
            this.colFactura_Prov.Caption = "Factura_Prov";
            this.colFactura_Prov.FieldName = "Factura_Prov";
            this.colFactura_Prov.Name = "colFactura_Prov";
            this.colFactura_Prov.Visible = true;
            this.colFactura_Prov.VisibleIndex = 0;
            // 
            // colced_ruc_proveedor
            // 
            this.colced_ruc_proveedor.Caption = "ced_ruc_proveedor";
            this.colced_ruc_proveedor.FieldName = "ced_ruc_proveedor";
            this.colced_ruc_proveedor.Name = "colced_ruc_proveedor";
            this.colced_ruc_proveedor.Visible = true;
            this.colced_ruc_proveedor.VisibleIndex = 1;
            // 
            // colNumRetencion
            // 
            this.colNumRetencion.Caption = "NumRetencion";
            this.colNumRetencion.FieldName = "NumRetencion";
            this.colNumRetencion.Name = "colNumRetencion";
            this.colNumRetencion.Visible = true;
            this.colNumRetencion.VisibleIndex = 2;
            // 
            // colfechart
            // 
            this.colfechart.Caption = "fecha_RT";
            this.colfechart.FieldName = "fecha";
            this.colfechart.Name = "colfechart";
            this.colfechart.Visible = true;
            this.colfechart.VisibleIndex = 3;
            // 
            // colCodigoSRI
            // 
            this.colCodigoSRI.Caption = "CodigoSRI";
            this.colCodigoSRI.FieldName = "Info_det_retencion.CodigoSRI";
            this.colCodigoSRI.Name = "colCodigoSRI";
            this.colCodigoSRI.Visible = true;
            this.colCodigoSRI.VisibleIndex = 4;
            // 
            // colre_baseRetencion
            // 
            this.colre_baseRetencion.Caption = "re_baseRetencion";
            this.colre_baseRetencion.FieldName = "Info_det_retencion.re_baseRetencion";
            this.colre_baseRetencion.Name = "colre_baseRetencion";
            this.colre_baseRetencion.Visible = true;
            this.colre_baseRetencion.VisibleIndex = 5;
            // 
            // colre_Porcen_retencion
            // 
            this.colre_Porcen_retencion.Caption = "re_Porcen_retencion";
            this.colre_Porcen_retencion.FieldName = "Info_det_retencion.re_Porcen_retencion";
            this.colre_Porcen_retencion.Name = "colre_Porcen_retencion";
            this.colre_Porcen_retencion.Visible = true;
            this.colre_Porcen_retencion.VisibleIndex = 6;
            // 
            // colre_valor_retencion
            // 
            this.colre_valor_retencion.Caption = "re_valor_retencion";
            this.colre_valor_retencion.FieldName = "Info_det_retencion.re_valor_retencion";
            this.colre_valor_retencion.Name = "colre_valor_retencion";
            this.colre_valor_retencion.Visible = true;
            this.colre_valor_retencion.VisibleIndex = 7;
            // 
            // tabPageVentas
            // 
            this.tabPageVentas.Controls.Add(this.gridControlVentas);
            this.tabPageVentas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVentas.Name = "tabPageVentas";
            this.tabPageVentas.Size = new System.Drawing.Size(1063, 368);
            this.tabPageVentas.TabIndex = 1;
            this.tabPageVentas.Text = "Ventas";
            this.tabPageVentas.UseVisualStyleBackColor = true;
            // 
            // gridControlVentas
            // 
            this.gridControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVentas.Location = new System.Drawing.Point(0, 0);
            this.gridControlVentas.MainView = this.gridViewVentas;
            this.gridControlVentas.Name = "gridControlVentas";
            this.gridControlVentas.Size = new System.Drawing.Size(1063, 368);
            this.gridControlVentas.TabIndex = 0;
            this.gridControlVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVentas});
            // 
            // gridViewVentas
            // 
            this.gridViewVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoIdentificacion,
            this.colIdentifiacion,
            this.coltipoComprobante,
            this.colbaseNoGraIva,
            this.colbaseImponible,
            this.colbaseImpGrav,
            this.colmontoIvav,
            this.colvalorRetIva,
            this.colvalorRetRenta});
            this.gridViewVentas.GridControl = this.gridControlVentas;
            this.gridViewVentas.Name = "gridViewVentas";
            this.gridViewVentas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.Caption = "Tipo Iden.";
            this.colTipoIdentificacion.FieldName = "tipoCliente";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            // 
            // colIdentifiacion
            // 
            this.colIdentifiacion.Caption = "#Identificacion/Cliente";
            this.colIdentifiacion.FieldName = "idCliente";
            this.colIdentifiacion.Name = "colIdentifiacion";
            this.colIdentifiacion.Visible = true;
            this.colIdentifiacion.VisibleIndex = 0;
            this.colIdentifiacion.Width = 189;
            // 
            // coltipoComprobante
            // 
            this.coltipoComprobante.Caption = "tipoComprobante";
            this.coltipoComprobante.FieldName = "tipoComprobante";
            this.coltipoComprobante.Name = "coltipoComprobante";
            this.coltipoComprobante.Visible = true;
            this.coltipoComprobante.VisibleIndex = 1;
            this.coltipoComprobante.Width = 121;
            // 
            // colbaseNoGraIva
            // 
            this.colbaseNoGraIva.Caption = "baseNoGraIva";
            this.colbaseNoGraIva.FieldName = "baseNoGraIva";
            this.colbaseNoGraIva.Name = "colbaseNoGraIva";
            this.colbaseNoGraIva.Visible = true;
            this.colbaseNoGraIva.VisibleIndex = 2;
            this.colbaseNoGraIva.Width = 121;
            // 
            // colbaseImponible
            // 
            this.colbaseImponible.Caption = "baseImponible";
            this.colbaseImponible.FieldName = "baseImponible";
            this.colbaseImponible.Name = "colbaseImponible";
            this.colbaseImponible.Visible = true;
            this.colbaseImponible.VisibleIndex = 3;
            this.colbaseImponible.Width = 121;
            // 
            // colbaseImpGrav
            // 
            this.colbaseImpGrav.Caption = "baseImpGrav";
            this.colbaseImpGrav.FieldName = "baseImpGrav";
            this.colbaseImpGrav.Name = "colbaseImpGrav";
            this.colbaseImpGrav.Visible = true;
            this.colbaseImpGrav.VisibleIndex = 4;
            this.colbaseImpGrav.Width = 121;
            // 
            // colmontoIvav
            // 
            this.colmontoIvav.Caption = "montoIva";
            this.colmontoIvav.FieldName = "montoIva";
            this.colmontoIvav.Name = "colmontoIvav";
            this.colmontoIvav.Visible = true;
            this.colmontoIvav.VisibleIndex = 5;
            this.colmontoIvav.Width = 121;
            // 
            // colvalorRetIva
            // 
            this.colvalorRetIva.Caption = "valorRetIva";
            this.colvalorRetIva.FieldName = "valorRetIva";
            this.colvalorRetIva.Name = "colvalorRetIva";
            this.colvalorRetIva.Visible = true;
            this.colvalorRetIva.VisibleIndex = 6;
            this.colvalorRetIva.Width = 121;
            // 
            // colvalorRetRenta
            // 
            this.colvalorRetRenta.Caption = "valorRetRenta";
            this.colvalorRetRenta.FieldName = "valorRetRenta";
            this.colvalorRetRenta.Name = "colvalorRetRenta";
            this.colvalorRetRenta.Visible = true;
            this.colvalorRetRenta.VisibleIndex = 7;
            this.colvalorRetRenta.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.cmb_periodo);
            this.groupBox1.Controls.Add(this.btn_procesar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_anio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(558, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1071, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 11;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 466);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1071, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 437);
            this.panel2.TabIndex = 13;
            // 
            // frmCP_AnexosAtsRoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmCP_AnexosAtsRoc";
            this.Text = "Generación de Anexos ATS & ROC para el SRI";
            this.Load += new System.EventHandler(this.frmCP_AnexosAtsRoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCompras.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompras)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRT)).EndInit();
            this.tabPageVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_anio;
        private System.Windows.Forms.ComboBox cmb_periodo;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCompras;
        //   private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompras;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlRT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRT;
        private DevExpress.XtraGrid.Columns.GridColumn colSustento;
        private DevExpress.XtraGrid.Columns.GridColumn colRucCed;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseIva0;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseIva_dif_0;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoIva;
        private DevExpress.XtraGrid.Columns.GridColumn colsecRetencion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaEmiRet1;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura_Prov;
        private DevExpress.XtraGrid.Columns.GridColumn colced_ruc_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechart;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colre_baseRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colre_Porcen_retencion;
        private DevExpress.XtraGrid.Columns.GridColumn colre_valor_retencion;
        private System.Windows.Forms.TabPage tabPageVentas;
        private DevExpress.XtraGrid.GridControl gridControlVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentifiacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipoComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colbaseNoGraIva;
        private DevExpress.XtraGrid.Columns.GridColumn colbaseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colbaseImpGrav;
        private DevExpress.XtraGrid.Columns.GridColumn colmontoIvav;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorRetIva;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorRetRenta;
    }
}
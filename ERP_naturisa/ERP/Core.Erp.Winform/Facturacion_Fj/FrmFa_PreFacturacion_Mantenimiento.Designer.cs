namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class FrmFa_PreFacturacion_Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFa_PreFacturacion_Mantenimiento));
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ucFa_CatalogosCmb1 = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.lblAnulado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdPreFacturacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.btn_Procesar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Observacion = new DevExpress.XtraEditors.MemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlClientes = new DevExpress.XtraTreeList.TreeList();
            this.tlcolNom_cliente = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBarControlProceso = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControlPre_fact = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageEgresos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlEgresos_bodega = new DevExpress.XtraGrid.GridControl();
            this.gridViewEgresos_bodega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoUnitario_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAplicaIva_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorIva_egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Egresos = new System.Windows.Forms.ToolStripButton();
            this.tabPageGastos_x_factura = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlGastos = new DevExpress.XtraGrid.GridControl();
            this.gridViewGastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_gas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoUnitario_gas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal_gas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva_gas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_gas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Gastos = new System.Windows.Forms.ToolStripButton();
            this.tabPageMovilziacion = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMovilizacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewMovilizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn62 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Movilización = new System.Windows.Forms.ToolStripButton();
            this.tabPageDepreciacion = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDepreciacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepreciacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Depreciacion = new System.Windows.Forms.ToolStripButton();
            this.tabPagePoliza = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlPoliza = new DevExpress.XtraGrid.GridControl();
            this.gridViewPoliza = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivo_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoFacturacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn61 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoUnitario_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_pol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPor_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Amortizacion = new System.Windows.Forms.ToolStripButton();
            this.tabPageHorometro = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMarcaciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewMarcaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad_mar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoUnitario_mar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal_mar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva_mar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_mar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Marcaciones = new System.Windows.Forms.ToolStripButton();
            this.tabPageAtivos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlActivos = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir_Ubicacion = new System.Windows.Forms.ToolStripButton();
            this.tab_ManoObra = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_mano_obra = new DevExpress.XtraGrid.GridControl();
            this.gridView_mano_obra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_SALARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_H_EXTRAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOL_ALIMENTACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TOTAL_INGRESOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_T_BENEFICIOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TOTAL_M_O = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Intereses = new DevExpress.XtraGrid.GridControl();
            this.gridView_Intereses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Observac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Val = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip10 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tab_otrosGastos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_otros = new DevExpress.XtraGrid.GridControl();
            this.gridView_otros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Nombre_Cobro_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.splashScreenManagereEspera = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlClientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlProceso.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlPre_fact)).BeginInit();
            this.tabControlPre_fact.SuspendLayout();
            this.tabPageEgresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEgresos_bodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEgresos_bodega)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPageGastos_x_factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPageMovilziacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovilizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovilizacion)).BeginInit();
            this.toolStrip7.SuspendLayout();
            this.tabPageDepreciacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepreciacion)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.tabPagePoliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoliza)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.tabPageHorometro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcaciones)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPageAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivos)).BeginInit();
            this.toolStrip6.SuspendLayout();
            this.tab_ManoObra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_mano_obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_mano_obra)).BeginInit();
            this.toolStrip8.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Intereses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Intereses)).BeginInit();
            this.toolStrip10.SuspendLayout();
            this.tab_otrosGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_otros)).BeginInit();
            this.toolStrip9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 470);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1131, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1131, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.ucFa_CatalogosCmb1);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.de_Fecha);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txt_IdPreFacturacion);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.ucCon_Periodo1);
            this.panel1.Controls.Add(this.btn_Procesar);
            this.panel1.Controls.Add(this.txt_Observacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 91);
            this.panel1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(573, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Estado:";
            // 
            // ucFa_CatalogosCmb1
            // 
            this.ucFa_CatalogosCmb1.Location = new System.Drawing.Point(616, 1);
            this.ucFa_CatalogosCmb1.Name = "ucFa_CatalogosCmb1";
            this.ucFa_CatalogosCmb1.Size = new System.Drawing.Size(209, 30);
            this.ucFa_CatalogosCmb1.TabIndex = 19;
            this.ucFa_CatalogosCmb1.Visible_cmb_Accion = false;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(348, 7);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(141, 19);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(26, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Desde:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(831, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Fecha:";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = new System.DateTime(2016, 4, 22, 12, 36, 16, 861);
            this.de_Fecha.Location = new System.Drawing.Point(896, 6);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(109, 20);
            this.de_Fecha.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(399, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Observación:";
            // 
            // txt_IdPreFacturacion
            // 
            this.txt_IdPreFacturacion.Location = new System.Drawing.Point(124, 7);
            this.txt_IdPreFacturacion.Name = "txt_IdPreFacturacion";
            this.txt_IdPreFacturacion.Properties.ReadOnly = true;
            this.txt_IdPreFacturacion.Size = new System.Drawing.Size(90, 20);
            this.txt_IdPreFacturacion.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "# Pre-facturación:";
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(47, 30);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(342, 56);
            this.ucCon_Periodo1.TabIndex = 9;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = false;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = false;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Location = new System.Drawing.Point(1011, 10);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(82, 30);
            this.btn_Procesar.TabIndex = 7;
            this.btn_Procesar.Text = "Procesar";
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(469, 33);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(536, 47);
            this.txt_Observacion.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tlClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 326);
            this.panel2.TabIndex = 3;
            // 
            // tlClientes
            // 
            this.tlClientes.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcolNom_cliente});
            this.tlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlClientes.Location = new System.Drawing.Point(0, 0);
            this.tlClientes.Name = "tlClientes";
            this.tlClientes.OptionsBehavior.Editable = false;
            this.tlClientes.OptionsPrint.UsePrintStyles = true;
            this.tlClientes.Size = new System.Drawing.Size(200, 326);
            this.tlClientes.TabIndex = 0;
            this.tlClientes.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlClientes_FocusedNodeChanged);
            // 
            // tlcolNom_cliente
            // 
            this.tlcolNom_cliente.Caption = "Clientes";
            this.tlcolNom_cliente.FieldName = "nom_Cliente";
            this.tlcolNom_cliente.Name = "tlcolNom_cliente";
            this.tlcolNom_cliente.Visible = true;
            this.tlcolNom_cliente.VisibleIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBarControlProceso);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 24);
            this.panel3.TabIndex = 4;
            // 
            // progressBarControlProceso
            // 
            this.progressBarControlProceso.Location = new System.Drawing.Point(26, 3);
            this.progressBarControlProceso.Name = "progressBarControlProceso";
            this.progressBarControlProceso.Size = new System.Drawing.Size(757, 18);
            this.progressBarControlProceso.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControlPre_fact);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 326);
            this.panel4.TabIndex = 5;
            // 
            // tabControlPre_fact
            // 
            this.tabControlPre_fact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPre_fact.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tabControlPre_fact.Location = new System.Drawing.Point(0, 0);
            this.tabControlPre_fact.Name = "tabControlPre_fact";
            this.tabControlPre_fact.SelectedTabPage = this.tabPageEgresos;
            this.tabControlPre_fact.Size = new System.Drawing.Size(931, 326);
            this.tabControlPre_fact.TabIndex = 0;
            this.tabControlPre_fact.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageEgresos,
            this.tabPageGastos_x_factura,
            this.tabPageMovilziacion,
            this.tabPageDepreciacion,
            this.tabPagePoliza,
            this.tabPageHorometro,
            this.tabPageAtivos,
            this.tab_ManoObra,
            this.xtraTabPage1,
            this.tab_otrosGastos});
            // 
            // tabPageEgresos
            // 
            this.tabPageEgresos.Controls.Add(this.gridControlEgresos_bodega);
            this.tabPageEgresos.Controls.Add(this.toolStrip1);
            this.tabPageEgresos.Name = "tabPageEgresos";
            this.tabPageEgresos.Size = new System.Drawing.Size(925, 298);
            this.tabPageEgresos.Text = "Egresos de bodega";
            // 
            // gridControlEgresos_bodega
            // 
            this.gridControlEgresos_bodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEgresos_bodega.Location = new System.Drawing.Point(0, 25);
            this.gridControlEgresos_bodega.MainView = this.gridViewEgresos_bodega;
            this.gridControlEgresos_bodega.Name = "gridControlEgresos_bodega";
            this.gridControlEgresos_bodega.Size = new System.Drawing.Size(925, 273);
            this.gridControlEgresos_bodega.TabIndex = 0;
            this.gridControlEgresos_bodega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEgresos_bodega});
            // 
            // gridViewEgresos_bodega
            // 
            this.gridViewEgresos_bodega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colCantidad_egr,
            this.gridColumn4,
            this.gridColumn5,
            this.colCostoUnitario_egr,
            this.colTotal_egr,
            this.gridColumn9,
            this.gridColumn15,
            this.colIva_egr,
            this.colSubtotal_egr,
            this.gridColumn58,
            this.colAplicaIva_egr,
            this.colPorIva_egr,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn7});
            this.gridViewEgresos_bodega.GridControl = this.gridControlEgresos_bodega;
            this.gridViewEgresos_bodega.GroupCount = 2;
            this.gridViewEgresos_bodega.GroupFormat = "[#image]{1} {2}";
            this.gridViewEgresos_bodega.Name = "gridViewEgresos_bodega";
            this.gridViewEgresos_bodega.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewEgresos_bodega.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEgresos_bodega.OptionsView.ShowGroupPanel = false;
            this.gridViewEgresos_bodega.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn15, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewEgresos_bodega.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewEgresos_bodega_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.FieldName = "cm_fecha";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Proveedor";
            this.gridColumn2.FieldName = "nom_Proveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 157;
            // 
            // colCantidad_egr
            // 
            this.colCantidad_egr.Caption = "Cantidad";
            this.colCantidad_egr.FieldName = "Cantidad";
            this.colCantidad_egr.Name = "colCantidad_egr";
            this.colCantidad_egr.Visible = true;
            this.colCantidad_egr.VisibleIndex = 8;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descripción";
            this.gridColumn4.FieldName = "nom_Producto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 230;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Factura ";
            this.gridColumn5.FieldName = "num_Factura";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // colCostoUnitario_egr
            // 
            this.colCostoUnitario_egr.Caption = "Costo unitario";
            this.colCostoUnitario_egr.FieldName = "Costo_Uni";
            this.colCostoUnitario_egr.Name = "colCostoUnitario_egr";
            this.colCostoUnitario_egr.Visible = true;
            this.colCostoUnitario_egr.VisibleIndex = 7;
            this.colCostoUnitario_egr.Width = 80;
            // 
            // colTotal_egr
            // 
            this.colTotal_egr.Caption = "Total";
            this.colTotal_egr.FieldName = "Total";
            this.colTotal_egr.Name = "colTotal_egr";
            this.colTotal_egr.OptionsColumn.AllowEdit = false;
            this.colTotal_egr.Visible = true;
            this.colTotal_egr.VisibleIndex = 11;
            this.colTotal_egr.Width = 101;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "nom_Cliente";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // colIva_egr
            // 
            this.colIva_egr.Caption = "Iva";
            this.colIva_egr.FieldName = "Valor_Iva";
            this.colIva_egr.Name = "colIva_egr";
            this.colIva_egr.OptionsColumn.AllowEdit = false;
            this.colIva_egr.Visible = true;
            this.colIva_egr.VisibleIndex = 10;
            this.colIva_egr.Width = 50;
            // 
            // colSubtotal_egr
            // 
            this.colSubtotal_egr.Caption = "Subtotal";
            this.colSubtotal_egr.FieldName = "Subtotal";
            this.colSubtotal_egr.Name = "colSubtotal_egr";
            this.colSubtotal_egr.OptionsColumn.AllowEdit = false;
            this.colSubtotal_egr.Visible = true;
            this.colSubtotal_egr.VisibleIndex = 9;
            this.colSubtotal_egr.Width = 65;
            // 
            // gridColumn58
            // 
            this.gridColumn58.Caption = "*";
            this.gridColumn58.FieldName = "Facturar";
            this.gridColumn58.Name = "gridColumn58";
            this.gridColumn58.Visible = true;
            this.gridColumn58.VisibleIndex = 0;
            this.gridColumn58.Width = 62;
            // 
            // colAplicaIva_egr
            // 
            this.colAplicaIva_egr.Caption = "Aplica iva";
            this.colAplicaIva_egr.FieldName = "Aplica_Iva";
            this.colAplicaIva_egr.Name = "colAplicaIva_egr";
            this.colAplicaIva_egr.OptionsColumn.AllowEdit = false;
            // 
            // colPorIva_egr
            // 
            this.colPorIva_egr.Caption = "% IVA";
            this.colPorIva_egr.FieldName = "Por_Iva";
            this.colPorIva_egr.Name = "colPorIva_egr";
            this.colPorIva_egr.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Activo";
            this.gridColumn3.FieldName = "nom_punto_cargo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 125;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Egreso";
            this.gridColumn6.FieldName = "IdNumMovi_mov_inv";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 66;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "% Ganancia";
            this.gridColumn7.FieldName = "Porc_ganancia";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Egresos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir_Egresos
            // 
            this.btnImprimir_Egresos.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Egresos.Image")));
            this.btnImprimir_Egresos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Egresos.Name = "btnImprimir_Egresos";
            this.btnImprimir_Egresos.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Egresos.Text = "Imprimir";
            this.btnImprimir_Egresos.Click += new System.EventHandler(this.btnImprimir_Egresos_Click);
            // 
            // tabPageGastos_x_factura
            // 
            this.tabPageGastos_x_factura.Controls.Add(this.gridControlGastos);
            this.tabPageGastos_x_factura.Controls.Add(this.toolStrip3);
            this.tabPageGastos_x_factura.Name = "tabPageGastos_x_factura";
            this.tabPageGastos_x_factura.Size = new System.Drawing.Size(925, 298);
            this.tabPageGastos_x_factura.Text = "Gastos por factura";
            // 
            // gridControlGastos
            // 
            this.gridControlGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGastos.Location = new System.Drawing.Point(0, 25);
            this.gridControlGastos.MainView = this.gridViewGastos;
            this.gridControlGastos.Name = "gridControlGastos";
            this.gridControlGastos.Size = new System.Drawing.Size(925, 273);
            this.gridControlGastos.TabIndex = 1;
            this.gridControlGastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGastos});
            // 
            // gridViewGastos
            // 
            this.gridViewGastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn45,
            this.gridColumn47,
            this.gridColumn48,
            this.colCantidad_gas,
            this.gridColumn50,
            this.colCostoUnitario_gas,
            this.colSubtotal_gas,
            this.colIva_gas,
            this.colTotal_gas,
            this.gridColumn46,
            this.gridColumn59,
            this.gridColumn8});
            this.gridViewGastos.GridControl = this.gridControlGastos;
            this.gridViewGastos.GroupCount = 3;
            this.gridViewGastos.GroupFormat = "[#image]{1} {2}";
            this.gridViewGastos.Name = "gridViewGastos";
            this.gridViewGastos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewGastos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGastos.OptionsView.ShowGroupPanel = false;
            this.gridViewGastos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn21, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn22, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn46, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewGastos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewGastos_CellValueChanged);
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "nom_Cliente";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            // 
            // gridColumn22
            // 
            this.gridColumn22.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 0;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Activo";
            this.gridColumn23.FieldName = "nom_punto_cargo";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 5;
            this.gridColumn23.Width = 79;
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "Fecha";
            this.gridColumn45.FieldName = "co_FechaFactura";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.OptionsColumn.AllowEdit = false;
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 1;
            this.gridColumn45.Width = 62;
            // 
            // gridColumn47
            // 
            this.gridColumn47.Caption = "Proveedor";
            this.gridColumn47.FieldName = "nom_Proveedor";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.OptionsColumn.AllowEdit = false;
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 2;
            this.gridColumn47.Width = 130;
            // 
            // gridColumn48
            // 
            this.gridColumn48.Caption = "Factura";
            this.gridColumn48.FieldName = "co_factura";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.OptionsColumn.AllowEdit = false;
            this.gridColumn48.Visible = true;
            this.gridColumn48.VisibleIndex = 3;
            this.gridColumn48.Width = 74;
            // 
            // colCantidad_gas
            // 
            this.colCantidad_gas.Caption = "Cantidad";
            this.colCantidad_gas.FieldName = "Cantidad";
            this.colCantidad_gas.Name = "colCantidad_gas";
            this.colCantidad_gas.Visible = true;
            this.colCantidad_gas.VisibleIndex = 6;
            this.colCantidad_gas.Width = 51;
            // 
            // gridColumn50
            // 
            this.gridColumn50.Caption = "Descripción";
            this.gridColumn50.FieldName = "Descripcion";
            this.gridColumn50.Name = "gridColumn50";
            this.gridColumn50.OptionsColumn.AllowEdit = false;
            this.gridColumn50.Visible = true;
            this.gridColumn50.VisibleIndex = 4;
            this.gridColumn50.Width = 148;
            // 
            // colCostoUnitario_gas
            // 
            this.colCostoUnitario_gas.Caption = "Costo unitario";
            this.colCostoUnitario_gas.FieldName = "Costo_Uni";
            this.colCostoUnitario_gas.Name = "colCostoUnitario_gas";
            this.colCostoUnitario_gas.Visible = true;
            this.colCostoUnitario_gas.VisibleIndex = 7;
            this.colCostoUnitario_gas.Width = 57;
            // 
            // colSubtotal_gas
            // 
            this.colSubtotal_gas.Caption = "Subtotal";
            this.colSubtotal_gas.FieldName = "Subtotal";
            this.colSubtotal_gas.Name = "colSubtotal_gas";
            this.colSubtotal_gas.OptionsColumn.AllowEdit = false;
            this.colSubtotal_gas.Visible = true;
            this.colSubtotal_gas.VisibleIndex = 8;
            this.colSubtotal_gas.Width = 59;
            // 
            // colIva_gas
            // 
            this.colIva_gas.Caption = "Iva";
            this.colIva_gas.FieldName = "Valor_Iva";
            this.colIva_gas.Name = "colIva_gas";
            this.colIva_gas.OptionsColumn.AllowEdit = false;
            this.colIva_gas.Visible = true;
            this.colIva_gas.VisibleIndex = 9;
            this.colIva_gas.Width = 54;
            // 
            // colTotal_gas
            // 
            this.colTotal_gas.Caption = "Total";
            this.colTotal_gas.FieldName = "Total";
            this.colTotal_gas.Name = "colTotal_gas";
            this.colTotal_gas.OptionsColumn.AllowEdit = false;
            this.colTotal_gas.Visible = true;
            this.colTotal_gas.VisibleIndex = 10;
            this.colTotal_gas.Width = 49;
            // 
            // gridColumn46
            // 
            this.gridColumn46.FieldName = "nom_Gasto";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.OptionsColumn.AllowEdit = false;
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 11;
            // 
            // gridColumn59
            // 
            this.gridColumn59.Caption = "*";
            this.gridColumn59.FieldName = "Facturar";
            this.gridColumn59.Name = "gridColumn59";
            this.gridColumn59.Visible = true;
            this.gridColumn59.VisibleIndex = 0;
            this.gridColumn59.Width = 83;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "% Ganancia";
            this.gridColumn8.FieldName = "Porc_ganancia";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 11;
            this.gridColumn8.Width = 61;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Gastos});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(925, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnImprimir_Gastos
            // 
            this.btnImprimir_Gastos.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Gastos.Image")));
            this.btnImprimir_Gastos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Gastos.Name = "btnImprimir_Gastos";
            this.btnImprimir_Gastos.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Gastos.Text = "Imprimir";
            this.btnImprimir_Gastos.Click += new System.EventHandler(this.btnImprimir_Gastos_Click);
            // 
            // tabPageMovilziacion
            // 
            this.tabPageMovilziacion.Controls.Add(this.gridControlMovilizacion);
            this.tabPageMovilziacion.Controls.Add(this.toolStrip7);
            this.tabPageMovilziacion.Name = "tabPageMovilziacion";
            this.tabPageMovilziacion.Size = new System.Drawing.Size(925, 298);
            this.tabPageMovilziacion.Text = "Movilización";
            // 
            // gridControlMovilizacion
            // 
            this.gridControlMovilizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovilizacion.Location = new System.Drawing.Point(0, 25);
            this.gridControlMovilizacion.MainView = this.gridViewMovilizacion;
            this.gridControlMovilizacion.Name = "gridControlMovilizacion";
            this.gridControlMovilizacion.Size = new System.Drawing.Size(925, 273);
            this.gridControlMovilizacion.TabIndex = 1;
            this.gridControlMovilizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovilizacion});
            // 
            // gridViewMovilizacion
            // 
            this.gridViewMovilizacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn39,
            this.gridColumn55,
            this.gridColumn56,
            this.gridColumn57,
            this.gridColumn62,
            this.gridColumn17});
            this.gridViewMovilizacion.GridControl = this.gridControlMovilizacion;
            this.gridViewMovilizacion.GroupCount = 2;
            this.gridViewMovilizacion.GroupFormat = "[#image]{1} {2}";
            this.gridViewMovilizacion.Name = "gridViewMovilizacion";
            this.gridViewMovilizacion.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMovilizacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMovilizacion.OptionsView.ShowGroupPanel = false;
            this.gridViewMovilizacion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn39, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn55, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn39
            // 
            this.gridColumn39.FieldName = "nom_Cliente";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.OptionsColumn.AllowEdit = false;
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 0;
            // 
            // gridColumn55
            // 
            this.gridColumn55.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn55.Name = "gridColumn55";
            this.gridColumn55.OptionsColumn.AllowEdit = false;
            this.gridColumn55.Visible = true;
            this.gridColumn55.VisibleIndex = 0;
            // 
            // gridColumn56
            // 
            this.gridColumn56.Caption = "Activo";
            this.gridColumn56.FieldName = "Af_Nombre";
            this.gridColumn56.Name = "gridColumn56";
            this.gridColumn56.OptionsColumn.AllowEdit = false;
            this.gridColumn56.Visible = true;
            this.gridColumn56.VisibleIndex = 1;
            this.gridColumn56.Width = 402;
            // 
            // gridColumn57
            // 
            this.gridColumn57.Caption = "Movilización";
            this.gridColumn57.FieldName = "Movilizacion";
            this.gridColumn57.Name = "gridColumn57";
            this.gridColumn57.Visible = true;
            this.gridColumn57.VisibleIndex = 2;
            this.gridColumn57.Width = 336;
            // 
            // gridColumn62
            // 
            this.gridColumn62.Caption = "*";
            this.gridColumn62.FieldName = "Facturar";
            this.gridColumn62.Name = "gridColumn62";
            this.gridColumn62.Visible = true;
            this.gridColumn62.VisibleIndex = 0;
            this.gridColumn62.Width = 62;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "% Ganancia";
            this.gridColumn17.FieldName = "Porc_ganancia";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 3;
            this.gridColumn17.Width = 107;
            // 
            // toolStrip7
            // 
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Movilización});
            this.toolStrip7.Location = new System.Drawing.Point(0, 0);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(925, 25);
            this.toolStrip7.TabIndex = 0;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // btnImprimir_Movilización
            // 
            this.btnImprimir_Movilización.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Movilización.Image")));
            this.btnImprimir_Movilización.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Movilización.Name = "btnImprimir_Movilización";
            this.btnImprimir_Movilización.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Movilización.Text = "Imprimir";
            // 
            // tabPageDepreciacion
            // 
            this.tabPageDepreciacion.Controls.Add(this.gridControlDepreciacion);
            this.tabPageDepreciacion.Controls.Add(this.toolStrip4);
            this.tabPageDepreciacion.Name = "tabPageDepreciacion";
            this.tabPageDepreciacion.Size = new System.Drawing.Size(925, 298);
            this.tabPageDepreciacion.Text = "Depreciación";
            // 
            // gridControlDepreciacion
            // 
            this.gridControlDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDepreciacion.Location = new System.Drawing.Point(0, 25);
            this.gridControlDepreciacion.MainView = this.gridViewDepreciacion;
            this.gridControlDepreciacion.Name = "gridControlDepreciacion";
            this.gridControlDepreciacion.Size = new System.Drawing.Size(925, 273);
            this.gridControlDepreciacion.TabIndex = 1;
            this.gridControlDepreciacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepreciacion});
            // 
            // gridViewDepreciacion
            // 
            this.gridViewDepreciacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn60,
            this.gridColumn29});
            this.gridViewDepreciacion.GridControl = this.gridControlDepreciacion;
            this.gridViewDepreciacion.GroupCount = 2;
            this.gridViewDepreciacion.GroupFormat = "[#image]{1} {2}";
            this.gridViewDepreciacion.Name = "gridViewDepreciacion";
            this.gridViewDepreciacion.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDepreciacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDepreciacion.OptionsView.ShowGroupPanel = false;
            this.gridViewDepreciacion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn24, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn25, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn24
            // 
            this.gridColumn24.FieldName = "nom_Cliente";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            // 
            // gridColumn25
            // 
            this.gridColumn25.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 0;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Activo";
            this.gridColumn26.FieldName = "Af_Nombre";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 1;
            this.gridColumn26.Width = 338;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Modelo";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.AllowEdit = false;
            this.gridColumn30.Width = 102;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Color";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.Width = 102;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Placas";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.OptionsColumn.AllowEdit = false;
            this.gridColumn33.Width = 102;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Marca";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.OptionsColumn.AllowEdit = false;
            this.gridColumn34.Width = 102;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Costo unitario";
            this.gridColumn35.FieldName = "Costo_unitario";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 2;
            this.gridColumn35.Width = 162;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Valor de salvamento";
            this.gridColumn36.FieldName = "Valor_salvamento";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            this.gridColumn36.Width = 195;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Total a depreciar";
            this.gridColumn37.FieldName = "Total_depreciado_x_cobrar";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 4;
            this.gridColumn37.Width = 202;
            // 
            // gridColumn60
            // 
            this.gridColumn60.Caption = "*";
            this.gridColumn60.FieldName = "Facturar";
            this.gridColumn60.Name = "gridColumn60";
            this.gridColumn60.Visible = true;
            this.gridColumn60.VisibleIndex = 0;
            this.gridColumn60.Width = 64;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "% Ganancia";
            this.gridColumn29.FieldName = "Porc_ganancia";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 5;
            this.gridColumn29.Width = 219;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Depreciacion});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(925, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnImprimir_Depreciacion
            // 
            this.btnImprimir_Depreciacion.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Depreciacion.Image")));
            this.btnImprimir_Depreciacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Depreciacion.Name = "btnImprimir_Depreciacion";
            this.btnImprimir_Depreciacion.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Depreciacion.Text = "Imprimir";
            // 
            // tabPagePoliza
            // 
            this.tabPagePoliza.Controls.Add(this.gridControlPoliza);
            this.tabPagePoliza.Controls.Add(this.toolStrip5);
            this.tabPagePoliza.Name = "tabPagePoliza";
            this.tabPagePoliza.Size = new System.Drawing.Size(925, 298);
            this.tabPagePoliza.Text = "Póliza";
            // 
            // gridControlPoliza
            // 
            this.gridControlPoliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPoliza.Location = new System.Drawing.Point(0, 25);
            this.gridControlPoliza.MainView = this.gridViewPoliza;
            this.gridControlPoliza.Name = "gridControlPoliza";
            this.gridControlPoliza.Size = new System.Drawing.Size(925, 273);
            this.gridControlPoliza.TabIndex = 1;
            this.gridControlPoliza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPoliza});
            // 
            // gridViewPoliza
            // 
            this.gridViewPoliza.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn27,
            this.gridColumn28,
            this.colActivo_pol,
            this.colCodigo_pol,
            this.colSubtotal_pol,
            this.colIva_pol,
            this.colTotal_pol,
            this.colEstadoFacturacion,
            this.gridColumn61,
            this.colCostoUnitario_pol,
            this.colCantidad_pol,
            this.colPor_Iva,
            this.gridColumn40});
            this.gridViewPoliza.GridControl = this.gridControlPoliza;
            this.gridViewPoliza.GroupCount = 2;
            this.gridViewPoliza.GroupFormat = "[#image]{1} {2}";
            this.gridViewPoliza.Name = "gridViewPoliza";
            this.gridViewPoliza.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewPoliza.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPoliza.OptionsView.ShowGroupPanel = false;
            this.gridViewPoliza.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn27, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn28, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPoliza.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPoliza_CellValueChanged);
            // 
            // gridColumn27
            // 
            this.gridColumn27.FieldName = "nom_Cliente";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 0;
            // 
            // gridColumn28
            // 
            this.gridColumn28.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 0;
            // 
            // colActivo_pol
            // 
            this.colActivo_pol.Caption = "Activo";
            this.colActivo_pol.FieldName = "Af_Nombre";
            this.colActivo_pol.Name = "colActivo_pol";
            this.colActivo_pol.OptionsColumn.AllowEdit = false;
            this.colActivo_pol.Visible = true;
            this.colActivo_pol.VisibleIndex = 7;
            this.colActivo_pol.Width = 100;
            // 
            // colCodigo_pol
            // 
            this.colCodigo_pol.Caption = "Código";
            this.colCodigo_pol.FieldName = "cod_cuota_pol_cuota";
            this.colCodigo_pol.Name = "colCodigo_pol";
            this.colCodigo_pol.OptionsColumn.AllowEdit = false;
            this.colCodigo_pol.Visible = true;
            this.colCodigo_pol.VisibleIndex = 1;
            this.colCodigo_pol.Width = 88;
            // 
            // colSubtotal_pol
            // 
            this.colSubtotal_pol.Caption = "Subtotal";
            this.colSubtotal_pol.FieldName = "Subtotal";
            this.colSubtotal_pol.Name = "colSubtotal_pol";
            this.colSubtotal_pol.OptionsColumn.AllowEdit = false;
            this.colSubtotal_pol.Visible = true;
            this.colSubtotal_pol.VisibleIndex = 4;
            this.colSubtotal_pol.Width = 103;
            // 
            // colIva_pol
            // 
            this.colIva_pol.Caption = "IVA";
            this.colIva_pol.FieldName = "Valor_Iva";
            this.colIva_pol.Name = "colIva_pol";
            this.colIva_pol.OptionsColumn.AllowEdit = false;
            this.colIva_pol.Visible = true;
            this.colIva_pol.VisibleIndex = 5;
            this.colIva_pol.Width = 100;
            // 
            // colTotal_pol
            // 
            this.colTotal_pol.Caption = "Total";
            this.colTotal_pol.FieldName = "Total";
            this.colTotal_pol.Name = "colTotal_pol";
            this.colTotal_pol.OptionsColumn.AllowEdit = false;
            this.colTotal_pol.Visible = true;
            this.colTotal_pol.VisibleIndex = 6;
            this.colTotal_pol.Width = 100;
            // 
            // colEstadoFacturacion
            // 
            this.colEstadoFacturacion.Caption = "Estado facturación";
            this.colEstadoFacturacion.FieldName = "nom_EstadoFacturacion_cat";
            this.colEstadoFacturacion.Name = "colEstadoFacturacion";
            this.colEstadoFacturacion.OptionsColumn.AllowEdit = false;
            this.colEstadoFacturacion.Visible = true;
            this.colEstadoFacturacion.VisibleIndex = 8;
            this.colEstadoFacturacion.Width = 100;
            // 
            // gridColumn61
            // 
            this.gridColumn61.Caption = "*";
            this.gridColumn61.FieldName = "Facturar";
            this.gridColumn61.Name = "gridColumn61";
            this.gridColumn61.Visible = true;
            this.gridColumn61.VisibleIndex = 0;
            this.gridColumn61.Width = 62;
            // 
            // colCostoUnitario_pol
            // 
            this.colCostoUnitario_pol.Caption = "Costo unitario";
            this.colCostoUnitario_pol.FieldName = "Costo_Uni";
            this.colCostoUnitario_pol.Name = "colCostoUnitario_pol";
            this.colCostoUnitario_pol.Visible = true;
            this.colCostoUnitario_pol.VisibleIndex = 3;
            this.colCostoUnitario_pol.Width = 116;
            // 
            // colCantidad_pol
            // 
            this.colCantidad_pol.Caption = "Cantidad";
            this.colCantidad_pol.FieldName = "Cantidad";
            this.colCantidad_pol.Name = "colCantidad_pol";
            this.colCantidad_pol.Visible = true;
            this.colCantidad_pol.VisibleIndex = 2;
            this.colCantidad_pol.Width = 88;
            // 
            // colPor_Iva
            // 
            this.colPor_Iva.Caption = "% IVA";
            this.colPor_Iva.FieldName = "Por_Iva";
            this.colPor_Iva.Name = "colPor_Iva";
            this.colPor_Iva.OptionsColumn.AllowEdit = false;
            this.colPor_Iva.Width = 50;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "% Ganancia";
            this.gridColumn40.FieldName = "Porc_ganancia";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 9;
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Amortizacion});
            this.toolStrip5.Location = new System.Drawing.Point(0, 0);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(925, 25);
            this.toolStrip5.TabIndex = 0;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // btnImprimir_Amortizacion
            // 
            this.btnImprimir_Amortizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Amortizacion.Image")));
            this.btnImprimir_Amortizacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Amortizacion.Name = "btnImprimir_Amortizacion";
            this.btnImprimir_Amortizacion.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Amortizacion.Text = "Imprimir";
            // 
            // tabPageHorometro
            // 
            this.tabPageHorometro.Controls.Add(this.gridControlMarcaciones);
            this.tabPageHorometro.Controls.Add(this.toolStrip2);
            this.tabPageHorometro.Name = "tabPageHorometro";
            this.tabPageHorometro.Size = new System.Drawing.Size(925, 298);
            this.tabPageHorometro.Text = "Marcaciones";
            // 
            // gridControlMarcaciones
            // 
            this.gridControlMarcaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMarcaciones.Location = new System.Drawing.Point(0, 25);
            this.gridControlMarcaciones.MainView = this.gridViewMarcaciones;
            this.gridControlMarcaciones.Name = "gridControlMarcaciones";
            this.gridControlMarcaciones.Size = new System.Drawing.Size(925, 273);
            this.gridControlMarcaciones.TabIndex = 1;
            this.gridControlMarcaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMarcaciones});
            // 
            // gridViewMarcaciones
            // 
            this.gridViewMarcaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn16,
            this.gridColumn38,
            this.colCantidad_mar,
            this.colCostoUnitario_mar,
            this.colSubtotal_mar,
            this.colIva_mar,
            this.colTotal_mar,
            this.gridColumn41});
            this.gridViewMarcaciones.GridControl = this.gridControlMarcaciones;
            this.gridViewMarcaciones.GroupCount = 2;
            this.gridViewMarcaciones.GroupFormat = "[#image]{1} {2}";
            this.gridViewMarcaciones.Name = "gridViewMarcaciones";
            this.gridViewMarcaciones.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMarcaciones.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMarcaciones.OptionsView.ShowGroupPanel = false;
            this.gridViewMarcaciones.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn19, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn18, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewMarcaciones.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewMarcaciones_CellValueChanged);
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "nom_Cliente";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Activo";
            this.gridColumn20.FieldName = "Af_Nombre";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 350;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "*";
            this.gridColumn16.FieldName = "Facturar";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            this.gridColumn16.Width = 62;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "Tiene tarifario";
            this.gridColumn38.FieldName = "Estado";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.OptionsColumn.AllowEdit = false;
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 7;
            this.gridColumn38.Width = 142;
            // 
            // colCantidad_mar
            // 
            this.colCantidad_mar.Caption = "Cantidad";
            this.colCantidad_mar.FieldName = "Cantidad";
            this.colCantidad_mar.Name = "colCantidad_mar";
            this.colCantidad_mar.Visible = true;
            this.colCantidad_mar.VisibleIndex = 2;
            this.colCantidad_mar.Width = 122;
            // 
            // colCostoUnitario_mar
            // 
            this.colCostoUnitario_mar.Caption = "Costo unitario";
            this.colCostoUnitario_mar.FieldName = "Costo_Uni";
            this.colCostoUnitario_mar.Name = "colCostoUnitario_mar";
            this.colCostoUnitario_mar.Visible = true;
            this.colCostoUnitario_mar.VisibleIndex = 3;
            this.colCostoUnitario_mar.Width = 122;
            // 
            // colSubtotal_mar
            // 
            this.colSubtotal_mar.Caption = "Subtotal";
            this.colSubtotal_mar.FieldName = "Subtotal";
            this.colSubtotal_mar.Name = "colSubtotal_mar";
            this.colSubtotal_mar.OptionsColumn.AllowEdit = false;
            this.colSubtotal_mar.Visible = true;
            this.colSubtotal_mar.VisibleIndex = 4;
            this.colSubtotal_mar.Width = 122;
            // 
            // colIva_mar
            // 
            this.colIva_mar.Caption = "IVA";
            this.colIva_mar.FieldName = "Valor_Iva";
            this.colIva_mar.Name = "colIva_mar";
            this.colIva_mar.OptionsColumn.AllowEdit = false;
            this.colIva_mar.Visible = true;
            this.colIva_mar.VisibleIndex = 5;
            this.colIva_mar.Width = 122;
            // 
            // colTotal_mar
            // 
            this.colTotal_mar.Caption = "Total";
            this.colTotal_mar.FieldName = "Total";
            this.colTotal_mar.Name = "colTotal_mar";
            this.colTotal_mar.OptionsColumn.AllowEdit = false;
            this.colTotal_mar.Visible = true;
            this.colTotal_mar.VisibleIndex = 6;
            this.colTotal_mar.Width = 138;
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "% Ganancia";
            this.gridColumn41.FieldName = "Porc_ganancia";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Marcaciones});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(925, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnImprimir_Marcaciones
            // 
            this.btnImprimir_Marcaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Marcaciones.Image")));
            this.btnImprimir_Marcaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Marcaciones.Name = "btnImprimir_Marcaciones";
            this.btnImprimir_Marcaciones.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Marcaciones.Text = "Imprimir";
            // 
            // tabPageAtivos
            // 
            this.tabPageAtivos.Controls.Add(this.gridControlActivos);
            this.tabPageAtivos.Controls.Add(this.toolStrip6);
            this.tabPageAtivos.Name = "tabPageAtivos";
            this.tabPageAtivos.Size = new System.Drawing.Size(925, 298);
            this.tabPageAtivos.Text = "Ubicación activos";
            // 
            // gridControlActivos
            // 
            this.gridControlActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlActivos.Location = new System.Drawing.Point(0, 25);
            this.gridControlActivos.MainView = this.gridViewActivos;
            this.gridControlActivos.Name = "gridControlActivos";
            this.gridControlActivos.Size = new System.Drawing.Size(925, 273);
            this.gridControlActivos.TabIndex = 0;
            this.gridControlActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivos});
            // 
            // gridViewActivos
            // 
            this.gridViewActivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gridViewActivos.GridControl = this.gridControlActivos;
            this.gridViewActivos.GroupCount = 3;
            this.gridViewActivos.GroupFormat = "[#image]{1} {2}";
            this.gridViewActivos.Name = "gridViewActivos";
            this.gridViewActivos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewActivos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewActivos.OptionsView.ShowGroupPanel = false;
            this.gridViewActivos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn10, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn11, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "nom_Cliente";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "nom_Categoria";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Activo";
            this.gridColumn13.FieldName = "Af_Nombre";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 83;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Encargado";
            this.gridColumn14.FieldName = "nom_encargado";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // toolStrip6
            // 
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir_Ubicacion});
            this.toolStrip6.Location = new System.Drawing.Point(0, 0);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(925, 25);
            this.toolStrip6.TabIndex = 1;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // btnImprimir_Ubicacion
            // 
            this.btnImprimir_Ubicacion.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir_Ubicacion.Image")));
            this.btnImprimir_Ubicacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir_Ubicacion.Name = "btnImprimir_Ubicacion";
            this.btnImprimir_Ubicacion.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir_Ubicacion.Text = "Imprimir";
            // 
            // tab_ManoObra
            // 
            this.tab_ManoObra.Controls.Add(this.gridControl_mano_obra);
            this.tab_ManoObra.Controls.Add(this.toolStrip8);
            this.tab_ManoObra.Name = "tab_ManoObra";
            this.tab_ManoObra.Size = new System.Drawing.Size(925, 298);
            this.tab_ManoObra.Text = "Mano Obra";
            // 
            // gridControl_mano_obra
            // 
            this.gridControl_mano_obra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_mano_obra.Location = new System.Drawing.Point(0, 25);
            this.gridControl_mano_obra.MainView = this.gridView_mano_obra;
            this.gridControl_mano_obra.Name = "gridControl_mano_obra";
            this.gridControl_mano_obra.Size = new System.Drawing.Size(925, 273);
            this.gridControl_mano_obra.TabIndex = 3;
            this.gridControl_mano_obra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_mano_obra});
            // 
            // gridView_mano_obra
            // 
            this.gridView_mano_obra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_pe_nombreCompleto,
            this.cOL_pe_cedulaRuc,
            this.cOL_ca_descripcion,
            this.COL_SALARIO,
            this.cOL_H_EXTRAS,
            this.cOL_ALIMENTACION,
            this.Col_TOTAL_INGRESOS,
            this.Col_T_BENEFICIOS,
            this.Col_TOTAL_M_O});
            this.gridView_mano_obra.GridControl = this.gridControl_mano_obra;
            this.gridView_mano_obra.GroupFormat = "[#image]{1} {2}";
            this.gridView_mano_obra.Name = "gridView_mano_obra";
            this.gridView_mano_obra.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_mano_obra.OptionsView.ColumnAutoWidth = false;
            this.gridView_mano_obra.OptionsView.ShowAutoFilterRow = true;
            // 
            // Col_pe_nombreCompleto
            // 
            this.Col_pe_nombreCompleto.Caption = "NOMBRE";
            this.Col_pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.Col_pe_nombreCompleto.Name = "Col_pe_nombreCompleto";
            this.Col_pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.Col_pe_nombreCompleto.Visible = true;
            this.Col_pe_nombreCompleto.VisibleIndex = 0;
            this.Col_pe_nombreCompleto.Width = 326;
            // 
            // cOL_pe_cedulaRuc
            // 
            this.cOL_pe_cedulaRuc.Caption = "CEDULA";
            this.cOL_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.cOL_pe_cedulaRuc.Name = "cOL_pe_cedulaRuc";
            this.cOL_pe_cedulaRuc.OptionsColumn.AllowEdit = false;
            this.cOL_pe_cedulaRuc.Visible = true;
            this.cOL_pe_cedulaRuc.VisibleIndex = 1;
            this.cOL_pe_cedulaRuc.Width = 111;
            // 
            // cOL_ca_descripcion
            // 
            this.cOL_ca_descripcion.Caption = "CARGO";
            this.cOL_ca_descripcion.FieldName = "ca_descripcion";
            this.cOL_ca_descripcion.Name = "cOL_ca_descripcion";
            this.cOL_ca_descripcion.Visible = true;
            this.cOL_ca_descripcion.VisibleIndex = 2;
            this.cOL_ca_descripcion.Width = 263;
            // 
            // COL_SALARIO
            // 
            this.COL_SALARIO.Caption = "SALARIO";
            this.COL_SALARIO.FieldName = "SALARIO";
            this.COL_SALARIO.Name = "COL_SALARIO";
            this.COL_SALARIO.OptionsColumn.AllowEdit = false;
            this.COL_SALARIO.Visible = true;
            this.COL_SALARIO.VisibleIndex = 3;
            this.COL_SALARIO.Width = 78;
            // 
            // cOL_H_EXTRAS
            // 
            this.cOL_H_EXTRAS.Caption = "HORAS EXTRAS";
            this.cOL_H_EXTRAS.FieldName = "H_EXTRAS";
            this.cOL_H_EXTRAS.Name = "cOL_H_EXTRAS";
            this.cOL_H_EXTRAS.OptionsColumn.AllowEdit = false;
            this.cOL_H_EXTRAS.Visible = true;
            this.cOL_H_EXTRAS.VisibleIndex = 4;
            this.cOL_H_EXTRAS.Width = 107;
            // 
            // cOL_ALIMENTACION
            // 
            this.cOL_ALIMENTACION.Caption = "ALIMENTACION";
            this.cOL_ALIMENTACION.FieldName = "ALIMENTACION";
            this.cOL_ALIMENTACION.Name = "cOL_ALIMENTACION";
            this.cOL_ALIMENTACION.Visible = true;
            this.cOL_ALIMENTACION.VisibleIndex = 5;
            this.cOL_ALIMENTACION.Width = 111;
            // 
            // Col_TOTAL_INGRESOS
            // 
            this.Col_TOTAL_INGRESOS.Caption = "TOTAL_INGRESOS";
            this.Col_TOTAL_INGRESOS.FieldName = "TOTAL_INGRESOS";
            this.Col_TOTAL_INGRESOS.Name = "Col_TOTAL_INGRESOS";
            this.Col_TOTAL_INGRESOS.Visible = true;
            this.Col_TOTAL_INGRESOS.VisibleIndex = 6;
            this.Col_TOTAL_INGRESOS.Width = 108;
            // 
            // Col_T_BENEFICIOS
            // 
            this.Col_T_BENEFICIOS.Caption = "T_BENEFICIOS";
            this.Col_T_BENEFICIOS.FieldName = "T_BENEFICIOS";
            this.Col_T_BENEFICIOS.Name = "Col_T_BENEFICIOS";
            this.Col_T_BENEFICIOS.OptionsColumn.AllowEdit = false;
            this.Col_T_BENEFICIOS.Visible = true;
            this.Col_T_BENEFICIOS.VisibleIndex = 8;
            this.Col_T_BENEFICIOS.Width = 85;
            // 
            // Col_TOTAL_M_O
            // 
            this.Col_TOTAL_M_O.Caption = "TOTAL_M_O";
            this.Col_TOTAL_M_O.FieldName = "TOTAL_M_O";
            this.Col_TOTAL_M_O.Name = "Col_TOTAL_M_O";
            this.Col_TOTAL_M_O.OptionsColumn.AllowEdit = false;
            this.Col_TOTAL_M_O.Visible = true;
            this.Col_TOTAL_M_O.VisibleIndex = 7;
            // 
            // toolStrip8
            // 
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip8.Location = new System.Drawing.Point(0, 0);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(925, 25);
            this.toolStrip8.TabIndex = 2;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Imprimir";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_Intereses);
            this.xtraTabPage1.Controls.Add(this.toolStrip10);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(925, 298);
            this.xtraTabPage1.Text = "Gastos de Intereses";
            // 
            // gridControl_Intereses
            // 
            this.gridControl_Intereses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Intereses.Location = new System.Drawing.Point(0, 25);
            this.gridControl_Intereses.MainView = this.gridView_Intereses;
            this.gridControl_Intereses.Name = "gridControl_Intereses";
            this.gridControl_Intereses.Size = new System.Drawing.Size(925, 273);
            this.gridControl_Intereses.TabIndex = 6;
            this.gridControl_Intereses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Intereses});
            // 
            // gridView_Intereses
            // 
            this.gridView_Intereses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Observac,
            this.Col_Val});
            this.gridView_Intereses.GridControl = this.gridControl_Intereses;
            this.gridView_Intereses.Name = "gridView_Intereses";
            this.gridView_Intereses.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Intereses.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Observac
            // 
            this.Col_Observac.Caption = "Observacion";
            this.Col_Observac.FieldName = "Observacion";
            this.Col_Observac.Name = "Col_Observac";
            this.Col_Observac.Visible = true;
            this.Col_Observac.VisibleIndex = 0;
            this.Col_Observac.Width = 1003;
            // 
            // Col_Val
            // 
            this.Col_Val.Caption = "Valorde cuota";
            this.Col_Val.FieldName = "Valor";
            this.Col_Val.Name = "Col_Val";
            this.Col_Val.Visible = true;
            this.Col_Val.VisibleIndex = 1;
            this.Col_Val.Width = 167;
            // 
            // toolStrip10
            // 
            this.toolStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.toolStrip10.Location = new System.Drawing.Point(0, 0);
            this.toolStrip10.Name = "toolStrip10";
            this.toolStrip10.Size = new System.Drawing.Size(925, 25);
            this.toolStrip10.TabIndex = 5;
            this.toolStrip10.Text = "toolStrip10";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton3.Text = "Imprimir";
            // 
            // tab_otrosGastos
            // 
            this.tab_otrosGastos.Controls.Add(this.gridControl_otros);
            this.tab_otrosGastos.Controls.Add(this.toolStrip9);
            this.tab_otrosGastos.Name = "tab_otrosGastos";
            this.tab_otrosGastos.Size = new System.Drawing.Size(925, 298);
            this.tab_otrosGastos.Text = "Otros Gastos";
            // 
            // gridControl_otros
            // 
            this.gridControl_otros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_otros.Location = new System.Drawing.Point(0, 25);
            this.gridControl_otros.MainView = this.gridView_otros;
            this.gridControl_otros.Name = "gridControl_otros";
            this.gridControl_otros.Size = new System.Drawing.Size(925, 273);
            this.gridControl_otros.TabIndex = 4;
            this.gridControl_otros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_otros});
            // 
            // gridView_otros
            // 
            this.gridView_otros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Nombre_Cobro_,
            this.Col_Valor,
            this.Col_Observacion});
            this.gridView_otros.GridControl = this.gridControl_otros;
            this.gridView_otros.Name = "gridView_otros";
            this.gridView_otros.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_otros.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Nombre_Cobro_
            // 
            this.Col_Nombre_Cobro_.Caption = "Descripcion cobro";
            this.Col_Nombre_Cobro_.FieldName = "Nombre_Cobro";
            this.Col_Nombre_Cobro_.Name = "Col_Nombre_Cobro_";
            this.Col_Nombre_Cobro_.Visible = true;
            this.Col_Nombre_Cobro_.VisibleIndex = 0;
            this.Col_Nombre_Cobro_.Width = 404;
            // 
            // Col_Valor
            // 
            this.Col_Valor.Caption = "$Valor";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.Visible = true;
            this.Col_Valor.VisibleIndex = 2;
            this.Col_Valor.Width = 54;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observación";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 1;
            this.Col_Observacion.Width = 449;
            // 
            // toolStrip9
            // 
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip9.Location = new System.Drawing.Point(0, 0);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.Size = new System.Drawing.Size(925, 25);
            this.toolStrip9.TabIndex = 3;
            this.toolStrip9.Text = "toolStrip9";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton2.Text = "Imprimir";
            // 
            // FrmFa_PreFacturacion_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 496);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmFa_PreFacturacion_Mantenimiento";
            this.Text = "Pre-facturación mantenimiento";
            this.Load += new System.EventHandler(this.FrmFa_PreFacturacion_Mantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlProceso.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlPre_fact)).EndInit();
            this.tabControlPre_fact.ResumeLayout(false);
            this.tabPageEgresos.ResumeLayout(false);
            this.tabPageEgresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEgresos_bodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEgresos_bodega)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageGastos_x_factura.ResumeLayout(false);
            this.tabPageGastos_x_factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPageMovilziacion.ResumeLayout(false);
            this.tabPageMovilziacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovilizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovilizacion)).EndInit();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.tabPageDepreciacion.ResumeLayout(false);
            this.tabPageDepreciacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepreciacion)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tabPagePoliza.ResumeLayout(false);
            this.tabPagePoliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPoliza)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.tabPageHorometro.ResumeLayout(false);
            this.tabPageHorometro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcaciones)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPageAtivos.ResumeLayout(false);
            this.tabPageAtivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivos)).EndInit();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.tab_ManoObra.ResumeLayout(false);
            this.tab_ManoObra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_mano_obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_mano_obra)).EndInit();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Intereses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Intereses)).EndInit();
            this.toolStrip10.ResumeLayout(false);
            this.toolStrip10.PerformLayout();
            this.tab_otrosGastos.ResumeLayout(false);
            this.tab_otrosGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_otros)).EndInit();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraTreeList.TreeList tlClientes;
        private DevExpress.XtraTab.XtraTabControl tabControlPre_fact;
        private DevExpress.XtraTab.XtraTabPage tabPageEgresos;
        private DevExpress.XtraEditors.SimpleButton btn_Procesar;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlProceso;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private DevExpress.XtraEditors.TextEdit txt_IdPreFacturacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit de_Fecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txt_Observacion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblAnulado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolNom_cliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Controles.UCFa_CatalogosCmb ucFa_CatalogosCmb1;
        private DevExpress.XtraGrid.GridControl gridControlEgresos_bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEgresos_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_egr;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoUnitario_egr;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_egr;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraTab.XtraTabPage tabPageAtivos;
        private DevExpress.XtraGrid.GridControl gridControlActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn colIva_egr;
        private DevExpress.XtraTab.XtraTabPage tabPageGastos_x_factura;
        private DevExpress.XtraTab.XtraTabPage tabPageDepreciacion;
        private DevExpress.XtraTab.XtraTabPage tabPagePoliza;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraTab.XtraTabPage tabPageHorometro;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private DevExpress.XtraGrid.GridControl gridControlMarcaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarcaciones;
        private DevExpress.XtraGrid.GridControl gridControlGastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGastos;
        private DevExpress.XtraGrid.GridControl gridControlDepreciacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepreciacion;
        private DevExpress.XtraGrid.GridControl gridControlPoliza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPoliza;
        private System.Windows.Forms.ToolStripButton btnImprimir_Marcaciones;
        private System.Windows.Forms.ToolStripButton btnImprimir_Egresos;
        private System.Windows.Forms.ToolStripButton btnImprimir_Gastos;
        private System.Windows.Forms.ToolStripButton btnImprimir_Depreciacion;
        private System.Windows.Forms.ToolStripButton btnImprimir_Amortizacion;
        private System.Windows.Forms.ToolStripButton btnImprimir_Ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo_pol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colIva_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoFacturacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_gas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoUnitario_gas;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal_gas;
        private DevExpress.XtraGrid.Columns.GridColumn colIva_gas;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_gas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal_egr;
        private DevExpress.XtraTab.XtraTabPage tabPageMovilziacion;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton btnImprimir_Movilización;
        private DevExpress.XtraGrid.GridControl gridControlMovilizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovilizacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn58;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn59;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn60;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn61;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn62;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_mar;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoUnitario_mar;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal_mar;
        private DevExpress.XtraGrid.Columns.GridColumn colIva_mar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_mar;
        private DevExpress.XtraGrid.Columns.GridColumn colAplicaIva_egr;
        private DevExpress.XtraGrid.Columns.GridColumn colPorIva_egr;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoUnitario_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad_pol;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraTab.XtraTabPage tab_ManoObra;
        private DevExpress.XtraGrid.GridControl gridControl_mano_obra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_mano_obra;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn COL_SALARIO;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_H_EXTRAS;
        private DevExpress.XtraGrid.Columns.GridColumn cOL_ALIMENTACION;
        private DevExpress.XtraGrid.Columns.GridColumn Col_T_BENEFICIOS;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TOTAL_M_O;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TOTAL_INGRESOS;
        private DevExpress.XtraTab.XtraTabPage tab_otrosGastos;
        private DevExpress.XtraGrid.GridControl gridControl_otros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_otros;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Nombre_Cobro_;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl_Intereses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Intereses;
        private System.Windows.Forms.ToolStrip toolStrip10;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observac;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Val;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagereEspera;
    }
}
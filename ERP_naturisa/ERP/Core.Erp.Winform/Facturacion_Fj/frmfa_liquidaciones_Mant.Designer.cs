namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmfa_liquidaciones_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel_principal = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlDetalle_Gastos = new DevExpress.XtraGrid.GridControl();
            this.gridView_detalleGastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Colpe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coltotal_liquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_consultar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucFa_Cliente = new Core.Erp.Winform.Controles.UCFa_Cliente_x_centro_costo_cmb();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_facturacion_catalogo = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.txtid_liquidaciones = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_periodo = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.btn_Facturar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Procesar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Observacion = new DevExpress.XtraEditors.MemoEdit();
            this.check_probar = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_principal)).BeginInit();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detalleGastos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid_liquidaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_probar.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1111, 28);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.panelControl1);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 28);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1111, 517);
            this.panel_principal.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlDetalle_Gastos);
            this.panelControl1.Controls.Add(this.toolStrip1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 137);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1107, 378);
            this.panelControl1.TabIndex = 17;
            // 
            // gridControlDetalle_Gastos
            // 
            this.gridControlDetalle_Gastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetalle_Gastos.Location = new System.Drawing.Point(2, 27);
            this.gridControlDetalle_Gastos.MainView = this.gridView_detalleGastos;
            this.gridControlDetalle_Gastos.Name = "gridControlDetalle_Gastos";
            this.gridControlDetalle_Gastos.Size = new System.Drawing.Size(1103, 349);
            this.gridControlDetalle_Gastos.TabIndex = 3;
            this.gridControlDetalle_Gastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_detalleGastos});
            // 
            // gridView_detalleGastos
            // 
            this.gridView_detalleGastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Colpe_nombre,
            this.ColObservacion,
            this.Col_subtotal,
            this.Col_Iva,
            this.Coltotal_liquidacion,
            this.Col_IdLiquidacion});
            this.gridView_detalleGastos.GridControl = this.gridControlDetalle_Gastos;
            this.gridView_detalleGastos.Name = "gridView_detalleGastos";
            this.gridView_detalleGastos.OptionsView.ShowFooter = true;
            this.gridView_detalleGastos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_detalleGastos_RowClick);
            // 
            // Colpe_nombre
            // 
            this.Colpe_nombre.Caption = "Cliente";
            this.Colpe_nombre.FieldName = "pe_nombre";
            this.Colpe_nombre.Name = "Colpe_nombre";
            this.Colpe_nombre.Visible = true;
            this.Colpe_nombre.VisibleIndex = 1;
            this.Colpe_nombre.Width = 245;
            // 
            // ColObservacion
            // 
            this.ColObservacion.Caption = "Observacion";
            this.ColObservacion.FieldName = "Observacion";
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.Visible = true;
            this.ColObservacion.VisibleIndex = 2;
            this.ColObservacion.Width = 508;
            // 
            // Col_subtotal
            // 
            this.Col_subtotal.Caption = "Subtotal";
            this.Col_subtotal.FieldName = "Subtotal";
            this.Col_subtotal.Name = "Col_subtotal";
            this.Col_subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_subtotal.Visible = true;
            this.Col_subtotal.VisibleIndex = 3;
            this.Col_subtotal.Width = 85;
            // 
            // Col_Iva
            // 
            this.Col_Iva.Caption = "Iva";
            this.Col_Iva.FieldName = "Iva";
            this.Col_Iva.Name = "Col_Iva";
            this.Col_Iva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Iva.Visible = true;
            this.Col_Iva.VisibleIndex = 4;
            this.Col_Iva.Width = 65;
            // 
            // Coltotal_liquidacion
            // 
            this.Coltotal_liquidacion.Caption = "Total";
            this.Coltotal_liquidacion.FieldName = "total_liquidacion";
            this.Coltotal_liquidacion.Name = "Coltotal_liquidacion";
            this.Coltotal_liquidacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Coltotal_liquidacion.Visible = true;
            this.Coltotal_liquidacion.VisibleIndex = 5;
            this.Coltotal_liquidacion.Width = 175;
            // 
            // Col_IdLiquidacion
            // 
            this.Col_IdLiquidacion.Caption = "Id Liqui.";
            this.Col_IdLiquidacion.FieldName = "IdLiquidacion";
            this.Col_IdLiquidacion.Name = "Col_IdLiquidacion";
            this.Col_IdLiquidacion.Visible = true;
            this.Col_IdLiquidacion.VisibleIndex = 0;
            this.Col_IdLiquidacion.Width = 71;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.toolStripSeparator1,
            this.btn_modificar,
            this.toolStripSeparator2,
            this.btn_consultar});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1103, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_nuevo.Image = global::Core.Erp.Winform.Properties.Resources.mas;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(23, 22);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_modificar
            // 
            this.btn_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_modificar.Image = global::Core.Erp.Winform.Properties.Resources.edit_64x64;
            this.btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(23, 22);
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_consultar
            // 
            this.btn_consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_consultar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(23, 22);
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.check_probar);
            this.panel1.Controls.Add(this.ucFa_Cliente);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.cmb_facturacion_catalogo);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.de_Fecha);
            this.panel1.Controls.Add(this.txtid_liquidaciones);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cmb_periodo);
            this.panel1.Controls.Add(this.btn_Facturar);
            this.panel1.Controls.Add(this.btn_Procesar);
            this.panel1.Controls.Add(this.txt_Observacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 135);
            this.panel1.TabIndex = 16;
            // 
            // ucFa_Cliente
            // 
            this.ucFa_Cliente.Enabled_BtnAccion_cc = true;
            this.ucFa_Cliente.Enabled_BtnAccion_cli = true;
            this.ucFa_Cliente.Enabled_BtnAccion_Scc = true;
            this.ucFa_Cliente.Enabled_cmb_Centro_costo = true;
            this.ucFa_Cliente.Enabled_cmb_Cliente = true;
            this.ucFa_Cliente.Location = new System.Drawing.Point(385, 7);
            this.ucFa_Cliente.Name = "ucFa_Cliente";
            this.ucFa_Cliente.ReadOnly_cmb_Centro_costo = false;
            this.ucFa_Cliente.ReadOnly_cmb_Cliente = false;
            this.ucFa_Cliente.ReadOnly_cmb_Subcentro_costo = false;
            this.ucFa_Cliente.Size = new System.Drawing.Size(427, 78);
            this.ucFa_Cliente.TabIndex = 24;
            this.ucFa_Cliente.Visible_BtnAccion_cc = true;
            this.ucFa_Cliente.Visible_BtnAccion_cli = true;
            this.ucFa_Cliente.Visible_btnAccion_Scc = true;
            this.ucFa_Cliente.Visible_cmb_Centro_costo = true;
            this.ucFa_Cliente.Visible_cmb_Cliente = true;
            this.ucFa_Cliente.Visible_cmb_Subcentro_costo = true;
            this.ucFa_Cliente.Visible_lblCentro_costo = true;
            this.ucFa_Cliente.Visible_lblCliente = true;
            this.ucFa_Cliente.Visible_lblSub_centro_costo = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Estado Facturacion:";
            // 
            // cmb_facturacion_catalogo
            // 
            this.cmb_facturacion_catalogo.Location = new System.Drawing.Point(115, 62);
            this.cmb_facturacion_catalogo.Name = "cmb_facturacion_catalogo";
            this.cmb_facturacion_catalogo.Size = new System.Drawing.Size(308, 30);
            this.cmb_facturacion_catalogo.TabIndex = 22;
            this.cmb_facturacion_catalogo.Visible_cmb_Accion = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Desde:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(812, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Fecha:";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = new System.DateTime(2016, 4, 22, 12, 36, 16, 861);
            this.de_Fecha.Location = new System.Drawing.Point(909, 35);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(90, 20);
            this.de_Fecha.TabIndex = 14;
            // 
            // txtid_liquidaciones
            // 
            this.txtid_liquidaciones.Location = new System.Drawing.Point(909, 9);
            this.txtid_liquidaciones.Name = "txtid_liquidaciones";
            this.txtid_liquidaciones.Properties.ReadOnly = true;
            this.txtid_liquidaciones.Size = new System.Drawing.Size(90, 20);
            this.txtid_liquidaciones.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(812, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Id Liquidaciones:";
            // 
            // cmb_periodo
            // 
            this.cmb_periodo.Enabled_cmb_Periodo = true;
            this.cmb_periodo.Enabled_de_Desde = true;
            this.cmb_periodo.Enabled_de_Hasta = true;
            this.cmb_periodo.Location = new System.Drawing.Point(44, 7);
            this.cmb_periodo.Name = "cmb_periodo";
            this.cmb_periodo.ReadOnly_cmb_Periodo = false;
            this.cmb_periodo.ReadOnly_de_Desde = true;
            this.cmb_periodo.ReadOnly_de_Hasta = true;
            this.cmb_periodo.Size = new System.Drawing.Size(342, 56);
            this.cmb_periodo.TabIndex = 9;
            this.cmb_periodo.Visible_cmb_Periodo = true;
            this.cmb_periodo.Visible_de_Desde = true;
            this.cmb_periodo.Visible_de_Hasta = true;
            this.cmb_periodo.Visible_lblDesde = false;
            this.cmb_periodo.Visible_lblHasta = true;
            this.cmb_periodo.Visible_lblPeriodo = false;
            this.cmb_periodo.event_delegate_cmb_Periodo_EditValueChanged += new Core.Erp.Winform.Controles.UCCon_Periodo.delegate_cmb_Periodo_EditValueChanged(this.cmb_periodo_event_delegate_cmb_Periodo_EditValueChanged_1);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Location = new System.Drawing.Point(1018, 39);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(82, 28);
            this.btn_Facturar.TabIndex = 8;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Location = new System.Drawing.Point(1018, 7);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(82, 30);
            this.btn_Procesar.TabIndex = 7;
            this.btn_Procesar.Text = "Procesar";
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Observacion.Location = new System.Drawing.Point(0, 98);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(1107, 37);
            this.txt_Observacion.TabIndex = 12;
            // 
            // check_probar
            // 
            this.check_probar.Location = new System.Drawing.Point(818, 67);
            this.check_probar.Name = "check_probar";
            this.check_probar.Properties.Caption = "Probar Reporte por Empresa";
            this.check_probar.Size = new System.Drawing.Size(168, 19);
            this.check_probar.TabIndex = 25;
            // 
            // frmfa_liquidaciones_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 545);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmfa_liquidaciones_Mant";
            this.Text = "Liquidaciones de gasto";
            this.Load += new System.EventHandler(this.frmfa_liquidaciones_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_principal)).EndInit();
            this.panel_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle_Gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detalleGastos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid_liquidaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_probar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl panel_principal;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetalle_Gastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_detalleGastos;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn Coltotal_liquidacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_consultar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit de_Fecha;
        private DevExpress.XtraEditors.TextEdit txtid_liquidaciones;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Controles.UCCon_Periodo cmb_periodo;
        private DevExpress.XtraEditors.SimpleButton btn_Facturar;
        private DevExpress.XtraEditors.SimpleButton btn_Procesar;
        private DevExpress.XtraEditors.MemoEdit txt_Observacion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Controles.UCFa_CatalogosCmb cmb_facturacion_catalogo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdLiquidacion;
        private Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente;
        private DevExpress.XtraEditors.CheckEdit check_probar;

    }
}
namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_Tarifario_Mantenimiento
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
            this.gridControlDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoriaAf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Categoria = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescipcion_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor_x_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUnidades_minimas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tabControlTarifario_det = new DevExpress.XtraTab.XtraTabControl();
            this.tabDetalle = new DevExpress.XtraTab.XtraTabPage();
            this.tabActivosxCategoria = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlActivos = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAf_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_x_Unidad_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades_minimas_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad_Fact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Num_empleado_relacionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Margenes_Ganancia = new DevExpress.XtraGrid.GridControl();
            this.gridView_Margenes_Ganancia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColAnio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel_datos_depreciacion = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_activos_depreciar = new DevExpress.XtraGrid.GridControl();
            this.gridView_activos_depreciar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_activo_fijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Vida_util = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valo_salvamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_porcentaje_depreciacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAf_costo_historico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Af_costo_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAf_Meses_depreciar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAf_fecha_ini_depre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Af_fecha_fin_depre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAf_ValorResidual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colse_factura_valorSalvamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.check_iva = new System.Windows.Forms.CheckBox();
            this.check_factura_Valor_Salvamento = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_tabla_Depreciacion = new DevExpress.XtraGrid.GridControl();
            this.gridView_tabla_Depreciacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Af_Nomnre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor_Compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor_Salvamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColValor_Depreciacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor_Depre_Acum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlPrincipal = new DevExpress.XtraEditors.GroupControl();
            this.txt_porcenaje_poliza = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_movilizacion = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_porcentaje_ganancia = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ucFa_CatalogosCmb1 = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.deFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.deFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ucFa_Cliente = new Core.Erp.Winform.Controles.UCFa_Cliente_x_centro_costo_cmb();
            this.group_box_parametro_fact = new DevExpress.XtraEditors.GroupControl();
            this.che_recargo_interes = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_otros = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_horas_minimas = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_horometro = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_margen_ganacia = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_factura_gastos_roles = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_egreso_bodega = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_gatos = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_movilizacion = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_seguro = new DevExpress.XtraEditors.CheckEdit();
            this.check_se_fact_depreciacion = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlTarifario_det)).BeginInit();
            this.tabControlTarifario_det.SuspendLayout();
            this.tabDetalle.SuspendLayout();
            this.tabActivosxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivos)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Margenes_Ganancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Margenes_Ganancia)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.panel_datos_depreciacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_activos_depreciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_activos_depreciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_factura_Valor_Salvamento.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tabla_Depreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tabla_Depreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPrincipal)).BeginInit();
            this.groupControlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcenaje_poliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_movilizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_ganancia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_box_parametro_fact)).BeginInit();
            this.group_box_parametro_fact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.che_recargo_interes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_otros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_horas_minimas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_horometro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_margen_ganacia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_factura_gastos_roles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_egreso_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_gatos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_movilizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_seguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_depreciacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDetalle
            // 
            this.gridControlDetalle.Location = new System.Drawing.Point(0, 0);
            this.gridControlDetalle.MainView = this.gridViewDetalle;
            this.gridControlDetalle.Name = "gridControlDetalle";
            this.gridControlDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Categoria});
            this.gridControlDetalle.ShowOnlyPredefinedDetails = true;
            this.gridControlDetalle.Size = new System.Drawing.Size(1105, 290);
            this.gridControlDetalle.TabIndex = 0;
            this.gridControlDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalle});
            // 
            // gridViewDetalle
            // 
            this.gridViewDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCategoriaAf,
            this.ColCantidad,
            this.ColValor_x_Unidad,
            this.ColUnidades_minimas});
            this.gridViewDetalle.GridControl = this.gridControlDetalle;
            this.gridViewDetalle.Name = "gridViewDetalle";
            this.gridViewDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalle.OptionsView.ShowGroupPanel = false;
            this.gridViewDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDetalle_CellValueChanged);
            this.gridViewDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewDetalle_KeyDown);
            // 
            // colIdCategoriaAf
            // 
            this.colIdCategoriaAf.Caption = "Categoría";
            this.colIdCategoriaAf.ColumnEdit = this.cmb_Categoria;
            this.colIdCategoriaAf.FieldName = "IdCategoriaAF";
            this.colIdCategoriaAf.Name = "colIdCategoriaAf";
            this.colIdCategoriaAf.Visible = true;
            this.colIdCategoriaAf.VisibleIndex = 0;
            this.colIdCategoriaAf.Width = 461;
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.AutoHeight = false;
            this.cmb_Categoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_cat,
            this.colDescipcion_cat});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId_cat
            // 
            this.colId_cat.Caption = "ID";
            this.colId_cat.FieldName = "IdCategoriaAF";
            this.colId_cat.Name = "colId_cat";
            this.colId_cat.Visible = true;
            this.colId_cat.VisibleIndex = 1;
            this.colId_cat.Width = 99;
            // 
            // colDescipcion_cat
            // 
            this.colDescipcion_cat.Caption = "Categoria";
            this.colDescipcion_cat.FieldName = "Descripcion";
            this.colDescipcion_cat.Name = "colDescipcion_cat";
            this.colDescipcion_cat.Visible = true;
            this.colDescipcion_cat.VisibleIndex = 0;
            this.colDescipcion_cat.Width = 399;
            // 
            // ColCantidad
            // 
            this.ColCantidad.Caption = "Cantidad";
            this.ColCantidad.FieldName = "cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Visible = true;
            this.ColCantidad.VisibleIndex = 1;
            this.ColCantidad.Width = 122;
            // 
            // ColValor_x_Unidad
            // 
            this.ColValor_x_Unidad.Caption = "Costo Hrs/Km";
            this.ColValor_x_Unidad.FieldName = "Valor_x_Unidad";
            this.ColValor_x_Unidad.Name = "ColValor_x_Unidad";
            this.ColValor_x_Unidad.Visible = true;
            this.ColValor_x_Unidad.VisibleIndex = 3;
            this.ColValor_x_Unidad.Width = 155;
            // 
            // ColUnidades_minimas
            // 
            this.ColUnidades_minimas.Caption = "Unidades Minimas Hrs/Km";
            this.ColUnidades_minimas.FieldName = "Unidades_minimas";
            this.ColUnidades_minimas.Name = "ColUnidades_minimas";
            this.ColUnidades_minimas.Visible = true;
            this.ColUnidades_minimas.VisibleIndex = 2;
            this.ColUnidades_minimas.Width = 128;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1111, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
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
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.tabControlTarifario_det);
            this.panelPrincipal.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panelPrincipal.Controls.Add(this.splitContainerControl1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 29);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1111, 546);
            this.panelPrincipal.TabIndex = 2;
            // 
            // tabControlTarifario_det
            // 
            this.tabControlTarifario_det.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTarifario_det.Location = new System.Drawing.Point(0, 199);
            this.tabControlTarifario_det.Name = "tabControlTarifario_det";
            this.tabControlTarifario_det.SelectedTabPage = this.tabDetalle;
            this.tabControlTarifario_det.Size = new System.Drawing.Size(1111, 321);
            this.tabControlTarifario_det.TabIndex = 2;
            this.tabControlTarifario_det.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDetalle,
            this.tabActivosxCategoria,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // tabDetalle
            // 
            this.tabDetalle.Controls.Add(this.gridControlDetalle);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Size = new System.Drawing.Size(1105, 293);
            this.tabDetalle.Text = "Detalle tarifario";
            // 
            // tabActivosxCategoria
            // 
            this.tabActivosxCategoria.Controls.Add(this.gridControlActivos);
            this.tabActivosxCategoria.Name = "tabActivosxCategoria";
            this.tabActivosxCategoria.Size = new System.Drawing.Size(1105, 293);
            this.tabActivosxCategoria.Text = "Activos x Categoria";
            // 
            // gridControlActivos
            // 
            this.gridControlActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlActivos.Location = new System.Drawing.Point(0, 0);
            this.gridControlActivos.MainView = this.gridViewActivos;
            this.gridControlActivos.Name = "gridControlActivos";
            this.gridControlActivos.Size = new System.Drawing.Size(1105, 293);
            this.gridControlActivos.TabIndex = 0;
            this.gridControlActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivos});
            // 
            // gridViewActivos
            // 
            this.gridViewActivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAf_Nombre,
            this.colSeleccionado,
            this.colValor_x_Unidad_A,
            this.colUnidades_minimas_A,
            this.colCategoria,
            this.colUnidad_Fact,
            this.col_Num_empleado_relacionado});
            this.gridViewActivos.GridControl = this.gridControlActivos;
            this.gridViewActivos.GroupCount = 1;
            this.gridViewActivos.Name = "gridViewActivos";
            this.gridViewActivos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewActivos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewActivos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewActivos.OptionsView.ShowGroupPanel = false;
            this.gridViewActivos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoria, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewActivos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewActivos_CellValueChanged);
            // 
            // colAf_Nombre
            // 
            this.colAf_Nombre.Caption = "Activo fijo";
            this.colAf_Nombre.FieldName = "Af_Nombre";
            this.colAf_Nombre.Name = "colAf_Nombre";
            this.colAf_Nombre.OptionsColumn.AllowEdit = false;
            this.colAf_Nombre.Visible = true;
            this.colAf_Nombre.VisibleIndex = 1;
            this.colAf_Nombre.Width = 443;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = "*";
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 0;
            this.colSeleccionado.Width = 55;
            // 
            // colValor_x_Unidad_A
            // 
            this.colValor_x_Unidad_A.Caption = "Valor x unidad Km/hrs";
            this.colValor_x_Unidad_A.FieldName = "Valor_x_Unidad";
            this.colValor_x_Unidad_A.Name = "colValor_x_Unidad_A";
            this.colValor_x_Unidad_A.Visible = true;
            this.colValor_x_Unidad_A.VisibleIndex = 4;
            this.colValor_x_Unidad_A.Width = 134;
            // 
            // colUnidades_minimas_A
            // 
            this.colUnidades_minimas_A.Caption = "Unidades mínimas Km/hrs";
            this.colUnidades_minimas_A.FieldName = "Unidades_minimas";
            this.colUnidades_minimas_A.Name = "colUnidades_minimas_A";
            this.colUnidades_minimas_A.Visible = true;
            this.colUnidades_minimas_A.VisibleIndex = 3;
            this.colUnidades_minimas_A.Width = 139;
            // 
            // colCategoria
            // 
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.FieldName = "nom_Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 4;
            // 
            // colUnidad_Fact
            // 
            this.colUnidad_Fact.Caption = "Unidad Km/hrs";
            this.colUnidad_Fact.FieldName = "nom_UnidadFact";
            this.colUnidad_Fact.Name = "colUnidad_Fact";
            this.colUnidad_Fact.OptionsColumn.AllowEdit = false;
            this.colUnidad_Fact.Visible = true;
            this.colUnidad_Fact.VisibleIndex = 2;
            this.colUnidad_Fact.Width = 94;
            // 
            // col_Num_empleado_relacionado
            // 
            this.col_Num_empleado_relacionado.Caption = "Nº Max Empleado Relacionado";
            this.col_Num_empleado_relacionado.FieldName = "Num_empleado_relacionado";
            this.col_Num_empleado_relacionado.Name = "col_Num_empleado_relacionado";
            this.col_Num_empleado_relacionado.Visible = true;
            this.col_Num_empleado_relacionado.VisibleIndex = 5;
            this.col_Num_empleado_relacionado.Width = 222;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_Margenes_Ganancia);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1105, 293);
            this.xtraTabPage1.Text = "Margenes de Ganancia por Año";
            // 
            // gridControl_Margenes_Ganancia
            // 
            this.gridControl_Margenes_Ganancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Margenes_Ganancia.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Margenes_Ganancia.MainView = this.gridView_Margenes_Ganancia;
            this.gridControl_Margenes_Ganancia.Name = "gridControl_Margenes_Ganancia";
            this.gridControl_Margenes_Ganancia.Size = new System.Drawing.Size(1105, 293);
            this.gridControl_Margenes_Ganancia.TabIndex = 0;
            this.gridControl_Margenes_Ganancia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Margenes_Ganancia});
            // 
            // gridView_Margenes_Ganancia
            // 
            this.gridView_Margenes_Ganancia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColAnio,
            this.Col_porcentaje,
            this.Col_Fecha_desde,
            this.Col_Fecha_Hasta});
            this.gridView_Margenes_Ganancia.GridControl = this.gridControl_Margenes_Ganancia;
            this.gridView_Margenes_Ganancia.Name = "gridView_Margenes_Ganancia";
            this.gridView_Margenes_Ganancia.OptionsView.ColumnAutoWidth = false;
            this.gridView_Margenes_Ganancia.OptionsView.ShowGroupPanel = false;
            // 
            // ColAnio
            // 
            this.ColAnio.Caption = "Año";
            this.ColAnio.FieldName = "IdAnio";
            this.ColAnio.Name = "ColAnio";
            this.ColAnio.OptionsColumn.AllowEdit = false;
            this.ColAnio.Visible = true;
            this.ColAnio.VisibleIndex = 0;
            this.ColAnio.Width = 62;
            // 
            // Col_porcentaje
            // 
            this.Col_porcentaje.Caption = "Margen de Ganancia [%]";
            this.Col_porcentaje.FieldName = "porcentaje";
            this.Col_porcentaje.Name = "Col_porcentaje";
            this.Col_porcentaje.OptionsColumn.AllowEdit = false;
            this.Col_porcentaje.Visible = true;
            this.Col_porcentaje.VisibleIndex = 3;
            this.Col_porcentaje.Width = 128;
            // 
            // Col_Fecha_desde
            // 
            this.Col_Fecha_desde.Caption = "Desde";
            this.Col_Fecha_desde.FieldName = "Fecha_inicio";
            this.Col_Fecha_desde.Name = "Col_Fecha_desde";
            this.Col_Fecha_desde.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_desde.Visible = true;
            this.Col_Fecha_desde.VisibleIndex = 1;
            this.Col_Fecha_desde.Width = 117;
            // 
            // Col_Fecha_Hasta
            // 
            this.Col_Fecha_Hasta.Caption = "Hasta";
            this.Col_Fecha_Hasta.FieldName = "Fecha_Fin";
            this.Col_Fecha_Hasta.Name = "Col_Fecha_Hasta";
            this.Col_Fecha_Hasta.OptionsColumn.AllowEdit = false;
            this.Col_Fecha_Hasta.Visible = true;
            this.Col_Fecha_Hasta.VisibleIndex = 2;
            this.Col_Fecha_Hasta.Width = 113;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel_datos_depreciacion);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1105, 293);
            this.xtraTabPage2.Text = "Depreciación";
            // 
            // panel_datos_depreciacion
            // 
            this.panel_datos_depreciacion.Controls.Add(this.xtraTabControl1);
            this.panel_datos_depreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos_depreciacion.Location = new System.Drawing.Point(0, 0);
            this.panel_datos_depreciacion.Name = "panel_datos_depreciacion";
            this.panel_datos_depreciacion.Size = new System.Drawing.Size(1105, 293);
            this.panel_datos_depreciacion.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(1105, 293);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl_activos_depreciar);
            this.xtraTabPage3.Controls.Add(this.panelControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1099, 265);
            this.xtraTabPage3.Text = "Parametros Depreciacion";
            // 
            // gridControl_activos_depreciar
            // 
            this.gridControl_activos_depreciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_activos_depreciar.Location = new System.Drawing.Point(0, 53);
            this.gridControl_activos_depreciar.MainView = this.gridView_activos_depreciar;
            this.gridControl_activos_depreciar.Name = "gridControl_activos_depreciar";
            this.gridControl_activos_depreciar.Size = new System.Drawing.Size(1099, 212);
            this.gridControl_activos_depreciar.TabIndex = 3;
            this.gridControl_activos_depreciar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_activos_depreciar});
            // 
            // gridView_activos_depreciar
            // 
            this.gridView_activos_depreciar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_activo_fijo,
            this.Col_Vida_util,
            this.Col_Valo_salvamento,
            this.col_porcentaje_depreciacion,
            this.ColAf_costo_historico,
            this.Col_Af_costo_compra,
            this.ColAf_Meses_depreciar,
            this.ColAf_fecha_ini_depre,
            this.Col_Af_fecha_fin_depre,
            this.ColAf_ValorResidual,
            this.Colse_factura_valorSalvamento});
            this.gridView_activos_depreciar.GridControl = this.gridControl_activos_depreciar;
            this.gridView_activos_depreciar.Name = "gridView_activos_depreciar";
            this.gridView_activos_depreciar.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_activos_depreciar.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_activos_depreciar.OptionsView.ShowAutoFilterRow = true;
            this.gridView_activos_depreciar.OptionsView.ShowGroupPanel = false;
            // 
            // col_activo_fijo
            // 
            this.col_activo_fijo.Caption = "Activo fijo";
            this.col_activo_fijo.FieldName = "Af_Nombre";
            this.col_activo_fijo.Name = "col_activo_fijo";
            this.col_activo_fijo.OptionsColumn.AllowEdit = false;
            this.col_activo_fijo.Visible = true;
            this.col_activo_fijo.VisibleIndex = 0;
            this.col_activo_fijo.Width = 196;
            // 
            // Col_Vida_util
            // 
            this.Col_Vida_util.Caption = "Vida Util [Año]";
            this.Col_Vida_util.FieldName = "Af_anios_vida_util";
            this.Col_Vida_util.Name = "Col_Vida_util";
            this.Col_Vida_util.Visible = true;
            this.Col_Vida_util.VisibleIndex = 1;
            this.Col_Vida_util.Width = 84;
            // 
            // Col_Valo_salvamento
            // 
            this.Col_Valo_salvamento.Caption = "Valor salvamento";
            this.Col_Valo_salvamento.FieldName = "Af_ValorSalvamento";
            this.Col_Valo_salvamento.Name = "Col_Valo_salvamento";
            this.Col_Valo_salvamento.Visible = true;
            this.Col_Valo_salvamento.VisibleIndex = 2;
            this.Col_Valo_salvamento.Width = 111;
            // 
            // col_porcentaje_depreciacion
            // 
            this.col_porcentaje_depreciacion.Caption = "% depreciacion";
            this.col_porcentaje_depreciacion.FieldName = "Af_porcentaje_deprec";
            this.col_porcentaje_depreciacion.Name = "col_porcentaje_depreciacion";
            this.col_porcentaje_depreciacion.Visible = true;
            this.col_porcentaje_depreciacion.VisibleIndex = 3;
            this.col_porcentaje_depreciacion.Width = 90;
            // 
            // ColAf_costo_historico
            // 
            this.ColAf_costo_historico.Caption = "Costo Historico";
            this.ColAf_costo_historico.FieldName = "Af_costo_historico";
            this.ColAf_costo_historico.Name = "ColAf_costo_historico";
            this.ColAf_costo_historico.Visible = true;
            this.ColAf_costo_historico.VisibleIndex = 4;
            this.ColAf_costo_historico.Width = 79;
            // 
            // Col_Af_costo_compra
            // 
            this.Col_Af_costo_compra.Caption = "Costo Compra";
            this.Col_Af_costo_compra.FieldName = "Af_costo_compra";
            this.Col_Af_costo_compra.Name = "Col_Af_costo_compra";
            this.Col_Af_costo_compra.Visible = true;
            this.Col_Af_costo_compra.VisibleIndex = 5;
            this.Col_Af_costo_compra.Width = 79;
            // 
            // ColAf_Meses_depreciar
            // 
            this.ColAf_Meses_depreciar.Caption = "Meses Depreciacion";
            this.ColAf_Meses_depreciar.FieldName = "Af_Meses_depreciar";
            this.ColAf_Meses_depreciar.Name = "ColAf_Meses_depreciar";
            this.ColAf_Meses_depreciar.Visible = true;
            this.ColAf_Meses_depreciar.VisibleIndex = 6;
            this.ColAf_Meses_depreciar.Width = 79;
            // 
            // ColAf_fecha_ini_depre
            // 
            this.ColAf_fecha_ini_depre.Caption = "Fecha Inicio";
            this.ColAf_fecha_ini_depre.FieldName = "Af_fecha_ini_depre";
            this.ColAf_fecha_ini_depre.Name = "ColAf_fecha_ini_depre";
            this.ColAf_fecha_ini_depre.Visible = true;
            this.ColAf_fecha_ini_depre.VisibleIndex = 7;
            this.ColAf_fecha_ini_depre.Width = 79;
            // 
            // Col_Af_fecha_fin_depre
            // 
            this.Col_Af_fecha_fin_depre.Caption = "Fecha Fin";
            this.Col_Af_fecha_fin_depre.FieldName = "Af_fecha_fin_depre";
            this.Col_Af_fecha_fin_depre.Name = "Col_Af_fecha_fin_depre";
            this.Col_Af_fecha_fin_depre.Visible = true;
            this.Col_Af_fecha_fin_depre.VisibleIndex = 8;
            this.Col_Af_fecha_fin_depre.Width = 79;
            // 
            // ColAf_ValorResidual
            // 
            this.ColAf_ValorResidual.Caption = "Valor Residual";
            this.ColAf_ValorResidual.FieldName = "Af_ValorResidual";
            this.ColAf_ValorResidual.Name = "ColAf_ValorResidual";
            this.ColAf_ValorResidual.Visible = true;
            this.ColAf_ValorResidual.VisibleIndex = 9;
            this.ColAf_ValorResidual.Width = 79;
            // 
            // Colse_factura_valorSalvamento
            // 
            this.Colse_factura_valorSalvamento.Caption = "Se Fact Valor Salvamento";
            this.Colse_factura_valorSalvamento.FieldName = "se_factura_valorSalvamento";
            this.Colse_factura_valorSalvamento.Name = "Colse_factura_valorSalvamento";
            this.Colse_factura_valorSalvamento.Visible = true;
            this.Colse_factura_valorSalvamento.VisibleIndex = 10;
            this.Colse_factura_valorSalvamento.Width = 158;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1099, 53);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.check_iva);
            this.groupControl1.Controls.Add(this.check_factura_Valor_Salvamento);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(914, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(183, 49);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Se Factura:";
            // 
            // check_iva
            // 
            this.check_iva.AutoSize = true;
            this.check_iva.Location = new System.Drawing.Point(130, 22);
            this.check_iva.Name = "check_iva";
            this.check_iva.Size = new System.Drawing.Size(41, 17);
            this.check_iva.TabIndex = 1;
            this.check_iva.Text = "Iva";
            this.check_iva.UseVisualStyleBackColor = true;
            this.check_iva.CheckedChanged += new System.EventHandler(this.check_iva_CheckedChanged);
            // 
            // check_factura_Valor_Salvamento
            // 
            this.check_factura_Valor_Salvamento.Location = new System.Drawing.Point(5, 20);
            this.check_factura_Valor_Salvamento.Name = "check_factura_Valor_Salvamento";
            this.check_factura_Valor_Salvamento.Properties.Caption = "Valo salvamento";
            this.check_factura_Valor_Salvamento.Size = new System.Drawing.Size(113, 19);
            this.check_factura_Valor_Salvamento.TabIndex = 0;
            this.check_factura_Valor_Salvamento.CheckedChanged += new System.EventHandler(this.check_factura_Valor_Salvamento_CheckedChanged);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gridControl_tabla_Depreciacion);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1099, 265);
            this.xtraTabPage4.Text = "Tabla Depreciacion";
            // 
            // gridControl_tabla_Depreciacion
            // 
            this.gridControl_tabla_Depreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_tabla_Depreciacion.Location = new System.Drawing.Point(0, 0);
            this.gridControl_tabla_Depreciacion.MainView = this.gridView_tabla_Depreciacion;
            this.gridControl_tabla_Depreciacion.Name = "gridControl_tabla_Depreciacion";
            this.gridControl_tabla_Depreciacion.Size = new System.Drawing.Size(1099, 265);
            this.gridControl_tabla_Depreciacion.TabIndex = 0;
            this.gridControl_tabla_Depreciacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_tabla_Depreciacion});
            // 
            // gridView_tabla_Depreciacion
            // 
            this.gridView_tabla_Depreciacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Af_Nomnre,
            this.Col_Valor_Compra,
            this.ColValor_Salvamento,
            this.ColValor_Depreciacion,
            this.Col_Valor_Depre_Acum});
            this.gridView_tabla_Depreciacion.GridControl = this.gridControl_tabla_Depreciacion;
            this.gridView_tabla_Depreciacion.GroupCount = 1;
            this.gridView_tabla_Depreciacion.Name = "gridView_tabla_Depreciacion";
            this.gridView_tabla_Depreciacion.OptionsView.ShowGroupPanel = false;
            this.gridView_tabla_Depreciacion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Col_Af_Nomnre, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Col_Af_Nomnre
            // 
            this.Col_Af_Nomnre.Caption = "Activo";
            this.Col_Af_Nomnre.FieldName = "Af_Nombre";
            this.Col_Af_Nomnre.Name = "Col_Af_Nomnre";
            this.Col_Af_Nomnre.Visible = true;
            this.Col_Af_Nomnre.VisibleIndex = 0;
            this.Col_Af_Nomnre.Width = 596;
            // 
            // Col_Valor_Compra
            // 
            this.Col_Valor_Compra.Caption = "Valor Compra";
            this.Col_Valor_Compra.FieldName = "Valor_Compra";
            this.Col_Valor_Compra.Name = "Col_Valor_Compra";
            this.Col_Valor_Compra.Visible = true;
            this.Col_Valor_Compra.VisibleIndex = 0;
            this.Col_Valor_Compra.Width = 129;
            // 
            // ColValor_Salvamento
            // 
            this.ColValor_Salvamento.Caption = "Valor Salvamento";
            this.ColValor_Salvamento.FieldName = "Valor_Salvamento";
            this.ColValor_Salvamento.Name = "ColValor_Salvamento";
            this.ColValor_Salvamento.Visible = true;
            this.ColValor_Salvamento.VisibleIndex = 1;
            this.ColValor_Salvamento.Width = 124;
            // 
            // ColValor_Depreciacion
            // 
            this.ColValor_Depreciacion.Caption = "Depreciacion Mensual";
            this.ColValor_Depreciacion.FieldName = "Valor_Depreciacion";
            this.ColValor_Depreciacion.Name = "ColValor_Depreciacion";
            this.ColValor_Depreciacion.Visible = true;
            this.ColValor_Depreciacion.VisibleIndex = 2;
            this.ColValor_Depreciacion.Width = 124;
            // 
            // Col_Valor_Depre_Acum
            // 
            this.Col_Valor_Depre_Acum.Caption = "Depreciacion Acumulada";
            this.Col_Valor_Depre_Acum.FieldName = "Valor_Depre_Acum";
            this.Col_Valor_Depre_Acum.Name = "Col_Valor_Depre_Acum";
            this.Col_Valor_Depre_Acum.Visible = true;
            this.Col_Valor_Depre_Acum.VisibleIndex = 3;
            this.Col_Valor_Depre_Acum.Width = 140;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 520);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1111, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlPrincipal);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.group_box_parametro_fact);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1111, 199);
            this.splitContainerControl1.SplitterPosition = 824;
            this.splitContainerControl1.TabIndex = 36;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControlPrincipal
            // 
            this.groupControlPrincipal.Controls.Add(this.txt_porcenaje_poliza);
            this.groupControlPrincipal.Controls.Add(this.label12);
            this.groupControlPrincipal.Controls.Add(this.txt_movilizacion);
            this.groupControlPrincipal.Controls.Add(this.label11);
            this.groupControlPrincipal.Controls.Add(this.label10);
            this.groupControlPrincipal.Controls.Add(this.txt_porcentaje_ganancia);
            this.groupControlPrincipal.Controls.Add(this.label8);
            this.groupControlPrincipal.Controls.Add(this.label6);
            this.groupControlPrincipal.Controls.Add(this.ucFa_CatalogosCmb1);
            this.groupControlPrincipal.Controls.Add(this.deFecha);
            this.groupControlPrincipal.Controls.Add(this.deFechaFin);
            this.groupControlPrincipal.Controls.Add(this.deFechaInicio);
            this.groupControlPrincipal.Controls.Add(this.label9);
            this.groupControlPrincipal.Controls.Add(this.txtobservacion);
            this.groupControlPrincipal.Controls.Add(this.label7);
            this.groupControlPrincipal.Controls.Add(this.label5);
            this.groupControlPrincipal.Controls.Add(this.label4);
            this.groupControlPrincipal.Controls.Add(this.txtnombre);
            this.groupControlPrincipal.Controls.Add(this.label3);
            this.groupControlPrincipal.Controls.Add(this.txtcodigo);
            this.groupControlPrincipal.Controls.Add(this.label2);
            this.groupControlPrincipal.Controls.Add(this.txtid);
            this.groupControlPrincipal.Controls.Add(this.label1);
            this.groupControlPrincipal.Controls.Add(this.ucFa_Cliente);
            this.groupControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.groupControlPrincipal.Name = "groupControlPrincipal";
            this.groupControlPrincipal.Size = new System.Drawing.Size(824, 199);
            this.groupControlPrincipal.TabIndex = 0;
            this.groupControlPrincipal.Text = "Datos Generales";
            this.groupControlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlPrincipal_Paint);
            // 
            // txt_porcenaje_poliza
            // 
            this.txt_porcenaje_poliza.Location = new System.Drawing.Point(644, 96);
            this.txt_porcenaje_poliza.Name = "txt_porcenaje_poliza";
            this.txt_porcenaje_poliza.Properties.Mask.EditMask = "p";
            this.txt_porcenaje_poliza.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_porcenaje_poliza.Size = new System.Drawing.Size(175, 20);
            this.txt_porcenaje_poliza.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "% Recargo Intereses Póliza:";
            // 
            // txt_movilizacion
            // 
            this.txt_movilizacion.EditValue = 0D;
            this.txt_movilizacion.Location = new System.Drawing.Point(644, 73);
            this.txt_movilizacion.Name = "txt_movilizacion";
            this.txt_movilizacion.Properties.Mask.EditMask = "n0";
            this.txt_movilizacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_movilizacion.Size = new System.Drawing.Size(175, 20);
            this.txt_movilizacion.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Movillización por Activo Fijo $:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cliente:";
            // 
            // txt_porcentaje_ganancia
            // 
            this.txt_porcentaje_ganancia.Location = new System.Drawing.Point(580, 49);
            this.txt_porcentaje_ganancia.Name = "txt_porcentaje_ganancia";
            this.txt_porcentaje_ganancia.Properties.Mask.EditMask = "n0";
            this.txt_porcentaje_ganancia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_porcentaje_ganancia.Size = new System.Drawing.Size(239, 20);
            this.txt_porcentaje_ganancia.TabIndex = 31;
            this.txt_porcentaje_ganancia.EditValueChanged += new System.EventHandler(this.txt_porcentaje_ganancia_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "% Ganacia inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estado:";
            // 
            // ucFa_CatalogosCmb1
            // 
            this.ucFa_CatalogosCmb1.Location = new System.Drawing.Point(573, 22);
            this.ucFa_CatalogosCmb1.Name = "ucFa_CatalogosCmb1";
            this.ucFa_CatalogosCmb1.Size = new System.Drawing.Size(292, 30);
            this.ucFa_CatalogosCmb1.TabIndex = 28;
            this.ucFa_CatalogosCmb1.Visible_cmb_Accion = false;
            // 
            // deFecha
            // 
            this.deFecha.EditValue = new System.DateTime(2016, 5, 7, 10, 43, 20, 0);
            this.deFecha.Location = new System.Drawing.Point(644, 117);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(175, 20);
            this.deFecha.TabIndex = 26;
            // 
            // deFechaFin
            // 
            this.deFechaFin.EditValue = new System.DateTime(((long)(0)));
            this.deFechaFin.Location = new System.Drawing.Point(311, 53);
            this.deFechaFin.Name = "deFechaFin";
            this.deFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaFin.Size = new System.Drawing.Size(125, 20);
            this.deFechaFin.TabIndex = 25;
            this.deFechaFin.EditValueChanged += new System.EventHandler(this.deFechaFin_EditValueChanged);
            // 
            // deFechaInicio
            // 
            this.deFechaInicio.EditValue = new System.DateTime(((long)(0)));
            this.deFechaInicio.Location = new System.Drawing.Point(311, 27);
            this.deFechaInicio.Name = "deFechaInicio";
            this.deFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaInicio.Size = new System.Drawing.Size(125, 20);
            this.deFechaInicio.TabIndex = 24;
            this.deFechaInicio.EditValueChanged += new System.EventHandler(this.deFechaInicio_EditValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha Transacción:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(113, 142);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(706, 39);
            this.txtobservacion.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Observación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha inicio:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(113, 103);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(323, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre tarifario:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(113, 53);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(92, 20);
            this.txtcodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(113, 27);
            this.txtid.Name = "txtid";
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(92, 20);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Tarifario:";
            // 
            // ucFa_Cliente
            // 
            this.ucFa_Cliente.Enabled_BtnAccion_cc = true;
            this.ucFa_Cliente.Enabled_BtnAccion_cli = true;
            this.ucFa_Cliente.Enabled_BtnAccion_Scc = true;
            this.ucFa_Cliente.Enabled_cmb_Centro_costo = true;
            this.ucFa_Cliente.Enabled_cmb_Cliente = true;
            this.ucFa_Cliente.Location = new System.Drawing.Point(24, 76);
            this.ucFa_Cliente.Name = "ucFa_Cliente";
            this.ucFa_Cliente.ReadOnly_cmb_Centro_costo = false;
            this.ucFa_Cliente.ReadOnly_cmb_Cliente = false;
            this.ucFa_Cliente.ReadOnly_cmb_Subcentro_costo = false;
            this.ucFa_Cliente.Size = new System.Drawing.Size(468, 34);
            this.ucFa_Cliente.TabIndex = 23;
            this.ucFa_Cliente.Visible_BtnAccion_cc = false;
            this.ucFa_Cliente.Visible_BtnAccion_cli = true;
            this.ucFa_Cliente.Visible_btnAccion_Scc = false;
            this.ucFa_Cliente.Visible_cmb_Centro_costo = false;
            this.ucFa_Cliente.Visible_cmb_Cliente = true;
            this.ucFa_Cliente.Visible_cmb_Subcentro_costo = false;
            this.ucFa_Cliente.Visible_lblCentro_costo = false;
            this.ucFa_Cliente.Visible_lblCliente = false;
            this.ucFa_Cliente.Visible_lblSub_centro_costo = false;
            // 
            // group_box_parametro_fact
            // 
            this.group_box_parametro_fact.Controls.Add(this.che_recargo_interes);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_otros);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_horas_minimas);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_horometro);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_margen_ganacia);
            this.group_box_parametro_fact.Controls.Add(this.check_se_factura_gastos_roles);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_egreso_bodega);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_gatos);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_movilizacion);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_seguro);
            this.group_box_parametro_fact.Controls.Add(this.check_se_fact_depreciacion);
            this.group_box_parametro_fact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_box_parametro_fact.Location = new System.Drawing.Point(0, 0);
            this.group_box_parametro_fact.Name = "group_box_parametro_fact";
            this.group_box_parametro_fact.Size = new System.Drawing.Size(282, 199);
            this.group_box_parametro_fact.TabIndex = 35;
            this.group_box_parametro_fact.Text = "Parámetros";
            // 
            // che_recargo_interes
            // 
            this.che_recargo_interes.Location = new System.Drawing.Point(5, 176);
            this.che_recargo_interes.Name = "che_recargo_interes";
            this.che_recargo_interes.Properties.Caption = "Se factura Recargo Interes por Póliza";
            this.che_recargo_interes.Size = new System.Drawing.Size(173, 19);
            this.che_recargo_interes.TabIndex = 10;
            // 
            // check_se_fact_otros
            // 
            this.check_se_fact_otros.Location = new System.Drawing.Point(156, 45);
            this.check_se_fact_otros.Name = "check_se_fact_otros";
            this.check_se_fact_otros.Properties.Caption = "Se factura otros";
            this.check_se_fact_otros.Size = new System.Drawing.Size(114, 19);
            this.check_se_fact_otros.TabIndex = 9;
            // 
            // check_se_fact_horas_minimas
            // 
            this.check_se_fact_horas_minimas.Location = new System.Drawing.Point(5, 158);
            this.check_se_fact_horas_minimas.Name = "check_se_fact_horas_minimas";
            this.check_se_fact_horas_minimas.Properties.Caption = "Se factura horas mínimas";
            this.check_se_fact_horas_minimas.Size = new System.Drawing.Size(235, 19);
            this.check_se_fact_horas_minimas.TabIndex = 8;
            // 
            // check_se_fact_horometro
            // 
            this.check_se_fact_horometro.Location = new System.Drawing.Point(5, 137);
            this.check_se_fact_horometro.Name = "check_se_fact_horometro";
            this.check_se_fact_horometro.Properties.Caption = "Se factura Horometro";
            this.check_se_fact_horometro.Size = new System.Drawing.Size(130, 19);
            this.check_se_fact_horometro.TabIndex = 7;
            this.check_se_fact_horometro.CheckedChanged += new System.EventHandler(this.check_se_fact_horometro_CheckedChanged);
            // 
            // check_se_fact_margen_ganacia
            // 
            this.check_se_fact_margen_ganacia.Location = new System.Drawing.Point(5, 117);
            this.check_se_fact_margen_ganacia.Name = "check_se_fact_margen_ganacia";
            this.check_se_fact_margen_ganacia.Properties.Caption = "Se factura margen de ganacia";
            this.check_se_fact_margen_ganacia.Size = new System.Drawing.Size(179, 19);
            this.check_se_fact_margen_ganacia.TabIndex = 6;
            // 
            // check_se_factura_gastos_roles
            // 
            this.check_se_factura_gastos_roles.Location = new System.Drawing.Point(5, 96);
            this.check_se_factura_gastos_roles.Name = "check_se_factura_gastos_roles";
            this.check_se_factura_gastos_roles.Properties.Caption = "Se factura gastos por roles";
            this.check_se_factura_gastos_roles.Size = new System.Drawing.Size(152, 19);
            this.check_se_factura_gastos_roles.TabIndex = 5;
            // 
            // check_se_fact_egreso_bodega
            // 
            this.check_se_fact_egreso_bodega.Location = new System.Drawing.Point(5, 76);
            this.check_se_fact_egreso_bodega.Name = "check_se_fact_egreso_bodega";
            this.check_se_fact_egreso_bodega.Properties.Caption = "se factura egresos de bodegas";
            this.check_se_fact_egreso_bodega.Size = new System.Drawing.Size(179, 19);
            this.check_se_fact_egreso_bodega.TabIndex = 4;
            // 
            // check_se_fact_gatos
            // 
            this.check_se_fact_gatos.Location = new System.Drawing.Point(156, 24);
            this.check_se_fact_gatos.Name = "check_se_fact_gatos";
            this.check_se_fact_gatos.Properties.Caption = "Se factura gastos";
            this.check_se_fact_gatos.Size = new System.Drawing.Size(121, 19);
            this.check_se_fact_gatos.TabIndex = 3;
            // 
            // check_se_fact_movilizacion
            // 
            this.check_se_fact_movilizacion.Location = new System.Drawing.Point(5, 56);
            this.check_se_fact_movilizacion.Name = "check_se_fact_movilizacion";
            this.check_se_fact_movilizacion.Properties.Caption = "Se factura movilización";
            this.check_se_fact_movilizacion.Size = new System.Drawing.Size(130, 19);
            this.check_se_fact_movilizacion.TabIndex = 2;
            // 
            // check_se_fact_seguro
            // 
            this.check_se_fact_seguro.Location = new System.Drawing.Point(5, 38);
            this.check_se_fact_seguro.Name = "check_se_fact_seguro";
            this.check_se_fact_seguro.Properties.Caption = "Se factuta poliza/seguro";
            this.check_se_fact_seguro.Size = new System.Drawing.Size(202, 19);
            this.check_se_fact_seguro.TabIndex = 1;
            // 
            // check_se_fact_depreciacion
            // 
            this.check_se_fact_depreciacion.Location = new System.Drawing.Point(5, 20);
            this.check_se_fact_depreciacion.Name = "check_se_fact_depreciacion";
            this.check_se_fact_depreciacion.Properties.Caption = "Se factura depreciación";
            this.check_se_fact_depreciacion.Size = new System.Drawing.Size(179, 19);
            this.check_se_fact_depreciacion.TabIndex = 0;
            // 
            // frmFa_Tarifario_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 575);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmFa_Tarifario_Mantenimiento";
            this.Text = "Tarifario por cliente mantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFa_Tarifario_Mantenimiento_FormClosed);
            this.Load += new System.EventHandler(this.frmFa_Tarifario_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlTarifario_det)).EndInit();
            this.tabControlTarifario_det.ResumeLayout(false);
            this.tabDetalle.ResumeLayout(false);
            this.tabActivosxCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivos)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Margenes_Ganancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Margenes_Ganancia)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.panel_datos_depreciacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_activos_depreciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_activos_depreciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_factura_Valor_Salvamento.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_tabla_Depreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tabla_Depreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPrincipal)).EndInit();
            this.groupControlPrincipal.ResumeLayout(false);
            this.groupControlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcenaje_poliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_movilizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_ganancia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_box_parametro_fact)).EndInit();
            this.group_box_parametro_fact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.che_recargo_interes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_otros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_horas_minimas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_horometro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_margen_ganacia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_factura_gastos_roles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_egreso_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_gatos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_movilizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_seguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_se_fact_depreciacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelPrincipal;
        private DevExpress.XtraEditors.GroupControl groupControlPrincipal;
        private DevExpress.XtraGrid.GridControl gridControlDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtnombre;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtcodigo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaAf;
        private DevExpress.XtraGrid.Columns.GridColumn ColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor_x_Unidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColUnidades_minimas;
        private Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Categoria;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colDescipcion_cat;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraTab.XtraTabControl tabControlTarifario_det;
        private DevExpress.XtraTab.XtraTabPage tabDetalle;
        private DevExpress.XtraTab.XtraTabPage tabActivosxCategoria;
        private DevExpress.XtraEditors.DateEdit deFechaFin;
        private DevExpress.XtraEditors.DateEdit deFechaInicio;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraGrid.GridControl gridControlActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivos;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_x_Unidad_A;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades_minimas_A;
        private System.Windows.Forms.Label label6;
        private Controles.UCFa_CatalogosCmb ucFa_CatalogosCmb1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad_Fact;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl_Margenes_Ganancia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Margenes_Ganancia;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn ColAnio;
        private DevExpress.XtraGrid.Columns.GridColumn Col_porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_desde;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Hasta;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje_ganancia;
        private System.Windows.Forms.Panel panel_datos_depreciacion;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl_tabla_Depreciacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_tabla_Depreciacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_Nomnre;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor_Compra;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor_Salvamento;
        private DevExpress.XtraGrid.Columns.GridColumn ColValor_Depreciacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor_Depre_Acum;
        private DevExpress.XtraGrid.GridControl gridControl_activos_depreciar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_activos_depreciar;
        private DevExpress.XtraGrid.Columns.GridColumn col_activo_fijo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Vida_util;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valo_salvamento;
        private DevExpress.XtraGrid.Columns.GridColumn col_porcentaje_depreciacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColAf_costo_historico;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_costo_compra;
        private DevExpress.XtraGrid.Columns.GridColumn ColAf_Meses_depreciar;
        private DevExpress.XtraGrid.Columns.GridColumn ColAf_fecha_ini_depre;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_fecha_fin_depre;
        private DevExpress.XtraGrid.Columns.GridColumn ColAf_ValorResidual;
        private DevExpress.XtraGrid.Columns.GridColumn Colse_factura_valorSalvamento;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit check_factura_Valor_Salvamento;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox check_iva;
        private DevExpress.XtraEditors.TextEdit txt_movilizacion;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.GroupControl group_box_parametro_fact;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_margen_ganacia;
        private DevExpress.XtraEditors.CheckEdit check_se_factura_gastos_roles;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_egreso_bodega;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_gatos;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_movilizacion;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_seguro;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_depreciacion;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_horometro;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_horas_minimas;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.CheckEdit check_se_fact_otros;
        private DevExpress.XtraGrid.Columns.GridColumn col_Num_empleado_relacionado;
        private DevExpress.XtraEditors.TextEdit txt_porcenaje_poliza;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.CheckEdit che_recargo_interes;
    }
}
namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ingreso_x_OrdenCompra_Mant
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControlIngreso = new DevExpress.XtraGrid.GridControl();
            this.gridViewIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_pedida_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Ing_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_stock_ante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoRecepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPuntoCargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPunto_cargo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Ing_OC_AUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_ingresada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_estado_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sub_centro_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_grupo_pto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo_punto_cargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IDSUBCENTRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucCp_Proveedor = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1 = new Core.Erp.Winform.Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumIngreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTodos.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1016, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.Load += new System.EventHandler(this.ucGe_Menu_Superior_Mant1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 488);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 488);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle Ingreso O/C";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControlIngreso);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 262);
            this.panel4.TabIndex = 1;
            // 
            // gridControlIngreso
            // 
            this.gridControlIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIngreso.Location = new System.Drawing.Point(0, 0);
            this.gridControlIngreso.MainView = this.gridViewIngreso;
            this.gridControlIngreso.Name = "gridControlIngreso";
            this.gridControlIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCentroCosto_grid,
            this.cmbPuntoCargo_grid,
            this.cmb_unidad_medida,
            this.cmb_sub_centro_costo,
            this.cmb_grupo_punto_cargo});
            this.gridControlIngreso.Size = new System.Drawing.Size(1002, 262);
            this.gridControlIngreso.TabIndex = 0;
            this.gridControlIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIngreso});
            // 
            // gridViewIngreso
            // 
            this.gridViewIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenCompra,
            this.colSecuencia_oc,
            this.colIdProveedor,
            this.colnom_proveedor,
            this.colTipo,
            this.coloc_fecha,
            this.coloc_observacion,
            this.colcod_producto,
            this.colnom_producto,
            this.colIdProducto,
            this.coldm_precio,
            this.colcantidad_pedida_OC,
            this.coldm_cantidad,
            this.colSaldo_x_Ing_OC,
            this.coldm_stock_ante,
            this.coldm_peso,
            this.colCostoProducto,
            this.colEstado,
            this.colIdEstadoAprobacion,
            this.colIdEstadoRecepcion,
            this.colIdCentroCosto,
            this.colIdPunto_cargo,
            this.colChecked,
            this.colSaldo_x_Ing_OC_AUX,
            this.colIdMotivo_OC,
            this.colNom_Motivo,
            this.colcantidad_ingresada,
            this.colIdEstado_cierre,
            this.colnom_estado_cierre,
            this.colIdCentroCosto_sub_centro_costo,
            this.gridColumn10,
            this.col_IdUnidadMedida,
            this.gridColumn15,
            this.gridColumn16,
            this.col_grupo_pto_cargo,
            this.col_IDSUBCENTRO});
            this.gridViewIngreso.CustomizationFormBounds = new System.Drawing.Rectangle(853, 395, 210, 172);
            this.gridViewIngreso.GridControl = this.gridControlIngreso;
            this.gridViewIngreso.GroupCount = 1;
            this.gridViewIngreso.Name = "gridViewIngreso";
            this.gridViewIngreso.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gridViewIngreso.OptionsView.ShowGroupPanel = false;
            this.gridViewIngreso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewIngreso.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewIngreso_RowClick);
            this.gridViewIngreso.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewIngreso_FocusedRowChanged);
            this.gridViewIngreso.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewIngreso_CellValueChanged);
            this.gridViewIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewIngreso_KeyDown);
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "# OC";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 1;
            this.colIdOrdenCompra.Width = 67;
            // 
            // colSecuencia_oc
            // 
            this.colSecuencia_oc.FieldName = "Secuencia_oc";
            this.colSecuencia_oc.Name = "colSecuencia_oc";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colnom_proveedor
            // 
            this.colnom_proveedor.Caption = "Proveedor";
            this.colnom_proveedor.FieldName = "nom_proveedor";
            this.colnom_proveedor.Name = "colnom_proveedor";
            this.colnom_proveedor.OptionsColumn.AllowEdit = false;
            this.colnom_proveedor.Width = 71;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.AllowEdit = false;
            this.coloc_fecha.Width = 56;
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.Caption = "Observación";
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            this.coloc_observacion.OptionsColumn.AllowEdit = false;
            this.coloc_observacion.Width = 148;
            // 
            // colcod_producto
            // 
            this.colcod_producto.FieldName = "cod_producto";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 2;
            this.colcod_producto.Width = 79;
            // 
            // colnom_producto
            // 
            this.colnom_producto.Caption = "Producto";
            this.colnom_producto.FieldName = "nom_producto";
            this.colnom_producto.Name = "colnom_producto";
            this.colnom_producto.OptionsColumn.AllowEdit = false;
            this.colnom_producto.Visible = true;
            this.colnom_producto.VisibleIndex = 3;
            this.colnom_producto.Width = 252;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // coldm_precio
            // 
            this.coldm_precio.FieldName = "dm_precio";
            this.coldm_precio.Name = "coldm_precio";
            // 
            // colcantidad_pedida_OC
            // 
            this.colcantidad_pedida_OC.Caption = "cantidad_pedida_OC";
            this.colcantidad_pedida_OC.FieldName = "cantidad_pedida_OC";
            this.colcantidad_pedida_OC.Name = "colcantidad_pedida_OC";
            this.colcantidad_pedida_OC.OptionsColumn.AllowEdit = false;
            this.colcantidad_pedida_OC.Visible = true;
            this.colcantidad_pedida_OC.VisibleIndex = 4;
            this.colcantidad_pedida_OC.Width = 106;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "cantidad_ing_a_Inven";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 5;
            this.coldm_cantidad.Width = 114;
            // 
            // colSaldo_x_Ing_OC
            // 
            this.colSaldo_x_Ing_OC.Caption = "Saldo_x_Ing_OC";
            this.colSaldo_x_Ing_OC.DisplayFormat.FormatString = "n2";
            this.colSaldo_x_Ing_OC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo_x_Ing_OC.FieldName = "Saldo_x_Ing_OC";
            this.colSaldo_x_Ing_OC.Name = "colSaldo_x_Ing_OC";
            this.colSaldo_x_Ing_OC.OptionsColumn.AllowEdit = false;
            this.colSaldo_x_Ing_OC.Visible = true;
            this.colSaldo_x_Ing_OC.VisibleIndex = 6;
            this.colSaldo_x_Ing_OC.Width = 110;
            // 
            // coldm_stock_ante
            // 
            this.coldm_stock_ante.FieldName = "dm_stock_ante";
            this.coldm_stock_ante.Name = "coldm_stock_ante";
            // 
            // coldm_peso
            // 
            this.coldm_peso.FieldName = "dm_peso";
            this.coldm_peso.Name = "coldm_peso";
            // 
            // colCostoProducto
            // 
            this.colCostoProducto.FieldName = "CostoProducto";
            this.colCostoProducto.Name = "colCostoProducto";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 47;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            // 
            // colIdEstadoRecepcion
            // 
            this.colIdEstadoRecepcion.FieldName = "IdEstadoRecepcion";
            this.colIdEstadoRecepcion.Name = "colIdEstadoRecepcion";
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Centro de Costo";
            this.colIdCentroCosto.ColumnEdit = this.cmbCentroCosto_grid;
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 7;
            this.colIdCentroCosto.Width = 106;
            // 
            // cmbCentroCosto_grid
            // 
            this.cmbCentroCosto_grid.AutoHeight = false;
            this.cmbCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto_grid.Name = "cmbCentroCosto_grid";
            this.cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo_cmbgrid});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 251;
            // 
            // colCentro_costo_cmbgrid
            // 
            this.colCentro_costo_cmbgrid.Caption = "Centro de Costo";
            this.colCentro_costo_cmbgrid.FieldName = "Centro_costo";
            this.colCentro_costo_cmbgrid.Name = "colCentro_costo_cmbgrid";
            this.colCentro_costo_cmbgrid.Visible = true;
            this.colCentro_costo_cmbgrid.VisibleIndex = 0;
            this.colCentro_costo_cmbgrid.Width = 929;
            // 
            // colIdPunto_cargo
            // 
            this.colIdPunto_cargo.Caption = "Punto de Cargo";
            this.colIdPunto_cargo.ColumnEdit = this.cmbPuntoCargo_grid;
            this.colIdPunto_cargo.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo.Name = "colIdPunto_cargo";
            this.colIdPunto_cargo.Visible = true;
            this.colIdPunto_cargo.VisibleIndex = 10;
            this.colIdPunto_cargo.Width = 87;
            // 
            // cmbPuntoCargo_grid
            // 
            this.cmbPuntoCargo_grid.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbPuntoCargo_grid.AutoHeight = false;
            this.cmbPuntoCargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo2";
            this.cmbPuntoCargo_grid.Name = "cmbPuntoCargo_grid";
            this.cmbPuntoCargo_grid.ReadOnly = true;
            this.cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";
            this.cmbPuntoCargo_grid.View = this.gridView2;
            this.cmbPuntoCargo_grid.Click += new System.EventHandler(this.cmbPuntoCargo_grid_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPunto_cargo_cmbgrid,
            this.colnom_punto_cargo});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPunto_cargo_cmbgrid
            // 
            this.colIdPunto_cargo_cmbgrid.Caption = "IdPuntoCargo";
            this.colIdPunto_cargo_cmbgrid.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo_cmbgrid.Name = "colIdPunto_cargo_cmbgrid";
            this.colIdPunto_cargo_cmbgrid.Visible = true;
            this.colIdPunto_cargo_cmbgrid.VisibleIndex = 1;
            this.colIdPunto_cargo_cmbgrid.Width = 267;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Nombre";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 0;
            this.colnom_punto_cargo.Width = 913;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.AllowEdit = false;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 57;
            // 
            // colSaldo_x_Ing_OC_AUX
            // 
            this.colSaldo_x_Ing_OC_AUX.FieldName = "Saldo_x_Ing_OC_AUX";
            this.colSaldo_x_Ing_OC_AUX.Name = "colSaldo_x_Ing_OC_AUX";
            // 
            // colIdMotivo_OC
            // 
            this.colIdMotivo_OC.Caption = "IdMotivo_OC";
            this.colIdMotivo_OC.Name = "colIdMotivo_OC";
            // 
            // colNom_Motivo
            // 
            this.colNom_Motivo.Caption = "Motivo";
            this.colNom_Motivo.FieldName = "Nom_Motivo";
            this.colNom_Motivo.Name = "colNom_Motivo";
            this.colNom_Motivo.OptionsColumn.AllowEdit = false;
            this.colNom_Motivo.Width = 106;
            // 
            // colcantidad_ingresada
            // 
            this.colcantidad_ingresada.Caption = "Cant. Ingresada";
            this.colcantidad_ingresada.FieldName = "cantidad_ingresada";
            this.colcantidad_ingresada.Name = "colcantidad_ingresada";
            // 
            // colIdEstado_cierre
            // 
            this.colIdEstado_cierre.Caption = "IdEstado_cierre";
            this.colIdEstado_cierre.FieldName = "IdEstado_cierre";
            this.colIdEstado_cierre.Name = "colIdEstado_cierre";
            // 
            // colnom_estado_cierre
            // 
            this.colnom_estado_cierre.Caption = "Estado Cierre";
            this.colnom_estado_cierre.FieldName = "nom_estado_cierre";
            this.colnom_estado_cierre.Name = "colnom_estado_cierre";
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "Subcentro costo";
            this.colIdCentroCosto_sub_centro_costo.ColumnEdit = this.cmb_sub_centro_costo;
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdRegistro";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Visible = true;
            this.colIdCentroCosto_sub_centro_costo.VisibleIndex = 8;
            this.colIdCentroCosto_sub_centro_costo.Width = 93;
            // 
            // cmb_sub_centro_costo
            // 
            this.cmb_sub_centro_costo.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_sub_centro_costo.AutoHeight = false;
            this.cmb_sub_centro_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sub_centro_costo.DisplayMember = "Centro_costo2";
            this.cmb_sub_centro_costo.Name = "cmb_sub_centro_costo";
            this.cmb_sub_centro_costo.ReadOnly = true;
            this.cmb_sub_centro_costo.ValueMember = "IdRegistro";
            this.cmb_sub_centro_costo.View = this.gridView1;
            this.cmb_sub_centro_costo.Click += new System.EventHandler(this.cmb_sub_centro_costo_Click);
            this.cmb_sub_centro_costo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_sub_centro_costo_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ID";
            this.gridColumn17.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 219;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Subcentro de costo";
            this.gridColumn18.FieldName = "Centro_costo";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 961;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ref";
            this.gridColumn10.FieldName = "Ref_OC";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 15;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "IdUnidadMedida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida1,
            this.colDescripcion1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida1
            // 
            this.colIdUnidadMedida1.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida1.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida1.Name = "colIdUnidadMedida1";
            this.colIdUnidadMedida1.Visible = true;
            this.colIdUnidadMedida1.VisibleIndex = 0;
            this.colIdUnidadMedida1.Width = 179;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripcion";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 1001;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "IdTipoConsumo";
            this.gridColumn15.FieldName = "IdTipoConsumo";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "OC";
            this.gridColumn16.FieldName = "oc_NumDocumento";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Width = 88;
            // 
            // col_grupo_pto_cargo
            // 
            this.col_grupo_pto_cargo.Caption = "Grupo";
            this.col_grupo_pto_cargo.ColumnEdit = this.cmb_grupo_punto_cargo;
            this.col_grupo_pto_cargo.FieldName = "IdPunto_cargo_grupo";
            this.col_grupo_pto_cargo.Name = "col_grupo_pto_cargo";
            this.col_grupo_pto_cargo.Visible = true;
            this.col_grupo_pto_cargo.VisibleIndex = 9;
            // 
            // cmb_grupo_punto_cargo
            // 
            this.cmb_grupo_punto_cargo.AutoHeight = false;
            this.cmb_grupo_punto_cargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo_punto_cargo.DisplayMember = "nom_punto_cargo_grupo2";
            this.cmb_grupo_punto_cargo.Name = "cmb_grupo_punto_cargo";
            this.cmb_grupo_punto_cargo.ValueMember = "IdPunto_cargo_grupo";
            this.cmb_grupo_punto_cargo.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn21});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "ID";
            this.gridColumn20.FieldName = "IdPunto_cargo_grupo";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 163;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Grupo";
            this.gridColumn21.FieldName = "nom_punto_cargo_grupo";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            this.gridColumn21.Width = 1017;
            // 
            // col_IDSUBCENTRO
            // 
            this.col_IDSUBCENTRO.Caption = "IdCentroCosto_sub_centro_costo";
            this.col_IDSUBCENTRO.FieldName = "IdCentroCosto_sub_centro_costo";
            this.col_IDSUBCENTRO.Name = "col_IDSUBCENTRO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCp_Proveedor);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 34);
            this.panel3.TabIndex = 0;
            // 
            // ucCp_Proveedor
            // 
            this.ucCp_Proveedor.Location = new System.Drawing.Point(71, 5);
            this.ucCp_Proveedor.Name = "ucCp_Proveedor";
            this.ucCp_Proveedor.Size = new System.Drawing.Size(675, 26);
            this.ucCp_Proveedor.TabIndex = 5;
            this.ucCp_Proveedor.event_cmb_proveedor_EditValueChanged += new Core.Erp.Winform.Controles.UCCp_Proveedor.delegate_cmb_proveedor_EditValueChanged(this.ucCp_Proveedor_event_cmb_proveedor_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Proveedor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diario Contable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucInv_GridCbte_Cble_x_Ing_Egr_Inv1
            // 
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Location = new System.Drawing.Point(3, 3);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Name = "ucInv_GridCbte_Cble_x_Ing_Egr_Inv1";
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Size = new System.Drawing.Size(1002, 296);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkTodos);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbMotivoInv);
            this.panel5.Controls.Add(this.dtpFecha);
            this.panel5.Controls.Add(this.lblAnulado);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtCodigo);
            this.panel5.Controls.Add(this.txtNumIngreso);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 109);
            this.panel5.TabIndex = 1;
            // 
            // checkTodos
            // 
            this.checkTodos.Location = new System.Drawing.Point(12, 85);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Properties.Caption = "Seleccionar visibles";
            this.checkTodos.Size = new System.Drawing.Size(136, 19);
            this.checkTodos.TabIndex = 4;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nº Ingreso:";
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(554, 35);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(250, 26);
            this.cmbMotivoInv.TabIndex = 19;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            this.cmbMotivoInv.event_cmbMotivoInv_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb.delegate_cmbMotivoInv_EditValueChanged(this.cmbMotivoInv_event_cmbMotivoInv_EditValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(854, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(89, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(620, 5);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(127, 20);
            this.lblAnulado.TabIndex = 11;
            this.lblAnulado.Text = "*** Anulado ***";
            this.lblAnulado.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Motivo Inv:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(257, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(213, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.Location = new System.Drawing.Point(85, 9);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtNumIngreso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(13, 35);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(467, 51);
            this.ucIn_Sucursal_Bodega1.TabIndex = 5;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código/Doc.:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtObservacion);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 437);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1016, 51);
            this.panel6.TabIndex = 2;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(91, 9);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(852, 36);
            this.txtObservacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observación:";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 517);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1016, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // FrmIn_Ingreso_x_OrdenCompra_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Ingreso_x_OrdenCompra_Mant";
            this.Text = "Ingreso a Inventario por Orden de Compra  v11302014";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Ingreso_x_OrdenCompra_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTodos.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumIngreso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControlIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_precio;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_pedida_OC;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Ing_OC;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_stock_ante;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoRecepcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Ing_OC_AUX;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo_cmbgrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbPuntoCargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_OC;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Motivo;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_ingresada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_estado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraEditors.CheckEdit checkTodos;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv ucInv_GridCbte_Cble_x_Ing_Egr_Inv1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private Controles.UCCp_Proveedor ucCp_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_sub_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn col_grupo_pto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_grupo_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.Columns.GridColumn col_IDSUBCENTRO;
    }
}
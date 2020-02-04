namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Egresos_Inv_Multi_Bodega_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_bodega = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdUnidadMedida_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo_convertido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_centro_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistro_subcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentrocosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_punto_cargo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPunto_cargo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_subcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ucGe_Sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoMovi = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentrocosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 540);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(989, 26);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(989, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 511);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 338);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlProductos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlProductos.Location = new System.Drawing.Point(3, 3);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.cmb_punto_cargo,
            this.cmb_bodega,
            this.cmb_subcentrocosto,
            this.cmb_unidad_medida,
            this.cmb_centro_costo});
            this.gridControlProductos.Size = new System.Drawing.Size(975, 306);
            this.gridControlProductos.TabIndex = 0;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBodega,
            this.colIdProducto,
            this.col_IdUnidadMedida,
            this.col_IdUnidadMedida_convertida,
            this.coldm_cantidad,
            this.coldm_cantidad_convertida,
            this.colmv_costo,
            this.colmv_costo_convertido,
            this.coldm_observacion,
            this.colIdCentroCosto,
            this.colIdRegistro_subcentro,
            this.colIdPunto_cargo,
            this.colIdCentroCosto_sub_centro_costo,
            this.col_cod_subcentro});
            this.gridViewProductos.CustomizationFormBounds = new System.Drawing.Rectangle(823, 450, 216, 178);
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductos.OptionsView.ShowFooter = true;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProductos_RowCellStyle);
            this.gridViewProductos.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewProductos_InitNewRow);
            this.gridViewProductos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProductos_FocusedRowChanged);
            this.gridViewProductos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanged);
            this.gridViewProductos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanging_1);
            this.gridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyDown);
            // 
            // colIdBodega
            // 
            this.colIdBodega.Caption = "Bodega";
            this.colIdBodega.ColumnEdit = this.cmb_bodega;
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Visible = true;
            this.colIdBodega.VisibleIndex = 0;
            this.colIdBodega.Width = 211;
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.AutoHeight = false;
            this.cmb_bodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_bodega.DisplayMember = "bo_Descripcion";
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.ValueMember = "IdBodega";
            this.cmb_bodega.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBodega1,
            this.colbo_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBodega1
            // 
            this.colIdBodega1.Caption = "IdBodega";
            this.colIdBodega1.FieldName = "IdBodega";
            this.colIdBodega1.Name = "colIdBodega1";
            this.colIdBodega1.Visible = true;
            this.colIdBodega1.VisibleIndex = 0;
            this.colIdBodega1.Width = 121;
            // 
            // colbo_Descripcion
            // 
            this.colbo_Descripcion.Caption = "Bodega";
            this.colbo_Descripcion.FieldName = "bo_Descripcion";
            this.colbo_Descripcion.Name = "colbo_Descripcion";
            this.colbo_Descripcion.Visible = true;
            this.colbo_Descripcion.VisibleIndex = 1;
            this.colbo_Descripcion.Width = 1059;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 221;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.DisplayMember = "pr_descripcion";
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.ValueMember = "IdProducto";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_cmbgrid,
            this.colpr_codigo_cmbgrid,
            this.colpr_descripcion,
            this.colpr_precio_publico,
            this.colpr_stock,
            this.colpr_pedidos,
            this.colpr_ManejaIva,
            this.colpr_costo_promedio,
            this.colpr_peso});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_cmbgrid
            // 
            this.colIdProducto_cmbgrid.Caption = "IdProducto";
            this.colIdProducto_cmbgrid.FieldName = "IdProducto";
            this.colIdProducto_cmbgrid.Name = "colIdProducto_cmbgrid";
            this.colIdProducto_cmbgrid.Width = 103;
            // 
            // colpr_codigo_cmbgrid
            // 
            this.colpr_codigo_cmbgrid.Caption = "Código";
            this.colpr_codigo_cmbgrid.FieldName = "pr_codigo";
            this.colpr_codigo_cmbgrid.Name = "colpr_codigo_cmbgrid";
            this.colpr_codigo_cmbgrid.Visible = true;
            this.colpr_codigo_cmbgrid.VisibleIndex = 0;
            this.colpr_codigo_cmbgrid.Width = 146;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            this.colpr_descripcion.Width = 573;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "P.V.P.";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 4;
            this.colpr_precio_publico.Width = 89;
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock_Bodega";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Visible = true;
            this.colpr_stock.VisibleIndex = 2;
            this.colpr_stock.Width = 121;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 3;
            this.colpr_pedidos.Width = 121;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Visible = true;
            this.colpr_ManejaIva.VisibleIndex = 5;
            this.colpr_ManejaIva.Width = 130;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Width = 93;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Width = 102;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "U. medida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida_sinConversion";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.Visible = true;
            this.col_IdUnidadMedida.VisibleIndex = 2;
            this.col_IdUnidadMedida.Width = 132;
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion2";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.ReadOnly = true;
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida.View = this.gridView5;
            this.cmb_unidad_medida.Click += new System.EventHandler(this.cmb_unidad_medida_Click);
            this.cmb_unidad_medida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_unidad_medida_KeyDown);
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdUnidadMedida_convertida
            // 
            this.col_IdUnidadMedida_convertida.Caption = "U. medida convertida";
            this.col_IdUnidadMedida_convertida.ColumnEdit = this.cmb_unidad_medida;
            this.col_IdUnidadMedida_convertida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida_convertida.Name = "col_IdUnidadMedida_convertida";
            this.col_IdUnidadMedida_convertida.OptionsColumn.AllowEdit = false;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad_sinConversion";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dm_cantidad_sinConversion", "{0:n2}")});
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 4;
            this.coldm_cantidad.Width = 122;
            // 
            // coldm_cantidad_convertida
            // 
            this.coldm_cantidad_convertida.Caption = "Cantidad convertida";
            this.coldm_cantidad_convertida.FieldName = "dm_cantidad";
            this.coldm_cantidad_convertida.Name = "coldm_cantidad_convertida";
            this.coldm_cantidad_convertida.OptionsColumn.AllowEdit = false;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo";
            this.colmv_costo.FieldName = "mv_costo_sinConversion";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.OptionsColumn.AllowEdit = false;
            this.colmv_costo.Width = 46;
            // 
            // colmv_costo_convertido
            // 
            this.colmv_costo_convertido.Caption = "Costo convertido";
            this.colmv_costo_convertido.FieldName = "mv_costo";
            this.colmv_costo_convertido.Name = "colmv_costo_convertido";
            this.colmv_costo_convertido.OptionsColumn.AllowEdit = false;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 3;
            this.coldm_observacion.Width = 117;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Centro de Costo";
            this.colIdCentroCosto.ColumnEdit = this.cmb_centro_costo;
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 5;
            this.colIdCentroCosto.Width = 160;
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.AutoHeight = false;
            this.cmb_centro_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.DisplayMember = "Centro_costo2";
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.View = this.gridView6;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn13});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "IdCentroCosto";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Centro de costo";
            this.gridColumn13.FieldName = "Centro_costo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // colIdRegistro_subcentro
            // 
            this.colIdRegistro_subcentro.Caption = "Subcentro de costo";
            this.colIdRegistro_subcentro.ColumnEdit = this.cmb_subcentrocosto;
            this.colIdRegistro_subcentro.FieldName = "IdRegistro";
            this.colIdRegistro_subcentro.Name = "colIdRegistro_subcentro";
            this.colIdRegistro_subcentro.Visible = true;
            this.colIdRegistro_subcentro.VisibleIndex = 6;
            this.colIdRegistro_subcentro.Width = 217;
            // 
            // cmb_subcentrocosto
            // 
            this.cmb_subcentrocosto.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_subcentrocosto.AutoHeight = false;
            this.cmb_subcentrocosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentrocosto.DisplayMember = "Centro_costo2";
            this.cmb_subcentrocosto.Name = "cmb_subcentrocosto";
            this.cmb_subcentrocosto.ReadOnly = true;
            this.cmb_subcentrocosto.ValueMember = "IdRegistro";
            this.cmb_subcentrocosto.View = this.gridView4;
            this.cmb_subcentrocosto.Click += new System.EventHandler(this.cmb_subcentrocosto_Click);
            this.cmb_subcentrocosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_subcentrocosto_KeyDown);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCentroCosto_sub_centro_costo,
            this.col_Centro_costo});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdCentroCosto_sub_centro_costo
            // 
            this.col_IdCentroCosto_sub_centro_costo.Caption = "ID";
            this.col_IdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.col_IdCentroCosto_sub_centro_costo.Name = "col_IdCentroCosto_sub_centro_costo";
            this.col_IdCentroCosto_sub_centro_costo.Visible = true;
            this.col_IdCentroCosto_sub_centro_costo.VisibleIndex = 0;
            // 
            // col_Centro_costo
            // 
            this.col_Centro_costo.Caption = "Subcentro de costo";
            this.col_Centro_costo.FieldName = "col_Centro_costo";
            this.col_Centro_costo.Name = "col_Centro_costo";
            this.col_Centro_costo.Visible = true;
            this.col_Centro_costo.VisibleIndex = 1;
            // 
            // colIdPunto_cargo
            // 
            this.colIdPunto_cargo.Caption = "Punto Cargo";
            this.colIdPunto_cargo.ColumnEdit = this.cmb_punto_cargo;
            this.colIdPunto_cargo.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo.Name = "colIdPunto_cargo";
            this.colIdPunto_cargo.Width = 98;
            // 
            // cmb_punto_cargo
            // 
            this.cmb_punto_cargo.AutoHeight = false;
            this.cmb_punto_cargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_punto_cargo.DisplayMember = "nom_punto_cargo";
            this.cmb_punto_cargo.Name = "cmb_punto_cargo";
            this.cmb_punto_cargo.ValueMember = "IdPunto_cargo";
            this.cmb_punto_cargo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPunto_cargo1,
            this.colnom_punto_cargo2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IdPunto_cargo1
            // 
            this.IdPunto_cargo1.Caption = "IdPunto_cargo";
            this.IdPunto_cargo1.FieldName = "IdPunto_cargo";
            this.IdPunto_cargo1.Name = "IdPunto_cargo1";
            this.IdPunto_cargo1.Visible = true;
            this.IdPunto_cargo1.VisibleIndex = 0;
            this.IdPunto_cargo1.Width = 314;
            // 
            // colnom_punto_cargo2
            // 
            this.colnom_punto_cargo2.Caption = "Punto Cargo";
            this.colnom_punto_cargo2.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo2.Name = "colnom_punto_cargo2";
            this.colnom_punto_cargo2.Visible = true;
            this.colnom_punto_cargo2.VisibleIndex = 1;
            this.colnom_punto_cargo2.Width = 866;
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "IdSubcentro";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.OptionsColumn.AllowEdit = false;
            // 
            // col_cod_subcentro
            // 
            this.col_cod_subcentro.Caption = "Scc";
            this.col_cod_subcentro.FieldName = "IdCentroCosto_sub_centro_costo";
            this.col_cod_subcentro.Name = "col_cod_subcentro";
            this.col_cod_subcentro.Width = 41;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMotivoInv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ucGe_Sucursal);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtNumIngreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales:";
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(77, 86);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(396, 26);
            this.cmbMotivoInv.TabIndex = 15;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.EGR;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motivo Inv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sucursal:";
            // 
            // ucGe_Sucursal
            // 
            this.ucGe_Sucursal.Location = new System.Drawing.Point(77, 53);
            this.ucGe_Sucursal.Name = "ucGe_Sucursal";
            this.ucGe_Sucursal.Size = new System.Drawing.Size(386, 22);
            this.ucGe_Sucursal.TabIndex = 11;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(554, 16);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(116, 16);
            this.lblAnulado.TabIndex = 10;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoMovi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(479, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Movimiento:";
            // 
            // cmbTipoMovi
            // 
            this.cmbTipoMovi.Location = new System.Drawing.Point(78, 14);
            this.cmbTipoMovi.Name = "cmbTipoMovi";
            this.cmbTipoMovi.Size = new System.Drawing.Size(345, 33);
            this.cmbTipoMovi.TabIndex = 16;
            this.cmbTipoMovi.Visible_buton_Acciones = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(77, 117);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(850, 51);
            this.txtObservacion.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(808, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(105, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(343, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.Location = new System.Drawing.Point(77, 13);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtNumIngreso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Ingreso:";
            // 
            // FrmIn_Egresos_Inv_Multi_Bodega_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Egresos_Inv_Multi_Bodega_Mant";
            this.Text = "Mantenimiento Egresos Multibodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Egresos_Inv_Multi_Bodega_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentrocosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal;
        private System.Windows.Forms.Label label7;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private Controles.UCIn_TipoMoviInv_Cmb cmbTipoMovi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistro_subcentro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentrocosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdPunto_cargo1;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colbo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida_convertida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo_convertido;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_convertida;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_subcentro;
    }
}
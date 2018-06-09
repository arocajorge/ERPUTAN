namespace Core.Erp.Winform.Compras_FJ
{
    partial class frmCom_OrdenCompra_Mant_FJ
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCom_OrdenCompra_Mant_FJ));
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlOrdenCompra = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoCodigo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorc_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtporcDesc = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colIco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescuento = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetallexItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsta_en_base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colPor_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida_x_prod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCod_Impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoImpuesto1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_grupo_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo_punto_cargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdPunto_cargo_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_punto_cargo_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_combo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cmb_puntoC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_puntoCargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColPunto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_suncentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_subCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDepartamento = new Core.Erp.Winform.Controles.UCCom_Departamento_cmb();
            this.cmbMotivo = new Core.Erp.Winform.Controles.UCCom_MotivoCompraCmb();
            this.ucCom_TerminoPagoCmb1 = new Core.Erp.Winform.Controles.UCCom_TerminoPagoCmb();
            this.ucCom_Comprador1 = new Core.Erp.Winform.Controles.UCCom_Comprador();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.cmbSucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.txeFlete = new DevExpress.XtraEditors.TextEdit();
            this.cmb_estado_cierre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstado_cierre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbEstadoAprob = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogocompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblanulado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOC = new System.Windows.Forms.TextBox();
            this.txtIdOC = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel_central.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoImpuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_puntoCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeFlete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_cierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.panel1);
            this.panel_central.Controls.Add(this.groupBox2);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 27);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1239, 521);
            this.panel_central.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 321);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 321);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlOrdenCompra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1231, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlOrdenCompra
            // 
            this.gridControlOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlOrdenCompra.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlOrdenCompra.Location = new System.Drawing.Point(3, 3);
            this.gridControlOrdenCompra.MainView = this.gridViewOrdenCompra;
            this.gridControlOrdenCompra.Name = "gridControlOrdenCompra";
            this.gridControlOrdenCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProductoCodigo,
            this.txtCantidad,
            this.txtporcDesc,
            this.repositoryItemPictureEdit1,
            this.cmbCentroCosto,
            this.repositoryItemImageEdit1,
            this.txtDescuento,
            this.cmbTipoImpuesto1,
            this.cmb_unidad_medida,
            this.cmb_grupo_punto_cargo,
            this.cmb_subcentroCosto,
            this.cmb_puntoCargo});
            this.gridControlOrdenCompra.Size = new System.Drawing.Size(1225, 289);
            this.gridControlOrdenCompra.TabIndex = 1;
            this.gridControlOrdenCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenCompra});
            // 
            // gridViewOrdenCompra
            // 
            this.gridViewOrdenCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colCodigo_Producto,
            this.colCantidad,
            this.colPrecio,
            this.colPorc_Descuento,
            this.colIco1,
            this.colDescuento,
            this.colPrecioFinal,
            this.colSubtotal,
            this.colIva,
            this.colTotal,
            this.colDetallexItems,
            this.colchek,
            this.colEsta_en_base,
            this.colSecuencia,
            this.ColNew,
            this.colPor_Iva,
            this.col_IdUnidadMedida,
            this.col_IdUnidadMedida_x_prod,
            this.colIdCod_Impuesto,
            this.colIdMovi,
            this.col_grupo_punto_cargo,
            this.colIdCentroCosto,
            this.col_cmb_puntoC,
            this.Col_suncentro});
            this.gridViewOrdenCompra.CustomizationFormBounds = new System.Drawing.Rectangle(1079, 547, 210, 172);
            this.gridViewOrdenCompra.GridControl = this.gridControlOrdenCompra;
            this.gridViewOrdenCompra.Name = "gridViewOrdenCompra";
            this.gridViewOrdenCompra.OptionsCustomization.AllowSort = false;
            this.gridViewOrdenCompra.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewOrdenCompra.OptionsView.ShowFooter = true;
            this.gridViewOrdenCompra.OptionsView.ShowGroupPanel = false;
            this.gridViewOrdenCompra.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewOrdenCompra_RowCellClick);
            this.gridViewOrdenCompra.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewOrdenCompra_RowCellStyle);
            this.gridViewOrdenCompra.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOrdenCompra_FocusedRowChanged);
            this.gridViewOrdenCompra.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridViewOrdenCompra_FocusedColumnChanged);
            this.gridViewOrdenCompra.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrdenCompra_CellValueChanged);
            this.gridViewOrdenCompra.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrdenCompra_CellValueChanging);
            this.gridViewOrdenCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewOrdenCompra_KeyDown);
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 65;
            // 
            // colCodigo_Producto
            // 
            this.colCodigo_Producto.Caption = "Item";
            this.colCodigo_Producto.ColumnEdit = this.cmbProductoCodigo;
            this.colCodigo_Producto.FieldName = "IdProducto";
            this.colCodigo_Producto.Name = "colCodigo_Producto";
            this.colCodigo_Producto.Visible = true;
            this.colCodigo_Producto.VisibleIndex = 1;
            this.colCodigo_Producto.Width = 204;
            // 
            // cmbProductoCodigo
            // 
            this.cmbProductoCodigo.AutoHeight = false;
            this.cmbProductoCodigo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbProductoCodigo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoCodigo.DisplayMember = "pr_descripcion_2";
            this.cmbProductoCodigo.Name = "cmbProductoCodigo";
            this.cmbProductoCodigo.ValueMember = "IdProducto";
            this.cmbProductoCodigo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdProducto1,
            this.colpr_stock,
            this.colpr_codigo,
            this.colpr_ManejaIva,
            this.colpr_peso,
            this.colpr_costo_promedio,
            this.colpr_precio_publico,
            this.colpr_pedidos,
            this.colDisponible,
            this.colpr_descripcion1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Visible = true;
            this.colpr_stock.VisibleIndex = 2;
            this.colpr_stock.Width = 118;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código Producto";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            this.colpr_codigo.Width = 131;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Visible = true;
            this.colpr_ManejaIva.VisibleIndex = 7;
            this.colpr_ManejaIva.Width = 137;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Visible = true;
            this.colpr_peso.VisibleIndex = 4;
            this.colpr_peso.Width = 118;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo Promedio";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 6;
            this.colpr_costo_promedio.Width = 118;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "Precio Público";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 5;
            this.colpr_precio_publico.Width = 118;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 3;
            this.colpr_pedidos.Width = 118;
            // 
            // colDisponible
            // 
            this.colDisponible.Caption = "Disponibles";
            this.colDisponible.FieldName = "pr_Disponible";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.Width = 130;
            // 
            // colpr_descripcion1
            // 
            this.colpr_descripcion1.Caption = "Descripción";
            this.colpr_descripcion1.FieldName = "pr_descripcion";
            this.colpr_descripcion1.Name = "colpr_descripcion1";
            this.colpr_descripcion1.Visible = true;
            this.colpr_descripcion1.VisibleIndex = 1;
            this.colpr_descripcion1.Width = 322;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.txtCantidad;
            this.colCantidad.FieldName = "do_Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            this.colCantidad.Width = 67;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoHeight = false;
            this.txtCantidad.Mask.EditMask = "n6";
            this.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Mask.ShowPlaceHolders = false;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio/Costo";
            this.colPrecio.FieldName = "do_precioCompra";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 5;
            this.colPrecio.Width = 93;
            // 
            // colPorc_Descuento
            // 
            this.colPorc_Descuento.Caption = "% Desc.";
            this.colPorc_Descuento.ColumnEdit = this.txtporcDesc;
            this.colPorc_Descuento.FieldName = "do_porc_des";
            this.colPorc_Descuento.Name = "colPorc_Descuento";
            this.colPorc_Descuento.Visible = true;
            this.colPorc_Descuento.VisibleIndex = 6;
            this.colPorc_Descuento.Width = 52;
            // 
            // txtporcDesc
            // 
            this.txtporcDesc.AutoHeight = false;
            this.txtporcDesc.Mask.EditMask = "n6";
            this.txtporcDesc.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtporcDesc.Name = "txtporcDesc";
            // 
            // colIco1
            // 
            this.colIco1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIco1.FieldName = "Ico1";
            this.colIco1.Name = "colIco1";
            this.colIco1.OptionsColumn.AllowEdit = false;
            this.colIco1.OptionsColumn.AllowSize = false;
            this.colIco1.OptionsColumn.ReadOnly = true;
            this.colIco1.OptionsColumn.ShowCaption = false;
            this.colIco1.Width = 30;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colDescuento
            // 
            this.colDescuento.Caption = "Desc.";
            this.colDescuento.ColumnEdit = this.txtDescuento;
            this.colDescuento.FieldName = "do_descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.AllowEdit = false;
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 7;
            this.colDescuento.Width = 52;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AutoHeight = false;
            this.txtDescuento.Mask.EditMask = "n6";
            this.txtDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDescuento.Name = "txtDescuento";
            // 
            // colPrecioFinal
            // 
            this.colPrecioFinal.Caption = "Precio Final";
            this.colPrecioFinal.DisplayFormat.FormatString = "{0:n2}";
            this.colPrecioFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioFinal.FieldName = "do_precioFinal";
            this.colPrecioFinal.Name = "colPrecioFinal";
            this.colPrecioFinal.OptionsColumn.AllowEdit = false;
            this.colPrecioFinal.Visible = true;
            this.colPrecioFinal.VisibleIndex = 8;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Caption = "SubTotal";
            this.colSubtotal.DisplayFormat.FormatString = "{0:n2}";
            this.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotal.FieldName = "do_subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.OptionsColumn.AllowEdit = false;
            this.colSubtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 9;
            this.colSubtotal.Width = 92;
            // 
            // colIva
            // 
            this.colIva.Caption = "$Imp";
            this.colIva.DisplayFormat.FormatString = "{0:n2}";
            this.colIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIva.FieldName = "do_iva";
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 11;
            this.colIva.Width = 71;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "{0:n2}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "do_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 12;
            this.colTotal.Width = 63;
            // 
            // colDetallexItems
            // 
            this.colDetallexItems.Caption = "detalle x Items";
            this.colDetallexItems.FieldName = "do_observacion";
            this.colDetallexItems.Name = "colDetallexItems";
            this.colDetallexItems.Visible = true;
            this.colDetallexItems.VisibleIndex = 3;
            this.colDetallexItems.Width = 130;
            // 
            // colchek
            // 
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            // 
            // colEsta_en_base
            // 
            this.colEsta_en_base.FieldName = "Esta_en_base";
            this.colEsta_en_base.Name = "colEsta_en_base";
            this.colEsta_en_base.Width = 77;
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "*";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.OptionsColumn.AllowEdit = false;
            this.colSecuencia.Width = 64;
            // 
            // ColNew
            // 
            this.ColNew.Caption = "+";
            this.ColNew.ColumnEdit = this.repositoryItemImageEdit1;
            this.ColNew.Name = "ColNew";
            this.ColNew.OptionsColumn.AllowEdit = false;
            this.ColNew.Visible = true;
            this.ColNew.VisibleIndex = 0;
            this.ColNew.Width = 28;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Images = this.imageList1;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo_32x32.png");
            // 
            // colPor_Iva
            // 
            this.colPor_Iva.Caption = "%Imp";
            this.colPor_Iva.FieldName = "Por_Iva";
            this.colPor_Iva.Name = "colPor_Iva";
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "Uni. medida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.Visible = true;
            this.col_IdUnidadMedida.VisibleIndex = 2;
            this.col_IdUnidadMedida.Width = 76;
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
            this.cmb_unidad_medida.View = this.gridView2;
            this.cmb_unidad_medida.Click += new System.EventHandler(this.cmb_unidad_medida_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdUnidadMedida";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 185;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Unidad de medida";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 995;
            // 
            // col_IdUnidadMedida_x_prod
            // 
            this.col_IdUnidadMedida_x_prod.Caption = "IdUnidadMedida_x_prod";
            this.col_IdUnidadMedida_x_prod.FieldName = "IdUnidadMedida_x_prod";
            this.col_IdUnidadMedida_x_prod.Name = "col_IdUnidadMedida_x_prod";
            this.col_IdUnidadMedida_x_prod.Width = 126;
            // 
            // colIdCod_Impuesto
            // 
            this.colIdCod_Impuesto.Caption = "%Imp.";
            this.colIdCod_Impuesto.ColumnEdit = this.cmbTipoImpuesto1;
            this.colIdCod_Impuesto.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto.Name = "colIdCod_Impuesto";
            this.colIdCod_Impuesto.Visible = true;
            this.colIdCod_Impuesto.VisibleIndex = 10;
            this.colIdCod_Impuesto.Width = 81;
            // 
            // cmbTipoImpuesto1
            // 
            this.cmbTipoImpuesto1.AutoHeight = false;
            this.cmbTipoImpuesto1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoImpuesto1.DisplayMember = "nom_impuesto";
            this.cmbTipoImpuesto1.Name = "cmbTipoImpuesto1";
            this.cmbTipoImpuesto1.ValueMember = "IdCod_Impuesto";
            this.cmbTipoImpuesto1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto_cmb,
            this.colnom_impuesto_cmb});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto_cmb
            // 
            this.colIdCod_Impuesto_cmb.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto_cmb.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto_cmb.Name = "colIdCod_Impuesto_cmb";
            this.colIdCod_Impuesto_cmb.Visible = true;
            this.colIdCod_Impuesto_cmb.VisibleIndex = 1;
            this.colIdCod_Impuesto_cmb.Width = 93;
            // 
            // colnom_impuesto_cmb
            // 
            this.colnom_impuesto_cmb.Caption = "Impuesto";
            this.colnom_impuesto_cmb.FieldName = "nom_impuesto";
            this.colnom_impuesto_cmb.Name = "colnom_impuesto_cmb";
            this.colnom_impuesto_cmb.Visible = true;
            this.colnom_impuesto_cmb.VisibleIndex = 0;
            this.colnom_impuesto_cmb.Width = 1054;
            // 
            // colIdMovi
            // 
            this.colIdMovi.Caption = "# Movi";
            this.colIdMovi.FieldName = "IdNumMovi";
            this.colIdMovi.Name = "colIdMovi";
            this.colIdMovi.OptionsColumn.AllowEdit = false;
            this.colIdMovi.Width = 83;
            // 
            // col_grupo_punto_cargo
            // 
            this.col_grupo_punto_cargo.Caption = "Grupo";
            this.col_grupo_punto_cargo.ColumnEdit = this.cmb_grupo_punto_cargo;
            this.col_grupo_punto_cargo.FieldName = "IdPunto_cargo_grupo";
            this.col_grupo_punto_cargo.Name = "col_grupo_punto_cargo";
            this.col_grupo_punto_cargo.Width = 66;
            // 
            // cmb_grupo_punto_cargo
            // 
            this.cmb_grupo_punto_cargo.AutoHeight = false;
            this.cmb_grupo_punto_cargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo_punto_cargo.DisplayMember = "nom_punto_cargo_grupo";
            this.cmb_grupo_punto_cargo.Name = "cmb_grupo_punto_cargo";
            this.cmb_grupo_punto_cargo.ValueMember = "IdPunto_cargo_grupo";
            this.cmb_grupo_punto_cargo.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdPunto_cargo_grupo,
            this.col_nom_punto_cargo_grupo});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdPunto_cargo_grupo
            // 
            this.col_IdPunto_cargo_grupo.Caption = "Id Grupo";
            this.col_IdPunto_cargo_grupo.FieldName = "IdPunto_cargo_grupo";
            this.col_IdPunto_cargo_grupo.Name = "col_IdPunto_cargo_grupo";
            this.col_IdPunto_cargo_grupo.Visible = true;
            this.col_IdPunto_cargo_grupo.VisibleIndex = 1;
            this.col_IdPunto_cargo_grupo.Width = 91;
            // 
            // col_nom_punto_cargo_grupo
            // 
            this.col_nom_punto_cargo_grupo.Caption = "Nombre de grupo";
            this.col_nom_punto_cargo_grupo.FieldName = "nom_punto_cargo_grupo";
            this.col_nom_punto_cargo_grupo.Name = "col_nom_punto_cargo_grupo";
            this.col_nom_punto_cargo_grupo.Visible = true;
            this.col_nom_punto_cargo_grupo.VisibleIndex = 0;
            this.col_nom_punto_cargo_grupo.Width = 963;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Centro de Costo";
            this.colIdCentroCosto.ColumnEdit = this.cmbCentroCosto;
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Width = 109;
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.AutoHeight = false;
            this.cmbCentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto.DisplayMember = "Centro_costo";
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_combo,
            this.colEstado_2,
            this.colCentro_costo});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_combo
            // 
            this.colIdCentroCosto_combo.Caption = "Código";
            this.colIdCentroCosto_combo.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_combo.Name = "colIdCentroCosto_combo";
            this.colIdCentroCosto_combo.Visible = true;
            this.colIdCentroCosto_combo.VisibleIndex = 0;
            this.colIdCentroCosto_combo.Width = 94;
            // 
            // colEstado_2
            // 
            this.colEstado_2.Caption = "Estado";
            this.colEstado_2.Name = "colEstado_2";
            this.colEstado_2.Visible = true;
            this.colEstado_2.VisibleIndex = 2;
            this.colEstado_2.Width = 455;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro_costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            this.colCentro_costo.Width = 631;
            // 
            // col_cmb_puntoC
            // 
            this.col_cmb_puntoC.Caption = "Punto Cargo";
            this.col_cmb_puntoC.ColumnEdit = this.cmb_puntoCargo;
            this.col_cmb_puntoC.FieldName = "IdPunto_cargo";
            this.col_cmb_puntoC.Name = "col_cmb_puntoC";
            this.col_cmb_puntoC.Visible = true;
            this.col_cmb_puntoC.VisibleIndex = 13;
            // 
            // cmb_puntoCargo
            // 
            this.cmb_puntoCargo.AutoHeight = false;
            this.cmb_puntoCargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_puntoCargo.Name = "cmb_puntoCargo";
            this.cmb_puntoCargo.View = this.gridView8;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColPunto});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // ColPunto
            // 
            this.ColPunto.Caption = "Nombre Punto Cargo";
            this.ColPunto.FieldName = "nom_punto_cargo";
            this.ColPunto.Name = "ColPunto";
            this.ColPunto.Visible = true;
            this.ColPunto.VisibleIndex = 0;
            // 
            // Col_suncentro
            // 
            this.Col_suncentro.Caption = "SubCentro Costo";
            this.Col_suncentro.FieldName = "IdCentroCosto_sub_centro_costo";
            this.Col_suncentro.Name = "Col_suncentro";
            // 
            // cmb_subcentroCosto
            // 
            this.cmb_subcentroCosto.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_subcentroCosto.AutoHeight = false;
            this.cmb_subcentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentroCosto.DisplayMember = "Centro_costo2";
            this.cmb_subcentroCosto.Name = "cmb_subcentroCosto";
            this.cmb_subcentroCosto.ReadOnly = true;
            this.cmb_subcentroCosto.ValueMember = "IdRegistro";
            this.cmb_subcentroCosto.View = this.gridView7;
            this.cmb_subcentroCosto.Click += new System.EventHandler(this.cmb_subcentroCosto_Click);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_subCentro_costo});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // col_subCentro_costo
            // 
            this.col_subCentro_costo.Caption = "Subcentro de costo";
            this.col_subCentro_costo.FieldName = "Centro_costo";
            this.col_subCentro_costo.Name = "col_subCentro_costo";
            this.col_subCentro_costo.Visible = true;
            this.col_subCentro_costo.VisibleIndex = 0;
            this.col_subCentro_costo.Width = 1052;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDepartamento);
            this.groupBox2.Controls.Add(this.cmbMotivo);
            this.groupBox2.Controls.Add(this.ucCom_TerminoPagoCmb1);
            this.groupBox2.Controls.Add(this.ucCom_Comprador1);
            this.groupBox2.Controls.Add(this.ucCp_Proveedor1);
            this.groupBox2.Controls.Add(this.cmbSucursal);
            this.groupBox2.Controls.Add(this.txeFlete);
            this.groupBox2.Controls.Add(this.cmb_estado_cierre);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.dtpFechaEntrega);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbEstadoAprob);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtPlazo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dTPFecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblanulado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumOC);
            this.groupBox2.Controls.Add(this.txtIdOC);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1239, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Orden de Compra:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Location = new System.Drawing.Point(88, 100);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(294, 28);
            this.cmbDepartamento.TabIndex = 125;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.Location = new System.Drawing.Point(871, 121);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(140, 27);
            this.cmbMotivo.TabIndex = 123;
            // 
            // ucCom_TerminoPagoCmb1
            // 
            this.ucCom_TerminoPagoCmb1.Location = new System.Drawing.Point(494, 40);
            this.ucCom_TerminoPagoCmb1.Name = "ucCom_TerminoPagoCmb1";
            this.ucCom_TerminoPagoCmb1.Size = new System.Drawing.Size(265, 28);
            this.ucCom_TerminoPagoCmb1.TabIndex = 122;
            this.ucCom_TerminoPagoCmb1.event_cmbTermPago_EditValueChanged += new Core.Erp.Winform.Controles.UCCom_TerminoPagoCmb.delegate_cmbTermPago_EditValueChanged(this.ucCom_TerminoPagoCmb1_event_cmbTermPago_EditValueChanged);
            // 
            // ucCom_Comprador1
            // 
            this.ucCom_Comprador1.Location = new System.Drawing.Point(498, 70);
            this.ucCom_Comprador1.Name = "ucCom_Comprador1";
            this.ucCom_Comprador1.Size = new System.Drawing.Size(265, 26);
            this.ucCom_Comprador1.TabIndex = 120;
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(88, 74);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(294, 27);
            this.ucCp_Proveedor1.TabIndex = 119;
            this.ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += new Core.Erp.Winform.Controles.UCCp_Proveedor.delegate_cmb_proveedor_EditValueChanged(this.ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged_1);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(88, 47);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(287, 22);
            this.cmbSucursal.TabIndex = 118;
            this.cmbSucursal.event_cmbsucursal_EditValueChanged += new Core.Erp.Winform.Controles.UCGe_Sucursal_combo.delegate_cmbsucursal_EditValueChanged(this.cmb_sucursal_ValueChanged);
            // 
            // txeFlete
            // 
            this.txeFlete.Location = new System.Drawing.Point(874, 98);
            this.txeFlete.Name = "txeFlete";
            this.txeFlete.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeFlete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeFlete.Size = new System.Drawing.Size(134, 20);
            this.txeFlete.TabIndex = 117;
            // 
            // cmb_estado_cierre
            // 
            this.cmb_estado_cierre.Location = new System.Drawing.Point(498, 128);
            this.cmb_estado_cierre.Name = "cmb_estado_cierre";
            this.cmb_estado_cierre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estado_cierre.Properties.DisplayMember = "Descripcion";
            this.cmb_estado_cierre.Properties.ValueMember = "IdEstado_cierre";
            this.cmb_estado_cierre.Properties.View = this.gridView9;
            this.cmb_estado_cierre.Size = new System.Drawing.Size(261, 20);
            this.cmb_estado_cierre.TabIndex = 115;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstado_cierre,
            this.colDescripcion1});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstado_cierre
            // 
            this.colIdEstado_cierre.Caption = "IdEstado_cierre";
            this.colIdEstado_cierre.FieldName = "IdEstado_cierre";
            this.colIdEstado_cierre.Name = "colIdEstado_cierre";
            this.colIdEstado_cierre.Visible = true;
            this.colIdEstado_cierre.VisibleIndex = 0;
            this.colIdEstado_cierre.Width = 138;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripcion";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 1042;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(391, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 114;
            this.label22.Text = "Estado Cierre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(777, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 113;
            this.label21.Text = "Fecha Entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(874, 41);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(133, 20);
            this.dtpFechaEntrega.TabIndex = 112;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(793, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 110;
            this.label20.Text = "Motivo:";
            // 
            // cmbEstadoAprob
            // 
            this.cmbEstadoAprob.Location = new System.Drawing.Point(498, 103);
            this.cmbEstadoAprob.Name = "cmbEstadoAprob";
            this.cmbEstadoAprob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAprob.Properties.DisplayMember = "Nombre";
            this.cmbEstadoAprob.Properties.ValueMember = "IdCatalogocompra";
            this.cmbEstadoAprob.Properties.View = this.gridView4;
            this.cmbEstadoAprob.Size = new System.Drawing.Size(261, 20);
            this.cmbEstadoAprob.TabIndex = 109;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCatalogo,
            this.colCodigo,
            this.colIdCatalogocompra,
            this.coldescripcion,
            this.colestado,
            this.colorden,
            this.colNombre,
            this.colname});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colIdCatalogocompra
            // 
            this.colIdCatalogocompra.FieldName = "IdCatalogocompra";
            this.colIdCatalogocompra.Name = "colIdCatalogocompra";
            this.colIdCatalogocompra.Visible = true;
            this.colIdCatalogocompra.VisibleIndex = 1;
            this.colIdCatalogocompra.Width = 279;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colorden
            // 
            this.colorden.FieldName = "orden";
            this.colorden.Name = "colorden";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 901;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(391, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 108;
            this.label19.Text = "Estado Aprobación:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 105;
            this.label18.Text = "Departamento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(391, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 103;
            this.label17.Text = "Comprador:";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(874, 69);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Properties.Mask.EditMask = "###0 ds";
            this.txtPlazo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPlazo.Size = new System.Drawing.Size(133, 20);
            this.txtPlazo.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Observacion:";
            // 
            // dTPFecha
            // 
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFecha.Location = new System.Drawing.Point(874, 14);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(133, 20);
            this.dTPFecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Flete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Fecha O/C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Plazo O/C:";
            // 
            // lblanulado
            // 
            this.lblanulado.AutoSize = true;
            this.lblanulado.BackColor = System.Drawing.SystemColors.Control;
            this.lblanulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulado.ForeColor = System.Drawing.Color.Red;
            this.lblanulado.Location = new System.Drawing.Point(508, 16);
            this.lblanulado.Name = "lblanulado";
            this.lblanulado.Size = new System.Drawing.Size(122, 16);
            this.lblanulado.TabIndex = 91;
            this.lblanulado.Text = "****ANULADO***";
            this.lblanulado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Sucursal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Termino de Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "# O/C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "#Reg:";
            // 
            // txtNumOC
            // 
            this.txtNumOC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumOC.Location = new System.Drawing.Point(211, 19);
            this.txtNumOC.MaxLength = 50;
            this.txtNumOC.Name = "txtNumOC";
            this.txtNumOC.Size = new System.Drawing.Size(167, 20);
            this.txtNumOC.TabIndex = 1;
            // 
            // txtIdOC
            // 
            this.txtIdOC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIdOC.Location = new System.Drawing.Point(88, 21);
            this.txtIdOC.Name = "txtIdOC";
            this.txtIdOC.ReadOnly = true;
            this.txtIdOC.Size = new System.Drawing.Size(67, 20);
            this.txtIdOC.TabIndex = 1;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(88, 150);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(925, 38);
            this.txtObservacion.TabIndex = 93;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1239, 27);
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
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 522);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1060, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // frmCom_OrdenCompra_Mant_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 548);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmCom_OrdenCompra_Mant_FJ";
            this.Text = "Orden de Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCom_OrdenCompra_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCom_OrdenCompra_Mant_Load);
            this.panel_central.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoImpuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_puntoCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeFlete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estado_cierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtPlazo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblanulado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOC;
        private System.Windows.Forms.TextBox txtIdOC;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.GridControl gridControlOrdenCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoCodigo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colPorc_Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDetallexItems;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private DevExpress.XtraGrid.Columns.GridColumn colEsta_en_base;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantidad;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoAprob;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogocompra;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colorden;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtporcDesc;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn colIco1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponible;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_combo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_estado_cierre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.TextEdit txeFlete;
        private Controles.UCGe_Sucursal_combo cmbSucursal;
        private Controles.UCCom_Comprador ucCom_Comprador1;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
        private Controles.UCCom_TerminoPagoCmb ucCom_TerminoPagoCmb1;
        private DevExpress.XtraGrid.Columns.GridColumn ColNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private Controles.UCCom_MotivoCompraCmb cmbMotivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPor_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida_x_prod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTipoImpuesto1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_cmb;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto_cmb;
        private Controles.UCCom_Departamento_cmb cmbDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_grupo_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdPunto_cargo_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_punto_cargo_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn col_grupo_punto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn col_subCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_cmb_puntoC;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_puntoCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn ColPunto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_suncentro;
    }
}
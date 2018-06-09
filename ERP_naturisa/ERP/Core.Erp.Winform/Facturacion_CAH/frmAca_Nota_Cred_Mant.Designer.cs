namespace Core.Erp.Winform.Facturacion_CAH
{
    partial class frmAca_Nota_Cred_Mant
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDetalle = new System.Windows.Forms.TabPage();
            this.gridControlNotaCreDeb = new DevExpress.XtraGrid.GridControl();
            this.gridViewNotaCreDeb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCod_Impuesto_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImpuestoIva = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_txtObservacion = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdPunto_Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Punto_cargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPunto_cargo_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Grupo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorce_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsc_precioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPageDiarioConta = new System.Windows.Forms.TabPage();
            this.ucCon_GridDiario = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_cargar_diario = new System.Windows.Forms.ToolStripButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ucAca_Estudiante = new Core.Erp.Winform.Controles.UCAca_Estudiante();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDatosInternos = new DevExpress.XtraTab.XtraTabPage();
            this.ctrl_NumDoc = new Core.Erp.Winform.Controles.UCGe_NumeroDocTrans();
            this.rdbUsoInterno = new System.Windows.Forms.RadioButton();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.rdbAutSri = new System.Windows.Forms.RadioButton();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.tabDocumentosRelacionados = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDocRelacionados = new DevExpress.XtraGrid.GridControl();
            this.gridViewDocRelacionados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor_aplicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Buscar_doc = new System.Windows.Forms.ToolStripButton();
            this.ctrl_Cliente = new Core.Erp.Winform.Controles.UCFa_ClienteCmb();
            this.cmbCredito = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCtaCble_TipoNota = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cmb_vendedor = new Core.Erp.Winform.Controles.UCFa_VendedorCmb();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdNotaCred = new System.Windows.Forms.Label();
            this.txtCodigoNot = new DevExpress.XtraEditors.TextEdit();
            this.cmbCaja = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumNot = new DevExpress.XtraEditors.TextEdit();
            this.ucSucursalBode = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.colCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdcentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotaCreDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotaCreDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImpuestoIva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_txtObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPageDiarioConta.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabDatosInternos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            this.tabDocumentosRelacionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocRelacionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocRelacionados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1022, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            this.ucGe_Menu.Visible_btn_Generar_XML = true;
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
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 578);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1022, 24);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1022, 549);
            this.panelMain.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDetalle);
            this.tabControl1.Controls.Add(this.tabPageDiarioConta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 288);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageDetalle
            // 
            this.tabPageDetalle.Controls.Add(this.gridControlNotaCreDeb);
            this.tabPageDetalle.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetalle.Name = "tabPageDetalle";
            this.tabPageDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalle.Size = new System.Drawing.Size(1014, 235);
            this.tabPageDetalle.TabIndex = 0;
            this.tabPageDetalle.Text = "Detalle de Nota";
            this.tabPageDetalle.UseVisualStyleBackColor = true;
            // 
            // gridControlNotaCreDeb
            // 
            this.gridControlNotaCreDeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNotaCreDeb.Location = new System.Drawing.Point(3, 3);
            this.gridControlNotaCreDeb.MainView = this.gridViewNotaCreDeb;
            this.gridControlNotaCreDeb.Name = "gridControlNotaCreDeb";
            this.gridControlNotaCreDeb.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.col_txtObservacion,
            this.cmb_Grupo,
            this.cmb_Punto_cargo,
            this.cmbImpuestoIva,
            this.cmbCentroCosto});
            this.gridControlNotaCreDeb.Size = new System.Drawing.Size(1008, 229);
            this.gridControlNotaCreDeb.TabIndex = 0;
            this.gridControlNotaCreDeb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNotaCreDeb});
            this.gridControlNotaCreDeb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControlNotaCreDeb_KeyDown);
            // 
            // gridViewNotaCreDeb
            // 
            this.gridViewNotaCreDeb.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo_Producto,
            this.colCantidad,
            this.colPrecio,
            this.colPorDesc,
            this.colDescuento,
            this.colSubtotal,
            this.colIdCod_Impuesto_Iva,
            this.colIva,
            this.colTotal,
            this.colDetalle,
            this.colSecuencia,
            this.colDescuento_total,
            this.ColIdPunto_Cargo,
            this.colIdPunto_cargo_grupo,
            this.colPorce_Iva,
            this.colsc_precioFinal,
            this.colCentroCosto});
            this.gridViewNotaCreDeb.GridControl = this.gridControlNotaCreDeb;
            this.gridViewNotaCreDeb.Name = "gridViewNotaCreDeb";
            this.gridViewNotaCreDeb.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewNotaCreDeb.OptionsView.ShowFooter = true;
            this.gridViewNotaCreDeb.OptionsView.ShowGroupedColumns = true;
            this.gridViewNotaCreDeb.OptionsView.ShowGroupPanel = false;
            this.gridViewNotaCreDeb.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNotaCreDeb_FocusedRowChanged);
            this.gridViewNotaCreDeb.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewNotaCreDeb_CellValueChanged);
            // 
            // colCodigo_Producto
            // 
            this.colCodigo_Producto.Caption = "Item";
            this.colCodigo_Producto.ColumnEdit = this.cmbProducto_grid;
            this.colCodigo_Producto.FieldName = "IdProducto";
            this.colCodigo_Producto.Name = "colCodigo_Producto";
            this.colCodigo_Producto.Visible = true;
            this.colCodigo_Producto.VisibleIndex = 0;
            this.colCodigo_Producto.Width = 257;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colCodigo,
            this.colProducto});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "pr_codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 2;
            this.colCodigo.Width = 217;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "pr_descripcion";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 963;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "sc_cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 73;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "sc_Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 80;
            // 
            // colPorDesc
            // 
            this.colPorDesc.Caption = "% Desc.";
            this.colPorDesc.FieldName = "sc_PordescUni";
            this.colPorDesc.Name = "colPorDesc";
            this.colPorDesc.Visible = true;
            this.colPorDesc.VisibleIndex = 4;
            this.colPorDesc.Width = 73;
            // 
            // colDescuento
            // 
            this.colDescuento.Caption = "Descuento uni";
            this.colDescuento.FieldName = "sc_descUni";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.AllowEdit = false;
            this.colDescuento.Width = 60;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Caption = "SubTotal";
            this.colSubtotal.FieldName = "sc_subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.OptionsColumn.AllowEdit = false;
            this.colSubtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 7;
            this.colSubtotal.Width = 72;
            // 
            // colIdCod_Impuesto_Iva
            // 
            this.colIdCod_Impuesto_Iva.Caption = "% Iva";
            this.colIdCod_Impuesto_Iva.ColumnEdit = this.cmbImpuestoIva;
            this.colIdCod_Impuesto_Iva.FieldName = "IdCod_Impuesto_Iva";
            this.colIdCod_Impuesto_Iva.Name = "colIdCod_Impuesto_Iva";
            this.colIdCod_Impuesto_Iva.Visible = true;
            this.colIdCod_Impuesto_Iva.VisibleIndex = 8;
            this.colIdCod_Impuesto_Iva.Width = 48;
            // 
            // cmbImpuestoIva
            // 
            this.cmbImpuestoIva.AutoHeight = false;
            this.cmbImpuestoIva.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImpuestoIva.DisplayMember = "nom_impuesto";
            this.cmbImpuestoIva.Name = "cmbImpuestoIva";
            this.cmbImpuestoIva.ValueMember = "IdCod_Impuesto";
            this.cmbImpuestoIva.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto,
            this.colnom_impuesto});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto
            // 
            this.colIdCod_Impuesto.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto.Name = "colIdCod_Impuesto";
            this.colIdCod_Impuesto.Visible = true;
            this.colIdCod_Impuesto.VisibleIndex = 1;
            this.colIdCod_Impuesto.Width = 300;
            // 
            // colnom_impuesto
            // 
            this.colnom_impuesto.Caption = "Impuesto";
            this.colnom_impuesto.FieldName = "nom_impuesto";
            this.colnom_impuesto.Name = "colnom_impuesto";
            this.colnom_impuesto.Visible = true;
            this.colnom_impuesto.VisibleIndex = 0;
            this.colnom_impuesto.Width = 880;
            // 
            // colIva
            // 
            this.colIva.Caption = "$Iva";
            this.colIva.FieldName = "sc_iva";
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 9;
            this.colIva.Width = 37;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "sc_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 10;
            this.colTotal.Width = 56;
            // 
            // colDetalle
            // 
            this.colDetalle.Caption = "Detalle";
            this.colDetalle.ColumnEdit = this.col_txtObservacion;
            this.colDetalle.FieldName = "DetallexItems";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 1;
            this.colDetalle.Width = 143;
            // 
            // col_txtObservacion
            // 
            this.col_txtObservacion.AutoHeight = false;
            this.col_txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.col_txtObservacion.Name = "col_txtObservacion";
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.OptionsColumn.AllowEdit = false;
            this.colSecuencia.Width = 57;
            // 
            // colDescuento_total
            // 
            this.colDescuento_total.Caption = "Descuento";
            this.colDescuento_total.FieldName = "sc_descTotal";
            this.colDescuento_total.Name = "colDescuento_total";
            this.colDescuento_total.OptionsColumn.AllowEdit = false;
            this.colDescuento_total.Visible = true;
            this.colDescuento_total.VisibleIndex = 5;
            // 
            // ColIdPunto_Cargo
            // 
            this.ColIdPunto_Cargo.Caption = "Punto cargo";
            this.ColIdPunto_Cargo.ColumnEdit = this.cmb_Punto_cargo;
            this.ColIdPunto_Cargo.FieldName = "IdPunto_cargo";
            this.ColIdPunto_Cargo.Name = "ColIdPunto_Cargo";
            this.ColIdPunto_Cargo.Visible = true;
            this.ColIdPunto_Cargo.VisibleIndex = 12;
            this.ColIdPunto_Cargo.Width = 113;
            // 
            // cmb_Punto_cargo
            // 
            this.cmb_Punto_cargo.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_Punto_cargo.AutoHeight = false;
            this.cmb_Punto_cargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Punto_cargo.DisplayMember = "nom_punto_cargo";
            this.cmb_Punto_cargo.Name = "cmb_Punto_cargo";
            this.cmb_Punto_cargo.ReadOnly = true;
            this.cmb_Punto_cargo.ValueMember = "IdPunto_cargo";
            this.cmb_Punto_cargo.View = this.gridView3;
            this.cmb_Punto_cargo.Click += new System.EventHandler(this.cmb_Punto_cargo_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Punto de cargo";
            this.gridColumn14.FieldName = "nom_punto_cargo";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            // 
            // colIdPunto_cargo_grupo
            // 
            this.colIdPunto_cargo_grupo.Caption = "Grupo";
            this.colIdPunto_cargo_grupo.ColumnEdit = this.cmb_Grupo;
            this.colIdPunto_cargo_grupo.FieldName = "IdPunto_cargo_grupo";
            this.colIdPunto_cargo_grupo.Name = "colIdPunto_cargo_grupo";
            this.colIdPunto_cargo_grupo.Visible = true;
            this.colIdPunto_cargo_grupo.VisibleIndex = 11;
            this.colIdPunto_cargo_grupo.Width = 71;
            // 
            // cmb_Grupo
            // 
            this.cmb_Grupo.AutoHeight = false;
            this.cmb_Grupo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Grupo.DisplayMember = "nom_punto_cargo_grupo";
            this.cmb_Grupo.Name = "cmb_Grupo";
            this.cmb_Grupo.ValueMember = "IdPunto_cargo_grupo";
            this.cmb_Grupo.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Grupo";
            this.gridColumn15.FieldName = "nom_punto_cargo_grupo";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            // 
            // colPorce_Iva
            // 
            this.colPorce_Iva.Caption = "colPorce_Iva";
            this.colPorce_Iva.FieldName = "vt_por_iva";
            this.colPorce_Iva.Name = "colPorce_Iva";
            this.colPorce_Iva.OptionsColumn.AllowEdit = false;
            // 
            // colsc_precioFinal
            // 
            this.colsc_precioFinal.Caption = "Precio/Final";
            this.colsc_precioFinal.FieldName = "sc_precioFinal";
            this.colsc_precioFinal.Name = "colsc_precioFinal";
            this.colsc_precioFinal.OptionsColumn.AllowEdit = false;
            this.colsc_precioFinal.Visible = true;
            this.colsc_precioFinal.VisibleIndex = 6;
            this.colsc_precioFinal.Width = 82;
            // 
            // tabPageDiarioConta
            // 
            this.tabPageDiarioConta.Controls.Add(this.ucCon_GridDiario);
            this.tabPageDiarioConta.Controls.Add(this.toolStrip2);
            this.tabPageDiarioConta.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiarioConta.Name = "tabPageDiarioConta";
            this.tabPageDiarioConta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiarioConta.Size = new System.Drawing.Size(1014, 235);
            this.tabPageDiarioConta.TabIndex = 1;
            this.tabPageDiarioConta.Text = "Diario Contable";
            this.tabPageDiarioConta.UseVisualStyleBackColor = true;
            // 
            // ucCon_GridDiario
            // 
            this.ucCon_GridDiario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiario.IdCtaCble_x_Banco = null;
            this.ucCon_GridDiario.Location = new System.Drawing.Point(3, 28);
            this.ucCon_GridDiario.Margin = new System.Windows.Forms.Padding(4);
            this.ucCon_GridDiario.Name = "ucCon_GridDiario";
            this.ucCon_GridDiario.Size = new System.Drawing.Size(1008, 204);
            this.ucCon_GridDiario.TabIndex = 2;
            this.ucCon_GridDiario.Visible_Botones = false;
            this.ucCon_GridDiario.Visible_Cabecera = false;
            this.ucCon_GridDiario.Visible_columna_GrupoPuntoCargo = true;
            this.ucCon_GridDiario.Visible_columna_PuntoCargo = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cargar_diario});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_cargar_diario
            // 
            this.btn_cargar_diario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cargar_diario.Name = "btn_cargar_diario";
            this.btn_cargar_diario.Size = new System.Drawing.Size(80, 22);
            this.btn_cargar_diario.Text = "Cargar Diario";
            this.btn_cargar_diario.Click += new System.EventHandler(this.btn_cargar_diario_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.ucAca_Estudiante);
            this.panelTop.Controls.Add(this.xtraTabControl1);
            this.panelTop.Controls.Add(this.ctrl_Cliente);
            this.panelTop.Controls.Add(this.cmbCredito);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.cmbCtaCble_TipoNota);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.txtObservacion);
            this.panelTop.Controls.Add(this.cmb_vendedor);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.dateFechaVencimiento);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.dateFecha);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.lblIdNotaCred);
            this.panelTop.Controls.Add(this.txtCodigoNot);
            this.panelTop.Controls.Add(this.cmbCaja);
            this.panelTop.Controls.Add(this.txtNumNot);
            this.panelTop.Controls.Add(this.ucSucursalBode);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1022, 288);
            this.panelTop.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Estudiante:";
            // 
            // ucAca_Estudiante
            // 
            this.ucAca_Estudiante.Location = new System.Drawing.Point(98, 137);
            this.ucAca_Estudiante.Name = "ucAca_Estudiante";
            this.ucAca_Estudiante.Size = new System.Drawing.Size(415, 27);
            this.ucAca_Estudiante.TabIndex = 81;
            this.ucAca_Estudiante.event_UCAca_Estudiante_EditValueChanged += new Core.Erp.Winform.Controles.UCAca_Estudiante.delegate_UCAca_Estudiante_EditValueChanged(this.ucAca_Estudiante_event_UCAca_Estudiante_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(520, 43);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabDatosInternos;
            this.xtraTabControl1.Size = new System.Drawing.Size(490, 211);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDatosInternos,
            this.tabDocumentosRelacionados});
            // 
            // tabDatosInternos
            // 
            this.tabDatosInternos.Controls.Add(this.ctrl_NumDoc);
            this.tabDatosInternos.Controls.Add(this.rdbUsoInterno);
            this.tabDatosInternos.Controls.Add(this.chkActivo);
            this.tabDatosInternos.Controls.Add(this.rdbAutSri);
            this.tabDatosInternos.Controls.Add(this.lblAnulado);
            this.tabDatosInternos.Name = "tabDatosInternos";
            this.tabDatosInternos.Size = new System.Drawing.Size(484, 183);
            this.tabDatosInternos.Text = "Datos internos";
            // 
            // ctrl_NumDoc
            // 
            this.ctrl_NumDoc.IdEstablecimiento = null;
            this.ctrl_NumDoc.IdPuntoEmision = null;
            this.ctrl_NumDoc.IdTipoDocumento = Core.Erp.Info.General.Cl_Enumeradores.eTipoDocumento_Talonario.NTCR;
            this.ctrl_NumDoc.Location = new System.Drawing.Point(20, 41);
            this.ctrl_NumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.ctrl_NumDoc.Name = "ctrl_NumDoc";
            this.ctrl_NumDoc.Size = new System.Drawing.Size(380, 51);
            this.ctrl_NumDoc.TabIndex = 11;
            // 
            // rdbUsoInterno
            // 
            this.rdbUsoInterno.AutoSize = true;
            this.rdbUsoInterno.Location = new System.Drawing.Point(222, 6);
            this.rdbUsoInterno.Name = "rdbUsoInterno";
            this.rdbUsoInterno.Size = new System.Drawing.Size(105, 17);
            this.rdbUsoInterno.TabIndex = 12;
            this.rdbUsoInterno.Text = "Para Uso Interno";
            this.rdbUsoInterno.UseVisualStyleBackColor = true;
            this.rdbUsoInterno.CheckedChanged += new System.EventHandler(this.rdbUsoInt_CheckedChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(331, 106);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(83, 19);
            this.chkActivo.TabIndex = 77;
            // 
            // rdbAutSri
            // 
            this.rdbAutSri.AutoSize = true;
            this.rdbAutSri.Checked = true;
            this.rdbAutSri.Location = new System.Drawing.Point(77, 6);
            this.rdbAutSri.Name = "rdbAutSri";
            this.rdbAutSri.Size = new System.Drawing.Size(125, 17);
            this.rdbAutSri.TabIndex = 0;
            this.rdbAutSri.TabStop = true;
            this.rdbAutSri.Text = "Autorizada por el SRI";
            this.rdbAutSri.UseVisualStyleBackColor = true;
            this.rdbAutSri.CheckedChanged += new System.EventHandler(this.rdbAutSri_CheckedChanged);
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(286, 140);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(104, 16);
            this.lblAnulado.TabIndex = 3;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.Visible = false;
            // 
            // tabDocumentosRelacionados
            // 
            this.tabDocumentosRelacionados.Controls.Add(this.gridControlDocRelacionados);
            this.tabDocumentosRelacionados.Controls.Add(this.toolStrip1);
            this.tabDocumentosRelacionados.Name = "tabDocumentosRelacionados";
            this.tabDocumentosRelacionados.Size = new System.Drawing.Size(484, 183);
            this.tabDocumentosRelacionados.Text = "Documentos relacionados";
            // 
            // gridControlDocRelacionados
            // 
            this.gridControlDocRelacionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDocRelacionados.Location = new System.Drawing.Point(0, 25);
            this.gridControlDocRelacionados.MainView = this.gridViewDocRelacionados;
            this.gridControlDocRelacionados.Name = "gridControlDocRelacionados";
            this.gridControlDocRelacionados.Size = new System.Drawing.Size(484, 158);
            this.gridControlDocRelacionados.TabIndex = 1;
            this.gridControlDocRelacionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocRelacionados});
            // 
            // gridViewDocRelacionados
            // 
            this.gridViewDocRelacionados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.col_valor_aplicado,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.colSaldoNC});
            this.gridViewDocRelacionados.GridControl = this.gridControlDocRelacionados;
            this.gridViewDocRelacionados.Name = "gridViewDocRelacionados";
            this.gridViewDocRelacionados.OptionsView.ShowGroupPanel = false;
            this.gridViewDocRelacionados.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDocRelacionados_FocusedRowChanged);
            this.gridViewDocRelacionados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDocRelacionados_CellValueChanged);
            this.gridViewDocRelacionados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewDocRelacionados_KeyDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdEmpresa";
            this.gridColumn1.FieldName = "IdEmpresa_fac_nd_doc_mod";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IdSucursal";
            this.gridColumn2.FieldName = "IdSucursal_fac_nd_doc_mod";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdBodega";
            this.gridColumn3.FieldName = "IdBodega_fac_nd_doc_mod";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Establecimiento";
            this.gridColumn4.FieldName = "vt_serie1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Punto de emisión";
            this.gridColumn5.FieldName = "vt_serie2";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "# Documento";
            this.gridColumn6.FieldName = "vt_NumFactura";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "IdDoc";
            this.gridColumn7.FieldName = "IdCbteVta_fac_nd_doc_mod";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "TipoDoc";
            this.gridColumn8.FieldName = "vt_tipoDoc";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 62;
            // 
            // col_valor_aplicado
            // 
            this.col_valor_aplicado.Caption = "Valor aplicado";
            this.col_valor_aplicado.FieldName = "Valor_Aplicado";
            this.col_valor_aplicado.Name = "col_valor_aplicado";
            this.col_valor_aplicado.Visible = true;
            this.col_valor_aplicado.VisibleIndex = 3;
            this.col_valor_aplicado.Width = 77;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Observación";
            this.gridColumn10.FieldName = "vt_Observacion";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 159;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Total";
            this.gridColumn11.FieldName = "vt_total";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 66;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "# Documento";
            this.gridColumn12.FieldName = "num_doc";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 113;
            // 
            // colSaldoNC
            // 
            this.colSaldoNC.Caption = "Saldo";
            this.colSaldoNC.FieldName = "saldo";
            this.colSaldoNC.Name = "colSaldoNC";
            this.colSaldoNC.OptionsColumn.AllowEdit = false;
            this.colSaldoNC.Visible = true;
            this.colSaldoNC.VisibleIndex = 4;
            this.colSaldoNC.Width = 74;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Buscar_doc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Buscar_doc
            // 
            this.btn_Buscar_doc.Image = global::Core.Erp.Winform.Properties.Resources.Buscar1_32X32;
            this.btn_Buscar_doc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Buscar_doc.Name = "btn_Buscar_doc";
            this.btn_Buscar_doc.Size = new System.Drawing.Size(127, 22);
            this.btn_Buscar_doc.Text = "Buscar documento";
            this.btn_Buscar_doc.Click += new System.EventHandler(this.btn_BuscarFactura_Click);
            // 
            // ctrl_Cliente
            // 
            this.ctrl_Cliente.Location = new System.Drawing.Point(98, 161);
            this.ctrl_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.ctrl_Cliente.Name = "ctrl_Cliente";
            this.ctrl_Cliente.Size = new System.Drawing.Size(415, 26);
            this.ctrl_Cliente.TabIndex = 1;
            this.ctrl_Cliente.event_cmb_cliente_EditValueChanged += new Core.Erp.Winform.Controles.UCFa_ClienteCmb.delegate_cmb_cliente_EditValueChanged(this.ctrl_Cliente_Event_cmb_cliente_EditValueChanged);
            // 
            // cmbCredito
            // 
            this.cmbCredito.Location = new System.Drawing.Point(71, 92);
            this.cmbCredito.Name = "cmbCredito";
            this.cmbCredito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCredito.Properties.DisplayMember = "no_Descripcion";
            this.cmbCredito.Properties.ValueMember = "IdTipoNota";
            this.cmbCredito.Properties.View = this.searchLookUpEdit1View;
            this.cmbCredito.Size = new System.Drawing.Size(443, 20);
            this.cmbCredito.TabIndex = 4;
            this.cmbCredito.EditValueChanged += new System.EventHandler(this.cmbCredito_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodTipoNota,
            this.ColTipo,
            this.colDescripcionTipo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCodTipoNota
            // 
            this.colCodTipoNota.Caption = "Código";
            this.colCodTipoNota.FieldName = "CodTipoNota";
            this.colCodTipoNota.Name = "colCodTipoNota";
            this.colCodTipoNota.Visible = true;
            this.colCodTipoNota.VisibleIndex = 0;
            // 
            // ColTipo
            // 
            this.ColTipo.Caption = "Tipo Nota";
            this.ColTipo.FieldName = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Visible = true;
            this.ColTipo.VisibleIndex = 1;
            // 
            // colDescripcionTipo
            // 
            this.colDescripcionTipo.Caption = "Descripción";
            this.colDescripcionTipo.FieldName = "no_Descripcion";
            this.colDescripcionTipo.Name = "colDescripcionTipo";
            this.colDescripcionTipo.Visible = true;
            this.colDescripcionTipo.VisibleIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Motivo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Cta Contable :";
            // 
            // cmbCtaCble_TipoNota
            // 
            this.cmbCtaCble_TipoNota.Location = new System.Drawing.Point(97, 110);
            this.cmbCtaCble_TipoNota.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCtaCble_TipoNota.Name = "cmbCtaCble_TipoNota";
            this.cmbCtaCble_TipoNota.Size = new System.Drawing.Size(417, 29);
            this.cmbCtaCble_TipoNota.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Observacion:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Location = new System.Drawing.Point(6, 238);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(470, 45);
            this.txtObservacion.TabIndex = 17;
            // 
            // cmb_vendedor
            // 
            this.cmb_vendedor.Location = new System.Drawing.Point(13, 191);
            this.cmb_vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_vendedor.Name = "cmb_vendedor";
            this.cmb_vendedor.Size = new System.Drawing.Size(500, 26);
            this.cmb_vendedor.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Vcto :";
            // 
            // dateFechaVencimiento
            // 
            this.dateFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaVencimiento.Location = new System.Drawing.Point(910, 17);
            this.dateFechaVencimiento.Name = "dateFechaVencimiento";
            this.dateFechaVencimiento.Size = new System.Drawing.Size(112, 20);
            this.dateFechaVencimiento.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha:";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(710, 16);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(112, 20);
            this.dateFecha.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Caja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // lblIdNotaCred
            // 
            this.lblIdNotaCred.AutoSize = true;
            this.lblIdNotaCred.Location = new System.Drawing.Point(12, 16);
            this.lblIdNotaCred.Name = "lblIdNotaCred";
            this.lblIdNotaCred.Size = new System.Drawing.Size(64, 13);
            this.lblIdNotaCred.TabIndex = 7;
            this.lblIdNotaCred.Text = "IdNota Cred";
            // 
            // txtCodigoNot
            // 
            this.txtCodigoNot.Location = new System.Drawing.Point(245, 13);
            this.txtCodigoNot.Name = "txtCodigoNot";
            this.txtCodigoNot.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoNot.TabIndex = 6;
            // 
            // cmbCaja
            // 
            this.cmbCaja.Location = new System.Drawing.Point(392, 16);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCaja.Properties.DisplayMember = "ca_Descripcion";
            this.cmbCaja.Properties.ValueMember = "IdCaja";
            this.cmbCaja.Properties.View = this.gridView1;
            this.cmbCaja.Size = new System.Drawing.Size(254, 20);
            this.cmbCaja.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colIdentificador});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "ca_Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colIdentificador
            // 
            this.colIdentificador.Caption = "Identificador";
            this.colIdentificador.FieldName = "IdCaja";
            this.colIdentificador.Name = "colIdentificador";
            this.colIdentificador.Visible = true;
            this.colIdentificador.VisibleIndex = 1;
            // 
            // txtNumNot
            // 
            this.txtNumNot.Location = new System.Drawing.Point(82, 13);
            this.txtNumNot.Name = "txtNumNot";
            this.txtNumNot.Size = new System.Drawing.Size(100, 20);
            this.txtNumNot.TabIndex = 2;
            // 
            // ucSucursalBode
            // 
            this.ucSucursalBode.Location = new System.Drawing.Point(12, 42);
            this.ucSucursalBode.Margin = new System.Windows.Forms.Padding(4);
            this.ucSucursalBode.Name = "ucSucursalBode";
            this.ucSucursalBode.Size = new System.Drawing.Size(501, 53);
            this.ucSucursalBode.TabIndex = 0;
            this.ucSucursalBode.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.ucSucursalBode.Visible_cmb_bodega = true;
            this.ucSucursalBode.Event_cmb_sucursal1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_sucursal1_EditValueChanged(this.ucSucursalBode_Event_cmb_sucursal1_EditValueChanged);
            this.ucSucursalBode.Event_cmb_bodega1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(this.ucSucursalBode_Event_cmb_bodega1_EditValueChanged);
            // 
            // colCentroCosto
            // 
            this.colCentroCosto.Caption = "Centro Costo";
            this.colCentroCosto.ColumnEdit = this.cmbCentroCosto;
            this.colCentroCosto.FieldName = "IdCentroCosto";
            this.colCentroCosto.Name = "colCentroCosto";
            this.colCentroCosto.Visible = true;
            this.colCentroCosto.VisibleIndex = 13;
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.AutoHeight = false;
            this.cmbCentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto.DisplayMember = "IdCentroCosto";
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.ValueMember = "Centro_costo";
            this.cmbCentroCosto.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdcentroCosto,
            this.col_CentroCosto});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdcentroCosto
            // 
            this.colIdcentroCosto.Caption = "Id Centro Costo";
            this.colIdcentroCosto.FieldName = "IdCentroCosto";
            this.colIdcentroCosto.Name = "colIdcentroCosto";
            this.colIdcentroCosto.Visible = true;
            this.colIdcentroCosto.VisibleIndex = 0;
            // 
            // col_CentroCosto
            // 
            this.col_CentroCosto.Caption = "Centro Costo";
            this.col_CentroCosto.FieldName = "Centro_costo";
            this.col_CentroCosto.Name = "col_CentroCosto";
            this.col_CentroCosto.Visible = true;
            this.col_CentroCosto.VisibleIndex = 1;
            // 
            // frmAca_Nota_Cred_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmAca_Nota_Cred_Mant";
            this.Text = "Nota de crédito ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAca_Nota_Cred_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmAca_Nota_Cred_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotaCreDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotaCreDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImpuestoIva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_txtObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPageDiarioConta.ResumeLayout(false);
            this.tabPageDiarioConta.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabDatosInternos.ResumeLayout(false);
            this.tabDatosInternos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            this.tabDocumentosRelacionados.ResumeLayout(false);
            this.tabDocumentosRelacionados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocRelacionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocRelacionados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private Controles.UCFa_ClienteCmb ctrl_Cliente;
        private Controles.UCIn_Sucursal_Bodega ucSucursalBode;
        private DevExpress.XtraEditors.TextEdit txtNumNot;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCredito;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCaja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdNotaCred;
        private DevExpress.XtraEditors.TextEdit txtCodigoNot;
        private Controles.UCGe_NumeroDocTrans ctrl_NumDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFechaVencimiento;
        private Controles.UCFa_VendedorCmb cmb_vendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.RadioButton rdbAutSri;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmbCtaCble_TipoNota;
        private System.Windows.Forms.RadioButton rdbUsoInterno;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDetalle;
        private DevExpress.XtraGrid.GridControl gridControlNotaCreDeb;
        private System.Windows.Forms.TabPage tabPageDiarioConta;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificador;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colPorDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewNotaCreDeb;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_txtObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento_total;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabDatosInternos;
        private DevExpress.XtraTab.XtraTabPage tabDocumentosRelacionados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Buscar_doc;
        private DevExpress.XtraGrid.GridControl gridControlDocRelacionados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDocRelacionados;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor_aplicado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPunto_Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_grupo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbImpuestoIva;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colPorce_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colsc_precioFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoNC;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiario;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_cargar_diario;
        private Controles.UCAca_Estudiante ucAca_Estudiante;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdcentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn col_CentroCosto;
    }
}
namespace Core.Erp.Winform.Inventario_Fj
{
    partial class FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento
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
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblNoDoc = new DevExpress.XtraEditors.LabelControl();
            this.lblNoFact = new DevExpress.XtraEditors.LabelControl();
            this.txtNoDoc = new DevExpress.XtraEditors.TextEdit();
            this.txtNoFact = new DevExpress.XtraEditors.TextEdit();
            this.lblCentroCosto = new DevExpress.XtraEditors.LabelControl();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.ucCon_CentroCosto_ctas_Movi1 = new Core.Erp.Winform.Controles.UCCon_CentroCosto_ctas_Movi();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucaF_Activo_Fijo1 = new Core.Erp.Winform.Controles.UCAF_Activo_Fijo();
            this.lblActivoFijo = new DevExpress.XtraEditors.LabelControl();
            this.gridControlActivoFijo = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivoFijo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.slueProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCosto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManeja_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txeSTotal = new DevExpress.XtraEditors.TextEdit();
            this.txeSTotaliva = new DevExpress.XtraEditors.TextEdit();
            this.txeSsubtotal = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.lblNumTransaccion = new DevExpress.XtraEditors.LabelControl();
            this.txtId_OrdenSer = new DevExpress.XtraEditors.TextEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotaliva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            this.groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId_OrdenSer.Properties)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(581, 60);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(54, 13);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(650, 30);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(244, 20);
            this.deFecha.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(602, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNoDoc
            // 
            this.lblNoDoc.Location = new System.Drawing.Point(566, 90);
            this.lblNoDoc.Name = "lblNoDoc";
            this.lblNoDoc.Size = new System.Drawing.Size(69, 13);
            this.lblNoDoc.TabIndex = 7;
            this.lblNoDoc.Text = "# Documento:";
            // 
            // lblNoFact
            // 
            this.lblNoFact.Location = new System.Drawing.Point(583, 116);
            this.lblNoFact.Name = "lblNoFact";
            this.lblNoFact.Size = new System.Drawing.Size(52, 13);
            this.lblNoFact.TabIndex = 8;
            this.lblNoFact.Text = "# Factura:";
            // 
            // txtNoDoc
            // 
            this.txtNoDoc.Location = new System.Drawing.Point(650, 87);
            this.txtNoDoc.Name = "txtNoDoc";
            this.txtNoDoc.Size = new System.Drawing.Size(244, 20);
            this.txtNoDoc.TabIndex = 9;
            // 
            // txtNoFact
            // 
            this.txtNoFact.Location = new System.Drawing.Point(650, 113);
            this.txtNoFact.Name = "txtNoFact";
            this.txtNoFact.Size = new System.Drawing.Size(244, 20);
            this.txtNoFact.TabIndex = 10;
            // 
            // lblCentroCosto
            // 
            this.lblCentroCosto.Location = new System.Drawing.Point(10, 113);
            this.lblCentroCosto.Name = "lblCentroCosto";
            this.lblCentroCosto.Size = new System.Drawing.Size(81, 13);
            this.lblCentroCosto.TabIndex = 12;
            this.lblCentroCosto.Text = "Centro de costo:";
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(647, 56);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(298, 26);
            this.ucCp_Proveedor1.TabIndex = 13;
            // 
            // ucCon_CentroCosto_ctas_Movi1
            // 
            this.ucCon_CentroCosto_ctas_Movi1.IdCentroCostoPadre = null;
            this.ucCon_CentroCosto_ctas_Movi1.InfoCentroCosto = null;
            this.ucCon_CentroCosto_ctas_Movi1.Location = new System.Drawing.Point(100, 108);
            this.ucCon_CentroCosto_ctas_Movi1.Name = "ucCon_CentroCosto_ctas_Movi1";
            this.ucCon_CentroCosto_ctas_Movi1.Size = new System.Drawing.Size(453, 30);
            this.ucCon_CentroCosto_ctas_Movi1.TabIndex = 11;
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(44, 60);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(469, 54);
            this.ucIn_Sucursal_Bodega1.TabIndex = 2;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(965, 26);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // ucaF_Activo_Fijo1
            // 
            this.ucaF_Activo_Fijo1.BackColor = System.Drawing.Color.Transparent;
            this.ucaF_Activo_Fijo1.Location = new System.Drawing.Point(100, 36);
            this.ucaF_Activo_Fijo1.Name = "ucaF_Activo_Fijo1";
            this.ucaF_Activo_Fijo1.Size = new System.Drawing.Size(452, 27);
            this.ucaF_Activo_Fijo1.TabIndex = 14;
            // 
            // lblActivoFijo
            // 
            this.lblActivoFijo.Location = new System.Drawing.Point(39, 43);
            this.lblActivoFijo.Name = "lblActivoFijo";
            this.lblActivoFijo.Size = new System.Drawing.Size(52, 13);
            this.lblActivoFijo.TabIndex = 15;
            this.lblActivoFijo.Text = "Activo fijo:";
            // 
            // gridControlActivoFijo
            // 
            this.gridControlActivoFijo.Location = new System.Drawing.Point(16, 19);
            this.gridControlActivoFijo.MainView = this.gridViewActivoFijo;
            this.gridControlActivoFijo.Name = "gridControlActivoFijo";
            this.gridControlActivoFijo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Producto,
            this.txtCantidad,
            this.txtCosto,
            this.txtCodigo});
            this.gridControlActivoFijo.Size = new System.Drawing.Size(929, 187);
            this.gridControlActivoFijo.TabIndex = 16;
            this.gridControlActivoFijo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivoFijo});
            // 
            // gridViewActivoFijo
            // 
            this.gridViewActivoFijo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colCosto,
            this.colSubTotal,
            this.colIva,
            this.colTotal,
            this.colIdProducto,
            this.colManeja_Iva});
            this.gridViewActivoFijo.GridControl = this.gridControlActivoFijo;
            this.gridViewActivoFijo.Name = "gridViewActivoFijo";
            this.gridViewActivoFijo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewActivoFijo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewActivoFijo.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewActivoFijo.OptionsView.ShowGroupPanel = false;
            this.gridViewActivoFijo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewActivoFijo_CellValueChanged);
            this.gridViewActivoFijo.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewActivoFijo_CellValueChanging);
            this.gridViewActivoFijo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewActivoFijo_KeyDown);
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.ColumnEdit = this.cmb_Producto;
            this.colProducto.FieldName = "IdProducto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            this.colProducto.Width = 307;
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.AutoHeight = false;
            this.cmb_Producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.View = this.slueProducto;
            // 
            // slueProducto
            // 
            this.slueProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCod,
            this.colNombre});
            this.slueProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.slueProducto.Name = "slueProducto";
            this.slueProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.slueProducto.OptionsView.ShowGroupPanel = false;
            // 
            // colCod
            // 
            this.colCod.Caption = "Código";
            this.colCod.FieldName = "pr_codigo";
            this.colCod.Name = "colCod";
            this.colCod.Visible = true;
            this.colCod.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "pr_descripcion";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.txtCantidad;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 109;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoHeight = false;
            this.txtCantidad.Mask.EditMask = "#,######.##;#,######.##";
            this.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // colCosto
            // 
            this.colCosto.Caption = "Costo";
            this.colCosto.ColumnEdit = this.txtCosto;
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 2;
            this.colCosto.Width = 106;
            // 
            // txtCosto
            // 
            this.txtCosto.AutoHeight = false;
            this.txtCosto.Mask.EditMask = "#,######.##;#,######.##";
            this.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCosto.Name = "txtCosto";
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "SubTotal";
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.OptionsColumn.AllowEdit = false;
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 4;
            this.colSubTotal.Width = 102;
            // 
            // colIva
            // 
            this.colIva.Caption = "Iva";
            this.colIva.FieldName = "Iva";
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 5;
            this.colIva.Width = 93;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 101;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colManeja_Iva
            // 
            this.colManeja_Iva.Caption = "Maneja Iva";
            this.colManeja_Iva.FieldName = "Maneja_Iva";
            this.colManeja_Iva.Name = "colManeja_Iva";
            this.colManeja_Iva.Visible = true;
            this.colManeja_Iva.VisibleIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoHeight = false;
            this.txtCodigo.Name = "txtCodigo";
            // 
            // txeSTotal
            // 
            this.txeSTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txeSTotal.Location = new System.Drawing.Point(800, 212);
            this.txeSTotal.Name = "txeSTotal";
            this.txeSTotal.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSTotal.Properties.ReadOnly = true;
            this.txeSTotal.Size = new System.Drawing.Size(145, 20);
            this.txeSTotal.TabIndex = 135;
            // 
            // txeSTotaliva
            // 
            this.txeSTotaliva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txeSTotaliva.Location = new System.Drawing.Point(555, 212);
            this.txeSTotaliva.Name = "txeSTotaliva";
            this.txeSTotaliva.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSTotaliva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSTotaliva.Properties.ReadOnly = true;
            this.txeSTotaliva.Size = new System.Drawing.Size(145, 20);
            this.txeSTotaliva.TabIndex = 134;
            // 
            // txeSsubtotal
            // 
            this.txeSsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txeSsubtotal.Location = new System.Drawing.Point(300, 212);
            this.txeSsubtotal.Name = "txeSsubtotal";
            this.txeSsubtotal.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeSsubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeSsubtotal.Properties.ReadOnly = true;
            this.txeSsubtotal.Size = new System.Drawing.Size(147, 20);
            this.txeSsubtotal.TabIndex = 133;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(225, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 124;
            this.label15.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(473, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 126;
            this.label12.Text = "Total IVA:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(727, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 127;
            this.label13.Text = "TOTAL:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 147);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 136;
            this.labelControl1.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(102, 144);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(792, 56);
            this.txtObservacion.TabIndex = 137;
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.label15);
            this.groupBoxDetalle.Controls.Add(this.gridControlActivoFijo);
            this.groupBoxDetalle.Controls.Add(this.txeSTotaliva);
            this.groupBoxDetalle.Controls.Add(this.txeSTotal);
            this.groupBoxDetalle.Controls.Add(this.label12);
            this.groupBoxDetalle.Controls.Add(this.label13);
            this.groupBoxDetalle.Controls.Add(this.txeSsubtotal);
            this.groupBoxDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetalle.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(965, 238);
            this.groupBoxDetalle.TabIndex = 138;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle";
            // 
            // lblNumTransaccion
            // 
            this.lblNumTransaccion.Location = new System.Drawing.Point(46, 17);
            this.lblNumTransaccion.Name = "lblNumTransaccion";
            this.lblNumTransaccion.Size = new System.Drawing.Size(45, 13);
            this.lblNumTransaccion.TabIndex = 139;
            this.lblNumTransaccion.Text = "# Orden:";
            // 
            // txtId_OrdenSer
            // 
            this.txtId_OrdenSer.Location = new System.Drawing.Point(102, 14);
            this.txtId_OrdenSer.Name = "txtId_OrdenSer";
            this.txtId_OrdenSer.Properties.ReadOnly = true;
            this.txtId_OrdenSer.Size = new System.Drawing.Size(100, 20);
            this.txtId_OrdenSer.TabIndex = 140;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(247, 12);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(117, 20);
            this.lblAnulado.TabIndex = 141;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 476);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(965, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 142;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 26);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(965, 450);
            this.panelMain.TabIndex = 143;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.groupBoxDetalle);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 212);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(965, 238);
            this.panelBody.TabIndex = 143;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblNumTransaccion);
            this.panelTop.Controls.Add(this.lblNoDoc);
            this.panelTop.Controls.Add(this.lblNoFact);
            this.panelTop.Controls.Add(this.lblAnulado);
            this.panelTop.Controls.Add(this.lblFecha);
            this.panelTop.Controls.Add(this.txtNoDoc);
            this.panelTop.Controls.Add(this.txtId_OrdenSer);
            this.panelTop.Controls.Add(this.deFecha);
            this.panelTop.Controls.Add(this.txtNoFact);
            this.panelTop.Controls.Add(this.lblProveedor);
            this.panelTop.Controls.Add(this.labelControl1);
            this.panelTop.Controls.Add(this.ucCon_CentroCosto_ctas_Movi1);
            this.panelTop.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panelTop.Controls.Add(this.lblActivoFijo);
            this.panelTop.Controls.Add(this.lblCentroCosto);
            this.panelTop.Controls.Add(this.txtObservacion);
            this.panelTop.Controls.Add(this.ucaF_Activo_Fijo1);
            this.panelTop.Controls.Add(this.ucCp_Proveedor1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(965, 212);
            this.panelTop.TabIndex = 142;
            // 
            // FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 502);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de servicio por activo fijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSTotaliva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeSsubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId_OrdenSer.Properties)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.LabelControl lblNoDoc;
        private DevExpress.XtraEditors.LabelControl lblNoFact;
        private DevExpress.XtraEditors.TextEdit txtNoDoc;
        private DevExpress.XtraEditors.TextEdit txtNoFact;
        private Controles.UCCon_CentroCosto_ctas_Movi ucCon_CentroCosto_ctas_Movi1;
        private DevExpress.XtraEditors.LabelControl lblCentroCosto;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
        private Controles.UCAF_Activo_Fijo ucaF_Activo_Fijo1;
        private DevExpress.XtraEditors.LabelControl lblActivoFijo;
        private DevExpress.XtraGrid.GridControl gridControlActivoFijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.TextEdit txeSTotal;
        private DevExpress.XtraEditors.TextEdit txeSTotaliva;
        private DevExpress.XtraEditors.TextEdit txeSsubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colManeja_Iva;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private DevExpress.XtraEditors.LabelControl lblNumTransaccion;
        private DevExpress.XtraEditors.TextEdit txtId_OrdenSer;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Producto;
        private DevExpress.XtraGrid.Views.Grid.GridView slueProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCod;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCodigo;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelTop;
    }
}
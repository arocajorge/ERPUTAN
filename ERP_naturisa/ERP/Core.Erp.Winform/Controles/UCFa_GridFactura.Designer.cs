namespace Core.Erp.Winform.Controles
{
    partial class UCFa_GridFactura
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tablapedidodetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoCodigo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.viewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo_Producto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisponibles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto_Promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManeja_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoDescri = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Producto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.preciopublico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costopromedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPorc_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaga_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetallexItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_Dev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPunto_Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Ven0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_VenIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.faproductoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faproductoinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablapedidodetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoDescri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faproductoinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faproductoinfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tablapedidodetInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProductoCodigo,
            this.cmbProductoDescri,
            this.txtCantidad,
            this.repositoryItemTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(1067, 337);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gridControl_PreviewKeyDown);
            // 
            // tablapedidodetInfoBindingSource
            // 
            //this.tablapedidodetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.Tabla_pedido_det_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colCodigo_Producto,
            this.colProducto,
            this.colPeso,
            this.colCantidad,
            this.colPrecio,
            this.colPorc_Descuento,
            this.colDescuento,
            this.colPrecioFinal,
            this.colSubtotal,
            this.colIva,
            this.colTotal,
            this.colPaga_Iva,
            this.colDetallexItems,
            this.colCosto,
            this.colStock,
            this.colCant_Venta,
            this.colCant_Dev,
            this.colchek,
            this.colSecuencia,
            this.colIdPunto_Cargo,
            this.colPrecio_Iva,
            this.gridColumn1,
            this.colIdCtaCble_Ven0,
            this.colIdCtaCble_VenIva});
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupedColumns = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colCodigo_Producto
            // 
            this.colCodigo_Producto.Caption = "Item";
            this.colCodigo_Producto.ColumnEdit = this.cmbProductoCodigo;
            this.colCodigo_Producto.FieldName = "IdProducto";
            this.colCodigo_Producto.Name = "colCodigo_Producto";
            this.colCodigo_Producto.Visible = true;
            this.colCodigo_Producto.VisibleIndex = 0;
            this.colCodigo_Producto.Width = 280;
            // 
            // cmbProductoCodigo
            // 
            this.cmbProductoCodigo.AutoHeight = false;
            this.cmbProductoCodigo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbProductoCodigo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoCodigo.DisplayMember = "pr_descripcion";
            this.cmbProductoCodigo.Name = "cmbProductoCodigo";
            this.cmbProductoCodigo.ValueMember = "IdProducto";
            this.cmbProductoCodigo.View = this.viewProducto;
            // 
            // viewProducto
            // 
            this.viewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo_Producto1,
            this.colProducto1,
            this.colDisponibles,
            this.colStock1,
            this.colPedidos,
            this.colPeso1,
            this.colPrecio_Publico,
            this.colCosto_Promedio,
            this.colManeja_Iva,
            this.colIdProducto1});
            this.viewProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewProducto.Name = "viewProducto";
            this.viewProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewProducto.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo_Producto1
            // 
            this.colCodigo_Producto1.Caption = "codigo";
            this.colCodigo_Producto1.FieldName = "pr_codigo";
            this.colCodigo_Producto1.Name = "colCodigo_Producto1";
            this.colCodigo_Producto1.Visible = true;
            this.colCodigo_Producto1.VisibleIndex = 0;
            this.colCodigo_Producto1.Width = 96;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "Producto";
            this.colProducto1.FieldName = "pr_descripcion";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 1;
            this.colProducto1.Width = 352;
            // 
            // colDisponibles
            // 
            this.colDisponibles.Caption = "Disponibilidad";
            this.colDisponibles.FieldName = "disponible";
            this.colDisponibles.Name = "colDisponibles";
            this.colDisponibles.Visible = true;
            this.colDisponibles.VisibleIndex = 2;
            this.colDisponibles.Width = 90;
            // 
            // colStock1
            // 
            this.colStock1.Caption = "Stock";
            this.colStock1.FieldName = "pr_stock";
            this.colStock1.Name = "colStock1";
            this.colStock1.Visible = true;
            this.colStock1.VisibleIndex = 6;
            this.colStock1.Width = 90;
            // 
            // colPedidos
            // 
            this.colPedidos.Caption = "Pedidos";
            this.colPedidos.FieldName = "pr_pedidos";
            this.colPedidos.Name = "colPedidos";
            this.colPedidos.Visible = true;
            this.colPedidos.VisibleIndex = 3;
            this.colPedidos.Width = 90;
            // 
            // colPeso1
            // 
            this.colPeso1.Caption = "Peso";
            this.colPeso1.FieldName = "pr_peso";
            this.colPeso1.Name = "colPeso1";
            this.colPeso1.Visible = true;
            this.colPeso1.VisibleIndex = 4;
            this.colPeso1.Width = 90;
            // 
            // colPrecio_Publico
            // 
            this.colPrecio_Publico.Caption = "PVP";
            this.colPrecio_Publico.FieldName = "pr_precio_publico";
            this.colPrecio_Publico.Name = "colPrecio_Publico";
            this.colPrecio_Publico.Visible = true;
            this.colPrecio_Publico.VisibleIndex = 5;
            this.colPrecio_Publico.Width = 90;
            // 
            // colCosto_Promedio
            // 
            this.colCosto_Promedio.Caption = "Costo";
            this.colCosto_Promedio.FieldName = "pr_costo_promedio";
            this.colCosto_Promedio.Name = "colCosto_Promedio";
            this.colCosto_Promedio.Width = 90;
            // 
            // colManeja_Iva
            // 
            this.colManeja_Iva.Caption = "Calculo Iva";
            this.colManeja_Iva.FieldName = "pr_ManejaIva";
            this.colManeja_Iva.Name = "colManeja_Iva";
            this.colManeja_Iva.Visible = true;
            this.colManeja_Iva.VisibleIndex = 7;
            this.colManeja_Iva.Width = 90;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.Caption = "IdProducto";
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Visible = true;
            this.colIdProducto1.VisibleIndex = 8;
            this.colIdProducto1.Width = 102;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Item";
            this.colProducto.ColumnEdit = this.cmbProductoDescri;
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Width = 347;
            // 
            // cmbProductoDescri
            // 
            this.cmbProductoDescri.AutoHeight = false;
            this.cmbProductoDescri.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoDescri.DisplayMember = "Producto";
            this.cmbProductoDescri.Name = "cmbProductoDescri";
            this.cmbProductoDescri.ValueMember = "IdProducto";
            this.cmbProductoDescri.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codProducto1,
            this.Producto1,
            this.disponible,
            this.stock,
            this.pedidos,
            this.peso,
            this.preciopublico,
            this.costopromedio,
            this.manejaIva,
            this.colIdProducto2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // codProducto1
            // 
            this.codProducto1.Caption = "codProducto1";
            this.codProducto1.FieldName = "pr_codigo";
            this.codProducto1.Name = "codProducto1";
            this.codProducto1.Visible = true;
            this.codProducto1.VisibleIndex = 0;
            this.codProducto1.Width = 118;
            // 
            // Producto1
            // 
            this.Producto1.Caption = "Producto1";
            this.Producto1.FieldName = "pr_descripcion";
            this.Producto1.Name = "Producto1";
            this.Producto1.Visible = true;
            this.Producto1.VisibleIndex = 1;
            this.Producto1.Width = 385;
            // 
            // disponible
            // 
            this.disponible.Caption = "disponible";
            this.disponible.FieldName = "disponible";
            this.disponible.Name = "disponible";
            this.disponible.Visible = true;
            this.disponible.VisibleIndex = 2;
            this.disponible.Width = 83;
            // 
            // stock
            // 
            this.stock.Caption = "stock";
            this.stock.FieldName = "pr_stock";
            this.stock.Name = "stock";
            this.stock.Visible = true;
            this.stock.VisibleIndex = 3;
            this.stock.Width = 83;
            // 
            // pedidos
            // 
            this.pedidos.Caption = "pedidos";
            this.pedidos.FieldName = "pr_pedidos";
            this.pedidos.Name = "pedidos";
            this.pedidos.Visible = true;
            this.pedidos.VisibleIndex = 4;
            this.pedidos.Width = 83;
            // 
            // peso
            // 
            this.peso.Caption = "peso";
            this.peso.FieldName = "pr_peso";
            this.peso.Name = "peso";
            this.peso.Visible = true;
            this.peso.VisibleIndex = 5;
            this.peso.Width = 83;
            // 
            // preciopublico
            // 
            this.preciopublico.Caption = "preciopublico";
            this.preciopublico.FieldName = "pr_precio_publico";
            this.preciopublico.Name = "preciopublico";
            this.preciopublico.Visible = true;
            this.preciopublico.VisibleIndex = 6;
            this.preciopublico.Width = 83;
            // 
            // costopromedio
            // 
            this.costopromedio.Caption = "costopromedio";
            this.costopromedio.FieldName = "pr_costo_promedio";
            this.costopromedio.Name = "costopromedio";
            this.costopromedio.Visible = true;
            this.costopromedio.VisibleIndex = 7;
            this.costopromedio.Width = 83;
            // 
            // manejaIva
            // 
            this.manejaIva.Caption = "manejaIva";
            this.manejaIva.FieldName = "pr_ManejaIva";
            this.manejaIva.Name = "manejaIva";
            this.manejaIva.Visible = true;
            this.manejaIva.VisibleIndex = 8;
            this.manejaIva.Width = 83;
            // 
            // colIdProducto2
            // 
            this.colIdProducto2.Caption = "IdProducto";
            this.colIdProducto2.FieldName = "IdProducto";
            this.colIdProducto2.Name = "colIdProducto2";
            this.colIdProducto2.Visible = true;
            this.colIdProducto2.VisibleIndex = 9;
            this.colIdProducto2.Width = 96;
            // 
            // colPeso
            // 
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 1;
            this.colPeso.Width = 85;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.ColumnEdit = this.txtCantidad;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 55;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoHeight = false;
            this.txtCantidad.Mask.EditMask = "f";
            this.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidad.Mask.ShowPlaceHolders = false;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 46;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "C";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colPorc_Descuento
            // 
            this.colPorc_Descuento.Caption = "% Desc.";
            this.colPorc_Descuento.FieldName = "Porc_Descuento";
            this.colPorc_Descuento.Name = "colPorc_Descuento";
            this.colPorc_Descuento.Visible = true;
            this.colPorc_Descuento.VisibleIndex = 4;
            this.colPorc_Descuento.Width = 70;
            // 
            // colDescuento
            // 
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 5;
            this.colDescuento.Width = 68;
            // 
            // colPrecioFinal
            // 
            this.colPrecioFinal.FieldName = "PrecioFinal";
            this.colPrecioFinal.Name = "colPrecioFinal";
            this.colPrecioFinal.Visible = true;
            this.colPrecioFinal.VisibleIndex = 6;
            this.colPrecioFinal.Width = 57;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 7;
            this.colSubtotal.Width = 59;
            // 
            // colIva
            // 
            this.colIva.FieldName = "Iva";
            this.colIva.Name = "colIva";
            this.colIva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 8;
            this.colIva.Width = 46;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 34;
            // 
            // colPaga_Iva
            // 
            this.colPaga_Iva.Caption = "  IVA";
            this.colPaga_Iva.FieldName = "Paga_Iva";
            this.colPaga_Iva.Name = "colPaga_Iva";
            this.colPaga_Iva.OptionsColumn.AllowEdit = false;
            this.colPaga_Iva.Visible = true;
            this.colPaga_Iva.VisibleIndex = 11;
            this.colPaga_Iva.Width = 35;
            // 
            // colDetallexItems
            // 
            this.colDetallexItems.FieldName = "DetallexItems";
            this.colDetallexItems.Name = "colDetallexItems";
            this.colDetallexItems.Visible = true;
            this.colDetallexItems.VisibleIndex = 12;
            this.colDetallexItems.Width = 48;
            // 
            // colCosto
            // 
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Width = 40;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 10;
            this.colStock.Width = 39;
            // 
            // colCant_Venta
            // 
            this.colCant_Venta.FieldName = "Cant_Venta";
            this.colCant_Venta.Name = "colCant_Venta";
            // 
            // colCant_Dev
            // 
            this.colCant_Dev.FieldName = "Cant_Dev";
            this.colCant_Dev.Name = "colCant_Dev";
            // 
            // colchek
            // 
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 15;
            this.colSecuencia.Width = 70;
            // 
            // colIdPunto_Cargo
            // 
            this.colIdPunto_Cargo.Caption = "IdPunto_Cargo";
            this.colIdPunto_Cargo.FieldName = "IdPunto_Cargo";
            this.colIdPunto_Cargo.Name = "colIdPunto_Cargo";
            this.colIdPunto_Cargo.Visible = true;
            this.colIdPunto_Cargo.VisibleIndex = 13;
            this.colIdPunto_Cargo.Width = 34;
            // 
            // colPrecio_Iva
            // 
            this.colPrecio_Iva.Caption = "Precio_Iva";
            this.colPrecio_Iva.FieldName = "Precio_Iva";
            this.colPrecio_Iva.Name = "colPrecio_Iva";
            this.colPrecio_Iva.Visible = true;
            this.colPrecio_Iva.VisibleIndex = 14;
            this.colPrecio_Iva.Width = 23;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdEmpresa";
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colIdCtaCble_Ven0
            // 
            this.colIdCtaCble_Ven0.Caption = "IdCtaCble_Ven0";
            this.colIdCtaCble_Ven0.FieldName = "IdCtaCble_Ven0";
            this.colIdCtaCble_Ven0.Name = "colIdCtaCble_Ven0";
            // 
            // colIdCtaCble_VenIva
            // 
            this.colIdCtaCble_VenIva.Caption = "IdCtaCble_VenIva";
            this.colIdCtaCble_VenIva.FieldName = "IdCtaCble_VenIva";
            this.colIdCtaCble_VenIva.Name = "colIdCtaCble_VenIva";
            // 
            // faproductoinfoBindingSource
            // 
            this.faproductoinfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // faproductoinfoBindingSource1
            // 
            this.faproductoinfoBindingSource1.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // UCFa_GridFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "UCFa_GridFactura";
            this.Size = new System.Drawing.Size(1067, 337);
            this.Load += new System.EventHandler(this.GridFacturaDevExpres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablapedidodetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoDescri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faproductoinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faproductoinfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource tablapedidodetInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colPorc_Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPaga_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colDetallexItems;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_Dev;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoCodigo;
        private DevExpress.XtraGrid.Views.Grid.GridView viewProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoDescri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource faproductoinfoBindingSource;
        private System.Windows.Forms.BindingSource faproductoinfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Producto1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colDisponibles;
        private DevExpress.XtraGrid.Columns.GridColumn colStock1;
        private DevExpress.XtraGrid.Columns.GridColumn colPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Publico;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto_Promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colManeja_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn codProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn Producto1;
        private DevExpress.XtraGrid.Columns.GridColumn disponible;
        private DevExpress.XtraGrid.Columns.GridColumn stock;
        private DevExpress.XtraGrid.Columns.GridColumn pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn peso;
        private DevExpress.XtraGrid.Columns.GridColumn preciopublico;
        private DevExpress.XtraGrid.Columns.GridColumn costopromedio;
        private DevExpress.XtraGrid.Columns.GridColumn manejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Ven0;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_VenIva;
    }
}

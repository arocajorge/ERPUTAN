namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Orden_Despacho_Mant
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.gridControlPedido = new DevExpress.XtraGrid.GridControl();
            this.fapedidodetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Checked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DesProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cp_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_pagaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_PorDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_desUni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_detallexItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dp_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Secuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSucBod = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.inProductoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProductoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_mayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_fob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_CIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Inven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CosBaseIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CosBase0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_VenIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Ven0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_DesIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Des0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_DevIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Dev0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_DiasMaritimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_DiasAereo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_DiasTerrestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_largo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_alto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_profundidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_EstaPromocion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_partidaArancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_porcentajeArancel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_imagenPeque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_imagen_Grande = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUndadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadAjustada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdOrdenDespacho = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlOrdenDespacho = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenDesapacho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPRODUCTOs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.od_pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPedidoDES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_tieneIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_PorDescUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_DescUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_PrecioFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_detallexItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.od_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SecuenciaPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtquintales = new DevExpress.XtraEditors.TextEdit();
            this.txtKilos = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbDespacho = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.panelPedidosYProductos = new System.Windows.Forms.Panel();
            this.Cheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RutaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlGuia = new DevExpress.XtraGrid.GridControl();
            this.gridViewGuia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdGuiaRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gi_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ultraComboEditorTransportista = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransportista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPlazo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapedidodetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPedido.SuspendLayout();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenDesapacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquintales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilos.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelPedidosYProductos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorTransportista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCliente
            // 
            this.pnlCliente.Location = new System.Drawing.Point(4, 173);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(468, 82);
            this.pnlCliente.TabIndex = 7;
            // 
            // gridControlPedido
            // 
            this.gridControlPedido.DataSource = this.fapedidodetInfoBindingSource;
            this.gridControlPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPedido.Location = new System.Drawing.Point(3, 3);
            this.gridControlPedido.MainView = this.gridViewPedido;
            this.gridControlPedido.Name = "gridControlPedido";
            this.gridControlPedido.Size = new System.Drawing.Size(483, 189);
            this.gridControlPedido.TabIndex = 1;
            this.gridControlPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPedido});
            // 
            // fapedidodetInfoBindingSource
            // 
            this.fapedidodetInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_pedido_det_Info);
            // 
            // gridViewPedido
            // 
            this.gridViewPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Checked,
            this.DesProduct,
            this.IdPedido,
            this.cp_fecha,
            this.IdProducto,
            this.dp_cantidad,
            this.Referencia,
            this.dp_saldo,
            this.dp_total,
            this.dp_pagaIva,
            this.dp_subtotal,
            this.dp_PorDescuento,
            this.dp_desUni,
            this.dp_detallexItems,
            this.dp_iva,
            this.Secuencial});
            this.gridViewPedido.GridControl = this.gridControlPedido;
            this.gridViewPedido.GroupCount = 1;
            this.gridViewPedido.Name = "gridViewPedido";
            this.gridViewPedido.OptionsBehavior.Editable = false;
            this.gridViewPedido.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPedido.OptionsView.ShowGroupPanel = false;
            this.gridViewPedido.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Referencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPedido.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPedido_RowClick);
            // 
            // Checked
            // 
            this.Checked.Caption = "*";
            this.Checked.FieldName = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.Visible = true;
            this.Checked.VisibleIndex = 0;
            this.Checked.Width = 54;
            // 
            // DesProduct
            // 
            this.DesProduct.Caption = "Producto";
            this.DesProduct.FieldName = "DesProduct";
            this.DesProduct.Name = "DesProduct";
            this.DesProduct.Visible = true;
            this.DesProduct.VisibleIndex = 1;
            this.DesProduct.Width = 353;
            // 
            // IdPedido
            // 
            this.IdPedido.Caption = "IdPedido";
            this.IdPedido.FieldName = "IdPedido";
            this.IdPedido.Name = "IdPedido";
            // 
            // cp_fecha
            // 
            this.cp_fecha.Caption = "cp_fecha";
            this.cp_fecha.FieldName = "cp_fecha";
            this.cp_fecha.Name = "cp_fecha";
            // 
            // IdProducto
            // 
            this.IdProducto.Caption = "IdProducto";
            this.IdProducto.FieldName = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // dp_cantidad
            // 
            this.dp_cantidad.Caption = "Cantidad";
            this.dp_cantidad.FieldName = "dp_cantidad";
            this.dp_cantidad.Name = "dp_cantidad";
            this.dp_cantidad.Visible = true;
            this.dp_cantidad.VisibleIndex = 2;
            this.dp_cantidad.Width = 78;
            // 
            // Referencia
            // 
            this.Referencia.Caption = ".";
            this.Referencia.FieldName = "Referencia";
            this.Referencia.Name = "Referencia";
            // 
            // dp_saldo
            // 
            this.dp_saldo.Caption = "Saldo";
            this.dp_saldo.FieldName = "dp_saldo";
            this.dp_saldo.Name = "dp_saldo";
            this.dp_saldo.Visible = true;
            this.dp_saldo.VisibleIndex = 3;
            // 
            // dp_total
            // 
            this.dp_total.Caption = "dp_total";
            this.dp_total.FieldName = "dp_total";
            this.dp_total.Name = "dp_total";
            // 
            // dp_pagaIva
            // 
            this.dp_pagaIva.Caption = "dp_pagaIva";
            this.dp_pagaIva.FieldName = "dp_pagaIva";
            this.dp_pagaIva.Name = "dp_pagaIva";
            // 
            // dp_subtotal
            // 
            this.dp_subtotal.Caption = "dp_subtotal";
            this.dp_subtotal.FieldName = "dp_subtotal";
            this.dp_subtotal.Name = "dp_subtotal";
            // 
            // dp_PorDescuento
            // 
            this.dp_PorDescuento.Caption = "dp_PorDescuento";
            this.dp_PorDescuento.FieldName = "dp_PorDescuento";
            this.dp_PorDescuento.Name = "dp_PorDescuento";
            // 
            // dp_desUni
            // 
            this.dp_desUni.Caption = "dp_desUni";
            this.dp_desUni.FieldName = "dp_desUni";
            this.dp_desUni.Name = "dp_desUni";
            // 
            // dp_detallexItems
            // 
            this.dp_detallexItems.Caption = "dp_detallexItems";
            this.dp_detallexItems.FieldName = "dp_detallexItems";
            this.dp_detallexItems.Name = "dp_detallexItems";
            // 
            // dp_iva
            // 
            this.dp_iva.Caption = "dp_iva";
            this.dp_iva.FieldName = "dp_iva";
            this.dp_iva.Name = "dp_iva";
            // 
            // Secuencial
            // 
            this.Secuencial.Caption = "Secuencial";
            this.Secuencial.FieldName = "Secuencial";
            this.Secuencial.Name = "Secuencial";
            // 
            // pnlSucBod
            // 
            this.pnlSucBod.Location = new System.Drawing.Point(4, 102);
            this.pnlSucBod.Name = "pnlSucBod";
            this.pnlSucBod.Size = new System.Drawing.Size(468, 66);
            this.pnlSucBod.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPedido);
            this.tabControl.Controls.Add(this.tabProducto);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(497, 221);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPedido
            // 
            this.tabPedido.Controls.Add(this.gridControlPedido);
            this.tabPedido.Location = new System.Drawing.Point(4, 22);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedido.Size = new System.Drawing.Size(489, 195);
            this.tabPedido.TabIndex = 0;
            this.tabPedido.Text = "Pedidos";
            this.tabPedido.UseVisualStyleBackColor = true;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.gridControlProductos);
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(489, 195);
            this.tabProducto.TabIndex = 1;
            this.tabProducto.Text = "Productos";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.DataSource = this.inProductoInfoBindingSource;
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(3, 3);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.Size = new System.Drawing.Size(483, 189);
            this.gridControlProductos.TabIndex = 0;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos,
            this.gridView1});
            // 
            // inProductoInfoBindingSource
            // 
            this.inProductoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdProducto,
            this.colpr_codigo,
            this.colpr_descripcion,
            this.colpr_codigo_barra,
            this.colIdProductoTipo,
            this.colIdPresentacion,
            this.colIdCategoria,
            this.colpr_observacion,
            this.colIdUnidadMedida,
            this.colpr_precio_publico,
            this.colpr_precio_mayor,
            this.colpr_precio_minimo,
            this.colpr_stock,
            this.colpr_pedidos,
            this.colpr_ManejaIva,
            this.colpr_ManejaSeries,
            this.colpr_costo_fob,
            this.colpr_costo_CIF,
            this.colpr_costo_promedio,
            this.colIdCtaCble_Inven,
            this.colIdCtaCble_Vta,
            this.colIdCtaCble_CosBaseIva,
            this.colIdCtaCble_CosBase0,
            this.colIdCtaCble_VenIva,
            this.colIdCtaCble_Ven0,
            this.colIdCtaCble_DesIva,
            this.colIdCtaCble_Des0,
            this.colIdCtaCble_DevIva,
            this.colIdCtaCble_Dev0,
            this.colIdBodega,
            this.colIdSucursal,
            this.colMarca,
            this.colIdProveedor,
            this.colIdMarca,
            this.colpr_DiasMaritimo,
            this.colpr_DiasAereo,
            this.colpr_DiasTerrestre,
            this.colpr_largo,
            this.colpr_alto,
            this.colpr_profundidad,
            this.colpr_peso,
            this.colpr_EstaPromocion,
            this.colpr_partidaArancel,
            this.colpr_porcentajeArancel,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado,
            this.colpr_imagenPeque,
            this.colpr_imagen_Grande,
            this.colRutaPadre,
            this.colBodega,
            this.colSucursal,
            this.colTipo_Producto,
            this.colPresentacion,
            this.colUndadMedida,
            this.colCheked,
            this.colStockFisico,
            this.colCantidadAjustada});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsBehavior.Editable = false;
            this.gridViewProductos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProductos_RowClick);
            this.gridViewProductos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanging);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripcion";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            this.colpr_descripcion.Width = 144;
            // 
            // colpr_codigo_barra
            // 
            this.colpr_codigo_barra.FieldName = "pr_codigo_barra";
            this.colpr_codigo_barra.Name = "colpr_codigo_barra";
            // 
            // colIdProductoTipo
            // 
            this.colIdProductoTipo.FieldName = "IdProductoTipo";
            this.colIdProductoTipo.Name = "colIdProductoTipo";
            // 
            // colIdPresentacion
            // 
            this.colIdPresentacion.FieldName = "IdPresentacion";
            this.colIdPresentacion.Name = "colIdPresentacion";
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.FieldName = "IdCategoria";
            this.colIdCategoria.Name = "colIdCategoria";
            // 
            // colpr_observacion
            // 
            this.colpr_observacion.FieldName = "pr_observacion";
            this.colpr_observacion.Name = "colpr_observacion";
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            // 
            // colpr_precio_mayor
            // 
            this.colpr_precio_mayor.FieldName = "pr_precio_mayor";
            this.colpr_precio_mayor.Name = "colpr_precio_mayor";
            // 
            // colpr_precio_minimo
            // 
            this.colpr_precio_minimo.FieldName = "pr_precio_minimo";
            this.colpr_precio_minimo.Name = "colpr_precio_minimo";
            // 
            // colpr_stock
            // 
            this.colpr_stock.FieldName = "pr_stock";
            this.colpr_stock.Name = "colpr_stock";
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            // 
            // colpr_ManejaSeries
            // 
            this.colpr_ManejaSeries.FieldName = "pr_ManejaSeries";
            this.colpr_ManejaSeries.Name = "colpr_ManejaSeries";
            // 
            // colpr_costo_fob
            // 
            this.colpr_costo_fob.FieldName = "pr_costo_fob";
            this.colpr_costo_fob.Name = "colpr_costo_fob";
            // 
            // colpr_costo_CIF
            // 
            this.colpr_costo_CIF.FieldName = "pr_costo_CIF";
            this.colpr_costo_CIF.Name = "colpr_costo_CIF";
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            // 
            // colIdCtaCble_Inven
            // 
            this.colIdCtaCble_Inven.FieldName = "IdCtaCble_Inven";
            this.colIdCtaCble_Inven.Name = "colIdCtaCble_Inven";
            // 
            // colIdCtaCble_Vta
            // 
            this.colIdCtaCble_Vta.FieldName = "IdCtaCble_Vta";
            this.colIdCtaCble_Vta.Name = "colIdCtaCble_Vta";
            // 
            // colIdCtaCble_CosBaseIva
            // 
            this.colIdCtaCble_CosBaseIva.FieldName = "IdCtaCble_CosBaseIva";
            this.colIdCtaCble_CosBaseIva.Name = "colIdCtaCble_CosBaseIva";
            // 
            // colIdCtaCble_CosBase0
            // 
            this.colIdCtaCble_CosBase0.FieldName = "IdCtaCble_CosBase0";
            this.colIdCtaCble_CosBase0.Name = "colIdCtaCble_CosBase0";
            // 
            // colIdCtaCble_VenIva
            // 
            this.colIdCtaCble_VenIva.FieldName = "IdCtaCble_VenIva";
            this.colIdCtaCble_VenIva.Name = "colIdCtaCble_VenIva";
            // 
            // colIdCtaCble_Ven0
            // 
            this.colIdCtaCble_Ven0.FieldName = "IdCtaCble_Ven0";
            this.colIdCtaCble_Ven0.Name = "colIdCtaCble_Ven0";
            // 
            // colIdCtaCble_DesIva
            // 
            this.colIdCtaCble_DesIva.FieldName = "IdCtaCble_DesIva";
            this.colIdCtaCble_DesIva.Name = "colIdCtaCble_DesIva";
            // 
            // colIdCtaCble_Des0
            // 
            this.colIdCtaCble_Des0.FieldName = "IdCtaCble_Des0";
            this.colIdCtaCble_Des0.Name = "colIdCtaCble_Des0";
            // 
            // colIdCtaCble_DevIva
            // 
            this.colIdCtaCble_DevIva.FieldName = "IdCtaCble_DevIva";
            this.colIdCtaCble_DevIva.Name = "colIdCtaCble_DevIva";
            // 
            // colIdCtaCble_Dev0
            // 
            this.colIdCtaCble_Dev0.FieldName = "IdCtaCble_Dev0";
            this.colIdCtaCble_Dev0.Name = "colIdCtaCble_Dev0";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            this.colMarca.Width = 148;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colIdMarca
            // 
            this.colIdMarca.FieldName = "IdMarca";
            this.colIdMarca.Name = "colIdMarca";
            // 
            // colpr_DiasMaritimo
            // 
            this.colpr_DiasMaritimo.FieldName = "pr_DiasMaritimo";
            this.colpr_DiasMaritimo.Name = "colpr_DiasMaritimo";
            // 
            // colpr_DiasAereo
            // 
            this.colpr_DiasAereo.FieldName = "pr_DiasAereo";
            this.colpr_DiasAereo.Name = "colpr_DiasAereo";
            // 
            // colpr_DiasTerrestre
            // 
            this.colpr_DiasTerrestre.FieldName = "pr_DiasTerrestre";
            this.colpr_DiasTerrestre.Name = "colpr_DiasTerrestre";
            // 
            // colpr_largo
            // 
            this.colpr_largo.FieldName = "pr_largo";
            this.colpr_largo.Name = "colpr_largo";
            // 
            // colpr_alto
            // 
            this.colpr_alto.FieldName = "pr_alto";
            this.colpr_alto.Name = "colpr_alto";
            // 
            // colpr_profundidad
            // 
            this.colpr_profundidad.FieldName = "pr_profundidad";
            this.colpr_profundidad.Name = "colpr_profundidad";
            // 
            // colpr_peso
            // 
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            // 
            // colpr_EstaPromocion
            // 
            this.colpr_EstaPromocion.FieldName = "pr_EstaPromocion";
            this.colpr_EstaPromocion.Name = "colpr_EstaPromocion";
            // 
            // colpr_partidaArancel
            // 
            this.colpr_partidaArancel.FieldName = "pr_partidaArancel";
            this.colpr_partidaArancel.Name = "colpr_partidaArancel";
            // 
            // colpr_porcentajeArancel
            // 
            this.colpr_porcentajeArancel.FieldName = "pr_porcentajeArancel";
            this.colpr_porcentajeArancel.Name = "colpr_porcentajeArancel";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colpr_imagenPeque
            // 
            this.colpr_imagenPeque.FieldName = "pr_imagenPeque";
            this.colpr_imagenPeque.Name = "colpr_imagenPeque";
            // 
            // colpr_imagen_Grande
            // 
            this.colpr_imagen_Grande.FieldName = "pr_imagen_Grande";
            this.colpr_imagen_Grande.Name = "colpr_imagen_Grande";
            // 
            // colRutaPadre
            // 
            this.colRutaPadre.FieldName = "RutaPadre";
            this.colRutaPadre.Name = "colRutaPadre";
            this.colRutaPadre.Visible = true;
            this.colRutaPadre.VisibleIndex = 2;
            this.colRutaPadre.Width = 144;
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            // 
            // colTipo_Producto
            // 
            this.colTipo_Producto.FieldName = "Tipo_Producto";
            this.colTipo_Producto.Name = "colTipo_Producto";
            // 
            // colPresentacion
            // 
            this.colPresentacion.FieldName = "Presentacion";
            this.colPresentacion.Name = "colPresentacion";
            // 
            // colUndadMedida
            // 
            this.colUndadMedida.FieldName = "UndadMedida";
            this.colUndadMedida.Name = "colUndadMedida";
            // 
            // colCheked
            // 
            this.colCheked.Caption = "*";
            this.colCheked.FieldName = "Cheked";
            this.colCheked.Name = "colCheked";
            this.colCheked.Visible = true;
            this.colCheked.VisibleIndex = 0;
            this.colCheked.Width = 29;
            // 
            // colStockFisico
            // 
            this.colStockFisico.FieldName = "StockFisico";
            this.colStockFisico.Name = "colStockFisico";
            // 
            // colCantidadAjustada
            // 
            this.colCantidadAjustada.FieldName = "CantidadAjustada";
            this.colCantidadAjustada.Name = "colCantidadAjustada";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlProductos;
            this.gridView1.Name = "gridView1";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(530, 30);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(82, 20);
            this.dateFecha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "#Orden Despacho:";
            // 
            // txtIdOrdenDespacho
            // 
            this.txtIdOrdenDespacho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIdOrdenDespacho.Location = new System.Drawing.Point(113, 28);
            this.txtIdOrdenDespacho.Name = "txtIdOrdenDespacho";
            this.txtIdOrdenDespacho.ReadOnly = true;
            this.txtIdOrdenDespacho.Size = new System.Drawing.Size(100, 20);
            this.txtIdOrdenDespacho.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlOrdenDespacho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 163);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de orden de despacho";
            // 
            // gridControlOrdenDespacho
            // 
            this.gridControlOrdenDespacho.Location = new System.Drawing.Point(0, 35);
            this.gridControlOrdenDespacho.MainView = this.gridViewOrdenDesapacho;
            this.gridControlOrdenDespacho.Name = "gridControlOrdenDespacho";
            this.gridControlOrdenDespacho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControlOrdenDespacho.Size = new System.Drawing.Size(945, 125);
            this.gridControlOrdenDespacho.TabIndex = 0;
            this.gridControlOrdenDespacho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenDesapacho});
            // 
            // gridViewOrdenDesapacho
            // 
            this.gridViewOrdenDesapacho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPRODUCTOs,
            this.d,
            this.od_pedido,
            this.od_cantidad,
            this.Saldo,
            this.IdPedidoDES,
            this.od_tieneIVA,
            this.od_Subtotal,
            this.od_total,
            this.od_PorDescUnitario,
            this.od_DescUnitario,
            this.od_Precio,
            this.od_PrecioFinal,
            this.od_detallexItems,
            this.od_iva,
            this.SecuenciaPedido});
            this.gridViewOrdenDesapacho.GridControl = this.gridControlOrdenDespacho;
            this.gridViewOrdenDesapacho.Name = "gridViewOrdenDesapacho";
            this.gridViewOrdenDesapacho.OptionsView.ShowGroupPanel = false;
            this.gridViewOrdenDesapacho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOrdenDesapacho_RowClick);
            this.gridViewOrdenDesapacho.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOrdenDesapacho_CellValueChanged);
            this.gridViewOrdenDesapacho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewOrdenDesapacho_KeyDown);
            // 
            // IDPRODUCTOs
            // 
            this.IDPRODUCTOs.Caption = "# Pedido";
            this.IDPRODUCTOs.FieldName = "IdProducto";
            this.IDPRODUCTOs.Name = "IDPRODUCTOs";
            this.IDPRODUCTOs.OptionsColumn.AllowEdit = false;
            this.IDPRODUCTOs.OptionsColumn.ReadOnly = true;
            this.IDPRODUCTOs.Width = 59;
            // 
            // d
            // 
            this.d.Caption = "Producto";
            this.d.ColumnEdit = this.repositoryItemButtonEdit1;
            this.d.FieldName = "pr_descripcion";
            this.d.Name = "d";
            this.d.OptionsColumn.AllowEdit = false;
            this.d.OptionsColumn.ReadOnly = true;
            this.d.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.d.Visible = true;
            this.d.VisibleIndex = 1;
            this.d.Width = 439;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            serializableAppearanceObject1.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            serializableAppearanceObject1.Options.UseImage = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Eliminar", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Core.Erp.Winform.Properties.Resources.eliminar, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)), serializableAppearanceObject1, "", null, null, false)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // od_pedido
            // 
            this.od_pedido.Caption = "Pedido";
            this.od_pedido.FieldName = "od_pedido";
            this.od_pedido.Name = "od_pedido";
            this.od_pedido.OptionsColumn.AllowEdit = false;
            this.od_pedido.Visible = true;
            this.od_pedido.VisibleIndex = 3;
            this.od_pedido.Width = 140;
            // 
            // od_cantidad
            // 
            this.od_cantidad.Caption = "Cantidad";
            this.od_cantidad.FieldName = "od_cantidad";
            this.od_cantidad.Name = "od_cantidad";
            this.od_cantidad.Visible = true;
            this.od_cantidad.VisibleIndex = 2;
            this.od_cantidad.Width = 140;
            // 
            // Saldo
            // 
            this.Saldo.Caption = "Saldo";
            this.Saldo.FieldName = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.OptionsColumn.AllowEdit = false;
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 4;
            this.Saldo.Width = 148;
            // 
            // IdPedidoDES
            // 
            this.IdPedidoDES.Caption = "IdPedido";
            this.IdPedidoDES.FieldName = "IdPedido";
            this.IdPedidoDES.Name = "IdPedidoDES";
            this.IdPedidoDES.Visible = true;
            this.IdPedidoDES.VisibleIndex = 0;
            this.IdPedidoDES.Width = 55;
            // 
            // od_tieneIVA
            // 
            this.od_tieneIVA.Caption = "od_tieneIVA";
            this.od_tieneIVA.FieldName = "od_tieneIVA";
            this.od_tieneIVA.Name = "od_tieneIVA";
            // 
            // od_Subtotal
            // 
            this.od_Subtotal.Caption = "od_Subtotal";
            this.od_Subtotal.FieldName = "od_Subtotal";
            this.od_Subtotal.Name = "od_Subtotal";
            // 
            // od_total
            // 
            this.od_total.Caption = "od_total";
            this.od_total.FieldName = "od_total";
            this.od_total.Name = "od_total";
            // 
            // od_PorDescUnitario
            // 
            this.od_PorDescUnitario.Caption = "od_PorDescUnitario";
            this.od_PorDescUnitario.FieldName = "od_PorDescUnitario";
            this.od_PorDescUnitario.Name = "od_PorDescUnitario";
            // 
            // od_DescUnitario
            // 
            this.od_DescUnitario.Caption = "od_DescUnitario";
            this.od_DescUnitario.FieldName = "od_DescUnitario";
            this.od_DescUnitario.Name = "od_DescUnitario";
            // 
            // od_Precio
            // 
            this.od_Precio.Caption = "od_Precio";
            this.od_Precio.FieldName = "od_Precio";
            this.od_Precio.Name = "od_Precio";
            // 
            // od_PrecioFinal
            // 
            this.od_PrecioFinal.Caption = "od_PrecioFinal";
            this.od_PrecioFinal.FieldName = "od_PrecioFinal";
            this.od_PrecioFinal.Name = "od_PrecioFinal";
            // 
            // od_detallexItems
            // 
            this.od_detallexItems.Caption = "od_detallexItems";
            this.od_detallexItems.FieldName = "od_detallexItems";
            this.od_detallexItems.Name = "od_detallexItems";
            // 
            // od_iva
            // 
            this.od_iva.Caption = "od_iva";
            this.od_iva.FieldName = "od_iva";
            this.od_iva.Name = "od_iva";
            // 
            // SecuenciaPedido
            // 
            this.SecuenciaPedido.Caption = "SecuenciaPedido";
            this.SecuenciaPedido.FieldName = "SecuenciaPedido";
            this.SecuenciaPedido.Name = "SecuenciaPedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtquintales);
            this.groupBox2.Controls.Add(this.txtKilos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales a Despachar";
            // 
            // txtquintales
            // 
            this.txtquintales.Location = new System.Drawing.Point(299, 18);
            this.txtquintales.Name = "txtquintales";
            this.txtquintales.Size = new System.Drawing.Size(100, 20);
            this.txtquintales.TabIndex = 1;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(60, 19);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quintales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kilos";
            // 
            // ckbDespacho
            // 
            this.ckbDespacho.AutoSize = true;
            this.ckbDespacho.Location = new System.Drawing.Point(2, 249);
            this.ckbDespacho.Name = "ckbDespacho";
            this.ckbDespacho.Size = new System.Drawing.Size(111, 17);
            this.ckbDespacho.TabIndex = 8;
            this.ckbDespacho.Text = "Despacho Abierto";
            this.ckbDespacho.UseVisualStyleBackColor = true;
            this.ckbDespacho.CheckedChanged += new System.EventHandler(this.ckbDespacho_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cod. Orden Despacho:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(347, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transportista:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Plazo:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha Entrega";
            this.label8.Visible = false;
            // 
            // dateFechavencimiento
            // 
            this.dateFechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechavencimiento.Location = new System.Drawing.Point(877, 30);
            this.dateFechavencimiento.Name = "dateFechavencimiento";
            this.dateFechavencimiento.Size = new System.Drawing.Size(82, 20);
            this.dateFechavencimiento.TabIndex = 5;
            this.dateFechavencimiento.Visible = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(3, 16);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(940, 59);
            this.txtObservacion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservacion);
            this.groupBox3.Location = new System.Drawing.Point(9, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 78);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observacion";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnulado.Location = new System.Drawing.Point(334, 60);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(320, 24);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "**Orden de Despacho Anulada **";
            this.lblAnulado.Visible = false;
            // 
            // panelPedidosYProductos
            // 
            this.panelPedidosYProductos.Controls.Add(this.tabControl);
            this.panelPedidosYProductos.Location = new System.Drawing.Point(478, 102);
            this.panelPedidosYProductos.Name = "panelPedidosYProductos";
            this.panelPedidosYProductos.Size = new System.Drawing.Size(497, 221);
            this.panelPedidosYProductos.TabIndex = 19;
            this.panelPedidosYProductos.MouseEnter += new System.EventHandler(this.panelPedidosYProductos_MouseEnter);
            // 
            // Cheked
            // 
            this.Cheked.Caption = "*";
            this.Cheked.FieldName = "Cheked";
            this.Cheked.Name = "Cheked";
            this.Cheked.Visible = true;
            this.Cheked.VisibleIndex = 0;
            this.Cheked.Width = 22;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "pr_codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 196;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IdProducto";
            this.gridColumn6.FieldName = "IdProducto";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // pr_descripcion
            // 
            this.pr_descripcion.Caption = "Producto";
            this.pr_descripcion.FieldName = "pr_descripcion";
            this.pr_descripcion.Name = "pr_descripcion";
            this.pr_descripcion.Visible = true;
            this.pr_descripcion.VisibleIndex = 2;
            this.pr_descripcion.Width = 115;
            // 
            // RutaPadre
            // 
            this.RutaPadre.Caption = "Ruta Padre";
            this.RutaPadre.FieldName = "RutaPadre";
            this.RutaPadre.Name = "RutaPadre";
            this.RutaPadre.Visible = true;
            this.RutaPadre.VisibleIndex = 3;
            this.RutaPadre.Width = 120;
            // 
            // pr_precio_publico
            // 
            this.pr_precio_publico.Caption = "pr_precio_publico";
            this.pr_precio_publico.FieldName = "pr_precio_publico";
            this.pr_precio_publico.Name = "pr_precio_publico";
            // 
            // pr_ManejaIva
            // 
            this.pr_ManejaIva.Caption = "pr_ManejaIva";
            this.pr_ManejaIva.FieldName = "pr_ManejaIva";
            this.pr_ManejaIva.Name = "pr_ManejaIva";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 335);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 195);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(3, 3);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(948, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControlGuia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guia de Remision Asociada";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControlGuia
            // 
            this.gridControlGuia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGuia.Location = new System.Drawing.Point(3, 3);
            this.gridControlGuia.MainView = this.gridViewGuia;
            this.gridControlGuia.Name = "gridControlGuia";
            this.gridControlGuia.Size = new System.Drawing.Size(948, 163);
            this.gridControlGuia.TabIndex = 0;
            this.gridControlGuia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGuia});
            // 
            // gridViewGuia
            // 
            this.gridViewGuia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdGuiaRemision,
            this.gi_fecha,
            this.gi_Observacion});
            this.gridViewGuia.GridControl = this.gridControlGuia;
            this.gridViewGuia.Name = "gridViewGuia";
            // 
            // IdGuiaRemision
            // 
            this.IdGuiaRemision.Caption = "Id Guia De Remision";
            this.IdGuiaRemision.FieldName = "IdGuiaRemision";
            this.IdGuiaRemision.Name = "IdGuiaRemision";
            this.IdGuiaRemision.Visible = true;
            this.IdGuiaRemision.VisibleIndex = 0;
            // 
            // gi_fecha
            // 
            this.gi_fecha.Caption = "Fecha";
            this.gi_fecha.FieldName = "gi_fecha";
            this.gi_fecha.Name = "gi_fecha";
            this.gi_fecha.Visible = true;
            this.gi_fecha.VisibleIndex = 1;
            // 
            // gi_Observacion
            // 
            this.gi_Observacion.Caption = "Observacion";
            this.gi_Observacion.FieldName = "gi_Observacion";
            this.gi_Observacion.Name = "gi_Observacion";
            this.gi_Observacion.Visible = true;
            this.gi_Observacion.VisibleIndex = 2;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(975, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            // 
            // ultraComboEditorTransportista
            // 
            this.ultraComboEditorTransportista.Location = new System.Drawing.Point(299, 252);
            this.ultraComboEditorTransportista.Name = "ultraComboEditorTransportista";
            this.ultraComboEditorTransportista.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraComboEditorTransportista.Properties.DisplayMember = "Nombre";
            this.ultraComboEditorTransportista.Properties.ValueMember = "IdTransportista";
            this.ultraComboEditorTransportista.Properties.View = this.searchLookUpEdit1View;
            this.ultraComboEditorTransportista.Size = new System.Drawing.Size(144, 20);
            this.ultraComboEditorTransportista.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransportista,
            this.colNombre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTransportista
            // 
            this.colIdTransportista.Caption = "Id";
            this.colIdTransportista.FieldName = "IdTransportista";
            this.colIdTransportista.Name = "colIdTransportista";
            this.colIdTransportista.Visible = true;
            this.colIdTransportista.VisibleIndex = 0;
            this.colIdTransportista.Width = 72;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 1102;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(655, 30);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 4;
            // 
            // frmFa_Orden_Despacho_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 638);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.ultraComboEditorTransportista);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelPedidosYProductos);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbDespacho);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdOrdenDespacho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFechavencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSucBod);
            this.Controls.Add(this.pnlCliente);
            this.Name = "frmFa_Orden_Despacho_Mant";
            this.Text = "Orden Despacho Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFA_OrdenDespacho_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_OrdenDespacho_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fapedidodetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPedido)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPedido.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenDesapacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquintales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilos.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelPedidosYProductos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGuia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorTransportista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlazo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCliente;
        private DevExpress.XtraGrid.GridControl gridControlPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPedido;
        private System.Windows.Forms.Panel pnlSucBod;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPedido;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdOrdenDespacho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbDespacho;
        private DevExpress.XtraGrid.GridControl gridControlOrdenDespacho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenDesapacho;
        private DevExpress.XtraGrid.Columns.GridColumn IDPRODUCTOs;
        private DevExpress.XtraGrid.Columns.GridColumn d;
        private DevExpress.XtraGrid.Columns.GridColumn od_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn IdPedidoDES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn od_tieneIVA;
        private DevExpress.XtraGrid.Columns.GridColumn od_Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn od_total;
        private DevExpress.XtraGrid.Columns.GridColumn od_PorDescUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn od_DescUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn od_Precio;
        private DevExpress.XtraGrid.Columns.GridColumn od_PrecioFinal;
        private DevExpress.XtraGrid.Columns.GridColumn od_detallexItems;
        private DevExpress.XtraGrid.Columns.GridColumn od_iva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFechavencimiento;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.Columns.GridColumn SecuenciaPedido;
        public System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Panel panelPedidosYProductos;
        private DevExpress.XtraGrid.Columns.GridColumn Secuencial;
        private DevExpress.XtraGrid.Columns.GridColumn dp_iva;
        private DevExpress.XtraGrid.Columns.GridColumn dp_detallexItems;
        private DevExpress.XtraGrid.Columns.GridColumn dp_desUni;
        private DevExpress.XtraGrid.Columns.GridColumn dp_PorDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn dp_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn dp_pagaIva;
        private DevExpress.XtraGrid.Columns.GridColumn dp_total;
        private DevExpress.XtraGrid.Columns.GridColumn dp_saldo;
        private DevExpress.XtraGrid.Columns.GridColumn Referencia;
        private DevExpress.XtraGrid.Columns.GridColumn dp_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn cp_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdPedido;
        private DevExpress.XtraGrid.Columns.GridColumn DesProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Checked;
        private System.Windows.Forms.TabPage tabProducto;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Cheked;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn RutaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn pr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn pr_ManejaIva;
        private System.Windows.Forms.BindingSource inProductoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_mayor;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_minimo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_fob;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_CIF;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Vta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CosBaseIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CosBase0;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_VenIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Ven0;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_DesIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Des0;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_DevIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Dev0;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_DiasMaritimo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_DiasAereo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_DiasTerrestre;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_largo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_alto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_profundidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_EstaPromocion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_partidaArancel;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_porcentajeArancel;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_imagenPeque;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_imagen_Grande;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUndadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colCheked;
        private DevExpress.XtraGrid.Columns.GridColumn colStockFisico;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadAjustada;
        private System.Windows.Forms.BindingSource fapedidodetInfoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn od_pedido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControlGuia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGuia;
        private DevExpress.XtraGrid.Columns.GridColumn IdGuiaRemision;
        private DevExpress.XtraGrid.Columns.GridColumn gi_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn gi_Observacion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.TextEdit txtquintales;
        private DevExpress.XtraEditors.TextEdit txtKilos;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraComboEditorTransportista;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtPlazo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransportista;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}
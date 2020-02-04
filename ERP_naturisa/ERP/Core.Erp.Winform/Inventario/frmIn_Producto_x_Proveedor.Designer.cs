namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_x_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Producto_x_Proveedor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlProducto = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion_ConCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_costoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_costoFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_saldoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_saldoFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_stockActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_TotalIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_TotalEgresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkr_TotalMovimientos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDerechaç = new DevExpress.XtraEditors.SimpleButton();
            this.btnIzquierdaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.btnDerechaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlProductoXPRoveedor = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdXProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pr_codigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductoXPRoveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdXProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.toolStripMain);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbProveedor);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1216, 72);
            this.panelControl1.TabIndex = 70;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_salir,
            this.toolStripTextBox1});
            this.toolStripMain.Location = new System.Drawing.Point(2, 2);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1212, 25);
            this.toolStripMain.TabIndex = 5;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(51, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "KF 26022014 1310";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.labelControl3.Location = new System.Drawing.Point(563, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(190, 15);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Listado de Productos por Proveedor";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.labelControl2.Location = new System.Drawing.Point(2, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 15);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Listado de Productos";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(197, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Proveedores";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Location = new System.Drawing.Point(264, 43);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor.Properties.DisplayMember = "pr_nombre";
            this.cmbProveedor.Properties.ValueMember = "IdProveedor";
            this.cmbProveedor.Properties.View = this.searchLookUpEdit1View;
            this.cmbProveedor.Size = new System.Drawing.Size(277, 20);
            this.cmbProveedor.TabIndex = 0;
            this.cmbProveedor.EditValueChanged += new System.EventHandler(this.cmbProveedor_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pr_nombre,
            this.ruc,
            this.IdProveedor});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // pr_nombre
            // 
            this.pr_nombre.Caption = "Razon Social";
            this.pr_nombre.FieldName = "pr_nombre";
            this.pr_nombre.Name = "pr_nombre";
            this.pr_nombre.Visible = true;
            this.pr_nombre.VisibleIndex = 0;
            // 
            // ruc
            // 
            this.ruc.Caption = "ruc";
            this.ruc.FieldName = "ruc";
            this.ruc.Name = "ruc";
            this.ruc.Visible = true;
            this.ruc.VisibleIndex = 1;
            // 
            // IdProveedor
            // 
            this.IdProveedor.Caption = "IdProveedor";
            this.IdProveedor.FieldName = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.Visible = true;
            this.IdProveedor.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlProducto);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 72);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(477, 355);
            this.panelControl2.TabIndex = 71;
            // 
            // gridControlProducto
            // 
            this.gridControlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducto.Location = new System.Drawing.Point(2, 2);
            this.gridControlProducto.MainView = this.gridViewProducto;
            this.gridControlProducto.Name = "gridControlProducto";
            this.gridControlProducto.Size = new System.Drawing.Size(473, 351);
            this.gridControlProducto.TabIndex = 0;
            this.gridControlProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducto});
            // 
            // gridViewProducto
            // 
            this.gridViewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdProducto,
            this.colpr_codigo,
            this.colpr_descripcion,
            this.colpr_descripcion_ConCodigo,
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
            this.colProducto,
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
            this.colCantidadAjustada,
            this.colca_Categoria,
            this.colkr_costoInicial,
            this.colkr_costoFinal,
            this.colkr_saldoInicial,
            this.colkr_saldoFinal,
            this.colkr_stockActual,
            this.colkr_TotalIngresos,
            this.colkr_TotalEgresos,
            this.colkr_TotalMovimientos,
            this.colCodBarra,
            this.colTipo});
            this.gridViewProducto.GridControl = this.gridControlProducto;
            this.gridViewProducto.Name = "gridViewProducto";
            this.gridViewProducto.OptionsBehavior.Editable = false;
            this.gridViewProducto.OptionsFind.AlwaysVisible = true;
            this.gridViewProducto.OptionsSelection.MultiSelect = true;
            this.gridViewProducto.OptionsView.ShowGroupPanel = false;
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
            this.colpr_codigo.Caption = "Codigo";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            this.colpr_codigo.Width = 20;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Width = 20;
            // 
            // colpr_descripcion_ConCodigo
            // 
            this.colpr_descripcion_ConCodigo.Caption = "Descripción";
            this.colpr_descripcion_ConCodigo.FieldName = "pr_descripcion";
            this.colpr_descripcion_ConCodigo.Name = "colpr_descripcion_ConCodigo";
            this.colpr_descripcion_ConCodigo.Visible = true;
            this.colpr_descripcion_ConCodigo.VisibleIndex = 1;
            this.colpr_descripcion_ConCodigo.Width = 20;
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
            this.colpr_pedidos.Width = 20;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Width = 20;
            // 
            // colpr_ManejaSeries
            // 
            this.colpr_ManejaSeries.FieldName = "pr_ManejaSeries";
            this.colpr_ManejaSeries.Name = "colpr_ManejaSeries";
            this.colpr_ManejaSeries.Width = 20;
            // 
            // colpr_costo_fob
            // 
            this.colpr_costo_fob.FieldName = "pr_costo_fob";
            this.colpr_costo_fob.Name = "colpr_costo_fob";
            this.colpr_costo_fob.Width = 20;
            // 
            // colpr_costo_CIF
            // 
            this.colpr_costo_CIF.FieldName = "pr_costo_CIF";
            this.colpr_costo_CIF.Name = "colpr_costo_CIF";
            this.colpr_costo_CIF.Width = 20;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Width = 20;
            // 
            // colIdCtaCble_Inven
            // 
            this.colIdCtaCble_Inven.FieldName = "IdCtaCble_Inven";
            this.colIdCtaCble_Inven.Name = "colIdCtaCble_Inven";
            this.colIdCtaCble_Inven.Width = 20;
            // 
            // colIdCtaCble_Vta
            // 
            this.colIdCtaCble_Vta.FieldName = "IdCtaCble_Vta";
            this.colIdCtaCble_Vta.Name = "colIdCtaCble_Vta";
            this.colIdCtaCble_Vta.Width = 20;
            // 
            // colIdCtaCble_CosBaseIva
            // 
            this.colIdCtaCble_CosBaseIva.FieldName = "IdCtaCble_CosBaseIva";
            this.colIdCtaCble_CosBaseIva.Name = "colIdCtaCble_CosBaseIva";
            this.colIdCtaCble_CosBaseIva.Width = 21;
            // 
            // colIdCtaCble_CosBase0
            // 
            this.colIdCtaCble_CosBase0.FieldName = "IdCtaCble_CosBase0";
            this.colIdCtaCble_CosBase0.Name = "colIdCtaCble_CosBase0";
            this.colIdCtaCble_CosBase0.Width = 20;
            // 
            // colIdCtaCble_VenIva
            // 
            this.colIdCtaCble_VenIva.FieldName = "IdCtaCble_VenIva";
            this.colIdCtaCble_VenIva.Name = "colIdCtaCble_VenIva";
            this.colIdCtaCble_VenIva.Width = 20;
            // 
            // colIdCtaCble_Ven0
            // 
            this.colIdCtaCble_Ven0.FieldName = "IdCtaCble_Ven0";
            this.colIdCtaCble_Ven0.Name = "colIdCtaCble_Ven0";
            this.colIdCtaCble_Ven0.Width = 20;
            // 
            // colIdCtaCble_DesIva
            // 
            this.colIdCtaCble_DesIva.FieldName = "IdCtaCble_DesIva";
            this.colIdCtaCble_DesIva.Name = "colIdCtaCble_DesIva";
            this.colIdCtaCble_DesIva.Width = 20;
            // 
            // colIdCtaCble_Des0
            // 
            this.colIdCtaCble_Des0.FieldName = "IdCtaCble_Des0";
            this.colIdCtaCble_Des0.Name = "colIdCtaCble_Des0";
            this.colIdCtaCble_Des0.Width = 20;
            // 
            // colIdCtaCble_DevIva
            // 
            this.colIdCtaCble_DevIva.FieldName = "IdCtaCble_DevIva";
            this.colIdCtaCble_DevIva.Name = "colIdCtaCble_DevIva";
            this.colIdCtaCble_DevIva.Width = 20;
            // 
            // colIdCtaCble_Dev0
            // 
            this.colIdCtaCble_Dev0.FieldName = "IdCtaCble_Dev0";
            this.colIdCtaCble_Dev0.Name = "colIdCtaCble_Dev0";
            this.colIdCtaCble_Dev0.Width = 20;
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Width = 20;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 20;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 2;
            this.colMarca.Width = 20;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Width = 20;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.Width = 20;
            // 
            // colIdMarca
            // 
            this.colIdMarca.FieldName = "IdMarca";
            this.colIdMarca.Name = "colIdMarca";
            this.colIdMarca.Width = 20;
            // 
            // colpr_DiasMaritimo
            // 
            this.colpr_DiasMaritimo.FieldName = "pr_DiasMaritimo";
            this.colpr_DiasMaritimo.Name = "colpr_DiasMaritimo";
            this.colpr_DiasMaritimo.Width = 20;
            // 
            // colpr_DiasAereo
            // 
            this.colpr_DiasAereo.FieldName = "pr_DiasAereo";
            this.colpr_DiasAereo.Name = "colpr_DiasAereo";
            this.colpr_DiasAereo.Width = 20;
            // 
            // colpr_DiasTerrestre
            // 
            this.colpr_DiasTerrestre.FieldName = "pr_DiasTerrestre";
            this.colpr_DiasTerrestre.Name = "colpr_DiasTerrestre";
            this.colpr_DiasTerrestre.Width = 20;
            // 
            // colpr_largo
            // 
            this.colpr_largo.FieldName = "pr_largo";
            this.colpr_largo.Name = "colpr_largo";
            this.colpr_largo.Width = 20;
            // 
            // colpr_alto
            // 
            this.colpr_alto.FieldName = "pr_alto";
            this.colpr_alto.Name = "colpr_alto";
            this.colpr_alto.Width = 20;
            // 
            // colpr_profundidad
            // 
            this.colpr_profundidad.FieldName = "pr_profundidad";
            this.colpr_profundidad.Name = "colpr_profundidad";
            this.colpr_profundidad.Width = 20;
            // 
            // colpr_peso
            // 
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Width = 20;
            // 
            // colpr_EstaPromocion
            // 
            this.colpr_EstaPromocion.FieldName = "pr_EstaPromocion";
            this.colpr_EstaPromocion.Name = "colpr_EstaPromocion";
            this.colpr_EstaPromocion.Width = 20;
            // 
            // colpr_partidaArancel
            // 
            this.colpr_partidaArancel.FieldName = "pr_partidaArancel";
            this.colpr_partidaArancel.Name = "colpr_partidaArancel";
            this.colpr_partidaArancel.Width = 20;
            // 
            // colpr_porcentajeArancel
            // 
            this.colpr_porcentajeArancel.FieldName = "pr_porcentajeArancel";
            this.colpr_porcentajeArancel.Name = "colpr_porcentajeArancel";
            this.colpr_porcentajeArancel.Width = 20;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 20;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 20;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.Width = 20;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.Width = 20;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Width = 20;
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            this.colFecha_UltAnu.Width = 20;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.Width = 23;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Width = 20;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 20;
            // 
            // colpr_imagenPeque
            // 
            this.colpr_imagenPeque.FieldName = "pr_imagenPeque";
            this.colpr_imagenPeque.Name = "colpr_imagenPeque";
            this.colpr_imagenPeque.Width = 20;
            // 
            // colpr_imagen_Grande
            // 
            this.colpr_imagen_Grande.FieldName = "pr_imagen_Grande";
            this.colpr_imagen_Grande.Name = "colpr_imagen_Grande";
            this.colpr_imagen_Grande.Width = 20;
            // 
            // colRutaPadre
            // 
            this.colRutaPadre.FieldName = "RutaPadre";
            this.colRutaPadre.Name = "colRutaPadre";
            this.colRutaPadre.Width = 20;
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Width = 20;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Width = 20;
            // 
            // colTipo_Producto
            // 
            this.colTipo_Producto.FieldName = "Tipo_Producto";
            this.colTipo_Producto.Name = "colTipo_Producto";
            this.colTipo_Producto.Width = 20;
            // 
            // colPresentacion
            // 
            this.colPresentacion.FieldName = "Presentacion";
            this.colPresentacion.Name = "colPresentacion";
            this.colPresentacion.Width = 20;
            // 
            // colUndadMedida
            // 
            this.colUndadMedida.FieldName = "UndadMedida";
            this.colUndadMedida.Name = "colUndadMedida";
            this.colUndadMedida.Width = 20;
            // 
            // colCheked
            // 
            this.colCheked.FieldName = "Cheked";
            this.colCheked.Name = "colCheked";
            this.colCheked.Width = 20;
            // 
            // colStockFisico
            // 
            this.colStockFisico.FieldName = "StockFisico";
            this.colStockFisico.Name = "colStockFisico";
            this.colStockFisico.Width = 20;
            // 
            // colCantidadAjustada
            // 
            this.colCantidadAjustada.FieldName = "CantidadAjustada";
            this.colCantidadAjustada.Name = "colCantidadAjustada";
            this.colCantidadAjustada.Width = 20;
            // 
            // colca_Categoria
            // 
            this.colca_Categoria.Caption = "Categoria";
            this.colca_Categoria.FieldName = "ca_Categoria";
            this.colca_Categoria.Name = "colca_Categoria";
            this.colca_Categoria.Visible = true;
            this.colca_Categoria.VisibleIndex = 3;
            this.colca_Categoria.Width = 20;
            // 
            // colkr_costoInicial
            // 
            this.colkr_costoInicial.FieldName = "kr_costoInicial";
            this.colkr_costoInicial.Name = "colkr_costoInicial";
            this.colkr_costoInicial.Width = 20;
            // 
            // colkr_costoFinal
            // 
            this.colkr_costoFinal.FieldName = "kr_costoFinal";
            this.colkr_costoFinal.Name = "colkr_costoFinal";
            this.colkr_costoFinal.Width = 20;
            // 
            // colkr_saldoInicial
            // 
            this.colkr_saldoInicial.FieldName = "kr_saldoInicial";
            this.colkr_saldoInicial.Name = "colkr_saldoInicial";
            this.colkr_saldoInicial.Width = 20;
            // 
            // colkr_saldoFinal
            // 
            this.colkr_saldoFinal.FieldName = "kr_saldoFinal";
            this.colkr_saldoFinal.Name = "colkr_saldoFinal";
            this.colkr_saldoFinal.Width = 20;
            // 
            // colkr_stockActual
            // 
            this.colkr_stockActual.FieldName = "kr_stockActual";
            this.colkr_stockActual.Name = "colkr_stockActual";
            this.colkr_stockActual.Width = 20;
            // 
            // colkr_TotalIngresos
            // 
            this.colkr_TotalIngresos.FieldName = "kr_TotalIngresos";
            this.colkr_TotalIngresos.Name = "colkr_TotalIngresos";
            this.colkr_TotalIngresos.Width = 20;
            // 
            // colkr_TotalEgresos
            // 
            this.colkr_TotalEgresos.FieldName = "kr_TotalEgresos";
            this.colkr_TotalEgresos.Name = "colkr_TotalEgresos";
            this.colkr_TotalEgresos.Width = 20;
            // 
            // colkr_TotalMovimientos
            // 
            this.colkr_TotalMovimientos.FieldName = "kr_TotalMovimientos";
            this.colkr_TotalMovimientos.Name = "colkr_TotalMovimientos";
            this.colkr_TotalMovimientos.Width = 20;
            // 
            // colCodBarra
            // 
            this.colCodBarra.FieldName = "CodBarra";
            this.colCodBarra.Name = "colCodBarra";
            this.colCodBarra.Width = 20;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 20;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnDerechaç);
            this.panelControl3.Controls.Add(this.btnIzquierdaTodos);
            this.panelControl3.Controls.Add(this.btnIzquierda);
            this.panelControl3.Controls.Add(this.btnDerechaTodos);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(477, 72);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(84, 355);
            this.panelControl3.TabIndex = 72;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // btnDerechaç
            // 
            this.btnDerechaç.Location = new System.Drawing.Point(5, 128);
            this.btnDerechaç.Name = "btnDerechaç";
            this.btnDerechaç.Size = new System.Drawing.Size(75, 23);
            this.btnDerechaç.TabIndex = 73;
            this.btnDerechaç.Text = ">";
            this.btnDerechaç.Click += new System.EventHandler(this.btnDerechaç_Click);
            // 
            // btnIzquierdaTodos
            // 
            this.btnIzquierdaTodos.Location = new System.Drawing.Point(5, 207);
            this.btnIzquierdaTodos.Name = "btnIzquierdaTodos";
            this.btnIzquierdaTodos.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierdaTodos.TabIndex = 73;
            this.btnIzquierdaTodos.Text = "<<";
            this.btnIzquierdaTodos.Click += new System.EventHandler(this.btnIzquierdaTodos_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(5, 245);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 73;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerechaTodos
            // 
            this.btnDerechaTodos.Location = new System.Drawing.Point(5, 166);
            this.btnDerechaTodos.Name = "btnDerechaTodos";
            this.btnDerechaTodos.Size = new System.Drawing.Size(75, 23);
            this.btnDerechaTodos.TabIndex = 73;
            this.btnDerechaTodos.Text = ">>";
            this.btnDerechaTodos.Click += new System.EventHandler(this.btnDerechaTodos_Click);
            // 
            // gridControlProductoXPRoveedor
            // 
            this.gridControlProductoXPRoveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductoXPRoveedor.Location = new System.Drawing.Point(2, 2);
            this.gridControlProductoXPRoveedor.MainView = this.gridViewProdXProveedor;
            this.gridControlProductoXPRoveedor.Name = "gridControlProductoXPRoveedor";
            this.gridControlProductoXPRoveedor.Size = new System.Drawing.Size(651, 351);
            this.gridControlProductoXPRoveedor.TabIndex = 0;
            this.gridControlProductoXPRoveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdXProveedor});
            // 
            // gridViewProdXProveedor
            // 
            this.gridViewProdXProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pr_codigo1,
            this.pr_descripcion1,
            this.Marca,
            this.ca_Categoria,
            this.gridColumn1});
            this.gridViewProdXProveedor.GridControl = this.gridControlProductoXPRoveedor;
            this.gridViewProdXProveedor.Name = "gridViewProdXProveedor";
            this.gridViewProdXProveedor.OptionsFind.AlwaysVisible = true;
            this.gridViewProdXProveedor.OptionsView.ShowGroupPanel = false;
            this.gridViewProdXProveedor.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProdXProveedor_FocusedRowChanged);
            // 
            // pr_codigo1
            // 
            this.pr_codigo1.Caption = "Codigo";
            this.pr_codigo1.FieldName = "pr_codigo";
            this.pr_codigo1.Name = "pr_codigo1";
            this.pr_codigo1.OptionsColumn.AllowEdit = false;
            this.pr_codigo1.Visible = true;
            this.pr_codigo1.VisibleIndex = 0;
            this.pr_codigo1.Width = 80;
            // 
            // pr_descripcion1
            // 
            this.pr_descripcion1.Caption = "Descripción";
            this.pr_descripcion1.FieldName = "pr_descripcion";
            this.pr_descripcion1.Name = "pr_descripcion1";
            this.pr_descripcion1.OptionsColumn.AllowEdit = false;
            this.pr_descripcion1.Visible = true;
            this.pr_descripcion1.VisibleIndex = 1;
            this.pr_descripcion1.Width = 139;
            // 
            // Marca
            // 
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.OptionsColumn.AllowEdit = false;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 3;
            this.Marca.Width = 136;
            // 
            // ca_Categoria
            // 
            this.ca_Categoria.Caption = "Categoria";
            this.ca_Categoria.FieldName = "ca_Categoria";
            this.ca_Categoria.Name = "ca_Categoria";
            this.ca_Categoria.OptionsColumn.AllowEdit = false;
            this.ca_Categoria.Visible = true;
            this.ca_Categoria.VisibleIndex = 4;
            this.ca_Categoria.Width = 132;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Desc. en el Proveedor";
            this.gridColumn1.FieldName = "Producto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 202;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControlProductoXPRoveedor);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(561, 72);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(655, 355);
            this.panelControl4.TabIndex = 74;
            // 
            // FrmIn_Producto_x_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 427);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmIn_Producto_x_Proveedor";
            this.Text = "Producto por Proveedores";
            this.Load += new System.EventHandler(this.FrmIn_Producto_x_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductoXPRoveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdXProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducto;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControlProductoXPRoveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdXProveedor;
        private DevExpress.XtraEditors.SimpleButton btnDerechaç;
        private DevExpress.XtraEditors.SimpleButton btnDerechaTodos;
        private DevExpress.XtraEditors.SimpleButton btnIzquierdaTodos;
        private DevExpress.XtraEditors.SimpleButton btnIzquierda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn pr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn ruc;
        private DevExpress.XtraGrid.Columns.GridColumn IdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion_ConCodigo;
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
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
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
        private DevExpress.XtraGrid.Columns.GridColumn colca_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_costoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_costoFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_saldoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_saldoFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_stockActual;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_TotalIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_TotalEgresos;
        private DevExpress.XtraGrid.Columns.GridColumn colkr_TotalMovimientos;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn pr_codigo1;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn ca_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}
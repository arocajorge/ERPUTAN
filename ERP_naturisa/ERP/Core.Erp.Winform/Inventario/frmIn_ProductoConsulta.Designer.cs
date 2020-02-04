namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_ProductoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_ProductoConsulta));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProducto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pr_codigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pr_descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pr_precio_publico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pr_precio_mayor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("pr_precio_minimo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresa");
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.mnuNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_anular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.colNomProducto_en_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock_maximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock_minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UlGridProducto = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDataSource2 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.toolStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlGridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.toolStripSeparator1,
            this.mnu_Modificar,
            this.toolStripSeparator2,
            this.mnu_consultar,
            this.toolStripSeparator3,
            this.mnu_anular,
            this.toolStripSeparator4,
            this.mnu_salir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(949, 25);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Image = ((System.Drawing.Image)(resources.GetObject("mnuNuevo.Image")));
            this.mnuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.Size = new System.Drawing.Size(62, 22);
            this.mnuNuevo.Text = "Nuevo";
            this.mnuNuevo.Click += new System.EventHandler(this.mnuNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_Modificar
            // 
            this.mnu_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("mnu_Modificar.Image")));
            this.mnu_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_Modificar.Name = "mnu_Modificar";
            this.mnu_Modificar.Size = new System.Drawing.Size(78, 22);
            this.mnu_Modificar.Text = "Modificar";
            this.mnu_Modificar.Click += new System.EventHandler(this.mnu_Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_consultar
            // 
            this.mnu_consultar.Image = ((System.Drawing.Image)(resources.GetObject("mnu_consultar.Image")));
            this.mnu_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_consultar.Name = "mnu_consultar";
            this.mnu_consultar.Size = new System.Drawing.Size(78, 22);
            this.mnu_consultar.Text = "Consultar";
            this.mnu_consultar.Click += new System.EventHandler(this.mnu_consultar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_anular
            // 
            this.mnu_anular.Image = ((System.Drawing.Image)(resources.GetObject("mnu_anular.Image")));
            this.mnu_anular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_anular.Name = "mnu_anular";
            this.mnu_anular.Size = new System.Drawing.Size(62, 22);
            this.mnu_anular.Text = "Anular";
            this.mnu_anular.Click += new System.EventHandler(this.mnu_anular_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlProducto);
            this.panel1.Controls.Add(this.UlGridProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 383);
            this.panel1.TabIndex = 6;
            // 
            // gridControlProducto
            // 
            this.gridControlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducto.Location = new System.Drawing.Point(0, 0);
            this.gridControlProducto.MainView = this.gridViewProducto;
            this.gridControlProducto.Name = "gridControlProducto";
            this.gridControlProducto.Size = new System.Drawing.Size(949, 383);
            this.gridControlProducto.TabIndex = 14;
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
            this.colNomProducto_en_Proveedor,
            this.colTipo,
            this.colpr_stock_maximo,
            this.colpr_stock_minimo});
            this.gridViewProducto.GridControl = this.gridControlProducto;
            this.gridViewProducto.Name = "gridViewProducto";
            this.gridViewProducto.OptionsBehavior.Editable = false;
            this.gridViewProducto.OptionsFind.AlwaysVisible = true;
            this.gridViewProducto.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducto.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpr_ManejaSeries, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewProducto.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProducto_RowCellStyle);
            this.gridViewProducto.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProducto_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 20;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Id";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 20;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 1;
            this.colpr_codigo.Width = 20;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 2;
            this.colpr_descripcion.Width = 20;
            // 
            // colpr_descripcion_ConCodigo
            // 
            this.colpr_descripcion_ConCodigo.FieldName = "pr_descripcion_ConCodigo";
            this.colpr_descripcion_ConCodigo.Name = "colpr_descripcion_ConCodigo";
            this.colpr_descripcion_ConCodigo.Width = 20;
            // 
            // colpr_codigo_barra
            // 
            this.colpr_codigo_barra.FieldName = "pr_codigo_barra";
            this.colpr_codigo_barra.Name = "colpr_codigo_barra";
            this.colpr_codigo_barra.Width = 20;
            // 
            // colIdProductoTipo
            // 
            this.colIdProductoTipo.FieldName = "IdProductoTipo";
            this.colIdProductoTipo.Name = "colIdProductoTipo";
            this.colIdProductoTipo.Width = 20;
            // 
            // colIdPresentacion
            // 
            this.colIdPresentacion.FieldName = "IdPresentacion";
            this.colIdPresentacion.Name = "colIdPresentacion";
            this.colIdPresentacion.Width = 20;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.FieldName = "IdCategoria";
            this.colIdCategoria.Name = "colIdCategoria";
            this.colIdCategoria.Width = 20;
            // 
            // colpr_observacion
            // 
            this.colpr_observacion.Caption = "Observación";
            this.colpr_observacion.FieldName = "pr_observacion";
            this.colpr_observacion.Name = "colpr_observacion";
            this.colpr_observacion.Visible = true;
            this.colpr_observacion.VisibleIndex = 8;
            this.colpr_observacion.Width = 20;
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Width = 20;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "Precio Público";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 6;
            this.colpr_precio_publico.Width = 20;
            // 
            // colpr_precio_mayor
            // 
            this.colpr_precio_mayor.FieldName = "pr_precio_mayor";
            this.colpr_precio_mayor.Name = "colpr_precio_mayor";
            this.colpr_precio_mayor.Width = 20;
            // 
            // colpr_precio_minimo
            // 
            this.colpr_precio_minimo.FieldName = "pr_precio_minimo";
            this.colpr_precio_minimo.Name = "colpr_precio_minimo";
            this.colpr_precio_minimo.Width = 20;
            // 
            // colpr_stock
            // 
            this.colpr_stock.FieldName = "pr_stock";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Width = 20;
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
            this.colpr_costo_promedio.Caption = "Costo Promedio";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 7;
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
            this.colIdCtaCble_CosBaseIva.Width = 20;
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
            this.colIdSucursal.Width = 90;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 5;
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
            this.colnom_pc.Width = 20;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Width = 20;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
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
            this.colTipo_Producto.Caption = "Tipo Producto";
            this.colTipo_Producto.FieldName = "Tipo_Producto";
            this.colTipo_Producto.Name = "colTipo_Producto";
            this.colTipo_Producto.Visible = true;
            this.colTipo_Producto.VisibleIndex = 3;
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
            this.colca_Categoria.VisibleIndex = 4;
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
            // colNomProducto_en_Proveedor
            // 
            this.colNomProducto_en_Proveedor.FieldName = "NomProducto_en_Proveedor";
            this.colNomProducto_en_Proveedor.Name = "colNomProducto_en_Proveedor";
            this.colNomProducto_en_Proveedor.Width = 20;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 20;
            // 
            // colpr_stock_maximo
            // 
            this.colpr_stock_maximo.FieldName = "pr_stock_maximo";
            this.colpr_stock_maximo.Name = "colpr_stock_maximo";
            this.colpr_stock_maximo.Width = 20;
            // 
            // colpr_stock_minimo
            // 
            this.colpr_stock_minimo.FieldName = "pr_stock_minimo";
            this.colpr_stock_minimo.Name = "colpr_stock_minimo";
            this.colpr_stock_minimo.Width = 20;
            // 
            // UlGridProducto
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UlGridProducto.DisplayLayout.Appearance = appearance1;
            ultraGridColumn8.Header.VisiblePosition = 0;
            ultraGridColumn8.Width = 47;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn9.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            ultraGridColumn9.Header.Caption = "Codigo";
            ultraGridColumn9.Header.VisiblePosition = 1;
            ultraGridColumn9.Width = 131;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn10.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            ultraGridColumn10.Header.Caption = "Producto";
            ultraGridColumn10.Header.VisiblePosition = 3;
            ultraGridColumn10.Width = 387;
            ultraGridColumn11.Header.Caption = "Categoria";
            ultraGridColumn11.Header.VisiblePosition = 2;
            ultraGridColumn11.Width = 28;
            ultraGridColumn12.Header.Caption = "PVP";
            ultraGridColumn12.Header.VisiblePosition = 4;
            ultraGridColumn13.Header.Caption = "PVP Mayor";
            ultraGridColumn13.Header.VisiblePosition = 5;
            ultraGridColumn14.Header.Caption = "PVP minimo";
            ultraGridColumn14.Header.VisiblePosition = 6;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            this.UlGridProducto.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UlGridProducto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UlGridProducto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.UlGridProducto.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UlGridProducto.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.UlGridProducto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UlGridProducto.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.UlGridProducto.DisplayLayout.MaxColScrollRegions = 1;
            this.UlGridProducto.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UlGridProducto.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UlGridProducto.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.UlGridProducto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UlGridProducto.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.UlGridProducto.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UlGridProducto.DisplayLayout.Override.CellAppearance = appearance8;
            this.UlGridProducto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UlGridProducto.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.UlGridProducto.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.UlGridProducto.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.UlGridProducto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UlGridProducto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.UlGridProducto.DisplayLayout.Override.RowAppearance = appearance11;
            this.UlGridProducto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UlGridProducto.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.UlGridProducto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UlGridProducto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UlGridProducto.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UlGridProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UlGridProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlGridProducto.Location = new System.Drawing.Point(0, 0);
            this.UlGridProducto.Name = "UlGridProducto";
            this.UlGridProducto.Size = new System.Drawing.Size(949, 383);
            this.UlGridProducto.TabIndex = 0;
            this.UlGridProducto.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.UlGridProducto_InitializeLayout);
            this.UlGridProducto.BeforeRowActivate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.UlGridProducto_BeforeRowActivate);
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1});
            // 
            // frmIn_ProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "frmIn_ProductoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Productos";
            this.Load += new System.EventHandler(this.frmIn_ProductoConsulta_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlGridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton mnuNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnu_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnu_consultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mnu_anular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid UlGridProducto;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource2;
        private DevExpress.XtraGrid.GridControl gridControlProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducto;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto_en_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock_maximo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock_minimo;

    }
}
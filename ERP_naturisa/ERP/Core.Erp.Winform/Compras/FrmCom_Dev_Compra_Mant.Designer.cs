namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Dev_Compra_Mant
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
            this.ucGe_Menu_Superior = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel_main = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ucCp_Proveedor1 = new Core.Erp.Winform.Controles.UCCp_Proveedor();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImportar = new DevExpress.XtraEditors.SimpleButton();
            this.chkdevolver_total_vta = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new DevExpress.XtraEditors.TextEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblobservacion = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txt_num_dev_compra = new System.Windows.Forms.TextBox();
            this.lblNum_dev = new System.Windows.Forms.Label();
            this.xtraTabControl_main = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_producto = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_productos = new DevExpress.XtraGrid.GridControl();
            this.gridView_productos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_a_devolver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_devuelta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo_x_devolver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorc_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaga_Iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Esta_en_base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant_pedida_x_OC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colocdet_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ocdet_IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ocdet_IdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ocdet_Secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_producto_cod = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkdevolver_total_vta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_main)).BeginInit();
            this.xtraTabControl_main.SuspendLayout();
            this.xtraTabPage_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_cod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior
            // 
            this.ucGe_Menu_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior.Name = "ucGe_Menu_Superior";
            this.ucGe_Menu_Superior.Size = new System.Drawing.Size(908, 27);
            this.ucGe_Menu_Superior.TabIndex = 0;
            this.ucGe_Menu_Superior.Visible_bntAnular = true;
            this.ucGe_Menu_Superior.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior.Visible_bntSalir = true;
            this.ucGe_Menu_Superior.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior.Visible_btnproductos = false;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 507);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(908, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.splitContainerMain);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 27);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(908, 480);
            this.panel_main.TabIndex = 2;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelControl1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerMain.Size = new System.Drawing.Size(908, 480);
            this.splitContainerMain.SplitterDistance = 208;
            this.splitContainerMain.TabIndex = 0;
            // 
            // ucCp_Proveedor1
            // 
            this.ucCp_Proveedor1.Location = new System.Drawing.Point(60, 99);
            this.ucCp_Proveedor1.Name = "ucCp_Proveedor1";
            this.ucCp_Proveedor1.Size = new System.Drawing.Size(412, 32);
            this.ucCp_Proveedor1.TabIndex = 36;
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(4, 42);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(467, 51);
            this.ucIn_Sucursal_Bodega.TabIndex = 1;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImportar);
            this.groupBox3.Controls.Add(this.chkdevolver_total_vta);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtOrdenCompra);
            this.groupBox3.Location = new System.Drawing.Point(507, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 91);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Datos de compra ";
            // 
            // btnImportar
            // 
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btnImportar.Location = new System.Drawing.Point(252, 14);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(104, 35);
            this.btnImportar.TabIndex = 31;
            this.btnImportar.Text = "Importar OC";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click_1);
            // 
            // chkdevolver_total_vta
            // 
            this.chkdevolver_total_vta.Location = new System.Drawing.Point(207, 52);
            this.chkdevolver_total_vta.Name = "chkdevolver_total_vta";
            this.chkdevolver_total_vta.Properties.Caption = "Devolver toda la compra";
            this.chkdevolver_total_vta.Size = new System.Drawing.Size(149, 19);
            this.chkdevolver_total_vta.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "#Orden de Compra:";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Enabled = false;
            this.txtOrdenCompra.Location = new System.Drawing.Point(143, 26);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Properties.Mask.EditMask = "\\d{0,10}";
            this.txtOrdenCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtOrdenCompra.Size = new System.Drawing.Size(103, 20);
            this.txtOrdenCompra.TabIndex = 0;
            this.txtOrdenCompra.Tag = "F";
            this.txtOrdenCompra.ToolTip = "Ingrese todos los digitos de la Factura Incluyendo \r\nlos Ceros...";
            this.txtOrdenCompra.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(375, 14);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 9;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.Location = new System.Drawing.Point(4, 107);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(59, 13);
            this.lblproveedor.TabIndex = 7;
            this.lblproveedor.Text = "Proveedor:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(80, 134);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(794, 52);
            this.txtObservacion.TabIndex = 3;
            // 
            // lblobservacion
            // 
            this.lblobservacion.AutoSize = true;
            this.lblobservacion.Location = new System.Drawing.Point(4, 163);
            this.lblobservacion.Name = "lblobservacion";
            this.lblobservacion.Size = new System.Drawing.Size(70, 13);
            this.lblobservacion.TabIndex = 5;
            this.lblobservacion.Text = "Observacion:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(713, 14);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(40, 13);
            this.lblfecha.TabIndex = 4;
            this.lblfecha.Text = "Fecha:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(770, 11);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(104, 20);
            this.dtpfecha.TabIndex = 4;
            // 
            // txt_num_dev_compra
            // 
            this.txt_num_dev_compra.Location = new System.Drawing.Point(120, 16);
            this.txt_num_dev_compra.Name = "txt_num_dev_compra";
            this.txt_num_dev_compra.Size = new System.Drawing.Size(122, 20);
            this.txt_num_dev_compra.TabIndex = 0;
            // 
            // lblNum_dev
            // 
            this.lblNum_dev.AutoSize = true;
            this.lblNum_dev.Location = new System.Drawing.Point(4, 18);
            this.lblNum_dev.Name = "lblNum_dev";
            this.lblNum_dev.Size = new System.Drawing.Size(110, 13);
            this.lblNum_dev.TabIndex = 1;
            this.lblNum_dev.Text = "#Devolucion Compra:";
            // 
            // xtraTabControl_main
            // 
            this.xtraTabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_main.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl_main.Name = "xtraTabControl_main";
            this.xtraTabControl_main.SelectedTabPage = this.xtraTabPage_producto;
            this.xtraTabControl_main.Size = new System.Drawing.Size(904, 264);
            this.xtraTabControl_main.TabIndex = 0;
            this.xtraTabControl_main.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_producto});
            // 
            // xtraTabPage_producto
            // 
            this.xtraTabPage_producto.Controls.Add(this.gridControl_productos);
            this.xtraTabPage_producto.Name = "xtraTabPage_producto";
            this.xtraTabPage_producto.Size = new System.Drawing.Size(898, 236);
            this.xtraTabPage_producto.Text = "Producto";
            // 
            // gridControl_productos
            // 
            this.gridControl_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_productos.Location = new System.Drawing.Point(0, 0);
            this.gridControl_productos.MainView = this.gridView_productos;
            this.gridControl_productos.Name = "gridControl_productos";
            this.gridControl_productos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_producto,
            this.cmb_producto_cod});
            this.gridControl_productos.Size = new System.Drawing.Size(898, 236);
            this.gridControl_productos.TabIndex = 0;
            this.gridControl_productos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_productos});
            // 
            // gridView_productos
            // 
            this.gridView_productos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_producto,
            this.colCant_a_devolver,
            this.colcant_devuelta,
            this.Saldo_x_devolver,
            this.colPrecio,
            this.colPorc_Descuento,
            this.colDescuento,
            this.colSubtotal,
            this.colIva,
            this.colTotal,
            this.colPaga_Iva,
            this.dv_observacion,
            this.Esta_en_base,
            this.colIdProducto,
            this.colCant_pedida_x_OC,
            this.colocdet_IdEmpresa,
            this.ocdet_IdSucursal,
            this.ocdet_IdOrdenCompra,
            this.ocdet_Secuencia});
            this.gridView_productos.GridControl = this.gridControl_productos;
            this.gridView_productos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.colSubtotal, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", this.colTotal, "")});
            this.gridView_productos.Name = "gridView_productos";
            this.gridView_productos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_productos_CellValueChanged);
            // 
            // cod_producto
            // 
            this.cod_producto.Caption = "Producto";
            this.cod_producto.ColumnEdit = this.cmb_producto;
            this.cod_producto.FieldName = "IdProducto";
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.OptionsColumn.AllowEdit = false;
            this.cod_producto.Visible = true;
            this.cod_producto.VisibleIndex = 0;
            this.cod_producto.Width = 330;
            // 
            // cmb_producto
            // 
            this.cmb_producto.AutoHeight = false;
            this.cmb_producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto.DisplayMember = "pr_descripcion";
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.ValueMember = "IdProducto";
            this.cmb_producto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigo,
            this.Producto,
            this.IdProducto});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // codigo
            // 
            this.codigo.Caption = "codigo";
            this.codigo.FieldName = "pr_codigo";
            this.codigo.Name = "codigo";
            this.codigo.Visible = true;
            this.codigo.VisibleIndex = 0;
            this.codigo.Width = 93;
            // 
            // Producto
            // 
            this.Producto.Caption = "Producto";
            this.Producto.FieldName = "pr_descripcion";
            this.Producto.Name = "Producto";
            this.Producto.Visible = true;
            this.Producto.VisibleIndex = 1;
            this.Producto.Width = 1013;
            // 
            // IdProducto
            // 
            this.IdProducto.Caption = "IdProducto";
            this.IdProducto.FieldName = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = true;
            this.IdProducto.VisibleIndex = 2;
            this.IdProducto.Width = 74;
            // 
            // colCant_a_devolver
            // 
            this.colCant_a_devolver.Caption = "Cant a devolver";
            this.colCant_a_devolver.FieldName = "dv_Cantidad";
            this.colCant_a_devolver.Name = "colCant_a_devolver";
            this.colCant_a_devolver.Visible = true;
            this.colCant_a_devolver.VisibleIndex = 1;
            this.colCant_a_devolver.Width = 113;
            // 
            // colcant_devuelta
            // 
            this.colcant_devuelta.Caption = "cant. devuelta";
            this.colcant_devuelta.FieldName = "cant_devuelta";
            this.colcant_devuelta.Name = "colcant_devuelta";
            this.colcant_devuelta.OptionsColumn.AllowEdit = false;
            this.colcant_devuelta.Visible = true;
            this.colcant_devuelta.VisibleIndex = 2;
            this.colcant_devuelta.Width = 82;
            // 
            // Saldo_x_devolver
            // 
            this.Saldo_x_devolver.Caption = "Saldo x Devolver";
            this.Saldo_x_devolver.FieldName = "saldo_x_devolver";
            this.Saldo_x_devolver.Name = "Saldo_x_devolver";
            this.Saldo_x_devolver.OptionsColumn.AllowEdit = false;
            this.Saldo_x_devolver.Visible = true;
            this.Saldo_x_devolver.VisibleIndex = 3;
            this.Saldo_x_devolver.Width = 101;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.FieldName = "dv_precioCompra";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.OptionsColumn.AllowEdit = false;
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 45;
            // 
            // colPorc_Descuento
            // 
            this.colPorc_Descuento.Caption = "% Desc.";
            this.colPorc_Descuento.FieldName = "dv_porc_des";
            this.colPorc_Descuento.Name = "colPorc_Descuento";
            this.colPorc_Descuento.OptionsColumn.AllowEdit = false;
            this.colPorc_Descuento.Visible = true;
            this.colPorc_Descuento.VisibleIndex = 5;
            this.colPorc_Descuento.Width = 25;
            // 
            // colDescuento
            // 
            this.colDescuento.Caption = "Descuento";
            this.colDescuento.FieldName = "dv_descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.OptionsColumn.AllowEdit = false;
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 6;
            this.colDescuento.Width = 38;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Caption = "Subtotal";
            this.colSubtotal.FieldName = "dv_subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.OptionsColumn.AllowEdit = false;
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 7;
            this.colSubtotal.Width = 37;
            // 
            // colIva
            // 
            this.colIva.Caption = "Iva";
            this.colIva.FieldName = "dv_iva";
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 8;
            this.colIva.Width = 20;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "dv_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 58;
            // 
            // colPaga_Iva
            // 
            this.colPaga_Iva.Caption = "Maneja Iva";
            this.colPaga_Iva.FieldName = "dv_ManejaIva";
            this.colPaga_Iva.Name = "colPaga_Iva";
            this.colPaga_Iva.Width = 66;
            // 
            // dv_observacion
            // 
            this.dv_observacion.Caption = "Observación";
            this.dv_observacion.FieldName = "dv_observacion";
            this.dv_observacion.Name = "dv_observacion";
            this.dv_observacion.Visible = true;
            this.dv_observacion.VisibleIndex = 10;
            this.dv_observacion.Width = 178;
            // 
            // Esta_en_base
            // 
            this.Esta_en_base.Caption = "Esta_en_base";
            this.Esta_en_base.FieldName = "Esta_en_base";
            this.Esta_en_base.Name = "Esta_en_base";
            this.Esta_en_base.OptionsColumn.AllowEdit = false;
            this.Esta_en_base.Width = 89;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.AllowEdit = false;
            this.colIdProducto.Width = 71;
            // 
            // colCant_pedida_x_OC
            // 
            this.colCant_pedida_x_OC.Caption = "Cant.Pedida x OC";
            this.colCant_pedida_x_OC.FieldName = "cant_pedida_x_OC";
            this.colCant_pedida_x_OC.Name = "colCant_pedida_x_OC";
            this.colCant_pedida_x_OC.OptionsColumn.AllowEdit = false;
            // 
            // colocdet_IdEmpresa
            // 
            this.colocdet_IdEmpresa.Caption = "ocdet_IdEmpresa";
            this.colocdet_IdEmpresa.FieldName = "ocdet_IdEmpresa ";
            this.colocdet_IdEmpresa.Name = "colocdet_IdEmpresa";
            this.colocdet_IdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // ocdet_IdSucursal
            // 
            this.ocdet_IdSucursal.Caption = "ocdet_IdSucursal";
            this.ocdet_IdSucursal.FieldName = "ocdet_IdSucursal";
            this.ocdet_IdSucursal.Name = "ocdet_IdSucursal";
            this.ocdet_IdSucursal.OptionsColumn.AllowEdit = false;
            // 
            // ocdet_IdOrdenCompra
            // 
            this.ocdet_IdOrdenCompra.Caption = "ocdet_IdOrdenCompra";
            this.ocdet_IdOrdenCompra.FieldName = "ocdet_IdOrdenCompra";
            this.ocdet_IdOrdenCompra.Name = "ocdet_IdOrdenCompra";
            this.ocdet_IdOrdenCompra.OptionsColumn.AllowEdit = false;
            // 
            // ocdet_Secuencia
            // 
            this.ocdet_Secuencia.Caption = "ocdet_Secuencia";
            this.ocdet_Secuencia.FieldName = "ocdet_Secuencia";
            this.ocdet_Secuencia.Name = "ocdet_Secuencia";
            this.ocdet_Secuencia.OptionsColumn.AllowEdit = false;
            // 
            // cmb_producto_cod
            // 
            this.cmb_producto_cod.AutoHeight = false;
            this.cmb_producto_cod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto_cod.DisplayMember = "pr_codigo";
            this.cmb_producto_cod.Name = "cmb_producto_cod";
            this.cmb_producto_cod.ValueMember = "IdProducto";
            this.cmb_producto_cod.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigo1,
            this.pr_descripcion,
            this.IdProducto1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // codigo1
            // 
            this.codigo1.Caption = "codigo";
            this.codigo1.FieldName = "pr_codigo";
            this.codigo1.Name = "codigo1";
            this.codigo1.Visible = true;
            this.codigo1.VisibleIndex = 0;
            // 
            // pr_descripcion
            // 
            this.pr_descripcion.Caption = "Producto";
            this.pr_descripcion.FieldName = "pr_descripcion";
            this.pr_descripcion.Name = "pr_descripcion";
            this.pr_descripcion.Visible = true;
            this.pr_descripcion.VisibleIndex = 1;
            // 
            // IdProducto1
            // 
            this.IdProducto1.Caption = "IdProducto";
            this.IdProducto1.FieldName = "IdProducto";
            this.IdProducto1.Name = "IdProducto1";
            this.IdProducto1.Visible = true;
            this.IdProducto1.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucCp_Proveedor1);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.ucIn_Sucursal_Bodega);
            this.panelControl1.Controls.Add(this.lblNum_dev);
            this.panelControl1.Controls.Add(this.groupBox3);
            this.panelControl1.Controls.Add(this.txt_num_dev_compra);
            this.panelControl1.Controls.Add(this.dtpfecha);
            this.panelControl1.Controls.Add(this.lblproveedor);
            this.panelControl1.Controls.Add(this.lblfecha);
            this.panelControl1.Controls.Add(this.txtObservacion);
            this.panelControl1.Controls.Add(this.lblobservacion);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 208);
            this.panelControl1.TabIndex = 37;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabControl_main);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(908, 268);
            this.panelControl2.TabIndex = 1;
            // 
            // FrmCom_Dev_Compra_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 533);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu_Superior);
            this.Name = "FrmCom_Dev_Compra_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución en Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCom_Dev_Compra_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmCom_Dev_Compra_Mant_Load);
            this.panel_main.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkdevolver_total_vta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_main)).EndInit();
            this.xtraTabControl_main.ResumeLayout(false);
            this.xtraTabPage_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_cod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblobservacion;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txt_num_dev_compra;
        private System.Windows.Forms.Label lblNum_dev;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_main;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_producto;
        private DevExpress.XtraGrid.GridControl gridControl_productos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_productos;
        private DevExpress.XtraGrid.Columns.GridColumn cod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_a_devolver;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colPorc_Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPaga_Iva;
        private DevExpress.XtraGrid.Columns.GridColumn dv_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Esta_en_base;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Producto;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_producto_cod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn codigo1;
        private DevExpress.XtraGrid.Columns.GridColumn pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn IdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.TextEdit txtOrdenCompra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_devuelta;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo_x_devolver;
        private DevExpress.XtraGrid.Columns.GridColumn colCant_pedida_x_OC;
        private DevExpress.XtraGrid.Columns.GridColumn colocdet_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn ocdet_IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn ocdet_IdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn ocdet_Secuencia;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private Controles.UCCp_Proveedor ucCp_Proveedor1;
        private DevExpress.XtraEditors.CheckEdit chkdevolver_total_vta;
        private DevExpress.XtraEditors.SimpleButton btnImportar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}
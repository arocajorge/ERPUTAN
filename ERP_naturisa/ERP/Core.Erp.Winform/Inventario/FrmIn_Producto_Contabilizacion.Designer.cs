namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_Contabilizacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.ucIn_Sucursal_Bodega = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridControlProducto_x_Bodg = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBandDatosProducto = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColSucursal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBodega = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColCategoria = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColLinea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColCodProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColGrupo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandCtaCbles = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRegModificado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColIdCtaCble_Inv = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_Inv = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_inv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Costo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_costo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Gastos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_Gasto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_Gastos1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_gastos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta_gastos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_gastos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_Vta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_vta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta_vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_DevVta = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_DevVta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_DevVta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_devVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta_devVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_devVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_DescVta = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_CtaCble_DescVta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_desVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta_descVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta_desVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre_desVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto_x_Bodg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Gasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Vta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_DevVta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_DescVta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1237, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 412);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1237, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 383);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaHoy);
            this.splitContainer1.Panel1.Controls.Add(this.ucIn_Sucursal_Bodega);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 383);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 1;
            // 
            // dtpFechaHoy
            // 
            this.dtpFechaHoy.Location = new System.Drawing.Point(1016, 6);
            this.dtpFechaHoy.Name = "dtpFechaHoy";
            this.dtpFechaHoy.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaHoy.TabIndex = 2;
            // 
            // ucIn_Sucursal_Bodega
            // 
            this.ucIn_Sucursal_Bodega.Location = new System.Drawing.Point(12, 3);
            this.ucIn_Sucursal_Bodega.Name = "ucIn_Sucursal_Bodega";
            this.ucIn_Sucursal_Bodega.Size = new System.Drawing.Size(462, 53);
            this.ucIn_Sucursal_Bodega.TabIndex = 1;
            this.ucIn_Sucursal_Bodega.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(530, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 32);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridControlProducto_x_Bodg);
            this.splitContainer2.Size = new System.Drawing.Size(1237, 320);
            this.splitContainer2.SplitterDistance = 26;
            this.splitContainer2.TabIndex = 1;
            // 
            // gridControlProducto_x_Bodg
            // 
            this.gridControlProducto_x_Bodg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducto_x_Bodg.Location = new System.Drawing.Point(0, 0);
            this.gridControlProducto_x_Bodg.MainView = this.advBandedGridView1;
            this.gridControlProducto_x_Bodg.Name = "gridControlProducto_x_Bodg";
            this.gridControlProducto_x_Bodg.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_CtaCble_Inv,
            this.cmb_CtaCble_costo,
            this.cmb_CtaCble_Vta,
            this.cmb_CtaCble_DescVta,
            this.cmb_CtaCble_DevVta,
            this.cmb_CtaCble_Gasto});
            this.gridControlProducto_x_Bodg.Size = new System.Drawing.Size(1237, 290);
            this.gridControlProducto_x_Bodg.TabIndex = 0;
            this.gridControlProducto_x_Bodg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandDatosProducto,
            this.gridBandCtaCbles});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColSucursal,
            this.colBodega,
            this.ColCategoria,
            this.ColLinea,
            this.ColGrupo,
            this.ColCodProducto,
            this.ColProducto,
            this.ColIdCtaCble_Inv,
            this.colIdCtaCble_Costo,
            this.colIdCtaCble,
            this.colIdCtaCble_DescVta,
            this.colIdCtaCble_DevVta,
            this.colIdCtaCble_Gastos,
            this.colRegModificado});
            this.advBandedGridView1.GridControl = this.gridControlProducto_x_Bodg;
            this.advBandedGridView1.GroupCount = 1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColSucursal, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.advBandedGridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.advBandedGridView1_CellValueChanged);
            // 
            // gridBandDatosProducto
            // 
            this.gridBandDatosProducto.Caption = "Datos Producto";
            this.gridBandDatosProducto.Columns.Add(this.ColSucursal);
            this.gridBandDatosProducto.Columns.Add(this.colBodega);
            this.gridBandDatosProducto.Columns.Add(this.ColCategoria);
            this.gridBandDatosProducto.Columns.Add(this.ColLinea);
            this.gridBandDatosProducto.Columns.Add(this.ColCodProducto);
            this.gridBandDatosProducto.Columns.Add(this.ColProducto);
            this.gridBandDatosProducto.Columns.Add(this.ColGrupo);
            this.gridBandDatosProducto.Name = "gridBandDatosProducto";
            this.gridBandDatosProducto.Width = 845;
            // 
            // ColSucursal
            // 
            this.ColSucursal.Caption = "Sucursal";
            this.ColSucursal.FieldName = "Nom_sucursal";
            this.ColSucursal.Name = "ColSucursal";
            this.ColSucursal.Visible = true;
            this.ColSucursal.Width = 109;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "Nom_bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.Width = 132;
            // 
            // ColCategoria
            // 
            this.ColCategoria.Caption = "Categoria";
            this.ColCategoria.FieldName = "nom_categoria";
            this.ColCategoria.Name = "ColCategoria";
            this.ColCategoria.Visible = true;
            this.ColCategoria.Width = 127;
            // 
            // ColLinea
            // 
            this.ColLinea.Caption = "Linea";
            this.ColLinea.FieldName = "nom_linea";
            this.ColLinea.Name = "ColLinea";
            this.ColLinea.Width = 93;
            // 
            // ColCodProducto
            // 
            this.ColCodProducto.Caption = "Cod-Producto";
            this.ColCodProducto.FieldName = "pr_codigo";
            this.ColCodProducto.Name = "ColCodProducto";
            this.ColCodProducto.Visible = true;
            this.ColCodProducto.Width = 101;
            // 
            // ColProducto
            // 
            this.ColProducto.Caption = "Producto";
            this.ColProducto.FieldName = "pr_descripcion";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.Visible = true;
            this.ColProducto.Width = 376;
            // 
            // ColGrupo
            // 
            this.ColGrupo.Caption = "Grupo";
            this.ColGrupo.FieldName = "nom_grupo";
            this.ColGrupo.Name = "ColGrupo";
            this.ColGrupo.RowIndex = 1;
            this.ColGrupo.Width = 759;
            // 
            // gridBandCtaCbles
            // 
            this.gridBandCtaCbles.Caption = "Cuentas Contables";
            this.gridBandCtaCbles.Columns.Add(this.colRegModificado);
            this.gridBandCtaCbles.Columns.Add(this.ColIdCtaCble_Inv);
            this.gridBandCtaCbles.Columns.Add(this.colIdCtaCble_Costo);
            this.gridBandCtaCbles.Columns.Add(this.colIdCtaCble_Gastos);
            this.gridBandCtaCbles.Columns.Add(this.colIdCtaCble);
            this.gridBandCtaCbles.Columns.Add(this.colIdCtaCble_DevVta);
            this.gridBandCtaCbles.Columns.Add(this.colIdCtaCble_DescVta);
            this.gridBandCtaCbles.Name = "gridBandCtaCbles";
            this.gridBandCtaCbles.Width = 4284;
            // 
            // colRegModificado
            // 
            this.colRegModificado.Caption = "RegModificado";
            this.colRegModificado.FieldName = "RegModificado";
            this.colRegModificado.Name = "colRegModificado";
            // 
            // ColIdCtaCble_Inv
            // 
            this.ColIdCtaCble_Inv.Caption = "CtaCble x Inventario";
            this.ColIdCtaCble_Inv.ColumnEdit = this.cmb_CtaCble_Inv;
            this.ColIdCtaCble_Inv.FieldName = "IdCtaCble_Inven";
            this.ColIdCtaCble_Inv.Name = "ColIdCtaCble_Inv";
            this.ColIdCtaCble_Inv.Visible = true;
            this.ColIdCtaCble_Inv.Width = 247;
            // 
            // cmb_CtaCble_Inv
            // 
            this.cmb_CtaCble_Inv.AutoHeight = false;
            this.cmb_CtaCble_Inv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_Inv.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_Inv.Name = "cmb_CtaCble_Inv";
            this.cmb_CtaCble_Inv.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_Inv.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_inv1,
            this.colpc_Cuenta,
            this.colCuentaPadre_inv,
            this.colpc_clave_corta_inv});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_inv1
            // 
            this.colIdCtaCble_inv1.Caption = "IdCtaCble";
            this.colIdCtaCble_inv1.FieldName = "IdCtaCble";
            this.colIdCtaCble_inv1.Name = "colIdCtaCble_inv1";
            this.colIdCtaCble_inv1.Visible = true;
            this.colIdCtaCble_inv1.VisibleIndex = 0;
            this.colIdCtaCble_inv1.Width = 152;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "Cuenta";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 2;
            this.colpc_Cuenta.Width = 686;
            // 
            // colCuentaPadre_inv
            // 
            this.colCuentaPadre_inv.Caption = "CuentaPadre";
            this.colCuentaPadre_inv.FieldName = "CuentaPadre";
            this.colCuentaPadre_inv.Name = "colCuentaPadre_inv";
            this.colCuentaPadre_inv.Visible = true;
            this.colCuentaPadre_inv.VisibleIndex = 3;
            this.colCuentaPadre_inv.Width = 208;
            // 
            // colpc_clave_corta_inv
            // 
            this.colpc_clave_corta_inv.Caption = "Clave";
            this.colpc_clave_corta_inv.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_inv.Name = "colpc_clave_corta_inv";
            this.colpc_clave_corta_inv.Visible = true;
            this.colpc_clave_corta_inv.VisibleIndex = 1;
            this.colpc_clave_corta_inv.Width = 134;
            // 
            // colIdCtaCble_Costo
            // 
            this.colIdCtaCble_Costo.Caption = "CtaCble Costo Inventario";
            this.colIdCtaCble_Costo.ColumnEdit = this.cmb_CtaCble_costo;
            this.colIdCtaCble_Costo.FieldName = "IdCtaCble_Costo";
            this.colIdCtaCble_Costo.Name = "colIdCtaCble_Costo";
            this.colIdCtaCble_Costo.Visible = true;
            this.colIdCtaCble_Costo.Width = 244;
            // 
            // cmb_CtaCble_costo
            // 
            this.cmb_CtaCble_costo.AutoHeight = false;
            this.cmb_CtaCble_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_costo.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_costo.Name = "cmb_CtaCble_costo";
            this.cmb_CtaCble_costo.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_costo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_costo1,
            this.colpc_Cuenta_costo,
            this.colpc_clave_corta_costo,
            this.colCuentaPadre_costo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_costo1
            // 
            this.colIdCtaCble_costo1.Caption = "IdCtaCble";
            this.colIdCtaCble_costo1.FieldName = "IdCtaCble";
            this.colIdCtaCble_costo1.Name = "colIdCtaCble_costo1";
            this.colIdCtaCble_costo1.Visible = true;
            this.colIdCtaCble_costo1.VisibleIndex = 0;
            this.colIdCtaCble_costo1.Width = 226;
            // 
            // colpc_Cuenta_costo
            // 
            this.colpc_Cuenta_costo.Caption = "Cuenta";
            this.colpc_Cuenta_costo.FieldName = "pc_Cuenta";
            this.colpc_Cuenta_costo.Name = "colpc_Cuenta_costo";
            this.colpc_Cuenta_costo.Visible = true;
            this.colpc_Cuenta_costo.VisibleIndex = 2;
            this.colpc_Cuenta_costo.Width = 606;
            // 
            // colpc_clave_corta_costo
            // 
            this.colpc_clave_corta_costo.Caption = "Clave";
            this.colpc_clave_corta_costo.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_costo.Name = "colpc_clave_corta_costo";
            this.colpc_clave_corta_costo.Visible = true;
            this.colpc_clave_corta_costo.VisibleIndex = 1;
            this.colpc_clave_corta_costo.Width = 113;
            // 
            // colCuentaPadre_costo
            // 
            this.colCuentaPadre_costo.Caption = "CuentaPadre";
            this.colCuentaPadre_costo.FieldName = "CuentaPadre";
            this.colCuentaPadre_costo.Name = "colCuentaPadre_costo";
            this.colCuentaPadre_costo.Visible = true;
            this.colCuentaPadre_costo.VisibleIndex = 3;
            this.colCuentaPadre_costo.Width = 235;
            // 
            // colIdCtaCble_Gastos
            // 
            this.colIdCtaCble_Gastos.Caption = "CtaCble Gastos en Compras";
            this.colIdCtaCble_Gastos.ColumnEdit = this.cmb_CtaCble_Gasto;
            this.colIdCtaCble_Gastos.FieldName = "IdCtaCble_Gasto_x_cxp";
            this.colIdCtaCble_Gastos.Name = "colIdCtaCble_Gastos";
            this.colIdCtaCble_Gastos.Visible = true;
            this.colIdCtaCble_Gastos.Width = 290;
            // 
            // cmb_CtaCble_Gasto
            // 
            this.cmb_CtaCble_Gasto.AutoHeight = false;
            this.cmb_CtaCble_Gasto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_Gasto.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_Gasto.Name = "cmb_CtaCble_Gasto";
            this.cmb_CtaCble_Gasto.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_Gasto.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_Gastos1,
            this.colpc_clave_corta_gastos,
            this.colpc_Cuenta_gastos,
            this.colCuentaPadre_gastos});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_Gastos1
            // 
            this.colIdCtaCble_Gastos1.Caption = "IdCtaCble";
            this.colIdCtaCble_Gastos1.FieldName = "IdCtaCble";
            this.colIdCtaCble_Gastos1.Name = "colIdCtaCble_Gastos1";
            this.colIdCtaCble_Gastos1.Visible = true;
            this.colIdCtaCble_Gastos1.VisibleIndex = 0;
            this.colIdCtaCble_Gastos1.Width = 172;
            // 
            // colpc_clave_corta_gastos
            // 
            this.colpc_clave_corta_gastos.Caption = "Clave Corta";
            this.colpc_clave_corta_gastos.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_gastos.Name = "colpc_clave_corta_gastos";
            this.colpc_clave_corta_gastos.Visible = true;
            this.colpc_clave_corta_gastos.VisibleIndex = 1;
            this.colpc_clave_corta_gastos.Width = 188;
            // 
            // colpc_Cuenta_gastos
            // 
            this.colpc_Cuenta_gastos.Caption = "Cuenta";
            this.colpc_Cuenta_gastos.FieldName = "pc_Cuenta";
            this.colpc_Cuenta_gastos.Name = "colpc_Cuenta_gastos";
            this.colpc_Cuenta_gastos.Visible = true;
            this.colpc_Cuenta_gastos.VisibleIndex = 2;
            this.colpc_Cuenta_gastos.Width = 537;
            // 
            // colCuentaPadre_gastos
            // 
            this.colCuentaPadre_gastos.Caption = "CuentaPadre";
            this.colCuentaPadre_gastos.FieldName = "CuentaPadre";
            this.colCuentaPadre_gastos.Name = "colCuentaPadre_gastos";
            this.colCuentaPadre_gastos.Visible = true;
            this.colCuentaPadre_gastos.VisibleIndex = 3;
            this.colCuentaPadre_gastos.Width = 283;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "CtaCble x Venta";
            this.colIdCtaCble.ColumnEdit = this.cmb_CtaCble_Vta;
            this.colIdCtaCble.FieldName = "IdCtaCble_Vta";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.Width = 252;
            // 
            // cmb_CtaCble_Vta
            // 
            this.cmb_CtaCble_Vta.AutoHeight = false;
            this.cmb_CtaCble_Vta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_Vta.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_Vta.Name = "cmb_CtaCble_Vta";
            this.cmb_CtaCble_Vta.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_Vta.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_vta1,
            this.colpc_clave_corta_vta,
            this.colpc_Cuenta_vta,
            this.colCuentaPadre_vta});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_vta1
            // 
            this.colIdCtaCble_vta1.Caption = "IdCtaCble";
            this.colIdCtaCble_vta1.FieldName = "IdCtaCble";
            this.colIdCtaCble_vta1.Name = "colIdCtaCble_vta1";
            this.colIdCtaCble_vta1.Visible = true;
            this.colIdCtaCble_vta1.VisibleIndex = 0;
            this.colIdCtaCble_vta1.Width = 183;
            // 
            // colpc_clave_corta_vta
            // 
            this.colpc_clave_corta_vta.Caption = "Clave_corta";
            this.colpc_clave_corta_vta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_vta.Name = "colpc_clave_corta_vta";
            this.colpc_clave_corta_vta.Visible = true;
            this.colpc_clave_corta_vta.VisibleIndex = 1;
            this.colpc_clave_corta_vta.Width = 171;
            // 
            // colpc_Cuenta_vta
            // 
            this.colpc_Cuenta_vta.Caption = "Cuenta";
            this.colpc_Cuenta_vta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta_vta.Name = "colpc_Cuenta_vta";
            this.colpc_Cuenta_vta.Visible = true;
            this.colpc_Cuenta_vta.VisibleIndex = 2;
            this.colpc_Cuenta_vta.Width = 412;
            // 
            // colCuentaPadre_vta
            // 
            this.colCuentaPadre_vta.Caption = "CuentaPadre";
            this.colCuentaPadre_vta.FieldName = "CuentaPadre";
            this.colCuentaPadre_vta.Name = "colCuentaPadre_vta";
            this.colCuentaPadre_vta.Visible = true;
            this.colCuentaPadre_vta.VisibleIndex = 3;
            this.colCuentaPadre_vta.Width = 414;
            // 
            // colIdCtaCble_DevVta
            // 
            this.colIdCtaCble_DevVta.Caption = "CtaCble  Devolucion en Vta";
            this.colIdCtaCble_DevVta.ColumnEdit = this.cmb_CtaCble_DevVta;
            this.colIdCtaCble_DevVta.FieldName = "IdCtaCble_Dev0";
            this.colIdCtaCble_DevVta.Name = "colIdCtaCble_DevVta";
            this.colIdCtaCble_DevVta.Visible = true;
            this.colIdCtaCble_DevVta.Width = 318;
            // 
            // cmb_CtaCble_DevVta
            // 
            this.cmb_CtaCble_DevVta.AutoHeight = false;
            this.cmb_CtaCble_DevVta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_DevVta.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_DevVta.Name = "cmb_CtaCble_DevVta";
            this.cmb_CtaCble_DevVta.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_DevVta.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_DevVta1,
            this.colpc_clave_corta_devVta,
            this.colpc_Cuenta_devVta,
            this.colCuentaPadre_devVta});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_DevVta1
            // 
            this.colIdCtaCble_DevVta1.Caption = "IdCtaCble";
            this.colIdCtaCble_DevVta1.FieldName = "IdCtaCble";
            this.colIdCtaCble_DevVta1.Name = "colIdCtaCble_DevVta1";
            this.colIdCtaCble_DevVta1.Visible = true;
            this.colIdCtaCble_DevVta1.VisibleIndex = 0;
            this.colIdCtaCble_DevVta1.Width = 171;
            // 
            // colpc_clave_corta_devVta
            // 
            this.colpc_clave_corta_devVta.Caption = "Clave Corta";
            this.colpc_clave_corta_devVta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_devVta.Name = "colpc_clave_corta_devVta";
            this.colpc_clave_corta_devVta.Visible = true;
            this.colpc_clave_corta_devVta.VisibleIndex = 1;
            this.colpc_clave_corta_devVta.Width = 176;
            // 
            // colpc_Cuenta_devVta
            // 
            this.colpc_Cuenta_devVta.Caption = "Cuenta";
            this.colpc_Cuenta_devVta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta_devVta.Name = "colpc_Cuenta_devVta";
            this.colpc_Cuenta_devVta.Visible = true;
            this.colpc_Cuenta_devVta.VisibleIndex = 2;
            this.colpc_Cuenta_devVta.Width = 509;
            // 
            // colCuentaPadre_devVta
            // 
            this.colCuentaPadre_devVta.Caption = "CuentaPadre";
            this.colCuentaPadre_devVta.FieldName = "CuentaPadre";
            this.colCuentaPadre_devVta.Name = "colCuentaPadre_devVta";
            this.colCuentaPadre_devVta.Visible = true;
            this.colCuentaPadre_devVta.VisibleIndex = 3;
            this.colCuentaPadre_devVta.Width = 324;
            // 
            // colIdCtaCble_DescVta
            // 
            this.colIdCtaCble_DescVta.Caption = "CtaCble  Descuento en Vta";
            this.colIdCtaCble_DescVta.ColumnEdit = this.cmb_CtaCble_DescVta;
            this.colIdCtaCble_DescVta.FieldName = "IdCtaCble_Des0";
            this.colIdCtaCble_DescVta.Name = "colIdCtaCble_DescVta";
            this.colIdCtaCble_DescVta.Visible = true;
            this.colIdCtaCble_DescVta.Width = 2933;
            // 
            // cmb_CtaCble_DescVta
            // 
            this.cmb_CtaCble_DescVta.AutoHeight = false;
            this.cmb_CtaCble_DescVta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CtaCble_DescVta.DisplayMember = "pc_Cuenta2";
            this.cmb_CtaCble_DescVta.Name = "cmb_CtaCble_DescVta";
            this.cmb_CtaCble_DescVta.ValueMember = "IdCtaCble";
            this.cmb_CtaCble_DescVta.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_desVta,
            this.colpc_clave_corta_descVta,
            this.colpc_Cuenta_desVta,
            this.colCuentaPadre_desVta});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_desVta
            // 
            this.colIdCtaCble_desVta.Caption = "IdCtaCble";
            this.colIdCtaCble_desVta.FieldName = "IdCtaCble";
            this.colIdCtaCble_desVta.Name = "colIdCtaCble_desVta";
            this.colIdCtaCble_desVta.Visible = true;
            this.colIdCtaCble_desVta.VisibleIndex = 0;
            this.colIdCtaCble_desVta.Width = 189;
            // 
            // colpc_clave_corta_descVta
            // 
            this.colpc_clave_corta_descVta.Caption = "Clave Corta";
            this.colpc_clave_corta_descVta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta_descVta.Name = "colpc_clave_corta_descVta";
            this.colpc_clave_corta_descVta.Visible = true;
            this.colpc_clave_corta_descVta.VisibleIndex = 1;
            this.colpc_clave_corta_descVta.Width = 126;
            // 
            // colpc_Cuenta_desVta
            // 
            this.colpc_Cuenta_desVta.Caption = "Cuenta";
            this.colpc_Cuenta_desVta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta_desVta.Name = "colpc_Cuenta_desVta";
            this.colpc_Cuenta_desVta.Visible = true;
            this.colpc_Cuenta_desVta.VisibleIndex = 2;
            this.colpc_Cuenta_desVta.Width = 514;
            // 
            // colCuentaPadre_desVta
            // 
            this.colCuentaPadre_desVta.Caption = "CuentaPadre";
            this.colCuentaPadre_desVta.FieldName = "CuentaPadre";
            this.colCuentaPadre_desVta.Name = "colCuentaPadre_desVta";
            this.colCuentaPadre_desVta.Visible = true;
            this.colCuentaPadre_desVta.VisibleIndex = 3;
            this.colCuentaPadre_desVta.Width = 351;
            // 
            // FrmIn_Producto_Contabilizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Producto_Contabilizacion";
            this.Text = "FrmIn_Producto_Contabilizacion";
            this.Load += new System.EventHandler(this.FrmIn_Producto_Contabilizacion_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto_x_Bodg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Gasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_Vta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_DevVta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CtaCble_DescVta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlProducto_x_Bodg;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColSucursal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBodega;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCategoria;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColLinea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCodProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColGrupo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColIdCtaCble_Inv;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCtaCble_Costo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCtaCble_DevVta;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCtaCble_DescVta;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCtaCble_Gastos;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_Inv;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_inv1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_inv;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_costo1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_costo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_Vta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_vta1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_vta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_vta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_vta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_DescVta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_desVta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_descVta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_desVta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_desVta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_DevVta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_DevVta1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_devVta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_devVta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_devVta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_CtaCble_Gasto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Gastos1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta_gastos;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta_gastos;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre_gastos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandDatosProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandCtaCbles;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegModificado;
        private System.Windows.Forms.DateTimePicker dtpFechaHoy;
    }
}
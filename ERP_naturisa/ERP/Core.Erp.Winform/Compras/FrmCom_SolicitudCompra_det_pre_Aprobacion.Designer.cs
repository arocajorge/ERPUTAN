namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_SolicitudCompra_det_pre_Aprobacion
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
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gbFiltroBusqueda = new System.Windows.Forms.GroupBox();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.lblFHasta = new System.Windows.Forms.Label();
            this.lblFdesde = new System.Windows.Forms.Label();
            this.dtpFecha_desde = new System.Windows.Forms.DateTimePicker();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlSolicitud_det_pre_Aprobacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewSolicitud_det_pre_Aprobacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Estado_Aprobacion_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogocompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked_apro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIdPunto_cargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProveedor_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_checked_repro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbFiltroBusqueda.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSolicitud_det_pre_Aprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitud_det_pre_Aprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado_Aprobacion_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdPunto_cargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(1455, 36);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            // 
            // gbFiltroBusqueda
            // 
            this.gbFiltroBusqueda.Controls.Add(this.ucGe_Sucursal_combo1);
            this.gbFiltroBusqueda.Controls.Add(this.label1);
            this.gbFiltroBusqueda.Controls.Add(this.btnBuscar);
            this.gbFiltroBusqueda.Controls.Add(this.dtpFecha_Hasta);
            this.gbFiltroBusqueda.Controls.Add(this.lblFHasta);
            this.gbFiltroBusqueda.Controls.Add(this.lblFdesde);
            this.gbFiltroBusqueda.Controls.Add(this.dtpFecha_desde);
            this.gbFiltroBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltroBusqueda.Location = new System.Drawing.Point(0, 36);
            this.gbFiltroBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltroBusqueda.Name = "gbFiltroBusqueda";
            this.gbFiltroBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltroBusqueda.Size = new System.Drawing.Size(1455, 99);
            this.gbFiltroBusqueda.TabIndex = 1;
            this.gbFiltroBusqueda.TabStop = false;
            this.gbFiltroBusqueda.Text = "Filtro de Busqueda";
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(200, 23);
            this.ucGe_Sucursal_combo1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(489, 27);
            this.ucGe_Sucursal_combo1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sucursal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(980, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 39);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(789, 54);
            this.dtpFecha_Hasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(153, 22);
            this.dtpFecha_Hasta.TabIndex = 3;
            // 
            // lblFHasta
            // 
            this.lblFHasta.AutoSize = true;
            this.lblFHasta.Location = new System.Drawing.Point(727, 60);
            this.lblFHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFHasta.Name = "lblFHasta";
            this.lblFHasta.Size = new System.Drawing.Size(49, 17);
            this.lblFHasta.TabIndex = 3;
            this.lblFHasta.Text = "Hasta:";
            // 
            // lblFdesde
            // 
            this.lblFdesde.AutoSize = true;
            this.lblFdesde.Location = new System.Drawing.Point(727, 22);
            this.lblFdesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFdesde.Name = "lblFdesde";
            this.lblFdesde.Size = new System.Drawing.Size(53, 17);
            this.lblFdesde.TabIndex = 2;
            this.lblFdesde.Text = "Desde:";
            // 
            // dtpFecha_desde
            // 
            this.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_desde.Location = new System.Drawing.Point(789, 22);
            this.dtpFecha_desde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_desde.Name = "dtpFecha_desde";
            this.dtpFecha_desde.Size = new System.Drawing.Size(153, 22);
            this.dtpFecha_desde.TabIndex = 2;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 540);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1455, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlSolicitud_det_pre_Aprobacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 405);
            this.panel1.TabIndex = 3;
            // 
            // gridControlSolicitud_det_pre_Aprobacion
            // 
            this.gridControlSolicitud_det_pre_Aprobacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSolicitud_det_pre_Aprobacion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSolicitud_det_pre_Aprobacion.Location = new System.Drawing.Point(0, 0);
            this.gridControlSolicitud_det_pre_Aprobacion.MainView = this.gridViewSolicitud_det_pre_Aprobacion;
            this.gridControlSolicitud_det_pre_Aprobacion.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSolicitud_det_pre_Aprobacion.Name = "gridControlSolicitud_det_pre_Aprobacion";
            this.gridControlSolicitud_det_pre_Aprobacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Estado_Aprobacion_grid,
            this.cmbIdPunto_cargo_grid,
            this.cmbProveedor_grid});
            this.gridControlSolicitud_det_pre_Aprobacion.Size = new System.Drawing.Size(1455, 405);
            this.gridControlSolicitud_det_pre_Aprobacion.TabIndex = 0;
            this.gridControlSolicitud_det_pre_Aprobacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSolicitud_det_pre_Aprobacion});
            // 
            // gridViewSolicitud_det_pre_Aprobacion
            // 
            this.gridViewSolicitud_det_pre_Aprobacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdSolicitudCompra,
            this.colSecuencia,
            this.colIdProducto,
            this.colNomProducto,
            this.coldo_Cantidad,
            this.colIdEstadoAprobacion,
            this.colChecked_apro,
            this.colnom_Sucursal,
            this.colfecha,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn23,
            this.gridColumn24,
            this.col_checked_repro});
            this.gridViewSolicitud_det_pre_Aprobacion.GridControl = this.gridControlSolicitud_det_pre_Aprobacion;
            this.gridViewSolicitud_det_pre_Aprobacion.Name = "gridViewSolicitud_det_pre_Aprobacion";
            this.gridViewSolicitud_det_pre_Aprobacion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewSolicitud_det_pre_Aprobacion.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSolicitud_det_pre_Aprobacion.OptionsView.ShowGroupPanel = false;
            this.gridViewSolicitud_det_pre_Aprobacion.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSolicitud_det_pre_Aprobacion_RowClick);
            this.gridViewSolicitud_det_pre_Aprobacion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSolicitud_det_pre_Aprobacion_CellValueChanged);
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
            // colIdSolicitudCompra
            // 
            this.colIdSolicitudCompra.Caption = "# Solicitud";
            this.colIdSolicitudCompra.FieldName = "IdSolicitudCompra";
            this.colIdSolicitudCompra.Name = "colIdSolicitudCompra";
            this.colIdSolicitudCompra.OptionsColumn.AllowEdit = false;
            this.colIdSolicitudCompra.OptionsColumn.ReadOnly = true;
            this.colIdSolicitudCompra.Visible = true;
            this.colIdSolicitudCompra.VisibleIndex = 3;
            this.colIdSolicitudCompra.Width = 64;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.OptionsColumn.AllowEdit = false;
            this.colNomProducto.OptionsColumn.ReadOnly = true;
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 7;
            this.colNomProducto.Width = 305;
            // 
            // coldo_Cantidad
            // 
            this.coldo_Cantidad.Caption = "Cant./Aprobada";
            this.coldo_Cantidad.FieldName = "cant_ing_SolCom";
            this.coldo_Cantidad.Name = "coldo_Cantidad";
            this.coldo_Cantidad.Visible = true;
            this.coldo_Cantidad.VisibleIndex = 9;
            this.coldo_Cantidad.Width = 111;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.Caption = "Estado/PreAprobacion";
            this.colIdEstadoAprobacion.ColumnEdit = this.cmb_Estado_Aprobacion_grid;
            this.colIdEstadoAprobacion.FieldName = "IdEstadoPreAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 2;
            this.colIdEstadoAprobacion.Width = 90;
            // 
            // cmb_Estado_Aprobacion_grid
            // 
            this.cmb_Estado_Aprobacion_grid.AutoHeight = false;
            this.cmb_Estado_Aprobacion_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Estado_Aprobacion_grid.Name = "cmb_Estado_Aprobacion_grid";
            this.cmb_Estado_Aprobacion_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion_cmb,
            this.colIdCatalogocompra});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion_cmb
            // 
            this.coldescripcion_cmb.Caption = "Estado";
            this.coldescripcion_cmb.FieldName = "descripcion";
            this.coldescripcion_cmb.Name = "coldescripcion_cmb";
            this.coldescripcion_cmb.Visible = true;
            this.coldescripcion_cmb.VisibleIndex = 0;
            this.coldescripcion_cmb.Width = 900;
            // 
            // colIdCatalogocompra
            // 
            this.colIdCatalogocompra.Caption = "ID";
            this.colIdCatalogocompra.FieldName = "IdCatalogocompra";
            this.colIdCatalogocompra.Name = "colIdCatalogocompra";
            this.colIdCatalogocompra.Visible = true;
            this.colIdCatalogocompra.VisibleIndex = 1;
            this.colIdCatalogocompra.Width = 252;
            // 
            // colChecked_apro
            // 
            this.colChecked_apro.Caption = "A";
            this.colChecked_apro.FieldName = "Checked";
            this.colChecked_apro.Name = "colChecked_apro";
            this.colChecked_apro.OptionsColumn.AllowEdit = false;
            this.colChecked_apro.Visible = true;
            this.colChecked_apro.VisibleIndex = 0;
            this.colChecked_apro.Width = 33;
            // 
            // colnom_Sucursal
            // 
            this.colnom_Sucursal.Caption = "Sucursal";
            this.colnom_Sucursal.FieldName = "nom_Sucursal";
            this.colnom_Sucursal.Name = "colnom_Sucursal";
            this.colnom_Sucursal.OptionsColumn.AllowEdit = false;
            this.colnom_Sucursal.Width = 129;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Width = 88;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Canti. Solicitada";
            this.gridColumn1.FieldName = "cant_solicitada";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 118;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado Aprobacion";
            this.gridColumn2.ColumnEdit = this.cmb_Estado_Aprobacion_grid;
            this.gridColumn2.FieldName = "IdEstadoAprobacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Width = 54;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Comprador";
            this.gridColumn3.FieldName = "Comprador";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 159;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Solicitante";
            this.gridColumn4.FieldName = "Solicitante";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 145;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Precio";
            this.gridColumn5.FieldName = "do_precioCompra";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Width = 60;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Iva";
            this.gridColumn6.FieldName = "do_iva";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Width = 34;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SubTotal";
            this.gridColumn7.FieldName = "do_subtotal";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Width = 46;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total";
            this.gridColumn8.FieldName = "do_total";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Width = 41;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Punto Cargo";
            this.gridColumn9.ColumnEdit = this.cmbIdPunto_cargo_grid;
            this.gridColumn9.FieldName = "IdPunto_cargo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Width = 198;
            // 
            // cmbIdPunto_cargo_grid
            // 
            this.cmbIdPunto_cargo_grid.AutoHeight = false;
            this.cmbIdPunto_cargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIdPunto_cargo_grid.DisplayMember = "nom_punto_cargo";
            this.cmbIdPunto_cargo_grid.Name = "cmbIdPunto_cargo_grid";
            this.cmbIdPunto_cargo_grid.ValueMember = "IdPunto_cargo";
            this.cmbIdPunto_cargo_grid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn22});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Punto cargo";
            this.gridColumn22.FieldName = "nom_punto_cargo";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 0;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Proveedor";
            this.gridColumn10.ColumnEdit = this.cmbProveedor_grid;
            this.gridColumn10.FieldName = "IdProveedor";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Width = 69;
            // 
            // cmbProveedor_grid
            // 
            this.cmbProveedor_grid.AutoHeight = false;
            this.cmbProveedor_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor_grid.DisplayMember = "pr_nombre";
            this.cmbProveedor_grid.Name = "cmbProveedor_grid";
            this.cmbProveedor_grid.ValueMember = "IdProveedor";
            this.cmbProveedor_grid.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn21});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Proveedor";
            this.gridColumn21.FieldName = "pr_nombre";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Centro de costo";
            this.gridColumn19.FieldName = "Nom_Centro_costo";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "SubCentro. de costo";
            this.gridColumn20.FieldName = "Nomsub_centro_costo";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Stock";
            this.gridColumn23.FieldName = "Stock";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.Width = 87;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Código";
            this.gridColumn24.FieldName = "cod_producto";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 6;
            this.gridColumn24.Width = 90;
            // 
            // col_checked_repro
            // 
            this.col_checked_repro.Caption = "R";
            this.col_checked_repro.FieldName = "Checked_REPRO";
            this.col_checked_repro.Name = "col_checked_repro";
            this.col_checked_repro.OptionsColumn.AllowEdit = false;
            this.col_checked_repro.Visible = true;
            this.col_checked_repro.VisibleIndex = 1;
            this.col_checked_repro.Width = 37;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Codigo";
            this.gridColumn11.FieldName = "IdPunto_cargo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Punto Cargo";
            this.gridColumn12.FieldName = "nom_punto_cargo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Estado";
            this.gridColumn13.FieldName = "Estado";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Codigo";
            this.gridColumn14.FieldName = "IdProveedor";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Proveedor";
            this.gridColumn15.FieldName = "pr_nombre";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Estado";
            this.gridColumn16.FieldName = "Estado";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 2;
            // 
            // FrmCom_SolicitudCompra_det_pre_Aprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.gbFiltroBusqueda);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCom_SolicitudCompra_det_pre_Aprobacion";
            this.Text = "FrmCom_SolicitudCompra_det_pre_Aprobacion";
            this.Load += new System.EventHandler(this.FrmCom_SolicitudCompra_det_pre_Aprobacion_Load);
            this.gbFiltroBusqueda.ResumeLayout(false);
            this.gbFiltroBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSolicitud_det_pre_Aprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitud_det_pre_Aprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Estado_Aprobacion_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdPunto_cargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private System.Windows.Forms.GroupBox gbFiltroBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Hasta;
        private System.Windows.Forms.Label lblFHasta;
        private System.Windows.Forms.Label lblFdesde;
        private System.Windows.Forms.DateTimePicker dtpFecha_desde;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlSolicitud_det_pre_Aprobacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Estado_Aprobacion_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_cmb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogocompra;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbIdPunto_cargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProveedor_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSolicitud_det_pre_Aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked_apro;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn col_checked_repro;
    }
}
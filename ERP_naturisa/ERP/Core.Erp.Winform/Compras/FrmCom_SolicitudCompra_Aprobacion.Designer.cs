namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_SolicitudCompra_Aprobacion
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.gbFiltroBusqueda = new System.Windows.Forms.GroupBox();
            this.ucGe_Sucursal_combo1 = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstadoAprobacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblestadoAprob = new System.Windows.Forms.Label();
            this.dtpFecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.lblFHasta = new System.Windows.Forms.Label();
            this.lblFdesde = new System.Windows.Forms.Label();
            this.dtpFecha_desde = new System.Windows.Forms.DateTimePicker();
            this.gridControl_solicitud_compra = new DevExpress.XtraGrid.GridControl();
            this.gridView_solicitud_com = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbEstadoAprobacion_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioAprobo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaHoraAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.gbFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_solicitud_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_solicitud_com)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.splitContainer_main);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 27);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1255, 463);
            this.panel_main.TabIndex = 2;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            this.splitContainer_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.gbFiltroBusqueda);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.gridControl_solicitud_compra);
            this.splitContainer_main.Size = new System.Drawing.Size(1255, 463);
            this.splitContainer_main.SplitterDistance = 104;
            this.splitContainer_main.TabIndex = 0;
            // 
            // gbFiltroBusqueda
            // 
            this.gbFiltroBusqueda.Controls.Add(this.ucGe_Sucursal_combo1);
            this.gbFiltroBusqueda.Controls.Add(this.label1);
            this.gbFiltroBusqueda.Controls.Add(this.btnBuscar);
            this.gbFiltroBusqueda.Controls.Add(this.cmbEstadoAprobacion);
            this.gbFiltroBusqueda.Controls.Add(this.lblestadoAprob);
            this.gbFiltroBusqueda.Controls.Add(this.dtpFecha_Hasta);
            this.gbFiltroBusqueda.Controls.Add(this.lblFHasta);
            this.gbFiltroBusqueda.Controls.Add(this.lblFdesde);
            this.gbFiltroBusqueda.Controls.Add(this.dtpFecha_desde);
            this.gbFiltroBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFiltroBusqueda.Location = new System.Drawing.Point(0, 0);
            this.gbFiltroBusqueda.Name = "gbFiltroBusqueda";
            this.gbFiltroBusqueda.Size = new System.Drawing.Size(1255, 104);
            this.gbFiltroBusqueda.TabIndex = 0;
            this.gbFiltroBusqueda.TabStop = false;
            this.gbFiltroBusqueda.Text = "Filtro de Busqueda";
            // 
            // ucGe_Sucursal_combo1
            // 
            this.ucGe_Sucursal_combo1.Location = new System.Drawing.Point(139, 18);
            this.ucGe_Sucursal_combo1.Name = "ucGe_Sucursal_combo1";
            this.ucGe_Sucursal_combo1.Size = new System.Drawing.Size(367, 22);
            this.ucGe_Sucursal_combo1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sucursal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(768, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstadoAprobacion
            // 
            this.cmbEstadoAprobacion.Location = new System.Drawing.Point(139, 53);
            this.cmbEstadoAprobacion.Name = "cmbEstadoAprobacion";
            this.cmbEstadoAprobacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAprobacion.Properties.DisplayMember = "descripcion";
            this.cmbEstadoAprobacion.Properties.ValueMember = "IdCatalogocompra";
            this.cmbEstadoAprobacion.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstadoAprobacion.Size = new System.Drawing.Size(367, 20);
            this.cmbEstadoAprobacion.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.coldescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "codigo";
            this.Id.FieldName = "IdCatalogocompra";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 118;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 1062;
            // 
            // lblestadoAprob
            // 
            this.lblestadoAprob.AutoSize = true;
            this.lblestadoAprob.Location = new System.Drawing.Point(18, 56);
            this.lblestadoAprob.Name = "lblestadoAprob";
            this.lblestadoAprob.Size = new System.Drawing.Size(115, 13);
            this.lblestadoAprob.TabIndex = 4;
            this.lblestadoAprob.Text = "Estado de Aprobacion:";
            // 
            // dtpFecha_Hasta
            // 
            this.dtpFecha_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Hasta.Location = new System.Drawing.Point(627, 56);
            this.dtpFecha_Hasta.Name = "dtpFecha_Hasta";
            this.dtpFecha_Hasta.Size = new System.Drawing.Size(116, 20);
            this.dtpFecha_Hasta.TabIndex = 3;
            // 
            // lblFHasta
            // 
            this.lblFHasta.AutoSize = true;
            this.lblFHasta.Location = new System.Drawing.Point(545, 63);
            this.lblFHasta.Name = "lblFHasta";
            this.lblFHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFHasta.TabIndex = 3;
            this.lblFHasta.Text = "Hasta:";
            // 
            // lblFdesde
            // 
            this.lblFdesde.AutoSize = true;
            this.lblFdesde.Location = new System.Drawing.Point(545, 28);
            this.lblFdesde.Name = "lblFdesde";
            this.lblFdesde.Size = new System.Drawing.Size(41, 13);
            this.lblFdesde.TabIndex = 2;
            this.lblFdesde.Text = "Desde:";
            // 
            // dtpFecha_desde
            // 
            this.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_desde.Location = new System.Drawing.Point(627, 22);
            this.dtpFecha_desde.Name = "dtpFecha_desde";
            this.dtpFecha_desde.Size = new System.Drawing.Size(116, 20);
            this.dtpFecha_desde.TabIndex = 2;
            // 
            // gridControl_solicitud_compra
            // 
            this.gridControl_solicitud_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_solicitud_compra.Location = new System.Drawing.Point(0, 0);
            this.gridControl_solicitud_compra.MainView = this.gridView_solicitud_com;
            this.gridControl_solicitud_compra.Name = "gridControl_solicitud_compra";
            this.gridControl_solicitud_compra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.cmbEstadoAprobacion_grid});
            this.gridControl_solicitud_compra.Size = new System.Drawing.Size(1255, 355);
            this.gridControl_solicitud_compra.TabIndex = 0;
            this.gridControl_solicitud_compra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_solicitud_com});
            this.gridControl_solicitud_compra.Click += new System.EventHandler(this.gridControl_solicitud_compra_Click);
            // 
            // gridView_solicitud_com
            // 
            this.gridView_solicitud_com.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSucursal,
            this.colIdSolicitudCompra,
            this.colSolicitante,
            this.colComprador,
            this.coldepartamento,
            this.colfecha,
            this.colobservacion,
            this.colEstado,
            this.colIdEstadoAprobacion,
            this.colIdUsuarioAprobo,
            this.colMotivoAprobacion,
            this.colFechaHoraAprobacion,
            this.colChecked,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView_solicitud_com.GridControl = this.gridControl_solicitud_compra;
            this.gridView_solicitud_com.Name = "gridView_solicitud_com";
            this.gridView_solicitud_com.OptionsFind.AlwaysVisible = true;
            this.gridView_solicitud_com.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView_solicitud_com.OptionsView.ShowAutoFilterRow = true;
            this.gridView_solicitud_com.OptionsView.ShowGroupPanel = false;
            this.gridView_solicitud_com.OptionsView.ShowViewCaption = true;
            this.gridView_solicitud_com.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_solicitud_com_RowClick);
            this.gridView_solicitud_com.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_solicitud_com_RowCellClick);
            this.gridView_solicitud_com.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_solicitud_com_RowCellStyle);
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 2;
            this.colSucursal.Width = 119;
            // 
            // colIdSolicitudCompra
            // 
            this.colIdSolicitudCompra.Caption = "#SolicitudCompra";
            this.colIdSolicitudCompra.FieldName = "IdSolicitudCompra";
            this.colIdSolicitudCompra.Name = "colIdSolicitudCompra";
            this.colIdSolicitudCompra.OptionsColumn.AllowEdit = false;
            this.colIdSolicitudCompra.Visible = true;
            this.colIdSolicitudCompra.VisibleIndex = 3;
            this.colIdSolicitudCompra.Width = 105;
            // 
            // colSolicitante
            // 
            this.colSolicitante.Caption = "Solicitante";
            this.colSolicitante.FieldName = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.OptionsColumn.AllowEdit = false;
            this.colSolicitante.Visible = true;
            this.colSolicitante.VisibleIndex = 4;
            this.colSolicitante.Width = 118;
            // 
            // colComprador
            // 
            this.colComprador.Caption = "Comprador";
            this.colComprador.FieldName = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.OptionsColumn.AllowEdit = false;
            this.colComprador.Width = 100;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 5;
            this.coldepartamento.Width = 123;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 6;
            this.colfecha.Width = 98;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observación";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.OptionsColumn.AllowEdit = false;
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 7;
            this.colobservacion.Width = 139;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 69;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.Caption = "Estado Aprobación";
            this.colIdEstadoAprobacion.ColumnEdit = this.cmbEstadoAprobacion_grid;
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 1;
            this.colIdEstadoAprobacion.Width = 105;
            // 
            // cmbEstadoAprobacion_grid
            // 
            this.cmbEstadoAprobacion_grid.AutoHeight = false;
            this.cmbEstadoAprobacion_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAprobacion_grid.DisplayMember = "descripcion";
            this.cmbEstadoAprobacion_grid.Name = "cmbEstadoAprobacion_grid";
            this.cmbEstadoAprobacion_grid.ValueMember = "IdCatalogocompra";
            this.cmbEstadoAprobacion_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion2});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "IdCatalogocompra";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "descripcion";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 1;
            // 
            // colIdUsuarioAprobo
            // 
            this.colIdUsuarioAprobo.Caption = "Usuario Aprobó";
            this.colIdUsuarioAprobo.FieldName = "IdUsuarioAprobo";
            this.colIdUsuarioAprobo.Name = "colIdUsuarioAprobo";
            this.colIdUsuarioAprobo.OptionsColumn.AllowEdit = false;
            this.colIdUsuarioAprobo.Visible = true;
            this.colIdUsuarioAprobo.VisibleIndex = 10;
            this.colIdUsuarioAprobo.Width = 93;
            // 
            // colMotivoAprobacion
            // 
            this.colMotivoAprobacion.Caption = "Motivo de Aprobación";
            this.colMotivoAprobacion.FieldName = "MotivoAprobacion";
            this.colMotivoAprobacion.Name = "colMotivoAprobacion";
            this.colMotivoAprobacion.Visible = true;
            this.colMotivoAprobacion.VisibleIndex = 11;
            this.colMotivoAprobacion.Width = 117;
            // 
            // colFechaHoraAprobacion
            // 
            this.colFechaHoraAprobacion.Caption = "Fecha/Aprobación";
            this.colFechaHoraAprobacion.FieldName = "FechaHoraAprobacion";
            this.colFechaHoraAprobacion.Name = "colFechaHoraAprobacion";
            this.colFechaHoraAprobacion.OptionsColumn.AllowEdit = false;
            this.colFechaHoraAprobacion.Visible = true;
            this.colFechaHoraAprobacion.VisibleIndex = 9;
            this.colFechaHoraAprobacion.Width = 128;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.AllowEdit = false;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 23;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado PreAprobacion";
            this.gridColumn1.ColumnEdit = this.cmbEstadoAprobacion_grid;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Comentario";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 13;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1255, 27);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = true;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 490);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1255, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // FrmCom_SolicitudCompra_Aprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 516);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmCom_SolicitudCompra_Aprobacion";
            this.Text = "Mantenimientos (Aprobaciones /Reprobaciones) Solicitud de Compra";
            this.Load += new System.EventHandler(this.FrmCom_SolicitudCompra_Aprobacion_Load);
            this.panel_main.ResumeLayout(false);
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.gbFiltroBusqueda.ResumeLayout(false);
            this.gbFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_solicitud_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_solicitud_com)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.GroupBox gbFiltroBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoAprobacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lblestadoAprob;
        private System.Windows.Forms.DateTimePicker dtpFecha_Hasta;
        private System.Windows.Forms.Label lblFHasta;
        private System.Windows.Forms.Label lblFdesde;
        private System.Windows.Forms.DateTimePicker dtpFecha_desde;
        private DevExpress.XtraGrid.GridControl gridControl_solicitud_compra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_solicitud_com;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colSolicitante;
        private DevExpress.XtraGrid.Columns.GridColumn colComprador;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioAprobo;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaHoraAprobacion;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbEstadoAprobacion_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
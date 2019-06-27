namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenPedidoAprobacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_OrdenPedidoAprobacion));
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gc_detalle = new DevExpress.XtraGrid.GridControl();
            this.gv_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_SucursalOrdigen = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_SucursalDestino = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_UnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_PuntoCargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtStock = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_R = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CantidadAprobada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_Reprobar = new DevExpress.XtraEditors.CheckEdit();
            this.chk_Aprobar = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Buscar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_search = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SucursalOrdigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SucursalDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PuntoCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Reprobar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_search)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1133, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAprobarGuardarSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobarGuardarSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // gc_detalle
            // 
            this.gc_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_detalle.Location = new System.Drawing.Point(0, 103);
            this.gc_detalle.MainView = this.gv_detalle;
            this.gc_detalle.Name = "gc_detalle";
            this.gc_detalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_SucursalOrdigen,
            this.cmb_SucursalDestino,
            this.cmb_PuntoCargo,
            this.cmb_UnidadMedida,
            this.txtStock,
            this.cmb_search});
            this.gc_detalle.Size = new System.Drawing.Size(1133, 627);
            this.gc_detalle.TabIndex = 3;
            this.gc_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_detalle});
            // 
            // gv_detalle
            // 
            this.gv_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.col_pr_descripcion,
            this.col_IdUnidadMedida,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn5,
            this.gridColumn21,
            this.col_A,
            this.col_R,
            this.col_CantidadAprobada,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn19,
            this.gridColumn20});
            this.gv_detalle.CustomizationFormBounds = new System.Drawing.Rectangle(978, 706, 218, 212);
            this.gv_detalle.GridControl = this.gc_detalle;
            this.gv_detalle.GroupCount = 2;
            this.gv_detalle.Images = this.imageList1;
            this.gv_detalle.Name = "gv_detalle";
            this.gv_detalle.OptionsBehavior.AutoExpandAllGroups = true;
            this.gv_detalle.OptionsView.ShowAutoFilterRow = true;
            this.gv_detalle.OptionsView.ShowFooter = true;
            this.gv_detalle.OptionsView.ShowGroupedColumns = true;
            this.gv_detalle.OptionsView.ShowGroupPanel = false;
            this.gv_detalle.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn19, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_detalle.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gv_detalle_RowCellStyle);
            this.gv_detalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_detalle_CellValueChanged);
            this.gv_detalle.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_detalle_CellValueChanging);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Origen";
            this.gridColumn3.ColumnEdit = this.cmb_SucursalOrdigen;
            this.gridColumn3.FieldName = "IdSucursalOrigen";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 108;
            // 
            // cmb_SucursalOrdigen
            // 
            this.cmb_SucursalOrdigen.AutoHeight = false;
            this.cmb_SucursalOrdigen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SucursalOrdigen.DisplayMember = "codigo";
            this.cmb_SucursalOrdigen.Name = "cmb_SucursalOrdigen";
            this.cmb_SucursalOrdigen.ValueMember = "IdSucursal";
            this.cmb_SucursalOrdigen.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "ID";
            this.gridColumn11.FieldName = "IdSucursal";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 224;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Sucursal";
            this.gridColumn12.FieldName = "Su_Descripcion";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 1288;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Código";
            this.gridColumn13.FieldName = "codigo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 222;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Destino";
            this.gridColumn4.ColumnEdit = this.cmb_SucursalDestino;
            this.gridColumn4.FieldName = "IdSucursalDestino";
            this.gridColumn4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 134;
            // 
            // cmb_SucursalDestino
            // 
            this.cmb_SucursalDestino.AutoHeight = false;
            this.cmb_SucursalDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_SucursalDestino.DisplayMember = "codigo";
            this.cmb_SucursalDestino.Name = "cmb_SucursalDestino";
            this.cmb_SucursalDestino.ValueMember = "IdSucursal";
            this.cmb_SucursalDestino.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "ID";
            this.gridColumn14.FieldName = "IdSucursal";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            this.gridColumn14.Width = 161;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Sucursal";
            this.gridColumn15.FieldName = "Su_Descripcion";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            this.gridColumn15.Width = 1340;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Código";
            this.gridColumn16.FieldName = "codigo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 2;
            this.gridColumn16.Width = 233;
            // 
            // col_pr_descripcion
            // 
            this.col_pr_descripcion.Caption = "Descripción";
            this.col_pr_descripcion.FieldName = "pr_descripcion";
            this.col_pr_descripcion.Name = "col_pr_descripcion";
            this.col_pr_descripcion.OptionsColumn.AllowEdit = false;
            this.col_pr_descripcion.Visible = true;
            this.col_pr_descripcion.VisibleIndex = 7;
            this.col_pr_descripcion.Width = 324;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "U.M";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_UnidadMedida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.OptionsColumn.AllowEdit = false;
            this.col_IdUnidadMedida.Visible = true;
            this.col_IdUnidadMedida.VisibleIndex = 11;
            this.col_IdUnidadMedida.Width = 92;
            // 
            // cmb_UnidadMedida
            // 
            this.cmb_UnidadMedida.AutoHeight = false;
            this.cmb_UnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_UnidadMedida.DisplayMember = "Descripcion";
            this.cmb_UnidadMedida.Name = "cmb_UnidadMedida";
            this.cmb_UnidadMedida.ValueMember = "IdUnidadMedida";
            this.cmb_UnidadMedida.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ID";
            this.gridColumn6.FieldName = "IdUnidadMedida";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 284;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Unidad de medida";
            this.gridColumn7.FieldName = "Descripcion";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 1450;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Cantidad";
            this.gridColumn8.FieldName = "opd_Cantidad";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 10;
            this.gridColumn8.Width = 93;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Detalle";
            this.gridColumn9.FieldName = "opd_Detalle";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 13;
            this.gridColumn9.Width = 258;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Punto de cargo";
            this.gridColumn10.ColumnEdit = this.cmb_PuntoCargo;
            this.gridColumn10.FieldName = "IdPunto_cargo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 135;
            // 
            // cmb_PuntoCargo
            // 
            this.cmb_PuntoCargo.AutoHeight = false;
            this.cmb_PuntoCargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_PuntoCargo.DisplayMember = "nom_punto_cargo";
            this.cmb_PuntoCargo.Name = "cmb_PuntoCargo";
            this.cmb_PuntoCargo.ValueMember = "IdPunto_cargo";
            this.cmb_PuntoCargo.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ID";
            this.gridColumn17.FieldName = "IdPunto_cargo";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 297;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Punto de cargo";
            this.gridColumn18.FieldName = "nom_punto_cargo";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 1437;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn5.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.Caption = "Stock";
            this.gridColumn5.ColumnEdit = this.txtStock;
            this.gridColumn5.FieldName = "Stock";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            this.gridColumn5.Width = 92;
            // 
            // txtStock
            // 
            this.txtStock.AutoHeight = false;
            this.txtStock.DisplayFormat.FormatString = "n2";
            this.txtStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.DoubleClick += new System.EventHandler(this.txtStock_DoubleClick);
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn21.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn21.AppearanceCell.Options.UseFont = true;
            this.gridColumn21.Caption = "U. Kardex";
            this.gridColumn21.ColumnEdit = this.cmb_UnidadMedida;
            this.gridColumn21.FieldName = "IdUnidadMedida_Consumo";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 9;
            this.gridColumn21.Width = 87;
            // 
            // col_A
            // 
            this.col_A.Caption = "A";
            this.col_A.FieldName = "A";
            this.col_A.Name = "col_A";
            this.col_A.Visible = true;
            this.col_A.VisibleIndex = 0;
            this.col_A.Width = 98;
            // 
            // col_R
            // 
            this.col_R.Caption = "R";
            this.col_R.FieldName = "R";
            this.col_R.Name = "col_R";
            this.col_R.Visible = true;
            this.col_R.VisibleIndex = 1;
            this.col_R.Width = 98;
            // 
            // col_CantidadAprobada
            // 
            this.col_CantidadAprobada.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.col_CantidadAprobada.AppearanceCell.Options.UseBackColor = true;
            this.col_CantidadAprobada.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.col_CantidadAprobada.AppearanceHeader.Options.UseFont = true;
            this.col_CantidadAprobada.Caption = "C. Aprobado";
            this.col_CantidadAprobada.FieldName = "opd_CantidadApro";
            this.col_CantidadAprobada.Name = "col_CantidadAprobada";
            this.col_CantidadAprobada.Visible = true;
            this.col_CantidadAprobada.VisibleIndex = 12;
            this.col_CantidadAprobada.Width = 98;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Solicitante";
            this.gridColumn1.FieldName = "nom_solicitante";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Width = 117;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Pedido";
            this.gridColumn2.FieldName = "IdOrdenPedido";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "op_Observacion";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_Reprobar);
            this.panel1.Controls.Add(this.chk_Aprobar);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 74);
            this.panel1.TabIndex = 4;
            // 
            // chk_Reprobar
            // 
            this.chk_Reprobar.Location = new System.Drawing.Point(169, 37);
            this.chk_Reprobar.Name = "chk_Reprobar";
            this.chk_Reprobar.Properties.Caption = "Reprobar visibles";
            this.chk_Reprobar.Size = new System.Drawing.Size(136, 21);
            this.chk_Reprobar.TabIndex = 6;
            this.chk_Reprobar.CheckedChanged += new System.EventHandler(this.chk_Reprobar_CheckedChanged);
            // 
            // chk_Aprobar
            // 
            this.chk_Aprobar.Location = new System.Drawing.Point(25, 37);
            this.chk_Aprobar.Name = "chk_Aprobar";
            this.chk_Aprobar.Properties.Caption = "Aprobar visibles";
            this.chk_Aprobar.Size = new System.Drawing.Size(127, 21);
            this.chk_Aprobar.TabIndex = 5;
            this.chk_Aprobar.CheckedChanged += new System.EventHandler(this.chk_Aprobar_CheckedChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(518, 11);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(105, 47);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_-_Magnifier-Search-Zoom-_3844432.png");
            // 
            // cmb_search
            // 
            this.cmb_search.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_search.AutoHeight = false;
            this.cmb_search.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_search.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_search.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.ReadOnly = true;
            this.cmb_search.SmallImages = this.imageList1;
            this.cmb_search.Click += new System.EventHandler(this.cmb_search_Click);
            // 
            // gridColumn20
            // 
            this.gridColumn20.ColumnEdit = this.cmb_search;
            this.gridColumn20.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn20.ImageIndex = 0;
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 4;
            // 
            // FrmCom_OrdenPedidoAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 730);
            this.Controls.Add(this.gc_detalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmCom_OrdenPedidoAprobacion";
            this.Text = "Aprobación de solicitud de pedido";
            this.Load += new System.EventHandler(this.FrmCom_OrdenPedidoAprobacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SucursalOrdigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SucursalDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PuntoCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_Reprobar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Aprobar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.GridControl gc_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_SucursalOrdigen;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_SucursalDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_UnidadMedida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_PuntoCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn col_A;
        private DevExpress.XtraGrid.Columns.GridColumn col_R;
        private DevExpress.XtraEditors.SimpleButton btn_Buscar;
        private DevExpress.XtraGrid.Columns.GridColumn col_CantidadAprobada;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.CheckEdit chk_Reprobar;
        private DevExpress.XtraEditors.CheckEdit chk_Aprobar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_search;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}
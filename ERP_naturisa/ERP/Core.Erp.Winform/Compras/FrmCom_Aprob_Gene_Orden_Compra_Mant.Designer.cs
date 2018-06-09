namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Aprob_Gene_Orden_Compra_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_Aprob_Gene_Orden_Compra_Mant));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colEstado_gridp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComprador = new Core.Erp.Winform.Controles.UCCom_Comprador();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstAproSC = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colChecked_Estado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdSolicitudCompra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcmb_Estado_AproSC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_EstadoAproSC = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageListEstadoAprobSC = new System.Windows.Forms.ImageList(this.components);
            this.colcmb_Estado_PreApro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_EstadoPreAprob = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colcmb_OrdenCompra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_OrdenCompra = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colChecked = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdSucursal_grid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfecha = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colComprador = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdPersona_Solicita = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdPersona_comprador = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colplazo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfecha_vtc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEstado_gridSC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSolicitante = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdUsuarioAprobo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMotivoAprobo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFechaHoraAprobacion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnom_producto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcant_aprobada_OC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSaldo_cant_SolCom_AUX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcant_aprobada_OC_AUX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdEstadoAprobacion_AUX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_observacion2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colcmbProveedor_grid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbProveedor_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbUniMedida_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_grid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_grid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdPunto_cargo_grid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbIdPunto_cargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcmbIdPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_grid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco1_editar = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colIco2_insertar = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSaldo_cant_SolCom = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcant_solicitada = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colcant_ing_SolCom = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_do_precioCompra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_porc_des = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_descuento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_subtotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_iva = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_total = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldo_observacion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIdMotivo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbMotivo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMotivo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_centro_costo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomsub_centro_costo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmb_sub_centro_grid = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colReferencia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcant_ing_SolCom_AUX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIdCodImpuesto_Iva = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cmbImpuesto_Iva = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCod_Impuesto_cmb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageListAgregarEdit = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_Estado_OC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstPreAproSC = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.splitContainerDetalle = new System.Windows.Forms.SplitContainer();
            this.toolStripMenuGrid = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImprimir = new System.Windows.Forms.ToolStripButton();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.colStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstAproSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_EstadoAproSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_EstadoPreAprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUniMedida_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdPunto_cargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImpuesto_Iva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstPreAproSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetalle)).BeginInit();
            this.splitContainerDetalle.Panel1.SuspendLayout();
            this.splitContainerDetalle.Panel2.SuspendLayout();
            this.splitContainerDetalle.SuspendLayout();
            this.toolStripMenuGrid.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // colEstado_gridp
            // 
            this.colEstado_gridp.Caption = "Estado";
            this.colEstado_gridp.FieldName = "pr_estado";
            this.colEstado_gridp.Name = "colEstado_gridp";
            this.colEstado_gridp.Visible = true;
            this.colEstado_gridp.VisibleIndex = 2;
            this.colEstado_gridp.Width = 187;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaIni);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 49);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo:";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(53, 21);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaIni.TabIndex = 14;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(239, 19);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desde:";
            // 
            // cmbComprador
            // 
            this.cmbComprador.Location = new System.Drawing.Point(580, 16);
            this.cmbComprador.Name = "cmbComprador";
            this.cmbComprador.Size = new System.Drawing.Size(337, 26);
            this.cmbComprador.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Comprador:";
            // 
            // cmbEstAproSC
            // 
            this.cmbEstAproSC.Location = new System.Drawing.Point(388, 19);
            this.cmbEstAproSC.Name = "cmbEstAproSC";
            this.cmbEstAproSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstAproSC.Properties.DisplayMember = "descripcion";
            this.cmbEstAproSC.Properties.ValueMember = "Id";
            this.cmbEstAproSC.Properties.View = this.searchLookUpEdit2View;
            this.cmbEstAproSC.Size = new System.Drawing.Size(186, 20);
            this.cmbEstAproSC.TabIndex = 15;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colEstado_3,
            this.colId});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 754;
            // 
            // colEstado_3
            // 
            this.colEstado_3.Caption = "Estado";
            this.colEstado_3.FieldName = "Estado";
            this.colEstado_3.Name = "colEstado_3";
            this.colEstado_3.Visible = true;
            this.colEstado_3.VisibleIndex = 2;
            this.colEstado_3.Width = 214;
            // 
            // colId
            // 
            this.colId.Caption = "Código";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 212;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Estado Aprobacion";
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProveedor_grid,
            this.cmbIdPunto_cargo_grid,
            this.cmbMotivo_grid,
            this.cmbUniMedida_grid,
            this.cmb_centro_costo_grid,
            this.cmb_sub_centro_grid,
            this.repositoryItemPictureEdit1,
            this.repositoryItemPictureEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.cmb_EstadoAproSC,
            this.cmb_EstadoPreAprob,
            this.cmb_OrdenCompra,
            this.cmbImpuesto_Iva});
            this.gridControlConsulta.Size = new System.Drawing.Size(1122, 304);
            this.gridControlConsulta.TabIndex = 0;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand4,
            this.gridBand3});
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colcmb_Estado_AproSC,
            this.colcmb_Estado_PreApro,
            this.colcmb_OrdenCompra,
            this.colcmbProveedor_grid,
            this.colIdEmpresa,
            this.colIdSucursal_grid,
            this.colIdSolicitudCompra,
            this.colNumDocumento,
            this.colIdPersona_Solicita,
            this.colIdPersona_comprador,
            this.colIdDepartamento,
            this.colfecha,
            this.colplazo,
            this.colfecha_vtc,
            this.colobservacion,
            this.colEstado_gridSC,
            this.colSucursal,
            this.colSolicitante,
            this.colComprador,
            this.coldepartamento,
            this.colIdUsuarioAprobo,
            this.colMotivoAprobo,
            this.colFechaHoraAprobacion,
            this.colSecuencia,
            this.colIdProducto,
            this.colNomProducto,
            this.colcod_producto,
            this.colnom_producto,
            this.colIdCentroCosto,
            this.colIdCentroCosto_sub_centro_costo,
            this.colChecked,
            this.colIdPunto_cargo_grid,
            this.colcant_aprobada_OC,
            this.colSaldo_cant_SolCom,
            this.colSaldo_cant_SolCom_AUX,
            this.colcant_aprobada_OC_AUX,
            this.colIdEstadoAprobacion_AUX,
            this.colcant_ing_SolCom,
            this.colIdMotivo,
            this.colIdUnidadMedida,
            this.col_do_precioCompra,
            this.coldo_porc_des,
            this.coldo_descuento,
            this.coldo_subtotal,
            this.coldo_iva,
            this.colNomsub_centro_costo,
            this.coldo_observacion2,
            this.colIco2_insertar,
            this.colIco1_editar,
            this.colChecked_Estado,
            this.colcant_ing_SolCom_AUX,
            this.colReferencia,
            this.coldo_observacion,
            this.colcant_solicitada,
            this.coldo_total,
            this.colIdCodImpuesto_Iva,
            this.colStock});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.GroupCount = 1;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewConsulta.OptionsView.ColumnAutoWidth = true;
            this.gridViewConsulta.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowFooter = true;
            this.gridViewConsulta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReferencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewConsulta_RowClick);
            this.gridViewConsulta.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewConsulta_CustomDrawCell);
            this.gridViewConsulta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewConsulta_FocusedRowChanged);
            this.gridViewConsulta.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConsulta_CellValueChanged);
            this.gridViewConsulta.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConsulta_CellValueChanging);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Info. Solicitud Compra";
            this.gridBand1.Columns.Add(this.colChecked_Estado);
            this.gridBand1.Columns.Add(this.colIdSolicitudCompra);
            this.gridBand1.Columns.Add(this.colcmb_Estado_AproSC);
            this.gridBand1.Columns.Add(this.colcmb_Estado_PreApro);
            this.gridBand1.Columns.Add(this.colcmb_OrdenCompra);
            this.gridBand1.Columns.Add(this.colChecked);
            this.gridBand1.Columns.Add(this.colSucursal);
            this.gridBand1.Columns.Add(this.colIdEmpresa);
            this.gridBand1.Columns.Add(this.colIdSucursal_grid);
            this.gridBand1.Columns.Add(this.colfecha);
            this.gridBand1.Columns.Add(this.colComprador);
            this.gridBand1.Columns.Add(this.colNumDocumento);
            this.gridBand1.Columns.Add(this.colIdPersona_Solicita);
            this.gridBand1.Columns.Add(this.colIdPersona_comprador);
            this.gridBand1.Columns.Add(this.colIdDepartamento);
            this.gridBand1.Columns.Add(this.colplazo);
            this.gridBand1.Columns.Add(this.colfecha_vtc);
            this.gridBand1.Columns.Add(this.colobservacion);
            this.gridBand1.Columns.Add(this.colEstado_gridSC);
            this.gridBand1.Columns.Add(this.colSolicitante);
            this.gridBand1.Columns.Add(this.coldepartamento);
            this.gridBand1.Columns.Add(this.colIdUsuarioAprobo);
            this.gridBand1.Columns.Add(this.colMotivoAprobo);
            this.gridBand1.Columns.Add(this.colFechaHoraAprobacion);
            this.gridBand1.Columns.Add(this.colSecuencia);
            this.gridBand1.Columns.Add(this.colIdProducto);
            this.gridBand1.Columns.Add(this.colcod_producto);
            this.gridBand1.Columns.Add(this.colnom_producto);
            this.gridBand1.Columns.Add(this.colIdCentroCosto_sub_centro_costo);
            this.gridBand1.Columns.Add(this.colcant_aprobada_OC);
            this.gridBand1.Columns.Add(this.colSaldo_cant_SolCom_AUX);
            this.gridBand1.Columns.Add(this.colcant_aprobada_OC_AUX);
            this.gridBand1.Columns.Add(this.colIdEstadoAprobacion_AUX);
            this.gridBand1.Columns.Add(this.coldo_observacion2);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.AllowMove = false;
            this.gridBand1.Width = 405;
            // 
            // colChecked_Estado
            // 
            this.colChecked_Estado.Caption = "*";
            this.colChecked_Estado.FieldName = "Checked_Estado";
            this.colChecked_Estado.Name = "colChecked_Estado";
            this.colChecked_Estado.OptionsColumn.AllowEdit = false;
            this.colChecked_Estado.Visible = true;
            this.colChecked_Estado.Width = 60;
            // 
            // colIdSolicitudCompra
            // 
            this.colIdSolicitudCompra.Caption = "# S/C";
            this.colIdSolicitudCompra.FieldName = "IdSolicitudCompra";
            this.colIdSolicitudCompra.Name = "colIdSolicitudCompra";
            this.colIdSolicitudCompra.OptionsColumn.AllowEdit = false;
            this.colIdSolicitudCompra.Visible = true;
            this.colIdSolicitudCompra.Width = 63;
            // 
            // colcmb_Estado_AproSC
            // 
            this.colcmb_Estado_AproSC.Caption = "Est.  S/C";
            this.colcmb_Estado_AproSC.ColumnEdit = this.cmb_EstadoAproSC;
            this.colcmb_Estado_AproSC.FieldName = "IdEstadoAprobacion";
            this.colcmb_Estado_AproSC.Name = "colcmb_Estado_AproSC";
            this.colcmb_Estado_AproSC.Visible = true;
            // 
            // cmb_EstadoAproSC
            // 
            this.cmb_EstadoAproSC.AutoHeight = false;
            this.cmb_EstadoAproSC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_EstadoAproSC.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("APRO", "APR_SOL", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PEND", "PEN_SOL", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("REPRO", "REP_SOL", 5)});
            this.cmb_EstadoAproSC.LargeImages = this.imageListEstadoAprobSC;
            this.cmb_EstadoAproSC.Name = "cmb_EstadoAproSC";
            this.cmb_EstadoAproSC.SmallImages = this.imageListEstadoAprobSC;
            // 
            // imageListEstadoAprobSC
            // 
            this.imageListEstadoAprobSC.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEstadoAprobSC.ImageStream")));
            this.imageListEstadoAprobSC.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEstadoAprobSC.Images.SetKeyName(0, "Aprobado.ico");
            this.imageListEstadoAprobSC.Images.SetKeyName(1, "PreAprobado.ico");
            this.imageListEstadoAprobSC.Images.SetKeyName(2, "Pendiente.ico");
            this.imageListEstadoAprobSC.Images.SetKeyName(3, "OrdenCompra.ico");
            this.imageListEstadoAprobSC.Images.SetKeyName(4, "Enviar.ico");
            this.imageListEstadoAprobSC.Images.SetKeyName(5, "Negado.png");
            // 
            // colcmb_Estado_PreApro
            // 
            this.colcmb_Estado_PreApro.Caption = "Est. PreApr";
            this.colcmb_Estado_PreApro.ColumnEdit = this.cmb_EstadoPreAprob;
            this.colcmb_Estado_PreApro.FieldName = "IdEstadoPreAprobacion";
            this.colcmb_Estado_PreApro.Name = "colcmb_Estado_PreApro";
            this.colcmb_Estado_PreApro.OptionsColumn.ReadOnly = true;
            this.colcmb_Estado_PreApro.Visible = true;
            this.colcmb_Estado_PreApro.Width = 86;
            // 
            // cmb_EstadoPreAprob
            // 
            this.cmb_EstadoPreAprob.AutoHeight = false;
            this.cmb_EstadoPreAprob.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_EstadoPreAprob.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("APRO", "APR_SOL", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PEND", "PEN_SOL", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("REPRO", "REP_SOL", 5)});
            this.cmb_EstadoPreAprob.LargeImages = this.imageListEstadoAprobSC;
            this.cmb_EstadoPreAprob.Name = "cmb_EstadoPreAprob";
            this.cmb_EstadoPreAprob.SmallImages = this.imageListEstadoAprobSC;
            // 
            // colcmb_OrdenCompra
            // 
            this.colcmb_OrdenCompra.Caption = "OC";
            this.colcmb_OrdenCompra.ColumnEdit = this.cmb_OrdenCompra;
            this.colcmb_OrdenCompra.FieldName = "Tiene_OC";
            this.colcmb_OrdenCompra.Name = "colcmb_OrdenCompra";
            this.colcmb_OrdenCompra.OptionsColumn.AllowEdit = false;
            this.colcmb_OrdenCompra.Width = 29;
            // 
            // cmb_OrdenCompra
            // 
            this.cmb_OrdenCompra.AutoHeight = false;
            this.cmb_OrdenCompra.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_OrdenCompra.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 3)});
            this.cmb_OrdenCompra.LargeImages = this.imageListEstadoAprobSC;
            this.cmb_OrdenCompra.Name = "cmb_OrdenCompra";
            this.cmb_OrdenCompra.SmallImages = this.imageListEstadoAprobSC;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.AllowEdit = false;
            this.colChecked.Width = 41;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.AllowEdit = false;
            this.colSucursal.Width = 61;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal_grid
            // 
            this.colIdSucursal_grid.FieldName = "IdSucursal";
            this.colIdSucursal_grid.Name = "colIdSucursal_grid";
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Width = 63;
            // 
            // colComprador
            // 
            this.colComprador.FieldName = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.OptionsColumn.AllowEdit = false;
            this.colComprador.Width = 107;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Width = 87;
            // 
            // colIdPersona_Solicita
            // 
            this.colIdPersona_Solicita.FieldName = "IdPersona_Solicita";
            this.colIdPersona_Solicita.Name = "colIdPersona_Solicita";
            this.colIdPersona_Solicita.Width = 100;
            // 
            // colIdPersona_comprador
            // 
            this.colIdPersona_comprador.FieldName = "IdPersona_comprador";
            this.colIdPersona_comprador.Name = "colIdPersona_comprador";
            this.colIdPersona_comprador.Width = 118;
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.Width = 91;
            // 
            // colplazo
            // 
            this.colplazo.FieldName = "plazo";
            this.colplazo.Name = "colplazo";
            // 
            // colfecha_vtc
            // 
            this.colfecha_vtc.FieldName = "fecha_vtc";
            this.colfecha_vtc.Name = "colfecha_vtc";
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observación S/C";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.OptionsColumn.AllowEdit = false;
            this.colobservacion.Width = 89;
            // 
            // colEstado_gridSC
            // 
            this.colEstado_gridSC.FieldName = "Estado";
            this.colEstado_gridSC.Name = "colEstado_gridSC";
            // 
            // colSolicitante
            // 
            this.colSolicitante.FieldName = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.Visible = true;
            this.colSolicitante.Width = 121;
            // 
            // coldepartamento
            // 
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Width = 77;
            // 
            // colIdUsuarioAprobo
            // 
            this.colIdUsuarioAprobo.FieldName = "IdUsuarioAprobo";
            this.colIdUsuarioAprobo.Name = "colIdUsuarioAprobo";
            this.colIdUsuarioAprobo.Width = 96;
            // 
            // colMotivoAprobo
            // 
            this.colMotivoAprobo.FieldName = "MotivoAprobo";
            this.colMotivoAprobo.Name = "colMotivoAprobo";
            this.colMotivoAprobo.Width = 79;
            // 
            // colFechaHoraAprobacion
            // 
            this.colFechaHoraAprobacion.FieldName = "FechaHoraAprobacion";
            this.colFechaHoraAprobacion.Name = "colFechaHoraAprobacion";
            this.colFechaHoraAprobacion.Width = 121;
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
            // colcod_producto
            // 
            this.colcod_producto.FieldName = "cod_producto";
            this.colcod_producto.Name = "colcod_producto";
            // 
            // colnom_producto
            // 
            this.colnom_producto.FieldName = "nom_producto";
            this.colnom_producto.Name = "colnom_producto";
            this.colnom_producto.Width = 78;
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "Sub Centro  Costo";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Width = 104;
            // 
            // colcant_aprobada_OC
            // 
            this.colcant_aprobada_OC.Caption = "Cant. Aprobada OC";
            this.colcant_aprobada_OC.FieldName = "cant_aprobada_OC";
            this.colcant_aprobada_OC.Name = "colcant_aprobada_OC";
            this.colcant_aprobada_OC.OptionsColumn.AllowEdit = false;
            this.colcant_aprobada_OC.Width = 104;
            // 
            // colSaldo_cant_SolCom_AUX
            // 
            this.colSaldo_cant_SolCom_AUX.FieldName = "Saldo_cant_SolCom_AUX";
            this.colSaldo_cant_SolCom_AUX.Name = "colSaldo_cant_SolCom_AUX";
            this.colSaldo_cant_SolCom_AUX.Width = 132;
            // 
            // colcant_aprobada_OC_AUX
            // 
            this.colcant_aprobada_OC_AUX.FieldName = "cant_aprobada_OC_AUX";
            this.colcant_aprobada_OC_AUX.Name = "colcant_aprobada_OC_AUX";
            this.colcant_aprobada_OC_AUX.Width = 129;
            // 
            // colIdEstadoAprobacion_AUX
            // 
            this.colIdEstadoAprobacion_AUX.FieldName = "IdEstadoAprobacion_AUX";
            this.colIdEstadoAprobacion_AUX.Name = "colIdEstadoAprobacion_AUX";
            this.colIdEstadoAprobacion_AUX.Width = 138;
            // 
            // coldo_observacion2
            // 
            this.coldo_observacion2.Caption = "Detalle x Items2";
            this.coldo_observacion2.FieldName = "do_observacion";
            this.coldo_observacion2.Name = "coldo_observacion2";
            this.coldo_observacion2.Width = 87;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Info Detalle Producto";
            this.gridBand2.Columns.Add(this.colcmbProveedor_grid);
            this.gridBand2.Columns.Add(this.colIdUnidadMedida);
            this.gridBand2.Columns.Add(this.colNomProducto);
            this.gridBand2.Columns.Add(this.colIdPunto_cargo_grid);
            this.gridBand2.Columns.Add(this.colIco1_editar);
            this.gridBand2.Columns.Add(this.colIco2_insertar);
            this.gridBand2.Columns.Add(this.colSaldo_cant_SolCom);
            this.gridBand2.Columns.Add(this.colcant_solicitada);
            this.gridBand2.Columns.Add(this.colStock);
            this.gridBand2.Columns.Add(this.colcant_ing_SolCom);
            this.gridBand2.Columns.Add(this.col_do_precioCompra);
            this.gridBand2.Columns.Add(this.coldo_porc_des);
            this.gridBand2.Columns.Add(this.coldo_descuento);
            this.gridBand2.Columns.Add(this.coldo_subtotal);
            this.gridBand2.Columns.Add(this.coldo_iva);
            this.gridBand2.Columns.Add(this.coldo_total);
            this.gridBand2.Columns.Add(this.coldo_observacion);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 1326;
            // 
            // colcmbProveedor_grid
            // 
            this.colcmbProveedor_grid.Caption = "Proveedor";
            this.colcmbProveedor_grid.ColumnEdit = this.cmbProveedor_grid;
            this.colcmbProveedor_grid.FieldName = "IdProveedor";
            this.colcmbProveedor_grid.Name = "colcmbProveedor_grid";
            this.colcmbProveedor_grid.Visible = true;
            this.colcmbProveedor_grid.Width = 147;
            // 
            // cmbProveedor_grid
            // 
            this.cmbProveedor_grid.AutoHeight = false;
            this.cmbProveedor_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor_grid.DisplayMember = "pr_nombre";
            this.cmbProveedor_grid.Name = "cmbProveedor_grid";
            this.cmbProveedor_grid.ValueMember = "IdProveedor";
            this.cmbProveedor_grid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor_grid,
            this.colpr_nombre_grid,
            this.colEstado_gridp});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colEstado_gridp;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "I";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProveedor_grid
            // 
            this.colIdProveedor_grid.Caption = "Código";
            this.colIdProveedor_grid.FieldName = "IdProveedor";
            this.colIdProveedor_grid.Name = "colIdProveedor_grid";
            this.colIdProveedor_grid.Visible = true;
            this.colIdProveedor_grid.VisibleIndex = 1;
            this.colIdProveedor_grid.Width = 184;
            // 
            // colpr_nombre_grid
            // 
            this.colpr_nombre_grid.Caption = "Nombre";
            this.colpr_nombre_grid.FieldName = "pr_nombre";
            this.colpr_nombre_grid.Name = "colpr_nombre_grid";
            this.colpr_nombre_grid.Visible = true;
            this.colpr_nombre_grid.VisibleIndex = 0;
            this.colpr_nombre_grid.Width = 809;
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.Caption = "U.Medida";
            this.colIdUnidadMedida.ColumnEdit = this.cmbUniMedida_grid;
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Visible = true;
            // 
            // cmbUniMedida_grid
            // 
            this.cmbUniMedida_grid.AutoHeight = false;
            this.cmbUniMedida_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUniMedida_grid.Name = "cmbUniMedida_grid";
            this.cmbUniMedida_grid.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida_grid,
            this.colDescripcion_grid2,
            this.colEstado_grid3});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida_grid
            // 
            this.colIdUnidadMedida_grid.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida_grid.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida_grid.Name = "colIdUnidadMedida_grid";
            this.colIdUnidadMedida_grid.Visible = true;
            this.colIdUnidadMedida_grid.VisibleIndex = 1;
            this.colIdUnidadMedida_grid.Width = 221;
            // 
            // colDescripcion_grid2
            // 
            this.colDescripcion_grid2.Caption = "Descripción";
            this.colDescripcion_grid2.FieldName = "Descripcion";
            this.colDescripcion_grid2.Name = "colDescripcion_grid2";
            this.colDescripcion_grid2.Visible = true;
            this.colDescripcion_grid2.VisibleIndex = 0;
            this.colDescripcion_grid2.Width = 736;
            // 
            // colEstado_grid3
            // 
            this.colEstado_grid3.Caption = "Estado";
            this.colEstado_grid3.FieldName = "Estado";
            this.colEstado_grid3.Name = "colEstado_grid3";
            this.colEstado_grid3.Visible = true;
            this.colEstado_grid3.VisibleIndex = 2;
            this.colEstado_grid3.Width = 223;
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.OptionsColumn.AllowEdit = false;
            this.colNomProducto.Visible = true;
            this.colNomProducto.Width = 170;
            // 
            // colIdPunto_cargo_grid
            // 
            this.colIdPunto_cargo_grid.Caption = "Punto Cargo";
            this.colIdPunto_cargo_grid.ColumnEdit = this.cmbIdPunto_cargo_grid;
            this.colIdPunto_cargo_grid.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo_grid.Name = "colIdPunto_cargo_grid";
            this.colIdPunto_cargo_grid.OptionsColumn.AllowEdit = false;
            this.colIdPunto_cargo_grid.OptionsColumn.ReadOnly = true;
            this.colIdPunto_cargo_grid.Visible = true;
            this.colIdPunto_cargo_grid.Width = 118;
            // 
            // cmbIdPunto_cargo_grid
            // 
            this.cmbIdPunto_cargo_grid.AutoHeight = false;
            this.cmbIdPunto_cargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIdPunto_cargo_grid.DisplayMember = "nom_punto_cargo";
            this.cmbIdPunto_cargo_grid.Name = "cmbIdPunto_cargo_grid";
            this.cmbIdPunto_cargo_grid.ValueMember = "IdPunto_cargo";
            this.cmbIdPunto_cargo_grid.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcmbIdPunto_cargo,
            this.colnom_punto_cargo,
            this.colEstado_grid2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colcmbIdPunto_cargo
            // 
            this.colcmbIdPunto_cargo.Caption = "Código";
            this.colcmbIdPunto_cargo.FieldName = "IdPunto_cargo";
            this.colcmbIdPunto_cargo.Name = "colcmbIdPunto_cargo";
            this.colcmbIdPunto_cargo.Visible = true;
            this.colcmbIdPunto_cargo.VisibleIndex = 1;
            this.colcmbIdPunto_cargo.Width = 210;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Descripción";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 0;
            this.colnom_punto_cargo.Width = 758;
            // 
            // colEstado_grid2
            // 
            this.colEstado_grid2.Caption = "Estado";
            this.colEstado_grid2.FieldName = "Estado";
            this.colEstado_grid2.Name = "colEstado_grid2";
            this.colEstado_grid2.Visible = true;
            this.colEstado_grid2.VisibleIndex = 2;
            this.colEstado_grid2.Width = 212;
            // 
            // colIco1_editar
            // 
            this.colIco1_editar.Caption = "Editar";
            this.colIco1_editar.ColumnEdit = this.repositoryItemPictureEdit2;
            this.colIco1_editar.FieldName = "Ico1";
            this.colIco1_editar.Name = "colIco1_editar";
            this.colIco1_editar.OptionsColumn.AllowEdit = false;
            this.colIco1_editar.OptionsColumn.AllowSize = false;
            this.colIco1_editar.OptionsColumn.ReadOnly = true;
            this.colIco1_editar.OptionsColumn.ShowCaption = false;
            this.colIco1_editar.Visible = true;
            this.colIco1_editar.Width = 44;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // colIco2_insertar
            // 
            this.colIco2_insertar.Caption = "Insertar";
            this.colIco2_insertar.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIco2_insertar.FieldName = "Ico2";
            this.colIco2_insertar.Name = "colIco2_insertar";
            this.colIco2_insertar.OptionsColumn.AllowEdit = false;
            this.colIco2_insertar.OptionsColumn.AllowSize = false;
            this.colIco2_insertar.OptionsColumn.ReadOnly = true;
            this.colIco2_insertar.OptionsColumn.ShowCaption = false;
            this.colIco2_insertar.Visible = true;
            this.colIco2_insertar.Width = 45;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colSaldo_cant_SolCom
            // 
            this.colSaldo_cant_SolCom.Caption = "Saldo";
            this.colSaldo_cant_SolCom.FieldName = "Saldo_cant_SolCom";
            this.colSaldo_cant_SolCom.Name = "colSaldo_cant_SolCom";
            this.colSaldo_cant_SolCom.OptionsColumn.AllowEdit = false;
            this.colSaldo_cant_SolCom.Width = 38;
            // 
            // colcant_solicitada
            // 
            this.colcant_solicitada.Caption = "Cant. Solicitada";
            this.colcant_solicitada.ColumnEdit = this.repositoryItemTextEdit1;
            this.colcant_solicitada.FieldName = "cant_solicitada";
            this.colcant_solicitada.Name = "colcant_solicitada";
            this.colcant_solicitada.OptionsColumn.AllowEdit = false;
            this.colcant_solicitada.Visible = true;
            this.colcant_solicitada.Width = 85;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "$ #,#######0.00000;$ #,#######0.00000";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colcant_ing_SolCom
            // 
            this.colcant_ing_SolCom.Caption = "Cant/Ing/Apro.";
            this.colcant_ing_SolCom.ColumnEdit = this.repositoryItemTextEdit2;
            this.colcant_ing_SolCom.FieldName = "cant_ing_SolCom";
            this.colcant_ing_SolCom.Name = "colcant_ing_SolCom";
            this.colcant_ing_SolCom.Visible = true;
            this.colcant_ing_SolCom.Width = 80;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = " #,#######0.00; #,#######0.00";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // col_do_precioCompra
            // 
            this.col_do_precioCompra.Caption = "Precio";
            this.col_do_precioCompra.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_do_precioCompra.FieldName = "do_precioCompra";
            this.col_do_precioCompra.Name = "col_do_precioCompra";
            this.col_do_precioCompra.Visible = true;
            this.col_do_precioCompra.Width = 72;
            // 
            // coldo_porc_des
            // 
            this.coldo_porc_des.Caption = "% Desc.";
            this.coldo_porc_des.ColumnEdit = this.repositoryItemTextEdit2;
            this.coldo_porc_des.FieldName = "do_porc_des";
            this.coldo_porc_des.Name = "coldo_porc_des";
            this.coldo_porc_des.Visible = true;
            this.coldo_porc_des.Width = 73;
            // 
            // coldo_descuento
            // 
            this.coldo_descuento.Caption = "Descuento";
            this.coldo_descuento.FieldName = "do_descuento";
            this.coldo_descuento.Name = "coldo_descuento";
            this.coldo_descuento.OptionsColumn.AllowEdit = false;
            this.coldo_descuento.Visible = true;
            this.coldo_descuento.Width = 80;
            // 
            // coldo_subtotal
            // 
            this.coldo_subtotal.Caption = "Subtotal";
            this.coldo_subtotal.FieldName = "do_subtotal";
            this.coldo_subtotal.Name = "coldo_subtotal";
            this.coldo_subtotal.OptionsColumn.AllowEdit = false;
            this.coldo_subtotal.Visible = true;
            this.coldo_subtotal.Width = 97;
            // 
            // coldo_iva
            // 
            this.coldo_iva.Caption = "Iva";
            this.coldo_iva.FieldName = "do_iva";
            this.coldo_iva.Name = "coldo_iva";
            this.coldo_iva.OptionsColumn.AllowEdit = false;
            this.coldo_iva.Visible = true;
            this.coldo_iva.Width = 89;
            // 
            // coldo_total
            // 
            this.coldo_total.Caption = "Total";
            this.coldo_total.FieldName = "do_total";
            this.coldo_total.Name = "coldo_total";
            this.coldo_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.coldo_total.Visible = true;
            this.coldo_total.Width = 62;
            // 
            // coldo_observacion
            // 
            this.coldo_observacion.Caption = "Detalle x Items";
            this.coldo_observacion.FieldName = "do_observacion";
            this.coldo_observacion.Name = "coldo_observacion";
            this.coldo_observacion.Width = 99;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Datos Obligatorios";
            this.gridBand4.Columns.Add(this.colIdMotivo);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Visible = false;
            this.gridBand4.Width = 196;
            // 
            // colIdMotivo
            // 
            this.colIdMotivo.Caption = "Motivo Compra";
            this.colIdMotivo.ColumnEdit = this.cmbMotivo_grid;
            this.colIdMotivo.FieldName = "IdMotivo";
            this.colIdMotivo.Name = "colIdMotivo";
            this.colIdMotivo.Width = 84;
            // 
            // cmbMotivo_grid
            // 
            this.cmbMotivo_grid.AutoHeight = false;
            this.cmbMotivo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivo_grid.DisplayMember = "Descripcion";
            this.cmbMotivo_grid.Name = "cmbMotivo_grid";
            this.cmbMotivo_grid.ValueMember = "IdMotivo";
            this.cmbMotivo_grid.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMotivo_cmbgrid,
            this.colDescripcion_cmbgrid,
            this.colestado_cmbgrid});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMotivo_cmbgrid
            // 
            this.colIdMotivo_cmbgrid.Caption = "IdMotivo";
            this.colIdMotivo_cmbgrid.FieldName = "IdMotivo";
            this.colIdMotivo_cmbgrid.Name = "colIdMotivo_cmbgrid";
            this.colIdMotivo_cmbgrid.Visible = true;
            this.colIdMotivo_cmbgrid.VisibleIndex = 1;
            this.colIdMotivo_cmbgrid.Width = 222;
            // 
            // colDescripcion_cmbgrid
            // 
            this.colDescripcion_cmbgrid.Caption = "Descripción";
            this.colDescripcion_cmbgrid.FieldName = "Descripcion";
            this.colDescripcion_cmbgrid.Name = "colDescripcion_cmbgrid";
            this.colDescripcion_cmbgrid.Visible = true;
            this.colDescripcion_cmbgrid.VisibleIndex = 0;
            this.colDescripcion_cmbgrid.Width = 734;
            // 
            // colestado_cmbgrid
            // 
            this.colestado_cmbgrid.Caption = "Estado";
            this.colestado_cmbgrid.FieldName = "estado";
            this.colestado_cmbgrid.Name = "colestado_cmbgrid";
            this.colestado_cmbgrid.Visible = true;
            this.colestado_cmbgrid.VisibleIndex = 2;
            this.colestado_cmbgrid.Width = 224;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Centros & SubCentro / Costo  Punto de Cargo";
            this.gridBand3.Columns.Add(this.colIdCentroCosto);
            this.gridBand3.Columns.Add(this.colNomsub_centro_costo);
            this.gridBand3.Columns.Add(this.colReferencia);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.Width = 104;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Centro de Costo";
            this.colIdCentroCosto.ColumnEdit = this.cmb_centro_costo_grid;
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Width = 114;
            // 
            // cmb_centro_costo_grid
            // 
            this.cmb_centro_costo_grid.AutoHeight = false;
            this.cmb_centro_costo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo_grid.Name = "cmb_centro_costo_grid";
            this.cmb_centro_costo_grid.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "Código";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 192;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Nombre";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 0;
            this.colCentro_costo.Width = 988;
            // 
            // colNomsub_centro_costo
            // 
            this.colNomsub_centro_costo.Caption = "Sub Centro";
            this.colNomsub_centro_costo.ColumnEdit = this.cmb_sub_centro_grid;
            this.colNomsub_centro_costo.FieldName = "Nomsub_centro_costo";
            this.colNomsub_centro_costo.Name = "colNomsub_centro_costo";
            this.colNomsub_centro_costo.Width = 111;
            // 
            // cmb_sub_centro_grid
            // 
            this.cmb_sub_centro_grid.AutoHeight = false;
            this.cmb_sub_centro_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sub_centro_grid.Name = "cmb_sub_centro_grid";
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Ref:";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.AllowEdit = false;
            this.colReferencia.Visible = true;
            this.colReferencia.Width = 104;
            // 
            // colcant_ing_SolCom_AUX
            // 
            this.colcant_ing_SolCom_AUX.FieldName = "cant_ing_SolCom_AUX";
            this.colcant_ing_SolCom_AUX.Name = "colcant_ing_SolCom_AUX";
            this.colcant_ing_SolCom_AUX.Width = 120;
            // 
            // colIdCodImpuesto_Iva
            // 
            this.colIdCodImpuesto_Iva.Caption = "%Iva";
            this.colIdCodImpuesto_Iva.Name = "colIdCodImpuesto_Iva";
            this.colIdCodImpuesto_Iva.Visible = true;
            // 
            // cmbImpuesto_Iva
            // 
            this.cmbImpuesto_Iva.AutoHeight = false;
            this.cmbImpuesto_Iva.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImpuesto_Iva.DisplayMember = "nom_impuesto";
            this.cmbImpuesto_Iva.Name = "cmbImpuesto_Iva";
            this.cmbImpuesto_Iva.ValueMember = "IdCod_Impuesto";
            this.cmbImpuesto_Iva.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_impuesto,
            this.colporcentaje,
            this.colIdCod_Impuesto_cmb});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnom_impuesto
            // 
            this.colnom_impuesto.Caption = "Impuesto";
            this.colnom_impuesto.FieldName = "nom_impuesto";
            this.colnom_impuesto.Name = "colnom_impuesto";
            this.colnom_impuesto.Visible = true;
            this.colnom_impuesto.VisibleIndex = 0;
            this.colnom_impuesto.Width = 459;
            // 
            // colporcentaje
            // 
            this.colporcentaje.Caption = "porcentaje";
            this.colporcentaje.FieldName = "porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.Visible = true;
            this.colporcentaje.VisibleIndex = 1;
            this.colporcentaje.Width = 198;
            // 
            // colIdCod_Impuesto_cmb
            // 
            this.colIdCod_Impuesto_cmb.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto_cmb.Name = "colIdCod_Impuesto_cmb";
            this.colIdCod_Impuesto_cmb.Visible = true;
            this.colIdCod_Impuesto_cmb.VisibleIndex = 2;
            this.colIdCod_Impuesto_cmb.Width = 199;
            // 
            // imageListAgregarEdit
            // 
            this.imageListAgregarEdit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAgregarEdit.ImageStream")));
            this.imageListAgregarEdit.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAgregarEdit.Images.SetKeyName(0, "editar1_128x128.png");
            this.imageListAgregarEdit.Images.SetKeyName(1, "agregar.png");
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
            this.splitContainer1.Panel1.Controls.Add(this.panelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerDetalle);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 433);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 19;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmb_Estado_OC);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.cmbEstPreAproSC);
            this.panelControl1.Controls.Add(this.cmbComprador);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.btnBuscar);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbSucursal);
            this.panelControl1.Controls.Add(this.cmbEstAproSC);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1122, 96);
            this.panelControl1.TabIndex = 1;
            // 
            // cmb_Estado_OC
            // 
            this.cmb_Estado_OC.FormattingEnabled = true;
            this.cmb_Estado_OC.Items.AddRange(new object[] {
            "Sin Orden de Compra",
            "Con Orden de Compra",
            "Todas"});
            this.cmb_Estado_OC.Location = new System.Drawing.Point(580, 67);
            this.cmb_Estado_OC.Name = "cmb_Estado_OC";
            this.cmb_Estado_OC.Size = new System.Drawing.Size(121, 21);
            this.cmb_Estado_OC.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estado/Orden de Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estado PreAprobacion";
            // 
            // cmbEstPreAproSC
            // 
            this.cmbEstPreAproSC.Location = new System.Drawing.Point(388, 67);
            this.cmbEstPreAproSC.Name = "cmbEstPreAproSC";
            this.cmbEstPreAproSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstPreAproSC.Properties.DisplayMember = "descripcion";
            this.cmbEstPreAproSC.Properties.ValueMember = "Id";
            this.cmbEstPreAproSC.Properties.View = this.gridView6;
            this.cmbEstPreAproSC.Size = new System.Drawing.Size(186, 20);
            this.cmbEstPreAproSC.TabIndex = 22;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descripción";
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 754;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado";
            this.gridColumn2.FieldName = "Estado";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 214;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 212;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(736, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 38);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(66, 5);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(298, 22);
            this.cmbSucursal.TabIndex = 19;
            // 
            // splitContainerDetalle
            // 
            this.splitContainerDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetalle.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDetalle.Name = "splitContainerDetalle";
            this.splitContainerDetalle.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDetalle.Panel1
            // 
            this.splitContainerDetalle.Panel1.Controls.Add(this.toolStripMenuGrid);
            // 
            // splitContainerDetalle.Panel2
            // 
            this.splitContainerDetalle.Panel2.Controls.Add(this.gridControlConsulta);
            this.splitContainerDetalle.Size = new System.Drawing.Size(1122, 333);
            this.splitContainerDetalle.SplitterDistance = 25;
            this.splitContainerDetalle.TabIndex = 2;
            // 
            // toolStripMenuGrid
            // 
            this.toolStripMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImprimir});
            this.toolStripMenuGrid.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenuGrid.Name = "toolStripMenuGrid";
            this.toolStripMenuGrid.Size = new System.Drawing.Size(1122, 25);
            this.toolStripMenuGrid.TabIndex = 0;
            this.toolStripMenuGrid.Text = "toolStrip1";
            // 
            // toolStripButtonImprimir
            // 
            this.toolStripButtonImprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.toolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImprimir.Name = "toolStripButtonImprimir";
            this.toolStripButtonImprimir.Size = new System.Drawing.Size(98, 22);
            this.toolStripButtonImprimir.Text = "Imprimir Grid";
            this.toolStripButtonImprimir.Click += new System.EventHandler(this.btnImprimirGrid_Click);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1122, 29);
            this.ucGe_Menu.TabIndex = 20;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.Visible_btnEstadosOC = true;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 462);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1122, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 22;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1122, 433);
            this.panelMain.TabIndex = 23;
            // 
            // colStock
            // 
            this.colStock.Caption = "Stock";
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.Width = 89;
            // 
            // FrmCom_Aprob_Gene_Orden_Compra_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 488);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmCom_Aprob_Gene_Orden_Compra_Mant";
            this.Text = "Mantenimiento / Aprobación y Generación de Ordenes de Compras";
            this.Load += new System.EventHandler(this.FrmCom_Aprob_Gene_Orden_Compra_Mant_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstAproSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_EstadoAproSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_EstadoPreAprob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUniMedida_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdPunto_cargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImpuesto_Iva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstPreAproSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.splitContainerDetalle.Panel1.ResumeLayout(false);
            this.splitContainerDetalle.Panel1.PerformLayout();
            this.splitContainerDetalle.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetalle)).EndInit();
            this.splitContainerDetalle.ResumeLayout(false);
            this.toolStripMenuGrid.ResumeLayout(false);
            this.toolStripMenuGrid.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstAproSC;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProveedor_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_gridp;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbIdPunto_cargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcmbIdPunto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_grid2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbMotivo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_cmbgrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbUniMedida_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_grid2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_grid3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_centro_costo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmb_sub_centro_grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageListAgregarEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridViewConsulta;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colChecked;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSucursal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdSucursal_grid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdSolicitudCompra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfecha;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colComprador;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNumDocumento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdPersona_Solicita;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdPersona_comprador;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colplazo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfecha_vtc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colobservacion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEstado_gridSC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSolicitante;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldepartamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdUsuarioAprobo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMotivoAprobo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFechaHoraAprobacion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSecuencia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcod_producto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnom_producto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcant_aprobada_OC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSaldo_cant_SolCom;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSaldo_cant_SolCom_AUX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcant_aprobada_OC_AUX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdEstadoAprobacion_AUX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_porc_des;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_descuento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_observacion2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNomProducto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIco1_editar;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIco2_insertar;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcant_ing_SolCom;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn col_do_precioCompra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_subtotal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_iva;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcmbProveedor_grid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdMotivo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcmb_Estado_AproSC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNomsub_centro_costo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdPunto_cargo_grid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colChecked_Estado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcant_ing_SolCom_AUX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReferencia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_observacion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCCom_Comprador cmbComprador;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private Controles.UCGe_Sucursal_combo cmbSucursal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcant_solicitada;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcmb_Estado_PreApro;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_EstadoAproSC;
        private System.Windows.Forms.ImageList imageListEstadoAprobSC;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_EstadoPreAprob;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcmb_OrdenCompra;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_OrdenCompra;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstPreAproSC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.SplitContainer splitContainerDetalle;
        private System.Windows.Forms.ToolStrip toolStripMenuGrid;
        private System.Windows.Forms.ToolStripButton toolStripButtonImprimir;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cmb_Estado_OC;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldo_total;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIdCodImpuesto_Iva;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbImpuesto_Iva;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_cmb;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock;
    }
}
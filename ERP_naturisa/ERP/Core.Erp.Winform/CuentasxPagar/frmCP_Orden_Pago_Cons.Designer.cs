namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Orden_Pago_Cons
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
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.cpordenpagoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_cbtecble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Persona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_cancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo_flujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_flujo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.DataSource = this.cpordenpagoInfoBindingSource;
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_flujo});
            this.gridControlConsulta.Size = new System.Drawing.Size(1152, 233);
            this.gridControlConsulta.TabIndex = 1;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // cpordenpagoInfoBindingSource
            // 
            this.cpordenpagoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_Info);
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdOrdenPago,
            this.colObservacion,
            this.colIdTipo_op,
            this.colIdProveedor,
            this.colFecha,
            this.colIdEmpresa_cbtecble,
            this.colIdTipoCbte_cbtecble,
            this.colIdCbteCble_cbtecble,
            this.colIdEstadoAprobacion,
            this.colIdFormaPago,
            this.colFecha_Pago,
            this.colIdBanco,
            this.colEstado,
            this.colIdPersona,
            this.colIdTipo_Persona,
            this.colpe_nombreCompleto,
            this.colSaldo,
            this.colTotal_cancelado,
            this.colTotal_OP,
            this.colEstadoCancelacion,
            this.gridColumn1,
            this.col_tipo_flujo});
            this.gridViewConsulta.CustomizationFormBounds = new System.Drawing.Rectangle(875, 364, 210, 179);
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowDetailButtons = false;
            this.gridViewConsulta.OptionsView.ShowFooter = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdOrdenPago, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsulta_RowCellStyle);
            this.gridViewConsulta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewConsulta_FocusedRowChanged);
            this.gridViewConsulta.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConsulta_CellValueChanged);
            this.gridViewConsulta.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewConsulta_CellValueChanging);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            // 
            // colIdOrdenPago
            // 
            this.colIdOrdenPago.Caption = "# Orden Pago";
            this.colIdOrdenPago.FieldName = "IdOrdenPago";
            this.colIdOrdenPago.Name = "colIdOrdenPago";
            this.colIdOrdenPago.OptionsColumn.AllowEdit = false;
            this.colIdOrdenPago.OptionsColumn.ReadOnly = true;
            this.colIdOrdenPago.Visible = true;
            this.colIdOrdenPago.VisibleIndex = 1;
            this.colIdOrdenPago.Width = 68;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.OptionsColumn.ReadOnly = true;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 206;
            // 
            // colIdTipo_op
            // 
            this.colIdTipo_op.Caption = "Tipo orden pago";
            this.colIdTipo_op.FieldName = "IdTipo_op";
            this.colIdTipo_op.Name = "colIdTipo_op";
            this.colIdTipo_op.OptionsColumn.AllowEdit = false;
            this.colIdTipo_op.OptionsColumn.ReadOnly = true;
            this.colIdTipo_op.Visible = true;
            this.colIdTipo_op.VisibleIndex = 10;
            this.colIdTipo_op.Width = 84;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.AllowEdit = false;
            this.colIdProveedor.OptionsColumn.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 74;
            // 
            // colIdEmpresa_cbtecble
            // 
            this.colIdEmpresa_cbtecble.FieldName = "IdEmpresa_cbtecble";
            this.colIdEmpresa_cbtecble.Name = "colIdEmpresa_cbtecble";
            this.colIdEmpresa_cbtecble.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // colIdTipoCbte_cbtecble
            // 
            this.colIdTipoCbte_cbtecble.FieldName = "IdTipoCbte_cbtecble";
            this.colIdTipoCbte_cbtecble.Name = "colIdTipoCbte_cbtecble";
            this.colIdTipoCbte_cbtecble.OptionsColumn.AllowEdit = false;
            this.colIdTipoCbte_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // colIdCbteCble_cbtecble
            // 
            this.colIdCbteCble_cbtecble.FieldName = "IdCbteCble_cbtecble";
            this.colIdCbteCble_cbtecble.Name = "colIdCbteCble_cbtecble";
            this.colIdCbteCble_cbtecble.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_cbtecble.OptionsColumn.ReadOnly = true;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.Caption = "Estado Aprobación";
            this.colIdEstadoAprobacion.FieldName = "Descripcion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.OptionsColumn.AllowEdit = false;
            this.colIdEstadoAprobacion.OptionsColumn.ReadOnly = true;
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 11;
            this.colIdEstadoAprobacion.Width = 90;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "Forma Pago";
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsColumn.AllowEdit = false;
            this.colIdFormaPago.OptionsColumn.ReadOnly = true;
            // 
            // colFecha_Pago
            // 
            this.colFecha_Pago.FieldName = "Fecha_Pago";
            this.colFecha_Pago.Name = "colFecha_Pago";
            this.colFecha_Pago.OptionsColumn.AllowEdit = false;
            this.colFecha_Pago.OptionsColumn.ReadOnly = true;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.OptionsColumn.AllowEdit = false;
            this.colIdBanco.OptionsColumn.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 46;
            // 
            // colIdPersona
            // 
            this.colIdPersona.Caption = "IdPersona";
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.OptionsColumn.AllowEdit = false;
            this.colIdPersona.OptionsColumn.ReadOnly = true;
            this.colIdPersona.Width = 110;
            // 
            // colIdTipo_Persona
            // 
            this.colIdTipo_Persona.Caption = "Tipo persona";
            this.colIdTipo_Persona.FieldName = "IdTipo_Persona";
            this.colIdTipo_Persona.Name = "colIdTipo_Persona";
            this.colIdTipo_Persona.OptionsColumn.AllowEdit = false;
            this.colIdTipo_Persona.OptionsColumn.ReadOnly = true;
            this.colIdTipo_Persona.Width = 96;
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Beneficiario";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.colpe_nombreCompleto.OptionsColumn.ReadOnly = true;
            this.colpe_nombreCompleto.Visible = true;
            this.colpe_nombreCompleto.VisibleIndex = 4;
            this.colpe_nombreCompleto.Width = 149;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")});
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 79;
            // 
            // colTotal_cancelado
            // 
            this.colTotal_cancelado.Caption = "Total cancelado";
            this.colTotal_cancelado.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colTotal_cancelado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal_cancelado.FieldName = "Total_cancelado";
            this.colTotal_cancelado.Name = "colTotal_cancelado";
            this.colTotal_cancelado.OptionsColumn.AllowEdit = false;
            this.colTotal_cancelado.OptionsColumn.ReadOnly = true;
            this.colTotal_cancelado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total_cancelado", "{0:n2}")});
            this.colTotal_cancelado.Visible = true;
            this.colTotal_cancelado.VisibleIndex = 6;
            this.colTotal_cancelado.Width = 77;
            // 
            // colTotal_OP
            // 
            this.colTotal_OP.Caption = "Total OP";
            this.colTotal_OP.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.colTotal_OP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal_OP.FieldName = "Total_OP";
            this.colTotal_OP.Name = "colTotal_OP";
            this.colTotal_OP.OptionsColumn.AllowEdit = false;
            this.colTotal_OP.OptionsColumn.ReadOnly = true;
            this.colTotal_OP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total_OP", "{0:n2}")});
            this.colTotal_OP.Visible = true;
            this.colTotal_OP.VisibleIndex = 5;
            this.colTotal_OP.Width = 51;
            // 
            // colEstadoCancelacion
            // 
            this.colEstadoCancelacion.Caption = "Estado Cancelacion";
            this.colEstadoCancelacion.FieldName = "EstadoCancelacion";
            this.colEstadoCancelacion.Name = "colEstadoCancelacion";
            this.colEstadoCancelacion.OptionsColumn.AllowEdit = false;
            this.colEstadoCancelacion.OptionsColumn.ReadOnly = true;
            this.colEstadoCancelacion.Visible = true;
            this.colEstadoCancelacion.VisibleIndex = 8;
            this.colEstadoCancelacion.Width = 95;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "*";
            this.gridColumn1.FieldName = "Check";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 22;
            // 
            // col_tipo_flujo
            // 
            this.col_tipo_flujo.Caption = "Tipo flujo";
            this.col_tipo_flujo.ColumnEdit = this.cmb_tipo_flujo;
            this.col_tipo_flujo.FieldName = "IdTipoFlujo";
            this.col_tipo_flujo.Name = "col_tipo_flujo";
            this.col_tipo_flujo.Visible = true;
            this.col_tipo_flujo.VisibleIndex = 9;
            this.col_tipo_flujo.Width = 130;
            // 
            // cmb_tipo_flujo
            // 
            this.cmb_tipo_flujo.AutoHeight = false;
            this.cmb_tipo_flujo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_flujo.DisplayMember = "Descricion2";
            this.cmb_tipo_flujo.Name = "cmb_tipo_flujo";
            this.cmb_tipo_flujo.ValueMember = "IdTipoFlujo";
            this.cmb_tipo_flujo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdTipoFlujo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 194;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo flujo";
            this.gridColumn3.FieldName = "Descricion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 794;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Código";
            this.gridColumn4.FieldName = "cod_flujo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 192;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 158);
            this.panel1.TabIndex = 2;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 3, 6, 11, 51, 18, 781);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 5, 6, 11, 51, 18, 782);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1152, 158);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 391);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1152, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlConsulta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 233);
            this.panel2.TabIndex = 4;
            // 
            // frmCP_Orden_Pago_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCP_Orden_Pago_Cons";
            this.Text = "Consulta Orden de Pago";
            this.Load += new System.EventHandler(this.frmCP_Orden_Pago_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private System.Windows.Forms.BindingSource cpordenpagoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_op;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_cbtecble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_cbtecble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_cbtecble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Persona;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_cancelado;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_OP;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_flujo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_flujo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
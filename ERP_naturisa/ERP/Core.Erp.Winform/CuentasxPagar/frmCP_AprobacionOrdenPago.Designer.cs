namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_AprobacionOrdenPago
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
            this.vwtbpersonabeneficiarioInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtNumAprobacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cpordenpagoformapagoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.cpordenpagoestadoaprobInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridAprobacionOrdenPago = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.IdOrdenPago_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nom_Beneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFormaPagoGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbEstadoAprobacionGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo_x_Pagar_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor_estimado_a_pagar_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalCancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEntidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion_AUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal_op_seleccionadas = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ucGe_Beneficiario = new Core.Erp.Winform.Controles.UCGe_Beneficiario();
            this.cmbFormaPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovi_caj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstadoAprobacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.vwtbpersonabeneficiarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoformapagoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoestadoaprobInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAprobacionOrdenPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_op_seleccionadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwtbpersonabeneficiarioInfoBindingSource
            // 
            this.vwtbpersonabeneficiarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.vwtb_persona_beneficiario_Info);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(689, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 72;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(110, 31);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(675, 28);
            this.txtObservacion.TabIndex = 71;
            // 
            // txtNumAprobacion
            // 
            this.txtNumAprobacion.Location = new System.Drawing.Point(110, 4);
            this.txtNumAprobacion.Name = "txtNumAprobacion";
            this.txtNumAprobacion.ReadOnly = true;
            this.txtNumAprobacion.Size = new System.Drawing.Size(100, 20);
            this.txtNumAprobacion.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Observación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "# Aprobación:";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Motivo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            this.gridColumn7.Width = 258;
            // 
            // cpordenpagoformapagoInfoBindingSource
            // 
            this.cpordenpagoformapagoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_formapago_Info);
            // 
            // cpordenpagoestadoaprobInfoBindingSource
            // 
            this.cpordenpagoestadoaprobInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_estado_aprob_Info);
            // 
            // gridAprobacionOrdenPago
            // 
            this.gridAprobacionOrdenPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAprobacionOrdenPago.Location = new System.Drawing.Point(0, 146);
            this.gridAprobacionOrdenPago.MainView = this.gridView;
            this.gridAprobacionOrdenPago.Name = "gridAprobacionOrdenPago";
            this.gridAprobacionOrdenPago.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemSearchLookUpEdit2});
            this.gridAprobacionOrdenPago.Size = new System.Drawing.Size(1151, 245);
            this.gridAprobacionOrdenPago.TabIndex = 63;
            this.gridAprobacionOrdenPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.ColumnPanelRowHeight = 20;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.check,
            this.IdOrdenPago_OP,
            this.Fecha_OP,
            this.Nom_Beneficiario,
            this.Referencia,
            this.Fecha_Pago,
            this.cmbFormaPagoGrid,
            this.cmbEstadoAprobacionGrid,
            this.Saldo_x_Pagar_OP,
            this.Valor_estimado_a_pagar_OP,
            this.Motivo,
            this.TotalCancelado,
            this.IdTipoPersona,
            this.IdPersona,
            this.IdEntidad,
            this.EstadoGrid,
            this.colIdEstadoAprobacion_AUX,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView.GridControl = this.gridAprobacionOrdenPago;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdOrdenPago_OP, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanging);
            // 
            // check
            // 
            this.check.Caption = "*";
            this.check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.check.FieldName = "Check";
            this.check.Name = "check";
            this.check.OptionsColumn.AllowEdit = false;
            this.check.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.check.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.check.Visible = true;
            this.check.VisibleIndex = 0;
            this.check.Width = 29;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // IdOrdenPago_OP
            // 
            this.IdOrdenPago_OP.Caption = "# OP";
            this.IdOrdenPago_OP.FieldName = "IdOrdenPago";
            this.IdOrdenPago_OP.Name = "IdOrdenPago_OP";
            this.IdOrdenPago_OP.OptionsColumn.AllowEdit = false;
            this.IdOrdenPago_OP.Visible = true;
            this.IdOrdenPago_OP.VisibleIndex = 1;
            this.IdOrdenPago_OP.Width = 44;
            // 
            // Fecha_OP
            // 
            this.Fecha_OP.Caption = "Fecha OP";
            this.Fecha_OP.FieldName = "Fecha_OP";
            this.Fecha_OP.Name = "Fecha_OP";
            this.Fecha_OP.OptionsColumn.AllowEdit = false;
            this.Fecha_OP.Visible = true;
            this.Fecha_OP.VisibleIndex = 5;
            this.Fecha_OP.Width = 78;
            // 
            // Nom_Beneficiario
            // 
            this.Nom_Beneficiario.Caption = "Beneficiario";
            this.Nom_Beneficiario.FieldName = "Nom_Beneficiario";
            this.Nom_Beneficiario.Name = "Nom_Beneficiario";
            this.Nom_Beneficiario.OptionsColumn.AllowEdit = false;
            this.Nom_Beneficiario.Visible = true;
            this.Nom_Beneficiario.VisibleIndex = 3;
            this.Nom_Beneficiario.Width = 168;
            // 
            // Referencia
            // 
            this.Referencia.Caption = "Referencia";
            this.Referencia.FieldName = "Referencia2";
            this.Referencia.Name = "Referencia";
            this.Referencia.OptionsColumn.AllowEdit = false;
            this.Referencia.Visible = true;
            this.Referencia.VisibleIndex = 2;
            this.Referencia.Width = 90;
            // 
            // Fecha_Pago
            // 
            this.Fecha_Pago.Caption = "Fecha de Pago";
            this.Fecha_Pago.FieldName = "Fecha_Pago";
            this.Fecha_Pago.Name = "Fecha_Pago";
            this.Fecha_Pago.Width = 74;
            // 
            // cmbFormaPagoGrid
            // 
            this.cmbFormaPagoGrid.Caption = "Forma pago";
            this.cmbFormaPagoGrid.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.cmbFormaPagoGrid.FieldName = "IdFormaPago";
            this.cmbFormaPagoGrid.Name = "cmbFormaPagoGrid";
            this.cmbFormaPagoGrid.Visible = true;
            this.cmbFormaPagoGrid.VisibleIndex = 9;
            this.cmbFormaPagoGrid.Width = 117;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "descripcion";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IdFormaPago";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colIdFormaPago1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 691;
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            this.colIdFormaPago1.Visible = true;
            this.colIdFormaPago1.VisibleIndex = 1;
            this.colIdFormaPago1.Width = 264;
            // 
            // cmbEstadoAprobacionGrid
            // 
            this.cmbEstadoAprobacionGrid.Caption = "Estado Aprobación";
            this.cmbEstadoAprobacionGrid.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.cmbEstadoAprobacionGrid.FieldName = "IdEstadoAprobacion";
            this.cmbEstadoAprobacionGrid.Name = "cmbEstadoAprobacionGrid";
            this.cmbEstadoAprobacionGrid.Visible = true;
            this.cmbEstadoAprobacionGrid.VisibleIndex = 10;
            this.cmbEstadoAprobacionGrid.Width = 108;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "Descripcion";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.ValueMember = "IdEstadoAprobacion";
            this.repositoryItemSearchLookUpEdit2.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion2,
            this.colIdEstadoAprobacion});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 0;
            this.colDescripcion2.Width = 866;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.Visible = true;
            this.colIdEstadoAprobacion.VisibleIndex = 1;
            this.colIdEstadoAprobacion.Width = 292;
            // 
            // Saldo_x_Pagar_OP
            // 
            this.Saldo_x_Pagar_OP.Caption = "Saldo OP";
            this.Saldo_x_Pagar_OP.FieldName = "Saldo_x_Pagar_OP";
            this.Saldo_x_Pagar_OP.Name = "Saldo_x_Pagar_OP";
            this.Saldo_x_Pagar_OP.OptionsColumn.AllowEdit = false;
            this.Saldo_x_Pagar_OP.Width = 84;
            // 
            // Valor_estimado_a_pagar_OP
            // 
            this.Valor_estimado_a_pagar_OP.Caption = "Valor";
            this.Valor_estimado_a_pagar_OP.DisplayFormat.FormatString = "n2";
            this.Valor_estimado_a_pagar_OP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Valor_estimado_a_pagar_OP.FieldName = "Valor_estimado_a_pagar_OP";
            this.Valor_estimado_a_pagar_OP.Name = "Valor_estimado_a_pagar_OP";
            this.Valor_estimado_a_pagar_OP.OptionsColumn.AllowEdit = false;
            this.Valor_estimado_a_pagar_OP.Visible = true;
            this.Valor_estimado_a_pagar_OP.VisibleIndex = 11;
            this.Valor_estimado_a_pagar_OP.Width = 117;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Observación";
            this.Motivo.FieldName = "Observacion";
            this.Motivo.Name = "Motivo";
            this.Motivo.OptionsColumn.AllowEdit = false;
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 4;
            this.Motivo.Width = 183;
            // 
            // TotalCancelado
            // 
            this.TotalCancelado.Caption = "Valor Cancelado a la Fecha";
            this.TotalCancelado.FieldName = "Total_cancelado_OP";
            this.TotalCancelado.Name = "TotalCancelado";
            this.TotalCancelado.OptionsColumn.AllowEdit = false;
            this.TotalCancelado.Width = 94;
            // 
            // IdTipoPersona
            // 
            this.IdTipoPersona.Caption = "Tipo Persona";
            this.IdTipoPersona.FieldName = "IdTipoPersona";
            this.IdTipoPersona.Name = "IdTipoPersona";
            this.IdTipoPersona.OptionsColumn.AllowEdit = false;
            this.IdTipoPersona.Width = 60;
            // 
            // IdPersona
            // 
            this.IdPersona.Caption = "Id Persona";
            this.IdPersona.FieldName = "IdPersona";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.OptionsColumn.AllowEdit = false;
            this.IdPersona.Width = 60;
            // 
            // IdEntidad
            // 
            this.IdEntidad.Caption = "Id Entidad";
            this.IdEntidad.FieldName = "IdEntidad";
            this.IdEntidad.Name = "IdEntidad";
            this.IdEntidad.OptionsColumn.AllowEdit = false;
            this.IdEntidad.Width = 60;
            // 
            // EstadoGrid
            // 
            this.EstadoGrid.Caption = "Estado";
            this.EstadoGrid.FieldName = "Estado";
            this.EstadoGrid.Name = "EstadoGrid";
            this.EstadoGrid.OptionsColumn.AllowEdit = false;
            // 
            // colIdEstadoAprobacion_AUX
            // 
            this.colIdEstadoAprobacion_AUX.FieldName = "IdEstadoAprobacion_AUX";
            this.colIdEstadoAprobacion_AUX.Name = "colIdEstadoAprobacion_AUX";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha factura";
            this.gridColumn1.FieldName = "Fecha_Fa_Prov";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha vcto";
            this.gridColumn2.FieldName = "Fecha_Venc_Fac_Prov";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 97;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Días vencido";
            this.gridColumn3.FieldName = "dias_vencido";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 68;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "descripcion";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "IdFormaPago";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1151, 29);
            this.ucGe_Menu.TabIndex = 64;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 16);
            this.labelControl1.TabIndex = 75;
            this.labelControl1.Text = "Total op seleccionadas";
            // 
            // txtTotal_op_seleccionadas
            // 
            this.txtTotal_op_seleccionadas.Location = new System.Drawing.Point(161, 6);
            this.txtTotal_op_seleccionadas.Name = "txtTotal_op_seleccionadas";
            this.txtTotal_op_seleccionadas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal_op_seleccionadas.Properties.Appearance.Options.UseFont = true;
            this.txtTotal_op_seleccionadas.Properties.ReadOnly = true;
            this.txtTotal_op_seleccionadas.Size = new System.Drawing.Size(100, 22);
            this.txtTotal_op_seleccionadas.TabIndex = 74;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(800, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ucGe_Beneficiario
            // 
            this.ucGe_Beneficiario.IdTipo_Persona = Core.Erp.Info.General.Cl_Enumeradores.eTipoPersona.PROVEE;
            this.ucGe_Beneficiario.Location = new System.Drawing.Point(109, 62);
            this.ucGe_Beneficiario.Name = "ucGe_Beneficiario";
            this.ucGe_Beneficiario.Size = new System.Drawing.Size(676, 35);
            this.ucGe_Beneficiario.TabIndex = 73;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Location = new System.Drawing.Point(113, 120);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFormaPago.Properties.DisplayMember = "descripcion";
            this.cmbFormaPago.Properties.ValueMember = "IdFormaPago";
            this.cmbFormaPago.Properties.View = this.gridView1;
            this.cmbFormaPago.Size = new System.Drawing.Size(268, 20);
            this.cmbFormaPago.TabIndex = 66;
            this.cmbFormaPago.EditValueChanged += new System.EventHandler(this.cmbFormaPago_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFormaPago,
            this.coldescripcion1,
            this.colIdTipoTransaccion,
            this.colCodModulo,
            this.colIdTipoMovi_caj});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 1;
            this.colIdFormaPago.Width = 257;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            this.coldescripcion1.Width = 917;
            // 
            // colIdTipoTransaccion
            // 
            this.colIdTipoTransaccion.FieldName = "IdTipoTransaccion";
            this.colIdTipoTransaccion.Name = "colIdTipoTransaccion";
            // 
            // colCodModulo
            // 
            this.colCodModulo.FieldName = "CodModulo";
            this.colCodModulo.Name = "colCodModulo";
            // 
            // colIdTipoMovi_caj
            // 
            this.colIdTipoMovi_caj.FieldName = "IdTipoMovi_caj";
            this.colIdTipoMovi_caj.Name = "colIdTipoMovi_caj";
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(403, 120);
            this.checkTodos.MaximumSize = new System.Drawing.Size(250, 40);
            this.checkTodos.MinimumSize = new System.Drawing.Size(10, 10);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(241, 17);
            this.checkTodos.TabIndex = 48;
            this.checkTodos.Text = "Aplicar a Todo el detalle esta Forma de Cobro";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Forma de pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Beneficiario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Estado Aprobación:";
            // 
            // cmbEstadoAprobacion
            // 
            this.cmbEstadoAprobacion.Location = new System.Drawing.Point(113, 92);
            this.cmbEstadoAprobacion.Name = "cmbEstadoAprobacion";
            this.cmbEstadoAprobacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoAprobacion.Properties.DisplayMember = "Descripcion";
            this.cmbEstadoAprobacion.Properties.ValueMember = "IdEstadoAprobacion";
            this.cmbEstadoAprobacion.Properties.View = this.gridView2;
            this.cmbEstadoAprobacion.Size = new System.Drawing.Size(268, 20);
            this.cmbEstadoAprobacion.TabIndex = 68;
            this.cmbEstadoAprobacion.EditValueChanged += new System.EventHandler(this.cmbEstadoAprobacion_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Código";
            this.gridColumn8.FieldName = "IdEstadoAprobacion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 142;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Descripción";
            this.gridColumn9.FieldName = "Descripcion";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 747;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 454);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1151, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridAprobacionOrdenPago);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 425);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbFormaPago);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtObservacion);
            this.panel2.Controls.Add(this.cmbEstadoAprobacion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNumAprobacion);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ucGe_Beneficiario);
            this.panel2.Controls.Add(this.checkTodos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 146);
            this.panel2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotal_op_seleccionadas);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1151, 34);
            this.panel3.TabIndex = 68;
            // 
            // frmCP_AprobacionOrdenPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCP_AprobacionOrdenPago";
            this.Text = "Aprobación de Orden de Pago";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCP_AprobacionOrdenPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwtbpersonabeneficiarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoformapagoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoestadoaprobInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAprobacionOrdenPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal_op_seleccionadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoAprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumAprobacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.BindingSource cpordenpagoformapagoInfoBindingSource;
        private System.Windows.Forms.BindingSource cpordenpagoestadoaprobInfoBindingSource;
        private System.Windows.Forms.BindingSource vwtbpersonabeneficiarioInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridAprobacionOrdenPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn IdOrdenPago_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Nom_Beneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn Referencia;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn cmbFormaPagoGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn cmbEstadoAprobacionGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo_x_Pagar_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Valor_estimado_a_pagar_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn TotalCancelado;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn IdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn IdEntidad;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion_AUX;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbFormaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovi_caj;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoAprobacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private Controles.UCGe_Beneficiario ucGe_Beneficiario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotal_op_seleccionadas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
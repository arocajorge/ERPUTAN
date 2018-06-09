namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Debito_Mant
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl_Data = new System.Windows.Forms.TabControl();
            this.tabPageDiario = new System.Windows.Forms.TabPage();
            this.UC_Diario_x_NC = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.tabPageOP = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ucGe_Beneficiario1 = new Core.Erp.Winform.Controles.UCGe_Beneficiario();
            this.gridAprobacionOrdenPago = new DevExpress.XtraGrid.GridControl();
            this.gridViewOP_Pendientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEntidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo_x_Pagar_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorAprobado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor_a_Cancelar_OPGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNom_Beneficiario_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Pagar2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ucGe_Sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.ucBa_CuentaBanco = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            this.ucbA_TipoNota = new Core.Erp.Winform.Controles.UCBA_TipoNota();
            this.dt_fechaCbte = new System.Windows.Forms.DateTimePicker();
            this.lblCbt_TipoAnulacion = new System.Windows.Forms.Label();
            this.txt_Memo = new System.Windows.Forms.TextBox();
            this.txt_Ncomprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms2 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.tabControl_Data.SuspendLayout();
            this.tabPageDiario.SuspendLayout();
            this.tabPageOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAprobacionOrdenPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOP_Pendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl_Data);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(999, 424);
            this.panelMain.TabIndex = 2;
            // 
            // tabControl_Data
            // 
            this.tabControl_Data.Controls.Add(this.tabPageDiario);
            this.tabControl_Data.Controls.Add(this.tabPageOP);
            this.tabControl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Data.Location = new System.Drawing.Point(0, 133);
            this.tabControl_Data.Name = "tabControl_Data";
            this.tabControl_Data.SelectedIndex = 0;
            this.tabControl_Data.Size = new System.Drawing.Size(999, 291);
            this.tabControl_Data.TabIndex = 5;
            // 
            // tabPageDiario
            // 
            this.tabPageDiario.Controls.Add(this.UC_Diario_x_NC);
            this.tabPageDiario.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiario.Name = "tabPageDiario";
            this.tabPageDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiario.Size = new System.Drawing.Size(991, 265);
            this.tabPageDiario.TabIndex = 0;
            this.tabPageDiario.Text = "Diario Contable";
            this.tabPageDiario.UseVisualStyleBackColor = true;
            // 
            // UC_Diario_x_NC
            // 
            this.UC_Diario_x_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Diario_x_NC.Location = new System.Drawing.Point(3, 3);
            this.UC_Diario_x_NC.Name = "UC_Diario_x_NC";
            this.UC_Diario_x_NC.Size = new System.Drawing.Size(985, 259);
            this.UC_Diario_x_NC.TabIndex = 123;
            this.UC_Diario_x_NC.Visible_Botones = false;
            this.UC_Diario_x_NC.Visible_Cabecera = false;
            this.UC_Diario_x_NC.Visible_columna_GrupoPuntoCargo = true;
            this.UC_Diario_x_NC.Visible_columna_PuntoCargo = true;
            // 
            // tabPageOP
            // 
            this.tabPageOP.Controls.Add(this.gridAprobacionOrdenPago);
            this.tabPageOP.Controls.Add(this.panel1);
            this.tabPageOP.Location = new System.Drawing.Point(4, 22);
            this.tabPageOP.Name = "tabPageOP";
            this.tabPageOP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOP.Size = new System.Drawing.Size(991, 265);
            this.tabPageOP.TabIndex = 1;
            this.tabPageOP.Text = "Orden de Pago Pendientes";
            this.tabPageOP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar Por:";
            // 
            // ucGe_Beneficiario1
            // 
            this.ucGe_Beneficiario1.IdTipo_Persona = Core.Erp.Info.General.Cl_Enumeradores.eTipoPersona.CLIENTE;
            this.ucGe_Beneficiario1.Location = new System.Drawing.Point(78, 3);
            this.ucGe_Beneficiario1.Name = "ucGe_Beneficiario1";
            this.ucGe_Beneficiario1.Size = new System.Drawing.Size(703, 26);
            this.ucGe_Beneficiario1.TabIndex = 3;
            this.ucGe_Beneficiario1.event_cmb_beneficiario_EditValueChanged += new Core.Erp.Winform.Controles.UCGe_Beneficiario.delegate_cmb_beneficiario_EditValueChanged(this.ucGe_Beneficiario1_event_cmb_beneficiario_EditValueChanged);
            // 
            // gridAprobacionOrdenPago
            // 
            this.gridAprobacionOrdenPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAprobacionOrdenPago.Location = new System.Drawing.Point(3, 38);
            this.gridAprobacionOrdenPago.MainView = this.gridViewOP_Pendientes;
            this.gridAprobacionOrdenPago.Name = "gridAprobacionOrdenPago";
            this.gridAprobacionOrdenPago.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.check});
            this.gridAprobacionOrdenPago.Size = new System.Drawing.Size(985, 224);
            this.gridAprobacionOrdenPago.TabIndex = 1;
            this.gridAprobacionOrdenPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOP_Pendientes});
            // 
            // gridViewOP_Pendientes
            // 
            this.gridViewOP_Pendientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReferencia,
            this.colIdOrdenPago,
            this.colIdEntidad1,
            this.colFecha_OP,
            this.Saldo_x_Pagar_OP,
            this.ValorAprobado,
            this.Valor_a_Cancelar_OPGrid,
            this.colCheck,
            this.colNom_Beneficiario_2,
            this.colIdCtaCble,
            this.colReferencia2,
            this.colSaldo_x_Pagar2,
            this.colIdTipo_op,
            this.colIdFormaPago});
            this.gridViewOP_Pendientes.GridControl = this.gridAprobacionOrdenPago;
            this.gridViewOP_Pendientes.Name = "gridViewOP_Pendientes";
            this.gridViewOP_Pendientes.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOP_Pendientes.OptionsView.ShowFooter = true;
            this.gridViewOP_Pendientes.OptionsView.ShowGroupPanel = false;
            this.gridViewOP_Pendientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOP_Pendientes_RowClick);
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.AllowEdit = false;
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 5;
            this.colReferencia.Width = 66;
            // 
            // colIdOrdenPago
            // 
            this.colIdOrdenPago.Caption = "# OP";
            this.colIdOrdenPago.FieldName = "IdOrdenPago";
            this.colIdOrdenPago.Name = "colIdOrdenPago";
            this.colIdOrdenPago.OptionsColumn.AllowEdit = false;
            this.colIdOrdenPago.Visible = true;
            this.colIdOrdenPago.VisibleIndex = 1;
            this.colIdOrdenPago.Width = 51;
            // 
            // colIdEntidad1
            // 
            this.colIdEntidad1.Caption = "Entidad";
            this.colIdEntidad1.FieldName = "IdEntidad";
            this.colIdEntidad1.Name = "colIdEntidad1";
            this.colIdEntidad1.OptionsColumn.AllowEdit = false;
            this.colIdEntidad1.Visible = true;
            this.colIdEntidad1.VisibleIndex = 4;
            this.colIdEntidad1.Width = 50;
            // 
            // colFecha_OP
            // 
            this.colFecha_OP.Caption = "Fecha OP";
            this.colFecha_OP.FieldName = "Fecha_OP";
            this.colFecha_OP.Name = "colFecha_OP";
            this.colFecha_OP.OptionsColumn.AllowEdit = false;
            this.colFecha_OP.Visible = true;
            this.colFecha_OP.VisibleIndex = 6;
            this.colFecha_OP.Width = 51;
            // 
            // Saldo_x_Pagar_OP
            // 
            this.Saldo_x_Pagar_OP.Caption = "Saldo OP";
            this.Saldo_x_Pagar_OP.FieldName = "Saldo_x_Pagar_OP";
            this.Saldo_x_Pagar_OP.Name = "Saldo_x_Pagar_OP";
            this.Saldo_x_Pagar_OP.OptionsColumn.AllowEdit = false;
            this.Saldo_x_Pagar_OP.Visible = true;
            this.Saldo_x_Pagar_OP.VisibleIndex = 8;
            this.Saldo_x_Pagar_OP.Width = 51;
            // 
            // ValorAprobado
            // 
            this.ValorAprobado.Caption = "Valor Aprobado";
            this.ValorAprobado.FieldName = "Valor_estimado_a_pagar_OP";
            this.ValorAprobado.Name = "ValorAprobado";
            this.ValorAprobado.OptionsColumn.AllowEdit = false;
            this.ValorAprobado.Visible = true;
            this.ValorAprobado.VisibleIndex = 9;
            this.ValorAprobado.Width = 78;
            // 
            // Valor_a_Cancelar_OPGrid
            // 
            this.Valor_a_Cancelar_OPGrid.Caption = "Valor a Cancelar";
            this.Valor_a_Cancelar_OPGrid.FieldName = "Valor_aplicado";
            this.Valor_a_Cancelar_OPGrid.Name = "Valor_a_Cancelar_OPGrid";
            this.Valor_a_Cancelar_OPGrid.OptionsColumn.AllowEdit = false;
            this.Valor_a_Cancelar_OPGrid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Valor_a_Cancelar_OPGrid.Visible = true;
            this.Valor_a_Cancelar_OPGrid.VisibleIndex = 10;
            this.Valor_a_Cancelar_OPGrid.Width = 101;
            // 
            // colCheck
            // 
            this.colCheck.ColumnEdit = this.check;
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.OptionsColumn.AllowEdit = false;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 27;
            // 
            // check
            // 
            this.check.AutoHeight = false;
            this.check.Name = "check";
            // 
            // colNom_Beneficiario_2
            // 
            this.colNom_Beneficiario_2.Caption = "Beneficiario";
            this.colNom_Beneficiario_2.FieldName = "Nom_Beneficiario_2";
            this.colNom_Beneficiario_2.Name = "colNom_Beneficiario_2";
            this.colNom_Beneficiario_2.OptionsColumn.AllowEdit = false;
            this.colNom_Beneficiario_2.Visible = true;
            this.colNom_Beneficiario_2.VisibleIndex = 7;
            this.colNom_Beneficiario_2.Width = 560;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colReferencia2
            // 
            this.colReferencia2.FieldName = "Referencia2";
            this.colReferencia2.Name = "colReferencia2";
            // 
            // colSaldo_x_Pagar2
            // 
            this.colSaldo_x_Pagar2.FieldName = "Saldo_x_Pagar2";
            this.colSaldo_x_Pagar2.Name = "colSaldo_x_Pagar2";
            // 
            // colIdTipo_op
            // 
            this.colIdTipo_op.Caption = "Tipo OP";
            this.colIdTipo_op.FieldName = "IdTipo_op";
            this.colIdTipo_op.Name = "colIdTipo_op";
            this.colIdTipo_op.OptionsColumn.AllowEdit = false;
            this.colIdTipo_op.Visible = true;
            this.colIdTipo_op.VisibleIndex = 2;
            this.colIdTipo_op.Width = 68;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "Forma Pago";
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsColumn.AllowEdit = false;
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 3;
            this.colIdFormaPago.Width = 77;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.ucGe_Sucursal);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.ucBa_TipoFlujo);
            this.panelTop.Controls.Add(this.ucBa_CuentaBanco);
            this.panelTop.Controls.Add(this.ucbA_TipoNota);
            this.panelTop.Controls.Add(this.dt_fechaCbte);
            this.panelTop.Controls.Add(this.lblCbt_TipoAnulacion);
            this.panelTop.Controls.Add(this.txt_Memo);
            this.panelTop.Controls.Add(this.txt_Ncomprobante);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(999, 133);
            this.panelTop.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Sucursal:";
            // 
            // ucGe_Sucursal
            // 
            this.ucGe_Sucursal.Location = new System.Drawing.Point(98, 10);
            this.ucGe_Sucursal.Name = "ucGe_Sucursal";
            this.ucGe_Sucursal.Size = new System.Drawing.Size(298, 26);
            this.ucGe_Sucursal.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de Flujo:";
            // 
            // ucBa_TipoFlujo
            // 
            this.ucBa_TipoFlujo.Location = new System.Drawing.Point(484, 6);
            this.ucBa_TipoFlujo.Name = "ucBa_TipoFlujo";
            this.ucBa_TipoFlujo.Size = new System.Drawing.Size(261, 26);
            this.ucBa_TipoFlujo.TabIndex = 30;
            // 
            // ucBa_CuentaBanco
            // 
            this.ucBa_CuentaBanco.Location = new System.Drawing.Point(98, 58);
            this.ucBa_CuentaBanco.Name = "ucBa_CuentaBanco";
            this.ucBa_CuentaBanco.Size = new System.Drawing.Size(362, 26);
            this.ucBa_CuentaBanco.TabIndex = 29;
            this.ucBa_CuentaBanco.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCBa_CuentaBanco.delegate_cmb_CuentaBanco_EditValueChanged(this.ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // ucbA_TipoNota
            // 
            this.ucbA_TipoNota.Location = new System.Drawing.Point(658, 50);
            this.ucbA_TipoNota.Name = "ucbA_TipoNota";
            this.ucbA_TipoNota.Size = new System.Drawing.Size(339, 26);
            this.ucbA_TipoNota.TabIndex = 28;
            this.ucbA_TipoNota.tipoNota = Core.Erp.Info.General.Cl_Enumeradores.eTipoNotaBanco.NDBA;
            this.ucbA_TipoNota.event_cmb_TipoNota_EditValueChanged += new Core.Erp.Winform.Controles.UCBA_TipoNota.delegate_cmb_TipoNota_EditValueChanged(this.ucbA_TipoNota_event_cmb_TipoNota_EditValueChanged);
            // 
            // dt_fechaCbte
            // 
            this.dt_fechaCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaCbte.Location = new System.Drawing.Point(845, 10);
            this.dt_fechaCbte.Name = "dt_fechaCbte";
            this.dt_fechaCbte.Size = new System.Drawing.Size(100, 20);
            this.dt_fechaCbte.TabIndex = 22;
            this.dt_fechaCbte.Tag = "";
            // 
            // lblCbt_TipoAnulacion
            // 
            this.lblCbt_TipoAnulacion.AutoEllipsis = true;
            this.lblCbt_TipoAnulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbt_TipoAnulacion.ForeColor = System.Drawing.Color.Red;
            this.lblCbt_TipoAnulacion.Location = new System.Drawing.Point(436, 34);
            this.lblCbt_TipoAnulacion.Name = "lblCbt_TipoAnulacion";
            this.lblCbt_TipoAnulacion.Size = new System.Drawing.Size(144, 28);
            this.lblCbt_TipoAnulacion.TabIndex = 20;
            this.lblCbt_TipoAnulacion.Text = "***ANULADO***";
            this.lblCbt_TipoAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCbt_TipoAnulacion.Visible = false;
            // 
            // txt_Memo
            // 
            this.txt_Memo.Location = new System.Drawing.Point(98, 88);
            this.txt_Memo.Multiline = true;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(895, 38);
            this.txt_Memo.TabIndex = 24;
            // 
            // txt_Ncomprobante
            // 
            this.txt_Ncomprobante.Location = new System.Drawing.Point(98, 34);
            this.txt_Ncomprobante.Name = "txt_Ncomprobante";
            this.txt_Ncomprobante.ReadOnly = true;
            this.txt_Ncomprobante.Size = new System.Drawing.Size(105, 20);
            this.txt_Ncomprobante.TabIndex = 21;
            this.txt_Ncomprobante.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "#Movimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Motivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Observación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cuenta Bancaria:";
            // 
            // ucGe_BarraEstadoInferior_Forms2
            // 
            this.ucGe_BarraEstadoInferior_Forms2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms2.Location = new System.Drawing.Point(0, 453);
            this.ucGe_BarraEstadoInferior_Forms2.Name = "ucGe_BarraEstadoInferior_Forms2";
            this.ucGe_BarraEstadoInferior_Forms2.Size = new System.Drawing.Size(999, 26);
            this.ucGe_BarraEstadoInferior_Forms2.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Enabled_bnRetImprimir = true;
            this.Menu.Enabled_bntAnular = true;
            this.Menu.Enabled_bntAprobar = true;
            this.Menu.Enabled_bntGuardar_y_Salir = true;
            this.Menu.Enabled_bntImprimir = true;
            this.Menu.Enabled_bntImprimir_Guia = true;
            this.Menu.Enabled_bntLimpiar = true;
            this.Menu.Enabled_bntSalir = true;
            this.Menu.Enabled_btn_conciliacion_Auto = true;
            this.Menu.Enabled_btn_DiseñoReporte = true;
            this.Menu.Enabled_btn_Generar_XML = true;
            this.Menu.Enabled_btn_Imprimir_Cbte = true;
            this.Menu.Enabled_btn_Imprimir_Cheq = true;
            this.Menu.Enabled_btn_Imprimir_Reten = true;
            this.Menu.Enabled_btnAceptar = true;
            this.Menu.Enabled_btnAprobarGuardarSalir = true;
            this.Menu.Enabled_btnEstadosOC = true;
            this.Menu.Enabled_btnGuardar = true;
            this.Menu.Enabled_btnImpFrm = true;
            this.Menu.Enabled_btnImpLote = true;
            this.Menu.Enabled_btnImpRep = true;
            this.Menu.Enabled_btnImprimirSoporte = true;
            this.Menu.Enabled_btnproductos = true;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(999, 29);
            this.Menu.TabIndex = 0;
            this.Menu.Visible_bntAnular = true;
            this.Menu.Visible_bntAprobar = false;
            this.Menu.Visible_bntDiseñoReporte = false;
            this.Menu.Visible_bntGuardar_y_Salir = true;
            this.Menu.Visible_bntImprimir = true;
            this.Menu.Visible_bntImprimir_Guia = false;
            this.Menu.Visible_bntLimpiar = true;
            this.Menu.Visible_bntReImprimir = false;
            this.Menu.Visible_bntSalir = true;
            this.Menu.Visible_btn_Actualizar = false;
            this.Menu.Visible_btn_conciliacion_Auto = false;
            this.Menu.Visible_btn_Generar_XML = false;
            this.Menu.Visible_btn_Imprimir_Cbte = false;
            this.Menu.Visible_btn_Imprimir_Cheq = false;
            this.Menu.Visible_btn_Imprimir_Reten = false;
            this.Menu.Visible_btnAceptar = false;
            this.Menu.Visible_btnAprobarGuardarSalir = false;
            this.Menu.Visible_btnEstadosOC = false;
            this.Menu.Visible_btnGuardar = true;
            this.Menu.Visible_btnImpFrm = false;
            this.Menu.Visible_btnImpLote = false;
            this.Menu.Visible_btnImpRep = false;
            this.Menu.Visible_btnImprimirSoporte = false;
            this.Menu.Visible_btnproductos = false;
            this.Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.Menu_event_btnGuardar_Click);
            this.Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.Menu_event_btnGuardar_y_Salir_Click);
            this.Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.Menu_event_btnlimpiar_Click);
            this.Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.Menu_event_btnImprimir_Click);
            this.Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.Menu_event_btnAnular_Click);
            this.Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.Menu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Beneficiario1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 35);
            this.panel1.TabIndex = 29;
            // 
            // FrmBA_Debito_Mant
            // 
            this.ClientSize = new System.Drawing.Size(999, 479);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms2);
            this.Controls.Add(this.Menu);
            this.Name = "FrmBA_Debito_Mant";
            this.Text = "Notas Debito Bancaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Debito_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Debito_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControl_Data.ResumeLayout(false);
            this.tabPageDiario.ResumeLayout(false);
            this.tabPageOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAprobacionOrdenPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOP_Pendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label9;
        private Controles.UCGe_Sucursal_combo ucGe_Sucursal;
        private System.Windows.Forms.Label label1;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo;
        private Controles.UCBa_CuentaBanco ucBa_CuentaBanco;
        private Controles.UCBA_TipoNota ucbA_TipoNota;
        private System.Windows.Forms.DateTimePicker dt_fechaCbte;
        private System.Windows.Forms.Label lblCbt_TipoAnulacion;
        private System.Windows.Forms.TextBox txt_Memo;
        private System.Windows.Forms.TextBox txt_Ncomprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl_Data;
        private System.Windows.Forms.TabPage tabPageDiario;
        private Controles.UCCon_GridDiarioContable UC_Diario_x_NC;
        private System.Windows.Forms.TabPage tabPageOP;
        private DevExpress.XtraGrid.GridControl gridAprobacionOrdenPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOP_Pendientes;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo_x_Pagar_OP;
        private DevExpress.XtraGrid.Columns.GridColumn ValorAprobado;
        private DevExpress.XtraGrid.Columns.GridColumn Valor_a_Cancelar_OPGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit check;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Beneficiario_2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia2;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Pagar2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_op;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private System.Windows.Forms.Label label3;
        private Controles.UCGe_Beneficiario ucGe_Beneficiario1;
        private System.Windows.Forms.Panel panel1;

        
        
    }
}
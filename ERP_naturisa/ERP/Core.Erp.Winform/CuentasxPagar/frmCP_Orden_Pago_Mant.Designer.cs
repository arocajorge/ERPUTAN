namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Orden_Pago_Mant
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vwtbpersonabeneficiarioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpproveedorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpproveedorGridInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dteFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cmbOrdTipPag = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cpordenpagotipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipo_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneraDiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_OP_anulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Credito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumOrden = new DevExpress.XtraEditors.TextEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlDeudas = new DevExpress.XtraGrid.GridControl();
            this.vwcpCbtexpagarOGInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDeudas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fechaOg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_Valorpagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_Respaldado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoPendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoAUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_a_pagar_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_op1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipo_Persona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_a_Pagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_a_pagar_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotPagar = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UC_DiarioContPago = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ucBa_TipoFlujo = new Core.Erp.Winform.Controles.UCBa_TipoFlujo();
            this.ucGe_Beneficiario = new Core.Erp.Winform.Controles.UCGe_Beneficiario();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoOP = new System.Windows.Forms.TextBox();
            this.lblSaldoOP = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dteFechaPago = new DevExpress.XtraEditors.DateEdit();
            this.cmbFormaPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cpordenpagoformapagoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovi_caj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Ultimo_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_num_digito_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.vwtbpersonabeneficiarioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorGridInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdTipPag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagotipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOrden.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeudas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcpCbtexpagarOGInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeudas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPagar.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaPago.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoformapagoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observación:";
            // 
            // vwtbpersonabeneficiarioInfoBindingSource
            // 
            this.vwtbpersonabeneficiarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.vwtb_persona_beneficiario_Info);
            // 
            // cpproveedorInfoBindingSource
            // 
            this.cpproveedorInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // cpproveedorGridInfoBindingSource
            // 
            this.cpproveedorGridInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // dteFecha
            // 
            this.dteFecha.EditValue = null;
            this.dteFecha.Location = new System.Drawing.Point(670, 13);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFecha.Size = new System.Drawing.Size(126, 20);
            this.dteFecha.TabIndex = 8;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(100, 95);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(696, 38);
            this.txtObservacion.TabIndex = 9;
            // 
            // cmbOrdTipPag
            // 
            this.cmbOrdTipPag.Location = new System.Drawing.Point(100, 69);
            this.cmbOrdTipPag.Name = "cmbOrdTipPag";
            this.cmbOrdTipPag.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbOrdTipPag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOrdTipPag.Properties.DataSource = this.cpordenpagotipoInfoBindingSource;
            this.cmbOrdTipPag.Properties.DisplayMember = "Descripcion";
            this.cmbOrdTipPag.Properties.ValueMember = "IdTipo_op";
            this.cmbOrdTipPag.Properties.View = this.gridView1;
            this.cmbOrdTipPag.Size = new System.Drawing.Size(286, 20);
            this.cmbOrdTipPag.TabIndex = 10;
            this.cmbOrdTipPag.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cmbOrdTipPag_Closed);
            this.cmbOrdTipPag.EditValueChanged += new System.EventHandler(this.cmbOrdTipPag_EditValueChanged);
            // 
            // cpordenpagotipoInfoBindingSource
            // 
            this.cpordenpagotipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_tipo_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipo_op,
            this.colDescripcion,
            this.colEstado,
            this.colGeneraDiario,
            this.colIdCentroCosto,
            this.colIdEmpresa3,
            this.colIdEstadoAprobacion1,
            this.colIdTipoCbte_OP,
            this.colIdTipoCbte_OP_anulacion,
            this.colIdCtaCble1,
            this.colIdCtaCble_Credito});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipo_op
            // 
            this.colIdTipo_op.Caption = "Código";
            this.colIdTipo_op.FieldName = "IdTipo_op";
            this.colIdTipo_op.Name = "colIdTipo_op";
            this.colIdTipo_op.Visible = true;
            this.colIdTipo_op.VisibleIndex = 1;
            this.colIdTipo_op.Width = 85;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 615;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 143;
            // 
            // colGeneraDiario
            // 
            this.colGeneraDiario.FieldName = "GeneraDiario";
            this.colGeneraDiario.Name = "colGeneraDiario";
            this.colGeneraDiario.Visible = true;
            this.colGeneraDiario.VisibleIndex = 4;
            this.colGeneraDiario.Width = 128;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            // 
            // colIdEmpresa3
            // 
            this.colIdEmpresa3.FieldName = "IdEmpresa";
            this.colIdEmpresa3.Name = "colIdEmpresa3";
            // 
            // colIdEstadoAprobacion1
            // 
            this.colIdEstadoAprobacion1.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion1.Name = "colIdEstadoAprobacion1";
            // 
            // colIdTipoCbte_OP
            // 
            this.colIdTipoCbte_OP.FieldName = "IdTipoCbte_OP";
            this.colIdTipoCbte_OP.Name = "colIdTipoCbte_OP";
            // 
            // colIdTipoCbte_OP_anulacion
            // 
            this.colIdTipoCbte_OP_anulacion.FieldName = "IdTipoCbte_OP_anulacion";
            this.colIdTipoCbte_OP_anulacion.Name = "colIdTipoCbte_OP_anulacion";
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.Caption = "Cta Cble Deudora";
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            this.colIdCtaCble1.Visible = true;
            this.colIdCtaCble1.VisibleIndex = 2;
            this.colIdCtaCble1.Width = 110;
            // 
            // colIdCtaCble_Credito
            // 
            this.colIdCtaCble_Credito.Caption = "Cta Cble Acreedora";
            this.colIdCtaCble_Credito.FieldName = "IdCtaCble_Credito";
            this.colIdCtaCble_Credito.Name = "colIdCtaCble_Credito";
            this.colIdCtaCble_Credito.Visible = true;
            this.colIdCtaCble_Credito.VisibleIndex = 3;
            this.colIdCtaCble_Credito.Width = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Orden de pago #:";
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Location = new System.Drawing.Point(101, 13);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(97, 20);
            this.txtNumOrden.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 388);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlDeudas);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deudas a Cancelar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlDeudas
            // 
            this.gridControlDeudas.DataSource = this.vwcpCbtexpagarOGInfoBindingSource;
            this.gridControlDeudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDeudas.Location = new System.Drawing.Point(3, 3);
            this.gridControlDeudas.MainView = this.gridViewDeudas;
            this.gridControlDeudas.Name = "gridControlDeudas";
            this.gridControlDeudas.Size = new System.Drawing.Size(1034, 317);
            this.gridControlDeudas.TabIndex = 17;
            this.gridControlDeudas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeudas});
            // 
            // vwcpCbtexpagarOGInfoBindingSource
            // 
            this.vwcpCbtexpagarOGInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.vwcp_Cbte_x_pagar_OG_Info);
            // 
            // gridViewDeudas
            // 
            this.gridViewDeudas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa2,
            this.colem_nombre,
            this.colIdCbteCble_Ogiro,
            this.colIdTipoCbte_Ogiro,
            this.colIdProveedor1,
            this.colNomProveedor,
            this.colco_fechaOg,
            this.colco_factura,
            this.colco_observacion,
            this.colco_serie,
            this.colco_total,
            this.colco_Valorpagar,
            this.colValor_Respaldado,
            this.colSaldoPendiente,
            this.colTipoReg,
            this.colDescripcion2,
            this.colCodTipoDocumento,
            this.colReferencia,
            this.colSaldoAUX,
            this.colcheck,
            this.colValor_a_pagar_User,
            this.colIdOrdenPago,
            this.colObservacion,
            this.colIdTipo_op1,
            this.colIdTipo_Persona,
            this.colIdPersona1,
            this.colFecha,
            this.colEstado2,
            this.colIdEstadoAprobacion,
            this.colSecuencia,
            this.colreferencia1,
            this.colTotal_a_Pagar,
            this.colTotal_a_pagar_OP,
            this.colTotal_Retencion});
            this.gridViewDeudas.CustomizationFormBounds = new System.Drawing.Rectangle(823, 457, 210, 179);
            this.gridViewDeudas.GridControl = this.gridControlDeudas;
            this.gridViewDeudas.Name = "gridViewDeudas";
            this.gridViewDeudas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewDeudas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDeudas.OptionsView.ShowFooter = true;
            this.gridViewDeudas.OptionsView.ShowGroupPanel = false;
            this.gridViewDeudas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDeudas_RowClick);
            this.gridViewDeudas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewDeudas_CellValueChanged);
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            // 
            // colem_nombre
            // 
            this.colem_nombre.FieldName = "em_nombre";
            this.colem_nombre.Name = "colem_nombre";
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.Caption = "# Cble";
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Ogiro.Visible = true;
            this.colIdCbteCble_Ogiro.VisibleIndex = 4;
            this.colIdCbteCble_Ogiro.Width = 71;
            // 
            // colIdTipoCbte_Ogiro
            // 
            this.colIdTipoCbte_Ogiro.FieldName = "IdTipoCbte_Ogiro";
            this.colIdTipoCbte_Ogiro.Name = "colIdTipoCbte_Ogiro";
            // 
            // colIdProveedor1
            // 
            this.colIdProveedor1.FieldName = "IdProveedor";
            this.colIdProveedor1.Name = "colIdProveedor1";
            // 
            // colNomProveedor
            // 
            this.colNomProveedor.FieldName = "NomProveedor";
            this.colNomProveedor.Name = "colNomProveedor";
            // 
            // colco_fechaOg
            // 
            this.colco_fechaOg.Caption = "Fecha";
            this.colco_fechaOg.FieldName = "co_fechaOg";
            this.colco_fechaOg.Name = "colco_fechaOg";
            this.colco_fechaOg.OptionsColumn.AllowEdit = false;
            this.colco_fechaOg.Visible = true;
            this.colco_fechaOg.VisibleIndex = 5;
            this.colco_fechaOg.Width = 89;
            // 
            // colco_factura
            // 
            this.colco_factura.FieldName = "co_factura";
            this.colco_factura.Name = "colco_factura";
            // 
            // colco_observacion
            // 
            this.colco_observacion.FieldName = "co_observacion";
            this.colco_observacion.Name = "colco_observacion";
            this.colco_observacion.Visible = true;
            this.colco_observacion.VisibleIndex = 3;
            this.colco_observacion.Width = 214;
            // 
            // colco_serie
            // 
            this.colco_serie.FieldName = "co_serie";
            this.colco_serie.Name = "colco_serie";
            // 
            // colco_total
            // 
            this.colco_total.Caption = "Total Factura";
            this.colco_total.FieldName = "co_total";
            this.colco_total.Name = "colco_total";
            this.colco_total.OptionsColumn.AllowEdit = false;
            this.colco_total.Visible = true;
            this.colco_total.VisibleIndex = 6;
            this.colco_total.Width = 54;
            // 
            // colco_Valorpagar
            // 
            this.colco_Valorpagar.Caption = "Total a Pagar";
            this.colco_Valorpagar.FieldName = "co_Valorpagar";
            this.colco_Valorpagar.Name = "colco_Valorpagar";
            this.colco_Valorpagar.Visible = true;
            this.colco_Valorpagar.VisibleIndex = 8;
            this.colco_Valorpagar.Width = 83;
            // 
            // colValor_Respaldado
            // 
            this.colValor_Respaldado.Caption = "Valor a Cancelar";
            this.colValor_Respaldado.FieldName = "Valor_Respaldado";
            this.colValor_Respaldado.Name = "colValor_Respaldado";
            this.colValor_Respaldado.Visible = true;
            this.colValor_Respaldado.VisibleIndex = 10;
            this.colValor_Respaldado.Width = 130;
            // 
            // colSaldoPendiente
            // 
            this.colSaldoPendiente.Caption = "Saldo pendiente";
            this.colSaldoPendiente.FieldName = "SaldoPendiente";
            this.colSaldoPendiente.Name = "colSaldoPendiente";
            this.colSaldoPendiente.OptionsColumn.AllowEdit = false;
            this.colSaldoPendiente.Visible = true;
            this.colSaldoPendiente.VisibleIndex = 9;
            this.colSaldoPendiente.Width = 83;
            // 
            // colTipoReg
            // 
            this.colTipoReg.Caption = "Tipo";
            this.colTipoReg.FieldName = "TipoReg";
            this.colTipoReg.Name = "colTipoReg";
            this.colTipoReg.OptionsColumn.AllowEdit = false;
            this.colTipoReg.Visible = true;
            this.colTipoReg.VisibleIndex = 1;
            this.colTipoReg.Width = 88;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            // 
            // colCodTipoDocumento
            // 
            this.colCodTipoDocumento.FieldName = "CodTipoDocumento";
            this.colCodTipoDocumento.Name = "colCodTipoDocumento";
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.AllowEdit = false;
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 2;
            this.colReferencia.Width = 118;
            // 
            // colSaldoAUX
            // 
            this.colSaldoAUX.FieldName = "SaldoAUX";
            this.colSaldoAUX.Name = "colSaldoAUX";
            // 
            // colcheck
            // 
            this.colcheck.Caption = "*";
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.AllowEdit = false;
            this.colcheck.OptionsColumn.AllowSize = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 21;
            // 
            // colValor_a_pagar_User
            // 
            this.colValor_a_pagar_User.FieldName = "Valor_a_pagar_User";
            this.colValor_a_pagar_User.Name = "colValor_a_pagar_User";
            // 
            // colIdOrdenPago
            // 
            this.colIdOrdenPago.FieldName = "IdOrdenPago";
            this.colIdOrdenPago.Name = "colIdOrdenPago";
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            // 
            // colIdTipo_op1
            // 
            this.colIdTipo_op1.FieldName = "IdTipo_op";
            this.colIdTipo_op1.Name = "colIdTipo_op1";
            // 
            // colIdTipo_Persona
            // 
            this.colIdTipo_Persona.FieldName = "IdTipo_Persona";
            this.colIdTipo_Persona.Name = "colIdTipo_Persona";
            // 
            // colIdPersona1
            // 
            this.colIdPersona1.FieldName = "IdPersona";
            this.colIdPersona1.Name = "colIdPersona1";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colEstado2
            // 
            this.colEstado2.FieldName = "Estado";
            this.colEstado2.Name = "colEstado2";
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colreferencia1
            // 
            this.colreferencia1.FieldName = "referencia";
            this.colreferencia1.Name = "colreferencia1";
            // 
            // colTotal_a_Pagar
            // 
            this.colTotal_a_Pagar.FieldName = "Total_a_Pagar";
            this.colTotal_a_Pagar.Name = "colTotal_a_Pagar";
            // 
            // colTotal_a_pagar_OP
            // 
            this.colTotal_a_pagar_OP.FieldName = "Total_a_pagar_OP";
            this.colTotal_a_pagar_OP.Name = "colTotal_a_pagar_OP";
            this.colTotal_a_pagar_OP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            // 
            // colTotal_Retencion
            // 
            this.colTotal_Retencion.Caption = "Valor Retenido";
            this.colTotal_Retencion.FieldName = "Total_Retencion";
            this.colTotal_Retencion.Name = "colTotal_Retencion";
            this.colTotal_Retencion.OptionsColumn.AllowEdit = false;
            this.colTotal_Retencion.Visible = true;
            this.colTotal_Retencion.VisibleIndex = 7;
            this.colTotal_Retencion.Width = 65;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotPagar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 39);
            this.panel2.TabIndex = 16;
            // 
            // txtTotPagar
            // 
            this.txtTotPagar.Location = new System.Drawing.Point(706, 3);
            this.txtTotPagar.Name = "txtTotPagar";
            this.txtTotPagar.Size = new System.Drawing.Size(97, 20);
            this.txtTotPagar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total a pagar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UC_DiarioContPago);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asiento Contable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UC_DiarioContPago
            // 
            this.UC_DiarioContPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_DiarioContPago.IdCtaCble_x_Banco = null;
            this.UC_DiarioContPago.Location = new System.Drawing.Point(3, 3);
            this.UC_DiarioContPago.Name = "UC_DiarioContPago";
            this.UC_DiarioContPago.Size = new System.Drawing.Size(1034, 356);
            this.UC_DiarioContPago.TabIndex = 0;
            this.UC_DiarioContPago.Visible_Botones = true;
            this.UC_DiarioContPago.Visible_Cabecera = false;
            this.UC_DiarioContPago.Visible_columna_GrupoPuntoCargo = true;
            this.UC_DiarioContPago.Visible_columna_PuntoCargo = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ucBa_TipoFlujo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbOrdTipPag);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.ucGe_Beneficiario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSaldoOP);
            this.groupBox2.Controls.Add(this.lblSaldoOP);
            this.groupBox2.Controls.Add(this.lblAnulado);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNumOrden);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dteFecha);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 216);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tipo de Flujo:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ucBa_TipoFlujo
            // 
            this.ucBa_TipoFlujo.Location = new System.Drawing.Point(531, 65);
            this.ucBa_TipoFlujo.Name = "ucBa_TipoFlujo";
            this.ucBa_TipoFlujo.Size = new System.Drawing.Size(311, 26);
            this.ucBa_TipoFlujo.TabIndex = 19;
            this.ucBa_TipoFlujo.Load += new System.EventHandler(this.ucBa_TipoFlujo_Load);
            // 
            // ucGe_Beneficiario
            // 
            this.ucGe_Beneficiario.IdTipo_Persona = Core.Erp.Info.General.Cl_Enumeradores.eTipoPersona.CLIENTE;
            this.ucGe_Beneficiario.Location = new System.Drawing.Point(95, 39);
            this.ucGe_Beneficiario.Name = "ucGe_Beneficiario";
            this.ucGe_Beneficiario.Size = new System.Drawing.Size(747, 34);
            this.ucGe_Beneficiario.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Buscar por:";
            // 
            // txtSaldoOP
            // 
            this.txtSaldoOP.Location = new System.Drawing.Point(742, 152);
            this.txtSaldoOP.Name = "txtSaldoOP";
            this.txtSaldoOP.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoOP.TabIndex = 17;
            // 
            // lblSaldoOP
            // 
            this.lblSaldoOP.AutoSize = true;
            this.lblSaldoOP.Location = new System.Drawing.Point(672, 159);
            this.lblSaldoOP.Name = "lblSaldoOP";
            this.lblSaldoOP.Size = new System.Drawing.Size(55, 13);
            this.lblSaldoOP.TabIndex = 15;
            this.lblSaldoOP.Text = "Saldo OP:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(331, 10);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(172, 26);
            this.lblAnulado.TabIndex = 15;
            this.lblAnulado.Text = "*** ANULADO ***";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dteFechaPago);
            this.groupBox3.Controls.Add(this.cmbFormaPago);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbBanco);
            this.groupBox3.Location = new System.Drawing.Point(101, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 67);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Cancelación:";
            // 
            // dteFechaPago
            // 
            this.dteFechaPago.EditValue = null;
            this.dteFechaPago.Location = new System.Drawing.Point(408, 17);
            this.dteFechaPago.Name = "dteFechaPago";
            this.dteFechaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFechaPago.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFechaPago.Size = new System.Drawing.Size(146, 20);
            this.dteFechaPago.TabIndex = 5;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Location = new System.Drawing.Point(98, 17);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFormaPago.Properties.DataSource = this.cpordenpagoformapagoInfoBindingSource;
            this.cmbFormaPago.Properties.DisplayMember = "descripcion";
            this.cmbFormaPago.Properties.ValueMember = "IdFormaPago";
            this.cmbFormaPago.Properties.View = this.gridView2;
            this.cmbFormaPago.Size = new System.Drawing.Size(188, 20);
            this.cmbFormaPago.TabIndex = 3;
            this.cmbFormaPago.EditValueChanged += new System.EventHandler(this.cmbFormaPago_EditValueChanged);
            // 
            // cpordenpagoformapagoInfoBindingSource
            // 
            this.cpordenpagoformapagoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_orden_pago_formapago_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFormaPago,
            this.coldescripcion1,
            this.colIdTipoTransaccion,
            this.colCodModulo,
            this.colIdTipoMovi_caj});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha de pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Forma de pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Banco:";
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(98, 41);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.DataSource = this.baBancoCuentaInfoBindingSource;
            this.cmbBanco.Properties.DisplayMember = "ba_descripcion";
            this.cmbBanco.Properties.ValueMember = "IdBanco";
            this.cmbBanco.Properties.View = this.searchLookUpEdit2View;
            this.cmbBanco.Size = new System.Drawing.Size(188, 20);
            this.cmbBanco.TabIndex = 4;
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdBanco,
            this.colba_descripcion,
            this.colba_Tipo,
            this.colba_Num_Cuenta,
            this.colba_Moneda,
            this.colba_Ultimo_Cheque,
            this.colba_num_digito_cheq,
            this.colIdCtaCble,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colnom_pc,
            this.colip,
            this.colestado1});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 1;
            this.colIdBanco.Width = 227;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 0;
            this.colba_descripcion.Width = 717;
            // 
            // colba_Tipo
            // 
            this.colba_Tipo.FieldName = "ba_Tipo";
            this.colba_Tipo.Name = "colba_Tipo";
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            // 
            // colba_Moneda
            // 
            this.colba_Moneda.FieldName = "ba_Moneda";
            this.colba_Moneda.Name = "colba_Moneda";
            // 
            // colba_Ultimo_Cheque
            // 
            this.colba_Ultimo_Cheque.FieldName = "ba_Ultimo_Cheque";
            this.colba_Ultimo_Cheque.Name = "colba_Ultimo_Cheque";
            // 
            // colba_num_digito_cheq
            // 
            this.colba_num_digito_cheq.FieldName = "ba_num_digito_cheq";
            this.colba_num_digito_cheq.Name = "colba_num_digito_cheq";
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colestado1
            // 
            this.colestado1.FieldName = "estado";
            this.colestado1.Name = "colestado1";
            this.colestado1.Visible = true;
            this.colestado1.VisibleIndex = 2;
            this.colestado1.Width = 230;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 680);
            this.panel1.TabIndex = 17;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 26);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1054, 628);
            this.splitContainerControl1.SplitterPosition = 216;
            this.splitContainerControl1.TabIndex = 18;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 654);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1054, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 17;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1054, 26);
            this.ucGe_Menu.TabIndex = 16;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // frmCP_Orden_Pago_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 680);
            this.Controls.Add(this.panel1);
            this.Name = "frmCP_Orden_Pago_Mant";
            this.Text = "Mantenimiento Orden de Pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCP_Orden_Pago_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCP_Orden_Pago_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwtbpersonabeneficiarioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorGridInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdTipPag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagotipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOrden.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeudas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcpCbtexpagarOGInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeudas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPagar.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaPago.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpordenpagoformapagoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dteFecha;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbOrdTipPag;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtNumOrden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.TextEdit txtTotPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource cpproveedorGridInfoBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit dteFechaPago;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbFormaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource baBancoCuentaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Ultimo_Cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colba_num_digito_cheq;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colestado1;
        private System.Windows.Forms.BindingSource cpordenpagoformapagoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovi_caj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource cpordenpagotipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_op;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneraDiario;
        private Controles.UCCon_GridDiarioContable UC_DiarioContPago;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource;
        private System.Windows.Forms.BindingSource vwcpCbtexpagarOGInfoBindingSource;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_OP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_OP_anulacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource vwtbpersonabeneficiarioInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlDeudas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeudas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colem_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fechaOg;
        private DevExpress.XtraGrid.Columns.GridColumn colco_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colco_total;
        private DevExpress.XtraGrid.Columns.GridColumn colco_Valorpagar;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_Respaldado;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoPendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoReg;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoAUX;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_a_pagar_User;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_op1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipo_Persona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_a_Pagar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_a_pagar_OP;
        private System.Windows.Forms.TextBox txtSaldoOP;
        private System.Windows.Forms.Label lblSaldoOP;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Retencion;
        private System.Windows.Forms.Label label11;
        private Controles.UCBa_TipoFlujo ucBa_TipoFlujo;
        private Controles.UCGe_Beneficiario ucGe_Beneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Credito;
    }
}
namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Cobros_x_Ventas_Mant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txe_saldo = new DevExpress.XtraEditors.TextEdit();
            this.txe_total = new DevExpress.XtraEditors.TextEdit();
            this.btn_ApliReten = new System.Windows.Forms.Button();
            this.lbl_IdBodega = new System.Windows.Forms.TextBox();
            this.cmbCaja = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cajCajaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_usuarioResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_bodega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.griddetalle = new DevExpress.XtraGrid.GridControl();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_detalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTipoCobro = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcr_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditBanco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaDocu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega_Cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTarjeta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.tbtarjetaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltr_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditFecha = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemComboBoxTipoCobro = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl_NCND = new DevExpress.XtraGrid.GridControl();
            this.cxccobroxcajCajaMovimientoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_NCND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcbr_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcbr_IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcbr_IdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmcj_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmcj_IdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmcj_IdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovi_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_CbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEfectivo = new DevExpress.XtraEditors.TextEdit();
            this.txtChq_Tarj = new DevExpress.XtraEditors.TextEdit();
            this.txtOtros = new DevExpress.XtraEditors.TextEdit();
            this.txtDeposito = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalCobrado = new DevExpress.XtraEditors.TextEdit();
            this.txtCHQF = new DevExpress.XtraEditors.TextEdit();
            this.txtCXC = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_propietarioCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_es_anticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNotaCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVendedorCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_MoviCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte_MoviCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_a_aplicar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPagoTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuentaTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchequeTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_TipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbte_vta_nota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_ValorPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento_Cobrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTipoCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtarjetaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFecha.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxTipoCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NCND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxcajCajaMovimientoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NCND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChq_Tarj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCobrado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHQF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCXC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txe_saldo);
            this.groupBox1.Controls.Add(this.txe_total);
            this.groupBox1.Controls.Add(this.btn_ApliReten);
            this.groupBox1.Controls.Add(this.lbl_IdBodega);
            this.groupBox1.Controls.Add(this.cmbCaja);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_NDoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.txt_bodega);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_sucursal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 154);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Factura";
            // 
            // txe_saldo
            // 
            this.txe_saldo.Location = new System.Drawing.Point(718, 124);
            this.txe_saldo.Name = "txe_saldo";
            this.txe_saldo.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_saldo.Properties.ReadOnly = true;
            this.txe_saldo.Size = new System.Drawing.Size(129, 20);
            this.txe_saldo.TabIndex = 78;
            // 
            // txe_total
            // 
            this.txe_total.Location = new System.Drawing.Point(718, 98);
            this.txe_total.Name = "txe_total";
            this.txe_total.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_total.Properties.ReadOnly = true;
            this.txe_total.Size = new System.Drawing.Size(129, 20);
            this.txe_total.TabIndex = 77;
            // 
            // btn_ApliReten
            // 
            this.btn_ApliReten.Location = new System.Drawing.Point(445, 102);
            this.btn_ApliReten.Name = "btn_ApliReten";
            this.btn_ApliReten.Size = new System.Drawing.Size(115, 29);
            this.btn_ApliReten.TabIndex = 76;
            this.btn_ApliReten.Text = "Aplicar Retenciones";
            this.btn_ApliReten.UseVisualStyleBackColor = true;
            this.btn_ApliReten.Visible = false;
            this.btn_ApliReten.Click += new System.EventHandler(this.btn_ApliReten_Click);
            // 
            // lbl_IdBodega
            // 
            this.lbl_IdBodega.Location = new System.Drawing.Point(566, 24);
            this.lbl_IdBodega.Name = "lbl_IdBodega";
            this.lbl_IdBodega.ReadOnly = true;
            this.lbl_IdBodega.Size = new System.Drawing.Size(32, 20);
            this.lbl_IdBodega.TabIndex = 75;
            this.lbl_IdBodega.Text = "0";
            // 
            // cmbCaja
            // 
            this.cmbCaja.Location = new System.Drawing.Point(97, 105);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCaja.Properties.DataSource = this.cajCajaInfoBindingSource;
            this.cmbCaja.Properties.DisplayMember = "ca_Descripcion";
            this.cmbCaja.Properties.ValueMember = "IdCaja";
            this.cmbCaja.Properties.View = this.searchLookUpEdit1View;
            this.cmbCaja.Size = new System.Drawing.Size(165, 20);
            this.cmbCaja.TabIndex = 74;
            // 
            // cajCajaInfoBindingSource
            // 
            this.cajCajaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Caja.caj_Caja_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCaja,
            this.colca_Codigo,
            this.colca_Descripcion,
            this.colca_Moneda,
            this.colIdCtaCble,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado,
            this.colIdUsuario_Responsable,
            this.colMotivoAnu,
            this.colN_usuarioResponsable,
            this.colIdSucursal,
            this.colNSucursal});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCaja
            // 
            this.colIdCaja.Caption = "Código";
            this.colIdCaja.FieldName = "IdCaja";
            this.colIdCaja.Name = "colIdCaja";
            this.colIdCaja.Visible = true;
            this.colIdCaja.VisibleIndex = 1;
            this.colIdCaja.Width = 236;
            // 
            // colca_Codigo
            // 
            this.colca_Codigo.FieldName = "ca_Codigo";
            this.colca_Codigo.Name = "colca_Codigo";
            // 
            // colca_Descripcion
            // 
            this.colca_Descripcion.Caption = "Descripción";
            this.colca_Descripcion.FieldName = "ca_Descripcion";
            this.colca_Descripcion.Name = "colca_Descripcion";
            this.colca_Descripcion.Visible = true;
            this.colca_Descripcion.VisibleIndex = 0;
            this.colca_Descripcion.Width = 938;
            // 
            // colca_Moneda
            // 
            this.colca_Moneda.FieldName = "ca_Moneda";
            this.colca_Moneda.Name = "colca_Moneda";
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
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
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
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colIdUsuario_Responsable
            // 
            this.colIdUsuario_Responsable.FieldName = "IdUsuario_Responsable";
            this.colIdUsuario_Responsable.Name = "colIdUsuario_Responsable";
            // 
            // colMotivoAnu
            // 
            this.colMotivoAnu.FieldName = "MotivoAnu";
            this.colMotivoAnu.Name = "colMotivoAnu";
            // 
            // colN_usuarioResponsable
            // 
            this.colN_usuarioResponsable.FieldName = "N_usuarioResponsable";
            this.colN_usuarioResponsable.Name = "colN_usuarioResponsable";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colNSucursal
            // 
            this.colNSucursal.FieldName = "NSucursal";
            this.colNSucursal.Name = "colNSucursal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Caja:";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(718, 72);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(129, 20);
            this.txtIva.TabIndex = 72;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(718, 47);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(129, 20);
            this.txtSubtotal.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Iva:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Subtotal:";
            // 
            // txt_NDoc
            // 
            this.txt_NDoc.Location = new System.Drawing.Point(97, 79);
            this.txt_NDoc.Name = "txt_NDoc";
            this.txt_NDoc.ReadOnly = true;
            this.txt_NDoc.Size = new System.Drawing.Size(463, 20);
            this.txt_NDoc.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "# Fact./# Not.:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(718, 21);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(129, 20);
            this.dtp_fecha.TabIndex = 66;
            // 
            // txt_bodega
            // 
            this.txt_bodega.Location = new System.Drawing.Point(381, 24);
            this.txt_bodega.Name = "txt_bodega";
            this.txt_bodega.ReadOnly = true;
            this.txt_bodega.Size = new System.Drawing.Size(179, 20);
            this.txt_bodega.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Bodega:";
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Location = new System.Drawing.Point(97, 24);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.ReadOnly = true;
            this.txt_sucursal.Size = new System.Drawing.Size(218, 20);
            this.txt_sucursal.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sucursal:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(97, 52);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(463, 20);
            this.txt_cliente.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Saldo por Cobrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(0, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 220);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aplicar Nota de Credito/Nota de Debito";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 196);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.griddetalle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle de cobros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // griddetalle
            // 
            this.griddetalle.DataSource = this.cxccobroInfoBindingSource;
            this.griddetalle.Location = new System.Drawing.Point(6, 6);
            this.griddetalle.MainView = this.gridView_detalle;
            this.griddetalle.Name = "griddetalle";
            this.griddetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditFecha,
            this.repositoryItemComboBoxTipoCobro,
            this.repositoryItemGridLookUpEditBanco,
            this.repositoryItemGridLookUpEditTipoCobro,
            this.cmbTarjeta,
            this.repositoryItemButtonEdit1});
            this.griddetalle.Size = new System.Drawing.Size(832, 158);
            this.griddetalle.TabIndex = 28;
            this.griddetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_detalle});
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // gridView_detalle
            // 
            this.gridView_detalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipocbte,
            this.colIdCobro_tipo,
            this.colcr_Valor,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_NumDocumento,
            this.colcr_observacion,
            this.colcr_fechaCobro,
            this.colcr_fechaDocu,
            this.colIdCobro,
            this.colIdBodega_Cbte,
            this.colcr_Tarjeta});
            this.gridView_detalle.CustomizationFormBounds = new System.Drawing.Rectangle(701, 392, 210, 179);
            this.gridView_detalle.GridControl = this.griddetalle;
            this.gridView_detalle.Name = "gridView_detalle";
            this.gridView_detalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_detalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_detalle.OptionsView.ShowAutoFilterRow = true;
            this.gridView_detalle.OptionsView.ShowGroupPanel = false;
            this.gridView_detalle.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_detalle_RowCellStyle);
            this.gridView_detalle.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_detalle_InitNewRow);
            this.gridView_detalle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_detalle_FocusedRowChanged);
            this.gridView_detalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_detalle_CellValueChanged);
            this.gridView_detalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_detalle_KeyDown);
            // 
            // colIdTipocbte
            // 
            this.colIdTipocbte.Caption = "Tipo Cbte.";
            this.colIdTipocbte.FieldName = "IdTipocbte";
            this.colIdTipocbte.Name = "colIdTipocbte";
            this.colIdTipocbte.Width = 83;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.Caption = "Tipo Cobro";
            this.colIdCobro_tipo.ColumnEdit = this.repositoryItemGridLookUpEditTipoCobro;
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 0;
            this.colIdCobro_tipo.Width = 99;
            // 
            // repositoryItemGridLookUpEditTipoCobro
            // 
            this.repositoryItemGridLookUpEditTipoCobro.AutoHeight = false;
            this.repositoryItemGridLookUpEditTipoCobro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTipoCobro.DisplayMember = "IdCobro_tipo";
            this.repositoryItemGridLookUpEditTipoCobro.Name = "repositoryItemGridLookUpEditTipoCobro";
            this.repositoryItemGridLookUpEditTipoCobro.ValueMember = "IdCobro_tipo";
            this.repositoryItemGridLookUpEditTipoCobro.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colcr_Valor
            // 
            this.colcr_Valor.Caption = "Valor";
            this.colcr_Valor.FieldName = "dc_ValorPago";
            this.colcr_Valor.Name = "colcr_Valor";
            this.colcr_Valor.Visible = true;
            this.colcr_Valor.VisibleIndex = 1;
            this.colcr_Valor.Width = 104;
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.Caption = "Banco";
            this.colcr_Banco.ColumnEdit = this.repositoryItemGridLookUpEditBanco;
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            this.colcr_Banco.Visible = true;
            this.colcr_Banco.VisibleIndex = 3;
            this.colcr_Banco.Width = 143;
            // 
            // repositoryItemGridLookUpEditBanco
            // 
            this.repositoryItemGridLookUpEditBanco.AutoHeight = false;
            this.repositoryItemGridLookUpEditBanco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditBanco.DisplayMember = "ba_descripcion";
            this.repositoryItemGridLookUpEditBanco.Name = "repositoryItemGridLookUpEditBanco";
            this.repositoryItemGridLookUpEditBanco.ValueMember = "ba_descripcion";
            this.repositoryItemGridLookUpEditBanco.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.Caption = "Cuenta";
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            this.colcr_cuenta.Visible = true;
            this.colcr_cuenta.VisibleIndex = 2;
            this.colcr_cuenta.Width = 145;
            // 
            // colcr_NumDocumento
            // 
            this.colcr_NumDocumento.Caption = "#Documento";
            this.colcr_NumDocumento.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento.Name = "colcr_NumDocumento";
            this.colcr_NumDocumento.Visible = true;
            this.colcr_NumDocumento.VisibleIndex = 4;
            this.colcr_NumDocumento.Width = 152;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.Caption = "Observación";
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            this.colcr_observacion.Visible = true;
            this.colcr_observacion.VisibleIndex = 5;
            this.colcr_observacion.Width = 252;
            // 
            // colcr_fechaCobro
            // 
            this.colcr_fechaCobro.Caption = "Fecha Cobro";
            this.colcr_fechaCobro.FieldName = "cr_fechaCobro";
            this.colcr_fechaCobro.Name = "colcr_fechaCobro";
            this.colcr_fechaCobro.Width = 95;
            // 
            // colcr_fechaDocu
            // 
            this.colcr_fechaDocu.Caption = "Fecha Doc.";
            this.colcr_fechaDocu.FieldName = "cr_fechaDocu";
            this.colcr_fechaDocu.Name = "colcr_fechaDocu";
            this.colcr_fechaDocu.Width = 87;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            // 
            // colIdBodega_Cbte
            // 
            this.colIdBodega_Cbte.FieldName = "IdBodega_Cbte";
            this.colIdBodega_Cbte.Name = "colIdBodega_Cbte";
            // 
            // colcr_Tarjeta
            // 
            this.colcr_Tarjeta.Caption = "Tarjeta";
            this.colcr_Tarjeta.ColumnEdit = this.cmbTarjeta;
            this.colcr_Tarjeta.FieldName = "cr_Tarjeta";
            this.colcr_Tarjeta.Name = "colcr_Tarjeta";
            this.colcr_Tarjeta.Width = 97;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.AutoHeight = false;
            this.cmbTarjeta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTarjeta.DataSource = this.tbtarjetaInfoBindingSource;
            this.cmbTarjeta.DisplayMember = "tr_Descripcion";
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.ValueMember = "tr_Descripcion";
            this.cmbTarjeta.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // tbtarjetaInfoBindingSource
            // 
            this.tbtarjetaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_tarjeta_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTarjeta,
            this.coltr_Descripcion,
            this.colIdBanco,
            this.colEstado1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTarjeta
            // 
            this.colIdTarjeta.Caption = "IdTarjeta";
            this.colIdTarjeta.FieldName = "IdTarjeta";
            this.colIdTarjeta.Name = "colIdTarjeta";
            this.colIdTarjeta.Visible = true;
            this.colIdTarjeta.VisibleIndex = 1;
            this.colIdTarjeta.Width = 206;
            // 
            // coltr_Descripcion
            // 
            this.coltr_Descripcion.Caption = "Descripción";
            this.coltr_Descripcion.FieldName = "tr_Descripcion";
            this.coltr_Descripcion.Name = "coltr_Descripcion";
            this.coltr_Descripcion.Visible = true;
            this.coltr_Descripcion.VisibleIndex = 0;
            this.coltr_Descripcion.Width = 760;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colEstado1
            // 
            this.colEstado1.Caption = "Estado";
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.Width = 208;
            // 
            // repositoryItemDateEditFecha
            // 
            this.repositoryItemDateEditFecha.AutoHeight = false;
            this.repositoryItemDateEditFecha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditFecha.Name = "repositoryItemDateEditFecha";
            this.repositoryItemDateEditFecha.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemComboBoxTipoCobro
            // 
            this.repositoryItemComboBoxTipoCobro.AutoHeight = false;
            this.repositoryItemComboBoxTipoCobro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxTipoCobro.Name = "repositoryItemComboBoxTipoCobro";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl_NCND);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transacciones generales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl_NCND
            // 
            this.gridControl_NCND.DataSource = this.cxccobroxcajCajaMovimientoInfoBindingSource;
            this.gridControl_NCND.Location = new System.Drawing.Point(6, 6);
            this.gridControl_NCND.MainView = this.gridView_NCND;
            this.gridControl_NCND.Name = "gridControl_NCND";
            this.gridControl_NCND.Size = new System.Drawing.Size(829, 158);
            this.gridControl_NCND.TabIndex = 19;
            this.gridControl_NCND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_NCND,
            this.gridView1});
            // 
            // cxccobroxcajCajaMovimientoInfoBindingSource
            // 
            this.cxccobroxcajCajaMovimientoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_x_caj_Caja_Movimiento_Info);
            // 
            // gridView_NCND
            // 
            this.gridView_NCND.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcbr_IdEmpresa,
            this.colcbr_IdSucursal,
            this.colcbr_IdCobro,
            this.colmcj_IdEmpresa,
            this.colmcj_IdCbteCble,
            this.colmcj_IdTipocbte,
            this.colem_nombre,
            this.colSu_Descripcion,
            this.coltc_descripcion,
            this.coltc_TipoCbte,
            this.colIdCobro_tipo1,
            this.colcr_TotalCobro,
            this.colcr_fecha,
            this.colcr_Banco1,
            this.colcr_cuenta1,
            this.colcr_NumDocumento1,
            this.colIdCaja1,
            this.colca_Descripcion1,
            this.colMovi_Caja,
            this.coltm_descripcion,
            this.coltc_TipoCbte2,
            this.colNum_CbteCble});
            this.gridView_NCND.GridControl = this.gridControl_NCND;
            this.gridView_NCND.Name = "gridView_NCND";
            this.gridView_NCND.OptionsView.ShowGroupPanel = false;
            // 
            // colcbr_IdEmpresa
            // 
            this.colcbr_IdEmpresa.Caption = "IdEmpresa";
            this.colcbr_IdEmpresa.FieldName = "cbr_IdEmpresa";
            this.colcbr_IdEmpresa.Name = "colcbr_IdEmpresa";
            this.colcbr_IdEmpresa.Visible = true;
            this.colcbr_IdEmpresa.VisibleIndex = 13;
            // 
            // colcbr_IdSucursal
            // 
            this.colcbr_IdSucursal.FieldName = "cbr_IdSucursal";
            this.colcbr_IdSucursal.Name = "colcbr_IdSucursal";
            // 
            // colcbr_IdCobro
            // 
            this.colcbr_IdCobro.Caption = "IdCobro";
            this.colcbr_IdCobro.FieldName = "cbr_IdCobro";
            this.colcbr_IdCobro.Name = "colcbr_IdCobro";
            this.colcbr_IdCobro.Visible = true;
            this.colcbr_IdCobro.VisibleIndex = 12;
            // 
            // colmcj_IdEmpresa
            // 
            this.colmcj_IdEmpresa.FieldName = "mcj_IdEmpresa";
            this.colmcj_IdEmpresa.Name = "colmcj_IdEmpresa";
            // 
            // colmcj_IdCbteCble
            // 
            this.colmcj_IdCbteCble.FieldName = "mcj_IdCbteCble";
            this.colmcj_IdCbteCble.Name = "colmcj_IdCbteCble";
            // 
            // colmcj_IdTipocbte
            // 
            this.colmcj_IdTipocbte.FieldName = "mcj_IdTipocbte";
            this.colmcj_IdTipocbte.Name = "colmcj_IdTipocbte";
            // 
            // colem_nombre
            // 
            this.colem_nombre.FieldName = "em_nombre";
            this.colem_nombre.Name = "colem_nombre";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            // 
            // coltc_descripcion
            // 
            this.coltc_descripcion.FieldName = "tc_descripcion";
            this.coltc_descripcion.Name = "coltc_descripcion";
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            // 
            // colIdCobro_tipo1
            // 
            this.colIdCobro_tipo1.Caption = "IdCobro_Tipo";
            this.colIdCobro_tipo1.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo1.Name = "colIdCobro_tipo1";
            this.colIdCobro_tipo1.Visible = true;
            this.colIdCobro_tipo1.VisibleIndex = 5;
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.Caption = "Total cobro";
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 11;
            // 
            // colcr_fecha
            // 
            this.colcr_fecha.Caption = "Fecha";
            this.colcr_fecha.FieldName = "cr_fecha";
            this.colcr_fecha.Name = "colcr_fecha";
            this.colcr_fecha.Visible = true;
            this.colcr_fecha.VisibleIndex = 10;
            // 
            // colcr_Banco1
            // 
            this.colcr_Banco1.Caption = "Banco";
            this.colcr_Banco1.FieldName = "cr_Banco";
            this.colcr_Banco1.Name = "colcr_Banco1";
            this.colcr_Banco1.Visible = true;
            this.colcr_Banco1.VisibleIndex = 3;
            // 
            // colcr_cuenta1
            // 
            this.colcr_cuenta1.Caption = "Cuenta";
            this.colcr_cuenta1.FieldName = "cr_cuenta";
            this.colcr_cuenta1.Name = "colcr_cuenta1";
            this.colcr_cuenta1.Visible = true;
            this.colcr_cuenta1.VisibleIndex = 2;
            // 
            // colcr_NumDocumento1
            // 
            this.colcr_NumDocumento1.Caption = "NumDocumento";
            this.colcr_NumDocumento1.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento1.Name = "colcr_NumDocumento1";
            this.colcr_NumDocumento1.Visible = true;
            this.colcr_NumDocumento1.VisibleIndex = 0;
            // 
            // colIdCaja1
            // 
            this.colIdCaja1.Caption = "IdCaja";
            this.colIdCaja1.FieldName = "IdCaja";
            this.colIdCaja1.Name = "colIdCaja1";
            this.colIdCaja1.Visible = true;
            this.colIdCaja1.VisibleIndex = 9;
            // 
            // colca_Descripcion1
            // 
            this.colca_Descripcion1.Caption = "Descripción caja";
            this.colca_Descripcion1.FieldName = "ca_Descripcion";
            this.colca_Descripcion1.Name = "colca_Descripcion1";
            this.colca_Descripcion1.Visible = true;
            this.colca_Descripcion1.VisibleIndex = 8;
            // 
            // colMovi_Caja
            // 
            this.colMovi_Caja.Caption = "Movi_Caja";
            this.colMovi_Caja.FieldName = "Movi_Caja";
            this.colMovi_Caja.Name = "colMovi_Caja";
            this.colMovi_Caja.Visible = true;
            this.colMovi_Caja.VisibleIndex = 7;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "tm_descripcion";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 6;
            // 
            // coltc_TipoCbte2
            // 
            this.coltc_TipoCbte2.Caption = "Tipo comprobante";
            this.coltc_TipoCbte2.FieldName = "tc_TipoCbte2";
            this.coltc_TipoCbte2.Name = "coltc_TipoCbte2";
            this.coltc_TipoCbte2.Visible = true;
            this.coltc_TipoCbte2.VisibleIndex = 4;
            // 
            // colNum_CbteCble
            // 
            this.colNum_CbteCble.Caption = "Num_CbteCble";
            this.colNum_CbteCble.FieldName = "Num_CbteCble";
            this.colNum_CbteCble.Name = "colNum_CbteCble";
            this.colNum_CbteCble.Visible = true;
            this.colNum_CbteCble.VisibleIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcbr_IdEmpresa,
            this.colcbr_IdSucursal,
            this.colcbr_IdCobro,
            this.colmcj_IdEmpresa,
            this.colmcj_IdCbteCble,
            this.colmcj_IdTipocbte,
            this.colem_nombre,
            this.colSu_Descripcion,
            this.coltc_descripcion,
            this.coltc_TipoCbte,
            this.colIdCobro_tipo,
            this.colcr_TotalCobro,
            this.colcr_fecha,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_NumDocumento,
            this.colIdCaja1,
            this.colca_Descripcion1,
            this.colMovi_Caja,
            this.coltm_descripcion,
            this.coltc_TipoCbte2,
            this.colNum_CbteCble});
            this.gridView1.GridControl = this.gridControl_NCND;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservacion);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtEfectivo);
            this.groupBox3.Controls.Add(this.txtChq_Tarj);
            this.groupBox3.Controls.Add(this.txtOtros);
            this.groupBox3.Controls.Add(this.txtDeposito);
            this.groupBox3.Controls.Add(this.txtTotalCobrado);
            this.groupBox3.Controls.Add(this.txtCHQF);
            this.groupBox3.Controls.Add(this.txtCXC);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(0, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 139);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formas de Pago";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(83, 45);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(493, 20);
            this.txtObservacion.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Observación:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(757, 9);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 13;
            // 
            // txtChq_Tarj
            // 
            this.txtChq_Tarj.Location = new System.Drawing.Point(757, 35);
            this.txtChq_Tarj.Name = "txtChq_Tarj";
            this.txtChq_Tarj.Size = new System.Drawing.Size(100, 20);
            this.txtChq_Tarj.TabIndex = 12;
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(757, 61);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(100, 20);
            this.txtOtros.TabIndex = 11;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(757, 87);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtDeposito.TabIndex = 10;
            // 
            // txtTotalCobrado
            // 
            this.txtTotalCobrado.Location = new System.Drawing.Point(757, 113);
            this.txtTotalCobrado.Name = "txtTotalCobrado";
            this.txtTotalCobrado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCobrado.TabIndex = 9;
            // 
            // txtCHQF
            // 
            this.txtCHQF.Location = new System.Drawing.Point(476, 17);
            this.txtCHQF.Name = "txtCHQF";
            this.txtCHQF.Size = new System.Drawing.Size(100, 20);
            this.txtCHQF.TabIndex = 8;
            // 
            // txtCXC
            // 
            this.txtCXC.Location = new System.Drawing.Point(83, 19);
            this.txtCXC.Name = "txtCXC";
            this.txtCXC.Size = new System.Drawing.Size(100, 20);
            this.txtCXC.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(674, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Total chq. / tarj:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(674, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Total efectivo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(674, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total otros:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(674, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total depósitos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total cobrado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cheques Pos-fechados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Por cobrar:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(882, 29);
            this.ucGe_Menu.TabIndex = 30;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = true;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            // 
            // colIdCobro_tipo2
            // 
            this.colIdCobro_tipo2.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo2.Name = "colIdCobro_tipo2";
            // 
            // colcr_propietarioCta
            // 
            this.colcr_propietarioCta.FieldName = "cr_propietarioCta";
            this.colcr_propietarioCta.Name = "colcr_propietarioCta";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colcr_TotalCobro1
            // 
            this.colcr_TotalCobro1.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro1.Name = "colcr_TotalCobro1";
            // 
            // colcr_fecha1
            // 
            this.colcr_fecha1.FieldName = "cr_fecha";
            this.colcr_fecha1.Name = "colcr_fecha1";
            // 
            // colcr_Banco2
            // 
            this.colcr_Banco2.FieldName = "cr_Banco";
            this.colcr_Banco2.Name = "colcr_Banco2";
            // 
            // colcr_cuenta2
            // 
            this.colcr_cuenta2.FieldName = "cr_cuenta";
            this.colcr_cuenta2.Name = "colcr_cuenta2";
            // 
            // colcr_NumDocumento2
            // 
            this.colcr_NumDocumento2.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento2.Name = "colcr_NumDocumento2";
            // 
            // colcr_es_anticipo
            // 
            this.colcr_es_anticipo.FieldName = "cr_es_anticipo";
            this.colcr_es_anticipo.Name = "colcr_es_anticipo";
            // 
            // colcr_estado
            // 
            this.colcr_estado.FieldName = "cr_estado";
            this.colcr_estado.Name = "colcr_estado";
            // 
            // colcr_recibo
            // 
            this.colcr_recibo.FieldName = "cr_recibo";
            this.colcr_recibo.Name = "colcr_recibo";
            // 
            // colcr_estadoCobro
            // 
            this.colcr_estadoCobro.FieldName = "cr_estadoCobro";
            this.colcr_estadoCobro.Name = "colcr_estadoCobro";
            // 
            // colcr_Codigo
            // 
            this.colcr_Codigo.FieldName = "cr_Codigo";
            this.colcr_Codigo.Name = "colcr_Codigo";
            // 
            // colIdUsuario1
            // 
            this.colIdUsuario1.FieldName = "IdUsuario";
            this.colIdUsuario1.Name = "colIdUsuario1";
            // 
            // colFecha_Transac1
            // 
            this.colFecha_Transac1.FieldName = "Fecha_Transac";
            this.colFecha_Transac1.Name = "colFecha_Transac1";
            // 
            // colIdUsuarioUltMod1
            // 
            this.colIdUsuarioUltMod1.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod1.Name = "colIdUsuarioUltMod1";
            // 
            // colFecha_UltMod1
            // 
            this.colFecha_UltMod1.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod1.Name = "colFecha_UltMod1";
            // 
            // colnom_pc1
            // 
            this.colnom_pc1.FieldName = "nom_pc";
            this.colnom_pc1.Name = "colnom_pc1";
            // 
            // colip1
            // 
            this.colip1.FieldName = "ip";
            this.colip1.Name = "colip1";
            // 
            // colIdUsuarioUltAnu1
            // 
            this.colIdUsuarioUltAnu1.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu1.Name = "colIdUsuarioUltAnu1";
            // 
            // colFecha_UltAnu1
            // 
            this.colFecha_UltAnu1.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu1.Name = "colFecha_UltAnu1";
            // 
            // colIdTipoNotaCredito
            // 
            this.colIdTipoNotaCredito.FieldName = "IdTipoNotaCredito";
            this.colIdTipoNotaCredito.Name = "colIdTipoNotaCredito";
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            // 
            // colFecha_Cobro
            // 
            this.colFecha_Cobro.FieldName = "Fecha_Cobro";
            this.colFecha_Cobro.Name = "colFecha_Cobro";
            // 
            // colIdVendedorCliente
            // 
            this.colIdVendedorCliente.FieldName = "IdVendedorCliente";
            this.colIdVendedorCliente.Name = "colIdVendedorCliente";
            // 
            // colnSucursal1
            // 
            this.colnSucursal1.FieldName = "nSucursal";
            this.colnSucursal1.Name = "colnSucursal1";
            // 
            // colnCliente
            // 
            this.colnCliente.FieldName = "nCliente";
            this.colnCliente.Name = "colnCliente";
            // 
            // colchek
            // 
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            // 
            // colCaja
            // 
            this.colCaja.FieldName = "Caja";
            this.colCaja.Name = "colCaja";
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colIdCbteCble_MoviCaja
            // 
            this.colIdCbteCble_MoviCaja.FieldName = "IdCbteCble_MoviCaja";
            this.colIdCbteCble_MoviCaja.Name = "colIdCbteCble_MoviCaja";
            // 
            // colIdTipocbte_MoviCaja
            // 
            this.colIdTipocbte_MoviCaja.FieldName = "IdTipocbte_MoviCaja";
            this.colIdTipocbte_MoviCaja.Name = "colIdTipocbte_MoviCaja";
            // 
            // colMotiAnula
            // 
            this.colMotiAnula.FieldName = "MotiAnula";
            this.colMotiAnula.Name = "colMotiAnula";
            // 
            // colIdCobro_a_aplicar
            // 
            this.colIdCobro_a_aplicar.FieldName = "IdCobro_a_aplicar";
            this.colIdCobro_a_aplicar.Name = "colIdCobro_a_aplicar";
            // 
            // colBancoCuenta
            // 
            this.colBancoCuenta.FieldName = "BancoCuenta";
            this.colBancoCuenta.Name = "colBancoCuenta";
            // 
            // colRF
            // 
            this.colRF.FieldName = "RF";
            this.colRF.Name = "colRF";
            // 
            // colRI
            // 
            this.colRI.FieldName = "RI";
            this.colRI.Name = "colRI";
            // 
            // colvalorRF
            // 
            this.colvalorRF.FieldName = "valorRF";
            this.colvalorRF.Name = "colvalorRF";
            // 
            // colvalorRI
            // 
            this.colvalorRI.FieldName = "valorRI";
            this.colvalorRI.Name = "colvalorRI";
            // 
            // colvalorComision
            // 
            this.colvalorComision.FieldName = "valorComision";
            this.colvalorComision.Name = "colvalorComision";
            // 
            // colValorCheque
            // 
            this.colValorCheque.FieldName = "ValorCheque";
            this.colValorCheque.Name = "colValorCheque";
            // 
            // colTipoPagoTarjeta
            // 
            this.colTipoPagoTarjeta.FieldName = "TipoPagoTarjeta";
            this.colTipoPagoTarjeta.Name = "colTipoPagoTarjeta";
            // 
            // colBancoTarjeta
            // 
            this.colBancoTarjeta.FieldName = "BancoTarjeta";
            this.colBancoTarjeta.Name = "colBancoTarjeta";
            // 
            // colcuentaTarjeta
            // 
            this.colcuentaTarjeta.FieldName = "cuentaTarjeta";
            this.colcuentaTarjeta.Name = "colcuentaTarjeta";
            // 
            // colchequeTarjeta
            // 
            this.colchequeTarjeta.FieldName = "chequeTarjeta";
            this.colchequeTarjeta.Name = "colchequeTarjeta";
            // 
            // coldc_TipoDocumento
            // 
            this.coldc_TipoDocumento.FieldName = "dc_TipoDocumento";
            this.coldc_TipoDocumento.Name = "coldc_TipoDocumento";
            // 
            // colIdCbte_vta_nota
            // 
            this.colIdCbte_vta_nota.FieldName = "IdCbte_vta_nota";
            this.colIdCbte_vta_nota.Name = "colIdCbte_vta_nota";
            // 
            // colIdCaja2
            // 
            this.colIdCaja2.FieldName = "IdCaja";
            this.colIdCaja2.Name = "colIdCaja2";
            // 
            // colIdFila
            // 
            this.colIdFila.FieldName = "IdFila";
            this.colIdFila.Name = "colIdFila";
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            // 
            // colsecuencial
            // 
            this.colsecuencial.FieldName = "secuencial";
            this.colsecuencial.Name = "colsecuencial";
            // 
            // coldc_ValorPago
            // 
            this.coldc_ValorPago.FieldName = "dc_ValorPago";
            this.coldc_ValorPago.Name = "coldc_ValorPago";
            // 
            // colDocumento_Cobrado
            // 
            this.colDocumento_Cobrado.FieldName = "Documento_Cobrado";
            this.colDocumento_Cobrado.Name = "colDocumento_Cobrado";
            // 
            // frmCxc_Cobros_x_Ventas_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 581);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCxc_Cobros_x_Ventas_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobros por Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcxc_CobrosXFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmcxc_CobrosXFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txe_saldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajCajaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griddetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTipoCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtarjetaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFecha.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxTipoCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NCND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxcajCajaMovimientoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NCND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChq_Tarj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCobrado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCHQF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCXC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_bodega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_NDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.TextEdit txtEfectivo;
        private DevExpress.XtraEditors.TextEdit txtChq_Tarj;
        private DevExpress.XtraEditors.TextEdit txtOtros;
        private DevExpress.XtraEditors.TextEdit txtDeposito;
        private DevExpress.XtraEditors.TextEdit txtTotalCobrado;
        private DevExpress.XtraEditors.TextEdit txtCHQF;
        private DevExpress.XtraEditors.TextEdit txtCXC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtObservacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCaja;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource cajCajaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Responsable;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colN_usuarioResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colNSucursal;
        private System.Windows.Forms.TextBox lbl_IdBodega;
        private System.Windows.Forms.Button btn_ApliReten;
        private System.Windows.Forms.BindingSource cxccobroxcajCajaMovimientoInfoBindingSource;
        private System.Windows.Forms.BindingSource tbtarjetaInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit txe_total;
        private DevExpress.XtraEditors.TextEdit txe_saldo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl griddetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTipoCobro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaDocu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega_Cbte;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Tarjeta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbTarjeta;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn coltr_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;        
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxTipoCobro;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl_NCND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_NCND;
        private DevExpress.XtraGrid.Columns.GridColumn colcbr_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcbr_IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colcbr_IdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colmcj_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colmcj_IdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colmcj_IdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colem_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco1;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja1;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colMovi_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte2;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_CbteCble;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_propietarioCta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_es_anticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_recibo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod1;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc1;
        private DevExpress.XtraGrid.Columns.GridColumn colip1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNotaCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Cobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendedorCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private DevExpress.XtraGrid.Columns.GridColumn colCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_MoviCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte_MoviCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colMotiAnula;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_a_aplicar;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colRF;
        private DevExpress.XtraGrid.Columns.GridColumn colRI;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorRF;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorRI;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorComision;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPagoTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colcuentaTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colchequeTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_TipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbte_vta_nota;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFila;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
        private DevExpress.XtraGrid.Columns.GridColumn colsecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_ValorPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento_Cobrado;
    }
}
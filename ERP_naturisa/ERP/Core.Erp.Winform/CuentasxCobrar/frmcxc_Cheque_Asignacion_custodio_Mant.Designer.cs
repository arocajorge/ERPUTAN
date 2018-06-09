namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Cheque_Asignacion_custodio_Mant
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrabar = new System.Windows.Forms.ToolStripButton();
            this.btnGrabarySalir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.cmbEstadoCobro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cxcEstadoCobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dteFec_Hasta = new DevExpress.XtraEditors.DateEdit();
            this.dteFec_Desde = new DevExpress.XtraEditors.DateEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXDepositar = new System.Windows.Forms.RadioButton();
            this.rdbDepositados = new System.Windows.Forms.RadioButton();
            this.cmbBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.baBancoCuentaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Ultimo_Cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_num_digito_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkAplicar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridChequesAsignados = new DevExpress.XtraGrid.GridControl();
            this.vwcxccobrosxchequedepositoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvChequeAsignados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco_del_cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Cheq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco_deposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.View_BancoGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_dep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmcj_IdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco_dep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmcj_IdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_IdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_IdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoCobro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Hasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Desde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Desde.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChequesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobrosxchequedepositoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChequeAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BancoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrabar,
            this.btnGrabarySalir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(77, 22);
            this.btnGrabar.Text = "Depositar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnGrabarySalir
            // 
            this.btnGrabarySalir.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.btnGrabarySalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabarySalir.Name = "btnGrabarySalir";
            this.btnGrabarySalir.Size = new System.Drawing.Size(111, 22);
            this.btnGrabarySalir.Text = "Depositar y Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado cobro:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 121);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel4.Controls.Add(this.cmbEstadoCobro);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Controls.Add(this.dteFec_Hasta);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dteFec_Desde);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 121);
            this.panel4.TabIndex = 16;
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(22, 6);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(467, 27);
            this.ucIn_Sucursal_Bodega1.TabIndex = 9;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // cmbEstadoCobro
            // 
            this.cmbEstadoCobro.Location = new System.Drawing.Point(94, 93);
            this.cmbEstadoCobro.Name = "cmbEstadoCobro";
            this.cmbEstadoCobro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoCobro.Properties.DataSource = this.cxcEstadoCobroInfoBindingSource;
            this.cmbEstadoCobro.Properties.DisplayMember = "Descripcion";
            this.cmbEstadoCobro.Properties.ValueMember = "IdEstadoCobro";
            this.cmbEstadoCobro.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstadoCobro.Size = new System.Drawing.Size(133, 20);
            this.cmbEstadoCobro.TabIndex = 8;
            // 
            // cxcEstadoCobroInfoBindingSource
            // 
            this.cxcEstadoCobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_EstadoCobro_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstadoCobro,
            this.colDescripcion,
            this.colposicion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.Caption = "Estado Cobro";
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            this.colIdEstadoCobro.Visible = true;
            this.colIdEstadoCobro.VisibleIndex = 0;
            this.colIdEstadoCobro.Width = 256;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 918;
            // 
            // colposicion
            // 
            this.colposicion.FieldName = "posicion";
            this.colposicion.Name = "colposicion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(277, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 26);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dteFec_Hasta
            // 
            this.dteFec_Hasta.EditValue = null;
            this.dteFec_Hasta.Location = new System.Drawing.Point(333, 43);
            this.dteFec_Hasta.Name = "dteFec_Hasta";
            this.dteFec_Hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFec_Hasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFec_Hasta.Size = new System.Drawing.Size(133, 20);
            this.dteFec_Hasta.TabIndex = 6;
            // 
            // dteFec_Desde
            // 
            this.dteFec_Desde.EditValue = null;
            this.dteFec_Desde.Location = new System.Drawing.Point(94, 43);
            this.dteFec_Desde.Name = "dteFec_Desde";
            this.dteFec_Desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFec_Desde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFec_Desde.Size = new System.Drawing.Size(133, 20);
            this.dteFec_Desde.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.cmbBanco);
            this.panel3.Controls.Add(this.checkAplicar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(539, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 121);
            this.panel3.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXDepositar);
            this.groupBox1.Controls.Add(this.rdbDepositados);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 86);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Cheques";
            // 
            // rdbXDepositar
            // 
            this.rdbXDepositar.AutoSize = true;
            this.rdbXDepositar.Checked = true;
            this.rdbXDepositar.Location = new System.Drawing.Point(229, 12);
            this.rdbXDepositar.Name = "rdbXDepositar";
            this.rdbXDepositar.Size = new System.Drawing.Size(89, 17);
            this.rdbXDepositar.TabIndex = 14;
            this.rdbXDepositar.TabStop = true;
            this.rdbXDepositar.Text = "Por Depositar";
            this.rdbXDepositar.UseVisualStyleBackColor = true;
            this.rdbXDepositar.CheckedChanged += new System.EventHandler(this.rdbXDepositar_CheckedChanged);
            // 
            // rdbDepositados
            // 
            this.rdbDepositados.AutoSize = true;
            this.rdbDepositados.Location = new System.Drawing.Point(229, 44);
            this.rdbDepositados.Name = "rdbDepositados";
            this.rdbDepositados.Size = new System.Drawing.Size(84, 17);
            this.rdbDepositados.TabIndex = 13;
            this.rdbDepositados.Text = "Depositados";
            this.rdbDepositados.UseVisualStyleBackColor = true;
            this.rdbDepositados.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(234, 95);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.DataSource = this.baBancoCuentaInfoBindingSource;
            this.cmbBanco.Properties.DisplayMember = "ba_descripcion";
            this.cmbBanco.Properties.ValueMember = "IdBanco";
            this.cmbBanco.Properties.View = this.View;
            this.cmbBanco.Size = new System.Drawing.Size(144, 20);
            this.cmbBanco.TabIndex = 11;
            this.cmbBanco.EditValueChanged += new System.EventHandler(this.cmbBanco_EditValueChanged);
            this.cmbBanco.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmbBanco_EditValueChanging);
            // 
            // baBancoCuentaInfoBindingSource
            // 
            this.baBancoCuentaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Banco_Cuenta_Info);
            // 
            // View
            // 
            this.View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colba_descripcion,
            this.colba_Num_Cuenta,
            this.colIdCtaCble,
            this.colba_Tipo,
            this.colba_Moneda,
            this.colba_Ultimo_Cheque,
            this.colIdEmpresa,
            this.colba_num_digito_cheq,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colnom_pc,
            this.colip,
            this.colestado});
            this.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View.Name = "View";
            this.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "ID";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 38;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Descripción";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 2;
            this.colba_descripcion.Width = 887;
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.Caption = "# Cta Cble";
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            this.colba_Num_Cuenta.Visible = true;
            this.colba_Num_Cuenta.VisibleIndex = 3;
            this.colba_Num_Cuenta.Width = 145;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "ID Cta. Ctble.";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 1;
            // 
            // colba_Tipo
            // 
            this.colba_Tipo.FieldName = "ba_Tipo";
            this.colba_Tipo.Name = "colba_Tipo";
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
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colba_num_digito_cheq
            // 
            this.colba_num_digito_cheq.FieldName = "ba_num_digito_cheq";
            this.colba_num_digito_cheq.Name = "colba_num_digito_cheq";
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
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Width = 104;
            // 
            // checkAplicar
            // 
            this.checkAplicar.AutoSize = true;
            this.checkAplicar.Location = new System.Drawing.Point(80, 97);
            this.checkAplicar.Name = "checkAplicar";
            this.checkAplicar.Size = new System.Drawing.Size(101, 17);
            this.checkAplicar.TabIndex = 10;
            this.checkAplicar.Text = "Aplicar custodio";
            this.checkAplicar.UseVisualStyleBackColor = true;
            this.checkAplicar.CheckedChanged += new System.EventHandler(this.checkAplicar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Banco:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridChequesAsignados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 200);
            this.panel2.TabIndex = 7;
            // 
            // gridChequesAsignados
            // 
            this.gridChequesAsignados.DataSource = this.vwcxccobrosxchequedepositoInfoBindingSource;
            this.gridChequesAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChequesAsignados.Location = new System.Drawing.Point(0, 0);
            this.gridChequesAsignados.MainView = this.grvChequeAsignados;
            this.gridChequesAsignados.Name = "gridChequesAsignados";
            this.gridChequesAsignados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            this.gridChequesAsignados.Size = new System.Drawing.Size(929, 200);
            this.gridChequesAsignados.TabIndex = 1;
            this.gridChequesAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChequeAsignados});
            // 
            // vwcxccobrosxchequedepositoInfoBindingSource
            // 
            this.vwcxccobrosxchequedepositoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.vwcxc_cobros_x_cheque_deposito_Info);
            // 
            // grvChequeAsignados
            // 
            this.grvChequeAsignados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSucursal,
            this.colCliente,
            this.colIdEstadoCobro1,
            this.colTipoCobro,
            this.colFecha,
            this.colFechaCobro,
            this.colBanco_del_cheq,
            this.colCuenta,
            this.colNum_Cheq,
            this.colTotalCobro,
            this.colBanco_deposito,
            this.colFecha_dep,
            this.colCheck,
            this.colReferencia,
            this.colmcj_IdTipocbte,
            this.colIdBanco_dep,
            this.colmcj_IdCbteCble,
            this.colIdSucursal,
            this.colIdEmpresa1,
            this.colIdCaja,
            this.colIdCliente,
            this.colIdCobro,
            this.colIdCobro_tipo,
            this.colCodCaja,
            this.colba_IdTipocbte,
            this.colba_IdCbteCble});
            this.grvChequeAsignados.GridControl = this.gridChequesAsignados;
            this.grvChequeAsignados.Name = "grvChequeAsignados";
            this.grvChequeAsignados.OptionsView.ShowGroupPanel = false;
            this.grvChequeAsignados.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvChequeAsignados_RowClick);
            this.grvChequeAsignados.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvChequeAsignados_CellValueChanged);
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.ReadOnly = true;
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 0;
            this.colSucursal.Width = 71;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.ReadOnly = true;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            this.colCliente.Width = 210;
            // 
            // colIdEstadoCobro1
            // 
            this.colIdEstadoCobro1.Caption = "Estado Cobro";
            this.colIdEstadoCobro1.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro1.Name = "colIdEstadoCobro1";
            this.colIdEstadoCobro1.OptionsColumn.ReadOnly = true;
            this.colIdEstadoCobro1.Visible = true;
            this.colIdEstadoCobro1.VisibleIndex = 2;
            this.colIdEstadoCobro1.Width = 88;
            // 
            // colTipoCobro
            // 
            this.colTipoCobro.Caption = "Tipo Cobro";
            this.colTipoCobro.FieldName = "TipoCobro";
            this.colTipoCobro.Name = "colTipoCobro";
            this.colTipoCobro.OptionsColumn.ReadOnly = true;
            this.colTipoCobro.Visible = true;
            this.colTipoCobro.VisibleIndex = 3;
            this.colTipoCobro.Width = 62;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 56;
            // 
            // colFechaCobro
            // 
            this.colFechaCobro.Caption = "Fecha Cobro";
            this.colFechaCobro.FieldName = "FechaCobro";
            this.colFechaCobro.Name = "colFechaCobro";
            this.colFechaCobro.OptionsColumn.ReadOnly = true;
            this.colFechaCobro.Visible = true;
            this.colFechaCobro.VisibleIndex = 5;
            this.colFechaCobro.Width = 82;
            // 
            // colBanco_del_cheq
            // 
            this.colBanco_del_cheq.Caption = "Banco";
            this.colBanco_del_cheq.FieldName = "Banco_del_cheq";
            this.colBanco_del_cheq.Name = "colBanco_del_cheq";
            this.colBanco_del_cheq.OptionsColumn.ReadOnly = true;
            this.colBanco_del_cheq.Visible = true;
            this.colBanco_del_cheq.VisibleIndex = 6;
            this.colBanco_del_cheq.Width = 83;
            // 
            // colCuenta
            // 
            this.colCuenta.Caption = "Cta";
            this.colCuenta.FieldName = "Cuenta";
            this.colCuenta.Name = "colCuenta";
            this.colCuenta.OptionsColumn.ReadOnly = true;
            this.colCuenta.Visible = true;
            this.colCuenta.VisibleIndex = 7;
            this.colCuenta.Width = 70;
            // 
            // colNum_Cheq
            // 
            this.colNum_Cheq.Caption = "# Cheque";
            this.colNum_Cheq.FieldName = "Num_Cheq";
            this.colNum_Cheq.Name = "colNum_Cheq";
            this.colNum_Cheq.OptionsColumn.ReadOnly = true;
            this.colNum_Cheq.Visible = true;
            this.colNum_Cheq.VisibleIndex = 8;
            this.colNum_Cheq.Width = 63;
            // 
            // colTotalCobro
            // 
            this.colTotalCobro.Caption = "Valor";
            this.colTotalCobro.FieldName = "TotalCobro";
            this.colTotalCobro.Name = "colTotalCobro";
            this.colTotalCobro.OptionsColumn.ReadOnly = true;
            this.colTotalCobro.Visible = true;
            this.colTotalCobro.VisibleIndex = 9;
            this.colTotalCobro.Width = 86;
            // 
            // colBanco_deposito
            // 
            this.colBanco_deposito.Caption = "Banco Depósito";
            this.colBanco_deposito.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colBanco_deposito.FieldName = "IdBanco_dep";
            this.colBanco_deposito.Name = "colBanco_deposito";
            this.colBanco_deposito.Visible = true;
            this.colBanco_deposito.VisibleIndex = 10;
            this.colBanco_deposito.Width = 61;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.baBancoCuentaInfoBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "ba_descripcion";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IdBanco";
            this.repositoryItemSearchLookUpEdit1.View = this.View_BancoGrid;
            // 
            // View_BancoGrid
            // 
            this.View_BancoGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco1,
            this.colba_descripcion1,
            this.colba_Num_Cuenta1,
            this.colIdCtaCble1});
            this.View_BancoGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View_BancoGrid.Name = "View_BancoGrid";
            this.View_BancoGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View_BancoGrid.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco1
            // 
            this.colIdBanco1.Caption = "ID";
            this.colIdBanco1.FieldName = "IdBanco";
            this.colIdBanco1.Name = "colIdBanco1";
            this.colIdBanco1.Visible = true;
            this.colIdBanco1.VisibleIndex = 0;
            this.colIdBanco1.Width = 34;
            // 
            // colba_descripcion1
            // 
            this.colba_descripcion1.Caption = "Descripción";
            this.colba_descripcion1.FieldName = "ba_descripcion";
            this.colba_descripcion1.Name = "colba_descripcion1";
            this.colba_descripcion1.Visible = true;
            this.colba_descripcion1.VisibleIndex = 2;
            this.colba_descripcion1.Width = 944;
            // 
            // colba_Num_Cuenta1
            // 
            this.colba_Num_Cuenta1.Caption = "# Cta.";
            this.colba_Num_Cuenta1.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta1.Name = "colba_Num_Cuenta1";
            this.colba_Num_Cuenta1.Visible = true;
            this.colba_Num_Cuenta1.VisibleIndex = 3;
            this.colba_Num_Cuenta1.Width = 106;
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.Caption = "Id Cta Cble";
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            this.colIdCtaCble1.Visible = true;
            this.colIdCtaCble1.VisibleIndex = 1;
            this.colIdCtaCble1.Width = 90;
            // 
            // colFecha_dep
            // 
            this.colFecha_dep.Caption = "Fecha Depósito";
            this.colFecha_dep.FieldName = "Fecha_dep";
            this.colFecha_dep.Name = "colFecha_dep";
            this.colFecha_dep.Visible = true;
            this.colFecha_dep.VisibleIndex = 11;
            this.colFecha_dep.Width = 70;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 12;
            this.colCheck.Width = 28;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Referencia";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.OptionsColumn.ReadOnly = true;
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 13;
            this.colReferencia.Width = 144;
            // 
            // colmcj_IdTipocbte
            // 
            this.colmcj_IdTipocbte.FieldName = "mcj_IdTipocbte";
            this.colmcj_IdTipocbte.Name = "colmcj_IdTipocbte";
            // 
            // colIdBanco_dep
            // 
            this.colIdBanco_dep.FieldName = "IdBanco_dep";
            this.colIdBanco_dep.Name = "colIdBanco_dep";
            this.colIdBanco_dep.Width = 82;
            // 
            // colmcj_IdCbteCble
            // 
            this.colmcj_IdCbteCble.FieldName = "mcj_IdCbteCble";
            this.colmcj_IdCbteCble.Name = "colmcj_IdCbteCble";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdCaja
            // 
            this.colIdCaja.FieldName = "IdCaja";
            this.colIdCaja.Name = "colIdCaja";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            // 
            // colCodCaja
            // 
            this.colCodCaja.FieldName = "CodCaja";
            this.colCodCaja.Name = "colCodCaja";
            // 
            // colba_IdTipocbte
            // 
            this.colba_IdTipocbte.FieldName = "ba_IdTipocbte";
            this.colba_IdTipocbte.Name = "colba_IdTipocbte";
            // 
            // colba_IdCbteCble
            // 
            this.colba_IdCbteCble.FieldName = "ba_IdCbteCble";
            this.colba_IdCbteCble.Name = "colba_IdCbteCble";
            // 
            // frmCxc_Cheque_Asignacion_custodio_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCxc_Cheque_Asignacion_custodio_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Asignación Cheque Custodio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmcxc_Cheque_Asignacion_custodio_Mant_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoCobro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Hasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Desde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFec_Desde.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baBancoCuentaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChequesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobrosxchequedepositoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChequeAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BancoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGrabar;
        private System.Windows.Forms.ToolStripButton btnGrabarySalir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView View;
        private System.Windows.Forms.CheckBox checkAplicar;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoCobro;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dteFec_Desde;
        private DevExpress.XtraEditors.DateEdit dteFec_Hasta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource cxcEstadoCobroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion;
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
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.GridControl gridChequesAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChequeAsignados;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco_del_cheq;
        private DevExpress.XtraGrid.Columns.GridColumn colCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Cheq;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco_deposito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco_dep;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_dep;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colmcj_IdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colmcj_IdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colba_IdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colba_IdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private System.Windows.Forms.BindingSource vwcxccobrosxchequedepositoInfoBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbXDepositar;
        private System.Windows.Forms.RadioButton rdbDepositados;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView View_BancoGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta1;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
    }
}
namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxcMantenimiento_Cheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCxcMantenimiento_Cheques));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnCobrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProtestar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ultraComboEditorTipoTransaccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ultraComboEditorEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbFechaCob = new System.Windows.Forms.RadioButton();
            this.rbFechaIng = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFchIni = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewMant_Cheq = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaEdicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumDocu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_numTarj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVendedorCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorTipoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMant_Cheq)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCobrar,
            this.toolStripSeparator1,
            this.btnProtestar,
            this.toolStripLabel1,
            this.toolStripSeparator7,
            this.mnu_salir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(965, 25);
            this.toolStripMain.TabIndex = 26;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnCobrar
            // 
            this.btnCobrar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.btnCobrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(107, 22);
            this.btnCobrar.Text = "Cobrar Cheque";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnProtestar
            // 
            this.btnProtestar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.btnProtestar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProtestar.Name = "btnProtestar";
            this.btnProtestar.Size = new System.Drawing.Size(118, 22);
            this.btnProtestar.Text = "Protestar Cheque";
            this.btnProtestar.Click += new System.EventHandler(this.btnProtestar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel1.Text = "                                              ";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ultraComboEditorTipoTransaccion);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.ultraComboEditorEstado);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 100);
            this.panel1.TabIndex = 28;
            // 
            // ultraComboEditorTipoTransaccion
            // 
            this.ultraComboEditorTipoTransaccion.Location = new System.Drawing.Point(578, 57);
            this.ultraComboEditorTipoTransaccion.Name = "ultraComboEditorTipoTransaccion";
            this.ultraComboEditorTipoTransaccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraComboEditorTipoTransaccion.Properties.DisplayMember = "tc_descripcion";
            this.ultraComboEditorTipoTransaccion.Properties.ValueMember = "IdCobro_tipo";
            this.ultraComboEditorTipoTransaccion.Properties.View = this.gridView2;
            this.ultraComboEditorTipoTransaccion.Size = new System.Drawing.Size(208, 20);
            this.ultraComboEditorTipoTransaccion.TabIndex = 133;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltc_descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coltc_descripcion
            // 
            this.coltc_descripcion.Caption = "Descripcion";
            this.coltc_descripcion.FieldName = "tc_descripcion";
            this.coltc_descripcion.Name = "coltc_descripcion";
            this.coltc_descripcion.Visible = true;
            this.coltc_descripcion.VisibleIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(818, 27);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 46);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ultraComboEditorEstado
            // 
            this.ultraComboEditorEstado.Location = new System.Drawing.Point(578, 24);
            this.ultraComboEditorEstado.Name = "ultraComboEditorEstado";
            this.ultraComboEditorEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraComboEditorEstado.Properties.DisplayMember = "Descripcion";
            this.ultraComboEditorEstado.Properties.ValueMember = "IdEstadoCobro";
            this.ultraComboEditorEstado.Properties.View = this.gridView9;
            this.ultraComboEditorEstado.Size = new System.Drawing.Size(208, 20);
            this.ultraComboEditorEstado.TabIndex = 132;
            this.ultraComboEditorEstado.EditValueChanged += new System.EventHandler(this.ultraComboEditorEstado_EditValueChanged);
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbFechaCob);
            this.groupBox1.Controls.Add(this.rbFechaIng);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaIni);
            this.groupBox1.Controls.Add(this.lblFchIni);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, -63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // rbFechaCob
            // 
            this.rbFechaCob.AutoSize = true;
            this.rbFechaCob.Checked = true;
            this.rbFechaCob.Location = new System.Drawing.Point(12, 57);
            this.rbFechaCob.Name = "rbFechaCob";
            this.rbFechaCob.Size = new System.Drawing.Size(105, 17);
            this.rbFechaCob.TabIndex = 28;
            this.rbFechaCob.TabStop = true;
            this.rbFechaCob.Text = "Por Fecha Cobro";
            this.rbFechaCob.UseVisualStyleBackColor = true;
            // 
            // rbFechaIng
            // 
            this.rbFechaIng.AutoSize = true;
            this.rbFechaIng.Location = new System.Drawing.Point(12, 35);
            this.rbFechaIng.Name = "rbFechaIng";
            this.rbFechaIng.Size = new System.Drawing.Size(112, 17);
            this.rbFechaIng.TabIndex = 28;
            this.rbFechaIng.Text = "Por Fecha Ingreso";
            this.rbFechaIng.UseVisualStyleBackColor = true;
            this.rbFechaIng.CheckedChanged += new System.EventHandler(this.rbFechaIng_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hasta:";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(194, 53);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaIni.TabIndex = 24;
            // 
            // lblFchIni
            // 
            this.lblFchIni.AutoSize = true;
            this.lblFchIni.Location = new System.Drawing.Point(154, 57);
            this.lblFchIni.Name = "lblFchIni";
            this.lblFchIni.Size = new System.Drawing.Size(38, 13);
            this.lblFchIni.TabIndex = 26;
            this.lblFchIni.Text = "Desde";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(350, 53);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaFin.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Estado Documento";
            // 
            // gridConsulta
            // 
            this.gridConsulta.DataSource = this.cxccobroInfoBindingSource;
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 125);
            this.gridConsulta.MainView = this.gridViewMant_Cheq;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(965, 333);
            this.gridConsulta.TabIndex = 29;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMant_Cheq});
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // gridViewMant_Cheq
            // 
            this.gridViewMant_Cheq.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdCobro,
            this.colIdCobro_tipo,
            this.colIdCliente,
            this.colcr_TotalCobro,
            this.colcr_fecha,
            this.colcr_fechaCobro,
            this.colcr_fechaEdicion,
            this.colcr_observacion,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.NumDocu,
            this.colcr_Tarjeta,
            this.colcr_numTarj,
            this.colcr_estado,
            this.colcr_recibo,
            this.colcr_estadoCobro,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colnom_pc,
            this.colip,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnSucursal,
            this.colnCliente,
            this.colchek,
            this.Fecha_Cobro,
            this.IdEstadoCobro,
            this.IdVendedorCliente});
            this.gridViewMant_Cheq.CustomizationFormBounds = new System.Drawing.Rectangle(805, 448, 210, 179);
            this.gridViewMant_Cheq.GridControl = this.gridConsulta;
            this.gridViewMant_Cheq.Name = "gridViewMant_Cheq";
            this.gridViewMant_Cheq.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMant_Cheq.OptionsView.ShowGroupPanel = false;
            this.gridViewMant_Cheq.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewMant_Cheq_RowClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 56;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 187;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 12;
            this.colIdCobro.Width = 57;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.OptionsColumn.AllowEdit = false;
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 3;
            this.colIdCobro_tipo.Width = 76;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Width = 149;
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.Caption = "Valor Cheque";
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.OptionsColumn.AllowEdit = false;
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 11;
            this.colcr_TotalCobro.Width = 71;
            // 
            // colcr_fecha
            // 
            this.colcr_fecha.FieldName = "cr_fecha";
            this.colcr_fecha.Name = "colcr_fecha";
            this.colcr_fecha.OptionsColumn.AllowEdit = false;
            this.colcr_fecha.Visible = true;
            this.colcr_fecha.VisibleIndex = 4;
            this.colcr_fecha.Width = 65;
            // 
            // colcr_fechaCobro
            // 
            this.colcr_fechaCobro.Caption = "Fecha Cobro";
            this.colcr_fechaCobro.FieldName = "cr_fechaCobro";
            this.colcr_fechaCobro.Name = "colcr_fechaCobro";
            this.colcr_fechaCobro.OptionsColumn.AllowEdit = false;
            this.colcr_fechaCobro.Visible = true;
            this.colcr_fechaCobro.VisibleIndex = 5;
            this.colcr_fechaCobro.Width = 69;
            // 
            // colcr_fechaEdicion
            // 
            this.colcr_fechaEdicion.FieldName = "cr_fechaEdicion";
            this.colcr_fechaEdicion.Name = "colcr_fechaEdicion";
            this.colcr_fechaEdicion.Width = 116;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            this.colcr_observacion.OptionsColumn.AllowEdit = false;
            this.colcr_observacion.Width = 90;
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.Caption = "Banco";
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            this.colcr_Banco.OptionsColumn.AllowEdit = false;
            this.colcr_Banco.Visible = true;
            this.colcr_Banco.VisibleIndex = 6;
            this.colcr_Banco.Width = 54;
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.Caption = "#Cuenta";
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            this.colcr_cuenta.OptionsColumn.AllowEdit = false;
            this.colcr_cuenta.Visible = true;
            this.colcr_cuenta.VisibleIndex = 7;
            this.colcr_cuenta.Width = 61;
            // 
            // NumDocu
            // 
            this.NumDocu.Caption = "#Cheque/Tarj";
            this.NumDocu.FieldName = "cr_NumDocumento";
            this.NumDocu.Name = "NumDocu";
            this.NumDocu.Visible = true;
            this.NumDocu.VisibleIndex = 8;
            this.NumDocu.Width = 77;
            // 
            // colcr_Tarjeta
            // 
            this.colcr_Tarjeta.FieldName = "cr_Tarjeta";
            this.colcr_Tarjeta.Name = "colcr_Tarjeta";
            this.colcr_Tarjeta.Width = 210;
            // 
            // colcr_numTarj
            // 
            this.colcr_numTarj.FieldName = "cr_numTarj";
            this.colcr_numTarj.Name = "colcr_numTarj";
            this.colcr_numTarj.Width = 143;
            // 
            // colcr_estado
            // 
            this.colcr_estado.Caption = "Estado";
            this.colcr_estado.FieldName = "cr_estado";
            this.colcr_estado.Name = "colcr_estado";
            this.colcr_estado.Visible = true;
            this.colcr_estado.VisibleIndex = 10;
            this.colcr_estado.Width = 40;
            // 
            // colcr_recibo
            // 
            this.colcr_recibo.FieldName = "cr_recibo";
            this.colcr_recibo.Name = "colcr_recibo";
            this.colcr_recibo.OptionsColumn.AllowEdit = false;
            // 
            // colcr_estadoCobro
            // 
            this.colcr_estadoCobro.Caption = "Estado Cobro";
            this.colcr_estadoCobro.FieldName = "cr_estadoCobro";
            this.colcr_estadoCobro.Name = "colcr_estadoCobro";
            this.colcr_estadoCobro.OptionsColumn.AllowEdit = false;
            this.colcr_estadoCobro.Width = 73;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 87;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.AllowEdit = false;
            this.colFecha_Transac.Width = 76;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.Width = 157;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.Width = 115;
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            this.colnom_pc.Width = 94;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            this.colip.Width = 20;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Width = 93;
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            this.colFecha_UltAnu.Width = 79;
            // 
            // colnSucursal
            // 
            this.colnSucursal.Caption = "Sucursal";
            this.colnSucursal.FieldName = "nSucursal";
            this.colnSucursal.Name = "colnSucursal";
            this.colnSucursal.OptionsColumn.AllowEdit = false;
            this.colnSucursal.Visible = true;
            this.colnSucursal.VisibleIndex = 1;
            this.colnSucursal.Width = 67;
            // 
            // colnCliente
            // 
            this.colnCliente.Caption = "Cliente";
            this.colnCliente.FieldName = "nCliente";
            this.colnCliente.Name = "colnCliente";
            this.colnCliente.OptionsColumn.AllowEdit = false;
            this.colnCliente.Visible = true;
            this.colnCliente.VisibleIndex = 2;
            this.colnCliente.Width = 205;
            // 
            // colchek
            // 
            this.colchek.Caption = " ";
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            this.colchek.Visible = true;
            this.colchek.VisibleIndex = 0;
            this.colchek.Width = 33;
            // 
            // Fecha_Cobro
            // 
            this.Fecha_Cobro.Caption = "Fecha_Cobro";
            this.Fecha_Cobro.FieldName = "Fecha_Cobro";
            this.Fecha_Cobro.Name = "Fecha_Cobro";
            this.Fecha_Cobro.OptionsColumn.AllowEdit = false;
            // 
            // IdEstadoCobro
            // 
            this.IdEstadoCobro.Caption = "Estado Cobro";
            this.IdEstadoCobro.FieldName = "IdEstadoCobro";
            this.IdEstadoCobro.Name = "IdEstadoCobro";
            this.IdEstadoCobro.OptionsColumn.AllowEdit = false;
            this.IdEstadoCobro.Visible = true;
            this.IdEstadoCobro.VisibleIndex = 9;
            this.IdEstadoCobro.Width = 74;
            // 
            // IdVendedorCliente
            // 
            this.IdVendedorCliente.Caption = "IdVendedorCliente";
            this.IdVendedorCliente.FieldName = "IdVendedorCliente";
            this.IdVendedorCliente.Name = "IdVendedorCliente";
            // 
            // frmCxcMantenimiento_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 458);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "frmCxcMantenimiento_Cheques";
            this.Text = "Mantenimiento de Cheques (Vista/a Fecha)";
            this.Load += new System.EventHandler(this.frmCo_cxcMantenimiento_Cheques_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorTipoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboEditorEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMant_Cheq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnCobrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProtestar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFchIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbFechaCob;
        private System.Windows.Forms.RadioButton rbFechaIng;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMant_Cheq;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaEdicion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Tarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_numTarj;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_recibo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colchek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Cobro;
        private DevExpress.XtraGrid.Columns.GridColumn IdEstadoCobro;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.Columns.GridColumn NumDocu;
        private DevExpress.XtraGrid.Columns.GridColumn IdVendedorCliente;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraComboEditorEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraComboEditorTipoTransaccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion;
    }
}
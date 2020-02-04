namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Cobros_Doc_Cta
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
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucfA_Cliente_Facturacion1 = new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstadoCobro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cxcEstadoCobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fechas = new System.Windows.Forms.GroupBox();
            this.rdFechaCobro = new System.Windows.Forms.RadioButton();
            this.rdFechaCrea = new System.Windows.Forms.RadioButton();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cxccobrotipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlCobros = new DevExpress.XtraGrid.GridControl();
            this.vwcxccobroxdocumentosxcobrarInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCobros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDoc_Aplicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento_Aplicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoCobro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.Fechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobroxdocumentosxcobrarInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnConsultar,
            this.btnSalir,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 22);
            this.btnNuevo.Text = "Nuevo Cobro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(185, 22);
            this.toolStripLabel1.Text = "                                     CJ V26.02.14 ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 432);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucfA_Cliente_Facturacion1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbEstadoCobro);
            this.groupBox1.Controls.Add(this.Fechas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSucursal);
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 196);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // ucfA_Cliente_Facturacion1
            // 
            this.ucfA_Cliente_Facturacion1.Location = new System.Drawing.Point(6, 48);
            this.ucfA_Cliente_Facturacion1.Name = "ucfA_Cliente_Facturacion1";
            this.ucfA_Cliente_Facturacion1.Size = new System.Drawing.Size(354, 28);
            this.ucfA_Cliente_Facturacion1.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstadoCobro
            // 
            this.cmbEstadoCobro.Location = new System.Drawing.Point(550, 24);
            this.cmbEstadoCobro.Name = "cmbEstadoCobro";
            this.cmbEstadoCobro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstadoCobro.Properties.DataSource = this.cxcEstadoCobroInfoBindingSource;
            this.cmbEstadoCobro.Properties.DisplayMember = "Descripcion";
            this.cmbEstadoCobro.Properties.NullText = "";
            this.cmbEstadoCobro.Properties.PopupSizeable = false;
            this.cmbEstadoCobro.Properties.ValueMember = "IdEstadoCobro";
            this.cmbEstadoCobro.Properties.View = this.gridView2;
            this.cmbEstadoCobro.Size = new System.Drawing.Size(221, 20);
            this.cmbEstadoCobro.TabIndex = 28;
            this.cmbEstadoCobro.EditValueChanged += new System.EventHandler(this.cmbEstadoCobro_EditValueChanged);
            // 
            // cxcEstadoCobroInfoBindingSource
            // 
            this.cxcEstadoCobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_EstadoCobro_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstadoCobro,
            this.colDescripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            this.colIdEstadoCobro.Visible = true;
            this.colIdEstadoCobro.VisibleIndex = 0;
            this.colIdEstadoCobro.Width = 247;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 933;
            // 
            // Fechas
            // 
            this.Fechas.Controls.Add(this.rdFechaCobro);
            this.Fechas.Controls.Add(this.rdFechaCrea);
            this.Fechas.Controls.Add(this.dtDesde);
            this.Fechas.Controls.Add(this.dtHasta);
            this.Fechas.Controls.Add(this.label3);
            this.Fechas.Controls.Add(this.label4);
            this.Fechas.Location = new System.Drawing.Point(6, 87);
            this.Fechas.Name = "Fechas";
            this.Fechas.Size = new System.Drawing.Size(940, 76);
            this.Fechas.TabIndex = 25;
            this.Fechas.TabStop = false;
            this.Fechas.Text = "Fechas";
            // 
            // rdFechaCobro
            // 
            this.rdFechaCobro.AutoSize = true;
            this.rdFechaCobro.Location = new System.Drawing.Point(24, 47);
            this.rdFechaCobro.Name = "rdFechaCobro";
            this.rdFechaCobro.Size = new System.Drawing.Size(120, 17);
            this.rdFechaCobro.TabIndex = 14;
            this.rdFechaCobro.Text = "Por Fecha de Cobro";
            this.rdFechaCobro.UseVisualStyleBackColor = true;
            // 
            // rdFechaCrea
            // 
            this.rdFechaCrea.AutoSize = true;
            this.rdFechaCrea.Checked = true;
            this.rdFechaCrea.Location = new System.Drawing.Point(24, 22);
            this.rdFechaCrea.Name = "rdFechaCrea";
            this.rdFechaCrea.Size = new System.Drawing.Size(134, 17);
            this.rdFechaCrea.TabIndex = 13;
            this.rdFechaCrea.TabStop = true;
            this.rdFechaCrea.Text = "Por Fecha de Creación";
            this.rdFechaCrea.UseVisualStyleBackColor = true;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(261, 32);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtDesde.Size = new System.Drawing.Size(143, 20);
            this.dtDesde.TabIndex = 12;
            this.dtDesde.EditValueChanged += new System.EventHandler(this.dtDesde_EditValueChanged);
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(493, 32);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtHasta.Properties.Appearance.Options.UseBackColor = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtHasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtHasta.Size = new System.Drawing.Size(143, 20);
            this.dtHasta.TabIndex = 11;
            this.dtHasta.EditValueChanged += new System.EventHandler(this.dtHasta_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado de Cobro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipo de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(85, 24);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.DataSource = this.tbSucursalInfoBindingSource;
            this.cmbSucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmbSucursal.Properties.NullText = "";
            this.cmbSucursal.Properties.PopupSizeable = false;
            this.cmbSucursal.Properties.ValueMember = "IdSucursal";
            this.cmbSucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmbSucursal.Size = new System.Drawing.Size(306, 20);
            this.cmbSucursal.TabIndex = 26;
            this.cmbSucursal.EditValueChanged += new System.EventHandler(this.cmbSucursal_EditValueChanged);
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSu_Descripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripción";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 934;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Location = new System.Drawing.Point(550, 56);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoDoc.Properties.DataSource = this.cxccobrotipoInfoBindingSource;
            this.cmbTipoDoc.Properties.DisplayMember = "tc_descripcion";
            this.cmbTipoDoc.Properties.NullText = "";
            this.cmbTipoDoc.Properties.PopupSizeable = false;
            this.cmbTipoDoc.Properties.ValueMember = "IdCobro_tipo";
            this.cmbTipoDoc.Properties.View = this.gridView1;
            this.cmbTipoDoc.Size = new System.Drawing.Size(221, 20);
            this.cmbTipoDoc.TabIndex = 31;
            this.cmbTipoDoc.EditValueChanged += new System.EventHandler(this.cmbTipoDoc_EditValueChanged);
            // 
            // cxccobrotipoInfoBindingSource
            // 
            this.cxccobrotipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_tipo_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltc_descripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coltc_descripcion
            // 
            this.coltc_descripcion.Caption = "Descripción";
            this.coltc_descripcion.FieldName = "tc_descripcion";
            this.coltc_descripcion.Name = "coltc_descripcion";
            this.coltc_descripcion.Visible = true;
            this.coltc_descripcion.VisibleIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridControlCobros);
            this.panel2.Location = new System.Drawing.Point(6, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 224);
            this.panel2.TabIndex = 16;
            // 
            // gridControlCobros
            // 
            this.gridControlCobros.DataSource = this.vwcxccobroxdocumentosxcobrarInfoBindingSource;
            this.gridControlCobros.Location = new System.Drawing.Point(4, 3);
            this.gridControlCobros.MainView = this.gridViewCobros;
            this.gridControlCobros.Name = "gridControlCobros";
            this.gridControlCobros.Size = new System.Drawing.Size(949, 218);
            this.gridControlCobros.TabIndex = 0;
            this.gridControlCobros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCobros});
            this.gridControlCobros.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControlCobros_FocusedViewChanged);
            // 
            // vwcxccobroxdocumentosxcobrarInfoBindingSource
            // 
            this.vwcxccobroxdocumentosxcobrarInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.vwcxc_cobro_x_documentos_x_cobrar_Info);
            // 
            // gridViewCobros
            // 
            this.gridViewCobros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcr_TotalCobro,
            this.colcr_fecha,
            this.colcr_fechaCobro,
            this.colIdEstadoCobro1,
            this.colNumDocumento,
            this.colTipoDoc_Aplicado,
            this.colDocumento_Aplicado,
            this.colCliente,
            this.colIdCobro_tipo,
            this.colsaldo,
            this.colSucursal,
            this.colEstadoCobro,
            this.colTipoCobro,
            this.colIdCobro});
            this.gridViewCobros.GridControl = this.gridControlCobros;
            this.gridViewCobros.Name = "gridViewCobros";
            this.gridViewCobros.OptionsBehavior.Editable = false;
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 12;
            this.colcr_TotalCobro.Width = 79;
            // 
            // colcr_fecha
            // 
            this.colcr_fecha.FieldName = "cr_fecha";
            this.colcr_fecha.Name = "colcr_fecha";
            this.colcr_fecha.Visible = true;
            this.colcr_fecha.VisibleIndex = 6;
            // 
            // colcr_fechaCobro
            // 
            this.colcr_fechaCobro.FieldName = "cr_fechaCobro";
            this.colcr_fechaCobro.Name = "colcr_fechaCobro";
            this.colcr_fechaCobro.Visible = true;
            this.colcr_fechaCobro.VisibleIndex = 7;
            this.colcr_fechaCobro.Width = 132;
            // 
            // colIdEstadoCobro1
            // 
            this.colIdEstadoCobro1.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro1.Name = "colIdEstadoCobro1";
            this.colIdEstadoCobro1.Visible = true;
            this.colIdEstadoCobro1.VisibleIndex = 11;
            this.colIdEstadoCobro1.Width = 91;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 3;
            this.colNumDocumento.Width = 85;
            // 
            // colTipoDoc_Aplicado
            // 
            this.colTipoDoc_Aplicado.FieldName = "TipoDoc_Aplicado";
            this.colTipoDoc_Aplicado.Name = "colTipoDoc_Aplicado";
            this.colTipoDoc_Aplicado.Visible = true;
            this.colTipoDoc_Aplicado.VisibleIndex = 4;
            this.colTipoDoc_Aplicado.Width = 90;
            // 
            // colDocumento_Aplicado
            // 
            this.colDocumento_Aplicado.FieldName = "Documento_Aplicado";
            this.colDocumento_Aplicado.Name = "colDocumento_Aplicado";
            this.colDocumento_Aplicado.Visible = true;
            this.colDocumento_Aplicado.VisibleIndex = 5;
            this.colDocumento_Aplicado.Width = 109;
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            this.colCliente.Width = 82;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 8;
            this.colIdCobro_tipo.Width = 86;
            // 
            // colsaldo
            // 
            this.colsaldo.FieldName = "saldo";
            this.colsaldo.Name = "colsaldo";
            this.colsaldo.Visible = true;
            this.colsaldo.VisibleIndex = 13;
            this.colsaldo.Width = 34;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 0;
            this.colSucursal.Width = 82;
            // 
            // colEstadoCobro
            // 
            this.colEstadoCobro.FieldName = "EstadoCobro";
            this.colEstadoCobro.Name = "colEstadoCobro";
            this.colEstadoCobro.Visible = true;
            this.colEstadoCobro.VisibleIndex = 9;
            this.colEstadoCobro.Width = 82;
            // 
            // colTipoCobro
            // 
            this.colTipoCobro.FieldName = "TipoCobro";
            this.colTipoCobro.Name = "colTipoCobro";
            this.colTipoCobro.Visible = true;
            this.colTipoCobro.VisibleIndex = 10;
            this.colTipoCobro.Width = 71;
            // 
            // colIdCobro
            // 
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 2;
            this.colIdCobro.Width = 82;
            // 
            // frmCxc_Cobros_Doc_Cta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(964, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCxc_Cobros_Doc_Cta";
            this.Text = "frmCxc_Cobros_Doc_Cta";
            this.Load += new System.EventHandler(this.frmCxc_Cobros_Doc_Cta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstadoCobro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.Fechas.ResumeLayout(false);
            this.Fechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcxccobroxdocumentosxcobrarInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstadoCobro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox Fechas;
        private System.Windows.Forms.RadioButton rdFechaCobro;
        private System.Windows.Forms.RadioButton rdFechaCrea;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private Controles.UCFa_Cliente_Facturacion ucfA_Cliente_Facturacion1;
        private System.Windows.Forms.BindingSource cxcEstadoCobroInfoBindingSource;
        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoDoc;
        private System.Windows.Forms.BindingSource cxccobrotipoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion;
        private System.Windows.Forms.BindingSource vwcxccobroxdocumentosxcobrarInfoBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlCobros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCobros;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDoc_Aplicado;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento_Aplicado;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colsaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
    }
}
namespace Core.Erp.Winform.Roles
{
    partial class frmRo_MarcacionesMant
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
            this.roEmpleadoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.romarcacionesxempleadoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnObtenerRuta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoEquipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.romarcacionesEquipoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo_Equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFabricante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlMarcaciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewMarcaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo_Biometrico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_fechaRegistro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMarcaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_Hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexisteerror = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_empleado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.view_empleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomCompleto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo_Descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colde_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_Hentrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_HSalidaLunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_HRegresoLunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_Hsalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_fechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_semana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_dia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_sdia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_idDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_EsActualizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PbarEstado = new System.Windows.Forms.ToolStripProgressBar();
            this.TimerProcesar1 = new System.Windows.Forms.Timer();
            this.backgroundWorker_Marca = new System.ComponentModel.BackgroundWorker();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesEquipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roEmpleadoInfoBindingSource
            // 
            this.roEmpleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // romarcacionesxempleadoInfoBindingSource
            // 
            this.romarcacionesxempleadoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_x_empleado_Info);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 89);
            this.panel2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtHoja);
            this.groupBox3.Controls.Add(this.txtRuta);
            this.groupBox3.Controls.Add(this.btnObtenerRuta);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(212, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 89);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Archivo de Marcaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hoja del Excel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta del Archivo:";
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(116, 45);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(209, 20);
            this.txtHoja.TabIndex = 5;
            this.txtHoja.Text = "Marcaciones";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(116, 19);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(248, 20);
            this.txtRuta.TabIndex = 5;
            this.txtRuta.Text = "C:\\Users\\KATI\\Downloads\\Original2.xlsx";
            // 
            // btnObtenerRuta
            // 
            this.btnObtenerRuta.Location = new System.Drawing.Point(394, 17);
            this.btnObtenerRuta.Name = "btnObtenerRuta";
            this.btnObtenerRuta.Size = new System.Drawing.Size(91, 23);
            this.btnObtenerRuta.TabIndex = 4;
            this.btnObtenerRuta.Text = "Explorar";
            this.btnObtenerRuta.UseVisualStyleBackColor = true;
            this.btnObtenerRuta.Click += new System.EventHandler(this.btnObtenerRuta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoEquipo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipo de Marcaciones:";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.Location = new System.Drawing.Point(27, 39);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoEquipo.Properties.DataSource = this.romarcacionesEquipoInfoBindingSource;
            this.cmbTipoEquipo.Properties.DisplayMember = "Nombre_Equipo";
            this.cmbTipoEquipo.Properties.ValueMember = "IdEquipoMar";
            this.cmbTipoEquipo.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoEquipo.Size = new System.Drawing.Size(167, 20);
            this.cmbTipoEquipo.TabIndex = 5;
            // 
            // romarcacionesEquipoInfoBindingSource
            // 
            this.romarcacionesEquipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_marcaciones_Equipo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Equipo,
            this.colModelo_Equipo,
            this.colFabricante,
            this.colProveedor});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre_Equipo
            // 
            this.colNombre_Equipo.Caption = "Equipo";
            this.colNombre_Equipo.FieldName = "Nombre_Equipo";
            this.colNombre_Equipo.Name = "colNombre_Equipo";
            this.colNombre_Equipo.Visible = true;
            this.colNombre_Equipo.VisibleIndex = 0;
            this.colNombre_Equipo.Width = 404;
            // 
            // colModelo_Equipo
            // 
            this.colModelo_Equipo.Caption = "Modelo";
            this.colModelo_Equipo.FieldName = "Modelo_Equipo";
            this.colModelo_Equipo.Name = "colModelo_Equipo";
            this.colModelo_Equipo.Visible = true;
            this.colModelo_Equipo.VisibleIndex = 1;
            this.colModelo_Equipo.Width = 258;
            // 
            // colFabricante
            // 
            this.colFabricante.Caption = "Fabricante";
            this.colFabricante.FieldName = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.Visible = true;
            this.colFabricante.VisibleIndex = 2;
            this.colFabricante.Width = 258;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Proveedor";
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 3;
            this.colProveedor.Width = 260;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.gridControlMarcaciones);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 449);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Consulta";
            // 
            // gridControlMarcaciones
            // 
            this.gridControlMarcaciones.DataSource = this.romarcacionesxempleadoInfoBindingSource;
            this.gridControlMarcaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMarcaciones.Location = new System.Drawing.Point(3, 105);
            this.gridControlMarcaciones.MainView = this.gridViewMarcaciones;
            this.gridControlMarcaciones.Name = "gridControlMarcaciones";
            this.gridControlMarcaciones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_empleado});
            this.gridControlMarcaciones.Size = new System.Drawing.Size(769, 319);
            this.gridControlMarcaciones.TabIndex = 8;
            this.gridControlMarcaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMarcaciones,
            this.gridView1});
            // 
            // gridViewMarcaciones
            // 
            this.gridViewMarcaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo_Biometrico,
            this.colem_codigo,
            this.colNomCompleto,
            this.coles_fechaRegistro1,
            this.colIdTipoMarcaciones,
            this.coles_Hora,
            this.colexisteerror});
            this.gridViewMarcaciones.GridControl = this.gridControlMarcaciones;
            this.gridViewMarcaciones.Name = "gridViewMarcaciones";
            this.gridViewMarcaciones.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMarcaciones.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewMarcaciones_RowCellStyle);
            // 
            // colCodigo_Biometrico
            // 
            this.colCodigo_Biometrico.Caption = "Código Biómetrico";
            this.colCodigo_Biometrico.FieldName = "Codigo_Biometrico";
            this.colCodigo_Biometrico.Name = "colCodigo_Biometrico";
            this.colCodigo_Biometrico.Visible = true;
            this.colCodigo_Biometrico.VisibleIndex = 0;
            // 
            // colem_codigo
            // 
            this.colem_codigo.Caption = "Código";
            this.colem_codigo.FieldName = "em_codigo";
            this.colem_codigo.Name = "colem_codigo";
            this.colem_codigo.Visible = true;
            this.colem_codigo.VisibleIndex = 1;
            // 
            // colNomCompleto
            // 
            this.colNomCompleto.Caption = "Empleado";
            this.colNomCompleto.FieldName = "NomCompleto";
            this.colNomCompleto.Name = "colNomCompleto";
            this.colNomCompleto.Visible = true;
            this.colNomCompleto.VisibleIndex = 2;
            // 
            // coles_fechaRegistro1
            // 
            this.coles_fechaRegistro1.Caption = "Fecha";
            this.coles_fechaRegistro1.FieldName = "es_fechaRegistro";
            this.coles_fechaRegistro1.Name = "coles_fechaRegistro1";
            this.coles_fechaRegistro1.Visible = true;
            this.coles_fechaRegistro1.VisibleIndex = 3;
            // 
            // colIdTipoMarcaciones
            // 
            this.colIdTipoMarcaciones.Caption = "Marcaciones";
            this.colIdTipoMarcaciones.FieldName = "IdTipoMarcaciones";
            this.colIdTipoMarcaciones.Name = "colIdTipoMarcaciones";
            this.colIdTipoMarcaciones.Visible = true;
            this.colIdTipoMarcaciones.VisibleIndex = 4;
            // 
            // coles_Hora
            // 
            this.coles_Hora.Caption = "Hora";
            this.coles_Hora.FieldName = "es_Hora";
            this.coles_Hora.Name = "coles_Hora";
            this.coles_Hora.Visible = true;
            this.coles_Hora.VisibleIndex = 5;
            // 
            // colexisteerror
            // 
            this.colexisteerror.Caption = "Error";
            this.colexisteerror.FieldName = "existeerror";
            this.colexisteerror.Name = "colexisteerror";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.AutoHeight = false;
            this.cmb_empleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empleado.DataSource = this.roEmpleadoInfoBindingSource;
            this.cmb_empleado.DisplayMember = "NomCompleto";
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.ValueMember = "IdEmpleado";
            this.cmb_empleado.View = this.view_empleado;
            // 
            // view_empleado
            // 
            this.view_empleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomCompleto2,
            this.colcargo_Descripcion1,
            this.colde_descripcion1});
            this.view_empleado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.view_empleado.Name = "view_empleado";
            this.view_empleado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.view_empleado.OptionsView.ShowGroupPanel = false;
            // 
            // colNomCompleto2
            // 
            this.colNomCompleto2.Caption = "Empleado";
            this.colNomCompleto2.FieldName = "NomCompleto";
            this.colNomCompleto2.Name = "colNomCompleto2";
            this.colNomCompleto2.Visible = true;
            this.colNomCompleto2.VisibleIndex = 0;
            // 
            // colcargo_Descripcion1
            // 
            this.colcargo_Descripcion1.Caption = "Cargo";
            this.colcargo_Descripcion1.FieldName = "cargo_Descripcion";
            this.colcargo_Descripcion1.Name = "colcargo_Descripcion1";
            this.colcargo_Descripcion1.Visible = true;
            this.colcargo_Descripcion1.VisibleIndex = 1;
            // 
            // colde_descripcion1
            // 
            this.colde_descripcion1.Caption = "Descripcion";
            this.colde_descripcion1.FieldName = "de_descripcion";
            this.colde_descripcion1.Name = "colde_descripcion1";
            this.colde_descripcion1.Visible = true;
            this.colde_descripcion1.VisibleIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.coles_Hentrada,
            this.coles_HSalidaLunch,
            this.coles_HRegresoLunch,
            this.coles_Hsalida,
            this.coles_fechaRegistro,
            this.coles_anio,
            this.coles_mes,
            this.coles_semana,
            this.coles_dia,
            this.coles_sdia,
            this.coles_idDia,
            this.coles_EsActualizacion});
            this.gridView1.GridControl = this.gridControlMarcaciones;
            this.gridView1.Name = "gridView1";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            // 
            // coles_Hentrada
            // 
            this.coles_Hentrada.FieldName = "es_Hentrada";
            this.coles_Hentrada.Name = "coles_Hentrada";
            this.coles_Hentrada.Visible = true;
            this.coles_Hentrada.VisibleIndex = 1;
            // 
            // coles_HSalidaLunch
            // 
            this.coles_HSalidaLunch.FieldName = "es_HSalidaLunch";
            this.coles_HSalidaLunch.Name = "coles_HSalidaLunch";
            this.coles_HSalidaLunch.Visible = true;
            this.coles_HSalidaLunch.VisibleIndex = 2;
            // 
            // coles_HRegresoLunch
            // 
            this.coles_HRegresoLunch.FieldName = "es_HRegresoLunch";
            this.coles_HRegresoLunch.Name = "coles_HRegresoLunch";
            this.coles_HRegresoLunch.Visible = true;
            this.coles_HRegresoLunch.VisibleIndex = 3;
            // 
            // coles_Hsalida
            // 
            this.coles_Hsalida.FieldName = "es_Hsalida";
            this.coles_Hsalida.Name = "coles_Hsalida";
            this.coles_Hsalida.Visible = true;
            this.coles_Hsalida.VisibleIndex = 4;
            // 
            // coles_fechaRegistro
            // 
            this.coles_fechaRegistro.FieldName = "es_fechaRegistro";
            this.coles_fechaRegistro.Name = "coles_fechaRegistro";
            this.coles_fechaRegistro.Visible = true;
            this.coles_fechaRegistro.VisibleIndex = 5;
            // 
            // coles_anio
            // 
            this.coles_anio.FieldName = "es_anio";
            this.coles_anio.Name = "coles_anio";
            this.coles_anio.Visible = true;
            this.coles_anio.VisibleIndex = 6;
            // 
            // coles_mes
            // 
            this.coles_mes.FieldName = "es_mes";
            this.coles_mes.Name = "coles_mes";
            this.coles_mes.Visible = true;
            this.coles_mes.VisibleIndex = 7;
            // 
            // coles_semana
            // 
            this.coles_semana.FieldName = "es_semana";
            this.coles_semana.Name = "coles_semana";
            this.coles_semana.Visible = true;
            this.coles_semana.VisibleIndex = 8;
            // 
            // coles_dia
            // 
            this.coles_dia.FieldName = "es_dia";
            this.coles_dia.Name = "coles_dia";
            this.coles_dia.Visible = true;
            this.coles_dia.VisibleIndex = 9;
            // 
            // coles_sdia
            // 
            this.coles_sdia.FieldName = "es_sdia";
            this.coles_sdia.Name = "coles_sdia";
            this.coles_sdia.Visible = true;
            this.coles_sdia.VisibleIndex = 10;
            // 
            // coles_idDia
            // 
            this.coles_idDia.FieldName = "es_idDia";
            this.coles_idDia.Name = "coles_idDia";
            this.coles_idDia.Visible = true;
            this.coles_idDia.VisibleIndex = 11;
            // 
            // coles_EsActualizacion
            // 
            this.coles_EsActualizacion.FieldName = "es_EsActualizacion";
            this.coles_EsActualizacion.Name = "coles_EsActualizacion";
            this.coles_EsActualizacion.Visible = true;
            this.coles_EsActualizacion.VisibleIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PbarEstado,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PbarEstado
            // 
            this.PbarEstado.Name = "PbarEstado";
            this.PbarEstado.Size = new System.Drawing.Size(680, 16);
            this.PbarEstado.Value = 20;
            // 
            // TimerProcesar1
            // 
            this.TimerProcesar1.Interval = 1000;
            this.TimerProcesar1.Tick += new System.EventHandler(this.TimerProcesar1_Tick);
            // 
            // backgroundWorker_Marca
            // 
            this.backgroundWorker_Marca.WorkerReportsProgress = true;
            this.backgroundWorker_Marca.WorkerSupportsCancellation = true;
            this.backgroundWorker_Marca.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Marca_DoWork);
            this.backgroundWorker_Marca.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Marca_ProgressChanged);
            this.backgroundWorker_Marca.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Marca_RunWorkerCompleted);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(775, 29);
            this.ucGe_Menu.TabIndex = 73;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 105);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmRo_MarcacionesMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 480);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmRo_MarcacionesMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Marcaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_MarcacionesMant_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_MarcacionesMant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesxempleadoInfoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romarcacionesEquipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roEmpleadoInfoBindingSource;
        private System.Windows.Forms.BindingSource romarcacionesxempleadoInfoBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoEquipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource romarcacionesEquipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Equipo;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo_Equipo;
        private DevExpress.XtraGrid.Columns.GridColumn colFabricante;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObtenerRuta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar PbarEstado;
        private System.Windows.Forms.Timer TimerProcesar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Marca;
        private DevExpress.XtraGrid.GridControl gridControlMarcaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarcaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Biometrico;
        private DevExpress.XtraGrid.Columns.GridColumn colem_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn coles_fechaRegistro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMarcaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coles_Hora;
        private DevExpress.XtraGrid.Columns.GridColumn colexisteerror;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_empleado;
        private DevExpress.XtraGrid.Views.Grid.GridView view_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCompleto2;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo_Descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colde_descripcion1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coles_Hentrada;
        private DevExpress.XtraGrid.Columns.GridColumn coles_HSalidaLunch;
        private DevExpress.XtraGrid.Columns.GridColumn coles_HRegresoLunch;
        private DevExpress.XtraGrid.Columns.GridColumn coles_Hsalida;
        private DevExpress.XtraGrid.Columns.GridColumn coles_fechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn coles_anio;
        private DevExpress.XtraGrid.Columns.GridColumn coles_mes;
        private DevExpress.XtraGrid.Columns.GridColumn coles_semana;
        private DevExpress.XtraGrid.Columns.GridColumn coles_dia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_sdia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_idDia;
        private DevExpress.XtraGrid.Columns.GridColumn coles_EsActualizacion;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
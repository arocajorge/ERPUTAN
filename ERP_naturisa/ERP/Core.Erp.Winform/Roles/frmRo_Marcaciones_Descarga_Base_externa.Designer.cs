namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Marcaciones_Descarga_Base_externa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CmbGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMarcacionesBaseExterna = new DevExpress.XtraGrid.GridControl();
            this.gridViewMarcacionesBaseExterna = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdTipoMarcaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColHMarcacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coles_fechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colem_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoEquipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo_Equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbDescargar = new DevExpress.XtraEditors.SimpleButton();
            this.DtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.backgroundWorker_Marca = new System.ComponentModel.BackgroundWorker();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.TimerProcesar1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManagereEspera = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.Roles.frmRo_WaitForm_Espera), true, true);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacionesBaseExterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcacionesBaseExterna)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEquipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 371);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 93);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CmbGrabar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlMarcacionesBaseExterna);
            this.splitContainer1.Size = new System.Drawing.Size(816, 278);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 5;
            // 
            // CmbGrabar
            // 
            this.CmbGrabar.Location = new System.Drawing.Point(718, 9);
            this.CmbGrabar.Name = "CmbGrabar";
            this.CmbGrabar.Size = new System.Drawing.Size(97, 23);
            this.CmbGrabar.TabIndex = 0;
            this.CmbGrabar.Text = "Importar/Guardar";
            this.CmbGrabar.Click += new System.EventHandler(this.CmbGrabar_Click);
            // 
            // gridControlMarcacionesBaseExterna
            // 
            this.gridControlMarcacionesBaseExterna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMarcacionesBaseExterna.Location = new System.Drawing.Point(0, 0);
            this.gridControlMarcacionesBaseExterna.MainView = this.gridViewMarcacionesBaseExterna;
            this.gridControlMarcacionesBaseExterna.Name = "gridControlMarcacionesBaseExterna";
            this.gridControlMarcacionesBaseExterna.Size = new System.Drawing.Size(816, 241);
            this.gridControlMarcacionesBaseExterna.TabIndex = 0;
            this.gridControlMarcacionesBaseExterna.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMarcacionesBaseExterna});
            // 
            // gridViewMarcacionesBaseExterna
            // 
            this.gridViewMarcacionesBaseExterna.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCheck,
            this.Colcedula,
            this.ColIdTipoMarcaciones,
            this.ColHMarcacion,
            this.ColNomCompleto,
            this.Coles_fechaRegistro,
            this.ColError,
            this.ColApellidos,
            this.ColNombres,
            this.Colem_codigo});
            this.gridViewMarcacionesBaseExterna.GridControl = this.gridControlMarcacionesBaseExterna;
            this.gridViewMarcacionesBaseExterna.Name = "gridViewMarcacionesBaseExterna";
            this.gridViewMarcacionesBaseExterna.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMarcacionesBaseExterna.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewMarcacionesBaseExterna_RowCellStyle);
            // 
            // ColCheck
            // 
            this.ColCheck.Caption = "*";
            this.ColCheck.FieldName = "check";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Visible = true;
            this.ColCheck.VisibleIndex = 0;
            this.ColCheck.Width = 24;
            // 
            // Colcedula
            // 
            this.Colcedula.Caption = "Cedula";
            this.Colcedula.FieldName = "cedula";
            this.Colcedula.Name = "Colcedula";
            this.Colcedula.OptionsColumn.ReadOnly = true;
            this.Colcedula.Visible = true;
            this.Colcedula.VisibleIndex = 2;
            this.Colcedula.Width = 80;
            // 
            // ColIdTipoMarcaciones
            // 
            this.ColIdTipoMarcaciones.Caption = "Tipo Marcacion";
            this.ColIdTipoMarcaciones.FieldName = "IdTipoMarcaciones";
            this.ColIdTipoMarcaciones.Name = "ColIdTipoMarcaciones";
            this.ColIdTipoMarcaciones.OptionsColumn.ReadOnly = true;
            this.ColIdTipoMarcaciones.Visible = true;
            this.ColIdTipoMarcaciones.VisibleIndex = 8;
            this.ColIdTipoMarcaciones.Width = 43;
            // 
            // ColHMarcacion
            // 
            this.ColHMarcacion.Caption = "Hora";
            this.ColHMarcacion.FieldName = "HMarcacion";
            this.ColHMarcacion.Name = "ColHMarcacion";
            this.ColHMarcacion.OptionsColumn.ReadOnly = true;
            this.ColHMarcacion.Visible = true;
            this.ColHMarcacion.VisibleIndex = 7;
            this.ColHMarcacion.Width = 35;
            // 
            // ColNomCompleto
            // 
            this.ColNomCompleto.Caption = "Nombre Empleado";
            this.ColNomCompleto.FieldName = "NomCompleto";
            this.ColNomCompleto.Name = "ColNomCompleto";
            this.ColNomCompleto.OptionsColumn.ReadOnly = true;
            this.ColNomCompleto.Visible = true;
            this.ColNomCompleto.VisibleIndex = 5;
            this.ColNomCompleto.Width = 180;
            // 
            // Coles_fechaRegistro
            // 
            this.Coles_fechaRegistro.Caption = "Fecha";
            this.Coles_fechaRegistro.FieldName = "es_fechaRegistro";
            this.Coles_fechaRegistro.Name = "Coles_fechaRegistro";
            this.Coles_fechaRegistro.OptionsColumn.ReadOnly = true;
            this.Coles_fechaRegistro.Visible = true;
            this.Coles_fechaRegistro.VisibleIndex = 6;
            this.Coles_fechaRegistro.Width = 58;
            // 
            // ColError
            // 
            this.ColError.Caption = "Error";
            this.ColError.FieldName = "Error";
            this.ColError.Name = "ColError";
            this.ColError.Visible = true;
            this.ColError.VisibleIndex = 9;
            this.ColError.Width = 184;
            // 
            // ColApellidos
            // 
            this.ColApellidos.Caption = "Apellidos";
            this.ColApellidos.FieldName = "Apellidos";
            this.ColApellidos.Name = "ColApellidos";
            this.ColApellidos.Visible = true;
            this.ColApellidos.VisibleIndex = 3;
            this.ColApellidos.Width = 58;
            // 
            // ColNombres
            // 
            this.ColNombres.Caption = "Nombres";
            this.ColNombres.FieldName = "Nombres";
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.Visible = true;
            this.ColNombres.VisibleIndex = 4;
            this.ColNombres.Width = 68;
            // 
            // Colem_codigo
            // 
            this.Colem_codigo.Caption = "Codigo";
            this.Colem_codigo.FieldName = "em_codigo";
            this.Colem_codigo.Name = "Colem_codigo";
            this.Colem_codigo.Visible = true;
            this.Colem_codigo.VisibleIndex = 1;
            this.Colem_codigo.Width = 58;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbTipoEquipo);
            this.panel2.Controls.Add(this.DtpFechaF);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CmbDescargar);
            this.panel2.Controls.Add(this.DtpFechaI);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 64);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Biometrico";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.Location = new System.Drawing.Point(442, 11);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoEquipo.Properties.DisplayMember = "Nombre_Equipo";
            this.cmbTipoEquipo.Properties.ValueMember = "IdEquipoMar";
            this.cmbTipoEquipo.Properties.View = this.searchLookUpEdit1View;
            this.cmbTipoEquipo.Size = new System.Drawing.Size(371, 20);
            this.cmbTipoEquipo.TabIndex = 6;
            this.cmbTipoEquipo.EditValueChanged += new System.EventHandler(this.cmbTipoEquipo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Equipo,
            this.colModelo_Equipo});
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
            this.colNombre_Equipo.Width = 238;
            // 
            // colModelo_Equipo
            // 
            this.colModelo_Equipo.Caption = "Modelo";
            this.colModelo_Equipo.FieldName = "Modelo_Equipo";
            this.colModelo_Equipo.Name = "colModelo_Equipo";
            this.colModelo_Equipo.Visible = true;
            this.colModelo_Equipo.VisibleIndex = 1;
            this.colModelo_Equipo.Width = 926;
            // 
            // DtpFechaF
            // 
            this.DtpFechaF.Location = new System.Drawing.Point(165, 37);
            this.DtpFechaF.Name = "DtpFechaF";
            this.DtpFechaF.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaF.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descargar marcaciones Hasta";
            // 
            // CmbDescargar
            // 
            this.CmbDescargar.Location = new System.Drawing.Point(718, 33);
            this.CmbDescargar.Name = "CmbDescargar";
            this.CmbDescargar.Size = new System.Drawing.Size(95, 28);
            this.CmbDescargar.TabIndex = 2;
            this.CmbDescargar.Text = "Descargar";
            this.CmbDescargar.Click += new System.EventHandler(this.CmbDescargar_Click);
            // 
            // DtpFechaI
            // 
            this.DtpFechaI.Enabled = false;
            this.DtpFechaI.Location = new System.Drawing.Point(165, 11);
            this.DtpFechaI.Name = "DtpFechaI";
            this.DtpFechaI.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Ultimo Corte:";
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(816, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 3;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // backgroundWorker_Marca
            // 
            this.backgroundWorker_Marca.WorkerReportsProgress = true;
            this.backgroundWorker_Marca.WorkerSupportsCancellation = true;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 371);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(816, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // TimerProcesar1
            // 
            this.TimerProcesar1.Interval = 1000;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // frmRo_Marcaciones_Descarga_Base_externa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "frmRo_Marcaciones_Descarga_Base_externa";
            this.Text = "Marcaciones Biometrico";
            this.Load += new System.EventHandler(this.frmRo_Marcaciones_Descarga_Base_externa_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcacionesBaseExterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcacionesBaseExterna)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoEquipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Marca;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Timer TimerProcesar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton CmbGrabar;
        private DevExpress.XtraGrid.GridControl gridControlMarcacionesBaseExterna;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarcacionesBaseExterna;
        private DevExpress.XtraGrid.Columns.GridColumn Colcedula;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdTipoMarcaciones;
        private DevExpress.XtraGrid.Columns.GridColumn ColHMarcacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Coles_fechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn ColError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoEquipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Equipo;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo_Equipo;
        private System.Windows.Forms.DateTimePicker DtpFechaF;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton CmbDescargar;
        private System.Windows.Forms.DateTimePicker DtpFechaI;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.Columns.GridColumn ColCheck;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombres;
        private DevExpress.XtraGrid.Columns.GridColumn Colem_codigo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagereEspera;

    }
}
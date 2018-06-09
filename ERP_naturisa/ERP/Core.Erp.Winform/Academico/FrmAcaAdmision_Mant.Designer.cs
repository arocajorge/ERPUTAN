namespace Core.Erp.Winform.Academico
{
    
    partial class FrmAcaAdmision_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Form = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblIdAspiranteTxt = new DevExpress.XtraEditors.LabelControl();
            this.lblIdAspirante = new DevExpress.XtraEditors.LabelControl();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigoAdmision = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoAdmision = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAdmision = new DevExpress.XtraEditors.TextEdit();
            this.lblIdAdmision = new DevExpress.XtraEditors.LabelControl();
            this.lblIdPersonaTxt = new DevExpress.XtraEditors.LabelControl();
            this.lblIdPersona = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.lblApellidos = new DevExpress.XtraEditors.LabelControl();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.lblNombres = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_Docu_PerIdentificacion = new Core.Erp.Winform.Controles.UCGe_Docu_Personales();
            this.txtCedRuc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabAdmision = new DevExpress.XtraTab.XtraTabControl();
            this.tabDatosPersonales = new DevExpress.XtraTab.XtraTabPage();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.lblLugar = new DevExpress.XtraEditors.LabelControl();
            this.txtBarrio = new DevExpress.XtraEditors.TextEdit();
            this.lblBarrio = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNroCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.rgSexo = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tabCursoAqueAplica = new DevExpress.XtraTab.XtraTabPage();
            this.cmbSeccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSeccionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSede = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaSedeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionSede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCurso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCursoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbJornada = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaJornadaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbAnioLectivo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaAnioLectivoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPeriodoLectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSeccion = new DevExpress.XtraEditors.LabelControl();
            this.lblSede = new DevExpress.XtraEditors.LabelControl();
            this.lblCurso = new DevExpress.XtraEditors.LabelControl();
            this.lblJornada = new DevExpress.XtraEditors.LabelControl();
            this.lblAnioLectivo = new DevExpress.XtraEditors.LabelControl();
            this.tabInformacionAdicional = new DevExpress.XtraTab.XtraTabPage();
            this.rgHijoProfesorNuestrocolegio = new DevExpress.XtraEditors.RadioGroup();
            this.lblHijoProfesorNuestroColegio = new DevExpress.XtraEditors.LabelControl();
            this.txtEnQueGrado = new DevExpress.XtraEditors.TextEdit();
            this.lblEnQueGrado = new DevExpress.XtraEditors.LabelControl();
            this.rgTieneHermanosEnNuestroColegio = new DevExpress.XtraEditors.RadioGroup();
            this.lblTieneHermanosNuestroColegio = new DevExpress.XtraEditors.LabelControl();
            this.rgTieneHermanosEnOtroColegio = new DevExpress.XtraEditors.RadioGroup();
            this.lblTieneHermanosEnOtroColegio = new DevExpress.XtraEditors.LabelControl();
            this.txtCualEstablecimientoEducativoAsiste = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rgAsisteEstablecimientoEducativo = new DevExpress.XtraEditors.RadioGroup();
            this.lblAsisteAlgunEstablecimientoEducativo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.rgHijoUnico = new DevExpress.XtraEditors.RadioGroup();
            this.chkPoseeDiscapacidad = new DevExpress.XtraEditors.CheckEdit();
            this.txtTelefonoEmergencia = new DevExpress.XtraEditors.TextEdit();
            this.cmbIdiomaNativo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoSangre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbReligion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTelefonoEmergencia = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTipoSangre = new DevExpress.XtraEditors.LabelControl();
            this.lblReligion = new DevExpress.XtraEditors.LabelControl();
            this.lblConQuienVive = new DevExpress.XtraEditors.LabelControl();
            this.cmbConQuienVive = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAdmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAdmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAdmision)).BeginInit();
            this.xtraTabAdmision.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).BeginInit();
            this.tabCursoAqueAplica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCursoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioLectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAnioLectivoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.tabInformacionAdicional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgHijoProfesorNuestrocolegio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnQueGrado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTieneHermanosEnNuestroColegio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTieneHermanosEnOtroColegio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCualEstablecimientoEducativoAsiste.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAsisteEstablecimientoEducativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgHijoUnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPoseeDiscapacidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoEmergencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdiomaNativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSangre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReligion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConQuienVive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(679, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Form
            // 
            this.ucGe_BarraEstadoInferior_Form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Form.Location = new System.Drawing.Point(0, 580);
            this.ucGe_BarraEstadoInferior_Form.Name = "ucGe_BarraEstadoInferior_Form";
            this.ucGe_BarraEstadoInferior_Form.Size = new System.Drawing.Size(679, 26);
            this.ucGe_BarraEstadoInferior_Form.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblIdAspiranteTxt);
            this.panelControl1.Controls.Add(this.lblIdAspirante);
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.chkActivo);
            this.panelControl1.Controls.Add(this.txtCodigoAdmision);
            this.panelControl1.Controls.Add(this.lblCodigoAdmision);
            this.panelControl1.Controls.Add(this.txtIdAdmision);
            this.panelControl1.Controls.Add(this.lblIdAdmision);
            this.panelControl1.Controls.Add(this.lblIdPersonaTxt);
            this.panelControl1.Controls.Add(this.lblIdPersona);
            this.panelControl1.Controls.Add(this.txtApellidos);
            this.panelControl1.Controls.Add(this.lblApellidos);
            this.panelControl1.Controls.Add(this.txtNombres);
            this.panelControl1.Controls.Add(this.lblNombres);
            this.panelControl1.Controls.Add(this.ucGe_Docu_PerIdentificacion);
            this.panelControl1.Controls.Add(this.txtCedRuc);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 129);
            this.panelControl1.TabIndex = 3;
            // 
            // lblIdAspiranteTxt
            // 
            this.lblIdAspiranteTxt.Location = new System.Drawing.Point(579, 39);
            this.lblIdAspiranteTxt.Name = "lblIdAspiranteTxt";
            this.lblIdAspiranteTxt.Size = new System.Drawing.Size(6, 13);
            this.lblIdAspiranteTxt.TabIndex = 59;
            this.lblIdAspiranteTxt.Text = "0";
            // 
            // lblIdAspirante
            // 
            this.lblIdAspirante.Location = new System.Drawing.Point(510, 39);
            this.lblIdAspirante.Name = "lblIdAspirante";
            this.lblIdAspirante.Size = new System.Drawing.Size(63, 13);
            this.lblIdAspirante.TabIndex = 58;
            this.lblIdAspirante.Text = "Id Aspirante:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(466, 91);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 57;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(608, 91);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(64, 19);
            this.chkActivo.TabIndex = 56;
            // 
            // txtCodigoAdmision
            // 
            this.txtCodigoAdmision.Location = new System.Drawing.Point(318, 11);
            this.txtCodigoAdmision.Name = "txtCodigoAdmision";
            this.txtCodigoAdmision.Properties.ReadOnly = true;
            this.txtCodigoAdmision.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoAdmision.TabIndex = 55;
            // 
            // lblCodigoAdmision
            // 
            this.lblCodigoAdmision.Location = new System.Drawing.Point(230, 13);
            this.lblCodigoAdmision.Name = "lblCodigoAdmision";
            this.lblCodigoAdmision.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoAdmision.TabIndex = 54;
            this.lblCodigoAdmision.Text = "Código Admisión:";
            // 
            // txtIdAdmision
            // 
            this.txtIdAdmision.EditValue = "0";
            this.txtIdAdmision.Location = new System.Drawing.Point(77, 10);
            this.txtIdAdmision.Name = "txtIdAdmision";
            this.txtIdAdmision.Properties.ReadOnly = true;
            this.txtIdAdmision.Size = new System.Drawing.Size(122, 20);
            this.txtIdAdmision.TabIndex = 53;
            // 
            // lblIdAdmision
            // 
            this.lblIdAdmision.Location = new System.Drawing.Point(12, 14);
            this.lblIdAdmision.Name = "lblIdAdmision";
            this.lblIdAdmision.Size = new System.Drawing.Size(59, 13);
            this.lblIdAdmision.TabIndex = 52;
            this.lblIdAdmision.Text = "Id Admisión:";
            // 
            // lblIdPersonaTxt
            // 
            this.lblIdPersonaTxt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblIdPersonaTxt.Location = new System.Drawing.Point(579, 17);
            this.lblIdPersonaTxt.Name = "lblIdPersonaTxt";
            this.lblIdPersonaTxt.Size = new System.Drawing.Size(6, 13);
            this.lblIdPersonaTxt.TabIndex = 51;
            this.lblIdPersonaTxt.Text = "0";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.Location = new System.Drawing.Point(517, 17);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(56, 13);
            this.lblIdPersona.TabIndex = 50;
            this.lblIdPersona.Text = "Id Persona:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(76, 91);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(365, 20);
            this.txtApellidos.TabIndex = 49;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Location = new System.Drawing.Point(12, 98);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(46, 13);
            this.lblApellidos.TabIndex = 48;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(76, 66);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(365, 20);
            this.txtNombres.TabIndex = 47;
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(12, 68);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(46, 13);
            this.lblNombres.TabIndex = 46;
            this.lblNombres.Text = "Nombres:";
            // 
            // ucGe_Docu_PerIdentificacion
            // 
            this.ucGe_Docu_PerIdentificacion._TipoDocPer = null;
            this.ucGe_Docu_PerIdentificacion.Location = new System.Drawing.Point(86, 39);
            this.ucGe_Docu_PerIdentificacion.Name = "ucGe_Docu_PerIdentificacion";
            this.ucGe_Docu_PerIdentificacion.Size = new System.Drawing.Size(113, 27);
            this.ucGe_Docu_PerIdentificacion.TabIndex = 45;
            // 
            // txtCedRuc
            // 
            this.txtCedRuc.Location = new System.Drawing.Point(205, 36);
            this.txtCedRuc.Name = "txtCedRuc";
            this.txtCedRuc.Size = new System.Drawing.Size(236, 20);
            this.txtCedRuc.TabIndex = 44;
            this.txtCedRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedRuc_KeyPress);
            this.txtCedRuc.Leave += new System.EventHandler(this.txtCedRuc_Leave);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Identificación:";
            // 
            // xtraTabAdmision
            // 
            this.xtraTabAdmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabAdmision.Location = new System.Drawing.Point(0, 158);
            this.xtraTabAdmision.Name = "xtraTabAdmision";
            this.xtraTabAdmision.SelectedTabPage = this.tabDatosPersonales;
            this.xtraTabAdmision.Size = new System.Drawing.Size(679, 422);
            this.xtraTabAdmision.TabIndex = 4;
            this.xtraTabAdmision.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDatosPersonales,
            this.tabCursoAqueAplica,
            this.tabInformacionAdicional});
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.Controls.Add(this.txtLugar);
            this.tabDatosPersonales.Controls.Add(this.lblLugar);
            this.tabDatosPersonales.Controls.Add(this.txtBarrio);
            this.tabDatosPersonales.Controls.Add(this.lblBarrio);
            this.tabDatosPersonales.Controls.Add(this.txtDireccion);
            this.tabDatosPersonales.Controls.Add(this.lblDireccion);
            this.tabDatosPersonales.Controls.Add(this.txtEmail);
            this.tabDatosPersonales.Controls.Add(this.txtNroCelular);
            this.tabDatosPersonales.Controls.Add(this.txtTelefono);
            this.tabDatosPersonales.Controls.Add(this.labelControl13);
            this.tabDatosPersonales.Controls.Add(this.labelControl12);
            this.tabDatosPersonales.Controls.Add(this.labelControl11);
            this.tabDatosPersonales.Controls.Add(this.cmbNacionalidad);
            this.tabDatosPersonales.Controls.Add(this.labelControl8);
            this.tabDatosPersonales.Controls.Add(this.rgSexo);
            this.tabDatosPersonales.Controls.Add(this.labelControl6);
            this.tabDatosPersonales.Controls.Add(this.dtFechaNacimiento);
            this.tabDatosPersonales.Controls.Add(this.labelControl5);
            this.tabDatosPersonales.Name = "tabDatosPersonales";
            this.tabDatosPersonales.Size = new System.Drawing.Size(673, 394);
            this.tabDatosPersonales.Text = "Datos Personales ";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(117, 226);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(514, 20);
            this.txtLugar.TabIndex = 48;
            // 
            // lblLugar
            // 
            this.lblLugar.Location = new System.Drawing.Point(9, 230);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(100, 13);
            this.lblLugar.TabIndex = 47;
            this.lblLugar.Text = "Sector/Urbanización:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(117, 174);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(514, 20);
            this.txtBarrio.TabIndex = 46;
            // 
            // lblBarrio
            // 
            this.lblBarrio.Location = new System.Drawing.Point(9, 181);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(32, 13);
            this.lblBarrio.TabIndex = 45;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 280);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(514, 20);
            this.txtDireccion.TabIndex = 44;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(9, 283);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(47, 13);
            this.lblDireccion.TabIndex = 43;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 328);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(514, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // txtNroCelular
            // 
            this.txtNroCelular.Location = new System.Drawing.Point(390, 131);
            this.txtNroCelular.Name = "txtNroCelular";
            this.txtNroCelular.Size = new System.Drawing.Size(182, 20);
            this.txtNroCelular.TabIndex = 41;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(118, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 20);
            this.txtTelefono.TabIndex = 40;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(9, 330);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 13);
            this.labelControl13.TabIndex = 39;
            this.labelControl13.Text = "E-mail:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(347, 138);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 38;
            this.labelControl12.Text = "Celular:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(9, 142);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 37;
            this.labelControl11.Text = "Teléfono:";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.DisplayMember = "Nacionalidad";
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(117, 88);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(217, 21);
            this.cmbNacionalidad.TabIndex = 36;
            this.cmbNacionalidad.ValueMember = "IdPais";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 100);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "Nacionalidad:";
            // 
            // rgSexo
            // 
            this.rgSexo.Location = new System.Drawing.Point(531, 35);
            this.rgSexo.Name = "rgSexo";
            this.rgSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_MAS", "Masculimo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_FEM", "Fenemino")});
            this.rgSexo.Size = new System.Drawing.Size(100, 58);
            this.rgSexo.TabIndex = 34;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(497, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Sexo:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.EditValue = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(117, 45);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.dtFechaNacimiento.TabIndex = 32;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Fecha de nacimiento:";
            // 
            // tabCursoAqueAplica
            // 
            this.tabCursoAqueAplica.Controls.Add(this.cmbSeccion);
            this.tabCursoAqueAplica.Controls.Add(this.cmbSede);
            this.tabCursoAqueAplica.Controls.Add(this.cmbCurso);
            this.tabCursoAqueAplica.Controls.Add(this.cmbJornada);
            this.tabCursoAqueAplica.Controls.Add(this.cmbAnioLectivo);
            this.tabCursoAqueAplica.Controls.Add(this.lblSeccion);
            this.tabCursoAqueAplica.Controls.Add(this.lblSede);
            this.tabCursoAqueAplica.Controls.Add(this.lblCurso);
            this.tabCursoAqueAplica.Controls.Add(this.lblJornada);
            this.tabCursoAqueAplica.Controls.Add(this.lblAnioLectivo);
            this.tabCursoAqueAplica.Name = "tabCursoAqueAplica";
            this.tabCursoAqueAplica.Size = new System.Drawing.Size(673, 394);
            this.tabCursoAqueAplica.Text = "Curso al que Aplica";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Location = new System.Drawing.Point(351, 146);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSeccion.Properties.DataSource = this.acaSeccionInfoBindingSource;
            this.cmbSeccion.Properties.DisplayMember = "DescripcionSeccion";
            this.cmbSeccion.Properties.ValueMember = "IdSeccion";
            this.cmbSeccion.Properties.View = this.gridView4;
            this.cmbSeccion.Size = new System.Drawing.Size(289, 20);
            this.cmbSeccion.TabIndex = 9;
            this.cmbSeccion.EditValueChanged += new System.EventHandler(this.cmbSeccion_EditValueChanged);
            // 
            // acaSeccionInfoBindingSource
            // 
            this.acaSeccionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Seccion_Info);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSeccion,
            this.colDescripcionSeccion,
            this.colEstado4});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSeccion
            // 
            this.colIdSeccion.Caption = "Id Sección";
            this.colIdSeccion.FieldName = "IdSeccion";
            this.colIdSeccion.Name = "colIdSeccion";
            this.colIdSeccion.OptionsColumn.AllowEdit = false;
            this.colIdSeccion.Visible = true;
            this.colIdSeccion.VisibleIndex = 0;
            this.colIdSeccion.Width = 176;
            // 
            // colDescripcionSeccion
            // 
            this.colDescripcionSeccion.Caption = "Descripción";
            this.colDescripcionSeccion.FieldName = "DescripcionSeccion";
            this.colDescripcionSeccion.Name = "colDescripcionSeccion";
            this.colDescripcionSeccion.OptionsColumn.AllowEdit = false;
            this.colDescripcionSeccion.Visible = true;
            this.colDescripcionSeccion.VisibleIndex = 1;
            this.colDescripcionSeccion.Width = 853;
            // 
            // colEstado4
            // 
            this.colEstado4.Caption = "Estado";
            this.colEstado4.FieldName = "Estado";
            this.colEstado4.Name = "colEstado4";
            this.colEstado4.OptionsColumn.AllowEdit = false;
            this.colEstado4.Visible = true;
            this.colEstado4.VisibleIndex = 2;
            this.colEstado4.Width = 124;
            // 
            // cmbSede
            // 
            this.cmbSede.Location = new System.Drawing.Point(351, 47);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSede.Properties.DataSource = this.acaSedeInfoBindingSource;
            this.cmbSede.Properties.DisplayMember = "DescripcionSede";
            this.cmbSede.Properties.ValueMember = "IdSede";
            this.cmbSede.Properties.View = this.gridView3;
            this.cmbSede.Size = new System.Drawing.Size(289, 20);
            this.cmbSede.TabIndex = 8;
            this.cmbSede.EditValueChanged += new System.EventHandler(this.cmbSede_EditValueChanged);
            // 
            // acaSedeInfoBindingSource
            // 
            this.acaSedeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Sede_Info);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSede,
            this.colDescripcionSede,
            this.colEstado3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescripcionSede, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdSede
            // 
            this.colIdSede.Caption = "Id Sede";
            this.colIdSede.FieldName = "IdSede";
            this.colIdSede.Name = "colIdSede";
            this.colIdSede.OptionsColumn.AllowEdit = false;
            this.colIdSede.Visible = true;
            this.colIdSede.VisibleIndex = 0;
            this.colIdSede.Width = 108;
            // 
            // colDescripcionSede
            // 
            this.colDescripcionSede.Caption = "Descripción";
            this.colDescripcionSede.FieldName = "DescripcionSede";
            this.colDescripcionSede.Name = "colDescripcionSede";
            this.colDescripcionSede.OptionsColumn.AllowEdit = false;
            this.colDescripcionSede.Visible = true;
            this.colDescripcionSede.VisibleIndex = 1;
            this.colDescripcionSede.Width = 893;
            // 
            // colEstado3
            // 
            this.colEstado3.Caption = "Estado";
            this.colEstado3.FieldName = "Estado";
            this.colEstado3.Name = "colEstado3";
            this.colEstado3.OptionsColumn.AllowEdit = false;
            this.colEstado3.Visible = true;
            this.colEstado3.VisibleIndex = 2;
            this.colEstado3.Width = 152;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Location = new System.Drawing.Point(33, 242);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCurso.Properties.DataSource = this.acaCursoInfoBindingSource;
            this.cmbCurso.Properties.DisplayMember = "DescripcionCurso";
            this.cmbCurso.Properties.ValueMember = "IdCurso";
            this.cmbCurso.Properties.View = this.gridView2;
            this.cmbCurso.Size = new System.Drawing.Size(289, 20);
            this.cmbCurso.TabIndex = 7;
            // 
            // acaCursoInfoBindingSource
            // 
            this.acaCursoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Curso_Info);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCurso,
            this.colDescripcionCurso,
            this.colEstado});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCurso
            // 
            this.colIdCurso.FieldName = "IdCurso";
            this.colIdCurso.Name = "colIdCurso";
            this.colIdCurso.Visible = true;
            this.colIdCurso.VisibleIndex = 0;
            this.colIdCurso.Width = 205;
            // 
            // colDescripcionCurso
            // 
            this.colDescripcionCurso.FieldName = "DescripcionCurso";
            this.colDescripcionCurso.Name = "colDescripcionCurso";
            this.colDescripcionCurso.OptionsColumn.AllowEdit = false;
            this.colDescripcionCurso.Visible = true;
            this.colDescripcionCurso.VisibleIndex = 1;
            this.colDescripcionCurso.Width = 821;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 127;
            // 
            // cmbJornada
            // 
            this.cmbJornada.Location = new System.Drawing.Point(33, 146);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbJornada.Properties.DataSource = this.acaJornadaInfoBindingSource;
            this.cmbJornada.Properties.DisplayMember = "DescripcionJornada";
            this.cmbJornada.Properties.ValueMember = "IdJornada";
            this.cmbJornada.Properties.View = this.gridView1;
            this.cmbJornada.Size = new System.Drawing.Size(289, 20);
            this.cmbJornada.TabIndex = 6;
            this.cmbJornada.EditValueChanged += new System.EventHandler(this.cmbJornada_EditValueChanged);
            // 
            // acaJornadaInfoBindingSource
            // 
            this.acaJornadaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Jornada_Info);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdJornada,
            this.colDescripcionJornada,
            this.colEstado1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdJornada
            // 
            this.colIdJornada.FieldName = "IdJornada";
            this.colIdJornada.Name = "colIdJornada";
            this.colIdJornada.OptionsColumn.AllowEdit = false;
            this.colIdJornada.Visible = true;
            this.colIdJornada.VisibleIndex = 0;
            this.colIdJornada.Width = 240;
            // 
            // colDescripcionJornada
            // 
            this.colDescripcionJornada.FieldName = "DescripcionJornada";
            this.colDescripcionJornada.Name = "colDescripcionJornada";
            this.colDescripcionJornada.OptionsColumn.AllowEdit = false;
            this.colDescripcionJornada.Visible = true;
            this.colDescripcionJornada.VisibleIndex = 1;
            this.colDescripcionJornada.Width = 783;
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.OptionsColumn.AllowEdit = false;
            this.colEstado1.Visible = true;
            this.colEstado1.VisibleIndex = 2;
            this.colEstado1.Width = 130;
            // 
            // cmbAnioLectivo
            // 
            this.cmbAnioLectivo.Location = new System.Drawing.Point(33, 47);
            this.cmbAnioLectivo.Name = "cmbAnioLectivo";
            this.cmbAnioLectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnioLectivo.Properties.DataSource = this.acaAnioLectivoInfoBindingSource;
            this.cmbAnioLectivo.Properties.DisplayMember = "Descripcion";
            this.cmbAnioLectivo.Properties.ValueMember = "IdAnioLectivo";
            this.cmbAnioLectivo.Properties.View = this.searchLookUpEdit1View;
            this.cmbAnioLectivo.Size = new System.Drawing.Size(289, 20);
            this.cmbAnioLectivo.TabIndex = 5;
            // 
            // acaAnioLectivoInfoBindingSource
            // 
            this.acaAnioLectivoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Anio_Lectivo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPeriodoLectivo,
            this.colDescripcion,
            this.colEstado2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPeriodoLectivo
            // 
            this.colIdPeriodoLectivo.FieldName = "IdAnioLectivo";
            this.colIdPeriodoLectivo.Name = "colIdPeriodoLectivo";
            this.colIdPeriodoLectivo.OptionsColumn.AllowEdit = false;
            this.colIdPeriodoLectivo.Visible = true;
            this.colIdPeriodoLectivo.VisibleIndex = 0;
            this.colIdPeriodoLectivo.Width = 187;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 802;
            // 
            // colEstado2
            // 
            this.colEstado2.FieldName = "Estado";
            this.colEstado2.Name = "colEstado2";
            this.colEstado2.OptionsColumn.AllowEdit = false;
            this.colEstado2.Visible = true;
            this.colEstado2.VisibleIndex = 2;
            this.colEstado2.Width = 164;
            // 
            // lblSeccion
            // 
            this.lblSeccion.Location = new System.Drawing.Point(351, 127);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(40, 13);
            this.lblSeccion.TabIndex = 4;
            this.lblSeccion.Text = "Sección:";
            // 
            // lblSede
            // 
            this.lblSede.Location = new System.Drawing.Point(351, 28);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(28, 13);
            this.lblSede.TabIndex = 3;
            this.lblSede.Text = "Sede:";
            // 
            // lblCurso
            // 
            this.lblCurso.Location = new System.Drawing.Point(33, 223);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(32, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // lblJornada
            // 
            this.lblJornada.Location = new System.Drawing.Point(33, 127);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(43, 13);
            this.lblJornada.TabIndex = 1;
            this.lblJornada.Text = "Jornada:";
            // 
            // lblAnioLectivo
            // 
            this.lblAnioLectivo.Location = new System.Drawing.Point(33, 28);
            this.lblAnioLectivo.Name = "lblAnioLectivo";
            this.lblAnioLectivo.Size = new System.Drawing.Size(60, 13);
            this.lblAnioLectivo.TabIndex = 0;
            this.lblAnioLectivo.Text = "Año Lectivo:";
            // 
            // tabInformacionAdicional
            // 
            this.tabInformacionAdicional.Controls.Add(this.rgHijoProfesorNuestrocolegio);
            this.tabInformacionAdicional.Controls.Add(this.lblHijoProfesorNuestroColegio);
            this.tabInformacionAdicional.Controls.Add(this.txtEnQueGrado);
            this.tabInformacionAdicional.Controls.Add(this.lblEnQueGrado);
            this.tabInformacionAdicional.Controls.Add(this.rgTieneHermanosEnNuestroColegio);
            this.tabInformacionAdicional.Controls.Add(this.lblTieneHermanosNuestroColegio);
            this.tabInformacionAdicional.Controls.Add(this.rgTieneHermanosEnOtroColegio);
            this.tabInformacionAdicional.Controls.Add(this.lblTieneHermanosEnOtroColegio);
            this.tabInformacionAdicional.Controls.Add(this.txtCualEstablecimientoEducativoAsiste);
            this.tabInformacionAdicional.Controls.Add(this.labelControl3);
            this.tabInformacionAdicional.Controls.Add(this.rgAsisteEstablecimientoEducativo);
            this.tabInformacionAdicional.Controls.Add(this.lblAsisteAlgunEstablecimientoEducativo);
            this.tabInformacionAdicional.Controls.Add(this.labelControl2);
            this.tabInformacionAdicional.Controls.Add(this.rgHijoUnico);
            this.tabInformacionAdicional.Controls.Add(this.chkPoseeDiscapacidad);
            this.tabInformacionAdicional.Controls.Add(this.txtTelefonoEmergencia);
            this.tabInformacionAdicional.Controls.Add(this.cmbIdiomaNativo);
            this.tabInformacionAdicional.Controls.Add(this.cmbTipoSangre);
            this.tabInformacionAdicional.Controls.Add(this.cmbReligion);
            this.tabInformacionAdicional.Controls.Add(this.lblTelefonoEmergencia);
            this.tabInformacionAdicional.Controls.Add(this.labelControl1);
            this.tabInformacionAdicional.Controls.Add(this.lblTipoSangre);
            this.tabInformacionAdicional.Controls.Add(this.lblReligion);
            this.tabInformacionAdicional.Controls.Add(this.lblConQuienVive);
            this.tabInformacionAdicional.Controls.Add(this.cmbConQuienVive);
            this.tabInformacionAdicional.Name = "tabInformacionAdicional";
            this.tabInformacionAdicional.Size = new System.Drawing.Size(673, 394);
            this.tabInformacionAdicional.Text = "Información Adicional";
            // 
            // rgHijoProfesorNuestrocolegio
            // 
            this.rgHijoProfesorNuestrocolegio.EditValue = "0";
            this.rgHijoProfesorNuestrocolegio.Location = new System.Drawing.Point(24, 363);
            this.rgHijoProfesorNuestrocolegio.Name = "rgHijoProfesorNuestrocolegio";
            this.rgHijoProfesorNuestrocolegio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "No")});
            this.rgHijoProfesorNuestrocolegio.Size = new System.Drawing.Size(108, 21);
            this.rgHijoProfesorNuestrocolegio.TabIndex = 30;
            // 
            // lblHijoProfesorNuestroColegio
            // 
            this.lblHijoProfesorNuestroColegio.Location = new System.Drawing.Point(26, 344);
            this.lblHijoProfesorNuestroColegio.Name = "lblHijoProfesorNuestroColegio";
            this.lblHijoProfesorNuestroColegio.Size = new System.Drawing.Size(178, 13);
            this.lblHijoProfesorNuestroColegio.TabIndex = 29;
            this.lblHijoProfesorNuestroColegio.Text = "¿Hijo de Profesor de nuestro colegio?";
            // 
            // txtEnQueGrado
            // 
            this.txtEnQueGrado.Location = new System.Drawing.Point(352, 322);
            this.txtEnQueGrado.Name = "txtEnQueGrado";
            this.txtEnQueGrado.Size = new System.Drawing.Size(288, 20);
            this.txtEnQueGrado.TabIndex = 28;
            // 
            // lblEnQueGrado
            // 
            this.lblEnQueGrado.Location = new System.Drawing.Point(352, 303);
            this.lblEnQueGrado.Name = "lblEnQueGrado";
            this.lblEnQueGrado.Size = new System.Drawing.Size(74, 13);
            this.lblEnQueGrado.TabIndex = 27;
            this.lblEnQueGrado.Text = "¿En qué grado?";
            // 
            // rgTieneHermanosEnNuestroColegio
            // 
            this.rgTieneHermanosEnNuestroColegio.EditValue = "0";
            this.rgTieneHermanosEnNuestroColegio.Location = new System.Drawing.Point(217, 304);
            this.rgTieneHermanosEnNuestroColegio.Name = "rgTieneHermanosEnNuestroColegio";
            this.rgTieneHermanosEnNuestroColegio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "No")});
            this.rgTieneHermanosEnNuestroColegio.Size = new System.Drawing.Size(108, 21);
            this.rgTieneHermanosEnNuestroColegio.TabIndex = 26;
            // 
            // lblTieneHermanosNuestroColegio
            // 
            this.lblTieneHermanosNuestroColegio.Location = new System.Drawing.Point(217, 284);
            this.lblTieneHermanosNuestroColegio.Name = "lblTieneHermanosNuestroColegio";
            this.lblTieneHermanosNuestroColegio.Size = new System.Drawing.Size(177, 13);
            this.lblTieneHermanosNuestroColegio.TabIndex = 25;
            this.lblTieneHermanosNuestroColegio.Text = "¿Tiene hermanos en nuestro colegio?";
            // 
            // rgTieneHermanosEnOtroColegio
            // 
            this.rgTieneHermanosEnOtroColegio.EditValue = "0";
            this.rgTieneHermanosEnOtroColegio.Location = new System.Drawing.Point(26, 303);
            this.rgTieneHermanosEnOtroColegio.Name = "rgTieneHermanosEnOtroColegio";
            this.rgTieneHermanosEnOtroColegio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "No")});
            this.rgTieneHermanosEnOtroColegio.Size = new System.Drawing.Size(108, 22);
            this.rgTieneHermanosEnOtroColegio.TabIndex = 24;
            // 
            // lblTieneHermanosEnOtroColegio
            // 
            this.lblTieneHermanosEnOtroColegio.Location = new System.Drawing.Point(26, 284);
            this.lblTieneHermanosEnOtroColegio.Name = "lblTieneHermanosEnOtroColegio";
            this.lblTieneHermanosEnOtroColegio.Size = new System.Drawing.Size(160, 13);
            this.lblTieneHermanosEnOtroColegio.TabIndex = 23;
            this.lblTieneHermanosEnOtroColegio.Text = "¿Tiene hermanos en otro colegio?";
            // 
            // txtCualEstablecimientoEducativoAsiste
            // 
            this.txtCualEstablecimientoEducativoAsiste.Location = new System.Drawing.Point(217, 258);
            this.txtCualEstablecimientoEducativoAsiste.Name = "txtCualEstablecimientoEducativoAsiste";
            this.txtCualEstablecimientoEducativoAsiste.Size = new System.Drawing.Size(423, 20);
            this.txtCualEstablecimientoEducativoAsiste.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(217, 239);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "¿ A cuál?";
            // 
            // rgAsisteEstablecimientoEducativo
            // 
            this.rgAsisteEstablecimientoEducativo.EditValue = "0";
            this.rgAsisteEstablecimientoEducativo.Location = new System.Drawing.Point(26, 239);
            this.rgAsisteEstablecimientoEducativo.Name = "rgAsisteEstablecimientoEducativo";
            this.rgAsisteEstablecimientoEducativo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "No")});
            this.rgAsisteEstablecimientoEducativo.Size = new System.Drawing.Size(108, 20);
            this.rgAsisteEstablecimientoEducativo.TabIndex = 20;
            // 
            // lblAsisteAlgunEstablecimientoEducativo
            // 
            this.lblAsisteAlgunEstablecimientoEducativo.Location = new System.Drawing.Point(26, 220);
            this.lblAsisteAlgunEstablecimientoEducativo.Name = "lblAsisteAlgunEstablecimientoEducativo";
            this.lblAsisteAlgunEstablecimientoEducativo.Size = new System.Drawing.Size(305, 13);
            this.lblAsisteAlgunEstablecimientoEducativo.TabIndex = 19;
            this.lblAsisteAlgunEstablecimientoEducativo.Text = "¿Actualmente su hijo(a) asiste algún establecimiento educativo?";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 187);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "¿Hijo Único?";
            // 
            // rgHijoUnico
            // 
            this.rgHijoUnico.EditValue = "0";
            this.rgHijoUnico.Location = new System.Drawing.Point(89, 182);
            this.rgHijoUnico.Name = "rgHijoUnico";
            this.rgHijoUnico.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Si"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "No")});
            this.rgHijoUnico.Size = new System.Drawing.Size(102, 20);
            this.rgHijoUnico.TabIndex = 15;
            // 
            // chkPoseeDiscapacidad
            // 
            this.chkPoseeDiscapacidad.Location = new System.Drawing.Point(398, 155);
            this.chkPoseeDiscapacidad.Name = "chkPoseeDiscapacidad";
            this.chkPoseeDiscapacidad.Properties.Caption = "¿Posee alguna discapacidad?";
            this.chkPoseeDiscapacidad.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.chkPoseeDiscapacidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPoseeDiscapacidad.Size = new System.Drawing.Size(172, 19);
            this.chkPoseeDiscapacidad.TabIndex = 14;
            // 
            // txtTelefonoEmergencia
            // 
            this.txtTelefonoEmergencia.Location = new System.Drawing.Point(400, 93);
            this.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            this.txtTelefonoEmergencia.Size = new System.Drawing.Size(236, 20);
            this.txtTelefonoEmergencia.TabIndex = 13;
            // 
            // cmbIdiomaNativo
            // 
            this.cmbIdiomaNativo.Location = new System.Drawing.Point(400, 44);
            this.cmbIdiomaNativo.Name = "cmbIdiomaNativo";
            this.cmbIdiomaNativo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIdiomaNativo.Properties.DataSource = this.acaCatalogoInfoBindingSource3;
            this.cmbIdiomaNativo.Properties.DisplayMember = "Descripcion";
            this.cmbIdiomaNativo.Properties.ValueMember = "IdCatalogo";
            this.cmbIdiomaNativo.Properties.View = this.gridView8;
            this.cmbIdiomaNativo.Size = new System.Drawing.Size(221, 20);
            this.cmbIdiomaNativo.TabIndex = 12;
            // 
            // acaCatalogoInfoBindingSource3
            // 
            this.acaCatalogoInfoBindingSource3.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo3,
            this.colDescripcion4,
            this.colEstado8});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            this.gridView8.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEstado8, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdCatalogo3
            // 
            this.colIdCatalogo3.Caption = "Id Catalogo";
            this.colIdCatalogo3.FieldName = "IdCatalogo";
            this.colIdCatalogo3.Name = "colIdCatalogo3";
            this.colIdCatalogo3.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo3.Visible = true;
            this.colIdCatalogo3.VisibleIndex = 0;
            this.colIdCatalogo3.Width = 192;
            // 
            // colDescripcion4
            // 
            this.colDescripcion4.Caption = "Descripción";
            this.colDescripcion4.FieldName = "Descripcion";
            this.colDescripcion4.Name = "colDescripcion4";
            this.colDescripcion4.OptionsColumn.AllowEdit = false;
            this.colDescripcion4.Visible = true;
            this.colDescripcion4.VisibleIndex = 1;
            this.colDescripcion4.Width = 781;
            // 
            // colEstado8
            // 
            this.colEstado8.Caption = "Estado";
            this.colEstado8.FieldName = "Estado";
            this.colEstado8.Name = "colEstado8";
            this.colEstado8.OptionsColumn.AllowEdit = false;
            this.colEstado8.Visible = true;
            this.colEstado8.VisibleIndex = 2;
            this.colEstado8.Width = 180;
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.Location = new System.Drawing.Point(26, 155);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoSangre.Properties.DataSource = this.acaCatalogoInfoBindingSource2;
            this.cmbTipoSangre.Properties.DisplayMember = "Descripcion";
            this.cmbTipoSangre.Properties.ValueMember = "IdCatalogo";
            this.cmbTipoSangre.Properties.View = this.gridView7;
            this.cmbTipoSangre.Size = new System.Drawing.Size(241, 20);
            this.cmbTipoSangre.TabIndex = 11;
            // 
            // acaCatalogoInfoBindingSource2
            // 
            this.acaCatalogoInfoBindingSource2.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo2,
            this.colDescripcion3,
            this.colEstado7});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo2
            // 
            this.colIdCatalogo2.Caption = "Id Catalogo";
            this.colIdCatalogo2.FieldName = "IdCatalogo";
            this.colIdCatalogo2.Name = "colIdCatalogo2";
            this.colIdCatalogo2.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo2.OptionsFilter.AllowAutoFilter = false;
            this.colIdCatalogo2.Visible = true;
            this.colIdCatalogo2.VisibleIndex = 0;
            this.colIdCatalogo2.Width = 204;
            // 
            // colDescripcion3
            // 
            this.colDescripcion3.Caption = "Descripción";
            this.colDescripcion3.FieldName = "Descripcion";
            this.colDescripcion3.Name = "colDescripcion3";
            this.colDescripcion3.OptionsColumn.AllowEdit = false;
            this.colDescripcion3.OptionsFilter.AllowAutoFilter = false;
            this.colDescripcion3.Visible = true;
            this.colDescripcion3.VisibleIndex = 1;
            this.colDescripcion3.Width = 746;
            // 
            // colEstado7
            // 
            this.colEstado7.FieldName = "Estado";
            this.colEstado7.Name = "colEstado7";
            this.colEstado7.OptionsColumn.AllowEdit = false;
            this.colEstado7.OptionsFilter.AllowAutoFilter = false;
            this.colEstado7.Visible = true;
            this.colEstado7.VisibleIndex = 2;
            this.colEstado7.Width = 203;
            // 
            // cmbReligion
            // 
            this.cmbReligion.Location = new System.Drawing.Point(24, 93);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReligion.Properties.DataSource = this.acaCatalogoInfoBindingSource1;
            this.cmbReligion.Properties.DisplayMember = "Descripcion";
            this.cmbReligion.Properties.ValueMember = "IdCatalogo";
            this.cmbReligion.Properties.View = this.gridView6;
            this.cmbReligion.Size = new System.Drawing.Size(244, 20);
            this.cmbReligion.TabIndex = 10;
            // 
            // acaCatalogoInfoBindingSource1
            // 
            this.acaCatalogoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo1,
            this.colDescripcion2,
            this.colEstado6});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo1
            // 
            this.colIdCatalogo1.Caption = "Id Catalogo";
            this.colIdCatalogo1.FieldName = "IdCatalogo";
            this.colIdCatalogo1.Name = "colIdCatalogo1";
            this.colIdCatalogo1.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo1.Visible = true;
            this.colIdCatalogo1.VisibleIndex = 0;
            this.colIdCatalogo1.Width = 147;
            // 
            // colDescripcion2
            // 
            this.colDescripcion2.Caption = "Descripción";
            this.colDescripcion2.FieldName = "Descripcion";
            this.colDescripcion2.Name = "colDescripcion2";
            this.colDescripcion2.OptionsColumn.AllowEdit = false;
            this.colDescripcion2.Visible = true;
            this.colDescripcion2.VisibleIndex = 1;
            this.colDescripcion2.Width = 750;
            // 
            // colEstado6
            // 
            this.colEstado6.FieldName = "Estado";
            this.colEstado6.Name = "colEstado6";
            this.colEstado6.OptionsColumn.AllowEdit = false;
            this.colEstado6.Visible = true;
            this.colEstado6.VisibleIndex = 2;
            this.colEstado6.Width = 256;
            // 
            // lblTelefonoEmergencia
            // 
            this.lblTelefonoEmergencia.Location = new System.Drawing.Point(400, 74);
            this.lblTelefonoEmergencia.Name = "lblTelefonoEmergencia";
            this.lblTelefonoEmergencia.Size = new System.Drawing.Size(119, 13);
            this.lblTelefonoEmergencia.TabIndex = 9;
            this.lblTelefonoEmergencia.Text = "Teléfono de Emergencia:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(407, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Idioma Nativo:";
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.Location = new System.Drawing.Point(24, 135);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(61, 13);
            this.lblTipoSangre.TabIndex = 7;
            this.lblTipoSangre.Text = "Tipo Sangre:";
            // 
            // lblReligion
            // 
            this.lblReligion.Location = new System.Drawing.Point(24, 74);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(41, 13);
            this.lblReligion.TabIndex = 6;
            this.lblReligion.Text = "Religión:";
            // 
            // lblConQuienVive
            // 
            this.lblConQuienVive.Location = new System.Drawing.Point(24, 20);
            this.lblConQuienVive.Name = "lblConQuienVive";
            this.lblConQuienVive.Size = new System.Drawing.Size(132, 13);
            this.lblConQuienVive.TabIndex = 5;
            this.lblConQuienVive.Text = "¿Con Quién Vive el Alumno?";
            // 
            // cmbConQuienVive
            // 
            this.cmbConQuienVive.Location = new System.Drawing.Point(24, 39);
            this.cmbConQuienVive.Name = "cmbConQuienVive";
            this.cmbConQuienVive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConQuienVive.Properties.DataSource = this.acaCatalogoInfoBindingSource;
            this.cmbConQuienVive.Properties.DisplayMember = "Descripcion";
            this.cmbConQuienVive.Properties.ValueMember = "IdCatalogo";
            this.cmbConQuienVive.Properties.View = this.gridView5;
            this.cmbConQuienVive.Size = new System.Drawing.Size(244, 20);
            this.cmbConQuienVive.TabIndex = 0;
            // 
            // acaCatalogoInfoBindingSource
            // 
            this.acaCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colIdCatalogo,
            this.colEstado5});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.OptionsColumn.AllowEdit = false;
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 716;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 0;
            this.colIdCatalogo.Width = 232;
            // 
            // colEstado5
            // 
            this.colEstado5.FieldName = "Estado";
            this.colEstado5.Name = "colEstado5";
            this.colEstado5.OptionsColumn.AllowEdit = false;
            this.colEstado5.Visible = true;
            this.colEstado5.VisibleIndex = 2;
            this.colEstado5.Width = 205;
            // 
            // FrmAcaAdmision_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 606);
            this.Controls.Add(this.xtraTabAdmision);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Form);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaAdmision_Mant";
            this.Text = "FrmAcaAdmision_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaAdmision_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaAdmision_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoAdmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAdmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAdmision)).EndInit();
            this.xtraTabAdmision.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).EndInit();
            this.tabCursoAqueAplica.ResumeLayout(false);
            this.tabCursoAqueAplica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSeccionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSede.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaSedeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCursoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJornada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaJornadaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnioLectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAnioLectivoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.tabInformacionAdicional.ResumeLayout(false);
            this.tabInformacionAdicional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgHijoProfesorNuestrocolegio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnQueGrado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTieneHermanosEnNuestroColegio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTieneHermanosEnOtroColegio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCualEstablecimientoEducativoAsiste.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgAsisteEstablecimientoEducativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgHijoUnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPoseeDiscapacidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoEmergencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdiomaNativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoSangre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReligion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConQuienVive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Form;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controles.UCGe_Docu_Personales ucGe_Docu_PerIdentificacion;
        private DevExpress.XtraEditors.TextEdit txtCedRuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.LabelControl lblNombres;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl lblApellidos;
        private DevExpress.XtraEditors.LabelControl lblIdPersona;
        private DevExpress.XtraEditors.LabelControl lblIdPersonaTxt;
        private DevExpress.XtraTab.XtraTabControl xtraTabAdmision;
        private DevExpress.XtraTab.XtraTabPage tabCursoAqueAplica;
        private DevExpress.XtraTab.XtraTabPage tabDatosPersonales;
        private DevExpress.XtraTab.XtraTabPage tabInformacionAdicional;
        private DevExpress.XtraEditors.DateEdit dtFechaNacimiento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.RadioGroup rgSexo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNroCelular;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl lblDireccion;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private DevExpress.XtraEditors.LabelControl lblLugar;
        private DevExpress.XtraEditors.TextEdit txtBarrio;
        private DevExpress.XtraEditors.LabelControl lblBarrio;
        private DevExpress.XtraEditors.LabelControl lblAnioLectivo;
        private DevExpress.XtraEditors.LabelControl lblSeccion;
        private DevExpress.XtraEditors.LabelControl lblSede;
        private DevExpress.XtraEditors.LabelControl lblCurso;
        private DevExpress.XtraEditors.LabelControl lblJornada;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbAnioLectivo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbJornada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSede;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSeccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl lblConQuienVive;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbConQuienVive;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.LabelControl lblReligion;
        private DevExpress.XtraEditors.LabelControl lblTelefonoEmergencia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTipoSangre;
        private DevExpress.XtraEditors.TextEdit txtTelefonoEmergencia;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbIdiomaNativo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTipoSangre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbReligion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.CheckEdit chkPoseeDiscapacidad;
        private DevExpress.XtraEditors.RadioGroup rgHijoUnico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup rgAsisteEstablecimientoEducativo;
        private DevExpress.XtraEditors.TextEdit txtCualEstablecimientoEducativoAsiste;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblAsisteAlgunEstablecimientoEducativo;
        private DevExpress.XtraEditors.LabelControl lblTieneHermanosEnOtroColegio;
        private DevExpress.XtraEditors.RadioGroup rgTieneHermanosEnOtroColegio;
        private DevExpress.XtraEditors.LabelControl lblTieneHermanosNuestroColegio;
        private DevExpress.XtraEditors.RadioGroup rgTieneHermanosEnNuestroColegio;
        private DevExpress.XtraEditors.LabelControl lblEnQueGrado;
        private DevExpress.XtraEditors.TextEdit txtEnQueGrado;
        private DevExpress.XtraEditors.LabelControl lblHijoProfesorNuestroColegio;
        private DevExpress.XtraEditors.RadioGroup rgHijoProfesorNuestrocolegio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodoLectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.BindingSource acaCursoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCurso;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionCurso;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.BindingSource acaJornadaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado2;
        private System.Windows.Forms.BindingSource acaSeccionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSeccion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado4;
        private System.Windows.Forms.BindingSource acaSedeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSede;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionSede;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado3;
        private DevExpress.XtraEditors.TextEdit txtIdAdmision;
        private DevExpress.XtraEditors.LabelControl lblIdAdmision;
        private DevExpress.XtraEditors.TextEdit txtCodigoAdmision;
        private DevExpress.XtraEditors.LabelControl lblCodigoAdmision;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado5;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado6;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion3;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado7;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion4;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado8;
        private DevExpress.XtraEditors.LabelControl lblIdAspiranteTxt;
        private DevExpress.XtraEditors.LabelControl lblIdAspirante;
        private System.Windows.Forms.BindingSource acaAnioLectivoInfoBindingSource;
    }
}
namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaEstudiante_Mant
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.xtraTabEstudiante = new DevExpress.XtraTab.XtraTabControl();
            this.TabFichaEst = new DevExpress.XtraTab.XtraTabPage();
            this.btn_imgGrande = new DevExpress.XtraEditors.SimpleButton();
            this.grImgGrande = new System.Windows.Forms.GroupBox();
            this.pibx_imagenPequeña = new System.Windows.Forms.PictureBox();
            this.cmbNacionalidad3 = new System.Windows.Forms.ComboBox();
            this.tbpaisInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNacionalidad2 = new System.Windows.Forms.ComboBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.dtFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNroCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtBarrio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.rgSexo = new DevExpress.XtraEditors.RadioGroup();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.TabFichaMedica = new DevExpress.XtraTab.XtraTabPage();
            this.cmb_GrupoSanguineo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblMedicamentosContraIndicados = new DevExpress.XtraEditors.LabelControl();
            this.txtSeguroMedico = new DevExpress.XtraEditors.TextEdit();
            this.lblSeguroMedico = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupoSanguineo = new DevExpress.XtraEditors.LabelControl();
            this.gbxAlergia = new DevExpress.XtraEditors.GroupControl();
            this.gcAlergia = new DevExpress.XtraGrid.GridControl();
            this.acaestudiantexAlergiaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAlergia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAlergiaCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAlergia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsta_en_Base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblInfoMed = new DevExpress.XtraEditors.LabelControl();
            this.meMedicamentosContraindicados = new DevExpress.XtraEditors.MemoEdit();
            this.meOtrasIndicaciones = new DevExpress.XtraEditors.MemoEdit();
            this.TabPadre = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudiantePadre = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.TabMadre = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteMadre = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.TabRepEco = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteRepEcono = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.TabPageRepLegal = new DevExpress.XtraTab.XtraTabPage();
            this.ucAca_Familiar_x_EstudianteRepLegal = new Core.Erp.Winform.Controles.UCAca_Familiar_x_Estudiante();
            this.lblIdPersona_ = new DevExpress.XtraEditors.LabelControl();
            this.txtCedRuc = new DevExpress.XtraEditors.TextEdit();
            this.txtIdEstudiante = new DevExpress.XtraEditors.TextEdit();
            this.lblIdEstudiante = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grbEstudiante = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo2 = new DevExpress.XtraEditors.TextEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_Docu_PerIdentificacion = new Core.Erp.Winform.Controles.UCGe_Docu_Personales();
            this.lblIdPersona = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEstudiante)).BeginInit();
            this.xtraTabEstudiante.SuspendLayout();
            this.TabFichaEst.SuspendLayout();
            this.grImgGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibx_imagenPequeña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpaisInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            this.TabFichaMedica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_GrupoSanguineo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguroMedico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAlergia)).BeginInit();
            this.gbxAlergia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAlergia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaestudiantexAlergiaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlergia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMedicamentosContraindicados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meOtrasIndicaciones.Properties)).BeginInit();
            this.TabPadre.SuspendLayout();
            this.TabMadre.SuspendLayout();
            this.TabRepEco.SuspendLayout();
            this.TabPageRepLegal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbEstudiante)).BeginInit();
            this.grbEstudiante.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo2.Properties)).BeginInit();
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(836, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 651);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(836, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // xtraTabEstudiante
            // 
            this.xtraTabEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabEstudiante.Location = new System.Drawing.Point(2, 139);
            this.xtraTabEstudiante.Name = "xtraTabEstudiante";
            this.xtraTabEstudiante.SelectedTabPage = this.TabFichaEst;
            this.xtraTabEstudiante.Size = new System.Drawing.Size(832, 481);
            this.xtraTabEstudiante.TabIndex = 2;
            this.xtraTabEstudiante.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabFichaEst,
            this.TabFichaMedica,
            this.TabPadre,
            this.TabMadre,
            this.TabRepEco,
            this.TabPageRepLegal});
            // 
            // TabFichaEst
            // 
            this.TabFichaEst.Controls.Add(this.btn_imgGrande);
            this.TabFichaEst.Controls.Add(this.grImgGrande);
            this.TabFichaEst.Controls.Add(this.cmbNacionalidad3);
            this.TabFichaEst.Controls.Add(this.labelControl16);
            this.TabFichaEst.Controls.Add(this.cmbNacionalidad2);
            this.TabFichaEst.Controls.Add(this.labelControl14);
            this.TabFichaEst.Controls.Add(this.chkActivo);
            this.TabFichaEst.Controls.Add(this.cmbNacionalidad);
            this.TabFichaEst.Controls.Add(this.dtFechaNacimiento);
            this.TabFichaEst.Controls.Add(this.txtEmail);
            this.TabFichaEst.Controls.Add(this.txtNroCelular);
            this.TabFichaEst.Controls.Add(this.txtTelefono);
            this.TabFichaEst.Controls.Add(this.txtBarrio);
            this.TabFichaEst.Controls.Add(this.labelControl13);
            this.TabFichaEst.Controls.Add(this.labelControl12);
            this.TabFichaEst.Controls.Add(this.labelControl11);
            this.TabFichaEst.Controls.Add(this.labelControl10);
            this.TabFichaEst.Controls.Add(this.rgSexo);
            this.TabFichaEst.Controls.Add(this.txtLugar);
            this.TabFichaEst.Controls.Add(this.labelControl9);
            this.TabFichaEst.Controls.Add(this.labelControl8);
            this.TabFichaEst.Controls.Add(this.labelControl7);
            this.TabFichaEst.Controls.Add(this.labelControl6);
            this.TabFichaEst.Controls.Add(this.labelControl5);
            this.TabFichaEst.Controls.Add(this.txtDireccion);
            this.TabFichaEst.Name = "TabFichaEst";
            this.TabFichaEst.Size = new System.Drawing.Size(826, 453);
            this.TabFichaEst.Text = "Datos Personales";
            // 
            // btn_imgGrande
            // 
            this.btn_imgGrande.Location = new System.Drawing.Point(638, 115);
            this.btn_imgGrande.Name = "btn_imgGrande";
            this.btn_imgGrande.Size = new System.Drawing.Size(40, 22);
            this.btn_imgGrande.TabIndex = 63;
            this.btn_imgGrande.Text = "......";
            // 
            // grImgGrande
            // 
            this.grImgGrande.Controls.Add(this.pibx_imagenPequeña);
            this.grImgGrande.Location = new System.Drawing.Point(405, 3);
            this.grImgGrande.Name = "grImgGrande";
            this.grImgGrande.Size = new System.Drawing.Size(230, 134);
            this.grImgGrande.TabIndex = 62;
            this.grImgGrande.TabStop = false;
            this.grImgGrande.Text = "Imagen ";
            // 
            // pibx_imagenPequeña
            // 
            this.pibx_imagenPequeña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pibx_imagenPequeña.Location = new System.Drawing.Point(3, 17);
            this.pibx_imagenPequeña.Name = "pibx_imagenPequeña";
            this.pibx_imagenPequeña.Size = new System.Drawing.Size(224, 114);
            this.pibx_imagenPequeña.TabIndex = 0;
            this.pibx_imagenPequeña.TabStop = false;
            // 
            // cmbNacionalidad3
            // 
            this.cmbNacionalidad3.DataSource = this.tbpaisInfoBindingSource;
            this.cmbNacionalidad3.DisplayMember = "Nacionalidad";
            this.cmbNacionalidad3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad3.FormattingEnabled = true;
            this.cmbNacionalidad3.Location = new System.Drawing.Point(158, 121);
            this.cmbNacionalidad3.Name = "cmbNacionalidad3";
            this.cmbNacionalidad3.Size = new System.Drawing.Size(217, 21);
            this.cmbNacionalidad3.TabIndex = 37;
            this.cmbNacionalidad3.ValueMember = "IdPais";
            // 
            // tbpaisInfoBindingSource
            // 
            this.tbpaisInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_pais_Info);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(29, 124);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(83, 13);
            this.labelControl16.TabIndex = 36;
            this.labelControl16.Text = "3ra Nacionalidad:";
            // 
            // cmbNacionalidad2
            // 
            this.cmbNacionalidad2.DataSource = this.tbpaisInfoBindingSource;
            this.cmbNacionalidad2.DisplayMember = "Nacionalidad";
            this.cmbNacionalidad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad2.FormattingEnabled = true;
            this.cmbNacionalidad2.Location = new System.Drawing.Point(158, 94);
            this.cmbNacionalidad2.Name = "cmbNacionalidad2";
            this.cmbNacionalidad2.Size = new System.Drawing.Size(217, 21);
            this.cmbNacionalidad2.TabIndex = 35;
            this.cmbNacionalidad2.ValueMember = "IdPais";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(29, 97);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(85, 13);
            this.labelControl14.TabIndex = 34;
            this.labelControl14.Text = "2da Nacionalidad:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(730, 285);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 33;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.DataSource = this.tbpaisInfoBindingSource;
            this.cmbNacionalidad.DisplayMember = "Nacionalidad";
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(158, 67);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(217, 21);
            this.cmbNacionalidad.TabIndex = 32;
            this.cmbNacionalidad.ValueMember = "IdPais";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.EditValue = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(158, 15);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.dtFechaNacimiento.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 261);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(325, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtNroCelular
            // 
            this.txtNroCelular.Location = new System.Drawing.Point(571, 230);
            this.txtNroCelular.Name = "txtNroCelular";
            this.txtNroCelular.Size = new System.Drawing.Size(215, 20);
            this.txtNroCelular.TabIndex = 26;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 230);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(325, 20);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(158, 203);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(628, 20);
            this.txtBarrio.TabIndex = 24;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(29, 264);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 13);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = "E-mail:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(510, 233);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Celular:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(28, 233);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Teléfono:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(28, 203);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 13);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Barrio:";
            // 
            // rgSexo
            // 
            this.rgSexo.Location = new System.Drawing.Point(686, 11);
            this.rgSexo.Name = "rgSexo";
            this.rgSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_MAS", "Masculimo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_FEM", "Fenemino")});
            this.rgSexo.Size = new System.Drawing.Size(100, 58);
            this.rgSexo.TabIndex = 17;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(158, 41);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(217, 20);
            this.txtLugar.TabIndex = 13;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(29, 163);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Dirección:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(29, 70);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Nacionalidad:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Lugar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(652, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Sexo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 18);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Fecha de nacimiento:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(158, 148);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(628, 46);
            this.txtDireccion.TabIndex = 19;
            // 
            // TabFichaMedica
            // 
            this.TabFichaMedica.Controls.Add(this.cmb_GrupoSanguineo);
            this.TabFichaMedica.Controls.Add(this.labelControl15);
            this.TabFichaMedica.Controls.Add(this.lblMedicamentosContraIndicados);
            this.TabFichaMedica.Controls.Add(this.txtSeguroMedico);
            this.TabFichaMedica.Controls.Add(this.lblSeguroMedico);
            this.TabFichaMedica.Controls.Add(this.lblGrupoSanguineo);
            this.TabFichaMedica.Controls.Add(this.gbxAlergia);
            this.TabFichaMedica.Controls.Add(this.lblInfoMed);
            this.TabFichaMedica.Controls.Add(this.meMedicamentosContraindicados);
            this.TabFichaMedica.Controls.Add(this.meOtrasIndicaciones);
            this.TabFichaMedica.Name = "TabFichaMedica";
            this.TabFichaMedica.Size = new System.Drawing.Size(826, 453);
            this.TabFichaMedica.Text = "Ficha Médica";
            // 
            // cmb_GrupoSanguineo
            // 
            this.cmb_GrupoSanguineo.Location = new System.Drawing.Point(102, 42);
            this.cmb_GrupoSanguineo.Name = "cmb_GrupoSanguineo";
            this.cmb_GrupoSanguineo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_GrupoSanguineo.Properties.DataSource = this.acaCatalogoInfoBindingSource;
            this.cmb_GrupoSanguineo.Properties.DisplayMember = "Descripcion";
            this.cmb_GrupoSanguineo.Properties.ValueMember = "IdCatalogo";
            this.cmb_GrupoSanguineo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_GrupoSanguineo.Size = new System.Drawing.Size(197, 20);
            this.cmb_GrupoSanguineo.TabIndex = 12;
            // 
            // acaCatalogoInfoBindingSource
            // 
            this.acaCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Catalogo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colIdTipoCatalogo,
            this.colDescripcion,
            this.colEstado,
            this.colOrden,
            this.colIdUsuario,
            this.colnom_pc,
            this.colip,
            this.colIdUsuarioUltMod,
            this.colFechaUltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colMotiAnula});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 0;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
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
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFechaUltMod
            // 
            this.colFechaUltMod.FieldName = "FechaUltMod";
            this.colFechaUltMod.Name = "colFechaUltMod";
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
            // colMotiAnula
            // 
            this.colMotiAnula.FieldName = "MotiAnula";
            this.colMotiAnula.Name = "colMotiAnula";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(11, 367);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(235, 13);
            this.labelControl15.TabIndex = 8;
            this.labelControl15.Text = "Otras Indicaciones médicas para tener en cuenta";
            // 
            // lblMedicamentosContraIndicados
            // 
            this.lblMedicamentosContraIndicados.Location = new System.Drawing.Point(11, 253);
            this.lblMedicamentosContraIndicados.Name = "lblMedicamentosContraIndicados";
            this.lblMedicamentosContraIndicados.Size = new System.Drawing.Size(152, 13);
            this.lblMedicamentosContraIndicados.TabIndex = 6;
            this.lblMedicamentosContraIndicados.Text = "Medicamentos Contraindicados:";
            // 
            // txtSeguroMedico
            // 
            this.txtSeguroMedico.Location = new System.Drawing.Point(399, 42);
            this.txtSeguroMedico.Name = "txtSeguroMedico";
            this.txtSeguroMedico.Size = new System.Drawing.Size(395, 20);
            this.txtSeguroMedico.TabIndex = 5;
            // 
            // lblSeguroMedico
            // 
            this.lblSeguroMedico.Location = new System.Drawing.Point(317, 49);
            this.lblSeguroMedico.Name = "lblSeguroMedico";
            this.lblSeguroMedico.Size = new System.Drawing.Size(74, 13);
            this.lblSeguroMedico.TabIndex = 4;
            this.lblSeguroMedico.Text = "Seguro Médico:";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(10, 49);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(86, 13);
            this.lblGrupoSanguineo.TabIndex = 2;
            this.lblGrupoSanguineo.Text = "Grupo Sanguineo:";
            // 
            // gbxAlergia
            // 
            this.gbxAlergia.Controls.Add(this.gcAlergia);
            this.gbxAlergia.Location = new System.Drawing.Point(8, 72);
            this.gbxAlergia.Name = "gbxAlergia";
            this.gbxAlergia.Size = new System.Drawing.Size(788, 169);
            this.gbxAlergia.TabIndex = 1;
            this.gbxAlergia.Text = "Alergias";
            // 
            // gcAlergia
            // 
            this.gcAlergia.DataSource = this.acaestudiantexAlergiaInfoBindingSource;
            this.gcAlergia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAlergia.Location = new System.Drawing.Point(2, 21);
            this.gcAlergia.MainView = this.gridViewAlergia;
            this.gcAlergia.Name = "gcAlergia";
            this.gcAlergia.Size = new System.Drawing.Size(784, 146);
            this.gcAlergia.TabIndex = 0;
            this.gcAlergia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAlergia});
            // 
            // acaestudiantexAlergiaInfoBindingSource
            // 
            this.acaestudiantexAlergiaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Estudiante_x_Alergia_Info);
            // 
            // gridViewAlergia
            // 
            this.gridViewAlergia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdEstudiante,
            this.colActivo,
            this.colIdAlergiaCatalogo,
            this.colNombreAlergia,
            this.colComentario,
            this.colEsta_en_Base});
            this.gridViewAlergia.GridControl = this.gcAlergia;
            this.gridViewAlergia.Name = "gridViewAlergia";
            this.gridViewAlergia.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdEstudiante
            // 
            this.colIdEstudiante.FieldName = "IdEstudiante";
            this.colIdEstudiante.Name = "colIdEstudiante";
            // 
            // colActivo
            // 
            this.colActivo.Caption = "*";
            this.colActivo.FieldName = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.Visible = true;
            this.colActivo.VisibleIndex = 0;
            this.colActivo.Width = 80;
            // 
            // colIdAlergiaCatalogo
            // 
            this.colIdAlergiaCatalogo.FieldName = "IdAlergiaCatalogo";
            this.colIdAlergiaCatalogo.Name = "colIdAlergiaCatalogo";
            // 
            // colNombreAlergia
            // 
            this.colNombreAlergia.Caption = "Alergia";
            this.colNombreAlergia.FieldName = "NombreAlergia";
            this.colNombreAlergia.Name = "colNombreAlergia";
            this.colNombreAlergia.Visible = true;
            this.colNombreAlergia.VisibleIndex = 1;
            this.colNombreAlergia.Width = 180;
            // 
            // colComentario
            // 
            this.colComentario.Caption = "Comentario";
            this.colComentario.FieldName = "Comentario";
            this.colComentario.Name = "colComentario";
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 2;
            this.colComentario.Width = 898;
            // 
            // colEsta_en_Base
            // 
            this.colEsta_en_Base.FieldName = "Esta_en_Base";
            this.colEsta_en_Base.Name = "colEsta_en_Base";
            // 
            // lblInfoMed
            // 
            this.lblInfoMed.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfoMed.Location = new System.Drawing.Point(11, 13);
            this.lblInfoMed.Name = "lblInfoMed";
            this.lblInfoMed.Size = new System.Drawing.Size(178, 13);
            this.lblInfoMed.TabIndex = 0;
            this.lblInfoMed.Text = "Información Médica del Alumno";
            // 
            // meMedicamentosContraindicados
            // 
            this.meMedicamentosContraindicados.Location = new System.Drawing.Point(11, 281);
            this.meMedicamentosContraindicados.Name = "meMedicamentosContraindicados";
            this.meMedicamentosContraindicados.Size = new System.Drawing.Size(788, 66);
            this.meMedicamentosContraindicados.TabIndex = 7;
            // 
            // meOtrasIndicaciones
            // 
            this.meOtrasIndicaciones.Location = new System.Drawing.Point(11, 386);
            this.meOtrasIndicaciones.Name = "meOtrasIndicaciones";
            this.meOtrasIndicaciones.Size = new System.Drawing.Size(788, 56);
            this.meOtrasIndicaciones.TabIndex = 11;
            // 
            // TabPadre
            // 
            this.TabPadre.Controls.Add(this.ucAca_Familiar_x_EstudiantePadre);
            this.TabPadre.Name = "TabPadre";
            this.TabPadre.Size = new System.Drawing.Size(826, 453);
            this.TabPadre.Text = "Padre";
            // 
            // ucAca_Familiar_x_EstudiantePadre
            // 
            this.ucAca_Familiar_x_EstudiantePadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudiantePadre.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudiantePadre.IdFamiliar = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudiantePadre.IdParentestoFamiliar = "PADR";
            this.ucAca_Familiar_x_EstudiantePadre.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudiantePadre.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudiantePadre.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudiantePadre.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudiantePadre.Name = "ucAca_Familiar_x_EstudiantePadre";
            this.ucAca_Familiar_x_EstudiantePadre.Size = new System.Drawing.Size(826, 453);
            this.ucAca_Familiar_x_EstudiantePadre.TabIndex = 0;
            this.ucAca_Familiar_x_EstudiantePadre.Visible_Page_InfoFinanciera = false;
            // 
            // TabMadre
            // 
            this.TabMadre.Controls.Add(this.ucAca_Familiar_x_EstudianteMadre);
            this.TabMadre.Name = "TabMadre";
            this.TabMadre.Size = new System.Drawing.Size(826, 453);
            this.TabMadre.Text = "Madre";
            // 
            // ucAca_Familiar_x_EstudianteMadre
            // 
            this.ucAca_Familiar_x_EstudianteMadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteMadre.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteMadre.IdFamiliar = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteMadre.IdParentestoFamiliar = "MADR";
            this.ucAca_Familiar_x_EstudianteMadre.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteMadre.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteMadre.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteMadre.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudianteMadre.Name = "ucAca_Familiar_x_EstudianteMadre";
            this.ucAca_Familiar_x_EstudianteMadre.Size = new System.Drawing.Size(826, 453);
            this.ucAca_Familiar_x_EstudianteMadre.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteMadre.Visible_Page_InfoFinanciera = false;
            // 
            // TabRepEco
            // 
            this.TabRepEco.Controls.Add(this.ucAca_Familiar_x_EstudianteRepEcono);
            this.TabRepEco.Name = "TabRepEco";
            this.TabRepEco.Size = new System.Drawing.Size(826, 453);
            this.TabRepEco.Text = "Representante Económico";
            // 
            // ucAca_Familiar_x_EstudianteRepEcono
            // 
            this.ucAca_Familiar_x_EstudianteRepEcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteRepEcono.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRepEcono.IdFamiliar = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRepEcono.IdParentestoFamiliar = "REP_ECO";
            this.ucAca_Familiar_x_EstudianteRepEcono.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteRepEcono.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteRepEcono.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteRepEcono.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudianteRepEcono.Name = "ucAca_Familiar_x_EstudianteRepEcono";
            this.ucAca_Familiar_x_EstudianteRepEcono.Size = new System.Drawing.Size(826, 453);
            this.ucAca_Familiar_x_EstudianteRepEcono.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteRepEcono.Visible_Page_InfoFinanciera = false;
            // 
            // TabPageRepLegal
            // 
            this.TabPageRepLegal.Controls.Add(this.ucAca_Familiar_x_EstudianteRepLegal);
            this.TabPageRepLegal.Name = "TabPageRepLegal";
            this.TabPageRepLegal.Size = new System.Drawing.Size(826, 453);
            this.TabPageRepLegal.Text = "Representante Legal";
            // 
            // ucAca_Familiar_x_EstudianteRepLegal
            // 
            this.ucAca_Familiar_x_EstudianteRepLegal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAca_Familiar_x_EstudianteRepLegal.IdEstudiante = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRepLegal.IdFamiliar = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ucAca_Familiar_x_EstudianteRepLegal.IdParentestoFamiliar = "REP_LEGAL";
            this.ucAca_Familiar_x_EstudianteRepLegal.Location = new System.Drawing.Point(0, 0);
            this.ucAca_Familiar_x_EstudianteRepLegal.Margin = new System.Windows.Forms.Padding(4);
            this.ucAca_Familiar_x_EstudianteRepLegal.matriculaInfo = null;
            this.ucAca_Familiar_x_EstudianteRepLegal.Mostrar_historico = false;
            this.ucAca_Familiar_x_EstudianteRepLegal.Name = "ucAca_Familiar_x_EstudianteRepLegal";
            this.ucAca_Familiar_x_EstudianteRepLegal.Size = new System.Drawing.Size(826, 453);
            this.ucAca_Familiar_x_EstudianteRepLegal.TabIndex = 0;
            this.ucAca_Familiar_x_EstudianteRepLegal.Visible_Page_InfoFinanciera = false;
            // 
            // lblIdPersona_
            // 
            this.lblIdPersona_.Location = new System.Drawing.Point(196, 16);
            this.lblIdPersona_.Name = "lblIdPersona_";
            this.lblIdPersona_.Size = new System.Drawing.Size(56, 13);
            this.lblIdPersona_.TabIndex = 40;
            this.lblIdPersona_.Text = "Id Persona:";
            // 
            // txtCedRuc
            // 
            this.txtCedRuc.Location = new System.Drawing.Point(612, 13);
            this.txtCedRuc.Name = "txtCedRuc";
            this.txtCedRuc.Size = new System.Drawing.Size(190, 20);
            this.txtCedRuc.TabIndex = 35;
            this.txtCedRuc.EditValueChanged += new System.EventHandler(this.txtCedRuc_EditValueChanged);
            this.txtCedRuc.Enter += new System.EventHandler(this.txtCedRuc_Enter);
            this.txtCedRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedRuc_KeyPress);
            this.txtCedRuc.Leave += new System.EventHandler(this.txtCedRuc_Leave);
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Enabled = false;
            this.txtIdEstudiante.Location = new System.Drawing.Point(90, 13);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIdEstudiante.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstudiante.TabIndex = 34;
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.Location = new System.Drawing.Point(27, 16);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(14, 13);
            this.lblIdEstudiante.TabIndex = 33;
            this.lblIdEstudiante.Text = "Id:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(90, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(712, 20);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(90, 65);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(712, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(419, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Identificación:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Apellidos:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombres:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // grbEstudiante
            // 
            this.grbEstudiante.Controls.Add(this.xtraTabEstudiante);
            this.grbEstudiante.Controls.Add(this.panel1);
            this.grbEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbEstudiante.Location = new System.Drawing.Point(0, 29);
            this.grbEstudiante.Name = "grbEstudiante";
            this.grbEstudiante.Size = new System.Drawing.Size(836, 622);
            this.grbEstudiante.TabIndex = 3;
            this.grbEstudiante.Text = "Ficha del Estudiantes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl19);
            this.panel1.Controls.Add(this.txtCodigo2);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.ucGe_Docu_PerIdentificacion);
            this.panel1.Controls.Add(this.lblIdPersona);
            this.panel1.Controls.Add(this.lblIdPersona_);
            this.panel1.Controls.Add(this.lblIdEstudiante);
            this.panel1.Controls.Add(this.txtIdEstudiante);
            this.panel1.Controls.Add(this.txtCedRuc);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 118);
            this.panel1.TabIndex = 3;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(254, 42);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(46, 13);
            this.labelControl19.TabIndex = 43;
            this.labelControl19.Text = "Código 2:";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(317, 39);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCodigo2.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo2.TabIndex = 44;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(666, 39);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 10;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_Docu_PerIdentificacion
            // 
            this.ucGe_Docu_PerIdentificacion._TipoDocPer = null;
            this.ucGe_Docu_PerIdentificacion.Location = new System.Drawing.Point(493, 16);
            this.ucGe_Docu_PerIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Docu_PerIdentificacion.Name = "ucGe_Docu_PerIdentificacion";
            this.ucGe_Docu_PerIdentificacion.Size = new System.Drawing.Size(113, 27);
            this.ucGe_Docu_PerIdentificacion.TabIndex = 42;
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.Location = new System.Drawing.Point(281, 16);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(0, 13);
            this.lblIdPersona.TabIndex = 41;
            // 
            // FrmAcaEstudiante_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 677);
            this.Controls.Add(this.grbEstudiante);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaEstudiante_Mant";
            this.Text = "Estudiante Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaEstudiante_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaEstudiante_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEstudiante)).EndInit();
            this.xtraTabEstudiante.ResumeLayout(false);
            this.TabFichaEst.ResumeLayout(false);
            this.TabFichaEst.PerformLayout();
            this.grImgGrande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibx_imagenPequeña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpaisInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            this.TabFichaMedica.ResumeLayout(false);
            this.TabFichaMedica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_GrupoSanguineo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguroMedico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxAlergia)).EndInit();
            this.gbxAlergia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAlergia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaestudiantexAlergiaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlergia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMedicamentosContraindicados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meOtrasIndicaciones.Properties)).EndInit();
            this.TabPadre.ResumeLayout(false);
            this.TabMadre.ResumeLayout(false);
            this.TabRepEco.ResumeLayout(false);
            this.TabPageRepLegal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbEstudiante)).EndInit();
            this.grbEstudiante.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraTab.XtraTabControl xtraTabEstudiante;
        private DevExpress.XtraTab.XtraTabPage TabFichaEst;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage TabFichaMedica;
        private DevExpress.XtraEditors.GroupControl grbEstudiante;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNroCelular;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtBarrio;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dtFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private DevExpress.XtraEditors.RadioGroup rgSexo;
        private DevExpress.XtraEditors.LabelControl lblIdEstudiante;
        private DevExpress.XtraEditors.TextEdit txtCedRuc;
        private DevExpress.XtraEditors.LabelControl lblIdPersona_;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl lblInfoMed;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblIdPersona;
        private DevExpress.XtraEditors.GroupControl gbxAlergia;
        private DevExpress.XtraGrid.GridControl gcAlergia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAlergia;
        private DevExpress.XtraEditors.LabelControl lblGrupoSanguineo;
        private DevExpress.XtraEditors.TextEdit txtSeguroMedico;
        private DevExpress.XtraEditors.LabelControl lblSeguroMedico;
        private DevExpress.XtraEditors.LabelControl lblMedicamentosContraIndicados;
        private DevExpress.XtraEditors.MemoEdit meMedicamentosContraindicados;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.MemoEdit meOtrasIndicaciones;
        private System.Windows.Forms.BindingSource acaestudiantexAlergiaInfoBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_GrupoSanguineo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource acaCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colMotiAnula;
        private Controles.UCGe_Docu_Personales ucGe_Docu_PerIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAlergiaCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAlergia;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colEsta_en_Base;
        private System.Windows.Forms.CheckBox chkActivo;
        private DevExpress.XtraTab.XtraTabPage TabPadre;
        private DevExpress.XtraTab.XtraTabPage TabMadre;
        private DevExpress.XtraTab.XtraTabPage TabRepEco;
        public DevExpress.XtraEditors.TextEdit txtIdEstudiante;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.BindingSource tbpaisInfoBindingSource;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudiantePadre;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteMadre;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteRepEcono;
        private DevExpress.XtraTab.XtraTabPage TabPageRepLegal;
        private Controles.UCAca_Familiar_x_Estudiante ucAca_Familiar_x_EstudianteRepLegal;
        private System.Windows.Forms.ComboBox cmbNacionalidad3;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.ComboBox cmbNacionalidad2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btn_imgGrande;
        private System.Windows.Forms.GroupBox grImgGrande;
        private System.Windows.Forms.PictureBox pibx_imagenPequeña;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtCodigo2;
    }
}
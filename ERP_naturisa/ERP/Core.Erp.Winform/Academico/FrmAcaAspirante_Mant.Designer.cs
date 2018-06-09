namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaAspirante_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.grbAspirante = new DevExpress.XtraEditors.GroupControl();
            this.lblIdPersonaTxt = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAspirante = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_Docu_PerIdentificacion = new Core.Erp.Winform.Controles.UCGe_Docu_Personales();
            this.txtCedRuc = new DevExpress.XtraEditors.TextEdit();
            this.lblIdentificacion = new DevExpress.XtraEditors.LabelControl();
            this.lblIdPersona = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.lblApellidos = new DevExpress.XtraEditors.LabelControl();
            this.lblNombres = new DevExpress.XtraEditors.LabelControl();
            this.lblIdAspirante = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabAspirante = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabDatosPers = new DevExpress.XtraTab.XtraTabPage();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.dtFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNroCelular = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarrio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtLugar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.rgSexo = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grbAspirante)).BeginInit();
            this.grbAspirante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAspirante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAspirante)).BeginInit();
            this.xtraTabAspirante.SuspendLayout();
            this.xtraTabDatosPers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(763, 32);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 455);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(763, 23);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // grbAspirante
            // 
            this.grbAspirante.Controls.Add(this.lblIdPersonaTxt);
            this.grbAspirante.Controls.Add(this.txtIdAspirante);
            this.grbAspirante.Controls.Add(this.txtCodigo);
            this.grbAspirante.Controls.Add(this.txtNombres);
            this.grbAspirante.Controls.Add(this.txtApellidos);
            this.grbAspirante.Controls.Add(this.lblAnulado);
            this.grbAspirante.Controls.Add(this.ucGe_Docu_PerIdentificacion);
            this.grbAspirante.Controls.Add(this.txtCedRuc);
            this.grbAspirante.Controls.Add(this.lblIdentificacion);
            this.grbAspirante.Controls.Add(this.lblIdPersona);
            this.grbAspirante.Controls.Add(this.lblCodigo);
            this.grbAspirante.Controls.Add(this.lblApellidos);
            this.grbAspirante.Controls.Add(this.lblNombres);
            this.grbAspirante.Controls.Add(this.lblIdAspirante);
            this.grbAspirante.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbAspirante.Location = new System.Drawing.Point(0, 32);
            this.grbAspirante.Name = "grbAspirante";
            this.grbAspirante.Size = new System.Drawing.Size(763, 129);
            this.grbAspirante.TabIndex = 2;
            this.grbAspirante.Text = "Ficha Aspirante";
            // 
            // lblIdPersonaTxt
            // 
            this.lblIdPersonaTxt.Location = new System.Drawing.Point(439, 32);
            this.lblIdPersonaTxt.Name = "lblIdPersonaTxt";
            this.lblIdPersonaTxt.Size = new System.Drawing.Size(6, 13);
            this.lblIdPersonaTxt.TabIndex = 51;
            this.lblIdPersonaTxt.Text = "0";
            // 
            // txtIdAspirante
            // 
            this.txtIdAspirante.EditValue = "0";
            this.txtIdAspirante.Enabled = false;
            this.txtIdAspirante.Location = new System.Drawing.Point(86, 29);
            this.txtIdAspirante.Name = "txtIdAspirante";
            this.txtIdAspirante.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIdAspirante.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdAspirante.Size = new System.Drawing.Size(100, 20);
            this.txtIdAspirante.TabIndex = 50;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 47;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(86, 81);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(519, 20);
            this.txtNombres.TabIndex = 48;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(86, 104);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(519, 20);
            this.txtApellidos.TabIndex = 49;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(612, 104);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 44;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_Docu_PerIdentificacion
            // 
            this.ucGe_Docu_PerIdentificacion._TipoDocPer = null;
            this.ucGe_Docu_PerIdentificacion.Location = new System.Drawing.Point(439, 54);
            this.ucGe_Docu_PerIdentificacion.Name = "ucGe_Docu_PerIdentificacion";
            this.ucGe_Docu_PerIdentificacion.Size = new System.Drawing.Size(113, 27);
            this.ucGe_Docu_PerIdentificacion.TabIndex = 46;
            // 
            // txtCedRuc
            // 
            this.txtCedRuc.Location = new System.Drawing.Point(558, 51);
            this.txtCedRuc.Name = "txtCedRuc";
            this.txtCedRuc.Size = new System.Drawing.Size(190, 20);
            this.txtCedRuc.TabIndex = 45;
            this.txtCedRuc.Enter += new System.EventHandler(this.txtCedRuc_Enter);
            this.txtCedRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedRuc_KeyPress);
            this.txtCedRuc.Leave += new System.EventHandler(this.txtCedRuc_Leave);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Location = new System.Drawing.Point(362, 54);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificacion.TabIndex = 43;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.Location = new System.Drawing.Point(362, 32);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(56, 13);
            this.lblIdPersona.TabIndex = 4;
            this.lblIdPersona.Text = "Id Persona:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(30, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Location = new System.Drawing.Point(30, 104);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(46, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(30, 85);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(46, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblIdAspirante
            // 
            this.lblIdAspirante.Location = new System.Drawing.Point(30, 32);
            this.lblIdAspirante.Name = "lblIdAspirante";
            this.lblIdAspirante.Size = new System.Drawing.Size(14, 13);
            this.lblIdAspirante.TabIndex = 0;
            this.lblIdAspirante.Text = "Id:";
            // 
            // xtraTabAspirante
            // 
            this.xtraTabAspirante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabAspirante.Location = new System.Drawing.Point(0, 161);
            this.xtraTabAspirante.Name = "xtraTabAspirante";
            this.xtraTabAspirante.SelectedTabPage = this.xtraTabDatosPers;
            this.xtraTabAspirante.Size = new System.Drawing.Size(763, 294);
            this.xtraTabAspirante.TabIndex = 3;
            this.xtraTabAspirante.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabDatosPers});
            // 
            // xtraTabDatosPers
            // 
            this.xtraTabDatosPers.Controls.Add(this.chkActivo);
            this.xtraTabDatosPers.Controls.Add(this.cmbNacionalidad);
            this.xtraTabDatosPers.Controls.Add(this.txtDireccion);
            this.xtraTabDatosPers.Controls.Add(this.dtFechaNacimiento);
            this.xtraTabDatosPers.Controls.Add(this.labelControl5);
            this.xtraTabDatosPers.Controls.Add(this.txtEmail);
            this.xtraTabDatosPers.Controls.Add(this.labelControl6);
            this.xtraTabDatosPers.Controls.Add(this.txtNroCelular);
            this.xtraTabDatosPers.Controls.Add(this.labelControl7);
            this.xtraTabDatosPers.Controls.Add(this.txtTelefono);
            this.xtraTabDatosPers.Controls.Add(this.labelControl8);
            this.xtraTabDatosPers.Controls.Add(this.txtBarrio);
            this.xtraTabDatosPers.Controls.Add(this.labelControl9);
            this.xtraTabDatosPers.Controls.Add(this.labelControl13);
            this.xtraTabDatosPers.Controls.Add(this.txtLugar);
            this.xtraTabDatosPers.Controls.Add(this.labelControl12);
            this.xtraTabDatosPers.Controls.Add(this.rgSexo);
            this.xtraTabDatosPers.Controls.Add(this.labelControl11);
            this.xtraTabDatosPers.Controls.Add(this.labelControl10);
            this.xtraTabDatosPers.Name = "xtraTabDatosPers";
            this.xtraTabDatosPers.Size = new System.Drawing.Size(757, 266);
            this.xtraTabDatosPers.Text = "Datos Personales";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(691, 244);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 70;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.DisplayMember = "Nacionalidad";
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(134, 75);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(217, 21);
            this.cmbNacionalidad.TabIndex = 69;
            this.cmbNacionalidad.ValueMember = "IdPais";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(134, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(547, 46);
            this.txtDireccion.TabIndex = 59;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.EditValue = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(134, 15);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaNacimiento.Size = new System.Drawing.Size(217, 20);
            this.dtFechaNacimiento.TabIndex = 68;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 13);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Fecha de nacimiento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(325, 20);
            this.txtEmail.TabIndex = 67;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(547, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Sexo:";
            // 
            // txtNroCelular
            // 
            this.txtNroCelular.Location = new System.Drawing.Point(547, 184);
            this.txtNroCelular.Name = "txtNroCelular";
            this.txtNroCelular.Size = new System.Drawing.Size(134, 20);
            this.txtNroCelular.TabIndex = 66;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 51);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 54;
            this.labelControl7.Text = "Lugar:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(134, 184);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(325, 20);
            this.txtTelefono.TabIndex = 65;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(29, 83);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 55;
            this.labelControl8.Text = "Nacionalidad:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(134, 157);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(547, 20);
            this.txtBarrio.TabIndex = 64;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(29, 116);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 56;
            this.labelControl9.Text = "Dirección:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(29, 218);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(32, 13);
            this.labelControl13.TabIndex = 63;
            this.labelControl13.Text = "E-mail:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(134, 49);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(217, 20);
            this.txtLugar.TabIndex = 57;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(486, 187);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 62;
            this.labelControl12.Text = "Celular:";
            // 
            // rgSexo
            // 
            this.rgSexo.Location = new System.Drawing.Point(581, 11);
            this.rgSexo.Name = "rgSexo";
            this.rgSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_MAS", "Masculimo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_FEM", "Fenemino")});
            this.rgSexo.Size = new System.Drawing.Size(100, 58);
            this.rgSexo.TabIndex = 58;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(28, 187);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Teléfono:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(28, 156);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 13);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Barrio:";
            // 
            // FrmAcaAspirante_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 478);
            this.Controls.Add(this.xtraTabAspirante);
            this.Controls.Add(this.grbAspirante);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaAspirante_Mant";
            this.Text = "FrmAcaAspirante_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaAspirante_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaAspirante_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbAspirante)).EndInit();
            this.grbAspirante.ResumeLayout(false);
            this.grbAspirante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAspirante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAspirante)).EndInit();
            this.xtraTabAspirante.ResumeLayout(false);
            this.xtraTabDatosPers.ResumeLayout(false);
            this.xtraTabDatosPers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarrio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraEditors.GroupControl grbAspirante;
        private DevExpress.XtraTab.XtraTabControl xtraTabAspirante;
        private DevExpress.XtraTab.XtraTabPage xtraTabDatosPers;
        private DevExpress.XtraEditors.LabelControl lblIdAspirante;
        private DevExpress.XtraEditors.LabelControl lblApellidos;
        private DevExpress.XtraEditors.LabelControl lblNombres;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblIdPersona;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_Docu_Personales ucGe_Docu_PerIdentificacion;
        private DevExpress.XtraEditors.TextEdit txtCedRuc;
        private DevExpress.XtraEditors.LabelControl lblIdentificacion;
        public DevExpress.XtraEditors.TextEdit txtIdAspirante;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl lblIdPersonaTxt;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private DevExpress.XtraEditors.DateEdit dtFechaNacimiento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNroCelular;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtBarrio;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtLugar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.RadioGroup rgSexo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;

    }
}
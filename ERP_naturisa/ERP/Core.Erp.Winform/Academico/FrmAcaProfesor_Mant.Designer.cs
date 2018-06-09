namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaProfesor_Mant
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
            this.lblIdProfesor = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigoProfesor = new DevExpress.XtraEditors.LabelControl();
            this.lblIdPersona = new DevExpress.XtraEditors.LabelControl();
            this.lblNombres = new DevExpress.XtraEditors.LabelControl();
            this.lblApellidos = new DevExpress.XtraEditors.LabelControl();
            this.txtIdProfesor = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoProfesor = new DevExpress.XtraEditors.TextEdit();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.lblIdPersonaTxt = new DevExpress.XtraEditors.LabelControl();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.rgSexo = new DevExpress.XtraEditors.RadioGroup();
            this.lblSexo = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.ucGe_Docu_PerIdentificacion = new Core.Erp.Winform.Controles.UCGe_Docu_Personales();
            this.lblIdentificacion = new DevExpress.XtraEditors.LabelControl();
            this.lblBase = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProfesor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProfesor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProfesor
            // 
            this.lblIdProfesor.Location = new System.Drawing.Point(25, 44);
            this.lblIdProfesor.Name = "lblIdProfesor";
            this.lblIdProfesor.Size = new System.Drawing.Size(58, 13);
            this.lblIdProfesor.TabIndex = 5;
            this.lblIdProfesor.Text = "Id Profesor:";
            // 
            // lblCodigoProfesor
            // 
            this.lblCodigoProfesor.Location = new System.Drawing.Point(25, 70);
            this.lblCodigoProfesor.Name = "lblCodigoProfesor";
            this.lblCodigoProfesor.Size = new System.Drawing.Size(81, 13);
            this.lblCodigoProfesor.TabIndex = 6;
            this.lblCodigoProfesor.Text = "Código Profesor:";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.Location = new System.Drawing.Point(447, 45);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(56, 13);
            this.lblIdPersona.TabIndex = 7;
            this.lblIdPersona.Text = "Id Persona:";
            // 
            // lblNombres
            // 
            this.lblNombres.Location = new System.Drawing.Point(25, 129);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(46, 13);
            this.lblNombres.TabIndex = 8;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Location = new System.Drawing.Point(25, 155);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(46, 13);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Location = new System.Drawing.Point(110, 42);
            this.txtIdProfesor.Name = "txtIdProfesor";
            this.txtIdProfesor.Size = new System.Drawing.Size(133, 20);
            this.txtIdProfesor.TabIndex = 10;
            // 
            // txtCodigoProfesor
            // 
            this.txtCodigoProfesor.Location = new System.Drawing.Point(110, 68);
            this.txtCodigoProfesor.Name = "txtCodigoProfesor";
            this.txtCodigoProfesor.Size = new System.Drawing.Size(133, 20);
            this.txtCodigoProfesor.TabIndex = 11;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(110, 127);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(444, 20);
            this.txtNombres.TabIndex = 12;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(110, 153);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(444, 20);
            this.txtApellidos.TabIndex = 13;
            // 
            // lblIdPersonaTxt
            // 
            this.lblIdPersonaTxt.Location = new System.Drawing.Point(509, 44);
            this.lblIdPersonaTxt.Name = "lblIdPersonaTxt";
            this.lblIdPersonaTxt.Size = new System.Drawing.Size(6, 13);
            this.lblIdPersonaTxt.TabIndex = 14;
            this.lblIdPersonaTxt.Text = "0";
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(485, 202);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Size = new System.Drawing.Size(58, 19);
            this.chkEstado.TabIndex = 15;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(302, 201);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 47;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 237);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(618, 23);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 4;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(618, 32);
            this.ucGe_Menu.TabIndex = 3;
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
            // rgSexo
            // 
            this.rgSexo.Location = new System.Drawing.Point(508, 63);
            this.rgSexo.Name = "rgSexo";
            this.rgSexo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_MAS", "Masculimo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SEXO_FEM", "Fenemino")});
            this.rgSexo.Size = new System.Drawing.Size(100, 58);
            this.rgSexo.TabIndex = 50;
            // 
            // lblSexo
            // 
            this.lblSexo.Location = new System.Drawing.Point(447, 64);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(28, 13);
            this.lblSexo.TabIndex = 51;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(229, 94);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(206, 20);
            this.txtCedula.TabIndex = 52;
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // ucGe_Docu_PerIdentificacion
            // 
            this.ucGe_Docu_PerIdentificacion._TipoDocPer = null;
            this.ucGe_Docu_PerIdentificacion.Location = new System.Drawing.Point(110, 94);
            this.ucGe_Docu_PerIdentificacion.Name = "ucGe_Docu_PerIdentificacion";
            this.ucGe_Docu_PerIdentificacion.Size = new System.Drawing.Size(113, 27);
            this.ucGe_Docu_PerIdentificacion.TabIndex = 53;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Location = new System.Drawing.Point(25, 100);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificacion.TabIndex = 54;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblBase
            // 
            this.lblBase.Location = new System.Drawing.Point(472, 181);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(0, 13);
            this.lblBase.TabIndex = 55;
            this.lblBase.Visible = false;
            // 
            // FrmAcaProfesor_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 260);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.ucGe_Docu_PerIdentificacion);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rgSexo);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.lblIdPersonaTxt);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigoProfesor);
            this.Controls.Add(this.txtIdProfesor);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.lblCodigoProfesor);
            this.Controls.Add(this.lblIdProfesor);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaProfesor_Mant";
            this.Text = "FrmAcaProfesor_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcaProfesor_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcaProfesor_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProfesor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProfesor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraEditors.LabelControl lblIdProfesor;
        private DevExpress.XtraEditors.LabelControl lblCodigoProfesor;
        private DevExpress.XtraEditors.LabelControl lblIdPersona;
        private DevExpress.XtraEditors.LabelControl lblNombres;
        private DevExpress.XtraEditors.LabelControl lblApellidos;
        private DevExpress.XtraEditors.TextEdit txtIdProfesor;
        private DevExpress.XtraEditors.TextEdit txtCodigoProfesor;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl lblIdPersonaTxt;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.RadioGroup rgSexo;
        private DevExpress.XtraEditors.LabelControl lblSexo;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private Controles.UCGe_Docu_Personales ucGe_Docu_PerIdentificacion;
        private DevExpress.XtraEditors.LabelControl lblIdentificacion;
        private DevExpress.XtraEditors.LabelControl lblBase;
    }
}
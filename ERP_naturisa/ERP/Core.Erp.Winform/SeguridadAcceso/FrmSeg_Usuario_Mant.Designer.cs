namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Usuario_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeg_Usuario_Mant));
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaEmpresas = new System.Windows.Forms.CheckedListBox();
            this.grbEmpresas = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonResetearContrasenia = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_cambio_contrasenia_sigt_sesion = new System.Windows.Forms.CheckBox();
            this.chk_directiva_contrasenia = new System.Windows.Forms.CheckBox();
            this.uC_Menu_Mantenimientos1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            this.grbEmpresas.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(12, 41);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(352, 20);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfirmarPassword);
            this.groupBox1.Controls.Add(this.lblConfirmarPassword);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Location = new System.Drawing.Point(36, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(12, 154);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(352, 20);
            this.txtConfirmarPassword.TabIndex = 2;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(12, 137);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmarPassword.TabIndex = 11;
            this.lblConfirmarPassword.Text = "Confirmar Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 214);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(352, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre completo";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Usuario";
            // 
            // listaEmpresas
            // 
            this.listaEmpresas.FormattingEnabled = true;
            this.listaEmpresas.Location = new System.Drawing.Point(6, 34);
            this.listaEmpresas.Name = "listaEmpresas";
            this.listaEmpresas.Size = new System.Drawing.Size(255, 214);
            this.listaEmpresas.TabIndex = 12;
            // 
            // grbEmpresas
            // 
            this.grbEmpresas.Controls.Add(this.listaEmpresas);
            this.grbEmpresas.Location = new System.Drawing.Point(501, 73);
            this.grbEmpresas.Name = "grbEmpresas";
            this.grbEmpresas.Size = new System.Drawing.Size(267, 256);
            this.grbEmpresas.TabIndex = 13;
            this.grbEmpresas.TabStop = false;
            this.grbEmpresas.Text = "Seleccione las empresas a las que se va a tener acceso el usuario";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonResetearContrasenia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonResetearContrasenia
            // 
            this.toolStripButtonResetearContrasenia.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResetearContrasenia.Image")));
            this.toolStripButtonResetearContrasenia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetearContrasenia.Name = "toolStripButtonResetearContrasenia";
            this.toolStripButtonResetearContrasenia.Size = new System.Drawing.Size(134, 22);
            this.toolStripButtonResetearContrasenia.Text = "Resetear Contraseña";
            this.toolStripButtonResetearContrasenia.Click += new System.EventHandler(this.toolStripButtonResetearContrasenia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_cambio_contrasenia_sigt_sesion);
            this.groupBox2.Controls.Add(this.chk_directiva_contrasenia);
            this.groupBox2.Location = new System.Drawing.Point(36, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // chk_cambio_contrasenia_sigt_sesion
            // 
            this.chk_cambio_contrasenia_sigt_sesion.AutoSize = true;
            this.chk_cambio_contrasenia_sigt_sesion.Location = new System.Drawing.Point(320, 19);
            this.chk_cambio_contrasenia_sigt_sesion.Name = "chk_cambio_contrasenia_sigt_sesion";
            this.chk_cambio_contrasenia_sigt_sesion.Size = new System.Drawing.Size(367, 17);
            this.chk_cambio_contrasenia_sigt_sesion.TabIndex = 15;
            this.chk_cambio_contrasenia_sigt_sesion.Text = "El usuario debe de cambiar la contraseña en el siguiente inicio de sesión";
            this.chk_cambio_contrasenia_sigt_sesion.UseVisualStyleBackColor = true;
            // 
            // chk_directiva_contrasenia
            // 
            this.chk_directiva_contrasenia.AutoSize = true;
            this.chk_directiva_contrasenia.Location = new System.Drawing.Point(37, 19);
            this.chk_directiva_contrasenia.Name = "chk_directiva_contrasenia";
            this.chk_directiva_contrasenia.Size = new System.Drawing.Size(171, 17);
            this.chk_directiva_contrasenia.TabIndex = 14;
            this.chk_directiva_contrasenia.Text = "Exigir directivas de Contraseña";
            this.chk_directiva_contrasenia.UseVisualStyleBackColor = true;
            // 
            // uC_Menu_Mantenimientos1
            // 
            this.uC_Menu_Mantenimientos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Menu_Mantenimientos1.Enabled_bnRetImprimir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntAnular = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntAprobar = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntGuardar_y_Salir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntImprimir = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntImprimir_Guia = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntLimpiar = true;
            this.uC_Menu_Mantenimientos1.Enabled_bntSalir = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_conciliacion_Auto = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_DiseñoReporte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Generar_XML = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Cbte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Cheq = true;
            this.uC_Menu_Mantenimientos1.Enabled_btn_Imprimir_Reten = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnAceptar = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnAprobarGuardarSalir = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnEstadosOC = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnGuardar = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpFrm = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpLote = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImpRep = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnImprimirSoporte = true;
            this.uC_Menu_Mantenimientos1.Enabled_btnproductos = true;
            this.uC_Menu_Mantenimientos1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Mantenimientos1.Name = "uC_Menu_Mantenimientos1";
            this.uC_Menu_Mantenimientos1.Size = new System.Drawing.Size(800, 29);
            this.uC_Menu_Mantenimientos1.TabIndex = 14;
            this.uC_Menu_Mantenimientos1.Visible_bntAnular = false;
            this.uC_Menu_Mantenimientos1.Visible_bntAprobar = false;
            this.uC_Menu_Mantenimientos1.Visible_bntDiseñoReporte = false;
            this.uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = true;
            this.uC_Menu_Mantenimientos1.Visible_bntImprimir = false;
            this.uC_Menu_Mantenimientos1.Visible_bntImprimir_Guia = false;
            this.uC_Menu_Mantenimientos1.Visible_bntLimpiar = false;
            this.uC_Menu_Mantenimientos1.Visible_bntReImprimir = false;
            this.uC_Menu_Mantenimientos1.Visible_bntSalir = true;
            this.uC_Menu_Mantenimientos1.Visible_btn_Actualizar = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_conciliacion_Auto = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Generar_XML = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Cbte = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Cheq = false;
            this.uC_Menu_Mantenimientos1.Visible_btn_Imprimir_Reten = false;
            this.uC_Menu_Mantenimientos1.Visible_btnAceptar = false;
            this.uC_Menu_Mantenimientos1.Visible_btnAprobarGuardarSalir = false;
            this.uC_Menu_Mantenimientos1.Visible_btnEstadosOC = false;
            this.uC_Menu_Mantenimientos1.Visible_btnGuardar = true;
            this.uC_Menu_Mantenimientos1.Visible_btnImpFrm = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImpLote = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImpRep = false;
            this.uC_Menu_Mantenimientos1.Visible_btnImprimirSoporte = false;
            this.uC_Menu_Mantenimientos1.Visible_btnproductos = false;
            this.uC_Menu_Mantenimientos1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uC_Menu_Mantenimientos1_event_btnGuardar_Click);
            this.uC_Menu_Mantenimientos1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uC_Menu_Mantenimientos1_event_btnGuardar_y_Salir_Click);
            this.uC_Menu_Mantenimientos1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uC_Menu_Mantenimientos1_event_btnSalir_Click);
            // 
            // FrmSeg_Usuario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uC_Menu_Mantenimientos1);
            this.Controls.Add(this.grbEmpresas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSeg_Usuario_Mant";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeg_Usuario_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmManUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbEmpresas.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblConfirmarPassword;
        public System.Windows.Forms.CheckedListBox listaEmpresas;
        public System.Windows.Forms.GroupBox grbEmpresas;
        private Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant uC_Menu_Mantenimientos1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetearContrasenia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_cambio_contrasenia_sigt_sesion;
        private System.Windows.Forms.CheckBox chk_directiva_contrasenia;
    }
}
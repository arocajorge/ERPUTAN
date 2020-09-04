namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Banco_Cuenta_Mant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UCBanco = new Core.Erp.Winform.Controles.UCGe_Bancos_cmb();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCuentaContable = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdbChequemascomprobante = new DevExpress.XtraEditors.CheckEdit();
            this.rdbSoloCheque = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txtFormCheque = new System.Windows.Forms.NumericUpDown();
            this.ckbPreviewChe = new System.Windows.Forms.CheckBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbChequemascomprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbSoloCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormCheque)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UCBanco);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbCuentaContable);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.lbl_Estado);
            this.panel1.Controls.Add(this.txtFormCheque);
            this.panel1.Controls.Add(this.ckbPreviewChe);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.cmbMoneda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNumCuenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTipoCuenta);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdBanco);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 514);
            this.panel1.TabIndex = 1;
            // 
            // UCBanco
            // 
            this.UCBanco.Location = new System.Drawing.Point(233, 43);
            this.UCBanco.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UCBanco.Name = "UCBanco";
            this.UCBanco.Size = new System.Drawing.Size(661, 42);
            this.UCBanco.TabIndex = 21;
            this.UCBanco.event_cmb_CuentaBanco_EditValueChanged += new Core.Erp.Winform.Controles.UCGe_Bancos_cmb.delegate_cmb_CuentaBanco_EditValueChanged(this.UCBanco_event_cmb_CuentaBanco_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Banco:";
            // 
            // cmbCuentaContable
            // 
            this.cmbCuentaContable.Location = new System.Drawing.Point(227, 308);
            this.cmbCuentaContable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbCuentaContable.Name = "cmbCuentaContable";
            this.cmbCuentaContable.Size = new System.Drawing.Size(608, 32);
            this.cmbCuentaContable.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdbChequemascomprobante);
            this.groupControl1.Controls.Add(this.rdbSoloCheque);
            this.groupControl1.Location = new System.Drawing.Point(55, 380);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 65);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Tipo De Impresión ";
            // 
            // rdbChequemascomprobante
            // 
            this.rdbChequemascomprobante.Location = new System.Drawing.Point(293, 33);
            this.rdbChequemascomprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbChequemascomprobante.Name = "rdbChequemascomprobante";
            this.rdbChequemascomprobante.Properties.Caption = "Imprimir cheque + Comprobante";
            this.rdbChequemascomprobante.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.rdbChequemascomprobante.Size = new System.Drawing.Size(265, 21);
            this.rdbChequemascomprobante.TabIndex = 0;
            this.rdbChequemascomprobante.CheckedChanged += new System.EventHandler(this.rdbChequemascomprobante_CheckedChanged);
            // 
            // rdbSoloCheque
            // 
            this.rdbSoloCheque.Location = new System.Drawing.Point(7, 33);
            this.rdbSoloCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSoloCheque.Name = "rdbSoloCheque";
            this.rdbSoloCheque.Properties.Caption = "Imprimir solo cheque";
            this.rdbSoloCheque.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.rdbSoloCheque.Size = new System.Drawing.Size(177, 21);
            this.rdbSoloCheque.TabIndex = 0;
            this.rdbSoloCheque.CheckedChanged += new System.EventHandler(this.rdbSoloCheque_CheckedChanged);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.Red;
            this.lbl_Estado.Location = new System.Drawing.Point(395, 6);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(176, 28);
            this.lbl_Estado.TabIndex = 0;
            this.lbl_Estado.Text = "**ANULADO**";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Estado.Visible = false;
            // 
            // txtFormCheque
            // 
            this.txtFormCheque.Location = new System.Drawing.Point(263, 257);
            this.txtFormCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFormCheque.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtFormCheque.Name = "txtFormCheque";
            this.txtFormCheque.Size = new System.Drawing.Size(84, 22);
            this.txtFormCheque.TabIndex = 5;
            this.txtFormCheque.ValueChanged += new System.EventHandler(this.txtFormCheque_ValueChanged);
            this.txtFormCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormCheque_KeyPress_1);
            this.txtFormCheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFormCheque_KeyUp);
            // 
            // ckbPreviewChe
            // 
            this.ckbPreviewChe.AutoSize = true;
            this.ckbPreviewChe.Location = new System.Drawing.Point(351, 484);
            this.ckbPreviewChe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPreviewChe.Name = "ckbPreviewChe";
            this.ckbPreviewChe.Size = new System.Drawing.Size(210, 21);
            this.ckbPreviewChe.TabIndex = 8;
            this.ckbPreviewChe.Text = "Mostrar Vista Previa Cheque";
            this.ckbPreviewChe.UseVisualStyleBackColor = true;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(64, 484);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(74, 21);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Items.AddRange(new object[] {
            "Dolar  ($)",
            "Euro   (€)"});
            this.cmbMoneda.Location = new System.Drawing.Point(589, 250);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(244, 24);
            this.cmbMoneda.TabIndex = 3;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Moneda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cuenta Contable Bancos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "# Digitos x Cheque(0000):";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(509, 92);
            this.txtNumCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumCuenta.MaxLength = 50;
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(324, 22);
            this.txtNumCuenta.TabIndex = 4;
            this.txtNumCuenta.TextChanged += new System.EventHandler(this.txtNumCuenta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "# Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Cuenta";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DisplayMember = "0";
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "Cuenta de ahorro",
            "Cuenta corriente"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(233, 89);
            this.cmbTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(173, 24);
            this.cmbTipoCuenta.TabIndex = 2;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(227, 159);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(607, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la Cuenta";
            // 
            // txtIdBanco
            // 
            this.txtIdBanco.Enabled = false;
            this.txtIdBanco.Location = new System.Drawing.Point(233, 7);
            this.txtIdBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdBanco.Name = "txtIdBanco";
            this.txtIdBanco.Size = new System.Drawing.Size(60, 22);
            this.txtIdBanco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCuentaBancaria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 514);
            this.panel2.TabIndex = 3;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 550);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(855, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(855, 36);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            // 
            // FrmBA_Banco_Cuenta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBA_Banco_Cuenta_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Bancaria Mantenimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBA_Banco_Cuenta_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmBA_Banco_Cuenta_Mantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdbChequemascomprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbSoloCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormCheque)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.NumericUpDown txtFormCheque;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label lbl_Estado;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit rdbChequemascomprobante;
        private DevExpress.XtraEditors.CheckEdit rdbSoloCheque;
        private System.Windows.Forms.CheckBox ckbPreviewChe;
        private Controles.UCCon_PlanCtaCmb cmbCuentaContable;
        private System.Windows.Forms.Label label8;
        private Controles.UCGe_Bancos_cmb UCBanco;
    }
}
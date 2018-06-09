namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Cancelacion_Cuotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txe_IdPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.txe_Banco = new DevExpress.XtraEditors.TextEdit();
            this.txe_numCuota = new DevExpress.XtraEditors.TextEdit();
            this.txe_ValorCuota = new DevExpress.XtraEditors.TextEdit();
            this.txe_Mon_x_Can = new DevExpress.XtraEditors.TextEdit();
            this.txe_SaldoPendiente = new DevExpress.XtraEditors.TextEdit();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.dte_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_banco = new Core.Erp.Winform.Controles.UCBa_CuentaBanco();
            ((System.ComponentModel.ISupportInitialize)(this.txe_IdPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_Banco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_numCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_ValorCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_Mon_x_Can.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_SaldoPendiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Fecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# Préstamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "# Cuota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto a cancelar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saldo Pendiente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Observación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Valor:";
            // 
            // txe_IdPrestamo
            // 
            this.txe_IdPrestamo.Location = new System.Drawing.Point(123, 39);
            this.txe_IdPrestamo.Name = "txe_IdPrestamo";
            this.txe_IdPrestamo.Properties.ReadOnly = true;
            this.txe_IdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txe_IdPrestamo.TabIndex = 10;
            // 
            // txe_Banco
            // 
            this.txe_Banco.Location = new System.Drawing.Point(123, 65);
            this.txe_Banco.Name = "txe_Banco";
            this.txe_Banco.Properties.ReadOnly = true;
            this.txe_Banco.Size = new System.Drawing.Size(380, 20);
            this.txe_Banco.TabIndex = 11;
            // 
            // txe_numCuota
            // 
            this.txe_numCuota.Location = new System.Drawing.Point(123, 113);
            this.txe_numCuota.Name = "txe_numCuota";
            this.txe_numCuota.Properties.ReadOnly = true;
            this.txe_numCuota.Size = new System.Drawing.Size(100, 20);
            this.txe_numCuota.TabIndex = 12;
            // 
            // txe_ValorCuota
            // 
            this.txe_ValorCuota.Location = new System.Drawing.Point(123, 138);
            this.txe_ValorCuota.Name = "txe_ValorCuota";
            this.txe_ValorCuota.Properties.ReadOnly = true;
            this.txe_ValorCuota.Size = new System.Drawing.Size(100, 20);
            this.txe_ValorCuota.TabIndex = 13;
            // 
            // txe_Mon_x_Can
            // 
            this.txe_Mon_x_Can.Location = new System.Drawing.Point(123, 160);
            this.txe_Mon_x_Can.Name = "txe_Mon_x_Can";
            this.txe_Mon_x_Can.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txe_Mon_x_Can.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txe_Mon_x_Can.Size = new System.Drawing.Size(100, 20);
            this.txe_Mon_x_Can.TabIndex = 14;
            this.txe_Mon_x_Can.Validating += new System.ComponentModel.CancelEventHandler(this.txe_Mon_x_Can_Validating);
            // 
            // txe_SaldoPendiente
            // 
            this.txe_SaldoPendiente.Location = new System.Drawing.Point(123, 186);
            this.txe_SaldoPendiente.Name = "txe_SaldoPendiente";
            this.txe_SaldoPendiente.Properties.ReadOnly = true;
            this.txe_SaldoPendiente.Size = new System.Drawing.Size(100, 20);
            this.txe_SaldoPendiente.TabIndex = 15;
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(123, 212);
            this.txt_Observacion.Multiline = true;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(380, 26);
            this.txt_Observacion.TabIndex = 16;
            // 
            // dte_Fecha
            // 
            this.dte_Fecha.EditValue = null;
            this.dte_Fecha.Location = new System.Drawing.Point(123, 91);
            this.dte_Fecha.Name = "dte_Fecha";
            this.dte_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dte_Fecha.Size = new System.Drawing.Size(100, 20);
            this.dte_Fecha.TabIndex = 17;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 279);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(515, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(515, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Banco a debitar:";
            // 
            // cmb_banco
            // 
            this.cmb_banco.Location = new System.Drawing.Point(115, 246);
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.Size = new System.Drawing.Size(388, 27);
            this.cmb_banco.TabIndex = 19;
            // 
            // FrmBA_Cancelacion_Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 305);
            this.Controls.Add(this.cmb_banco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dte_Fecha);
            this.Controls.Add(this.txt_Observacion);
            this.Controls.Add(this.txe_SaldoPendiente);
            this.Controls.Add(this.txe_Mon_x_Can);
            this.Controls.Add(this.txe_ValorCuota);
            this.Controls.Add(this.txe_numCuota);
            this.Controls.Add(this.txe_Banco);
            this.Controls.Add(this.txe_IdPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmBA_Cancelacion_Cuotas";
            this.Text = "FrmBA_Cancelacion_Cuotas";
            this.Load += new System.EventHandler(this.FrmBA_Cancelacion_Cuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txe_IdPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_Banco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_numCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_ValorCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_Mon_x_Can.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txe_SaldoPendiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Fecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txe_IdPrestamo;
        private DevExpress.XtraEditors.TextEdit txe_Banco;
        private DevExpress.XtraEditors.TextEdit txe_numCuota;
        private DevExpress.XtraEditors.TextEdit txe_ValorCuota;
        private DevExpress.XtraEditors.TextEdit txe_Mon_x_Can;
        private DevExpress.XtraEditors.TextEdit txe_SaldoPendiente;
        private System.Windows.Forms.TextBox txt_Observacion;
        private DevExpress.XtraEditors.DateEdit dte_Fecha;
        private System.Windows.Forms.Label label9;
        private Controles.UCBa_CuentaBanco cmb_banco;
    }
}
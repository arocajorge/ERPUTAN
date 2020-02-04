namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_caj_Caja_Movimiento_Tipo
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
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSeDeposita = new System.Windows.Forms.CheckBox();
            this.ucCon_PlanCtaCmb1 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gBox_TipoMovimiento = new System.Windows.Forms.GroupBox();
            this.rB_Egreso = new System.Windows.Forms.RadioButton();
            this.rB_Ingreso = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Anulado = new System.Windows.Forms.Label();
            this.txt_idTipoMovi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1.SuspendLayout();
            this.gBox_TipoMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(455, 23);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 5;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSeDeposita);
            this.panel1.Controls.Add(this.ucCon_PlanCtaCmb1);
            this.panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel1.Controls.Add(this.gBox_TipoMovimiento);
            this.panel1.Controls.Add(this.chk_estado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Anulado);
            this.panel1.Controls.Add(this.txt_idTipoMovi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 234);
            this.panel1.TabIndex = 1;
            // 
            // chkSeDeposita
            // 
            this.chkSeDeposita.AutoSize = true;
            this.chkSeDeposita.Location = new System.Drawing.Point(373, 85);
            this.chkSeDeposita.Name = "chkSeDeposita";
            this.chkSeDeposita.Size = new System.Drawing.Size(141, 17);
            this.chkSeDeposita.TabIndex = 142;
            this.chkSeDeposita.Text = "Se Deposita en banco?.";
            this.chkSeDeposita.UseVisualStyleBackColor = true;
            // 
            // ucCon_PlanCtaCmb1
            // 
            this.ucCon_PlanCtaCmb1.Location = new System.Drawing.Point(113, 176);
            this.ucCon_PlanCtaCmb1.Name = "ucCon_PlanCtaCmb1";
            this.ucCon_PlanCtaCmb1.Size = new System.Drawing.Size(401, 28);
            this.ucCon_PlanCtaCmb1.TabIndex = 141;
            this.ucCon_PlanCtaCmb1.event_cmbPlanCta_EditValueChanged += new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb.delegate_cmbPlanCta_EditValueChanged(this.ucCon_PlanCtaCmb1_event_cmbPlanCta_EditValueChanged);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 208);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(665, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 140;
            // 
            // gBox_TipoMovimiento
            // 
            this.gBox_TipoMovimiento.Controls.Add(this.rB_Egreso);
            this.gBox_TipoMovimiento.Controls.Add(this.rB_Ingreso);
            this.gBox_TipoMovimiento.Location = new System.Drawing.Point(20, 23);
            this.gBox_TipoMovimiento.Name = "gBox_TipoMovimiento";
            this.gBox_TipoMovimiento.Size = new System.Drawing.Size(230, 46);
            this.gBox_TipoMovimiento.TabIndex = 0;
            this.gBox_TipoMovimiento.TabStop = false;
            this.gBox_TipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // rB_Egreso
            // 
            this.rB_Egreso.AutoSize = true;
            this.rB_Egreso.Location = new System.Drawing.Point(138, 19);
            this.rB_Egreso.Name = "rB_Egreso";
            this.rB_Egreso.Size = new System.Drawing.Size(70, 17);
            this.rB_Egreso.TabIndex = 1;
            this.rB_Egreso.Text = "EGRESO";
            this.rB_Egreso.UseVisualStyleBackColor = true;
            // 
            // rB_Ingreso
            // 
            this.rB_Ingreso.AutoSize = true;
            this.rB_Ingreso.Checked = true;
            this.rB_Ingreso.Location = new System.Drawing.Point(24, 19);
            this.rB_Ingreso.Name = "rB_Ingreso";
            this.rB_Ingreso.Size = new System.Drawing.Size(74, 17);
            this.rB_Ingreso.TabIndex = 0;
            this.rB_Ingreso.TabStop = true;
            this.rB_Ingreso.Text = "INGRESO";
            this.rB_Ingreso.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Cuenta Cble.:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(119, 117);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(395, 23);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // lb_Anulado
            // 
            this.lb_Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anulado.ForeColor = System.Drawing.Color.Red;
            this.lb_Anulado.Location = new System.Drawing.Point(281, 17);
            this.lb_Anulado.Name = "lb_Anulado";
            this.lb_Anulado.Size = new System.Drawing.Size(143, 27);
            this.lb_Anulado.TabIndex = 134;
            this.lb_Anulado.Text = "**ANULADO**";
            this.lb_Anulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Anulado.Visible = false;
            // 
            // txt_idTipoMovi
            // 
            this.txt_idTipoMovi.Location = new System.Drawing.Point(119, 86);
            this.txt_idTipoMovi.Name = "txt_idTipoMovi";
            this.txt_idTipoMovi.ReadOnly = true;
            this.txt_idTipoMovi.Size = new System.Drawing.Size(99, 20);
            this.txt_idTipoMovi.TabIndex = 2;
            this.txt_idTipoMovi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Tipo Movimiento:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(665, 29);
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
            // 
            // FrmCa_caj_Caja_Movimiento_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmCa_caj_Caja_Movimiento_Tipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Movimiento Caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCa_caj_Caja_Movimiento_Tipo_FormClosing);
            this.Load += new System.EventHandler(this.FrmCa_caj_Caja_Movimiento_Tipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBox_TipoMovimiento.ResumeLayout(false);
            this.gBox_TipoMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_estado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.GroupBox gBox_TipoMovimiento;
        private System.Windows.Forms.RadioButton rB_Egreso;
        private System.Windows.Forms.RadioButton rB_Ingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Anulado;
        private System.Windows.Forms.TextBox txt_idTipoMovi;
        private System.Windows.Forms.Label label1;
        private Controles.UCCon_PlanCtaCmb ucCon_PlanCtaCmb1;
        private System.Windows.Forms.CheckBox chkSeDeposita;
    }
}
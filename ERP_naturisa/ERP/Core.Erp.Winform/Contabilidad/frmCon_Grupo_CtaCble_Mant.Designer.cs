namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Grupo_CtaCble_Mant
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
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lblIdGrupoCtaCble = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdGrupCtaCble = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.spinNumeric = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxSumaRestaER = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEstadoFinanciero = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdGrupCtaCble.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSumaRestaER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEstadoFinanciero.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActivo
            // 
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(331, 35);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(70, 19);
            this.chkActivo.TabIndex = 98;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(320, 57);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(104, 16);
            this.lblAnulado.TabIndex = 97;
            this.lblAnulado.Text = "**ANULADO**";
            this.lblAnulado.Visible = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 228);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(477, 34);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 96;
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
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(477, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 95;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            // 
            // lblIdGrupoCtaCble
            // 
            this.lblIdGrupoCtaCble.Location = new System.Drawing.Point(21, 53);
            this.lblIdGrupoCtaCble.Name = "lblIdGrupoCtaCble";
            this.lblIdGrupoCtaCble.Size = new System.Drawing.Size(93, 13);
            this.lblIdGrupoCtaCble.TabIndex = 99;
            this.lblIdGrupoCtaCble.Text = "Id Grupo CtaCble  :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 100;
            this.labelControl2.Text = "Descripción Grupo :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 101;
            this.labelControl3.Text = "Orden de Grupo    :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 102;
            this.labelControl4.Text = "Estado Financiero :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 194);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(189, 13);
            this.labelControl5.TabIndex = 103;
            this.labelControl5.Text = "Suma o Resta al Estado de Resultado  :";
            // 
            // txtIdGrupCtaCble
            // 
            this.txtIdGrupCtaCble.Location = new System.Drawing.Point(126, 50);
            this.txtIdGrupCtaCble.Name = "txtIdGrupCtaCble";
            this.txtIdGrupCtaCble.Size = new System.Drawing.Size(189, 20);
            this.txtIdGrupCtaCble.TabIndex = 104;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(126, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(302, 20);
            this.txtDescripcion.TabIndex = 105;
            // 
            // spinNumeric
            // 
            this.spinNumeric.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNumeric.Location = new System.Drawing.Point(126, 124);
            this.spinNumeric.Name = "spinNumeric";
            this.spinNumeric.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinNumeric.Size = new System.Drawing.Size(158, 20);
            this.spinNumeric.TabIndex = 110;
            // 
            // comboBoxSumaRestaER
            // 
            this.comboBoxSumaRestaER.Location = new System.Drawing.Point(216, 191);
            this.comboBoxSumaRestaER.Name = "comboBoxSumaRestaER";
            this.comboBoxSumaRestaER.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxSumaRestaER.Properties.Items.AddRange(new object[] {
            "-1",
            " 1"});
            this.comboBoxSumaRestaER.Size = new System.Drawing.Size(68, 20);
            this.comboBoxSumaRestaER.TabIndex = 112;
            // 
            // comboBoxEstadoFinanciero
            // 
            this.comboBoxEstadoFinanciero.Location = new System.Drawing.Point(126, 158);
            this.comboBoxEstadoFinanciero.Name = "comboBoxEstadoFinanciero";
            this.comboBoxEstadoFinanciero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEstadoFinanciero.Properties.Items.AddRange(new object[] {
            "BG",
            "ER"});
            this.comboBoxEstadoFinanciero.Size = new System.Drawing.Size(158, 20);
            this.comboBoxEstadoFinanciero.TabIndex = 113;
            // 
            // frmCon_Grupo_CtaCble_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 262);
            this.Controls.Add(this.comboBoxEstadoFinanciero);
            this.Controls.Add(this.comboBoxSumaRestaER);
            this.Controls.Add(this.spinNumeric);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdGrupCtaCble);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblIdGrupoCtaCble);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblAnulado);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmCon_Grupo_CtaCble_Mant";
            this.Text = "frmCon_Grupo_CtaCble_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_Grupo_CtaCble_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_Grupo_CtaCble_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdGrupCtaCble.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxSumaRestaER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEstadoFinanciero.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.LabelControl lblIdGrupoCtaCble;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtIdGrupCtaCble;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.SpinEdit spinNumeric;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxSumaRestaER;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEstadoFinanciero;
    }
}
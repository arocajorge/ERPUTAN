namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Motivo_Inven_Mant
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCon_CtaCbleCosto = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.ucCon_CtaCble_Inven = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.chk_puntocargo = new System.Windows.Forms.CheckBox();
            this.chk_generacxp = new System.Windows.Forms.CheckBox();
            this.Anulado = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.chk_gen_movi_inv = new System.Windows.Forms.CheckBox();
            this.label_descri = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ucIn_Catalogos_Ing_Egr = new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb();
            this.ucIn_Catalogos_Inv_Consu = new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.ucCon_CtaCbleCosto);
            this.panelMain.Controls.Add(this.ucCon_CtaCble_Inven);
            this.panelMain.Controls.Add(this.chk_puntocargo);
            this.panelMain.Controls.Add(this.chk_generacxp);
            this.panelMain.Controls.Add(this.Anulado);
            this.panelMain.Controls.Add(this.chk_estado);
            this.panelMain.Controls.Add(this.chk_gen_movi_inv);
            this.panelMain.Controls.Add(this.label_descri);
            this.panelMain.Controls.Add(this.txt_descripcion);
            this.panelMain.Controls.Add(this.txt_codigo);
            this.panelMain.Controls.Add(this.label_codigo);
            this.panelMain.Controls.Add(this.txt_id);
            this.panelMain.Controls.Add(this.labelId);
            this.panelMain.Controls.Add(this.ucIn_Catalogos_Ing_Egr);
            this.panelMain.Controls.Add(this.ucIn_Catalogos_Inv_Consu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(812, 261);
            this.panelMain.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cta Cble Costo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cta Cble Inventario:";
            // 
            // ucCon_CtaCbleCosto
            // 
            this.ucCon_CtaCbleCosto.Location = new System.Drawing.Point(127, 219);
            this.ucCon_CtaCbleCosto.Name = "ucCon_CtaCbleCosto";
            this.ucCon_CtaCbleCosto.Size = new System.Drawing.Size(416, 26);
            this.ucCon_CtaCbleCosto.TabIndex = 12;
            // 
            // ucCon_CtaCble_Inven
            // 
            this.ucCon_CtaCble_Inven.Location = new System.Drawing.Point(128, 187);
            this.ucCon_CtaCble_Inven.Name = "ucCon_CtaCble_Inven";
            this.ucCon_CtaCble_Inven.Size = new System.Drawing.Size(415, 26);
            this.ucCon_CtaCble_Inven.TabIndex = 11;
            // 
            // chk_puntocargo
            // 
            this.chk_puntocargo.AutoSize = true;
            this.chk_puntocargo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_puntocargo.Location = new System.Drawing.Point(672, 154);
            this.chk_puntocargo.Name = "chk_puntocargo";
            this.chk_puntocargo.Size = new System.Drawing.Size(128, 17);
            this.chk_puntocargo.TabIndex = 10;
            this.chk_puntocargo.Text = "Exigir Punto de Cargo";
            this.chk_puntocargo.UseVisualStyleBackColor = true;
            this.chk_puntocargo.Visible = false;
            // 
            // chk_generacxp
            // 
            this.chk_generacxp.AutoSize = true;
            this.chk_generacxp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_generacxp.Location = new System.Drawing.Point(648, 131);
            this.chk_generacxp.Name = "chk_generacxp";
            this.chk_generacxp.Size = new System.Drawing.Size(152, 17);
            this.chk_generacxp.TabIndex = 9;
            this.chk_generacxp.Text = "Genera Cuentas por Pagar";
            this.chk_generacxp.UseVisualStyleBackColor = true;
            this.chk_generacxp.Visible = false;
            // 
            // Anulado
            // 
            this.Anulado.AutoSize = true;
            this.Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anulado.ForeColor = System.Drawing.Color.Red;
            this.Anulado.Location = new System.Drawing.Point(564, 22);
            this.Anulado.Name = "Anulado";
            this.Anulado.Size = new System.Drawing.Size(136, 20);
            this.Anulado.TabIndex = 8;
            this.Anulado.Text = "***ANULADO***";
            this.Anulado.Visible = false;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(744, 228);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 7;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // chk_gen_movi_inv
            // 
            this.chk_gen_movi_inv.AutoSize = true;
            this.chk_gen_movi_inv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_gen_movi_inv.Location = new System.Drawing.Point(617, 108);
            this.chk_gen_movi_inv.Name = "chk_gen_movi_inv";
            this.chk_gen_movi_inv.Size = new System.Drawing.Size(183, 17);
            this.chk_gen_movi_inv.TabIndex = 6;
            this.chk_gen_movi_inv.Text = "Genera Movimiento de Inventario";
            this.chk_gen_movi_inv.UseVisualStyleBackColor = true;
            // 
            // label_descri
            // 
            this.label_descri.AutoSize = true;
            this.label_descri.Location = new System.Drawing.Point(11, 65);
            this.label_descri.Name = "label_descri";
            this.label_descri.Size = new System.Drawing.Size(66, 13);
            this.label_descri.TabIndex = 5;
            this.label_descri.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(83, 62);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(460, 20);
            this.txt_descripcion.TabIndex = 4;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(324, 26);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(275, 29);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(43, 13);
            this.label_codigo.TabIndex = 2;
            this.label_codigo.Text = "Codigo:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(83, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "0";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 29);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(812, 29);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 290);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(812, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Donde se muestra este Motivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Esto es Un:";
            // 
            // ucIn_Catalogos_Ing_Egr
            // 
            this.ucIn_Catalogos_Ing_Egr.Location = new System.Drawing.Point(171, 96);
            this.ucIn_Catalogos_Ing_Egr.Name = "ucIn_Catalogos_Ing_Egr";
            this.ucIn_Catalogos_Ing_Egr.Size = new System.Drawing.Size(224, 29);
            this.ucIn_Catalogos_Ing_Egr.TabIndex = 19;
            this.ucIn_Catalogos_Ing_Egr.Visible_btn_acciones = false;
            this.ucIn_Catalogos_Ing_Egr.Load += new System.EventHandler(this.ucIn_Catalogos_Cmb1_Load);
            // 
            // ucIn_Catalogos_Inv_Consu
            // 
            this.ucIn_Catalogos_Inv_Consu.Location = new System.Drawing.Point(418, 96);
            this.ucIn_Catalogos_Inv_Consu.Name = "ucIn_Catalogos_Inv_Consu";
            this.ucIn_Catalogos_Inv_Consu.Size = new System.Drawing.Size(232, 29);
            this.ucIn_Catalogos_Inv_Consu.TabIndex = 20;
            this.ucIn_Catalogos_Inv_Consu.Visible_btn_acciones = false;
            // 
            // FrmIn_Motivo_Inven_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 316);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "FrmIn_Motivo_Inven_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Motivo de Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Motivo_Inven_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Motivo_Inven_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox chk_gen_movi_inv;
        private System.Windows.Forms.Label label_descri;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label Anulado;
        private System.Windows.Forms.CheckBox chk_puntocargo;
        private System.Windows.Forms.CheckBox chk_generacxp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.UCCon_PlanCtaCmb ucCon_CtaCbleCosto;
        private Controles.UCCon_PlanCtaCmb ucCon_CtaCble_Inven;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Controles.UCIn_Catalogos_Cmb ucIn_Catalogos_Ing_Egr;
        private Controles.UCIn_Catalogos_Cmb ucIn_Catalogos_Inv_Consu;
    }
}
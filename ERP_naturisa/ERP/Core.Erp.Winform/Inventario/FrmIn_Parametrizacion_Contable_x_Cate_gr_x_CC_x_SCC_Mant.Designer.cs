namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant
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
            this.ucin_cat_lin_gr_sgr = new Core.Erp.Winform.Controles.ucIn_Linea_Grup_SubGr();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucct_plancta = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.label3 = new System.Windows.Forms.Label();
            this.ucct_cc_scc = new Core.Erp.Winform.Controles.UCFa_Cliente_x_centro_costo_cmb();
            this.ucIn_ProductoCmb1 = new Core.Erp.Winform.Controles.UCIn_ProductoCmb();
            this.SuspendLayout();
            // 
            // ucin_cat_lin_gr_sgr
            // 
            this.ucin_cat_lin_gr_sgr.Location = new System.Drawing.Point(2, 70);
            this.ucin_cat_lin_gr_sgr.Name = "ucin_cat_lin_gr_sgr";
            this.ucin_cat_lin_gr_sgr.Size = new System.Drawing.Size(522, 122);
            this.ucin_cat_lin_gr_sgr.SubGrupoInfo = null;
            this.ucin_cat_lin_gr_sgr.TabIndex = 0;
            this.ucin_cat_lin_gr_sgr.Visible_Todos_cmb_Categoria = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(594, 29);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 308);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(594, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // ucct_plancta
            // 
            this.ucct_plancta.Location = new System.Drawing.Point(101, 240);
            this.ucct_plancta.Name = "ucct_plancta";
            this.ucct_plancta.Size = new System.Drawing.Size(461, 29);
            this.ucct_plancta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuenta Contable:";
            // 
            // ucct_cc_scc
            // 
            this.ucct_cc_scc.Enabled_BtnAccion_cc = true;
            this.ucct_cc_scc.Enabled_BtnAccion_cli = true;
            this.ucct_cc_scc.Enabled_BtnAccion_Scc = true;
            this.ucct_cc_scc.Enabled_cmb_Centro_costo = true;
            this.ucct_cc_scc.Enabled_cmb_Cliente = true;
            this.ucct_cc_scc.Location = new System.Drawing.Point(14, 166);
            this.ucct_cc_scc.Name = "ucct_cc_scc";
            this.ucct_cc_scc.ReadOnly_cmb_Centro_costo = false;
            this.ucct_cc_scc.ReadOnly_cmb_Cliente = false;
            this.ucct_cc_scc.ReadOnly_cmb_Subcentro_costo = false;
            this.ucct_cc_scc.Size = new System.Drawing.Size(557, 76);
            this.ucct_cc_scc.TabIndex = 9;
            this.ucct_cc_scc.Visible_BtnAccion_cc = true;
            this.ucct_cc_scc.Visible_BtnAccion_cli = false;
            this.ucct_cc_scc.Visible_btnAccion_Scc = true;
            this.ucct_cc_scc.Visible_cmb_Centro_costo = true;
            this.ucct_cc_scc.Visible_cmb_Cliente = false;
            this.ucct_cc_scc.Visible_cmb_Subcentro_costo = true;
            this.ucct_cc_scc.Visible_lblCentro_costo = true;
            this.ucct_cc_scc.Visible_lblCliente = false;
            this.ucct_cc_scc.Visible_lblSub_centro_costo = true;
            // 
            // ucIn_ProductoCmb1
            // 
            this.ucIn_ProductoCmb1.Location = new System.Drawing.Point(16, 32);
            this.ucIn_ProductoCmb1.Name = "ucIn_ProductoCmb1";
            this.ucIn_ProductoCmb1.Size = new System.Drawing.Size(553, 26);
            this.ucIn_ProductoCmb1.TabIndex = 10;
            this.ucIn_ProductoCmb1.event_cmb_producto_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_ProductoCmb.delegate_cmb_producto_EditValueChanged(this.ucIn_ProductoCmb1_event_cmb_producto_EditValueChanged);
            // 
            // FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 334);
            this.Controls.Add(this.ucIn_ProductoCmb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucct_plancta);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucin_cat_lin_gr_sgr);
            this.Controls.Add(this.ucct_cc_scc);
            this.Name = "FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrización contable de categoria, linea, grupo, subgrupo, centro y subcentro" +
    " de costo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ucIn_Linea_Grup_SubGr ucin_cat_lin_gr_sgr;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento ucct_plancta;
        private System.Windows.Forms.Label label3;
        private Controles.UCFa_Cliente_x_centro_costo_cmb ucct_cc_scc;
        private Controles.UCIn_ProductoCmb ucIn_ProductoCmb1;
    }
}
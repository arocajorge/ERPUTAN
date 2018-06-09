namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_GrupoEmpresarial_grupocble
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orden = new System.Windows.Forms.NumericUpDown();
            this.cmb_estadoFinanciero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opt_resta = new System.Windows.Forms.RadioButton();
            this.opt_suma = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txt_orden)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(110, 36);
            this.txt_id.MaxLength = 5;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(104, 20);
            this.txt_id.TabIndex = 49;
            // 
            // txt_grupo
            // 
            this.txt_grupo.Location = new System.Drawing.Point(110, 62);
            this.txt_grupo.MaxLength = 50;
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(297, 20);
            this.txt_grupo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Grupo Contable";
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(110, 88);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(44, 20);
            this.txt_orden.TabIndex = 52;
            // 
            // cmb_estadoFinanciero
            // 
            this.cmb_estadoFinanciero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estadoFinanciero.FormattingEnabled = true;
            this.cmb_estadoFinanciero.Items.AddRange(new object[] {
            "Balance General",
            "Estado de Resultado"});
            this.cmb_estadoFinanciero.Location = new System.Drawing.Point(110, 113);
            this.cmb_estadoFinanciero.Name = "cmb_estadoFinanciero";
            this.cmb_estadoFinanciero.Size = new System.Drawing.Size(124, 21);
            this.cmb_estadoFinanciero.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Estado Financiero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt_resta);
            this.groupBox2.Controls.Add(this.opt_suma);
            this.groupBox2.Location = new System.Drawing.Point(18, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 38);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operación ";
            // 
            // opt_resta
            // 
            this.opt_resta.AutoSize = true;
            this.opt_resta.Location = new System.Drawing.Point(125, 15);
            this.opt_resta.Name = "opt_resta";
            this.opt_resta.Size = new System.Drawing.Size(53, 17);
            this.opt_resta.TabIndex = 7;
            this.opt_resta.Text = "Resta";
            this.opt_resta.UseVisualStyleBackColor = true;
            // 
            // opt_suma
            // 
            this.opt_suma.AutoSize = true;
            this.opt_suma.Checked = true;
            this.opt_suma.Location = new System.Drawing.Point(38, 15);
            this.opt_suma.Name = "opt_suma";
            this.opt_suma.Size = new System.Drawing.Size(52, 17);
            this.opt_suma.TabIndex = 6;
            this.opt_suma.TabStop = true;
            this.opt_suma.Text = "Suma";
            this.opt_suma.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Orden";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(420, 29);
            this.ucGe_Menu.TabIndex = 57;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
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
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // frmCon_GrupoEmpresarial_grupocble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 189);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_estadoFinanciero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.txt_grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "frmCon_GrupoEmpresarial_grupocble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Contable del Grupo Empresarial";
            this.Load += new System.EventHandler(this.frmCon_GrupoEmpresarial_grupocble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_orden)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_orden;
        private System.Windows.Forms.ComboBox cmb_estadoFinanciero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt_resta;
        private System.Windows.Forms.RadioButton opt_suma;
        private System.Windows.Forms.Label label3;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}
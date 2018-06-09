namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Presentacion_Mant
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
            this.groupBoxCatalogo = new System.Windows.Forms.GroupBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lb_nombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.Lb_IdCatalogo = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBoxCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCatalogo
            // 
            this.groupBoxCatalogo.Controls.Add(this.lblAnulado);
            this.groupBoxCatalogo.Controls.Add(this.ckbActivo);
            this.groupBoxCatalogo.Controls.Add(this.txt_nombre);
            this.groupBoxCatalogo.Controls.Add(this.Lb_nombre);
            this.groupBoxCatalogo.Controls.Add(this.txt_codigo);
            this.groupBoxCatalogo.Controls.Add(this.Lb_IdCatalogo);
            this.groupBoxCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCatalogo.Location = new System.Drawing.Point(0, 29);
            this.groupBoxCatalogo.Name = "groupBoxCatalogo";
            this.groupBoxCatalogo.Size = new System.Drawing.Size(554, 161);
            this.groupBoxCatalogo.TabIndex = 3;
            this.groupBoxCatalogo.TabStop = false;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(273, 103);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(127, 20);
            this.lblAnulado.TabIndex = 16;
            this.lblAnulado.Text = "*** Anulado ***";
            this.lblAnulado.Visible = false;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Checked = true;
            this.ckbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActivo.Enabled = false;
            this.ckbActivo.Location = new System.Drawing.Point(108, 103);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(56, 17);
            this.ckbActivo.TabIndex = 15;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(139, 55);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(348, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // Lb_nombre
            // 
            this.Lb_nombre.AutoSize = true;
            this.Lb_nombre.Location = new System.Drawing.Point(21, 58);
            this.Lb_nombre.Name = "Lb_nombre";
            this.Lb_nombre.Size = new System.Drawing.Size(112, 13);
            this.Lb_nombre.TabIndex = 4;
            this.Lb_nombre.Text = "Nombre Presentacion:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(139, 19);
            this.txt_codigo.MaxLength = 15;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(153, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // Lb_IdCatalogo
            // 
            this.Lb_IdCatalogo.AutoSize = true;
            this.Lb_IdCatalogo.Location = new System.Drawing.Point(21, 22);
            this.Lb_IdCatalogo.Name = "Lb_IdCatalogo";
            this.Lb_IdCatalogo.Size = new System.Drawing.Size(43, 13);
            this.Lb_IdCatalogo.TabIndex = 2;
            this.Lb_IdCatalogo.Text = "Codigo:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(554, 29);
            this.ucGe_Menu.TabIndex = 2;
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
            // FrmIn_Presentacion_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 190);
            this.Controls.Add(this.groupBoxCatalogo);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Presentacion_Mant";
            this.Text = "FrmIn_Presentacion_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Presentacion_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Presentacion_Mant_Load);
            this.groupBoxCatalogo.ResumeLayout(false);
            this.groupBoxCatalogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCatalogo;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Lb_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label Lb_IdCatalogo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}
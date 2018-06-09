namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Catalogo_Tipo_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBoxCatalogoTipo = new System.Windows.Forms.GroupBox();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Lb_descripcion = new System.Windows.Forms.Label();
            this.txtIdCatalogo_tipo = new System.Windows.Forms.TextBox();
            this.Lb_IdCatalogo_tipo = new System.Windows.Forms.Label();
            this.groupBoxCatalogoTipo.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(429, 29);
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
            // 
            // groupBoxCatalogoTipo
            // 
            this.groupBoxCatalogoTipo.Controls.Add(this.ckbActivo);
            this.groupBoxCatalogoTipo.Controls.Add(this.txt_descripcion);
            this.groupBoxCatalogoTipo.Controls.Add(this.Lb_descripcion);
            this.groupBoxCatalogoTipo.Controls.Add(this.txtIdCatalogo_tipo);
            this.groupBoxCatalogoTipo.Controls.Add(this.Lb_IdCatalogo_tipo);
            this.groupBoxCatalogoTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCatalogoTipo.Location = new System.Drawing.Point(0, 29);
            this.groupBoxCatalogoTipo.Name = "groupBoxCatalogoTipo";
            this.groupBoxCatalogoTipo.Size = new System.Drawing.Size(429, 130);
            this.groupBoxCatalogoTipo.TabIndex = 2;
            this.groupBoxCatalogoTipo.TabStop = false;
            this.groupBoxCatalogoTipo.Text = "Datos Tipo de Catalogo";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Checked = true;
            this.ckbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActivo.Enabled = false;
            this.ckbActivo.Location = new System.Drawing.Point(105, 105);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(56, 17);
            this.ckbActivo.TabIndex = 15;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(105, 65);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(302, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // Lb_descripcion
            // 
            this.Lb_descripcion.AutoSize = true;
            this.Lb_descripcion.Location = new System.Drawing.Point(18, 68);
            this.Lb_descripcion.Name = "Lb_descripcion";
            this.Lb_descripcion.Size = new System.Drawing.Size(66, 13);
            this.Lb_descripcion.TabIndex = 4;
            this.Lb_descripcion.Text = "Descripcion:";
            // 
            // txtIdCatalogo_tipo
            // 
            this.txtIdCatalogo_tipo.Enabled = false;
            this.txtIdCatalogo_tipo.Location = new System.Drawing.Point(105, 24);
            this.txtIdCatalogo_tipo.Name = "txtIdCatalogo_tipo";
            this.txtIdCatalogo_tipo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCatalogo_tipo.TabIndex = 1;
            // 
            // Lb_IdCatalogo_tipo
            // 
            this.Lb_IdCatalogo_tipo.AutoSize = true;
            this.Lb_IdCatalogo_tipo.Location = new System.Drawing.Point(18, 27);
            this.Lb_IdCatalogo_tipo.Name = "Lb_IdCatalogo_tipo";
            this.Lb_IdCatalogo_tipo.Size = new System.Drawing.Size(85, 13);
            this.Lb_IdCatalogo_tipo.TabIndex = 0;
            this.Lb_IdCatalogo_tipo.Text = "IdCatalogo Tipo:";
            // 
            // FrmIn_Catalogo_Tipo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 159);
            this.Controls.Add(this.groupBoxCatalogoTipo);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Catalogo_Tipo_Mant";
            this.Text = "FrmIn_Catalogo_Tipo_Mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Catalogo_Tipo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Catalogo_Tipo_Mant_Load);
            this.groupBoxCatalogoTipo.ResumeLayout(false);
            this.groupBoxCatalogoTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBoxCatalogoTipo;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label Lb_descripcion;
        public System.Windows.Forms.TextBox txtIdCatalogo_tipo;
        private System.Windows.Forms.Label Lb_IdCatalogo_tipo;
    }
}
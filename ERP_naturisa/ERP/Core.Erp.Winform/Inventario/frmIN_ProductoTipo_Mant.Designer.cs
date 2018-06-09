namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_ProductoTipo_Mant
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
            this.groupBoxTipoProduc = new System.Windows.Forms.GroupBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_ProductoTerminado = new System.Windows.Forms.CheckBox();
            this.chk_MateriaPrima = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_escombo = new System.Windows.Forms.CheckBox();
            this.chk_maneja_inventario = new System.Windows.Forms.CheckBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.txtIdProductoTipo = new DevExpress.XtraEditors.TextEdit();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBoxTipoProduc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductoTipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoProduc
            // 
            this.groupBoxTipoProduc.Controls.Add(this.lblAnulado);
            this.groupBoxTipoProduc.Controls.Add(this.label3);
            this.groupBoxTipoProduc.Controls.Add(this.chk_ProductoTerminado);
            this.groupBoxTipoProduc.Controls.Add(this.chk_MateriaPrima);
            this.groupBoxTipoProduc.Controls.Add(this.groupBox1);
            this.groupBoxTipoProduc.Controls.Add(this.txtIdProductoTipo);
            this.groupBoxTipoProduc.Controls.Add(this.txt_descripcion);
            this.groupBoxTipoProduc.Controls.Add(this.label2);
            this.groupBoxTipoProduc.Controls.Add(this.label1);
            this.groupBoxTipoProduc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTipoProduc.Location = new System.Drawing.Point(0, 29);
            this.groupBoxTipoProduc.Name = "groupBoxTipoProduc";
            this.groupBoxTipoProduc.Size = new System.Drawing.Size(552, 216);
            this.groupBoxTipoProduc.TabIndex = 1;
            this.groupBoxTipoProduc.TabStop = false;
            this.groupBoxTipoProduc.Text = "Datos Tipo de Producto";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(361, 17);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(127, 20);
            this.lblAnulado.TabIndex = 17;
            this.lblAnulado.Text = "*** Anulado ***";
            this.lblAnulado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo:";
            // 
            // chk_ProductoTerminado
            // 
            this.chk_ProductoTerminado.AutoSize = true;
            this.chk_ProductoTerminado.Location = new System.Drawing.Point(236, 85);
            this.chk_ProductoTerminado.Name = "chk_ProductoTerminado";
            this.chk_ProductoTerminado.Size = new System.Drawing.Size(122, 17);
            this.chk_ProductoTerminado.TabIndex = 15;
            this.chk_ProductoTerminado.Text = "Producto Terminado";
            this.chk_ProductoTerminado.UseVisualStyleBackColor = true;
            this.chk_ProductoTerminado.CheckedChanged += new System.EventHandler(this.chk_ProductoTerminado_CheckedChanged);
            // 
            // chk_MateriaPrima
            // 
            this.chk_MateriaPrima.AutoSize = true;
            this.chk_MateriaPrima.Location = new System.Drawing.Point(116, 85);
            this.chk_MateriaPrima.Name = "chk_MateriaPrima";
            this.chk_MateriaPrima.Size = new System.Drawing.Size(90, 17);
            this.chk_MateriaPrima.TabIndex = 14;
            this.chk_MateriaPrima.Text = "Materia Prima";
            this.chk_MateriaPrima.UseVisualStyleBackColor = true;
            this.chk_MateriaPrima.CheckedChanged += new System.EventHandler(this.chk_MateriaPrima_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_escombo);
            this.groupBox1.Controls.Add(this.chk_maneja_inventario);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Location = new System.Drawing.Point(85, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // chk_escombo
            // 
            this.chk_escombo.AutoSize = true;
            this.chk_escombo.Location = new System.Drawing.Point(31, 30);
            this.chk_escombo.Name = "chk_escombo";
            this.chk_escombo.Size = new System.Drawing.Size(88, 17);
            this.chk_escombo.TabIndex = 9;
            this.chk_escombo.Text = "Es un combo";
            this.chk_escombo.UseVisualStyleBackColor = true;
            // 
            // chk_maneja_inventario
            // 
            this.chk_maneja_inventario.AutoSize = true;
            this.chk_maneja_inventario.Location = new System.Drawing.Point(151, 30);
            this.chk_maneja_inventario.Name = "chk_maneja_inventario";
            this.chk_maneja_inventario.Size = new System.Drawing.Size(111, 17);
            this.chk_maneja_inventario.TabIndex = 10;
            this.chk_maneja_inventario.Text = "Maneja Inventario";
            this.chk_maneja_inventario.UseVisualStyleBackColor = true;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Checked = true;
            this.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_estado.Location = new System.Drawing.Point(31, 63);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 11;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // txtIdProductoTipo
            // 
            this.txtIdProductoTipo.Enabled = false;
            this.txtIdProductoTipo.Location = new System.Drawing.Point(116, 17);
            this.txtIdProductoTipo.Name = "txtIdProductoTipo";
            this.txtIdProductoTipo.Size = new System.Drawing.Size(98, 20);
            this.txtIdProductoTipo.TabIndex = 12;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(116, 50);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(242, 20);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Tipo Producto:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(552, 29);
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
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // frmIn_ProductoTipo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 245);
            this.Controls.Add(this.groupBoxTipoProduc);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmIn_ProductoTipo_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Tipo de Producto ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_ProductoTipo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_ProductoTipo_Mant_Load);
            this.groupBoxTipoProduc.ResumeLayout(false);
            this.groupBoxTipoProduc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductoTipo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBoxTipoProduc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_ProductoTerminado;
        private System.Windows.Forms.CheckBox chk_MateriaPrima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_escombo;
        private System.Windows.Forms.CheckBox chk_maneja_inventario;
        private System.Windows.Forms.CheckBox chk_estado;
        private DevExpress.XtraEditors.TextEdit txtIdProductoTipo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnulado;

    }
}
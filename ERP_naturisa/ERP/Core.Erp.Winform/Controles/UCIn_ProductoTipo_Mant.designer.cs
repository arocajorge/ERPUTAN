namespace Core.Erp.Winform.Controles
{
    partial class UCIn_ProductoTipo_Mant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIn_ProductoTipo_Mant));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.chk_maneja_inventario = new System.Windows.Forms.CheckBox();
            this.chk_escombo = new System.Windows.Forms.CheckBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_idProductoTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_grabar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_SaveExit = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.chk_maneja_inventario);
            this.groupBox1.Controls.Add(this.chk_escombo);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.lbl_idProductoTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(115, 144);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 4;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // chk_maneja_inventario
            // 
            this.chk_maneja_inventario.AutoSize = true;
            this.chk_maneja_inventario.Location = new System.Drawing.Point(219, 111);
            this.chk_maneja_inventario.Name = "chk_maneja_inventario";
            this.chk_maneja_inventario.Size = new System.Drawing.Size(111, 17);
            this.chk_maneja_inventario.TabIndex = 3;
            this.chk_maneja_inventario.Text = "Maneja Inventario";
            this.chk_maneja_inventario.UseVisualStyleBackColor = true;
            // 
            // chk_escombo
            // 
            this.chk_escombo.AutoSize = true;
            this.chk_escombo.Location = new System.Drawing.Point(115, 111);
            this.chk_escombo.Name = "chk_escombo";
            this.chk_escombo.Size = new System.Drawing.Size(88, 17);
            this.chk_escombo.TabIndex = 2;
            this.chk_escombo.Text = "Es un combo";
            this.chk_escombo.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(115, 76);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(242, 20);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // lbl_idProductoTipo
            // 
            this.lbl_idProductoTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_idProductoTipo.Location = new System.Drawing.Point(115, 42);
            this.lbl_idProductoTipo.Name = "lbl_idProductoTipo";
            this.lbl_idProductoTipo.Size = new System.Drawing.Size(100, 23);
            this.lbl_idProductoTipo.TabIndex = 0;
            this.lbl_idProductoTipo.Text = "0";
            this.lbl_idProductoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_idProductoTipo.Click += new System.EventHandler(this.lbl_idProductoTipo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Tipo Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_grabar,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btn_SaveExit,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(68, 22);
            this.btn_grabar.Text = "Aceptar";
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 22);
            this.toolStripButton1.Text = "Grabar y Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_SaveExit
            // 
            this.btn_SaveExit.Name = "btn_SaveExit";
            this.btn_SaveExit.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // UCIn_ProductoTipo_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCIn_ProductoTipo_Mant";
            this.Size = new System.Drawing.Size(400, 213);
            this.Load += new System.EventHandler(this.UCInv_ProductoTipo_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_idProductoTipo;
        private System.Windows.Forms.CheckBox chk_maneja_inventario;
        private System.Windows.Forms.CheckBox chk_escombo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_grabar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator btn_SaveExit;
    }
}

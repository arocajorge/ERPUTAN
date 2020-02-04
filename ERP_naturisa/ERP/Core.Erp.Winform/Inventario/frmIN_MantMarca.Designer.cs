namespace Core.Erp.Winform.Inventario
{


    partial class frmIN_MantMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIN_MantMarca));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ok = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.IdMarca = new System.Windows.Forms.Label();
            this.txt_idMarca = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrabarySalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ok,
            this.btnGrabarySalir,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(105, 22);
            this.btn_ok.Text = "toolStripButton1";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(47, 22);
            this.btn_salir.Text = "&Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // IdMarca
            // 
            this.IdMarca.AutoSize = true;
            this.IdMarca.Location = new System.Drawing.Point(13, 53);
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.Size = new System.Drawing.Size(52, 13);
            this.IdMarca.TabIndex = 24;
            this.IdMarca.Text = "IdMarca: ";
            // 
            // txt_idMarca
            // 
            this.txt_idMarca.Location = new System.Drawing.Point(80, 50);
            this.txt_idMarca.Name = "txt_idMarca";
            this.txt_idMarca.ReadOnly = true;
            this.txt_idMarca.Size = new System.Drawing.Size(100, 20);
            this.txt_idMarca.TabIndex = 3;
            this.txt_idMarca.Text = "0";
            this.txt_idMarca.TextChanged += new System.EventHandler(this.txt_idMarca_TextChanged_1);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(79, 89);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(324, 26);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descripción: ";
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(80, 132);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(15, 14);
            this.chk_estado.TabIndex = 2;
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Estado:";
            // 
            // btnGrabarySalir
            // 
            this.btnGrabarySalir.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabarySalir.Image")));
            this.btnGrabarySalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrabarySalir.Name = "btnGrabarySalir";
            this.btnGrabarySalir.Size = new System.Drawing.Size(92, 22);
            this.btnGrabarySalir.Text = "Grabar y Salir";
            this.btnGrabarySalir.Click += new System.EventHandler(this.btnGrabarySalir_Click);
            // 
            // frmIN_MantMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idMarca);
            this.Controls.Add(this.IdMarca);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmIN_MantMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Marca";
            this.Load += new System.EventHandler(this.frmIN_MantMarca_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ok;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Label IdMarca;
        private System.Windows.Forms.TextBox txt_idMarca;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnGrabarySalir;
    }
}
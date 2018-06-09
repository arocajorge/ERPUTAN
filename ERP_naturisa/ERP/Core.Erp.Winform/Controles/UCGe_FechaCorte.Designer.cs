namespace Core.Erp.Winform.Controles
{
    partial class UCGe_FechaCorte
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTFechaCorte = new System.Windows.Forms.DateTimePicker();
            this.btn_generar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTFechaCorte);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 59);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte a la Fecha de Corte:";
            // 
            // dTFechaCorte
            // 
            this.dTFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTFechaCorte.Location = new System.Drawing.Point(215, 23);
            this.dTFechaCorte.Name = "dTFechaCorte";
            this.dTFechaCorte.Size = new System.Drawing.Size(89, 20);
            this.dTFechaCorte.TabIndex = 2;
            this.dTFechaCorte.ValueChanged += new System.EventHandler(this.dTFechaCorte_ValueChanged);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(358, 17);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(103, 28);
            this.btn_generar.TabIndex = 1;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // UCGe_FechaCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCGe_FechaCorte";
            this.Size = new System.Drawing.Size(550, 59);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generar;
        public System.Windows.Forms.DateTimePicker dTFechaCorte;
    }
}

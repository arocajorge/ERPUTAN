namespace Core.Erp.Winform.Controles
{
    partial class UCGe_rango_fechas
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
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechaFin = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(89, 11);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(90, 20);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha Inicio:";
            // 
            // dtfechaFin
            // 
            this.dtfechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaFin.Location = new System.Drawing.Point(89, 49);
            this.dtfechaFin.Name = "dtfechaFin";
            this.dtfechaFin.Size = new System.Drawing.Size(90, 20);
            this.dtfechaFin.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha Fin:";
            // 
            // UCGe_rango_fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtfechaFin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFechaInicio);
            this.Name = "UCGe_rango_fechas";
            this.Size = new System.Drawing.Size(214, 87);
            this.Load += new System.EventHandler(this.UCGe_rango_fechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtFechaInicio;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.DateTimePicker dtfechaFin;
        public DevExpress.XtraEditors.LabelControl labelControl2;

    }
}

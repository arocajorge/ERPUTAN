namespace Core.Erp.Winform.Controles
{
    partial class UCCp_TipoCtaBancaria_cmb
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
            this.cmb_TipoGasto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_TipoGasto
            // 
            this.cmb_TipoGasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_TipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoGasto.FormattingEnabled = true;
            this.cmb_TipoGasto.Location = new System.Drawing.Point(0, 0);
            this.cmb_TipoGasto.Name = "cmb_TipoGasto";
            this.cmb_TipoGasto.Size = new System.Drawing.Size(208, 21);
            this.cmb_TipoGasto.TabIndex = 1;
            this.cmb_TipoGasto.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoGasto_SelectedIndexChanged);
            // 
            // UCCp_TipoCtaBancaria_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_TipoGasto);
            this.Name = "UCCp_TipoCtaBancaria_cmb";
            this.Size = new System.Drawing.Size(208, 22);
            this.Load += new System.EventHandler(this.UCCp_Catalogo_x_Tipo_cmb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TipoGasto;
    }
}

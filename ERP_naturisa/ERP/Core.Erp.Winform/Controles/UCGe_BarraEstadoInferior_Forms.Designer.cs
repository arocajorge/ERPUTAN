namespace Core.Erp.Winform.Controles
{
    partial class UCGe_BarraEstadoInferior_Forms
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblespacio1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblempresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblespacio2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblespacio3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblusuario,
            this.lblespacio1,
            this.lblempresa,
            this.lblespacio2,
            this.lblNombreSys,
            this.lblespacio3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblusuario
            // 
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(86, 21);
            this.lblusuario.Text = "Usuario:admin";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // lblespacio1
            // 
            this.lblespacio1.Name = "lblespacio1";
            this.lblespacio1.Size = new System.Drawing.Size(16, 21);
            this.lblespacio1.Text = "   ";
            // 
            // lblempresa
            // 
            this.lblempresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblempresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(94, 21);
            this.lblempresa.Text = "Empresa: Talme";
            // 
            // lblespacio2
            // 
            this.lblespacio2.Name = "lblespacio2";
            this.lblespacio2.Size = new System.Drawing.Size(16, 21);
            this.lblespacio2.Text = "   ";
            // 
            // lblNombreSys
            // 
            this.lblNombreSys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreSys.Name = "lblNombreSys";
            this.lblNombreSys.Size = new System.Drawing.Size(63, 21);
            this.lblNombreSys.Text = "Vzen V1.0";
            this.lblNombreSys.Click += new System.EventHandler(this.lblNombreSys_Click);
            // 
            // lblespacio3
            // 
            this.lblespacio3.Name = "lblespacio3";
            this.lblespacio3.Size = new System.Drawing.Size(16, 21);
            this.lblespacio3.Text = "   ";
            // 
            // UCGe_BarraEstadoInferior_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.statusStrip1);
            this.Name = "UCGe_BarraEstadoInferior_Forms";
            this.Size = new System.Drawing.Size(506, 26);
            this.Load += new System.EventHandler(this.UCGe_BarraEstadoInferior_Forms_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblusuario;
        private System.Windows.Forms.ToolStripStatusLabel lblespacio1;
        private System.Windows.Forms.ToolStripStatusLabel lblempresa;
        private System.Windows.Forms.ToolStripStatusLabel lblespacio2;
        private System.Windows.Forms.ToolStripStatusLabel lblNombreSys;
        private System.Windows.Forms.ToolStripStatusLabel lblespacio3;
    }
}

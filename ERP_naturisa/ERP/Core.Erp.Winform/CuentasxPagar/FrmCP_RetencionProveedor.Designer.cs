namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_RetencionProveedor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Aplicar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ucCp_Retencion1 = new Core.Erp.Winform.Controles.UCCp_Retencion();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Aplicar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton_Salir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Aplicar
            // 
            this.toolStripButton_Aplicar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.toolStripButton_Aplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Aplicar.Name = "toolStripButton_Aplicar";
            this.toolStripButton_Aplicar.Size = new System.Drawing.Size(131, 22);
            this.toolStripButton_Aplicar.Text = "Aplicar Retenciones";
            this.toolStripButton_Aplicar.Click += new System.EventHandler(this.toolStripButton_Aplicar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 22);
            this.toolStripLabel1.Text = "                                                 ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Salir
            // 
            this.toolStripButton_Salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.toolStripButton_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Salir.Name = "toolStripButton_Salir";
            this.toolStripButton_Salir.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton_Salir.Text = "&Salir";
            this.toolStripButton_Salir.Click += new System.EventHandler(this.toolStripButton_Salir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(599, 22);
            this.toolStripLabel2.Text = "                                                                                 " +
    "                                                                                " +
    "        V 05092013 1001";
            // 
            // ucCp_Retencion1
            // 
            this.ucCp_Retencion1.Location = new System.Drawing.Point(12, 28);
            this.ucCp_Retencion1.Name = "ucCp_Retencion1";
            this.ucCp_Retencion1.Size = new System.Drawing.Size(817, 239);
            this.ucCp_Retencion1.TabIndex = 3;
            // 
            // frmCP_RetencionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 290);
            this.ControlBox = false;
            this.Controls.Add(this.ucCp_Retencion1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCP_RetencionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retención del Proveedor";
            this.Load += new System.EventHandler(this.FrmCP_RetencionProveedor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Aplicar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private Controles.UCCp_Retencion ucCp_Retencion1;

    }
}
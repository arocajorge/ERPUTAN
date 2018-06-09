namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_Duplica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_Duplica));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btn_dulpicar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_salir = new System.Windows.Forms.ToolStripButton();
            this.PanelObra = new System.Windows.Forms.Panel();
            this.lbObra = new System.Windows.Forms.Label();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nuevo Modelo Produccion:";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_dulpicar,
            this.toolStripSeparator2,
            this.mnu_salir});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(505, 25);
            this.toolStripMain.TabIndex = 34;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btn_dulpicar
            // 
            this.btn_dulpicar.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btn_dulpicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_dulpicar.Name = "btn_dulpicar";
            this.btn_dulpicar.Size = new System.Drawing.Size(71, 22);
            this.btn_dulpicar.Text = "Duplicar";
            this.btn_dulpicar.Click += new System.EventHandler(this.btn_dulpicar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_salir
            // 
            this.mnu_salir.Image = ((System.Drawing.Image)(resources.GetObject("mnu_salir.Image")));
            this.mnu_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_salir.Name = "mnu_salir";
            this.mnu_salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_salir.Text = "&Salir";
            this.mnu_salir.Click += new System.EventHandler(this.mnu_salir_Click);
            // 
            // PanelObra
            // 
            this.PanelObra.Location = new System.Drawing.Point(142, 54);
            this.PanelObra.Name = "PanelObra";
            this.PanelObra.Size = new System.Drawing.Size(319, 24);
            this.PanelObra.TabIndex = 60;
            // 
            // lbObra
            // 
            this.lbObra.AutoSize = true;
            this.lbObra.Location = new System.Drawing.Point(26, 54);
            this.lbObra.Name = "lbObra";
            this.lbObra.Size = new System.Drawing.Size(30, 13);
            this.lbObra.TabIndex = 61;
            this.lbObra.Text = "Obra";
            // 
            // FrmPrd_Duplica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 100);
            this.Controls.Add(this.lbObra);
            this.Controls.Add(this.PanelObra);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmPrd_Duplica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicar";
            this.Load += new System.EventHandler(this.FrmPrd_Duplica_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btn_dulpicar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnu_salir;
        private System.Windows.Forms.Panel PanelObra;
        private System.Windows.Forms.Label lbObra;
    }
}
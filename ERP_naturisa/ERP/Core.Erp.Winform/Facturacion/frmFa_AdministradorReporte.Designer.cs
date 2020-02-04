namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_AdministradorReporte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Admin = new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 526);
            this.panel1.TabIndex = 0;
            // 
            // ucGe_Admin
            // 
            this.ucGe_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Admin.FormMain = null;
            this.ucGe_Admin.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Admin.Name = "ucGe_Admin";
            this.ucGe_Admin.Size = new System.Drawing.Size(990, 526);
            this.ucGe_Admin.TabIndex = 0;
            this.ucGe_Admin.event_ucGe_Menu_event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_ucGe_Menu_event_btnSalir_ItemClick(this.ucGe_Admin_event_ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Admin.Load += new System.EventHandler(this.ucGe_Admin_Load);
            // 
            // frmFa_AdministradorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 526);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_AdministradorReporte";
            this.Text = "frmFa_AdministradorReporte";
            this.Load += new System.EventHandler(this.frmFa_AdministradorReporte_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Administrador_Reporte ucGe_Admin;
    }
}
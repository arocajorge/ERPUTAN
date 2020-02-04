namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_AutorizacionProveedor
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
            this.components = new System.ComponentModel.Container();
            this.cpproveedorAutorizacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uccP_Proveedor_Autoriza1 = new Core.Erp.Winform.Controles.UCCP_Proveedor_Autoriza();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorAutorizacionInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpproveedorAutorizacionInfoBindingSource
            // 
            this.cpproveedorAutorizacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Autorizacion_Info);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uccP_Proveedor_Autoriza1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 313);
            this.panel1.TabIndex = 4;
            // 
            // uccP_Proveedor_Autoriza1
            // 
            this.uccP_Proveedor_Autoriza1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uccP_Proveedor_Autoriza1.Location = new System.Drawing.Point(0, 0);
            this.uccP_Proveedor_Autoriza1.Name = "uccP_Proveedor_Autoriza1";
            this.uccP_Proveedor_Autoriza1.OtroFrm_Aut_I = null;
            this.uccP_Proveedor_Autoriza1.Size = new System.Drawing.Size(767, 313);
            this.uccP_Proveedor_Autoriza1.TabIndex = 4;
            // 
            // frmCP_AutorizacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 313);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCP_AutorizacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autorización de Proveedor";
            this.Load += new System.EventHandler(this.FrmCP_AutorizacionProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorAutorizacionInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cpproveedorAutorizacionInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCCP_Proveedor_Autoriza uccP_Proveedor_Autoriza1;
    }
}
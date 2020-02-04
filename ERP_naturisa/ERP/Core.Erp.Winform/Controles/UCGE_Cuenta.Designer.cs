namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Cuenta
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
            this.cmbcuenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.Location = new System.Drawing.Point(0, 0);
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(665, 21);
            this.cmbcuenta.TabIndex = 10;
            this.cmbcuenta.SelectedIndexChanged += new System.EventHandler(this.cmbcuenta_SelectedIndexChanged);
            // 
            // UCGE_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbcuenta);
            this.Name = "UCGE_Cuenta";
            this.Size = new System.Drawing.Size(670, 23);
            this.Load += new System.EventHandler(this.UCGE_Cuenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcuenta;
    }
}

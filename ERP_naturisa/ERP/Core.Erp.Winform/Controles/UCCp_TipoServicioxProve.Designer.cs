namespace Core.Erp.Winform.Controles
{
    partial class UCCp_TipoServicioxProve
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
            this.cmb_tipoServicioxProve = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_tipoServicioxProve
            // 
            this.cmb_tipoServicioxProve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_tipoServicioxProve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoServicioxProve.FormattingEnabled = true;
            this.cmb_tipoServicioxProve.Location = new System.Drawing.Point(0, 0);
            this.cmb_tipoServicioxProve.Name = "cmb_tipoServicioxProve";
            this.cmb_tipoServicioxProve.Size = new System.Drawing.Size(247, 21);
            this.cmb_tipoServicioxProve.TabIndex = 0;
            this.cmb_tipoServicioxProve.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoServicioxProve_SelectedIndexChanged);
            // 
            // UCCp_TipoServicioxProve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_tipoServicioxProve);
            this.Name = "UCCp_TipoServicioxProve";
            this.Size = new System.Drawing.Size(247, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipoServicioxProve;
    }
}

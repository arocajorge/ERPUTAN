namespace Core.Erp.Winform.Controles
{
    partial class UCCp_TipoGasto
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
            this.cmb_TipoGasto.Size = new System.Drawing.Size(221, 21);
            this.cmb_TipoGasto.TabIndex = 0;
            this.cmb_TipoGasto.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoGasto_SelectedIndexChanged);
            // 
            // UCCp_TipoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_TipoGasto);
            this.Name = "UCCp_TipoGasto";
            this.Size = new System.Drawing.Size(221, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TipoGasto;
    }
}

namespace Core.Erp.Winform.Controles
{
    partial class UCCp_Tipo_codigo_SRI
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
            this.cmb_tipo_cod_SRI = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_tipo_cod_SRI
            // 
            this.cmb_tipo_cod_SRI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_tipo_cod_SRI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_cod_SRI.FormattingEnabled = true;
            this.cmb_tipo_cod_SRI.Location = new System.Drawing.Point(0, 0);
            this.cmb_tipo_cod_SRI.Name = "cmb_tipo_cod_SRI";
            this.cmb_tipo_cod_SRI.Size = new System.Drawing.Size(243, 21);
            this.cmb_tipo_cod_SRI.TabIndex = 0;
            this.cmb_tipo_cod_SRI.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_cod_SRI_SelectedIndexChanged);
            // 
            // UCCp_Tipo_codigo_SRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_tipo_cod_SRI);
            this.Name = "UCCp_Tipo_codigo_SRI";
            this.Size = new System.Drawing.Size(243, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipo_cod_SRI;
    }
}

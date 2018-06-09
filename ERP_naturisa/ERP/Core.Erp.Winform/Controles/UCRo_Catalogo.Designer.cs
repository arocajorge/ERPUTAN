namespace Core.Erp.Winform.Controles
{
    partial class UCRo_Catalogo
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
            this.cmb_catalogo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_catalogo
            // 
            this.cmb_catalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_catalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_catalogo.FormattingEnabled = true;
            this.cmb_catalogo.Location = new System.Drawing.Point(3, 3);
            this.cmb_catalogo.Name = "cmb_catalogo";
            this.cmb_catalogo.Size = new System.Drawing.Size(220, 21);
            this.cmb_catalogo.TabIndex = 1;
            this.cmb_catalogo.SelectedIndexChanged += new System.EventHandler(this.cmb_catalogo_SelectedIndexChanged);
            // 
            // UCRo_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_catalogo);
            this.Name = "UCRo_Catalogo";
            this.Size = new System.Drawing.Size(227, 27);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_catalogo;
    }
}

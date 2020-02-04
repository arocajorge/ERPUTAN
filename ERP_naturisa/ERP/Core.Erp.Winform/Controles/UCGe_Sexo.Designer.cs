namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Sexo
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
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(0, 0);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(150, 21);
            this.cmb_sexo.TabIndex = 0;
            this.cmb_sexo.SelectedIndexChanged += new System.EventHandler(this.cmb_sexo_SelectedIndexChanged);
            // 
            // UCGe_Sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_sexo);
            this.Name = "UCGe_Sexo";
            this.Size = new System.Drawing.Size(150, 27);
            this.Load += new System.EventHandler(this.UCGe_Sexo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_sexo;
    }
}

namespace Core.Erp.Winform.Controles
{
    partial class UCGe_EstadoCivil
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
            this.cmb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_estadoCivil
            // 
            this.cmb_estadoCivil.DisplayMember = "descripcion";
            this.cmb_estadoCivil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_estadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estadoCivil.FormattingEnabled = true;
            this.cmb_estadoCivil.Location = new System.Drawing.Point(0, 0);
            this.cmb_estadoCivil.Name = "cmb_estadoCivil";
            this.cmb_estadoCivil.Size = new System.Drawing.Size(185, 21);
            this.cmb_estadoCivil.TabIndex = 0;
            this.cmb_estadoCivil.SelectedIndexChanged += new System.EventHandler(this.cmb_estadoCivil_SelectedIndexChanged);
            // 
            // UCGe_EstadoCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_estadoCivil);
            this.Name = "UCGe_EstadoCivil";
            this.Size = new System.Drawing.Size(185, 29);
            this.Load += new System.EventHandler(this.UCGe_EstadoCivil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_estadoCivil;

    }
}

namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Docu_Personales
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
            this.cmb_Docum_perso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_Docum_perso
            // 
            this.cmb_Docum_perso.DisplayMember = "descripcion";
            this.cmb_Docum_perso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Docum_perso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Docum_perso.FormattingEnabled = true;
            this.cmb_Docum_perso.Location = new System.Drawing.Point(0, 0);
            this.cmb_Docum_perso.Name = "cmb_Docum_perso";
            this.cmb_Docum_perso.Size = new System.Drawing.Size(210, 21);
            this.cmb_Docum_perso.TabIndex = 0;
            this.cmb_Docum_perso.SelectedIndexChanged += new System.EventHandler(this.cmb_Docum_perso_SelectedIndexChanged);
            this.cmb_Docum_perso.SelectedValueChanged += new System.EventHandler(this.cmb_Docum_perso_SelectedValueChanged);
            this.cmb_Docum_perso.Click += new System.EventHandler(this.cmb_Docum_perso_Click);
            // 
            // UCGe_Docu_Personales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Docum_perso);
            this.Name = "UCGe_Docu_Personales";
            this.Size = new System.Drawing.Size(210, 29);
            this.Load += new System.EventHandler(this.UCGE_Docu_Personales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Docum_perso;
    }
}

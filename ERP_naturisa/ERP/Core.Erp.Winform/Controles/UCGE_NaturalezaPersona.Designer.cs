namespace Core.Erp.Winform.Controles
{
    partial class UCGe_NaturalezaPersona
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
            this.cmb_naturalezaPersona = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_naturalezaPersona
            // 
            this.cmb_naturalezaPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_naturalezaPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_naturalezaPersona.FormattingEnabled = true;
            this.cmb_naturalezaPersona.Location = new System.Drawing.Point(0, 0);
            this.cmb_naturalezaPersona.Name = "cmb_naturalezaPersona";
            this.cmb_naturalezaPersona.Size = new System.Drawing.Size(171, 21);
            this.cmb_naturalezaPersona.TabIndex = 0;
            this.cmb_naturalezaPersona.SelectedIndexChanged += new System.EventHandler(this.cmb_naturalezaPersona_SelectedIndexChanged);
            // 
            // UCGe_NaturalezaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_naturalezaPersona);
            this.Name = "UCGe_NaturalezaPersona";
            this.Size = new System.Drawing.Size(171, 27);
            this.Load += new System.EventHandler(this.UCGe_NaturalezaPersona_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_naturalezaPersona;
    }
}

namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Estado
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
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_estado
            // 
            this.cmb_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(0, 0);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(150, 21);
            this.cmb_estado.TabIndex = 0;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // UCGe_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_estado);
            this.Name = "UCGe_Estado";
            this.Size = new System.Drawing.Size(150, 29);
            this.Load += new System.EventHandler(this.UCGe_Estado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_estado;
    }
}

namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Aniof
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
            this.cmbanio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbanio
            // 
            this.cmbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbanio.FormattingEnabled = true;
            this.cmbanio.Location = new System.Drawing.Point(0, 0);
            this.cmbanio.Name = "cmbanio";
            this.cmbanio.Size = new System.Drawing.Size(101, 21);
            this.cmbanio.TabIndex = 0;
            this.cmbanio.SelectedIndexChanged += new System.EventHandler(this.cmbanio_SelectedIndexChanged);
            this.cmbanio.Click += new System.EventHandler(this.cmbanio_Click);
            // 
            // UCGE_Aniof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbanio);
            this.Name = "UCGE_Aniof";
            this.Size = new System.Drawing.Size(101, 22);
            this.Load += new System.EventHandler(this.UCGE_Aniof_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbanio;
    }
}

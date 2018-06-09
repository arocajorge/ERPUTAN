namespace Core.Erp.Winform.Controles
{
    partial class UCGe_EmpresaListChecked
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkListEmpresas = new System.Windows.Forms.CheckedListBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkListEmpresas);
            this.panel1.Controls.Add(this.chkTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 298);
            this.panel1.TabIndex = 0;
            // 
            // checkListEmpresas
            // 
            this.checkListEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListEmpresas.FormattingEnabled = true;
            this.checkListEmpresas.Location = new System.Drawing.Point(0, 17);
            this.checkListEmpresas.Name = "checkListEmpresas";
            this.checkListEmpresas.Size = new System.Drawing.Size(220, 281);
            this.checkListEmpresas.TabIndex = 1;
            this.checkListEmpresas.SelectedIndexChanged += new System.EventHandler(this.checkListEmpresas_SelectedIndexChanged);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTodos.Location = new System.Drawing.Point(0, 0);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(220, 17);
            this.chkTodos.TabIndex = 0;
            this.chkTodos.Text = "todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Click += new System.EventHandler(this.chkTodos_Click);
            // 
            // UCGe_EmpresaListChecked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCGe_EmpresaListChecked";
            this.Size = new System.Drawing.Size(220, 298);
            this.Load += new System.EventHandler(this.UCGe_EmpresaListChecked_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkListEmpresas;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}

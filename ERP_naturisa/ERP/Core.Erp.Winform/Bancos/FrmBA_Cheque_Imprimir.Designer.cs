namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Cheque_Imprimir
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NCheque = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSeleccionarChequeTalonario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Cheque:";
            // 
            // txt_NCheque
            // 
            this.txt_NCheque.Location = new System.Drawing.Point(102, 23);
            this.txt_NCheque.Name = "txt_NCheque";
            this.txt_NCheque.ReadOnly = true;
            this.txt_NCheque.Size = new System.Drawing.Size(100, 20);
            this.txt_NCheque.TabIndex = 1;
            this.txt_NCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NCheque_KeyPress);
            this.txt_NCheque.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NCheque_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeleccionarChequeTalonario
            // 
            this.btnSeleccionarChequeTalonario.Location = new System.Drawing.Point(219, 19);
            this.btnSeleccionarChequeTalonario.Name = "btnSeleccionarChequeTalonario";
            this.btnSeleccionarChequeTalonario.Size = new System.Drawing.Size(29, 24);
            this.btnSeleccionarChequeTalonario.TabIndex = 2;
            this.btnSeleccionarChequeTalonario.Text = "B";
            this.btnSeleccionarChequeTalonario.UseVisualStyleBackColor = true;
            this.btnSeleccionarChequeTalonario.Click += new System.EventHandler(this.btnSeleccionarChequeTalonario_Click);
            // 
            // FrmBA_Cheque_Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.btnSeleccionarChequeTalonario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NCheque);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBA_Cheque_Imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desea Imprimir Cheque?";
            this.Load += new System.EventHandler(this.FrmBA_Cheque_Imprimir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NCheque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeleccionarChequeTalonario;
    }
}
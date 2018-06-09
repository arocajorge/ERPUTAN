namespace Core.Erp.Winform.Academico
{
    partial class FrmAca_Retiro_Estudiante
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRetirarEstudiante = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucAca_Estudiante1 = new Core.Erp.Winform.Controles.UCAca_Estudiante();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRetirarEstudiante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMotivoAnulacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ucAca_Estudiante1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 184);
            this.panel1.TabIndex = 0;
            // 
            // btnRetirarEstudiante
            // 
            this.btnRetirarEstudiante.Location = new System.Drawing.Point(357, 142);
            this.btnRetirarEstudiante.Name = "btnRetirarEstudiante";
            this.btnRetirarEstudiante.Size = new System.Drawing.Size(189, 39);
            this.btnRetirarEstudiante.TabIndex = 7;
            this.btnRetirarEstudiante.Text = "RETIRAR ESTUDIANTE";
            this.btnRetirarEstudiante.Click += new System.EventHandler(this.btnRetirarEstudiante_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo de Retiro:";
            // 
            // txtMotivoAnulacion
            // 
            this.txtMotivoAnulacion.Location = new System.Drawing.Point(135, 42);
            this.txtMotivoAnulacion.Multiline = true;
            this.txtMotivoAnulacion.Name = "txtMotivoAnulacion";
            this.txtMotivoAnulacion.Size = new System.Drawing.Size(412, 93);
            this.txtMotivoAnulacion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudiante:";
            // 
            // ucAca_Estudiante1
            // 
            this.ucAca_Estudiante1.Location = new System.Drawing.Point(135, 1);
            this.ucAca_Estudiante1.Margin = new System.Windows.Forms.Padding(5);
            this.ucAca_Estudiante1.Name = "ucAca_Estudiante1";
            this.ucAca_Estudiante1.Size = new System.Drawing.Size(412, 33);
            this.ucAca_Estudiante1.TabIndex = 2;
            // 
            // FrmAca_Retiro_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 184);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAca_Retiro_Estudiante";
            this.Text = "FrmAca_Retiro_Estudiante";
            this.Load += new System.EventHandler(this.FrmAca_Retiro_Estudiante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivoAnulacion;
        private System.Windows.Forms.Label label1;
        private Controles.UCAca_Estudiante ucAca_Estudiante1;
        private DevExpress.XtraEditors.SimpleButton btnRetirarEstudiante;

    }
}
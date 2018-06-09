namespace Core.Erp.Winform.General
{
    partial class frmGe_CambiarContraseña
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmar_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_mostrarpass = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_passAnterior = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(151, 143);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(102, 30);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Anterior:";
            // 
            // txt_confirmar_pass
            // 
            this.txt_confirmar_pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmar_pass.Location = new System.Drawing.Point(151, 107);
            this.txt_confirmar_pass.MaxLength = 20;
            this.txt_confirmar_pass.Name = "txt_confirmar_pass";
            this.txt_confirmar_pass.PasswordChar = '*';
            this.txt_confirmar_pass.Size = new System.Drawing.Size(242, 23);
            this.txt_confirmar_pass.TabIndex = 4;
            this.txt_confirmar_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirmar_pass_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 37;
            this.label5.Text = "Confirmar Contraseña Nueva:";
            // 
            // chk_mostrarpass
            // 
            this.chk_mostrarpass.AutoSize = true;
            this.chk_mostrarpass.Location = new System.Drawing.Point(15, 143);
            this.chk_mostrarpass.Name = "chk_mostrarpass";
            this.chk_mostrarpass.Size = new System.Drawing.Size(118, 17);
            this.chk_mostrarpass.TabIndex = 5;
            this.chk_mostrarpass.Text = "Mostrar Contraseña";
            this.chk_mostrarpass.UseVisualStyleBackColor = true;
            this.chk_mostrarpass.CheckedChanged += new System.EventHandler(this.chk_mostrarpass_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(151, 78);
            this.txt_pass.MaxLength = 20;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(242, 23);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(151, 20);
            this.txt_user.MaxLength = 20;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(242, 23);
            this.txt_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Contraseña Nueva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // txt_passAnterior
            // 
            this.txt_passAnterior.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passAnterior.Location = new System.Drawing.Point(151, 49);
            this.txt_passAnterior.MaxLength = 20;
            this.txt_passAnterior.Name = "txt_passAnterior";
            this.txt_passAnterior.PasswordChar = '*';
            this.txt_passAnterior.Size = new System.Drawing.Size(242, 23);
            this.txt_passAnterior.TabIndex = 2;
            this.txt_passAnterior.TextChanged += new System.EventHandler(this.txt_passAnterior_TextChanged);
            this.txt_passAnterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_passAnterior_KeyPress);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(291, 143);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 30);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frmGe_CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 183);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_passAnterior);
            this.Controls.Add(this.txt_confirmar_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_mostrarpass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGe_CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmGe_CambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirmar_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_mostrarpass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_passAnterior;
        private System.Windows.Forms.Button btn_salir;
    }
}
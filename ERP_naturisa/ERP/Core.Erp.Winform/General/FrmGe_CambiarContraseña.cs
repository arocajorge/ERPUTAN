using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;




namespace Core.Erp.Winform.General
{
    public partial class frmGe_CambiarContraseña : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus parametros = cl_parametrosGenerales_Bus.Instance;


        public frmGe_CambiarContraseña()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void FrmGe_CambiarContraseña_Load(object sender, EventArgs e)
        {
            try
            {
                txt_user.Text= parametros.IdUsuario;
                txt_user.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void chk_mostrarpass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_mostrarpass.Checked)
                 chk_mostrarpass.Text = "Ocultar Contraseña";
                else
                 chk_mostrarpass.Text = "Mostrar Contraseña";
                this.txt_pass.PasswordChar = (chk_mostrarpass.Checked == true) ? '\0' : '*';
                this.txt_confirmar_pass.PasswordChar = (chk_mostrarpass.Checked == true) ? '\0' : '*';
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
            //    tb_Usuario_Bus userB = new tb_Usuario_Bus();
            //    tb_Usuario_Info userInfo= new tb_Usuario_Info();

         

            //userInfo.Contrasena = txt_passAnterior.Text.Trim();
            //userInfo.IdLogin = txt_user.Text.Trim();

            //if (userB.Validar_Credenciales(userInfo))
            //{

            //    if ((txt_pass.Text.Trim() != txt_confirmar_pass.Text.Trim()))
            //    {
            //        MessageBox.Show("Las contraseñas deben de ser iguales . verifique ..", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    }
            //    else
            //    {
            //        userInfo.Contrasena = txt_pass.Text.Trim();
            //        userB.Actualizar_Password(userInfo);
            //        MessageBox.Show("Contraseña Actualiza ok...","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Contraseña Anterior Errada .. verifique..", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}


            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

       

        private void txt_passAnterior_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void txt_passAnterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            

        }

        private void txt_confirmar_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            }
            catch (Exception ex)
            {             
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }
    }
}

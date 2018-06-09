using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class frmPrd_UsuarioAutoriza : Form
    {
        public frmPrd_UsuarioAutoriza()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

         
        }
        public Boolean Autorizado = false;
        public string Usuario = "";

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwprd_UsuarioAutorizados_Cidersus_Info User = new vwprd_UsuarioAutorizados_Cidersus_Info();
        vwprd_UsuarioAutorizados_Cidersus_Bus BusUser = new vwprd_UsuarioAutorizados_Cidersus_Bus();
                
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                User = BusUser.TraerUsuarioAutorizado(txtUser.Text.Trim(), txtCont.Text.Trim());
                if (User != null)
                { Autorizado = true; Usuario = User.IdLogin; MessageBox.Show("Autorizado"); }
                else {
                    Autorizado = false; Usuario = ""; MessageBox.Show("Usuario o Contraseña Invalida./n No autorizado.");
                                }
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    

       


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_ModificaCbte : UserControl
    {
        public UCGe_ModificaCbte()
        {
            try
            {
                InitializeComponent();
                this.event_btn_PermisoModiCbt_Click += new delegate_btn_PermisoModiCbt_Click(UCGe_ModificaCbte_event_btn_PermisoModiCbt_Click);
            
                //Usu_B.Validar_PermisoModificacionCbteCble(param.IdUsuario, "MODIFDIARIO_BAN", ref msj, ref tablaVacia);
                if (tablaVacia)
                    this.Visible = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCGe_ModificaCbte_event_btn_PermisoModiCbt_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        
        string msj;
        bool tablaVacia;
        public Boolean  ConPermisoModif { get; set; }

        public Boolean  ValidaPermiso()
        {
            try
            {
                //Boolean PERMISO = Usu_B.Validar_PermisoModificacionCbteCble(param.IdUsuario, "MODIFDIARIO_BAN", ref msj, ref tablaVacia);
                //if (PERMISO )
                //{
                //    ConPermisoModif = true;
                //}
                //else
                //{
                //    if (MessageBox.Show("El usuario no tiene permiso para modificar el Comprobante Contable..\n" + msj + " \n¿ Desea Solicitar Clave de desbloqueo para Modificar el Comprobante  ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        Frm_PermisoUsuarioProceso frm = new Frm_PermisoUsuarioProceso();
                //        frm.ShowDialog();
                //        ConPermisoModif = frm.ConPermisoModif;
                //    }
                //}
                //return ConPermisoModif;
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void btn_PermisoModiCbt_Click(object sender, EventArgs e)
        {
            try
            {
                this.event_btn_PermisoModiCbt_Click(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       

        public delegate void delegate_btn_PermisoModiCbt_Click(object sender, EventArgs e);
        public event delegate_btn_PermisoModiCbt_Click event_btn_PermisoModiCbt_Click;
       


    }
}

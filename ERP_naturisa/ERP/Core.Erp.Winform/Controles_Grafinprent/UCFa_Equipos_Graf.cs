using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Business.Facturacion_Grafinpren;
using Core.Erp.Winform.Facturacion_Grafinpren;

namespace Core.Erp.Winform.Controles_Grafinprent
{
    public partial class UCFa_Equipos_Graf : UserControl
    {
        #region Atributos y variables
        //generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //clases bus
        fa_Equipo_graf_Bus Bus_Equipo = new fa_Equipo_graf_Bus();

        //clases info
        fa_Equipo_graf_Info Info_equipo = new fa_Equipo_graf_Info();
        List<fa_Equipo_graf_Info> List_Equipo = new List<fa_Equipo_graf_Info>();

        //otros
        frmfa_Equipo_graf_Mant frm;
        string mensaje = "";

        #endregion

        public UCFa_Equipos_Graf()
        {
            InitializeComponent();
        }

        public void Cargar_Combo()
        {
            try
            {
                List_Equipo = new List<fa_Equipo_graf_Info>(Bus_Equipo.Get_List_Equipo(param.IdEmpresa, ref mensaje));
                cmb_Equipo.Properties.DataSource = List_Equipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmfa_Equipo_graf_Mant();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_equipo = (fa_Equipo_graf_Info)cmb_Equipo.EditValue;
                    if (Info_equipo != null)
                    {
                        frm.Set_Info(Info_equipo);
                        frm.Set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Para continuar seleccione un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.Set_Accion(Accion);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public int GetId_Equipo()
        {
            return (Convert.ToInt32(cmb_Equipo.EditValue));
        }

        public fa_Equipo_graf_Info Get_Equipo()
        {
            try
            {
                if (cmb_Equipo.EditValue != null && (int)cmb_Equipo.EditValue!=0)
                {
                    int IdEquipo = Convert.ToInt32(cmb_Equipo.EditValue);                     
                    Info_equipo = List_Equipo.FirstOrDefault(q => q.IdEquipo == IdEquipo);
                    return Info_equipo;
                }
                else
                    return new fa_Equipo_graf_Info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_Equipo_graf_Info();
            }
        }

        public void Set_InfoEquipo(int IdEquipo)
        {
            try
            {
                if (IdEquipo != 0 )
                {
                    cmb_Equipo.EditValue = IdEquipo;    
                }else
                    cmb_Equipo.EditValue = null;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void InicializarEquipo()
        {
            try
            {
                cmb_Equipo.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #region Eventos del control de usuario
        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void modificartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Activo_fijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_equipo = (fa_Equipo_graf_Info)cmb_Equipo.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion
    }
}

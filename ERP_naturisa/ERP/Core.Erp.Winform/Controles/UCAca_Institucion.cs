using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;
using Core.Erp.Winform.Academico;
using Core.Erp.Business.Academico;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_Institucion : UserControl
    {
        #region Variables

        List<Aca_Institucion_Info> listInstitucion = new List<Aca_Institucion_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmAcaInstitucion_Mant frm;
        Aca_Institucion_Bus InstitucionBus = new Aca_Institucion_Bus();
        BindingList<Aca_Institucion_Info> BInstitucionInfo;
        Aca_Institucion_Info Info_Institucuion = new Aca_Institucion_Info();
        string IdInstitucion;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        public UCAca_Institucion()
        {
            InitializeComponent();
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                BInstitucionInfo = new BindingList<Aca_Institucion_Info>(InstitucionBus.Get_List_Institucion(param.IdEmpresa));

                frm = new FrmAcaInstitucion_Mant();
                frm.event_FrmInstitucion_Mant_FormClosing += frm_event_FrmInstitucion_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info_Institucuion != null)
                    {
                        frm.set_Institucion(Info_Institucuion);
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Escoja una institucion para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.set_Accion(Accion);
                    frm.Show();
                }
                //frm.Event_frmAF_Catalogo_Mantenimiento_FormClosing += frm_Event_frmAF_Catalogo_Mantenimiento_FormClosing;
                //if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                //{
                //    frm.setInfo = InfoCatalogo;
                //    frm.setAccion(Accion);

                //}
                //else
                //    frm.setAccion(Accion);

                //frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        void frm_event_FrmInstitucion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Datos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Institucion(string IdInstitucion)
        {
            try
            {
                cmbInstitucion.EditValue = IdInstitucion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public Aca_Institucion_Info Get_Institucion()
        {
            try
            {
                if (cmbInstitucion.EditValue != null)
                {
                    Info_Institucuion = listInstitucion.FirstOrDefault(v => v.IdInstitucion == Convert.ToInt32(cmbInstitucion.EditValue));
                }
                return Info_Institucuion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Institucion_Info();
            }
        }

        public void cargar_Datos()
        {
            try
            {
                listInstitucion = new List<Aca_Institucion_Info>();
                listInstitucion = InstitucionBus.Get_List_Institucion(param.IdEmpresa);
                cmbInstitucion.Properties.DataSource = listInstitucion;
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Institucion();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Institucion();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_UnidadMedidaCmb : UserControl
    {
        List<in_UnidadMedida_Info> lstUnidadM = new List<in_UnidadMedida_Info>();
        vwIn_UnidadMedida_Equivalencia_Bus busEquiv = new vwIn_UnidadMedida_Equivalencia_Bus();
        List<vwIn_UnidadMedida_Equivalencia_Info> lstUniEquiv = new List<vwIn_UnidadMedida_Equivalencia_Info>();
        in_UnidadMedida_Bus UniB = new in_UnidadMedida_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_UnidadMedida_Info InfoUnidad = new in_UnidadMedida_Info();
        FrmIn_Unidad_Medida_Mant frm;

        

        public delegate void delegate_cmbUnidadMedida_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbUnidadMedida_EditValueChanged event_cmbUnidadMedida_EditValueChanged;

        public delegate void delegate_cmbUnidadMedida_Validated(object sender, EventArgs e);
        public event delegate_cmbUnidadMedida_Validated event_cmbUnidadMedida_Validated;

        public delegate void delegate_cmbUnidadMedida_Validating(object sender, CancelEventArgs e);
        public event delegate_cmbUnidadMedida_Validating event_cmbUnidadMedida_Validating;


        public UCIn_UnidadMedidaCmb()
        {
            InitializeComponent();
            event_cmbUnidadMedida_EditValueChanged += UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_EditValueChanged;
            event_cmbUnidadMedida_Validated += UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_Validated;
            event_cmbUnidadMedida_Validating += UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_Validating;
        }

        void UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_Validating(object sender, CancelEventArgs e)
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

        void UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_Validated(object sender, EventArgs e)
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

        void UCIn_UnidadMedidaCmb_event_cmbUnidadMedida_EditValueChanged(object sender, EventArgs e)
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


        public void CargarUnidadMedida()
        {
            try
            {
                lstUnidadM = new List<in_UnidadMedida_Info>();
                lstUnidadM = UniB.Get_list_UnidadMedida();
                cmbUnidadMedida.Properties.DataSource = lstUnidadM;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        public void CargarUnidadMedida_Equiv(string IdUnidadMedida)
        {
            try
            {
                lstUnidadM = new List<in_UnidadMedida_Info>();
                lstUniEquiv = new List<vwIn_UnidadMedida_Equivalencia_Info>();
                lstUniEquiv = busEquiv.Get_List_UnidadMedida_Equivalencia(IdUnidadMedida);
                foreach (var item in lstUniEquiv)
                {
                    in_UnidadMedida_Info Info = new in_UnidadMedida_Info();
                    Info.IdUnidadMedida = item.IdUnidadMedida_equiva;
                    Info.cod_alterno = item.cod_alterno;
                    Info.Descripcion = item.Descripcion;
                    lstUnidadM.Add(Info);
                }
                cmbUnidadMedida.Properties.DataSource = lstUnidadM;
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
                frm = new FrmIn_Unidad_Medida_Mant();
                frm.event_FrmIn_Unidad_Medida_Mant_FormClosing += frm_event_FrmIn_Unidad_Medida_Mant_FormClosing;

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm._InfoUni_Med = InfoUnidad;
                    frm._Accion = Accion;
                }
                else
                    frm._Accion = Accion;

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); 
            }
        }

        void frm_event_FrmIn_Unidad_Medida_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarUnidadMedida();
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
                Get_Info_UnidadMedida();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); 
            }
        }

        public in_UnidadMedida_Info Get_Info_UnidadMedida()
        {
            try
            {
                InfoUnidad = lstUnidadM.FirstOrDefault(v => v.IdUnidadMedida == Convert.ToString(cmbUnidadMedida.EditValue));
                return InfoUnidad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new in_UnidadMedida_Info();
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info_UnidadMedida();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCIn_UnidadMedidaCmb_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUnidadMedida();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbUnidadMedida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbUnidadMedida_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());  
            }
        }

        private void cmbUnidadMedida_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmbUnidadMedida_Validated(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbUnidadMedida_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmbUnidadMedida_Validating(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmbUnidadMedida.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbMarca()
        {
            try
            {
                cmbUnidadMedida.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_IdUnidadMedida(string IdUnidadMedida)
        {
            try
            {
                cmbUnidadMedida.EditValue = IdUnidadMedida;
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

        private void MenuAcciones_Opening(object sender, CancelEventArgs e)
        {

        }

      
    }
}

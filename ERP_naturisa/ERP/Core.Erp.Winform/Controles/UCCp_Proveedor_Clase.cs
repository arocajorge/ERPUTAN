using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.CuentasxPagar;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_Proveedor_Clase : UserControl
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        frmCP_Proveedor_Clase_Mant frm;
        public cp_proveedor_clase_Info InfoProveedor_clase { get; set; }


        List<cp_proveedor_clase_Info> listClaseProveedor = new List<cp_proveedor_clase_Info>();

        cp_proveedor_clase_Bus BusClaseProveedor = new cp_proveedor_clase_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cp_proveedor_clase_Info InfoClaseProve = new cp_proveedor_clase_Info();

        public delegate void delegate_cmb_Provedor_clase_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Provedor_clase_EditValueChanged event_cmb_Provedor_clase_EditValueChanged;

        public delegate void delegate_cmb_Provedor_clase_Validating(object sender, EventArgs e);
        public event delegate_cmb_Provedor_clase_Validating event_cmb_Provedor_clase_Validating;

        public delegate void delegate_cmb_Provedor_clase_Validated(object sender, EventArgs e);
        public event delegate_cmb_Provedor_clase_Validated event_cmb_Provedor_clase_Validated;
        
        public UCCp_Proveedor_Clase()
        {
            InitializeComponent();

            event_cmb_Provedor_clase_EditValueChanged += UCCp_Proveedor_Clase_event_cmb_Provedor_clase_EditValueChanged;
            event_cmb_Provedor_clase_Validating += UCCp_Proveedor_Clase_event_cmb_Provedor_clase_Validating;
            event_cmb_Provedor_clase_Validated += UCCp_Proveedor_Clase_event_cmb_Provedor_clase_Validated;

            


        }

        void UCCp_Proveedor_Clase_event_cmb_Provedor_clase_Validated(object sender, EventArgs e)
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

        void UCCp_Proveedor_Clase_event_cmb_Provedor_clase_Validating(object sender, EventArgs e)
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

        void UCCp_Proveedor_Clase_event_cmb_Provedor_clase_EditValueChanged(object sender, EventArgs e)
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

        private void NuevotoolStripMenuItem_Click(object sender, EventArgs e)
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

        public cp_proveedor_clase_Info get_ClaseProveedorInfo()
        {
            try
            {
                             
                InfoClaseProve = listClaseProveedor.FirstOrDefault(v => v.IdClaseProveedor == Convert.ToDecimal(cmb_Provedor_clase.EditValue));
                return InfoClaseProve;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_proveedor_clase_Info();
            }

        }

        int IdClaseProveedor = 0;
        public int Primer()
        {
            try
            {
                if (listClaseProveedor != null)
                {
                    if (listClaseProveedor.Count() > 0)
                    {
                        IdClaseProveedor = listClaseProveedor.FirstOrDefault().IdClaseProveedor;
                    }
                }


               

                return IdClaseProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return 0;
            }

        }

  
        public void cargar_Claseproveedores()
        {
            try
            {
                listClaseProveedor = new List<cp_proveedor_clase_Info>();
                listClaseProveedor = BusClaseProveedor.Get_List_proveedor_clase(param.IdEmpresa);
              

                cmb_Provedor_clase.Properties.DataSource = listClaseProveedor;
                cmb_Provedor_clase.Properties.DisplayMember = "descripcion_clas_prove";
                cmb_Provedor_clase.Properties.ValueMember = "IdClaseProveedor";


                if (listClaseProveedor.Count != 0)
                {
                    cmb_Provedor_clase.EditValue = listClaseProveedor.FirstOrDefault().IdClaseProveedor;
                }

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
                frm = new frmCP_Proveedor_Clase_Mant();           
                frm.event_frmCP_Proveedor_Clase_Mant_FormClosing += frm_event_frmCP_Proveedor_Clase_Mant_FormClosing;     
                // sino es grabar puede ser modificar ,consultar,
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {                
                    frm.Accion = Accion;
                    frm.InfoProveedor_clase = InfoClaseProve;                 
                    frm.set_accion();
                }
                else
                    frm.Accion = Accion;
                    frm.set_accion();

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        void frm_event_frmCP_Proveedor_Clase_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_Provedor_clase.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbClaseProveedor()
        {
            try
            {
                cmb_Provedor_clase.EditValue = null;

            }
            catch (Exception ex)
            {
            }
        }

        public void set_ClaseProveedorInfo(decimal IdClaseProveedor)
        {
            try
            {
                cmb_Provedor_clase.EditValue = IdClaseProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCp_Proveedor_Clase_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                           
            }
        }

        private void ModificartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_ClaseProveedorInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
               
            }
        }

        private void cmb_Provedor_clase_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_Provedor_clase_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        private void cmb_Provedor_clase_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmb_Provedor_clase_Validated(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void cmb_Provedor_clase_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_Provedor_clase_Validating(sender,e);
            }
            catch (Exception ex)
            {


            }
        }

        private void ConsultartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_Proveedor_Clase_Vista_Previa frmi = new frmCP_Proveedor_Clase_Vista_Previa();
                frmi.set_ProveedorClaseInfo(param.IdEmpresa, get_ClaseProveedorInfo().IdClaseProveedor);
                frmi.Show();
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

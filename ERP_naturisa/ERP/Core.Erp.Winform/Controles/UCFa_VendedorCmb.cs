using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_VendedorCmb : UserControl
    {
        #region Variables
        List<fa_Vendedor_Info> listVendedor = new List<fa_Vendedor_Info>();
        fa_Vendedor_Bus BusVendedor = new fa_Vendedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmFa_Vendedor_Mant frm;
        fa_Vendedor_Info InfoVendedor = new fa_Vendedor_Info();
        tb_persona_bus PersoBus = new tb_persona_bus();
        tb_persona_Info InfoPerso = new tb_persona_Info();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public delegate void delegate_cmb_vendedor_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_vendedor_EditValueChanged event_cmb_vendedor_EditValueChanged;

        public delegate void delegate_cmb_vendedor_Validating(object sender, EventArgs e);
        public event delegate_cmb_vendedor_Validating event_cmb_vendedor_Validating;

        public delegate void delegate_cmb_vendedor_Validated(object sender, EventArgs e);
        public event delegate_cmb_vendedor_Validated event_cmb_vendedor_Validated;
        #endregion

        public UCFa_VendedorCmb()
        {
            InitializeComponent();
            event_cmb_vendedor_EditValueChanged += UCFa_VendedorCmb_event_cmb_vendedor_EditValueChanged;
            event_cmb_vendedor_Validated += UCFa_VendedorCmb_event_cmb_vendedor_Validated;
            event_cmb_vendedor_Validating += UCFa_VendedorCmb_event_cmb_vendedor_Validating;
        }

        void UCFa_VendedorCmb_event_cmb_vendedor_Validating(object sender, EventArgs e)
        {
            
        }

        void UCFa_VendedorCmb_event_cmb_vendedor_Validated(object sender, EventArgs e)
        {
            
        }

        void UCFa_VendedorCmb_event_cmb_vendedor_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_vendedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_vendedor_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_vendedor_Validated(object sender, EventArgs e)
        {

            try
            {
                event_cmb_vendedor_Validated(sender, e);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_vendedor_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                event_cmb_vendedor_Validating(sender, e);
            }
            catch (Exception ex)
            {

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
                get_VendedorInfo();
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
                get_VendedorInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void cargar_Vendedores()
        {
            try
            {
                listVendedor = new List<fa_Vendedor_Info>();
                listVendedor = BusVendedor.Get_List_Vendedores(param.IdEmpresa);
                cmb_vendedor.Properties.DataSource = listVendedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void UCFa_VendedorCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Vendedores();
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
                frm = new frmFa_Vendedor_Mant();
                frm.event_frmFa_Vendedor_Mant_FormClosing += new frmFa_Vendedor_Mant.delegate_frmFa_Vendedor_Mant_FormClosing(frm_event_frmFa_Vendedor_Mant_FormClosing);               
                // sino es grabar puede ser modificar ,consultar,
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    if (InfoVendedor != null)
                    {
                        frm.set_Vendedor(InfoVendedor);
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("No ha seleccionado un registro.\nSeleccione un registro.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.set_Accion(Accion);
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

        void frm_event_frmFa_Vendedor_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Vendedores();
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
                cmb_vendedor.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void Inicializar_cmbVendedor()
        {
            try
            {
                cmb_vendedor.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void set_VendedorInfo(int IdVendedor)
        {
            try
            {
                cmb_vendedor.EditValue = IdVendedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public fa_Vendedor_Info get_VendedorInfo()
        {
            try
            {
                InfoVendedor = listVendedor.FirstOrDefault(v => v.IdVendedor == Convert.ToInt32(cmb_vendedor.EditValue));
                return InfoVendedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return new fa_Vendedor_Info();
            }

        }
    }
}

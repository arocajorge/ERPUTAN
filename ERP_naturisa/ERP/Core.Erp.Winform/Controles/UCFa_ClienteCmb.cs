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
    public partial class UCFa_ClienteCmb : UserControl
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<fa_Cliente_Info> listCliente = new List<fa_Cliente_Info>();
        fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmFa_Clientes_Mant frm;
        fa_Cliente_Info InfoCliente = new fa_Cliente_Info();
        tb_persona_bus PersoBus = new tb_persona_bus();
        tb_persona_Info InfoPerso = new tb_persona_Info();

        public delegate void delegate_cmb_cliente_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_cliente_EditValueChanged event_cmb_cliente_EditValueChanged;

        public delegate void delegate_cmb_cliente_Validating(object sender, EventArgs e);
        public event delegate_cmb_cliente_Validating event_cmb_cliente_Validating;

        public delegate void delegate_cmb_cliente_Validated(object sender, EventArgs e);
        public event delegate_cmb_cliente_Validated event_cmb_cliente_Validated;
        #endregion

        public UCFa_ClienteCmb()
        {
            InitializeComponent();
            event_cmb_cliente_Validating += UCFa_ClienteCmb_event_cmb_cliente_Validating;
            event_cmb_cliente_Validated += UCFa_ClienteCmb_event_cmb_cliente_Validated;
            event_cmb_cliente_EditValueChanged += UCFa_ClienteCmb_event_cmb_cliente_EditValueChanged;
        }

        void UCFa_ClienteCmb_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_cliente.EditValue != null)
                {
                    InfoCliente = listCliente.FirstOrDefault(w => w.IdCliente == Convert.ToDecimal(cmb_cliente.EditValue) && w.IdEmpresa == param.IdEmpresa);
                }
            }
            catch (Exception ex)
            {

            }
        }

        void UCFa_ClienteCmb_event_cmb_cliente_Validated(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        void UCFa_ClienteCmb_event_cmb_cliente_Validating(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_cliente_EditValueChanged(sender, e);
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
                get_ClienteInfo();
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
                if (get_ClienteInfo().IdEmpresa != 0)
                {
                    frmFa_Clientes_Vista_Previa frmi = new frmFa_Clientes_Vista_Previa();
                    frmi.set_ClienteInfo(param.IdEmpresa, get_ClienteInfo().IdCliente);
                    frmi.Show();
                }
                else
                    MessageBox.Show("No ha seleccionado nada.\nPor favor seleccione un registro para continuar.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        public void cargar_Clientes()
        {
            try
            {
                listCliente = new List<fa_Cliente_Info>();
                listCliente = BusCliente.Get_List_Clientes(param.IdEmpresa);
                cmb_cliente.Properties.DataSource = listCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void UCFa_ClienteCmb_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Clientes();
            }
            catch (Exception ex)
            {

            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmFa_Clientes_Mant();
                frm.event_frmFA_Clientes_Mant_FormClosing += new frmFa_Clientes_Mant.Delegate_frmFA_Clientes_Mant_FormClosing(frm_event_frmFA_Clientes_Mant_FormClosing);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (get_ClienteInfo() != null)
                    {
                        if (get_ClienteInfo().IdEmpresa != 0)
                        {
                            frm.set_Cliente(get_ClienteInfo());
                            frm.set_Accion(Accion);
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No ha seleccionado ningún registro.\nPor favor seleccione un registro para continuar.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
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

        void frm_event_frmFA_Clientes_Mant_FormClosing()
        {

            try
            {
                cargar_Clientes();
            }
            catch (Exception ex)
            {
            }

        }

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_cliente.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
            }
        }

        public void Inicializar_cmb_cliente()
        {
            try
            {
                cmb_cliente.EditValue = null;

            }
            catch (Exception ex)
            {
            }
        }

        public void set_ClienteInfo(decimal IdCliente)
        {
            try
            {
                cmb_cliente.EditValue = IdCliente;
            }
            catch (Exception ex)
            {

            }
        }

        public fa_Cliente_Info get_ClienteInfo()
        {
            try
            {
                InfoCliente = new fa_Cliente_Info();
                if (cmb_cliente.EditValue != null)
                {
                    InfoCliente = listCliente.FirstOrDefault(v => v.IdCliente == Convert.ToInt32(cmb_cliente.EditValue));
                }
                return InfoCliente;
            }
            catch (Exception ex)
            {
                return new fa_Cliente_Info();
            }

        }

        private void cmb_cliente_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmb_cliente_Validated(sender,e);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_cliente_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_cliente_Validating(sender, e);
            }
            catch (Exception ex)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using System.Windows.Forms;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Cliente_Facturacion : UserControl
    {
        public UCFa_Cliente_Facturacion()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
 
        }
        public UCFa_Cliente_Facturacion(int IdSucursal)
        {
            try
            {
                InitializeComponent();
                CargarCombosXsucurlsa ( IdSucursal);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
        List<fa_Vendedor_Info> Lista_Vendedores = new List<fa_Vendedor_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_Cliente_Info InfoClientes = new fa_Cliente_Info();

        public void CargarCombos()
        {
            try
            {
                 fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                Lista_Clientes = bus_cliente.Get_List_Clientes(param.IdEmpresa);

                this.cmb_cliente.Properties.DataSource = Lista_Clientes;
                       
                fa_Vendedor_Bus bus_vendedor = new fa_Vendedor_Bus();
                Lista_Vendedores = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);
                this.cmb_vendedor.Properties.DataSource = Lista_Vendedores;
                this.cmb_vendedor.Properties.DisplayMember = "Ve_Vendedor";
                this.cmb_vendedor.Properties.ValueMember = "IdVendedor";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void CargarCombosXsucurlsa (int IdSucursal)
        {
            try
            {
                fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                Lista_Clientes = bus_cliente.Get_List_Clientes(param.IdEmpresa);
                var CXS = from q in Lista_Clientes
                          where q.IdSucursal == IdSucursal
                          select q;

                this.cmb_cliente.Properties.DataSource = CXS.ToList();

                fa_Vendedor_Bus bus_vendedor = new fa_Vendedor_Bus();
                Lista_Vendedores = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);


                this.cmb_vendedor.Properties.DataSource = Lista_Vendedores;
                this.cmb_vendedor.Properties.DisplayMember = "Ve_Vendedor";
                this.cmb_vendedor.Properties.ValueMember = "IdVendedor";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void UCFA_Cliente_Facturacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                Event_cmb_cliente_EditValueChanged +=UCFA_Cliente_Facturacion_Event_cmb_cliente_EditValueChanged;   
                 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        void UCFA_Cliente_Facturacion_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e){}
       
        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_Clientes_consul frm = new frmFa_Clientes_consul();
                frm.llamadoFuera = true;

                frm.ShowDialog();

                //InfoClientes = frm.info_otroLLamado;
                cmb_cliente.EditValue = InfoClientes.IdPersona;
                cmb_vendedor.EditValue = InfoClientes.IdVendedor;
                txt_Telefonos.Text = InfoClientes.Persona_Info.pe_telefonoOfic;
                txt_Direccion.Text = InfoClientes.Persona_Info.pe_direccion;

                txt_Ruc.Text = InfoClientes.Persona_Info.pe_cedulaRuc;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }
        
        private void txtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_Clientes_Mant frm = new frmFa_Clientes_Mant();
                fa_Cliente_Info Cliente = new fa_Cliente_Info();

                if (Lista_Clientes.Count > 0)
                {
                    Cliente = Lista_Clientes.First(var => var.IdCliente == Convert.ToDecimal(cmb_cliente.EditValue));
                    frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                    frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);

                frm.set_Cliente(Cliente);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_Clientes_Mant ofrm = new frmFa_Clientes_Mant();
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = base.ParentForm.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        public delegate void Delegate_cmb_cliente_EditValueChanged(object sender, EventArgs e);
        public event Delegate_cmb_cliente_EditValueChanged Event_cmb_cliente_EditValueChanged;

        private void cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fa_Cliente_Info Cliente = new fa_Cliente_Info();
                Cliente = Lista_Clientes.FirstOrDefault(var => var.IdCliente == Convert.ToDecimal((cmb_cliente.EditValue == null) ? 0 : cmb_cliente.EditValue));
                if (Cliente != null)
                {
                    this.txt_Ruc.Text = Cliente.Persona_Info.pe_cedulaRuc;
                    this.txt_Direccion.Text = Cliente.Persona_Info.pe_direccion;
                    this.txt_Telefonos.Text = Cliente.Persona_Info.pe_telefonoOfic;
                    this.cmb_vendedor.EditValue = Cliente.IdVendedor;
                    Event_cmb_cliente_EditValueChanged(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
           
        }


        public fa_Cliente_Info get_IdTipoCredito(decimal IdCliente)
        {
            try
            {
                return Lista_Clientes.Where(q => q.IdCliente == IdCliente).First();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return null;
            }
        }


        public void Bloquear_ComboCliente()
        {
            this.cmb_cliente.Enabled = false;
            this.cmb_cliente.BackColor = System.Drawing.Color.White;
            this.cmb_cliente.ForeColor = System.Drawing.Color.Black;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_Clientes_Mant ofrm = new frmFa_Clientes_Mant();                
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = base.ParentForm.MdiParent;
                ofrm.Show();
                ofrm.event_frmFA_Clientes_Mant_FormClosing += new frmFa_Clientes_Mant.Delegate_frmFA_Clientes_Mant_FormClosing(frm_event_frmFA_Clientes_Mant_FormClosing);
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
                frmFa_Clientes_Mant frm = new frmFa_Clientes_Mant();
                fa_Cliente_Info Cliente = new fa_Cliente_Info();                
                if (Lista_Clientes.Count > 0)
                {
                    Cliente = Lista_Clientes.First(var => var.IdCliente == Convert.ToDecimal(cmb_cliente.EditValue));
                    frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                    frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);

                frm.set_Cliente(Cliente);
                frm.ShowDialog();
                frm.event_frmFA_Clientes_Mant_FormClosing += new frmFa_Clientes_Mant.Delegate_frmFA_Clientes_Mant_FormClosing(frm_event_frmFA_Clientes_Mant_FormClosing);
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
                CargarCombos();

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
                frmFa_Clientes_consul frm = new frmFa_Clientes_consul();
                frm.llamadoFuera = true;

                frm.ShowDialog();
                
                
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

        private void txt_Direccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

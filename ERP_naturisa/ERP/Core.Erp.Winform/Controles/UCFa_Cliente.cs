using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Cliente : UserControl
    {
        #region Variables
        public int EjeY { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_cmbCliente_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbCliente_EditValueChanged Event_cmbCliente_EditValueChanged;
        List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
        List<fa_Vendedor_Info> Lista_Vendedores = new List<fa_Vendedor_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public fa_Cliente_Info Info = new fa_Cliente_Info();
        public fa_Cliente_Info get_Cliente() { return Info; }
        #endregion
       
        public UCFa_Cliente(int y)
        {
            try
            {
                InitializeComponent();
                EjeY = y;
                load_combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        public UCFa_Cliente()
        {
            try
            {
                InitializeComponent();
                this.Event_cmbCliente_EditValueChanged += UCFa_Cliente_Event_cmbCliente_EditValueChanged;
                load_combos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        public void UCFa_Cliente_Event_cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public void set_Cliente(decimal id_cliente)
        {
            try
            {
                cmbCliente.EditValue = id_cliente;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void load_combos()
        {
            try
            {

                this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, EjeY));
                this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 647 - EjeY));

                fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                Lista_Clientes = bus_cliente.Get_List_Clientes(param.IdEmpresa);

                fa_Vendedor_Bus bus_vendedor = new fa_Vendedor_Bus();
                Lista_Vendedores = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);

                cmbCliente.Properties.DataSource = Lista_Clientes;
                cmbCliente.Properties.DisplayMember = "Nombre_Cliente";
                cmbCliente.Properties.ValueMember = "IdCliente";

                cmbVendedor.Properties.DataSource = Lista_Vendedores;
                cmbVendedor.Properties.DisplayMember = "Ve_Vendedor";
                cmbVendedor.Properties.ValueMember = "IdVendedor";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void UCFAC_Cliente_Load(object sender, EventArgs e)
        {

        }
       
        private void cmbCliente_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.cmbCliente.EditValue == null)
                { cmbCliente.EditValue = ""; }
                else
                {
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info = new fa_Cliente_Info();
                Info = (fa_Cliente_Info)cmbCliente.Properties.View.GetFocusedRow();
                this.txt_Ruc.Text = Info.Persona_Info.pe_cedulaRuc;
                this.txt_Direccion.Text = Info.Persona_Info.pe_direccion;
                this.txt_Telefonos.Text = Info.Persona_Info.pe_telefonoOfic;
                this.cmbVendedor.EditValue = Info.IdVendedor;
                this.Event_cmbCliente_EditValueChanged(sender, e);
               
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

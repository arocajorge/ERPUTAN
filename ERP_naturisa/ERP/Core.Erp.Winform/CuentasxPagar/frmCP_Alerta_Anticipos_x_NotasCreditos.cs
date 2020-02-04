using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Alerta_Anticipos_x_NotasCreditos : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public int IdEmpresa = 0;
        public decimal IProveedor = 0;
        string mensaje = "";

         cp_orden_pago_Bus bus_op = new cp_orden_pago_Bus();
         public List<vwcp_Anticipos_x_NotaCred_Saldo_Info> lista_AnticipoSaldo = new List<vwcp_Anticipos_x_NotaCred_Saldo_Info>();
        
        
        public frmCP_Alerta_Anticipos_x_NotasCreditos()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

      public  void carga_Grid()
        {
            try
            {
                lista_AnticipoSaldo = bus_op.Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(IdEmpresa, IProveedor, ref mensaje);

                if (lista_AnticipoSaldo.Count !=0)
                {                
                    gridControl_Anticipos.DataSource = lista_AnticipoSaldo;                
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void frmCP_Alerta_Anticipos_x_NotasCreditos_Load(object sender, EventArgs e)
        {
            try
            {
                if (lista_AnticipoSaldo.Count != 0)
                {
                    string Proveedor = lista_AnticipoSaldo.FirstOrDefault().Beneficiario;
                    MessageBox.Show("Existen Anticipos o Notas de Créditos Pendientes del Proveedor: " + Proveedor, "Sistemas");
                }
                carga_Grid();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

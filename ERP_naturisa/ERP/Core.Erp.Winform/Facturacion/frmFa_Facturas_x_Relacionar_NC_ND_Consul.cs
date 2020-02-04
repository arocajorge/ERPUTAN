using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Facturas_x_Relacionar_NC_ND_Consul : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<vwFa_Documentos_x_Relacionar_NC_ND_Info> lstCartera = new List<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
        vwFa_Documentos_x_Relacionar_NC_ND_Bus cartera_B = new vwFa_Documentos_x_Relacionar_NC_ND_Bus();
        BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info> DataSource = new BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
        vwFa_Documentos_x_Relacionar_NC_ND_Info Info = new vwFa_Documentos_x_Relacionar_NC_ND_Info();
        
        public frmFa_Facturas_x_Relacionar_NC_ND_Consul()
        {
            InitializeComponent();
        }



        public void Set_Facturas(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.eTipoDocumento_Talonario TipoDoc)
        {
            try
            {
                lstCartera = new List<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
                lstCartera = cartera_B.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(IdEmpresa, IdSucursal, IdCliente);
                if (TipoDoc == Cl_Enumeradores.eTipoDocumento_Talonario.NTDB)
                    lstCartera = lstCartera.Where(c => c.vt_tipoDoc == "NTCR").ToList();
                else
                    lstCartera = lstCartera.Where(c => c.vt_tipoDoc == "FACT" || c.vt_tipoDoc == "NTDB").ToList();
                
                DataSource = new BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info>(lstCartera);
                this.gridControlFacturas.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void gridViewFacturas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info = new vwFa_Documentos_x_Relacionar_NC_ND_Info();
                Info = (vwFa_Documentos_x_Relacionar_NC_ND_Info)gridViewFacturas.GetFocusedRow();
                getObtenerDatos();
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public vwFa_Documentos_x_Relacionar_NC_ND_Info getObtenerDatos()
        {
            try
            {
                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new vwFa_Documentos_x_Relacionar_NC_ND_Info();
            }
        }
    }
}

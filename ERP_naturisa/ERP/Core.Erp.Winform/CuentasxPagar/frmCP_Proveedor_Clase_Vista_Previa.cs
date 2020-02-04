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
using Core.Erp.Winform.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_Clase_Vista_Previa : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_clase_Info InfoClaseProve = new cp_proveedor_clase_Info();
        cp_proveedor_clase_Bus bus_ClaseProve = new cp_proveedor_clase_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
        
        
        public frmCP_Proveedor_Clase_Vista_Previa()
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

        public void set_ProveedorClaseInfo(int IdEmpresa, int IdClaseProveedor)
        {
            try
            {
                InfoClaseProve = bus_ClaseProve.Get_Info_proveedor_clase(IdEmpresa, IdClaseProveedor);

              
                txe_IdClaseProveedor.EditValue = Convert.ToString(InfoClaseProve.IdClaseProveedor);

                txe_codClaseProve.EditValue = InfoClaseProve.cod_clase_proveedor;
                txe_Descripcion.EditValue = InfoClaseProve.descripcion_clas_prove;
                txe_ctacbleAnticipo.EditValue = InfoClaseProve.IdCtaCble_Anticipo;
                txe_ctacbleGasto.EditValue = InfoClaseProve.IdCtaCble_gasto;
                txe_ctacbleCXP.EditValue = InfoClaseProve.IdCtaCble_CXP;
                txe_CentroCosto.EditValue = InfoClaseProve.IdCentroCosto;
                txe_subCentroCosto.EditValue = InfoClaseProve.IdCentroCosto_sub_centro_costo;


                if (InfoClaseProve.Estado == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

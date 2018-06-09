using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCInv_GridCbte_Cble_x_Ing_Egr_Inv : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Ing_Egr_Inven_det_Bus bus_Ing_Egr = new in_Ing_Egr_Inven_det_Bus();
        List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info> lstIng_Egr_Info = new List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info>();
        vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info Ing_Egr_Info = new vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info();


        public UCInv_GridCbte_Cble_x_Ing_Egr_Inv()
        {
            InitializeComponent();
        }


        public void CargarDatos_CbteCble(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, Nullable<decimal> IdNumMovi)
        {
            try
            {
                lstIng_Egr_Info = new List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info>();
                lstIng_Egr_Info = bus_Ing_Egr.Get_List_Ing_Egr_x_Cbte_Cble(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi == null ? 0 : Convert.ToDecimal(IdNumMovi));

                gridCbteCble_Ing_Egr_Inv.DataSource = lstIng_Egr_Info; 

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewCbteCble_Ing_Egr_Inv_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Ing_Egr_Info = (vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info)this.gridViewCbteCble_Ing_Egr_Inv.GetFocusedRow();
                ucCon_GridDiarioContable1.setInfo(Ing_Egr_Info.IdEmpresa_CbteCble, Ing_Egr_Info.IdTipoCbte, Ing_Egr_Info.IdCbteCble);
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

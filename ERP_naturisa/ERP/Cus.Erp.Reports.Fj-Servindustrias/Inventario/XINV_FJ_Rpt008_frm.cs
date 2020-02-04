using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public partial class XINV_FJ_Rpt008_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XINV_FJ_Rpt008_frm()
        {
            InitializeComponent();
        }

        private void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XINV_FJ_Rpt008_Rpt rpt = new XINV_FJ_Rpt008_Rpt();
                rpt.P_IdCentroCosto.Value = ucInv_MenuReportes1.Get_info_centro_costo() == null ? "" : ucInv_MenuReportes1.Get_info_centro_costo().IdCentroCosto;
                rpt.P_IdSucursal.Value = ucInv_MenuReportes1.Get_info_sucursal() == null ? 0 : ucInv_MenuReportes1.Get_info_sucursal().IdSucursal;
                rpt.P_Fecha_ini.Value = ucInv_MenuReportes1.dtpDesde.EditValue;
                rpt.P_Fecha_fin.Value = ucInv_MenuReportes1.dtpHasta.EditValue;
                rpt.RequestParameters = false;
                rpt.P_IdProducto.Value = ucInv_MenuReportes1.Get_info_producto() == null ? 0 : ucInv_MenuReportes1.Get_info_producto().IdProducto;
                List<int> lst_bodega = ucInv_MenuReportes1.Get_list_bodega_chk();
                List<string> lst_subcentro = ucInv_MenuReportes1.Get_list_sub_centro_chk();

                rpt.Set_listas(lst_bodega, lst_subcentro);
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;

                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

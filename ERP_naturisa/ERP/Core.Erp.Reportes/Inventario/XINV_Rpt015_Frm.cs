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

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt015_Frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt015_Frm()
        {
            InitializeComponent();
        }

        private void XINV_Rpt015_Frm_Load(object sender, EventArgs e)
        {

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

        private void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XINV_Rpt015_Rpt rpt = new XINV_Rpt015_Rpt();
                rpt.P_IdSucursal.Value = ucInv_MenuReportes1.Get_info_sucursal() == null ? 0 : ucInv_MenuReportes1.Get_info_sucursal().IdSucursal;
                rpt.P_IdProducto.Value = ucInv_MenuReportes1.Get_info_producto() == null ? 0 : ucInv_MenuReportes1.Get_info_producto().IdProducto;
                rpt.P_Fecha_ini.Value = ucInv_MenuReportes1.dtpDesde.EditValue;
                rpt.P_Fecha_fin.Value = ucInv_MenuReportes1.dtpHasta.EditValue;
                rpt.P_Mostrar_anuladas.Value = ucInv_MenuReportes1.beiCheck1.EditValue == null ? false :ucInv_MenuReportes1.beiCheck1.EditValue;
                rpt.P_IdCentroCosto.Value = ucInv_MenuReportes1.Get_info_centro_costo() == null ? "" : ucInv_MenuReportes1.Get_info_centro_costo().IdCentroCosto;
                rpt.Set_listas(ucInv_MenuReportes1.Get_list_bodega_chk(), ucInv_MenuReportes1.Get_list_sub_centro_chk());
                
                rpt.RequestParameters = false;

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
    }
}

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
    public partial class XINV_Rpt028_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt028_frm()
        {
            InitializeComponent();
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
                XINV_Rpt028_Rpt rpt = new XINV_Rpt028_Rpt();
                rpt.P_IdProveedor.Value = ucInv_MenuReportes1.Get_info_proveedor() == null ? 0 : ucInv_MenuReportes1.Get_info_proveedor().IdProveedor;
                rpt.P_IdProducto.Value = ucInv_MenuReportes1.Get_info_producto() == null ? 0 : ucInv_MenuReportes1.Get_info_producto().IdProducto;
                rpt.P_IdOrdenCompra.Value = ucInv_MenuReportes1.txt_num_transaccion.EditValue == null ? 0 : Convert.ToDecimal(ucInv_MenuReportes1.txt_num_transaccion.EditValue);
                rpt.P_IdSucursal.Value = ucInv_MenuReportes1.Get_info_sucursal() == null ? 0 : ucInv_MenuReportes1.Get_info_sucursal().IdSucursal;
                rpt.P_Fecha_ini.Value = ucInv_MenuReportes1.dtpDesde.EditValue;
                rpt.P_Fecha_fin.Value = ucInv_MenuReportes1.dtpHasta.EditValue;
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

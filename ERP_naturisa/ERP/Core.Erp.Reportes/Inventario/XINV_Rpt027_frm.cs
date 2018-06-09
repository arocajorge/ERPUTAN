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
    public partial class XINV_Rpt027_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt027_frm()
        {
            InitializeComponent();
        }

        private void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool Mostrar_detallado = ucInv_MenuReportes1.beiCheck1.EditValue == null ? false : Convert.ToBoolean(ucInv_MenuReportes1.beiCheck1.EditValue);
                if (!Mostrar_detallado)
                {
                    XINV_Rpt027_Rpt rpt = new XINV_Rpt027_Rpt();
                    rpt.P_Fecha_desde.Value = ucInv_MenuReportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue);
                    rpt.P_Fecha_hasta.Value = ucInv_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue);
                    rpt.P_IdSucursal.Value = ucInv_MenuReportes1.Get_info_sucursal() == null ? 0 : ucInv_MenuReportes1.Get_info_sucursal().IdSucursal;
                    //rpt.P_IdBodega.Value = ucInv_MenuReportes1.Get_info_bodega() == null ? 0 : ucInv_MenuReportes1.Get_info_bodega().IdBodega;
                    rpt.Set_lst_bodega(ucInv_MenuReportes1.Get_list_bodega_chk());
                    rpt.P_IdProducto.Value = ucInv_MenuReportes1.Get_info_producto() == null ? 0 : ucInv_MenuReportes1.Get_info_producto().IdProducto;
                    rpt.P_Mostrar_detallado.Value = Mostrar_detallado;
                    rpt.P_Mostrar_registros_0.Value = ucInv_MenuReportes1.beiCheck2.EditValue == null ? false : Convert.ToBoolean(ucInv_MenuReportes1.beiCheck2.EditValue);
                    rpt.RequestParameters = false;

                    ReportPrintTool pt = new ReportPrintTool(rpt);
                    printControl1.PrintingSystem = rpt.PrintingSystem;
                    splashScreenManager1.ShowWaitForm();
                    rpt.CreateDocument();
                    splashScreenManager1.CloseWaitForm();
                }
                else
                {
                    XINV_Rpt027_Rpt_detallado rpt = new XINV_Rpt027_Rpt_detallado();
                    rpt.P_Fecha_desde.Value = ucInv_MenuReportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue);
                    rpt.P_Fecha_hasta.Value = ucInv_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue);
                    rpt.P_IdSucursal.Value = ucInv_MenuReportes1.Get_info_sucursal() == null ? 0 : ucInv_MenuReportes1.Get_info_sucursal().IdSucursal;
                    //rpt.P_IdBodega.Value = ucInv_MenuReportes1.Get_info_bodega() == null ? 0 : ucInv_MenuReportes1.Get_info_bodega().IdBodega;
                    rpt.Set_lst_bodega(ucInv_MenuReportes1.Get_list_bodega_chk());
                    rpt.P_IdProducto.Value = ucInv_MenuReportes1.Get_info_producto() == null ? 0 : ucInv_MenuReportes1.Get_info_producto().IdProducto;
                    rpt.P_Mostrar_detallado.Value = Mostrar_detallado;
                    rpt.P_Mostrar_registros_0.Value = ucInv_MenuReportes1.beiCheck2.EditValue == null ? false : Convert.ToBoolean(ucInv_MenuReportes1.beiCheck2.EditValue);
                    rpt.RequestParameters = false;

                    ReportPrintTool pt = new ReportPrintTool(rpt);
                    printControl1.PrintingSystem = rpt.PrintingSystem;
                    splashScreenManager1.ShowWaitForm();
                    rpt.CreateDocument();
                    splashScreenManager1.CloseWaitForm();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashScreenManager1.CloseWaitForm();
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

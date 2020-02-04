using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Compras;
using Cus.Erp.Reports.Naturisa.Inventario;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_OrdenCompra_x_Guia_x_traspaso_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_Guia_x_traspaso_bodega_Info info_guia = new in_Guia_x_traspaso_bodega_Info();
        List<in_Guia_x_traspaso_bodega_Info> List_Guia = new List<in_Guia_x_traspaso_bodega_Info>();
        in_Guia_x_traspaso_bodega_Bus bus_guia = new in_Guia_x_traspaso_bodega_Bus();

        com_ordencompra_local_Info info_OC = new com_ordencompra_local_Info();

        public void Set_info_OC(com_ordencompra_local_Info Orden)
        {
            try
            {
                info_OC = Orden;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int RowHandle = 0;

        public FrmCom_OrdenCompra_x_Guia_x_traspaso_Cons()
        {
            InitializeComponent();
        }

        private void FrmCom_OrdenCompra_x_Guia_x_traspaso_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                List_Guia = bus_guia.Get_List_OC_x_in_Guia(info_OC.IdEmpresa, info_OC.IdSucursal, info_OC.IdOrdenCompra);
                gridControl_OC_x_Guia.DataSource = List_Guia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                info_guia = (in_Guia_x_traspaso_bodega_Info) gridView_OC_x_Guia.GetRow(RowHandle);
                if (info_guia!=null)
                {
                    XINV_NAT_Rpt001_Rpt Reporte = new XINV_NAT_Rpt001_Rpt();
                    Reporte.PIdEmpresa.Value = param.IdEmpresa;
                    Reporte.PIdGuia.Value = info_guia.IdGuia;

                    Reporte.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;

                    Reporte.ShowPreviewDialog();    
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_OC_x_Guia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

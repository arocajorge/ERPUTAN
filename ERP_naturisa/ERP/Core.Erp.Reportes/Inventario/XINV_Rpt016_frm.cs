using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Reportes.Inventario;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
       
namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt016_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt016_frm()
        {
            InitializeComponent();
        }

        private void XINV_Rpt016_frm_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        public void CargarCombos()
        {
            try
            {

                date_Fecha_Ini.Value=DateTime.Now;
                date_Fecha_Fin.Value = DateTime.Now;
                ucGe_Sucursal1.Get_IdSucursal();
                uCct_CentroCosto1.Get_IdCentroCosto();//error en el control usuario
                uCct_Pto_Cargo1.Get_Id_Pto_Cargo();
                uCin_Producto1.Get_Id_ProductoIni();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btn_Generar_rpt_Click(object sender, EventArgs e)
        {
            try
            {
                CargarReporte();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }


        void CargarReporte()
        {
            try
            {
                XINV_Rpt016_Rpt Reporte = new XINV_Rpt016_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["P_IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["P_IdSucursal"].Value = ucGe_Sucursal1.Get_IdSucursal();
                Reporte.Parameters["P_IdCentroCosto"].Value = uCct_CentroCosto1.Get_IdCentroCosto();
                Reporte.Parameters["P_IdSubCentroCosto"].Value = uCct_CentroCosto1.Get_IdSubCentro_Costo();
                Reporte.Parameters["P_IdPtoCargo"].Value = ucGe_Sucursal1.Get_IdSucursal();
                Reporte.Parameters["P_IdProductoIni"].Value = uCin_Producto1.Get_Id_ProductoIni();
                Reporte.Parameters["P_IdProductoFin"].Value = uCin_Producto1.Get_Id_ProductoFin();
                Reporte.Parameters["P_FechaIni"].Value = date_Fecha_Ini.Value;
                Reporte.Parameters["P_FechaFin"].Value = date_Fecha_Fin.Value;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

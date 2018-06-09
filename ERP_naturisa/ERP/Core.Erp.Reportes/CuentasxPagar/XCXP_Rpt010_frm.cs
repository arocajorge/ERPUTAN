using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Reportes.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt010_frm : Form
    {

        List<cp_proveedor_Info> ListproveedorInfo = new List<cp_proveedor_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt010_frm_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {

                XCXP_Rpt010_rpt Reporte = new XCXP_Rpt010_rpt();
        
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                
                pt.AutoShowParametersPanel = false;

                
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;                
                Reporte.Parameters["IdProveedorIni"].Value = (cmbProveedor.EditValue == null) ? 0 : cmbProveedor.EditValue;
                Reporte.Parameters["IdProveedorFin"].Value = (cmbProveedor.EditValue == null || Convert.ToDecimal(cmbProveedor.EditValue) == 0) ? 999999 : cmbProveedor.EditValue; 
                Reporte.Parameters["FechaIni"].Value = dtp_desde.Value;
                Reporte.Parameters["FechaFin"].Value = dtp_hasta.Value;
               

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarCombo()
        {
            try
            {
                cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
                ListproveedorInfo = proveedorBus.Get_List_proveedor(param.IdEmpresa);

                cp_proveedor_Info InfoTodos = new cp_proveedor_Info();
                InfoTodos.IdEmpresa = param.IdEmpresa;
                InfoTodos.IdProveedor = 0;
                InfoTodos.pr_nombre2 = "Todos";
                InfoTodos.pr_nombre = "Todos";
                ListproveedorInfo.Add(InfoTodos);

                cmbProveedor.Properties.DataSource = ListproveedorInfo;                
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

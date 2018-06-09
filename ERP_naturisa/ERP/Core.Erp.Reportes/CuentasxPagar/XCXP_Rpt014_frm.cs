using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt014_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cp_proveedor_Info> ListproveedorInfo = new List<cp_proveedor_Info>();
        cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt014_frm()
        {
            InitializeComponent();
            ListproveedorInfo = proveedorBus.Get_List_proveedor(param.IdEmpresa);

            cp_proveedor_Info InfoTodos= new cp_proveedor_Info();
            InfoTodos.IdEmpresa = param.IdEmpresa;
            InfoTodos.IdProveedor = 0;
            InfoTodos.pr_nombre2 = "Todos";
            InfoTodos.pr_nombre = "Todos";
            ListproveedorInfo.Add(InfoTodos);


            cmb_Proveedor.Properties.DataSource = ListproveedorInfo;
            cmb_Proveedor.Properties.DisplayMember = "pr_nombre2";
            cmb_Proveedor.Properties.ValueMember = "IdProveedor";
            
        }
       
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                XCXP_Rpt014_rpt Reporte = new XCXP_Rpt014_rpt();

                DateTime FechaCorte = Convert.ToDateTime(dtp_FechaIni.Value.ToShortDateString());
                Decimal IdProveedor = Convert.ToDecimal(cmb_Proveedor.EditValue);
                XCXP_Rpt014_Bus bus = new XCXP_Rpt014_Bus();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;
                Reporte.DataSource = bus.GetData(param.IdEmpresa, FechaCorte, IdProveedor);
                Reporte.lblFechaCorte.Text = dtp_FechaIni.Text;
                Reporte.lblUsuario.Text = param.IdUsuario;
                Reporte.ptbLogo.Image = param.InfoEmpresa.em_logo_Image;
                ReportPrintTool_.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

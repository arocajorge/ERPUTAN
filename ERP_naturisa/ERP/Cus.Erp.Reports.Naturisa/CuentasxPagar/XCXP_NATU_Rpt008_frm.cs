using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt008_frm : Form
    {
        cp_proveedor_clase_Bus bus_ClaseProv = new cp_proveedor_clase_Bus();
        List<cp_proveedor_clase_Info> lista_ClaseProv = new List<cp_proveedor_clase_Info>();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<cp_proveedor_Info> lista_proveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();
        
        public XCXP_NATU_Rpt008_frm()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XCXP_NATU_Rpt008_frm_Load(object sender, EventArgs e)
        {
            try
            {
                dte_FechaIni.EditValue = new DateTime(2015,01,01);
                dte_FechaFin.EditValue = DateTime.Now; 
                lista_ClaseProv = bus_ClaseProv.Get_List_proveedor_clase(param.IdEmpresa);

                cmb_ClaseProveedor.Properties.DataSource = lista_ClaseProv;
                cmb_ClaseProveedor.Properties.DisplayMember = "descripcion_clas_prove";
                cmb_ClaseProveedor.Properties.ValueMember= "IdClaseProveedor";

                lista_proveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_Proveedor.Properties.DataSource = lista_proveedor;
                cmb_Proveedor.Properties.DisplayMember = "pr_nombre_codigo";
                cmb_Proveedor.Properties.ValueMember = "IdProveedor";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            try
            {

                string S_ProveedorClase = "";
                
                XCXP_NATU_Rpt008_rpt Reporte = new XCXP_NATU_Rpt008_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["FechaIni"].Value = dte_FechaIni.EditValue;
                Reporte.Parameters["FechaFin"].Value = dte_FechaFin.EditValue;

                Reporte.Parameters["IdProveedorClaseIni"].Value = cmb_ClaseProveedor.EditValue==null ? 0 : cmb_ClaseProveedor.EditValue;
                Reporte.Parameters["IdProveedorClaseFin"].Value = cmb_ClaseProveedor.EditValue==null ? 9999: cmb_ClaseProveedor.EditValue;

                Reporte.Parameters["P_IdProveedorIni"].Value = cmb_Proveedor.EditValue == null ? 0 : cmb_Proveedor.EditValue;
                Reporte.Parameters["P_IdProveedorFin"].Value = cmb_Proveedor.EditValue == null ? 9999 : cmb_Proveedor.EditValue;

                Reporte.Parameters["S_Proveedor"].Value = cmb_Proveedor.EditValue == null ? "Todos" : cmb_Proveedor.Properties.GetDisplayText(cmb_Proveedor.EditValue);
                Reporte.Parameters["P_Mostrar_saldo_cero"].Value = chk_mostrar_saldo_cero.Checked;
                Reporte.Parameters["S_FechaIni"].Value = Convert.ToDateTime(dte_FechaIni.EditValue).ToShortDateString();
                Reporte.Parameters["S_FechaFin"].Value = Convert.ToDateTime(dte_FechaFin.EditValue).ToShortDateString();

                if (Convert.ToDecimal(cmb_ClaseProveedor.EditValue)==0)
                {
                    S_ProveedorClase = "TODOS";
                
                }
                else
                {
                    S_ProveedorClase = cmb_ClaseProveedor.Text;
                
                }

                Reporte.Parameters["S_ProveedorClase"].Value = S_ProveedorClase;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}

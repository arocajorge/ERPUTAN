using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.ActivoFijo;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt012_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XACTF_Rpt012_frm()
        {
            InitializeComponent();
            ucactF_Menu_Reportes1.event_delegate_cmb_tipoActivo_EditValueChanged += ucactF_Menu_Reportes1_event_delegate_cmb_tipoActivo_EditValueChanged;
        }

        void ucactF_Menu_Reportes1_event_delegate_cmb_tipoActivo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ucactF_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucactF_Menu_Reportes1_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (ucactF_Menu_Reportes1.barEditItemTipoImpresion.EditValue == "Detallado")
                {
                    XACTF_Rpt012_rpt Reporte = new XACTF_Rpt012_rpt();
                    Reporte.RequestParameters = false;
                    ReportPrintTool pt = new ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;


                    Reporte.Parameters["PIdEmpresa"].Value = param.IdEmpresa;
                    Reporte.Parameters["PIdSucursal"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue);
                    Reporte.Parameters["PIdDepartamento"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.cmb_departamento_.EditValue);
                    Reporte.Parameters["PIdTipoAF"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemTipoActivo.EditValue);
                    Reporte.Parameters["PFechaCorte"].Value = Convert.ToDateTime(ucactF_Menu_Reportes1.barEditItemFechaCorte.EditValue);
                    Reporte.Parameters["PIdCategoriaAF"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemCategoria.EditValue);
                    printControl1.PrintingSystem = Reporte.PrintingSystem;
                    Reporte.CreateDocument();
                }
                else
                    if (ucactF_Menu_Reportes1.barEditItemTipoImpresion.EditValue == "Resumido")
                    {
                        XACTF_Rpt014_Rpt Reporte = new XACTF_Rpt014_Rpt();
                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;


                        Reporte.Parameters["PidEmpresa"].Value = param.IdEmpresa;
                        Reporte.Parameters["PidSucursal"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemSucursal.EditValue);
                        Reporte.Parameters["PidTipoAF"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemTipoActivo.EditValue);
                        Reporte.Parameters["PidCategoriaAF"].Value = Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemCategoria.EditValue);
                        Reporte.Parameters["PFecha_corte"].Value = Convert.ToDateTime(ucactF_Menu_Reportes1.barEditItemFechaCorte.EditValue);
                        printControl1.PrintingSystem = Reporte.PrintingSystem;
                        Reporte.CreateDocument();
                    }
                    else
                        MessageBox.Show("Para continuar escoja un Tipo de impresión", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XACTF_Rpt012_frm_Load(object sender, EventArgs e)
        {

        }
    }
}

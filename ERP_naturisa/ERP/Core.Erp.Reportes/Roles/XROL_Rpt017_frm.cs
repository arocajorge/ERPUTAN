using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt017_frm : Form
    {
        public XROL_Rpt017_frm()
        {
            InitializeComponent();
        }
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        private void XROL_Rpt017_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (System.Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Cargar_Datos()
        {

            try
            {
                dtp_fecha_fin.EditValue = DateTime.Now;
                dtp_fecha_inicio.EditValue = DateTime.Now.AddMonths(-1);
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;


                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt017_Rpt Reporte = new XROL_Rpt017_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["s_fechaInicial"].Value = Convert.ToDateTime(dtp_fecha_inicio.EditValue);
                Reporte.Parameters["s_fechaFinal"].Value = Convert.ToDateTime(dtp_fecha_fin.EditValue);               
                Reporte.Parameters["p_idnomina"].Value = cmbnomina.EditValue == "" ? 0 : Convert.ToInt32(cmbnomina.EditValue);
                Reporte.Parameters["CodCtbteCble"].Value = cmbTipoComprobante.Text;
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbGenerar_Click(object sender, System.EventArgs e)
        {
            try
            {
                pu_GenerarReporte();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Cmbsalir_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

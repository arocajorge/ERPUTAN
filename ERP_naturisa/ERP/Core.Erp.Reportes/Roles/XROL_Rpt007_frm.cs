using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
/*CLASE: XROL_Rpt007_frm
 *CREADA POR: ALBERTO MENA
 *FECHA: 24-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt007_frm : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        int _idEmpresa = 0;
        decimal _idEmpleado = 0;
        decimal _idActaFiniquito = 0;

        public XROL_Rpt007_frm()
        {
            InitializeComponent();
        }

        void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            pu_CargarReporte();
        }

        void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }


        private void pu_CargarReporte() {
            try
            {
                XROL_Rpt007_rpt Reporte = new XROL_Rpt007_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["p_IdEmpresa"].Value = _idEmpresa;
                Reporte.Parameters["p_IdEmpleado"].Value = _idEmpleado;
                Reporte.Parameters["p_IdActaFiniquito"].Value =_idActaFiniquito ;

                Reporte.Parameters["s_fechaImpresion"].Value = param.Fecha_Transac;
                Reporte.Parameters["s_idUsuario"].Value = param.IdUsuario.Trim();

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        public void setInfo(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito)
        {
            try
            {
                _idEmpresa = idEmpresa;
                _idEmpleado = idEmpleado;
                _idActaFiniquito = idActaFiniquito;

                pu_CargarReporte();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void XROL_Rpt007_frm_Load(object sender, EventArgs e)
        {        

        }

       
    }
}

/*CLASE: XROL_Rpt008_frm
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
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

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt008_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        int _idEmpresa = 0;
        int _periodoFiscal = 0;
    

        public XROL_Rpt008_frm()
        {
            InitializeComponent();
        }

        private void XROL_Rpt008_frm_Load(object sender, EventArgs e)
        {
            pu_CargarInicial();
        }


        private void pu_CargarInicial()
        {
            try
            {

                int anioActual = 0;
                anioActual = param.Fecha_Transac.Year;

                for (int i = 5; i > 0; i--)
                {
                    cmbPeriodo.Items.Add(anioActual);
                    anioActual -= 1;
                }

                if (cmbPeriodo.Items.Count > 0)
                {
                    cmbPeriodo.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setInfo(int idEmpresa, int periodoFiscal)
        {
            try
            {
                _idEmpresa = idEmpresa;
                _periodoFiscal = periodoFiscal;
                pu_CargarReporte();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CargarReporte()
        {
            try
            {
                XROL_Rpt008_rpt Reporte = new XROL_Rpt008_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["p_IdEmpresa"].Value = _idEmpresa;
                Reporte.Parameters["p_PeriodoFiscal"].Value = _periodoFiscal;

                Reporte.Parameters["s_FechaImpresion"].Value = param.Fecha_Transac;
                Reporte.Parameters["s_IdUsuario"].Value = param.IdUsuario.Trim();

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void cmdCargarReporte_Click(object sender, EventArgs e)
        {
            if (getInfo())
            {
                pu_CargarReporte();
            }
        }



        private Boolean getInfo() {
            try {

                _idEmpresa = param.IdEmpresa;
                _periodoFiscal = Convert.ToInt32(cmbPeriodo.Text);

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
       
        }
    
    
    }
}

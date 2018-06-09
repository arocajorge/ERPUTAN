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
    public partial class XROL_Rpt025_frm : Form
    {
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;



        int _idEmpresa = 0;
        int _idNominaTipo = 0;
        int _idNominaTipoLiqui = 0;
        int _idPeriodo = 0;
        decimal _idDivision = 0;
        decimal _idEmpleado = 0;
        string _idCentroCosto = "";


        public XROL_Rpt025_frm()
        {
            InitializeComponent();
        }


        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            pu_GenerarReporte();
        }

  

        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt025_rpt Reporte = new XROL_Rpt025_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["s_fechaInicial"].Value = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaInicial());
                Reporte.Parameters["s_fechaFinal"].Value = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaFinal());
                Reporte.Parameters["p_IdDepartamento"].Value = ucRo_Menu_Reportes.getIdDepartamento() == "" ? 0 :Convert.ToInt32( ucRo_Menu_Reportes.getIdDepartamento());
                Reporte.Parameters["p_IdEmpleado"].Value = ucRo_Menu_Reportes.getIdEmpleado();
                Reporte.Parameters["p_IdRubro"].Value = ucRo_Menu_Reportes.getIdRubro();           

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
               // Reporte.ShowPreview();
            } 
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void XROL_Rpt025_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucRo_Menu_Reportes.VisibleGrupoFiltro1 = false;
                ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
                ucRo_Menu_Reportes.VisibleGrupoFecha = true;
                ucRo_Menu_Reportes.VisibleCmbNominaTipo = BarItemVisibility.Never;

                ucRo_Menu_Reportes.setFechaInicial(DateTime.Now.ToShortDateString());
                ucRo_Menu_Reportes.setFechaFinal(DateTime.Now.ToShortDateString());


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        }

        private void ucRo_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes1_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (pu_Validar())
                {
                    _idEmpresa = param.IdEmpresa;
                    _idDivision = Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision() == "" ? 0 : Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision()));
                    _idCentroCosto = ucRo_Menu_Reportes.getIdCentroCosto();
                  
                    pu_GenerarReporte();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        }


        private Boolean pu_Validar()
        {
            try
            {






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

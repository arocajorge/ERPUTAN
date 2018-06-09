/*CLASE: XROL_Rpt010_frm
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using DevExpress.XtraBars;
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
    public partial class XROL_Rpt010_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();

        int _idEmpresa = 0;
        decimal _idEmpleado = 0;
        int _IdDepartamento = 0;
        DateTime _fechaInicial;
        DateTime _fechaFinal;


        public XROL_Rpt010_frm()
        {
            InitializeComponent();

            ucRo_Menu_Reportes.event_btnsalir_ItemClick += ucRo_Menu_Reportes_event_btnsalir_ItemClick;

            ucRo_Menu_Reportes.event_cmdCargar_ItemClick += ucRo_Menu_Reportes_event_cmdCargar_ItemClick;
        }

        void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (getInfo())
            {
                pu_CargarReporte();
            }
        }

        void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XROL_Rpt010_frm_Load(object sender, EventArgs e)
        {
            ucRo_Menu_Reportes.VisibleGrupoFiltro1 = false;
            ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
            ucRo_Menu_Reportes.VisibleGrupoFecha = true;
            ucRo_Menu_Reportes.VisibleCmbDivision = BarItemVisibility.Never;
            ucRo_Menu_Reportes.VisibleCmbCentroCosto = BarItemVisibility.Never;
            ucRo_Menu_Reportes.VisibleCmbRubro= BarItemVisibility.Never;
            ucRo_Menu_Reportes.VisibleCmbEmpleado = BarItemVisibility.Always;


            ucRo_Menu_Reportes.setFechaInicial(param.Fecha_Transac.ToShortDateString());
            ucRo_Menu_Reportes.setFechaFinal(param.Fecha_Transac.ToShortDateString());

    
        }


        private Boolean getInfo() {
            try {
                _idEmpresa = param.IdEmpresa;
                _IdDepartamento = Convert.ToInt32(ucRo_Menu_Reportes.getIdDepartamento());
                _idEmpleado = Convert.ToDecimal(ucRo_Menu_Reportes.getIdEmpleado());
                _fechaInicial = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaInicial());
                _fechaFinal = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaFinal());

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }




        private void pu_CargarReporte()
        {
            try
            {
                XROL_Rpt010_rpt Reporte = new XROL_Rpt010_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["p_IdEmpresa"].Value = _idEmpresa;
                Reporte.Parameters["p_IdDepartamento"].Value = _IdDepartamento;
                Reporte.Parameters["p_IdEmpleado"].Value = _idEmpleado;
                Reporte.Parameters["s_fechaInicial"].Value = _fechaInicial;
                Reporte.Parameters["s_fechaFinal"].Value = _fechaFinal;
                

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

     

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;



namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt006_frm : Form
    {
        int _idEmpresa = 0;
        int _idNominaTipo = 0;
        int _idNominaTipoLiqui = 0;
        int _idPeriodo = 0;
        decimal _idDivision = 0;
        string _idCentroCosto = "";

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XROL_Rpt006_frm()
        {
            InitializeComponent();
        }


        public XROL_Rpt006_frm(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo):this() 
        {
            try
            {
                _idEmpresa = idEmpresa;
                _idNominaTipo = idNominaTipo;
                _idNominaTipoLiqui = idNominaTipoLiqui;
                _idPeriodo = idPeriodo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setInfo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
        {
            try
            {
                _idEmpresa = idEmpresa;
                _idNominaTipo = idNominaTipo;
                _idNominaTipoLiqui = idNominaTipoLiqui;
                _idPeriodo = idPeriodo;

                ucRo_Menu_Reportes.setIdNominaTipo(_idNominaTipo);
                ucRo_Menu_Reportes.setIdNominaTipoLiqui(_idNominaTipoLiqui);
                ucRo_Menu_Reportes.setIdPeriodo(_idPeriodo);                

                pu_Imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void XROL_Rpt006_frm_Load(object sender, EventArgs e)
        {

            ucRo_Menu_Reportes.VisibleGrupoFiltro1 = true;
            ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
            ucRo_Menu_Reportes.VisibleGrupoFecha = false;
            ucRo_Menu_Reportes.VisibleCmbEmpleado = BarItemVisibility.Never;
        }


        private void pu_Imprimir()
        {
            try
            {
                XROL_Rpt006_rpt Reporte = new XROL_Rpt006_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["p_IdNominaTipo"].Value = _idNominaTipo;
                Reporte.Parameters["p_IdNominaTipoLiqui"].Value = _idNominaTipoLiqui;
                Reporte.Parameters["p_IdPeriodo"].Value = _idPeriodo;
                Reporte.Parameters["p_IdDivision"].Value = _idDivision;
                Reporte.Parameters["p_IdCentroCosto"].Value = _idCentroCosto;
                Reporte.Parameters["s_CentroCosto"].Value = ucRo_Menu_Reportes.getDescripcionCentroCosto();
                Reporte.Parameters["s_Division"].Value = ucRo_Menu_Reportes.getDescripcionDivision();
                Reporte.Parameters["iddepartamento"].Value = ucRo_Menu_Reportes.getIdDepartamento();

              
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pu_Imprimir();
        }



        private Boolean pu_Validar() {
            try {






                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }        
        }
 
        private void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (pu_Validar())
                {
                    _idEmpresa = param.IdEmpresa;
                    _idNominaTipo = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipo());
                    _idNominaTipoLiqui = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipoLiqui());
                    _idPeriodo = Convert.ToInt32(ucRo_Menu_Reportes.getIdPeriodo());
                    _idDivision = Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision() == "" ? 0 : Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision()));
                    _idCentroCosto = ucRo_Menu_Reportes.getIdCentroCosto();

                    pu_Imprimir();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }   
        }

        private void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes_event_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }



    }
}

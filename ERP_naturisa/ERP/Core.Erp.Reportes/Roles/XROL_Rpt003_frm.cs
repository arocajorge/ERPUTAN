using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt003_frm : Form
    {
        int _idEmpresa;
        decimal _idEmpleado;
        int _idNominaTipo;
        int _idNominaTipoLiqui;
        int _idPeriodo;
        int _IdDepartamento = 0;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Empleado_Info> ListaE = new List<ro_Empleado_Info>();
        ro_Empleado_Bus BusE = new ro_Empleado_Bus();

        public XROL_Rpt003_frm()
        {
            InitializeComponent();
            _idEmpresa = param.IdEmpresa;
        }


        public XROL_Rpt003_frm(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
        {
            InitializeComponent();

             _idEmpresa=idEmpresa;
             _idEmpleado=idEmpleado;
             _idNominaTipo=idNominaTipo;
             _idNominaTipoLiqui=idNominaTipoLiqui;
             _idPeriodo=idPeriodo;

             ucRo_Menu_Reportes.setIdNominaTipo(_idNominaTipo);
             ucRo_Menu_Reportes.setIdNominaTipoLiqui(_idNominaTipoLiqui);
             ucRo_Menu_Reportes.setIdPeriodo(_idPeriodo);
             ucRo_Menu_Reportes.setIdEmpleado(_idEmpleado);

        }

        private void XROL_Rpt003_frm_Load(object sender, EventArgs e)
        {
            ucRo_Menu_Reportes.VisibleGrupoFiltro1 = true;
            ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
            ucRo_Menu_Reportes.VisibleGrupoFecha = false;
            ucRo_Menu_Reportes.VisibleCmbEmpleado = BarItemVisibility.Always;
            ucRo_Menu_Reportes.VisibleCmbCentroCosto= BarItemVisibility.Never;
            ucRo_Menu_Reportes.VisibleCmbDivision= BarItemVisibility.Never;

          //  pu_GenerarReporte();
        }


        private Boolean pu_setInfo() {
            try {
                _idNominaTipo = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipo());
                _idNominaTipoLiqui = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipoLiqui());
                _idPeriodo = Convert.ToInt32(ucRo_Menu_Reportes.getIdPeriodo());
                _idEmpleado = Convert.ToInt32(ucRo_Menu_Reportes.getIdEmpleado());
                if (ucRo_Menu_Reportes.getIdDepartamento() != "")
                {
                    _IdDepartamento = Convert.ToInt32(ucRo_Menu_Reportes.getIdDepartamento());
                }
                else
                {
                    _IdDepartamento = 0;
                }
                _idEmpleado = Convert.ToInt32(ucRo_Menu_Reportes.getIdEmpleado());
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }       
        }


        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt012_rpt Reporte = new XROL_Rpt012_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                if (pu_setInfo())
                {
                    Reporte.Parameters["PIdEmpresa"].Value = _idEmpresa;
                    Reporte.Parameters["PIdNomina_Tipo"].Value = _idNominaTipo;
                    Reporte.Parameters["PIdNominaTipoLiqui"].Value = _idNominaTipoLiqui;
                    Reporte.Parameters["PIdPeriodo"].Value = _idPeriodo;

                    if (_idEmpleado != 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo).Where(v => v.IdEmpleado == _idEmpleado).ToList().OrderBy(x => x.pe_apellido).ToList();
                    }

                    if (_IdDepartamento != 0 && _idEmpleado == 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo).Where(v => v.IdDepartamento == _IdDepartamento).ToList().OrderBy(x => x.pe_apellido).ToList();
                    }

                    if (_idEmpleado == 0 && _IdDepartamento == 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo);
                    }

                    if (ListaE.Count() == 0)
                    {
                        MessageBox.Show("No hay datos para la consulta", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                    {
                        Reporte.ListEmpleado(ListaE);
                        Reporte.Landscape = true;
                        Reporte.ShowPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            pu_GenerarReporte();
        }

        private void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            pu_GenerarReporte();
        }

        private void ucRo_Menu_Reportes_Load(object sender, EventArgs e)
        {

        }

    }
}

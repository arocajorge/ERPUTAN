using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public partial class XCXC_GRAF_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        int IdEmpresa = 0;
        int IdVendedor = 0;
        DateTime FechaIni, FechaFin;
        List<string> lst_TipoCobro = new List<string>();

        public XCXC_GRAF_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(int _IdEmpresa, int _IdVendedor, DateTime _FechaIni, DateTime _FechaFin, List<string> _lst_TipoCobro)
        {

            try
            {
                this.PIdEmpresa.Value = _IdEmpresa;
                this.PIdEmpresa.Visible = false;

                this.PIdVendedor.Value = _IdVendedor;
                this.PIdVendedor.Visible = false;

                this.PFechaIni.Value = _FechaIni;
                this.PFechaIni.Visible = false;

                this.PFechaFin.Value = _FechaFin;
                this.PFechaFin.Visible = false;

                lst_TipoCobro = _lst_TipoCobro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt001_Rpt) };
            }
        }

        private void XCXC_GRAF_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLEmpresa.Text = param.InfoEmpresa.em_nombre;
                xrLUsuario.Text = param.IdUsuario;
                xrLFecha.Text = Convert.ToString(param.Fecha_Transac);

                XCXC_GRAF_Rpt001_Bus Bus_Reporte = new XCXC_GRAF_Rpt001_Bus();
                List<XCXC_GRAF_Rpt001_Info> List_Reporte = new List<XCXC_GRAF_Rpt001_Info>();
                
                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdVendedor = Convert.ToInt32(this.PIdVendedor.Value);
                FechaIni = Convert.ToDateTime(this.PFechaIni.Value).Date;
                FechaFin = Convert.ToDateTime(this.PFechaFin.Value).Date;

                List_Reporte = Bus_Reporte.Get_list_x_empresa(IdEmpresa, IdVendedor, FechaIni, FechaFin, lst_TipoCobro);
                this.DataSource = List_Reporte.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_GRAF_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt001_Rpt) };
            }
        }
    }
}

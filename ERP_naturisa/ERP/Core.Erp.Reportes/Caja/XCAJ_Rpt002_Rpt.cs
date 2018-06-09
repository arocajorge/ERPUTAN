using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XCAJ_Rpt002_Rpt()
        {
            InitializeComponent();
            lblusuario.Text = param.IdUsuario.ToString();
            lblfechaHoy.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCAJ_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCAJ_Rpt002_Bus Rpt_Bus = new XCAJ_Rpt002_Bus();
                List<XCAJ_Rpt002_Info> ListRpt = new List<XCAJ_Rpt002_Info>();

                int IdEmpresa=0;
                int IdCajaIni=0;
                int IdCajaFin=0;
                int IdTipoMoviIni=0;
                int IdTipoMoviFin=0;
                string TipoIngrEgr="";
                DateTime FechaIni;
                DateTime FechaFin;
                decimal IdPersonaIni = 0;
                decimal IdPersonaFin = 0;
                decimal IdEntidadIni = 0;
                decimal IdEntidadFin = 0;
                int IdTipoFlujoIni=0;
                int IdTipoFlujoFin=0;
                string IdTipo_Persona = "";

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCajaIni = Convert.ToInt32(this.PIdCajaIni.Value);
                IdCajaFin = Convert.ToInt32(this.PIdCajaFin.Value);
                IdTipoMoviIni = Convert.ToInt32(this.PIdTipoMoviIni.Value);
                IdTipoMoviFin = Convert.ToInt32(this.PIdTipoMoviFin.Value);
                TipoIngrEgr = Convert.ToString(this.PTipoIngrEgr.Value);
                FechaIni = Convert.ToDateTime(this.PFechaIni.Value);
                FechaFin = Convert.ToDateTime(this.PFechaFin.Value);
                IdPersonaIni = Convert.ToDecimal(this.PIdPersonaIni.Value);
                IdPersonaFin = Convert.ToDecimal(this.PIdPersonaFin.Value);
                IdEntidadIni = Convert.ToDecimal(this.PIdEntidadIni.Value);
                IdEntidadFin = Convert.ToDecimal(this.PIdEntidadFin.Value);
                IdTipoFlujoIni = Convert.ToInt32(this.PIdTipoFlujoIni.Value);
                IdTipoFlujoFin = Convert.ToInt32(this.PIdTipoFlujoFin.Value);
                IdTipo_Persona = Convert.ToString(this.PIdTipo_Persona.Value);

                ListRpt = Rpt_Bus.Get_List(IdEmpresa, IdCajaIni, IdCajaFin, IdTipoMoviIni, IdTipoMoviFin, TipoIngrEgr, FechaIni, FechaFin, IdPersonaIni, IdPersonaFin, IdEntidadIni, IdEntidadFin, IdTipoFlujoIni, IdTipoFlujoFin, IdTipo_Persona);

                this.DataSource = ListRpt.ToArray();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCAJ_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt002_Rpt) };
            }
        }

    }
}

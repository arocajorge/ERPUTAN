using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt019_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt019_Rpt()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblUsuario.Text = param.IdUsuario;
        }

        private void XCONTA_Rpt019_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCONTA_Rpt019_Bus BusRpt = new XCONTA_Rpt019_Bus();
                List<XCONTA_Rpt019_Info> ListaRpt = new List<XCONTA_Rpt019_Info>();

                DateTime FechaIni, FechaFin;
                bool Mostrar_Cero = false;
                int IdPunto_Cargo = 0;
                int IdPunto_Cargo_Grupo = 0;
                string IdCentroCosto = "";
                bool Mostrar_CC = false;
                bool Considera_asiento_cierrre = false;

                
                FechaIni = Convert.ToDateTime(this.PFechaIni.Value);
                FechaFin = Convert.ToDateTime(this.PFechaFin.Value);
                Mostrar_Cero = Convert.ToBoolean(this.PMostrar_Reg_en_cero.Value);
                IdPunto_Cargo = Convert.ToInt32(this.PIdPunto_Cargo.Value);
                IdPunto_Cargo_Grupo = Convert.ToInt32(this.PIdPunto_Cargo_Grupo.Value);
                IdCentroCosto = Convert.ToString(this.PIdCentroCosto.Value);
                Mostrar_CC = Convert.ToBoolean(this.P_MostrarCC.Value);
                Considera_asiento_cierrre = Convert.ToBoolean(P_Mostrar_asiento_cierre.Value);
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha_corte.Text = "Al " + FechaFin.ToLongDateString();

                ListaRpt = BusRpt.Get_List_Reporte(param.IdEmpresa, FechaIni, FechaFin, IdCentroCosto, 
                    IdPunto_Cargo_Grupo, IdPunto_Cargo, Mostrar_Cero,Mostrar_CC,Considera_asiento_cierrre, param.IdUsuario  );
                this.DataSource = ListaRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_NATU_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt019_Rpt) };
            }
        }
    }
}

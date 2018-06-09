using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;



namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt013_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXC_Rpt013_Rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblUsuario.Text = param.IdUsuario;
            lblEmpresa.Text = param.NombreEmpresa;
        }

        private void XCXC_Rpt013_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt013_Bus rptBus = new XCXC_Rpt013_Bus();
                List<XCXC_Rpt013_Info> lstInfo = new List<XCXC_Rpt013_Info>();

                int IdEmpresa = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                bool Mostrar_fact_sin_ret = true;
                string Sfecha_busqueda = "";
                decimal IdCliente = 0;

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                FechaIni = Convert.ToDateTime(PFecha_Ini.Value);
                FechaFin = Convert.ToDateTime(PFecha_Fin.Value);
                Mostrar_fact_sin_ret = Convert.ToBoolean(p_Mostrar_fact_sin_rt.Value);
                Sfecha_busqueda  = Convert.ToString(P_Fecha_por_buscar.Value);
                IdCliente = Convert.ToDecimal(P_IdCliente.Value);


                XCXC_Rpt013_Data.eFiltro_Fecha_Busqueda fecha_busqueda;

                try
                {
                    fecha_busqueda = (XCXC_Rpt013_Data.eFiltro_Fecha_Busqueda)Enum.Parse(typeof(XCXC_Rpt013_Data.eFiltro_Fecha_Busqueda), Sfecha_busqueda);
                }
                catch (Exception )
                {
                    fecha_busqueda = XCXC_Rpt013_Data.eFiltro_Fecha_Busqueda.por_fecha_documento;
                }

                lstInfo = rptBus.Get_Data_Reporte(IdEmpresa, FechaIni, FechaFin, Mostrar_fact_sin_ret, fecha_busqueda, IdCliente);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt013_Rpt) };
            }
        }

    }
}

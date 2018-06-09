using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Linq;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XCONTA_Rpt014_Info> lst_rpt = new List<XCONTA_Rpt014_Info>();
        XCONTA_Rpt014_Bus bus_rpt = new XCONTA_Rpt014_Bus();
        List<string> IdGrupoCble = new List<string>();

        public XCONTA_Rpt014_Rpt()
        {
            InitializeComponent();
        }
        public void Set_list_grupo_cble(List<string> List)
        {
            try
            {
                IdGrupoCble = List;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_list_grupo_cble", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt014_Rpt) };
            }
        }
        private void XCONTA_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;

                string IdCentroCosto = P_IdCentroCosto.Value.ToString();
                string IdCtaCble = P_IdCtaCble.Value.ToString();
                
                DateTime FechaIni = Convert.ToDateTime(P_FechaIni.Value).Date;
                DateTime FechaFin = Convert.ToDateTime(P_FechaFin.Value).Date;
                lst_rpt = bus_rpt.Get_list_reporte(param.IdEmpresa, IdGrupoCble, IdCtaCble, IdCentroCosto, FechaIni, FechaFin);
                this.DataSource = lst_rpt.OrderBy(q=>q.cb_Fecha).ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt014_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt014_Rpt) };
            }
        }

        #region Centro de costo
        private void GrupoHeaderCentro_costo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_CC.Value))
            {
                e.Cancel = true;
            }
        }

        private void GroupFooterCentro_costo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_CC.Value))
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Subcentro de costo
        private void GroupHeaderSubcentro_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_SCC.Value))
            {
                e.Cancel = true;
            }
        }

        private void GroupFooterSubcentro_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_SCC.Value))
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Grupo
        private void GroupHeaderGrupo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_Grupo.Value))
            {
                e.Cancel = true;
            }
        }

        private void GroupFooterGrupo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_Grupo.Value))
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Punto de cargo
        private void GroupHeaderPunto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_Punto.Value))
            {
                e.Cancel = true;
            }
        }

        private void GroupFooterPunto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_Punto.Value))
            {
                e.Cancel = true;
            }

        }
        #endregion
    }
}

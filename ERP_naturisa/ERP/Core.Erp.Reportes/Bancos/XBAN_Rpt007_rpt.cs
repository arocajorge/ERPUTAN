using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt007_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<int> _lst_tipo_flujo = new List<int>();

        XBAN_Rpt007_Bus rptBus = new XBAN_Rpt007_Bus();
        List<XBAN_Rpt007_Info> lstInfo = new List<XBAN_Rpt007_Info>();
        List<XBAN_Rpt007_saldos_Info> lstInfo_saldos = new List<XBAN_Rpt007_saldos_Info>();
        XBAN_Rpt007_saldos_Bus bus_saldos = new XBAN_Rpt007_saldos_Bus();
        int cont_SubReporte_inicial = 0;
        int cont_SubReporte_final = 0;
        bool Mostrar_detallado = false;

        public XBAN_Rpt007_rpt()
        {
            InitializeComponent();            
        }

        public void set_parametros(List<int> lst_tipo_flujo)
        {
            try
            {
                _lst_tipo_flujo = lst_tipo_flujo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void XBAN_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                Mostrar_detallado = Convert.ToBoolean(P_Mostrar_detallado.Value);
                if (Mostrar_detallado) xrLabel1.Text = "FLUJO DE CAJA DETALLADO"; else xrLabel1.Text = "FLUJO DE CAJA RESUMIDO";
                lblEmpresa.Text = param.NombreEmpresa;
                lstInfo_saldos = bus_saldos.Get_List(param.IdEmpresa, Convert.ToDateTime(P_Fecha_ini.Value),Convert.ToDateTime(P_Fecha_fin.Value),param.IdUsuario);
                bool Mostrar_solo_conciliado = Convert.ToBoolean(P_Mostrar_solo_conciliado.Value);
                int IdBanco = Convert.ToInt32(P_IdBanco.Value);
                bool Mostrar_beneficiario = Convert.ToBoolean(P_Mostrar_beneficiario.Value);
                lstInfo = rptBus.Get_list_reporte(param.IdEmpresa, _lst_tipo_flujo, Convert.ToDateTime(P_Fecha_ini.Value), Convert.ToDateTime(P_Fecha_fin.Value), Mostrar_detallado, IdBanco,Mostrar_solo_conciliado, Mostrar_beneficiario);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };   
            }
        }

        private void SubReport_SaldoInicial_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XRSubreport xrSubReport = (XRSubreport)sender;
                XBAN_Rpt007_saldos_rpt subRep = xrSubReport.ReportSource as XBAN_Rpt007_saldos_rpt;
                subRep.set_parametros("INICIAL", lstInfo_saldos);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SubReport_SaldoInicial_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void SubReport_SaldoFinal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XRSubreport xrSubReport = (XRSubreport)sender;
                XBAN_Rpt007_saldos_rpt subRep = xrSubReport.ReportSource as XBAN_Rpt007_saldos_rpt;
                subRep.set_parametros("FINAL",lstInfo_saldos);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SubReport_SaldoFinal_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void GroupFooter_TipoFlujo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                e.Cancel = !Mostrar_detallado;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupFooter_TipoFlujo_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void GroupHeader_TipoFlujo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                e.Cancel = !Mostrar_detallado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupFooter_TipoFlujo_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

    }
}

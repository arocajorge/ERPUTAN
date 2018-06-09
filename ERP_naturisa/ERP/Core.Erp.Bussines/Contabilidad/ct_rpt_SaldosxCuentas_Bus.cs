using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_rpt_SaldosxCuentas_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public ct_rpt_SaldosxCuentas_Bus() { }

        public List<ct_rpt_SaldosxCuentas_Info> Get_List_saldoxCuentas(int IdEmpresa, int AnioF, int IdPeriodo, List<string> TipoEstadoFinanciero, int NivelInicial)
        {
            try
            {
                ct_rpt_SaldosxCuentas_data SD = new ct_rpt_SaldosxCuentas_data();
                return SD.Get_list_rpt_SaldosxCuentas(IdEmpresa, AnioF, IdPeriodo, TipoEstadoFinanciero, NivelInicial);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_saldoxCuentas", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldosxCuentas_Bus) };
            }
        }


        public List<ct_rpt_SaldosxCuentas_Info> Get_list_saldoxCuentas(int IdEmpresa, int AnioF,  List<string> TipoEstadoFinanciero, int NivelInicial)
        {
            try
            {

                ct_rpt_SaldosxCuentas_data SD = new ct_rpt_SaldosxCuentas_data();
                return SD.Get_list_rpt_SaldosxCuentas(IdEmpresa, AnioF, TipoEstadoFinanciero, NivelInicial);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_saldoxCuentas", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldosxCuentas_Bus) };
            }
        }



        

    }
}

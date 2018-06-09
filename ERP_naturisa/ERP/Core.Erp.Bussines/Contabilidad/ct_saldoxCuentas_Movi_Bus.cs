using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_saldoxCuentas_Movi_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public Boolean GrabarDB(List<ct_saldoxCuentas_Movi_Info> ListSaldoMovi)
        {
            try
            {
                ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();
                return salMoviCta.GrabarDB(ListSaldoMovi);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
            }
        
        }

        public Boolean EliminarDB_Registros_despues_del_periodo(int idempresa, int idPeriodo,ref string msg)
        {
            try
            {
                 ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();
                 return salMoviCta.EliminarDB_Registros_despues_del_periodo(idempresa, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB_Registros_despues_del_periodo", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
                
            }
        }

        public Boolean EliminarDB_SaldoxCuentas_Movi(List<ct_saldoxCuentas_Movi_Info> ListaSaldoActualizados)
        {

            try
            {
                ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();
                return salMoviCta.EliminarDB_SaldoxCuentas_Movi(ListaSaldoActualizados);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB_SaldoxCuentas_Movi", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
            }
        }

        public Boolean ExisteRegistros_SaldoMensualxCta(int IdEmpresa,int AnioF, int IdPeriodo ,String IdCtaCble)
        {
            try
            {
                ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();
                return salMoviCta.Get_ExisteRegistros_SaldoMensualxCta(IdEmpresa, AnioF, IdPeriodo, IdCtaCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ExisteRegistros_SaldoMensualxCta", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
            }

        }

        public List<ct_saldoxCuentas_Movi_Info> Get_List_saldoxCuentas_Movi_x_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
        {

            try
            {
                ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();

                return salMoviCta.Get_list_saldoxCuentas_Movi_x_Periodo(IdEmpresa, AnioF, IdPeriodo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_saldoxCuentas_Movi_x_Periodo", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
            }

        }

        public List<ct_saldoxCuentas_Movi_Info> Get_List_saldoxCuentas_Movi_SinCtasIngEgrex_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
        {
            try
            {
                ct_saldoxCuentas_Movi_Data salMoviCta = new ct_saldoxCuentas_Movi_Data();
                return salMoviCta.Get_list_saldoxCuentas_Movi_SinCtasIngEgrex_Periodo(IdEmpresa, AnioF, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_saldoxCuentas_Movi_SinCtasIngEgrex_Periodo", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Movi_Bus) };
            }

        }

        public ct_saldoxCuentas_Movi_Bus()
        {
            
        }
    }
}

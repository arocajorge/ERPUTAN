
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{

    public class ct_saldoxCuentas_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<ct_SaldoxCuentas_Info> Get_List_saldoxCuentas_x_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
        {
            try
            {

                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.Get_list_SaldoxCuentas_x_Periodo(IdEmpresa, AnioF, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_SaldoxCuentas_x_Periodo", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }

        }


        public List<ct_SaldoxCuentas_Info> Get_List_saldoxCuentas_x_Periodo_ParaEliminar(int IdEmpresa, int AnioF, int IdPeriodo)
        {

            try
            {

                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.Get_list_SaldoxCuentas_x_Periodo_ParaEliminar(IdEmpresa, AnioF, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_saldoxCuentas_x_Periodo_ParaEliminar", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }

        }
        


        public Boolean GrabarDB(List<ct_SaldoxCuentas_Info> ListSaldoxCta,ref string MensajeError)
        {

            try
            {
                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.GrabarDB(ListSaldoxCta, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }
        
        }

        public Boolean EliminarDB_Registros_despues_del_periodo(int idempresa, int idPeriodo,ref string mensaje)
        {
            try
            {
                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.EliminarDB_Registros_despues_del_periodo(idempresa, idPeriodo,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB_Registros_despues_del_periodo", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
                
            }
        }


        public Boolean EliminarDB(List<ct_SaldoxCuentas_Info> ListSaldoxCuenta)
        {
            try
            {
                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.EliminarDB_SaldoxCuentas(ListSaldoxCuenta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB_SaldoxCuentas", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }
        }


        public List<ct_SaldoxCuentas_Info> Get_Mayorizar_y_Optener_SaldoxCuentas(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string idusuario, Boolean Considerar_Asiento_cierre, string pc, ref string MensajeError)
        {
            try
            {
                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.Get_Mayorizar_y_Optener_SaldoxCuentas(IdEmpresa, FechaIni, FechaFin, idusuario, Considerar_Asiento_cierre, pc, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Mayorizar_y_Optener_SaldoxCuentas", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }
        
        }

        public List<ct_SaldoxCuentas_Info> Get_list_SaldoxCuentas_x_Periodo(int IdEmpresa, List<string> listCuentas, DateTime FechaCorte, ref string MensajeError)
        {
            try
            {
                ct_saldoxCuentas_Data salBxCta = new ct_saldoxCuentas_Data();
                return salBxCta.Get_Saldo_Inicial_x_Cuenta( IdEmpresa, listCuentas, FechaCorte, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Saldo_Inicial_x_Cuenta", ex.Message), ex) { EntityType = typeof(ct_saldoxCuentas_Bus) };
            }
        }

    }
}

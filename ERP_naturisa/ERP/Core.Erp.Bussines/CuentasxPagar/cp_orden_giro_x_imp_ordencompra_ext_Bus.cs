using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_giro_x_imp_ordencompra_ext_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_orden_giro_x_imp_ordencompra_ext_Data data = new cp_orden_giro_x_imp_ordencompra_ext_Data();

        public Boolean GrabarDB(cp_orden_giro_x_imp_ordencompra_ext_Info info, ref string mensaje)
        {
            try
            {
                  return data.GrabarDB(info, ref mensaje );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public Boolean GrabarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> lista, ref string mensaje)
        {
            try
            {
             return data.GrabarDB(lista, ref mensaje );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public List<cp_orden_giro_x_imp_ordencompra_ext_Info> Get_List_orden_giro_x_imp_ordencompra_ext(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
             return data.Get_List_orden_giro_x_imp_ordencompra_ext(IdEmpresa_Ogiro, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro_x_imp_ordencompra_ext", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public Boolean ActualizarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> listaNueva, List<cp_orden_giro_x_imp_ordencompra_ext_Info> listaAntigua)
        {
            try
            {
             return data.ActualizarDB(listaNueva, listaAntigua);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public Boolean EliminarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> lista)
        {
            try
            {
             return data.EliminarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
               return data.EliminarDB(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public Boolean ModificarDB(cp_orden_giro_x_imp_ordencompra_ext_Info info)
        {
            try
            {
             return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_imp_ordencompra_ext_Bus) };
            }

        }

        public cp_orden_giro_x_imp_ordencompra_ext_Bus(){}
    }
}

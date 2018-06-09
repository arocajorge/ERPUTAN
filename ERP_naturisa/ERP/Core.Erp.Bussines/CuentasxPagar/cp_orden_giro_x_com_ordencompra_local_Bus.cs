using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.Compras;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_giro_x_com_ordencompra_local_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        cp_orden_giro_x_com_ordencompra_local_Data data = new cp_orden_giro_x_com_ordencompra_local_Data();
        public List<cp_orden_giro_x_com_ordencompra_local_Info> Get_List_orden_giro_x_com_ordencompra_local(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
             return data.Get_List_orden_giro_x_com_ordencompra_local(IdEmpresa_Ogiro, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_orden_giro_x_com_ordencompra_local", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }

        public Boolean GrabarDB(cp_orden_giro_x_com_ordencompra_local_Info info)
        {
            try
            {
               return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }
        public Boolean GrabarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> lista, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }
        public Boolean ActualizarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> listaNueva, List<cp_orden_giro_x_com_ordencompra_local_Info> listaAntigua)
        {
            try
            {
             return data.ActualizarDB(listaNueva, listaAntigua);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }
        public Boolean EliminarLista(List<cp_orden_giro_x_com_ordencompra_local_Info> lista)
        {
            try
            {
              return data.EliminarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }
        public Boolean EliminarDB(cp_orden_giro_x_com_ordencompra_local_Info info)
        {
            try
            {
                 return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }

        public Boolean ModificarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> Lst, int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        {
            try
            {
              return data.ModificarDB(Lst,IdEmpresa,IdCbteCble,IdTipoCbte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa)
        {
            try
            {
              return data.Get_List_ordencompra_local(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int og_IdEmpresa, decimal og_IdCbteCble, int og_IdTipoCbte)
        {
            try
            {
               return data.Get_List_ordencompra_local(og_IdEmpresa, og_IdCbteCble, og_IdTipoCbte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_Bus) };
            }

        }

        public cp_orden_giro_x_com_ordencompra_local_Bus(){}
    }
}

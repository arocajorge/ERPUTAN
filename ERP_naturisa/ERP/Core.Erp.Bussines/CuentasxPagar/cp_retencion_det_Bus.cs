using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_retencion_det_Bus
    {

      cp_retencion_det_Data data = new cp_retencion_det_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       
        string mensaje = "";

        public List<cp_retencion_det_Info> Get_ListDetRetencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return data.Get_List_retencion_det(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_retencion_det", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return data.Get_List_retencion_det_x_Report(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_retencion_det_x_Report", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }

        }


        public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdRetencion, ref string mensaje)
        {
            try
            {
                 return data.Get_List_retencion_det_x_Report(IdEmpresa, IdRetencion, ref mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_retencion_det_x_Report", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        
        }
        public List<cp_retencion_det_Info> Get_List_retencion_det_x_Report(int IdEmpresa, decimal IdRetencion)
        {
            try
            {
                return data.Get_List_retencion_det_x_Report(IdEmpresa, IdRetencion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_retencion_det_x_Report", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }

        }

        public Boolean GrabarDB(List<cp_retencion_det_Info> lista)
        {
            try
            {
                return data.GrabarDB(lista);
            }
            catch (Exception ex)
            {
                

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }

        }

        public Boolean ActualizarDB(List<cp_retencion_det_Info> listaNueva, List<cp_retencion_det_Info> listaAntigua)
        {
            try
            {
                return data.ActualizarDB(listaNueva, listaAntigua);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }

        }

        public Boolean EliminarDB(cp_retencion_det_Info info)
        {
            try
            {
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }               
        }


        public Boolean EliminarDB(List<cp_retencion_det_Info> lista)
        {
            try
            {
                return data.EliminarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }     
        
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;
using Core.Erp.Data.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;

namespace Core.Erp.Business.Compras
{
  public  class com_comprador_Bus
    {

      com_comprador_Data odata = new com_comprador_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      
     
      public Boolean VericarCedulaExiste(int IdEmpresa,string cedula, ref string mensaje)
      {
          try
          {
              return odata.VericarCedulaExiste(IdEmpresa,cedula, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
          }

      }

      public Boolean VerificarNombre(int IdEmpresa, string nombre, ref string mensaje)
      {
          try
          {
              return odata.VerificarNombre(IdEmpresa, nombre, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarNombre", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
          }
      
      
      }

      public Boolean GuardarDB(com_comprador_Info info, ref string mensaje)
        {
            try
            {
                return odata.GuardarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            
            }

        }

      public Boolean ModificarDB(com_comprador_Info info, ref string msg)
       {
           try
           {
               return odata.ModificarDB(info, ref msg);

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
           }
       }

      public Boolean AnularDB(com_comprador_Info info, ref string msg)
       {
           try
           {
                 return odata.AnularDB(info, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
           }

       }

      public List<com_comprador_Info> Get_List_comprador(int IdEmpresa)
       {
           try
           {
               return odata.Get_List_comprador(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_comprador", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) }; 
           }

       }     
    }
}

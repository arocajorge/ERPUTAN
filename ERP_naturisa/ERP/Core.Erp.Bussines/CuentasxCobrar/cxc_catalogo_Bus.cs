using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
   public class cxc_catalogo_Bus
   {
       #region Declaración de variables
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       cxc_catalogo_Data Data = new cxc_catalogo_Data();
       #endregion

       public List<cxc_catalogo_Info> Get_List_catalogo(string IdCatalogo_tipo)
       {

           try
           {
               return Data.Get_List_Catalogo(IdCatalogo_tipo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }       
       }

       public string GetId()
       {
           try { return Data.GetId(); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public List<cxc_catalogo_Info> Get_List_catalogo()
       {
           try { return Data.Get_List_catalogo(); }
           catch (Exception ex) 
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_catalogo", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public List<cxc_catalogo_Info> ObtenerIdTipoLista(string cod)
       {
           try { return Data.Get_List_IdTipoLista(cod); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_IdTipoLista", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public Boolean GuardarDB(cxc_catalogo_Info Info)
       {
           try { return Data.GuardarDB(Info); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public Boolean ValidarCodigoExiste(string cod)
       {
           try { return Data.ValidarCodigoExiste(cod); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public Boolean ModificarDB(cxc_catalogo_Info Info)
       {
           try { return Data.ModificarDB(Info); }
           catch (Exception ex) 
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public Boolean AnularDB(cxc_catalogo_Info Info)
       {
           try { return Data.AnularDB(Info); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

       public Boolean ValidarIdTipoCatalogo_Descripcion(string idTipoCatalogo, string ca_descripcion)
       {
           try { return Data.ValidarIdTipoCatalogo_Descripcion(idTipoCatalogo, ca_descripcion); }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarIdTipoCatalogo_Descripcion", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
           }
       }

    }
}

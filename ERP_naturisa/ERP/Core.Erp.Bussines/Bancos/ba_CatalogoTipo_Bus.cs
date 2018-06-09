using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_CatalogoTipo_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_CatalogoTipo_Data cd = new ba_CatalogoTipo_Data();

        public List<ba_CatalogoTipo_info> Get_List_CatalogoTipo()
        {
            try { return cd.Get_List_CatalogoTipo(); }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CatalogoTipo", ex.Message), ex) { EntityType = typeof(ba_CatalogoTipo_Bus) };
            }
            
        }
       
        public Boolean ModificarDB(ref ba_CatalogoTipo_info info)
        {
            try { return cd.ModificarDB(info); }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_CatalogoTipo_Bus) };
            }
            
        }
       
        public Boolean GuardarDB(ref ba_CatalogoTipo_info info)
        {
            try { return cd.GuardarDB(info); }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_CatalogoTipo_Bus) };
            }
        }
       
        public Boolean ValidarCodigoExiste(string cod)
        {
            try { return cd.ValidarCodigoExiste(cod); }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(ba_CatalogoTipo_Bus) };
            }
            
        }
        
        public ba_CatalogoTipo_info Get_Info_Catalogo(string cod)
        {
            try { return cd.Get_Info_Catalogo(cod); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Catalogo", ex.Message), ex) { EntityType = typeof(ba_CatalogoTipo_Bus) };
            }
        }
    }
}

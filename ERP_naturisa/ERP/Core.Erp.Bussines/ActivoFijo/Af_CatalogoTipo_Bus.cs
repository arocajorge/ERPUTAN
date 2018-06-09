using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;


namespace Core.Erp.Business.ActivoFijo
{
    public class Af_CatalogoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_CatalogoTipo_Data cd = new Af_CatalogoTipo_Data();

        string mensaje = "";

        public List<Af_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
            try 
            {
                return cd.Get_List_CatalogoTipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CatalogoTipo", ex.Message), ex) { EntityType = typeof(Af_CatalogoTipo_Bus) };
            }

        }

        public Boolean Modificar(Af_CatalogoTipo_Info info)
        {
            try 
            { 
                return cd.Modificar(info);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(Af_CatalogoTipo_Bus) };
            }

        }
        
        public Boolean GuardarDB(Af_CatalogoTipo_Info info)
        {
            try
            {
                return cd.GuardarDB(info); 
            }
            catch (Exception ex) 
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_CatalogoTipo_Bus) };
            }
        }
        
        public Boolean ValidarCodigoExiste(string cod)
        {
            try 
            { 
                return cd.ValidarCodigoExiste(cod); 
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(Af_CatalogoTipo_Bus) };
            }

        }
        
        public Af_CatalogoTipo_Info Get_Info_CatalogoTipo(string cod)
        {
            try 
            {
                return cd.Get_Info_CatalogoTipo(cod); 
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_CatalogoTipo", ex.Message), ex) { EntityType = typeof(Af_CatalogoTipo_Bus) };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_CatalogoTipo_Bus
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_CatalogoTipo_Data cd = new cxc_CatalogoTipo_Data();
        #endregion

        public List<cxc_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
            try { return cd.Get_List_CatalogoTipo(); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CatalogoTipo", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
            }

        }

        public Boolean ModificarDB(cxc_CatalogoTipo_Info info)
        {
            try { return cd.ModificarDB(info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
            }

        }
        
        public Boolean GuardarDB(cxc_CatalogoTipo_Info info)
        {
            try { return cd.GuardarDB(info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
            }
        }
        
        public Boolean ValidarCodigoExiste(string cod)
        {
            try { return cd.ValidarCodigoExiste(cod); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
            }

        }

        public cxc_CatalogoTipo_Info Get_Info_CatalogoTipo(string cod)
        {
            try { return cd.Get_Info_CatalogoTipo(cod); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_CatalogoTipo", ex.Message), ex) { EntityType = typeof(cxc_catalogo_Bus) };
            }
        }
    
    }

}

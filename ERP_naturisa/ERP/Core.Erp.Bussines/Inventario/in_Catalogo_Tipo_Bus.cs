using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_Catalogo_Tipo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_Catalogo_Tipo_Data oData = new in_Catalogo_Tipo_Data();

        public List<in_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
            try
            {
                return oData.Get_List_CatalogoTipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaTipoCatalogo", ex.Message), ex) { EntityType = typeof(in_Catalogo_Tipo_Bus) };

            }
        }

        public Boolean GuardarDB(in_CatalogoTipo_Info info, ref string msg)
        {
            try
            {
                return oData.GuardarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Tipo_Bus) };

            }
        }

        public Boolean ModificarDB(in_CatalogoTipo_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Tipo_Bus) };

            }
        }
        

    }
}

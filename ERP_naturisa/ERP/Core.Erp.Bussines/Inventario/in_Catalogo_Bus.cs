using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_Catalogo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_Catalogo_Data oData = new in_Catalogo_Data();

        public List<in_Catalogo_Info> Get_List_Catalogo(int IdTipoCatalogo)
        {
            try
            {
                return oData.Get_List_Catalogo(IdTipoCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxTipoCatalogo", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean EliminarDB(in_Catalogo_Info info)
        {
            try
            {
                return oData.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean GuardarDB(in_Catalogo_Info info,ref string msg)
        {
            try
            {
                return oData.GuardarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean ModificarDB(in_Catalogo_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public List<in_Catalogo_Info> Get_List_Catalogo()
        {
            try
            {
                return oData.Get_List_Catalogo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogo", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_Tipo_docu_pago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_Tipo_docu_pago_Data data = new imp_Tipo_docu_pago_Data();

        public List<imp_Tipo_docu_pago_Info> Get_List_Tipo_docu_pago()
        {
            try
            {
                 return data.Get_List_Tipo_docu_pago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtener", ex.Message), ex) { EntityType = typeof(imp_Tipo_docu_pago_Bus) };
            
            }

        }

        public Boolean GuardarDB(imp_Tipo_docu_pago_Info info, ref string msg) 
        {
            try
            {
                 return data.GuardarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(imp_Tipo_docu_pago_Bus) };
            
            }

        }

        public Boolean ModificarDB(imp_Tipo_docu_pago_Info info, ref string msg)
        {
            try
            {
               return data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(imp_Tipo_docu_pago_Bus) };
            
            }

        }
    }
}

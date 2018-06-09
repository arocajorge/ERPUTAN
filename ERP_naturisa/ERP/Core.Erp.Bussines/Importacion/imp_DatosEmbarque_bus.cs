using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_DatosEmbarque_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        imp_DatosEmbarque_Data oData = new imp_DatosEmbarque_Data();


        public List<imp_DatosEmbarque_Info> Get_List_DatosEmbarque(imp_ordencompra_ext_Info info)
        {
            try
            {
            return oData.Get_List_DatosEmbarque(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_DatosEmbarque_bus) };
            
            }

        }
    }
}

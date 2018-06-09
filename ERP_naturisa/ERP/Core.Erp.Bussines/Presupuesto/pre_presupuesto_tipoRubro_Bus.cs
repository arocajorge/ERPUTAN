using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Presupuesto
{
    public class pre_presupuesto_tipoRubro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        pre_presupuesto_tipoRubro_Data data = new pre_presupuesto_tipoRubro_Data();
        public List<pre_presupuesto_tipoRubro_Info> Get_List_pre_presupuesto_tipoRubro() 
        {
            try
            {
               return data.Get_List_pre_presupuesto_tipoRubro();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtener", ex.Message), ex) { EntityType = typeof(pre_presupuesto_tipoRubro_Bus) };

            }

        }
    }
}

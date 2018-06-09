using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_Ciclo_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        imp_Ciclo_Data oDat = new imp_Ciclo_Data();

        public List<imp_Ciclo_Info> Get_List_Ciclo()
        {
            try
            {
               return oDat.Get_List_Ciclo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaCiclo", ex.Message), ex) { EntityType = typeof(imp_Ciclo_Bus) };
            
            }

        }
    }
}

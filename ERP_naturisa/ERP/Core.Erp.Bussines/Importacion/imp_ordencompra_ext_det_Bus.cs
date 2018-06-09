using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje="";
        imp_ordencompra_ext_det_Data oData = new imp_ordencompra_ext_det_Data();

        public List<imp_ordencompra_ext_det_Info> Get_List_ordencompra_ext_det(imp_ordencompra_ext_Info Info)
        {
            try
            {
              return oData.Get_List_ordencompra_ext_det(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_det_Bus) };
            
            }


        }


    }
}

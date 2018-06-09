using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_x_Condiciones_Pago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_ordencompra_ext_x_Condiciones_Pago_Data odata = new imp_ordencompra_ext_x_Condiciones_Pago_Data();

        public List<imp_ordencompra_ext_x_Condiciones_Pago_Info> Get_List_ordencompra_ext_x_Condiciones_Pago(imp_ordencompra_ext_Info Info)
        {
            try
            {
               return odata.Get_List_ordencompra_ext_x_Condiciones_Pago(Info);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_Condiciones_Pago_Bus) };
            
            }

        }

    }
}

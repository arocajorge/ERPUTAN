using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public class ro_Pago_decimos_x_Empleado_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ro_Pago_decimos_x_Empleado_Data oData = new ro_Pago_decimos_x_Empleado_Data();

       public List<ro_Pago_decimos_x_Empleado_Info> GetLisDecimo(int IdEmpresa, int IdRubro, DateTime FechaI, DateTime FechaF)
       {
           try
           {
               return oData.GetLisDecimo(IdEmpresa, IdRubro, FechaI, FechaF);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetLisDecimo", ex.Message), ex) { EntityType = typeof(ro_Pago_decimos_x_Empleado_Bus) };
           }
       }


       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt013_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       XROL_Rpt013_Data Data = new XROL_Rpt013_Data();
       public List<XROL_Rpt013_Info> Get_List_Vacaciones(int IdEmpresa, decimal IdEmpleado, DateTime FechaInicio, DateTime FechaFin)
       {
           try
           {
               return Data.Get_List_Vacaciones(IdEmpresa, IdEmpleado, FechaInicio, FechaFin);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Vacaciones", ex.Message), ex) { EntityType = typeof(XROL_Rpt013_Bus) };

           }


       }

    }
}

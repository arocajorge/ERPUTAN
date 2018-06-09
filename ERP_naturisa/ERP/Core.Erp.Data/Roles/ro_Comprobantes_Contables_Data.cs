using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Roles
{
   public class ro_Comprobantes_Contables_Data
   {
       string mensaje = "";
       public Boolean GuardarDB(ro_Comprobantes_Contables_Info info)
       {
           try
           {
               List<ro_area_Info> Lst = new List<ro_area_Info>();
               using (EntitiesRoles Context = new EntitiesRoles())
               {
                   var Address = new ro_Comprobantes_Contables();
                   Address.IdEmpresa = info.IdEmpresa;
                   Address.IdCbteCble = info.IdCbteCble;
                   Address.IdPeriodo = info.IdPeriodo;
                   Address.CodCtbteCble = info.CodCtbteCble;
                   Address.cb_Observacion = info.cb_Observacion;
                   Address.IdTipoCbte=info.IdTipoCbte;
                   Context.ro_Comprobantes_Contables.Add(Address);
                   Context.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_Parametro_calculo_Horas_Extras_Bus
   {
       string mensaje;
       ro_Parametro_calculo_Horas_Extras_Data data = new ro_Parametro_calculo_Horas_Extras_Data();
       public bool Guardar_DB(ro_Parametro_calculo_Horas_Extras_Info info)
       {
           try
           {
               return data.GuardarDB(info);


           }
           catch (Exception ex)
           {

               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
       public ro_Parametro_calculo_Horas_Extras_Info Get_info(int IdEmpresa)
       {
           try
           {
               return data.Get_info(IdEmpresa);


           }
           catch (Exception ex)
           {

               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
    }
}

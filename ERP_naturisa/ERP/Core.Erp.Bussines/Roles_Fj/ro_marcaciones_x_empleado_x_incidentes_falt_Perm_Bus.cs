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
   public class ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus
   {
       string mensaje = "";
       ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Data data = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Data();
       public bool Grabar_DB(ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info info)
       {
           try
           {
               return data.Grabar_DB(info);

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



       public List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista_atrasos_faltas_x_empleado(int IdEmpresa, DateTime Fecha_Inicio, DateTime FechaFin)
       {
           try
           {
               return data.lista_atrasos_faltas_x_empleado(IdEmpresa,Fecha_Inicio,FechaFin);

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

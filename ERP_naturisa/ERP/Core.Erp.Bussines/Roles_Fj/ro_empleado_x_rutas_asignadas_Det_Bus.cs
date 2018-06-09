using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
   public class ro_empleado_x_rutas_asignadas_Det_Bus
   {
       string mensaje;
       ro_empleado_x_rutas_asignadas_Det_Data data = new ro_empleado_x_rutas_asignadas_Det_Data();
       public bool Guardar_DB(List<ro_empleado_x_rutas_asignadas_Det_Info> lista)
       {
           try
           {

               return data.Guardar_DB(lista);
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
       public List<ro_empleado_x_rutas_asignadas_Det_Info> lista_paramatrso_x_empleados(int IdEmpresa, int idnomina_tipo, int idempleado)
       {
           try
           {
               return data.lista_paramatrso_x_empleados(IdEmpresa, idnomina_tipo, idempleado);

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


       public List<ro_empleado_x_rutas_asignadas_Det_Info> lista_paramatrso_x_empleados(int IdEmpresa, int idnomina_tipo)
       {
           try
           {
               return data.lista_paramatrso_x_empleados(IdEmpresa, idnomina_tipo);

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

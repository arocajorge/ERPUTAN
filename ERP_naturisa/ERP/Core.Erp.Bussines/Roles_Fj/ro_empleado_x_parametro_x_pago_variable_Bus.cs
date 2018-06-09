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
   public class ro_empleado_x_parametro_x_pago_variable_Bus
   {
       string mensaje;
       ro_empleado_x_parametro_x_pago_variable_Data data = new ro_empleado_x_parametro_x_pago_variable_Data();
       ro_empleado_x_parametro_x_pago_variable_Det_Bus bus_detalle = new ro_empleado_x_parametro_x_pago_variable_Det_Bus();
       public bool Guardar_DB(ro_empleado_x_parametro_x_pago_variable_Info info)
       {
           bool bandera = false;
           try
           {

               if (data.Guardar_DB(info))
               {
                   int sec=0;
                   foreach (var item in info.Lista)
                   {   sec++;
                       item.IdEmpleado = info.IdEmpleado;
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNomina_Tipo = info.IdNomina_Tipo;
                       item.Secuencia = sec;
                   }
                  bandera= bus_detalle.Guardar_DB(info.Lista);
               }

               return bandera;
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

       public bool Anular_DB(ro_empleado_x_parametro_x_pago_variable_Info info)
       {
           try
           {
               return data.Anular_DB(info);
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


       public List<ro_empleado_x_parametro_x_pago_variable_Info> listado_empleado_x_parametro_variables(int IdEmpresa)
       {
           try
           {
               return data.listado_empleado_x_parametro_variables(IdEmpresa);

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

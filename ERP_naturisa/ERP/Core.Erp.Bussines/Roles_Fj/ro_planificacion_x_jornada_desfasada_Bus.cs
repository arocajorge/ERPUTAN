using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;

namespace Core.Erp.Business.Roles_Fj
{
   public class ro_planificacion_x_jornada_desfasada_Bus
   {
       string mensaje = "";
       ro_planificacion_x_jornada_desfasada_Data data = new ro_planificacion_x_jornada_desfasada_Data();
       ro_planificacion_x_jornada_desfasada_empleado_Bus bus_planificacion_x_empleado = new ro_planificacion_x_jornada_desfasada_empleado_Bus();
       public bool Guardar_DB(ro_planificacion_x_jornada_desfasada_Info info)
       {
           bool ba = false;
           try
           {
               if (data.Guardar_DB(info))
               {
                   foreach (var item in info.Lista)
                   {                       
                      ba= bus_planificacion_x_empleado.Guardar_DB(item);

                   }
               }
               return ba;
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

       public bool Modificar_DB(ro_planificacion_x_jornada_desfasada_Info Info)
       {   bool ba=true;
           try
           {
               if( data.Modificar_DB(Info))
               {
                  if(bus_planificacion_x_empleado.Eliminar(Info))
                  {
                      foreach (var item in Info.Lista)
                      {
                        ba=  bus_planificacion_x_empleado.Guardar_DB(item);
                      }
                  }

                   
                     
               }

               return ba;
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

       public bool Anular_DB(ro_planificacion_x_jornada_desfasada_Info Info)
       {
           try
           {
               return data.Anular_DB(Info);

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

       public List<ro_planificacion_x_jornada_desfasada_Info> Listado_planificacion_x_periodo(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_Fin)
       {
           try
           {
               return data.Listado_planificacion_x_periodo(IdEmpresa, Fecha_Inicio, Fecha_Fin);
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
       public bool Cerrar_Planificacion(ro_planificacion_x_jornada_desfasada_Info Info)
       {
           try
           {
               return data.Cerrar_Planificacion(Info);
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

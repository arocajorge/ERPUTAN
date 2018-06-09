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
   public class ro_planificacion_x_ruta_x_empleado_Bus
   {
       string mensaje;
       ro_planificacion_x_ruta_x_empleado_Data data = new ro_planificacion_x_ruta_x_empleado_Data();
       ro_planificacion_x_ruta_x_empleado_det_Bus bus_detalle = new ro_planificacion_x_ruta_x_empleado_det_Bus();
       public bool Guardar_DB(ro_planificacion_x_ruta_x_empleado_Info info)
       {
           try
           {
               bool ba_siGrabo = false;

               if (Si_existe(info.IdEmpresa, info.IdNomina_Tipo, info.IdPeriodo))
               {
                   if (data.Modificar_DB(info))
                       ba_siGrabo= bus_detalle.Modificar_DB(info.lista);
               }
               else
               {
                   if( data.Guardar_DB(info))
                      ba_siGrabo= bus_detalle.Guardar_DB(info.lista);

               }

               return ba_siGrabo;
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


       public bool Modificar_DB(ro_planificacion_x_ruta_x_empleado_Info info)
       {
           try
           {
               return data.Modificar_DB(info);
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



       public bool Anular_DB(ro_planificacion_x_ruta_x_empleado_Info info)
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




       public List<ro_planificacion_x_ruta_x_empleado_Info> listado_Grupos(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_fin)
       {
           try
           {
               return data.listado_Grupos(IdEmpresa, Fecha_Inicio, Fecha_fin);
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


       public bool Si_existe(int IdEmpresa, int idNomina_tipo, int IdPeriodo)
       {
           try
           {
               return data.Si_existe(IdEmpresa, idNomina_tipo, IdPeriodo);
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

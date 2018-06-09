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
   public class ro_parametro_x_pago_variable_Bus
   {
       string mensaje;
       ro_parametro_x_pago_variable_Det_Data data_detalle = new ro_parametro_x_pago_variable_Det_Data();
       ro_parametro_x_pago_variable_Data data = new ro_parametro_x_pago_variable_Data();

       public bool Guardar_DB(ro_parametro_x_pago_variable_Info info, ref int Id_Tipo_Pago_Variable)
       {
           bool bandera = true;
           try
           {
               if (data.Guardar_DB(info, ref Id_Tipo_Pago_Variable))
               {
                   foreach (var item in info.detalle)
                   {
                       item.Idempresa = info.IdEmpresa;
                       item.IdNomina_Tipo = info.IdNomina_Tipo;
                       item.Id_Tipo_Pago_Variable = Id_Tipo_Pago_Variable;
                   }
                bandera=   data_detalle.Guardar_DB(info.detalle);
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


       public bool Modificar_DB(ro_parametro_x_pago_variable_Info info)
       {
           bool bandera = true;
           try
           {
               if (data.Modificar_DB(info))
               {
                   foreach (var item in info.detalle)
                   {
                       item.Idempresa = info.IdEmpresa;
                       item.IdNomina_Tipo = info.IdNomina_Tipo;
                       item.Id_Tipo_Pago_Variable = info.Id_Tipo_Pago_Variable;
                   }
                   bandera = data_detalle.Modificar_DB(info.detalle);
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



       public bool Anular_DB(ro_parametro_x_pago_variable_Info info)
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




       public List<ro_parametro_x_pago_variable_Info> listado_parametro_pago_variable(int IdEmpresa)
       {
           try
           {
               return data.listado_parametro_pago_variable(IdEmpresa);
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

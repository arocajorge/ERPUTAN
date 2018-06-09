using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
   public class ro_parametro_Egreso_Ingreso_x_implementos_Data
   {
       string mensaje = "";
       public Boolean GuardarDB( ro_parametro_Egreso_Ingreso_x_implementos_Info Info)
       {
           try
           {
             if(!  Get_si_existe_paramet(Info.IdEmpresa))
             {

               using (EntitiesRoles Context = new EntitiesRoles())
               {
                   var Address = new ro_parametro_Egreso_Ingreso_x_implementos();
                   Address.IdEmpresa = Info.IdEmpresa;
                   Address.IdSucursal = Info.IdSucursal;
                   Address.IdBodega = Info.IdBodega;
                   Address.IdTipo_mov_Egreso = Info.IdTipo_mov_Egreso;
                   Address.IdTipo_mov_Ingreso = Info.IdTipo_mov_Ingreso;
                   Context.ro_parametro_Egreso_Ingreso_x_implementos.Add(Address);
                   Context.SaveChanges();
               }
               return true;
             }
               else
             {
                 ModificarDB(Info);
                 return true;
             }
               
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

       public ro_parametro_Egreso_Ingreso_x_implementos_Info Get_Info_Parametr(int IdEmpresa)
       {
           ro_parametro_Egreso_Ingreso_x_implementos_Info Info = new ro_parametro_Egreso_Ingreso_x_implementos_Info();
           EntitiesRoles oEnti = new EntitiesRoles();
           try
           {
               var Query = from q in oEnti.ro_parametro_Egreso_Ingreso_x_implementos
                           where q.IdEmpresa == IdEmpresa
                           select q;
               foreach (var item in Query)
               {
             
               
               Info.IdEmpresa = item.IdEmpresa;
               Info.IdSucursal = item.IdSucursal;
               Info.IdBodega = item.IdBodega;
               Info.IdTipo_mov_Egreso = item.IdTipo_mov_Egreso;
               Info.IdTipo_mov_Ingreso = item.IdTipo_mov_Ingreso;
               }

               return Info;
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

       public Boolean ModificarDB(ro_parametro_Egreso_Ingreso_x_implementos_Info info)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_parametro_Egreso_Ingreso_x_implementos.First(minfo => minfo.IdEmpresa == info.IdEmpresa);
                   if (contact != null)
                   {
                       contact.IdSucursal = info.IdSucursal;
                       contact.IdBodega = info.IdBodega;
                       contact.IdTipo_mov_Egreso = info.IdTipo_mov_Egreso;
                       contact.IdTipo_mov_Ingreso = info.IdTipo_mov_Ingreso;
                       context.SaveChanges();
                   }
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


       public bool Get_si_existe_paramet(int IdEmpresa)
       {
           ro_parametro_Egreso_Ingreso_x_implementos_Info Info = new ro_parametro_Egreso_Ingreso_x_implementos_Info();
           EntitiesRoles oEnti = new EntitiesRoles();
           try
           {
               var Query = from q in oEnti.ro_parametro_Egreso_Ingreso_x_implementos
                           where q.IdEmpresa == IdEmpresa
                           select q;

               if (Query.Count() == 0)
               {
                   return false;
               }
               else
               {
                   return true;
               }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles_Fj
{
   public class ro_parametro_x_pago_variable_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(ro_parametro_x_pago_variable_Info info, ref int idgrupo)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   ro_parametro_x_pago_variable add = new ro_parametro_x_pago_variable();
                   add.IdEmpresa = info.IdEmpresa;
                   add.IdNomina_Tipo = info.IdNomina_Tipo;
                   add.Id_Tipo_Pago_Variable = GetId(info.IdEmpresa);
                   add.Nombre = info.Nombre;
                   add.IdUsuario = info.IdUsuario;
                   add.Fecha_Transaccion = DateTime.Now;
                   add.Estado = true;
                   db.ro_parametro_x_pago_variable.Add(add);
                   db.SaveChanges();
                   idgrupo = add.Id_Tipo_Pago_Variable;
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }


       public bool Modificar_DB(ro_parametro_x_pago_variable_Info info)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var add = db.ro_parametro_x_pago_variable.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.Id_Tipo_Pago_Variable==info.Id_Tipo_Pago_Variable);

                   add.Nombre = info.Nombre;
                   add.Fecha_UltMod = DateTime.Now;
                   add.IdUsuarioUltModi = info.IdUsuario;
                   
                   db.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }



       public bool Anular_DB(ro_parametro_x_pago_variable_Info info)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var add = db.ro_parametro_x_pago_variable.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.Id_Tipo_Pago_Variable == info.Id_Tipo_Pago_Variable);

                   add.Fecha_UltAnu =DateTime.Now;
                   add.IdUsuarioUltAnu = info.IdUsuario;
                   add.MotivoAnulacion = info.MotivoAnulacion;
                   add.Estado = false;
                   db.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }




       public List<ro_parametro_x_pago_variable_Info> listado_parametro_pago_variable(int IdEmpresa)
       {
           try
           {
               List<ro_parametro_x_pago_variable_Info> lista = new List<ro_parametro_x_pago_variable_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var query = from q in db.ro_parametro_x_pago_variable
                               where
                               q.IdEmpresa == IdEmpresa

                               select q;

                   foreach (var item in query)
                   {
                       ro_parametro_x_pago_variable_Info info = new ro_parametro_x_pago_variable_Info();

                       info.Nombre = item.Nombre;
                       info.Estado = item.Estado;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdEmpresa = item.IdEmpresa;
                       info.Id_Tipo_Pago_Variable = item.Id_Tipo_Pago_Variable;

                       lista.Add(info);
                   }
               }

               return lista;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }





       public int GetId(int IdEmpresa)
       {
           try
           {
               using (EntityRoles_FJ database = new EntityRoles_FJ())
               {

                   var query = (from i in database.ro_parametro_x_pago_variable
                                where i.IdEmpresa == IdEmpresa
                                select i);

                   if (query.Count() == 0)
                   {
                       return 1;
                   }
                   else
                   {
                       var query_ = (from i in database.ro_parametro_x_pago_variable
                                     where i.IdEmpresa == IdEmpresa
                                     select i.Id_Tipo_Pago_Variable).Count();
                       return query.Count() + 1;
                   }

               }

           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }

       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;

namespace Core.Erp.Data.Roles_Fj
{
   public class ro_parametro_x_pago_variable_tipo_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Modificar_DB(List<ro_parametro_x_pago_variable_tipo_Info> lista)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {

                   foreach (var info in lista)
                   {
                       var contact = db.ro_parametro_x_pago_variable_tipo.First(obj => obj.IdEmpresa == info.IdEmpresa &&
                             obj.cod_Pago_Variable == info.cod_Pago_Variable);

                       contact.IdRubro = info.IdRubro;
                       contact.nom_Pago_Variable = info.nom_Pago_Variable;
                       db.SaveChanges();
                   }
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

       public List<ro_parametro_x_pago_variable_tipo_Info> Get_lista_tipo_pago_variable(int IdEmpresa)
       {
           try
           {
               List<ro_parametro_x_pago_variable_tipo_Info> lista = new List<ro_parametro_x_pago_variable_tipo_Info>();

               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {

                   var contact = from q in Context.ro_parametro_x_pago_variable_tipo
                                 where q.IdEmpresa == IdEmpresa
                                
                                 select q;

                   foreach (var info in contact)
                   {
                       ro_parametro_x_pago_variable_tipo_Info add = new ro_parametro_x_pago_variable_tipo_Info();
                       add.IdEmpresa = info.IdEmpresa;
                       add.cod_Pago_Variable = info.cod_Pago_Variable;
                       add.nom_Pago_Variable = info.nom_Pago_Variable;
                       add.IdRubro = info.IdRubro;
                       add.cod_Pago_Variable = info.cod_Pago_Variable;
                      
                       lista.Add(add);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
   
    }
}

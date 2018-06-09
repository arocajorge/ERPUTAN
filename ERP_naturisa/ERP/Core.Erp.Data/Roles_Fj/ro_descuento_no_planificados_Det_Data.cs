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
   public class ro_descuento_no_planificados_Det_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(List< ro_descuento_no_planificados_Det_Info> lista)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   ro_descuento_no_planificados_Det_Info info = new ro_descuento_no_planificados_Det_Info();
                   info = lista.FirstOrDefault();
                   db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_descuento_no_planificados_Det where IdEmpresa='" + info.IdEmpresa + "' and IdNomina_Tipo='" + info.IdNomina_Tipo + "' and IdEmpleado='" + info.IdEmpleado + "' and IdDescuento='" + info.IdDescuento + "' ");

                   foreach (var item in lista)
                   {
                   ro_descuento_no_planificados_Det add = new ro_descuento_no_planificados_Det();
                   add.IdEmpresa = item.IdEmpresa;
                   add.IdNomina_Tipo = item.IdNomina_Tipo;
                   add.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                   add.IdEmpleado = item.IdEmpleado;
                   add.IdDescuento = item.IdDescuento;
                   add.IdRubro = item.IdRubro;
                   if (item.Observacion == null)
                       add.Observacion = ".";
                       else
                   add.Observacion = item.Observacion;
                   add.Secuencia = item.Secuencia;
                   add.Valor = item.Valor;
                   add.Fecha_Descuento = item.Fecha_Descuento;
                   db.ro_descuento_no_planificados_Det.Add(add);
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



       public List<ro_descuento_no_planificados_Det_Info> listado_Descuento(int IdEmpresa,int IdNomina_Tipo, decimal IdEmpleado, int IdDescuento)
       {
           try
           {
               List<ro_descuento_no_planificados_Det_Info> lista = new List<ro_descuento_no_planificados_Det_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                  
                   var query = from q in db.ro_descuento_no_planificados_Det
                               where
                               q.IdEmpresa == IdEmpresa
                               && q.IdDescuento==IdDescuento
                               && q.IdEmpleado==IdEmpleado
                               && q.IdNomina_Tipo == IdNomina_Tipo
                               select q;

                   foreach (var item in query)
                   {
                       ro_descuento_no_planificados_Det_Info info = new ro_descuento_no_planificados_Det_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdDescuento = item.IdDescuento;
                       info.IdRubro = item.IdRubro;
                       info.Observacion = item.Observacion;
                       info.Valor = item.Valor;
                       info.Fecha_Descuento = item.Fecha_Descuento;
                       info.eliminar = true;
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


    }
}

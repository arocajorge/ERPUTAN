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
   public class ro_empleado_x_zona_Det_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(List<ro_empleado_x_zona_Det_Info> lista)
       {
           try
           {
               int sec = 0;
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   foreach (var info in lista)
                   {
                       if (sec == 0)
                           db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_empleado_x_zona_Det where IdEmpresa='" + info.IdEmpresa + "' and IdNomina_Tipo='" + info.IdNomina_Tipo + "' and IdEmpleado='" + info.IdEmpleado + "' ");
                       ro_empleado_x_zona_Det add = new ro_empleado_x_zona_Det();
                       add.IdEmpresa = info.IdEmpresa;
                       add.IdNomina_Tipo = info.IdNomina_Tipo;
                       add.Idzona = info.Idzona;
                       add.IdEmpleado = info.IdEmpleado;
                       add.secuencia = info.secuencia;
                       db.ro_empleado_x_zona_Det.Add(add);
                       db.SaveChanges();
                       sec++;
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
       public List<ro_empleado_x_zona_Det_Info> lista_paramatrso_x_empleados(int IdEmpresa, int idnomina_tipo, int idempleado)
       {
           try
           {
               List<ro_empleado_x_zona_Det_Info> lista = new List<ro_empleado_x_zona_Det_Info>();


               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {

                   var contact = from q in Context.vwro_empleado_x_zona_Det
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdNomina_Tipo == idnomina_tipo
                                 && q.IdEmpleado == idempleado
                                 select q;

                   foreach (var item in contact)
                   {
                       ro_empleado_x_zona_Det_Info Info = new ro_empleado_x_zona_Det_Info();

                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdNomina_Tipo = item.IdNomina_Tipo;
                       Info.IdEmpleado = item.IdEmpleado;
                       Info.zo_descripcion = item.zo_descripcion;
                       Info.icono_eliminar = true;
                       Info.Idzona = item.Idzona;
                     //  Info.Nombre = item.Nombre;
                       lista.Add(Info);
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



       public List<ro_empleado_x_zona_Det_Info> lista_paramatrso_x_empleados(int IdEmpresa, int idnomina_tipo)
       {
           try
           {
               List<ro_empleado_x_zona_Det_Info> lista = new List<ro_empleado_x_zona_Det_Info>();


               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {

                   var contact = from q in Context.vwro_empleado_x_zona_Det
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdNomina_Tipo == idnomina_tipo
                                 select q;

                   foreach (var item in contact)
                   {
                       ro_empleado_x_zona_Det_Info Info = new ro_empleado_x_zona_Det_Info();

                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdNomina_Tipo = item.IdNomina_Tipo;
                       Info.IdEmpleado = item.IdEmpleado;
                       Info.zo_descripcion = item.zo_descripcion;
                       Info.icono_eliminar = true;
                       Info.Idzona = item.Idzona;
                       lista.Add(Info);
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

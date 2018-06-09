/*CLASE: ro_Novedad_x_Empleado_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_Novedad_x_Empleado_Data
    {
       string mensaje = "";
       private List<ro_Novedad_x_Empleado_Info> listado = new List<ro_Novedad_x_Empleado_Info>();

       public List<ro_Novedad_x_Empleado_Info> Get_List_Novedad_x_Empleado(int idEmpresa)
       {
           try {
               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_novedad_x_empleado
                                where a.IdEmpresa == idEmpresa
                                select a);
                   foreach(var item in datos){
                       ro_Novedad_x_Empleado_Info reg = new ro_Novedad_x_Empleado_Info();
                       reg.IdEmpresa = item.IdEmpresa;
                       reg.IdTransaccion = item.IdTransaccion;
                       reg.IdEmpresa_Emp_Novedad = item.IdEmpresa_Emp_Novedad;
                       reg.IdNovedad_Emp_Novedad = item.IdNovedad_Emp_Novedad;
                       reg.IdEmpleado_Emp_Novedad = item.IdEmpleado_Emp_Novedad;
                       reg.Observacion = item.Observacion;
                       reg.estado = item.estado;
                       reg.Fecha = item.Fecha;
                       reg.IdNomina_Tipo = item.IdNomina_Tipo;
                       reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       reg.IdRubro = item.IdRubro;
                       listado.Add(reg);
                   }

                   return listado;
               }                    
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public ro_Novedad_x_Empleado_Info Get_Info_Novedad_x_Empleado_x_IdTransaccion(int idEmpresa, decimal id)
       {
            ro_Novedad_x_Empleado_Info reg = new ro_Novedad_x_Empleado_Info();
           
           try
           {
               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_novedad_x_empleado
                                where a.IdEmpresa == idEmpresa && a.IdTransaccion==id
                                select a);            
                 
                   foreach (var item in datos)
                   {
                       reg.IdEmpresa = item.IdEmpresa;
                       reg.IdTransaccion = item.IdTransaccion;
                       reg.IdEmpresa_Emp_Novedad = item.IdEmpresa_Emp_Novedad;
                       reg.IdNovedad_Emp_Novedad = item.IdNovedad_Emp_Novedad;
                       reg.IdEmpleado_Emp_Novedad = item.IdEmpleado_Emp_Novedad;
                       reg.Observacion = item.Observacion;
                       reg.estado = item.estado;
                       reg.Fecha = item.Fecha;
                       reg.IdNomina_Tipo = item.IdNomina_Tipo;
                       reg.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       reg.IdRubro = item.IdRubro;
                   }

                   return reg;
               }
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public decimal getId(int idEmpresa) 
       {
           try
           {
               int Id;
               using (EntitiesRoles db = new EntitiesRoles()) {
                   var select = (from a in db.ro_novedad_x_empleado
                                where a.IdEmpresa==idEmpresa
                                select a);
                   if (select.ToList().Count() == 0)
                   {
                       Id = 1;
                   }
                   else
                   {
                       var select_pv = (from a in db.ro_novedad_x_empleado
                                        where a.IdEmpresa == idEmpresa
                                        select a.IdTransaccion).Max();
                       Id = Convert.ToInt32(select_pv.ToString()) + 1;
                   }
               }
                return Id;                     
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
            }   
       }


       public Boolean GrabarDB(ro_Novedad_x_Empleado_Info info, decimal id,ref string msg)
       {
        try{
        
            using (EntitiesRoles db =new EntitiesRoles()){
                    var address = new ro_novedad_x_empleado();
                    address.IdTransaccion = info.IdTransaccion = id;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdEmpresa_Emp_Novedad = info.IdEmpresa_Emp_Novedad;
                    address.IdNovedad_Emp_Novedad = info.IdNovedad_Emp_Novedad;
                    address.IdEmpleado_Emp_Novedad = info.IdEmpleado_Emp_Novedad;
                    address.Observacion = info.Observacion;
                    address.Fecha = info.Fecha;
                    address.IdNomina_Tipo = info.IdNomina_Tipo;
                    address.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                    address.IdRubro = info.IdRubro;
                    address.estado = (info.estado == null) ? "A" : info.estado; 

                    db.ro_novedad_x_empleado.Add(address);
                    db.SaveChanges();                           
            }
            return true;
        }catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
        }


       public Boolean ModificarDB(ro_Novedad_x_Empleado_Info info, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var registro = db.ro_novedad_x_empleado.First(a => a.IdEmpresa == info.IdEmpresa && a.IdTransaccion == info.IdTransaccion
                           && a.IdEmpresa_Emp_Novedad == info.IdEmpresa_Emp_Novedad && a.IdNovedad_Emp_Novedad == info.IdNovedad_Emp_Novedad
                           && a.IdEmpleado_Emp_Novedad == info.IdEmpleado_Emp_Novedad);

                   /*registro.IdEmpresa = info.IdEmpresa;
                       registro.IdEmpresa_Emp_Novedad = info.IdEmpresa_Emp_Novedad;
                       registro.IdNovedad_Emp_Novedad = info.IdNovedad_Emp_Novedad;
                       registro.IdEmpleado_Emp_Novedad = info.IdEmpleado_Emp_Novedad;
                   */
                       registro.Observacion = info.Observacion;
                       registro.Fecha = info.Fecha;
                       registro.IdNomina_Tipo = info.IdNomina_Tipo;
                       registro.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                       registro.IdRubro = info.IdRubro;
                       registro.estado = info.estado;

                   db.SaveChanges();
                   msg = "Se ha procedido a modificar el registro del cargo # : " + info.IdTransaccion.ToString() + " exitosamente";
                   }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public Boolean EliminarDB(ro_Novedad_x_Empleado_Info info, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var registro = db.ro_novedad_x_empleado.First(a => a.IdEmpresa == info.IdEmpresa && a.IdTransaccion == info.IdTransaccion
                           && a.IdEmpresa_Emp_Novedad == info.IdEmpresa_Emp_Novedad && a.IdNovedad_Emp_Novedad == info.IdNovedad_Emp_Novedad
                           && a.IdEmpleado_Emp_Novedad == info.IdEmpleado_Emp_Novedad);

                   registro.estado = "I";

                   db.SaveChanges();
                   msg = "Se ha procedido anular el registro del Cargo #: " + info.IdTransaccion.ToString() + " exitosamente";
               }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public Boolean BorrarDB(ro_Novedad_x_Empleado_Info info, ref string msg)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var S = context.Database.ExecuteSqlCommand("delete from dbo.ro_novedad_x_empleado  where IdEmpresa =" + info.IdEmpresa.ToString() 
                       + " AND IdTransaccion="+info.IdTransaccion.ToString()
                       + " AND IdEmpresa_Emp_Novedad=" + info.IdEmpresa_Emp_Novedad.ToString()
                       + " AND IdNovedad_Emp_Novedad=" + info.IdNovedad_Emp_Novedad .ToString()
                       + " AND IdEmpleado_Emp_Novedad=" + info.IdEmpleado_Emp_Novedad.ToString()
                       );
               }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}

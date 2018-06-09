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
   public class ro_Remplazo_x_emplado_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(ro_Remplazo_x_emplado_Info info, ref int Id_Remplazo)
       {
           try
           {
               using (EntityRoles_FJ db= new EntityRoles_FJ())
               {
                   
                   ro_Remplazo_x_emplado add = new ro_Remplazo_x_emplado();
                   add.Id_remplazo = GetId(info.IdEmpresa);
                   add.IdEmpleado = info.IdEmpleado;
                   add.IdEmpresa = info.IdEmpresa;
                   add.IdEmpleado_Remplazo = info.IdEmpleado_Remplazo;
                   add.Id_Motivo_Ausencia_Cat = info.Id_Motivo_Ausencia_Cat;
                   add.Id_Tipo_tipo_Remplazo_Cat = info.Id_Tipo_tipo_Remplazo_Cat;
                   add.IdNomina_Tipo = info.IdNomina_Tipo;
                   add.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                   add.IdPeriodo = info.IdPeriodo;
                   add.Fecha_Entrada = info.Fecha_Entrada;
                   add.Fecha_Salida = info.Fecha_Salida;
                   add.Fecha = info.Fecha;
                   add.Hora_regreso = info.Hora_regreso;
                   add.Hora_salida = info.Hora_salida;
                   add.Observacion = info.Observacion;
                   add.IdRubro = info.IdRubro;
                   add.IdNovedad = info.IdNovedad;
                   add.valor_x_dia_remplazo = info.valor_x_dia_remplazo;
                   add.Total_pagar_remplazo = info.Total_pagar_remplazo;
                   add.Valor_descuento_empleado = info.Valor_descuento_empleado;
                   add.Fecha_descuenta_rol = info.Fecha_descuenta_rol;
                   add.Estado = "A";
                   add.IdUsuario = info.IdUsuario;
                   add.Fecha_Transac = DateTime.Now;
                   db.ro_Remplazo_x_emplado.Add(add);
                   db.SaveChanges();
                   Id_Remplazo = add.Id_remplazo;
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


       public bool Modificar_DB(ro_Remplazo_x_emplado_Info info)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                  var add = db.ro_Remplazo_x_emplado.FirstOrDefault(v=>v.IdEmpresa==info.IdEmpresa && v.IdEmpleado==info.IdEmpleado && v.Id_remplazo==info.Id_remplazo);
                  
                   add.IdEmpleado_Remplazo = info.IdEmpleado_Remplazo;
                   add.Fecha_Entrada = info.Fecha_Entrada;
                   add.Fecha_Salida = info.Fecha_Salida;
                   add.Fecha = info.Fecha;
                   add.Hora_regreso = info.Hora_regreso;
                   add.Hora_salida = info.Hora_salida;
                   add.Descuenta_rol = info.Descuenta_rol;
                   add.Observacion = info.Observacion;
                   add.Id_Motivo_Ausencia_Cat = info.Id_Motivo_Ausencia_Cat;
                   add.Id_Tipo_tipo_Remplazo_Cat = info.Id_Tipo_tipo_Remplazo_Cat;
                   add.IdNomina_Tipo = info.IdNomina_Tipo;
                   add.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                   add.IdPeriodo = info.IdPeriodo;
                   add.IdRubro = info.IdRubro;
                   add.IdNovedad = info.IdNovedad;
                   add.valor_x_dia_remplazo = info.valor_x_dia_remplazo;
                   add.Total_pagar_remplazo = info.Total_pagar_remplazo;
                   add.Valor_descuento_empleado = info.Valor_descuento_empleado;
                   add.Fecha_descuenta_rol = info.Fecha_descuenta_rol;
                   add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                   add.Fecha_UltMod = info.Fecha_UltMod;
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
      
       public bool Modificar_DB_IdNovedad(ro_Remplazo_x_emplado_Info info)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var add = db.ro_Remplazo_x_emplado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdEmpleado == info.IdEmpleado && v.Id_remplazo == info.Id_remplazo);

                   add.IdNovedad = info.IdNovedad;
                   add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                   add.Fecha_UltMod = info.Fecha_UltMod;
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


       public bool Anular_DB(ro_Remplazo_x_emplado_Info info)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var add = db.ro_Remplazo_x_emplado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdEmpleado == info.IdEmpleado && v.Id_remplazo == info.Id_remplazo);

                   add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                   add.Fecha_UltAnu = info.Fecha_UltAnu;
                   add.MotiAnula = info.MotiAnula;
                   add.Estado = "I";
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


       public List<ro_Remplazo_x_emplado_Info> listado_remplazo(int IdEmpresa,DateTime fecha_desde,DateTime fecha_hasta)
       {
           try
           {
           List<ro_Remplazo_x_emplado_Info> lista= new List<ro_Remplazo_x_emplado_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var query = from q in db.vwro_Remplazo_x_emplado 
                              where
                              q.IdEmpresa==IdEmpresa
                              && q.Fecha_Salida>=fecha_desde
                              && q.Fecha_Salida<=fecha_hasta
                              select q;

                   foreach (var item in query)
                   {
                       ro_Remplazo_x_emplado_Info info = new ro_Remplazo_x_emplado_Info();

                       info.Id_remplazo = item.Id_remplazo;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado_Remplazo = item.IdEmpleado_Remplazo;
                       info.Fecha_Entrada = item.Fecha_Entrada;
                       info.Fecha_Salida = item.Fecha_Salida;
                       info.Fecha = item.Fecha;
                       info.Hora_regreso = item.Hora_regreso;
                       info.Hora_salida = item.Hora_salida;
                       info.Descuenta_rol = item.Descuenta_rol;
                       info.Observacion = item.Observacion;
                       info.Id_Motivo_Ausencia_Cat = item.Id_Motivo_Ausencia_Cat;
                       info.Id_Tipo_tipo_Remplazo_Cat = item.Id_Tipo_tipo_Remplazo_Cat;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       info.IdPeriodo = item.IdPeriodo;
                       info.pe_apellido = item.pe_apellido;
                       info.pe_nombre = item.pe_nombre;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.IdRubro = item.IdRubro;
                       info.valor_x_dia_remplazo = item.valor_x_dia_remplazo;
                       info.Total_pagar_remplazo = item.Total_pagar_remplazo;
                       info.Valor_descuento_empleado = item.Valor_descuento_empleado;
                       info.Fecha_descuenta_rol = item.Fecha_descuenta_rol;
                       info.IdNovedad = item.IdNovedad;
                       info.Estado = item.Estado;
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

       public List<ro_Remplazo_x_emplado_Info> listado_remplazo_Historico(int IdEmpresa,decimal IdEmpleado)
       {
           try
           {
               List<ro_Remplazo_x_emplado_Info> lista = new List<ro_Remplazo_x_emplado_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var query = from q in db.vwro_Remplazo_x_emplado
                               where
                               q.IdEmpresa == IdEmpresa
                               && q.IdEmpleado == IdEmpleado
                               select q;

                   foreach (var item in query)
                   {
                       ro_Remplazo_x_emplado_Info info = new ro_Remplazo_x_emplado_Info();

                       info.Id_remplazo = item.Id_remplazo;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado_Remplazo = item.IdEmpleado_Remplazo;
                       info.Fecha_Entrada = item.Fecha_Entrada;
                       info.Fecha_Salida = item.Fecha_Salida;
                       info.Fecha = item.Fecha;
                       info.Hora_regreso = item.Hora_regreso;
                       info.Hora_salida = item.Hora_salida;
                       info.Observacion = item.Observacion;
                       info.Id_Motivo_Ausencia_Cat = item.Id_Motivo_Ausencia_Cat;
                       info.Id_Tipo_tipo_Remplazo_Cat = item.Id_Tipo_tipo_Remplazo_Cat;
                       info.pe_apellido = item.pe_apellido;
                       info.pe_nombre = item.pe_nombre;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
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


       public bool Get_si_existe_remplazo_activo(ro_Remplazo_x_emplado_Info info)
       {
           try
           {
               bool si_existe = false;
               List<ro_Remplazo_x_emplado_Info> lista = new List<ro_Remplazo_x_emplado_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var query = from q in db.ro_Remplazo_x_emplado
                               where
                               q.IdEmpresa == info.IdEmpresa
                               && q.IdEmpleado == info.IdEmpleado

                               &&q.Fecha_Entrada>=info.Fecha_Entrada
                               && q.Fecha_Entrada <= info.Fecha_Salida                                                          
                               select q;

                   if (query.Count() > 0)
                   {
                       si_existe= true;
                   }
                   else
                   {

                       si_existe = false;
                   }

                   
               }

               return si_existe;
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

       public List<ro_Remplazo_x_emplado_Info> Get_lista_remplazo_para_reversar_horas_extras(int IdEmpresa, DateTime Fecha_Maxima, DateTime Fecha_minina)
       {
           try
           {
               List<ro_Remplazo_x_emplado_Info> lista = new List<ro_Remplazo_x_emplado_Info>();
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var query = from q in db.vwro_Remplazo_x_emplado
                               where
                               q.IdEmpresa == IdEmpresa
                              &&
                               (
                                q.Fecha_Entrada >= Fecha_minina
                                && q.Fecha_Entrada <= Fecha_Maxima                               
                               ||                               
                               q.Fecha_Salida<=Fecha_minina
                               && q.Fecha_Salida>=Fecha_Maxima
                               )
                               select q;

                   foreach (var item in query)
                   {
                       ro_Remplazo_x_emplado_Info info = new ro_Remplazo_x_emplado_Info();

                       info.Id_remplazo = item.Id_remplazo;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado_Remplazo = item.IdEmpleado_Remplazo;
                       info.Fecha_Entrada = item.Fecha_Entrada;
                       info.Fecha_Salida = item.Fecha_Salida;
                       info.Fecha = item.Fecha;
                       info.Hora_regreso = item.Hora_regreso;
                       info.Hora_salida = item.Hora_salida;
                       info.Descuenta_rol = item.Descuenta_rol;
                       info.Observacion = item.Observacion;
                       info.Id_Motivo_Ausencia_Cat = item.Id_Motivo_Ausencia_Cat;
                       info.Id_Tipo_tipo_Remplazo_Cat = item.Id_Tipo_tipo_Remplazo_Cat;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       info.IdPeriodo = item.IdPeriodo;
                       info.pe_apellido = item.pe_apellido;
                       info.pe_nombre = item.pe_nombre;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.IdRubro = item.IdRubro;
                       info.valor_x_dia_remplazo = item.valor_x_dia_remplazo;
                       info.Total_pagar_remplazo = item.Total_pagar_remplazo;
                       info.Valor_descuento_empleado = item.Valor_descuento_empleado;
                       info.Fecha_descuenta_rol = item.Fecha_descuenta_rol;
                       info.IdNovedad = item.IdNovedad;
                       info.Estado = item.Estado;
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

                   var query = (from i in database.ro_Remplazo_x_emplado
                                where i.IdEmpresa == IdEmpresa
                                select i);

                   if (query.Count() == 0)
                   {
                       return 1;
                   }
                   else
                   {
                       var query_ = (from i in database.ro_Remplazo_x_emplado
                                     where i.IdEmpresa == IdEmpresa
                                     select i.Id_remplazo).Count();
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

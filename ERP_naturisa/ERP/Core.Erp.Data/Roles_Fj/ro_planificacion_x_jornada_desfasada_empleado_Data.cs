using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
namespace Core.Erp.Data.Roles_Fj
{
  public  class ro_planificacion_x_jornada_desfasada_empleado_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_planificacion_x_jornada_desfasada_empleado_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_planificacion_x_jornada_desfasada_empleado add = new ro_planificacion_x_jornada_desfasada_empleado();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdEmpleado = info.IdEmpleado;
                  add.IdPeriodo = info.IdPeriodo;
                  add.IdTurno = info.IdTurno;
                  add.IdAnio = info.IdAnio;
                  add.IdMes = info.IdMes;
                  add.Observacion = info.Observacion;
                  add.Estado = "A";
                  db.ro_planificacion_x_jornada_desfasada_empleado.Add(add);
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

      public bool Modificar_DB(ro_planificacion_x_jornada_desfasada_empleado_Info item)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  
                  var add = db.ro_planificacion_x_jornada_desfasada_empleado.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdPeriodo == item.IdPeriodo && v.IdEmpleado==item.IdEmpleado);
                  add.IdTurno = item.IdTurno;
                  add.Observacion = item.Observacion;
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

      public bool Anular_DB(List<ro_planificacion_x_jornada_desfasada_empleado_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var item in lista)
                  {
                      var add = db.ro_planificacion_x_jornada_desfasada_empleado.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdPeriodo == item.IdPeriodo && v.IdEmpleado == item.IdEmpleado);                    
                      add.Estado = "I";
                      db.ro_planificacion_x_jornada_desfasada_empleado.Add(add);
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

      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Listado_planificacion_x_periodo(int IdEmpresa, int IdNomina_Tipo, int IdPeriodo)
      {
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> lista = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_ro_planificacion_x_jornada_desfasada_empleado
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.IdNomina_Tipo==IdNomina_Tipo
                              &&q.IdPeriodo==IdPeriodo
                              select q;

                  foreach (var item in query)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info add = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      add.IdEmpresa = item.IdEmpresa;
                      add.IdNomina_Tipo = item.IdNomina_Tipo;
                      add.IdEmpleado = item.IdEmpleado;
                      add.IdPeriodo = item.IdPeriodo;
                      add.IdTurno = item.IdTurno;
                      add.Observacion = item.Observacion;
                      add.pe_nombreCompleto = item.pe_nombreCompleto;
                      lista.Add(add);
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

      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdTurno)
      {
          string mensaje = "";
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> oListadoInfo = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)

                                select a);
                  foreach (var item in select)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info info = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Num_jornada_desfasada = item.Num_jornada_desfasada;
                      info.IdTurno = IdTurno;
                      oListadoInfo.Add(info);
                  }
                  return oListadoInfo;
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

      
      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo,int IdDepartamento,int IdCargo, int IdTurno)
      {
          string mensaje = "";
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> oListadoInfo = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)
                                where 
                                 a.IdDepartamento==IdDepartamento
                                 && a.IdCargo==IdCargo
                                select a);
                  foreach (var item in select)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info info = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Num_jornada_desfasada = item.Num_jornada_desfasada;
                      info.IdTurno = IdTurno;
                      oListadoInfo.Add(info);
                  }
                  return oListadoInfo;
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


      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_dep(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdDepartamento, int IdTurno)
      {
          string mensaje = "";
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> oListadoInfo = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)
                                where
                                 a.IdDepartamento == IdDepartamento
                                select a);
                  foreach (var item in select)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info info = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Num_jornada_desfasada = item.Num_jornada_desfasada;
                      info.IdTurno = IdTurno;
                      oListadoInfo.Add(info);
                  }
                  return oListadoInfo;
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
      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_car(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdCargo, int IdTurno)
      {
          string mensaje = "";
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> oListadoInfo = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)
                                where
                                a.IdCargo == IdCargo
                               
                                select a);
                  foreach (var item in select)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info info = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Num_jornada_desfasada = item.Num_jornada_desfasada;
                      info.IdTurno = IdTurno;
                      oListadoInfo.Add(info);
                  }
                  return oListadoInfo;
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

      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_car(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, decimal IdDivision, int IdTurno)
      {
          string mensaje = "";
          try
          {
              List<ro_planificacion_x_jornada_desfasada_empleado_Info> oListadoInfo = new List<ro_planificacion_x_jornada_desfasada_empleado_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)
                                where
                                a.IdDivision == IdDivision

                                select a);
                  foreach (var item in select)
                  {
                      ro_planificacion_x_jornada_desfasada_empleado_Info info = new ro_planificacion_x_jornada_desfasada_empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Num_jornada_desfasada = item.Num_jornada_desfasada;
                      info.IdTurno = IdTurno;
                      oListadoInfo.Add(info);
                  }
                  return oListadoInfo;
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



      public bool Eliminar(ro_planificacion_x_jornada_desfasada_Info info)
      {
          string mensaje = "";
          try
          {

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  db.Database.ExecuteSqlCommand(" delete Fj_servindustrias.ro_planificacion_x_jornada_desfasada_empleado where IdEmpresa='" + info.IdEmpresa + "'  and IdNomina_Tipo='" + info.IdNomina_Tipo + "'  and IdPeriodo='" + info.IdPeriodo + "'");
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

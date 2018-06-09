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
  public  class ro_empleado_x_turno_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_empleado_x_turno_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_empleado_x_turno add = new ro_empleado_x_turno();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdEmpleado = info.IdEmpleado;
                  add.IdPeriodo = info.IdPeriodo;
                  add.IdTurno = info.IdTurno;
                  add.Observacion = info.Observacion;
                  add.IdUsuario = info.IdUsuario;
                  add.Fecha_Transac = DateTime.Now;
                  add.Estado = "A";
                  db.ro_empleado_x_turno.Add(add);
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

      public bool Modificar_DB(List<ro_empleado_x_turno_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var item in lista)
                  {
                  var add = db.ro_empleado_x_turno.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdPeriodo == item.IdPeriodo && v.IdEmpleado==item.IdEmpleado);
                  add.IdTurno = item.IdTurno;
                  add.Observacion = item.Observacion;
                  add.IdUsuarioModif = item.IdUsuarioModif;
                  add.Fecha_Transac = DateTime.Now;
                  add.Estado = "A";
                  db.ro_empleado_x_turno.Add(add);
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

      public bool Anular_DB(List<ro_empleado_x_turno_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var item in lista)
                  {
                      var add = db.ro_empleado_x_turno.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa 
                          && v.IdPeriodo == item.IdPeriodo && v.IdEmpleado == item.IdEmpleado);                    
                      add.Estado = "I";
                      db.ro_empleado_x_turno.Add(add);
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

      public List<ro_empleado_x_turno_Info> listado_Grupos(int IdEmpresa, int IdNomina_Tipo, int IdPeriodo)
      {
          try
          {
              List<ro_empleado_x_turno_Info> lista = new List<ro_empleado_x_turno_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.ro_empleado_x_turno
                              where
                              q.IdEmpresa == IdEmpresa

                              select q;

                  foreach (var item in query)
                  {
                      ro_empleado_x_turno_Info add = new ro_empleado_x_turno_Info();
                      add.IdEmpresa = item.IdEmpresa;
                      add.IdNomina_Tipo = item.IdNomina_Tipo;
                      add.IdEmpleado = item.IdEmpleado;
                      add.IdPeriodo = item.IdPeriodo;
                      add.IdTurno = item.IdTurno;
                      add.Observacion = item.Observacion;
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

      public List<ro_empleado_x_turno_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo)
      {
          string mensaje = "";
          try
          {
              List<ro_empleado_x_turno_Info> oListadoInfo = new List<ro_empleado_x_turno_Info>();

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var select = (from a in db.spro_empleados_con_jornadas_desfasada(IdEmpresa, IdNomina_tipo, info_periodo.IdPeriodo, info_periodo.pe_mes, info_periodo.pe_anio)

                                select a);
                  foreach (var item in select)
                  {
                      ro_empleado_x_turno_Info info = new ro_empleado_x_turno_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNomina_Tipo = item.IdTipoNomina;
                      info.pe_nombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
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

     
    }
}

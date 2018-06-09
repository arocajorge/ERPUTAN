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
  public  class ro_fectividad_Entrega_x_Periodo_Empleado_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_fectividad_Entrega_x_Periodo_Empleado_Info info, ref int IdEfectividad)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_fectividad_Entrega_x_Periodo_Empleado add = new ro_fectividad_Entrega_x_Periodo_Empleado();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdNomina_tipo_Liq = info.IdNomina_tipo_Liq;
                  add.IdEfectividad = getId(info.IdEmpresa);
                  add.IdPeriodo = info.IdPeriodo;
                  add.Observacion = info.Observacion;
                  add.FechaTransac =DateTime.Now;
                  add.IdUsuario = info.IdUsuario;
                  add.Estado = info.Estado;
                
                  db.ro_fectividad_Entrega_x_Periodo_Empleado.Add(add);
                  db.SaveChanges();
                  IdEfectividad = add.IdEfectividad;
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

      public bool Modificar_DB(ro_fectividad_Entrega_x_Periodo_Empleado_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_planificacion_x_ruta_x_empleado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.IdPeriodo == info.IdPeriodo);

                  add.Observacion = info.Observacion;
                  add.Fecha_UltMod = DateTime.Now;
                  add.IdUsuarioUltModi = info.IdUsuarioUltModi;

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

      public bool Anular_DB(ro_fectividad_Entrega_x_Periodo_Empleado_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_planificacion_x_ruta_x_empleado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.IdPeriodo == info.IdPeriodo);

                  add.Estado = false;
                  add.Fecha_UltAnu = DateTime.Now;
                  add.IdUsuarioUltAnu = info.IdUsuarioAnu;

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

      public List<ro_fectividad_Entrega_x_Periodo_Empleado_Info> listado_Grupos(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_fin)
      {
          try
          {
              List<ro_fectividad_Entrega_x_Periodo_Empleado_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_fectividad_Entrega_x_Periodo_Empleado
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.pe_FechaIni >= Fecha_Inicio
                              && q.pe_FechaIni <= Fecha_fin
                              select q;

                  foreach (var item in query)
                  {
                      ro_fectividad_Entrega_x_Periodo_Empleado_Info info = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdNomina_tipo_Liq = item.IdNomina_tipo_Liq;
                      info.IdEfectividad = item.IdEfectividad;
                      info.Observacion = item.Observacion;
                      info.IdPeriodo = item.IdPeriodo;
                      info.pe_FechaIni = item.pe_FechaIni;
                      info.pe_FechaFin = item.pe_FechaFin;
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

      public bool Si_existe(int IdEmpresa, int idNomina_tipo, int IdPeriodo)
      {
          try
          {
              List<ro_fectividad_Entrega_x_Periodo_Empleado_Info> lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.ro_fectividad_Entrega_x_Periodo_Empleado
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.IdNomina_Tipo == idNomina_tipo
                              && q.IdPeriodo == IdPeriodo
                              select q;
                  if (query.Count() > 0)
                      return true;
                  else
                      return false;

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


      public int getId(int IdEmpresa)
      {
          try
          {
              int Id;
              EntityRoles_FJ OEEmpleado = new EntityRoles_FJ();
              var select = from q in OEEmpleado.ro_fectividad_Entrega_x_Periodo_Empleado
                           where q.IdEmpresa == IdEmpresa
                           select q;

              if (select.Count() == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in OEEmpleado.ro_fectividad_Entrega_x_Periodo_Empleado
                                   where q.IdEmpresa == IdEmpresa
                                   select q.IdEfectividad).Max();
                  Id = Convert.ToInt32(select_em) + 1;
              }
              return Id;
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

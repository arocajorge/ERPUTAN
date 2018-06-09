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
  public class ro_fectividad_x_empleado_Adm_x_periodo_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_fectividad_x_empleado_Adm_x_periodo add = new ro_fectividad_x_empleado_Adm_x_periodo();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdNomina_Tipo_Liq = info.IdNomina_Tipo_Liq;
                  add.IdPeriodo = info.IdPeriodo;
                  add.Observacion = info.Observacion;
                  add.Fecha_Transaccion = info.Fecha_Transaccion;
                  add.IdUsuario = info.IdUsuario;
                  add.Estado = info.Estado;

                  db.ro_fectividad_x_empleado_Adm_x_periodo.Add(add);
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

      public bool Modificar_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_fectividad_x_empleado_Adm_x_periodo.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.IdPeriodo == info.IdPeriodo);

                  add.Observacion = info.Observacion;
                  add.Fecha_UltMod = info.Fecha_UltMod;
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

      public bool Anular_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_fectividad_x_empleado_Adm_x_periodo.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdNomina_Tipo == info.IdNomina_Tipo && v.IdPeriodo == info.IdPeriodo);

                  add.Estado = false;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;

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

      public List<ro_fectividad_x_empleado_Adm_x_periodo_Info> lista_Efectividad_x_periodod(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_fin)
      {
          try
          {
              List<ro_fectividad_x_empleado_Adm_x_periodo_Info> lista = new List<ro_fectividad_x_empleado_Adm_x_periodo_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.ro_fectividad_x_empleado_Adm_x_periodo
                              where
                              q.IdEmpresa == IdEmpresa
                             // && q.pe_FechaIni >= Fecha_Inicio
                            //  && q.pe_FechaIni <= Fecha_fin
                              select q;

                  foreach (var item in query)
                  {
                      ro_fectividad_x_empleado_Adm_x_periodo_Info info = new ro_fectividad_x_empleado_Adm_x_periodo_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                      info.Observacion = item.Observacion;
                      info.IdPeriodo = item.IdPeriodo;
                      info.Estado = item.Estado;
                    //  info.pe_FechaFin = item.pe_FechaIni;
                    //  info.pe_FechaFin = item.pe_FechaFin;
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
              List<ro_fectividad_x_empleado_Adm_x_periodo_Info> lista = new List<ro_fectividad_x_empleado_Adm_x_periodo_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.ro_fectividad_x_empleado_Adm_x_periodo
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


    }
}

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
  public  class ro_empleado_x_Activo_Fijo_Historico_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_empleado_x_Activo_Fijo_Historico_Info info)
      {
          try
          {

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_empleado_x_Activo_Fijo_Historico add = new ro_empleado_x_Activo_Fijo_Historico();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_tipo = info.IdNomina_tipo;
                  add.IdPeriodo = info.IdPeriodo;
                  add.Id_Historico = GetId(info.IdEmpresa, info.IdActivo_fijo);
                  add.IdActivo_fijo = info.IdActivo_fijo;
                  add.IdEmpleado = info.IdEmpleado;
                  add.Fecha_Asignacion = info.Fecha_Asignacion;
                  add.Fecha_Hasta = info.Fecha_Hasta;
                  db.ro_empleado_x_Activo_Fijo_Historico.Add(add);
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

      public List<ro_empleado_x_Activo_Fijo_Historico_Info> listado_Grupos(int IdEmpresa, int IdActivo_fijo)
      {
          try
          {
              List<ro_empleado_x_Activo_Fijo_Historico_Info> lista = new List<ro_empleado_x_Activo_Fijo_Historico_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_ro_empleado_x_Activo_Fijo_Historico
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.IdActivo_fijo == IdActivo_fijo
                              select q;

                  foreach (var item in query)
                  {
                      ro_empleado_x_Activo_Fijo_Historico_Info info = new ro_empleado_x_Activo_Fijo_Historico_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdActivo_fijo = item.IdActivo_fijo;
                      //info.IdNomina_tipo = item.IdNomina_tipo;
                      info.IdPeriodo = info.IdPeriodo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.Fecha_Asignacion =Convert.ToDateTime( item.Fecha_Asignacion);
                      info.Fecha_Hasta =Convert.ToDateTime( item.Fecha_Hasta);
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.de_descripcion = item.de_descripcion;
                      info.Descripcion = item.Descripcion;
                      
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


      public int GetId(int IdEmpresa, int IdActivo_fijo)
      {
          try
          {
              using (EntityRoles_FJ database = new EntityRoles_FJ())
              {

                  var query = (from i in database.ro_empleado_x_Activo_Fijo_Historico
                               where i.IdEmpresa == IdEmpresa
                               && i.IdActivo_fijo == IdActivo_fijo
                               select i);

                  if (query.Count() == 0)
                  {
                      return 1;
                  }
                  else
                  {
                      var query_ = (from i in database.ro_empleado_x_Activo_Fijo_Historico
                                    where i.IdEmpresa == IdEmpresa
                                     && i.IdActivo_fijo == IdActivo_fijo
                                    select i.Id_Historico).Count();
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

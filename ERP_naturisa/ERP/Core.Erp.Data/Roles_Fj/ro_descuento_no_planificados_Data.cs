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
  public  class ro_descuento_no_planificados_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_descuento_no_planificados_Info info, ref int idgrupo)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_descuento_no_planificados add = new ro_descuento_no_planificados();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdEmpleado = info.IdEmpleado;
                  add.IdDescuento = GetId(info.IdEmpresa);
                  add.IdRubro = info.IdRubro;
                  add.Observacion = info.Observacion;
                  add.Valor = info.Valor;
                  add.Estado = true;
                  add.Fecha_Transaccion = info.Fecha_Transaccion;
                  add.IdUsuario = info.IdUsuario;
                  add.Fecha_Incidente = info.Fecha_Incidente;
                  db.ro_descuento_no_planificados.Add(add);
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

      public bool Modificar_DB(ro_descuento_no_planificados_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_descuento_no_planificados.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa
                      && v.IdEmpleado == info.IdEmpleado
                      && v.IdNomina_Tipo==info.IdNomina_Tipo
                      && v.IdDescuento==info.IdDescuento);

                  add.IdRubro = info.IdRubro;
                  add.Observacion = info.Observacion;
                  add.Valor = info.Valor;
                  add.Fecha_Incidente = info.Fecha_Incidente;
                  add.IdNovedad = info.IdNovedad;
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

      public bool Anular_DB(ro_descuento_no_planificados_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_descuento_no_planificados.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa 
                      && v.IdNomina_Tipo == info.IdNomina_Tipo
                      &&v.IdEmpleado==info.IdEmpleado
                      &&v.IdDescuento==info.IdDescuento);

                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.MotivoAnulacion = info.MotivoAnulacion;
                  add.Estado = false;
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

      public List<ro_descuento_no_planificados_Info> listado_Descuento(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
      {
          try
          {

              DateTime fi = Convert.ToDateTime(Fecha_inicio.ToShortDateString());
              DateTime ff = Convert.ToDateTime(Fecha_Fin.ToShortDateString());

              List<ro_descuento_no_planificados_Info> lista = new List<ro_descuento_no_planificados_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_descuento_no_planificados
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.Fecha_Transaccion >= fi
                              && q.Fecha_Transaccion <= ff
                              && q.IdNovedad==null
                              && q.Estado==true
                              select q;

                  foreach (var item in query)
                  {
                      ro_descuento_no_planificados_Info info = new ro_descuento_no_planificados_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdDescuento = item.IdDescuento;
                      info.IdRubro = item.IdRubro;
                      info.Observacion = item.Observacion;
                      info.Valor = item.Valor;
                      info.Estado = item.Estado;
                      info.Fecha_Incidente = item.Fecha_Incidente;
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.ru_descripcion = item.ru_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Observacion = item.Observacion;
                      info.Fecha_Transaccion = item.Fecha_Transaccion;
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
      public List<ro_descuento_no_planificados_Info> listado_Descuento_sin_planificacion(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
      {
          try
          {
              List<ro_descuento_no_planificados_Info> lista = new List<ro_descuento_no_planificados_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_descuento_sin_planificacion
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.Fecha_Transaccion >= Fecha_inicio
                              && q.Fecha_Transaccion <= Fecha_Fin
                              && q.Estado==true
                              select q;

                  foreach (var item in query)
                  {
                      ro_descuento_no_planificados_Info info = new ro_descuento_no_planificados_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdDescuento = item.IdDescuento;
                      info.IdRubro = item.IdRubro;
                      info.Observacion = item.Observacion;
                      info.Valor = item.Valor;
                      info.Estado = item.Estado;
                      info.Fecha_Incidente = item.Fecha_Incidente;
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.ru_descripcion = item.ru_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Observacion = item.Observacion;
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

                  var query = (from i in database.ro_descuento_no_planificados
                               where i.IdEmpresa == IdEmpresa
                               select i);

                  if (query.Count() == 0)
                  {
                      return 1;
                  }
                  else
                  {
                      var query_ = (from i in database.ro_descuento_no_planificados
                                    where i.IdEmpresa == IdEmpresa
                                   
                                    select i.IdDescuento).Count();
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

      public List<ro_descuento_no_planificados_Info> listado_Descuento(int IdEmpresa, int IdNomina_Tipo, int IdEmpleado)
      {
          try
          {
              List<ro_descuento_no_planificados_Info> lista = new List<ro_descuento_no_planificados_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_descuento_no_planificados
                              where
                              q.IdEmpresa == IdEmpresa
                              && q.IdNomina_Tipo == IdNomina_Tipo
                              && q.IdEmpleado == IdEmpleado
                              select q;

                  foreach (var item in query)
                  {
                      ro_descuento_no_planificados_Info info = new ro_descuento_no_planificados_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdDescuento = item.IdDescuento;
                      info.IdNovedad =Convert.ToInt32( item.IdNovedad);
                      info.IdRubro = item.IdRubro;
                      info.IdNovedad =Convert.ToInt32( item.IdNovedad);
                      info.Observacion = item.Observacion;
                      info.Valor = item.Valor;
                      info.Estado = item.Estado;
                      info.Fecha_Incidente = item.Fecha_Incidente;
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.ru_descripcion = item.ru_descripcion;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Observacion = item.Observacion;
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

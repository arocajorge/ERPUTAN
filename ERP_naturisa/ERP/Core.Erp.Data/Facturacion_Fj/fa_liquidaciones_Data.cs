using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion_Fj
{
  public  class fa_liquidaciones_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool GuardarDB(fa_liquidaciones_Info info, ref decimal IdLiquidaciones)
      {
          try
          {
              
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {
                  fa_liquidaciones add = new fa_liquidaciones();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdLiquidaciones = GetId(info.IdEmpresa);
                  add.IdPeriodo = info.IdPeriodo;
                  add.IdUsuario = info.IdUsuario;
                  add.Observacion = info.Observacion;
                  add.fecha = info.fecha;
                  add.Estado_Proceso = info.Estado_Proceso;
                  add.Estado = true;
                  database.fa_liquidaciones.Add(add);
                  database.SaveChanges();
                  IdLiquidaciones = add.IdLiquidaciones;
              }
              return true;

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

      public bool ModificarDB(fa_liquidaciones_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {
                  fa_liquidaciones add = database.fa_liquidaciones.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdPeriodo == info.IdPeriodo);
                  add.IdLiquidaciones = info.IdLiquidaciones;
                  add.IdPeriodo = info.IdPeriodo;
                  add.IdUsuario = info.IdUsuario;
                  add.Observacion = info.Observacion;
                  add.fecha = info.fecha;
                  add.Estado_Proceso = info.Estado_Proceso;
                  add.Estado = info.Estado;
                  add.IdUsuarioUltModi = info.IdUsuarioUltModi;
                  add.Fecha_UltMod = info.Fecha_UltMod;

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

      public bool AnularDB(fa_liquidaciones_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {
                  fa_liquidaciones add = database.fa_liquidaciones.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdPeriodo == info.IdPeriodo);
                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.Estado = false;

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

      public bool Procesar_Liquidaciones(int IdEmpresa, int IdPEriodo, DateTime fecha_inicio, DateTime fecha_fin)
      {
          try
          {
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {

                  database.spFa_Liquidar_Prefacturacion_x_periodo(IdEmpresa, IdPEriodo, fecha_inicio, fecha_fin);

              }
              return true;

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

      public bool si_existe_en_base(fa_liquidaciones_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {

                  var query = (from i in database.fa_liquidaciones
                               where i.IdEmpresa == info.IdEmpresa
                               && i.IdLiquidaciones == info.IdLiquidaciones
                               select i);

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

      public fa_liquidaciones_Info Get_liquidaciones_info(int IdEmpresa, Int32 IdPeriodo)
      {
          try
          {
              fa_liquidaciones_Info info = new fa_liquidaciones_Info();
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {

                  var query = (from i in database.fa_liquidaciones
                               where i.IdEmpresa == IdEmpresa
                               && i.IdPeriodo == IdPeriodo
                               select i);
                  foreach (var item in query)
                  {
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdLiquidaciones = item.IdLiquidaciones;
                      info.Observacion = item.Observacion;
                      info.fecha = item.fecha;
                      info.Estado_Proceso = item.Estado_Proceso;
                  }

                  return info;
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

      public int GetId(int IdEmpresa)
      {
          try
          {
              using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
              {

                  var query = (from i in database.fa_liquidaciones
                               where i.IdEmpresa == IdEmpresa
                               select i);

                  if (query.Count() > 0)
                  {
                      return 1;
                  }
                  else
                  {
                     var query_ = (from i in database.fa_liquidaciones
                                   where i.IdEmpresa == IdEmpresa
                                   select i.IdLiquidaciones).Count();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo_FJ
{
  public  class Af_Poliza_x_AF_det_Data
  {
      string mensaje = "";
      public bool GuardarDB(List<Af_Poliza_x_AF_det_Info> lista)
      {
          try
          {
              int secuancia = 0;
              using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
              {

                  foreach (var item in lista)
                  {
                      secuancia++;
                      Af_Poliza_x_AF_det Address = new Af_Poliza_x_AF_det();
                      Address.IdEmpresa = item.IdEmpresa;
                      Address.IdPoliza = item.IdPoliza;
                      Address.secuencia = secuancia;
                      Address.IdActivoFijo = item.IdActivoFijo;
                      Address.Subtotal_0 = item.Subtotal_0;
                      Address.Subtotal_12 = item.Subtotal_12;
                      Address.IdEstadoFacturacion_cat = item.IdEstadoFacturacion_cat;
                      Address.Iva = item.Iva;
                      Address.Prima = item.Prima;
                      if (item.observacion_det == null)
                      {
                          item.observacion_det = " ";
                      }
                      Address.observacion_det = item.observacion_det;
                      Context.Af_Poliza_x_AF_det.Add(Address);
                      Context.SaveChanges();

                  }

              }
              return true;
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

      public List<Af_Poliza_x_AF_det_Info> Get_List_Poliza_Detalle_Activo(int IdEmpresa, int IdPoliza)
      {
          List<Af_Poliza_x_AF_det_Info> Lista = new List<Af_Poliza_x_AF_det_Info>();
          try
          {
              EntitiesActivoFijo_FJ oEnti = new EntitiesActivoFijo_FJ();

              var qury = from j in oEnti.vwaf_Af_Poliza_x_AF_det
                         where j.IdEmpresa == IdEmpresa
                         && j.IdPoliza == IdPoliza
                         select j;
              foreach (var item in qury)
              {
                  Af_Poliza_x_AF_det_Info info = new Af_Poliza_x_AF_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdPoliza = item.IdPoliza;
                  info.secuencia = item.secuencia;
                  info.IdActivoFijo = item.IdActivoFijo;
                  info.Af_Nombre = item.Af_Nombre;
                  info.Subtotal_0 = item.Subtotal_0;
                  info.Subtotal_12 = item.Subtotal_12;
                  info.IdEstadoFacturacion_cat = item.IdEstadoFacturacion_cat;  
                  info.Iva = item.Iva;
                  info.Prima = item.Prima;
                  info.observacion_det = item.observacion_det;
                  info.check = true;
                  Lista.Add(info);

              }
              return Lista;
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


      public Boolean EliminarDB(int IdEmpresa, int IdPoliza)
      {
          try
          {
              using (EntitiesActivoFijo_FJ Context = new EntitiesActivoFijo_FJ())
              {
                  String SQL = " delete Fj_servindustrias.Af_Poliza_x_AF_det where IdEmpresa='" + IdEmpresa + "'  and IdPoliza='" + IdPoliza + "'";
                  Context.Database.ExecuteSqlCommand(SQL);
              }


              return true;

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

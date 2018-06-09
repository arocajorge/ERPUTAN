using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Data.Facturacion_Fj
{
  public  class fa_pre_facturacion_det_gasto_Interes_Banc_Data
  {
      public List<fa_pre_facturacion_det_gasto_Interes_Banc_Info> Get_List(int IdEmpresa, int IdPreFacturacion)
      {
          try
          {
              List<fa_pre_facturacion_det_gasto_Interes_Banc_Info> Lista = new List<fa_pre_facturacion_det_gasto_Interes_Banc_Info>();

              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  var lst = from q in Context.fa_pre_facturacion_det_gasto_Interes_Banc
                            where q.IdEmpresa == IdEmpresa &&
                            q.IdPreFacturacion == IdPreFacturacion
                            select q;

                  foreach (var item in lst)
                  {
                      fa_pre_facturacion_det_gasto_Interes_Banc_Info info_det = new fa_pre_facturacion_det_gasto_Interes_Banc_Info();
                      info_det.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                      info_det.IdPreFacturacion = Convert.ToDecimal(item.IdPreFacturacion);
                      info_det.secuencia = item.secuencia;
                      info_det.IdCliente = item.IdCliente;
                      info_det.Valor = item.Valor;
                      info_det.Observacion = item.Observacion;
                      
                      Lista.Add(info_det);
                  }
              }

              return Lista;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean Guardar(List<fa_pre_facturacion_det_gasto_Interes_Banc_Info> lst_Info)
      {
          try
          {
              int sec = 1;
              foreach (var item in lst_Info)
              {
                  using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                  {
                      fa_pre_facturacion_det_gasto_Interes_Banc Entity = new fa_pre_facturacion_det_gasto_Interes_Banc();
                      Entity.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                      Entity.IdPreFacturacion = Convert.ToDecimal(item.IdPreFacturacion);
                      Entity.secuencia = item.secuencia;
                      Entity.IdCliente = item.IdCliente;
                      Entity.Valor = item.Valor;
                      Entity.Observacion = item.Observacion;
                      Context.fa_pre_facturacion_det_gasto_Interes_Banc.Add(Entity);
                      Context.SaveChanges();
                  }
                  sec++;
              }
              return true;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean EliminarDB(fa_pre_facturacion_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_gasto_Interes_Banc where IdEmpresa = " + info.IdEmpresa + " and IdPreFacturacion = " + info.IdPreFacturacion);
              }
              return true;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
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

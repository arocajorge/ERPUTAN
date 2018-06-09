using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
  public  class cxc_conciliacion_det_Data
    {

      public int GetSecuencia(int IdEmpresa, int IdSucursal,decimal IdConciliacion, ref string mensaje)
      {
          try
          {
              int Id;
              EntitiesCuentas_x_Cobrar ECXP = new EntitiesCuentas_x_Cobrar();

              var select = ECXP.cxc_conciliacion_det.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdConciliacion==IdConciliacion );
              if (select == 0)
              {
                  return Id = 1;
              }

              else
              {
                  var select_ = (from t in ECXP.cxc_conciliacion_det
                                 where t.IdEmpresa == IdEmpresa && t.IdSucursal == IdSucursal && t.IdConciliacion==IdConciliacion
                                 select t.Secuencia).Max();
                  Id = Convert.ToInt32(select_.ToString()) + 1;
                  return Id;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                  "", "", "", "",DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean GuardarDB(List<cxc_conciliacion_det_Info> Lst, ref decimal Id, ref string mensaje)
      {
          try
          {
              foreach (var Item in Lst)
              {
                  using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                  {
                      cxc_conciliacion_det Deta = new cxc_conciliacion_det();
                      Deta.IdEmpresa_cbr = Item.IdEmpresa_cbr;
                      Deta.IdSucursal_cbr = Item.IdSucursal_cbr;
                      Deta.IdCobro = Item.IdCobro;                  
                      Deta.IdEmpresa = Item.IdEmpresa;
                      Deta.IdSucursal = Item.IdSucursal;
                      Deta.IdConciliacion = Id;
                      Deta.Secuencia = GetSecuencia(Item.IdEmpresa, Item.IdSucursal, Id, ref mensaje);
                      Deta.IdTipoConciliacion = Item.IdTipoConciliacion;
                      Deta.IdEmpresa_nt = Item.IdEmpresa_nt;
                      Deta.IdSucursal_nt = Item.IdSucursal_nt;
                      Deta.IdBodega_nt = Item.IdBodega_nt;
                      Deta.IdNota_nt = Item.IdNota_nt;
                      Deta.IdEmpresa_fa = Item.IdEmpresa_fa;
                      Deta.IdSucursal_fa = Item.IdSucursal_fa;
                      Deta.IdBodega_fa = Item.IdBodega_fa;
                      Deta.IdCbteVta_fa = Item.IdCbteVta_fa;
                      Deta.Saldo_por_aplicar = Item.Saldo_por_aplicar;
                      Deta.Valor_Aplicado = Item.Valor_Aplicado;
                      Deta.TipoDoc_vta = Item.TipoDoc_vta;
                      Context.cxc_conciliacion_det.Add(Deta);
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean ModificarDB(cxc_conciliacion_det_Info info, ref string mensaje)
      {
          try
          {
              Boolean res = false;              
              using (EntitiesCuentas_x_Cobrar cxc = new EntitiesCuentas_x_Cobrar())
              {
                  cxc_conciliacion_det data = cxc.cxc_conciliacion_det.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdSucursal == info.IdSucursal && v.IdConciliacion == info.IdConciliacion && v.Secuencia == info.Secuencia);
                  if (data != null)
                  {
                      data.IdEmpresa_cbr = info.IdEmpresa_cbr;
                      data.IdSucursal_cbr = info.IdSucursal_cbr;
                      data.IdCobro = info.IdCobro;
                      cxc.SaveChanges();
                      res = true;
                  }
              }
              return res;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                   "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<cxc_conciliacion_det_Info> Get_List_conciliacion_det(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
      {
          try
          {
              List<cxc_conciliacion_det_Info> lM = new List<cxc_conciliacion_det_Info>();
              EntitiesCuentas_x_Cobrar ECXC = new EntitiesCuentas_x_Cobrar();
              var Conciliacion = from selec in ECXC.cxc_conciliacion_det
                                 where selec.IdEmpresa == IdEmpresa && selec.IdSucursal == IdSucursal && selec.IdConciliacion == IdConciliacion
                                 select selec;

              foreach (var item in Conciliacion)
              {
                  cxc_conciliacion_det_Info info = new cxc_conciliacion_det_Info();
                  info.IdEmpresa_cbr = item.IdEmpresa_cbr;
                  info.IdSucursal_cbr = item.IdSucursal_cbr;
                  info.IdCobro = item.IdCobro;
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursal;
                  info.IdConciliacion = item.IdConciliacion;
                  info.Secuencia = item.Secuencia;
                  info.IdTipoConciliacion = item.IdTipoConciliacion;
                  info.IdEmpresa_nt = item.IdEmpresa_nt;
                  info.IdSucursal_nt = item.IdSucursal_nt;
                  info.IdBodega_nt = item.IdBodega_nt;
                  info.IdNota_nt = item.IdNota_nt;
                  info.IdEmpresa_fa = Convert.ToInt32(item.IdEmpresa_fa);
                  info.IdSucursal_fa = Convert.ToInt32(item.IdSucursal_fa);
                  info.IdBodega_fa = Convert.ToInt32(item.IdBodega_fa);
                  info.IdCbteVta_fa = Convert.ToDecimal(item.IdCbteVta_fa);
                  info.Saldo_por_aplicar = item.Saldo_por_aplicar;
                  info.Valor_Aplicado = item.Valor_Aplicado;
                  info.TipoDoc_vta = item.TipoDoc_vta;
                  lM.Add(info);
              }     
              return (lM);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }
    }
}

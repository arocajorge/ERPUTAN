using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
  public  class vwfa_creditos_debitos_con_saldo_Data
    {

      public List<vwfa_creditos_debitos_con_saldo_Info> Get_List_CreDeb_Saldo(int IdEmpresa, int IdSucursal,decimal IdCliente,ref string mensaje)
      {
          try
          {
              List<vwfa_creditos_debitos_con_saldo_Info> lM = new List<vwfa_creditos_debitos_con_saldo_Info>();
              EntitiesFacturacion FACT= new EntitiesFacturacion();

              var CreDeb = from selec in FACT.vwfa_creditos_debitos_con_saldo
                           where selec.IdEmpresa == IdEmpresa && selec.IdSucursal == IdSucursal && selec.IdCliente == IdCliente
                           && selec.Saldo>0
                                 select selec;

              foreach (var item in CreDeb)
              {
                  vwfa_creditos_debitos_con_saldo_Info info = new vwfa_creditos_debitos_con_saldo_Info();

                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal=item.IdSucursal; 
                   info.IdBodega=item.IdBodega;
                   info.Tipo = item.Tipo;
                   info.IdNota = item.IdNota;
                   info.CreDeb = item.CreDeb;
                   info.Serie1 = item.Serie1;
                   info.Serie2 = item.Serie2;
                   info.NumNota_Impresa = item.NumNota_Impresa; 
                   info.IdCliente=item.IdCliente; 
                   info.NomSucursal=item.NomSucursal; 
                   info.Nom_Bodega=item.Nom_Bodega; 
                   info.no_fecha=item.no_fecha; 
                   info.no_fecha_venc=Convert.ToDateTime(item.no_fecha_venc); 
                   info.sc_observacion=item.sc_observacion; 
                   info.Nom_Cliente=item.Nom_Cliente; 
                   info.Motivo_Nota=item.Motivo_Nota; 
                   info.Referencia=item.Referencia; 
                   info.sc_total=Convert.ToDouble(item.sc_total);
                   info.Saldo = Convert.ToDouble(item.Saldo);

                   info.saldoAUX_CreDeb = Convert.ToDouble(item.Saldo);

                   info.IdTipoConciliacion = item.IdTipoConciliacion;

                  lM.Add(info);
              }
              return (lM);
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}

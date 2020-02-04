using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
  public  class XCXP_NATU_Rpt007_Data
    {
      
      public List<XCXP_NATU_Rpt007_Info> consultar_Data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin
          ,ref List<XCXP_NATU_Rpt007_Resumen_Info> list_Resumen_ret 
          ,ref string mensaje)
      {
          try
          {

              List<XCXP_NATU_Rpt007_Info> listadedatos = new List<XCXP_NATU_Rpt007_Info>();
              

              DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
              DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());


              decimal ProveIni = 0;
              decimal ProveFin = 0;

              if (ProveedorIni == 0 && ProveedorFin == 0)
              {
                  ProveIni = 1;
                  ProveFin = 99999999;

              }
              else
              {
                  ProveIni = ProveedorIni;
                  ProveFin = ProveedorFin;

              }


              using (EntitiesCXP_Rpt_Naturisa facturaProvee = new EntitiesCXP_Rpt_Naturisa())
              {
                  var select = from h in facturaProvee.vwCXP_NATU_Rpt007
                               where h.IdEmpresa == IdEmpresa
                               && h.IdProveedor >= ProveIni && h.IdProveedor <= ProveFin
                               && h.fecha_retencion >= Fecha_Ini && h.fecha_retencion <= Fecha_Fin
                               select h;

                  foreach (var item in select)
                  {
                      XCXP_NATU_Rpt007_Info itemInfo = new XCXP_NATU_Rpt007_Info();
                      itemInfo.base_retencion = item.base_retencion;
                      itemInfo.ced_proveedor = item.ced_proveedor;
                      itemInfo.co_FechaFactura = item.co_FechaFactura;
                      itemInfo.co_fechaOg = item.co_fechaOg;
                      itemInfo.co_serie = String.IsNullOrEmpty(item.co_serie) ? "" : item.co_serie.Trim();
                      itemInfo.cod_Impuesto_SRI = item.cod_Impuesto_SRI;
                      itemInfo.dir_proveedor = item.dir_proveedor;
                      itemInfo.ejercicio_fiscal = Convert.ToInt32(item.ejercicio_fiscal);
                      itemInfo.Estado = item.Estado;
                      itemInfo.fecha_retencion = item.fecha_retencion;
                      itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                      itemInfo.IdCodigo_SRI = item.IdCodigo_SRI;
                      itemInfo.IdEmpresa = item.IdEmpresa;
                      itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                      itemInfo.IdProveedor = item.IdProveedor;
                      itemInfo.IdRetencion = item.IdRetencion;
                      itemInfo.Idsecuencia = item.Idsecuencia;
                      itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                      itemInfo.Impuesto = item.Impuesto;
                      itemInfo.nom_proveedor = String.IsNullOrEmpty(item.nom_proveedor) ? "" : item.nom_proveedor.Trim();
                      itemInfo.num_factura = String.IsNullOrEmpty(item.num_factura) ? "" : item.num_factura.Trim();
                      itemInfo.por_Retencion_SRI = item.por_Retencion_SRI/100;
                      itemInfo.TipoDocumento = item.TipoDocumento;
                      itemInfo.valor_Retenido = Convert.ToDouble(item.valor_Retenido);

                      itemInfo.IdEmpresa_Ogiro = Convert.ToInt32(item.IdEmpresa_Ogiro);
                      itemInfo.serie = String.IsNullOrEmpty(item.serie)?"":item.serie.Trim();
                      itemInfo.numRetencion = String.IsNullOrEmpty(item.NumRetencion) ? "" : item.NumRetencion.Trim();
                      itemInfo.co_descripcion = item.co_descripcion;

                      itemInfo.IdCtaCble = item.IdCtaCble;


                      listadedatos.Add(itemInfo);
                  }
              }


              list_Resumen_ret = new List<XCXP_NATU_Rpt007_Resumen_Info>();

              var TdebitosxCta = from Cb in listadedatos
                                 group Cb by new { Cb.cod_Impuesto_SRI, Cb.Impuesto, Cb.por_Retencion_SRI, Cb.co_descripcion}
                                     into grouping
                                     select new { grouping.Key, total_base_ret = grouping.Sum(p => p.base_retencion), total_ret = grouping.Sum(p => p.valor_Retenido) };

              foreach (var item in TdebitosxCta)
              {
                  XCXP_NATU_Rpt007_Resumen_Info InfoR= new XCXP_NATU_Rpt007_Resumen_Info();
                  InfoR.Base_Ret = item.total_base_ret;
                  InfoR.Cod_Sri = item.Key.cod_Impuesto_SRI;
                  InfoR.descripcion =item.Key.Impuesto +"."+ item.Key.por_Retencion_SRI + " "+  item.Key.co_descripcion;
                  InfoR.Tipo_Retencion = item.Key.Impuesto;
                  InfoR.Total_Ret = item.total_ret;
                  list_Resumen_ret.Add(InfoR);
              }


              return listadedatos;
          }
          catch (Exception ex)
          {
              return new List<XCXP_NATU_Rpt007_Info>();
          }
      }
    }
}

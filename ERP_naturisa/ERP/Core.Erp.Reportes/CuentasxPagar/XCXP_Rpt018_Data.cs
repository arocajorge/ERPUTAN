using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt018_Data
    {
      public List<XCXP_Rpt018_Info> consultar_data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
      {
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

              List<XCXP_Rpt018_Info> listadedatos = new List<XCXP_Rpt018_Info>();

              using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
              {
                  var select = from h in facturaProvee.vwCXP_Rpt018
                               where h.IdEmpresa == IdEmpresa
                               && h.co_fechaOg >= FechaIni && h.co_fechaOg <= FechaFin
                               && h.IdProveedor >= ProveedorIni && h.IdProveedor <= ProveedorFin
                               select h;

                  foreach (var item in select)
                  {
                      XCXP_Rpt018_Info itemInfo = new XCXP_Rpt018_Info();
                      itemInfo.IdEmpresa = item.IdEmpresa;
                      itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                      itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                      itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;                    
                      itemInfo.IdProveedor = item.IdProveedor;
                      itemInfo.nom_proveedor = item.nom_proveedor;
                      itemInfo.co_fechaOg = item.co_fechaOg;
                      itemInfo.Documento = item.Documento;
                      itemInfo.co_FechaFactura = item.co_FechaFactura;
                      itemInfo.co_observacion = item.co_observacion;
                      itemInfo.co_subtotal_iva = item.co_subtotal_iva;
                      itemInfo.co_subtotal_siniva = item.co_subtotal_siniva;
                      itemInfo.co_baseImponible = item.co_baseImponible;
                      itemInfo.co_Por_iva = item.co_Por_iva;
                      itemInfo.co_valoriva = item.co_valoriva;
                      itemInfo.co_total = item.co_total;
                      itemInfo.co_valorpagar = item.co_valorpagar;
                      itemInfo.Estado = item.Estado;
                      itemInfo.IdSucursal = item.IdSucursal;
                      itemInfo.Num_Autorizacion = item.Num_Autorizacion;
                      itemInfo.IdRetencion = item.IdRetencion;
                      itemInfo.serie = item.serie;
                      itemInfo.NumRetencion = item.NumRetencion;
                      itemInfo.re_tipoRet = item.re_tipoRet;
                      itemInfo.re_baseRetencion = item.re_baseRetencion;
                      itemInfo.IdCodigo_SRI = item.IdCodigo_SRI;
                      itemInfo.re_Codigo_impuesto = item.re_Codigo_impuesto;
                      itemInfo.re_Porcen_retencion = item.re_Porcen_retencion;
                      itemInfo.re_valor_retencion = item.re_valor_retencion;
                      itemInfo.co_descripcion = item.co_descripcion;
                      itemInfo.IdTipoSRI = item.IdTipoSRI;
                      itemInfo.nom_sucursal = item.nom_sucursal;
                      itemInfo.nom_TipoDocumento = item.nom_TipoDocumento;
                      itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;

                      listadedatos.Add(itemInfo);
                  }
              }
              return listadedatos;

          }
          catch (Exception ex)
          {

              return new List<XCXP_Rpt018_Info>();
          }
      }
    }
}

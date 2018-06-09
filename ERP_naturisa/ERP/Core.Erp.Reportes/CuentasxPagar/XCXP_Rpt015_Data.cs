using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt015_Data
    {

      public List<XCXP_Rpt015_Info> consultar_data(int IdEmpresa_Ogiro, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, ref string mensaje)
      {

          try
          {
              List<XCXP_Rpt015_Info> listadedatos = new List<XCXP_Rpt015_Info>();

              using (EntitiesCXP_General conexion = new EntitiesCXP_General())
              {
                  var select = from h in conexion.vwCXP_Rpt015
                               where h.IdEmpresa == IdEmpresa_Ogiro
                               && h.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                               && h.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                               select h;

                  foreach (var item in select)
                  {
                      XCXP_Rpt015_Info itemInfo = new XCXP_Rpt015_Info();
                      itemInfo.base_retencion = item.base_retencion;
                      itemInfo.ced_proveedor = item.ced_proveedor;
                      itemInfo.co_FechaFactura = item.co_FechaFactura;
                      itemInfo.co_fechaOg = item.co_fechaOg;
                      itemInfo.co_serie = item.co_serie;
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
                      itemInfo.nom_proveedor = item.nom_proveedor;
                      itemInfo.num_factura = item.num_factura;
                      itemInfo.por_Retencion_SRI = item.por_Retencion_SRI;
                      itemInfo.TipoDocumento = item.TipoDocumento;
                      itemInfo.valor_Retenido = Convert.ToDouble(item.valor_Retenido);

                      itemInfo.IdEmpresa_Ogiro = Convert.ToInt32(item.IdEmpresa_Ogiro);
                      itemInfo.serie = item.serie;
                      itemInfo.numRetencion = item.NumRetencion;

                      itemInfo.fecha_ret = "";

                   
                      listadedatos.Add(itemInfo);

                  }
              }

              return listadedatos;
          }
          catch (Exception ex)
          {

              return new List<XCXP_Rpt015_Info>();
          }
      }

        
    }
}

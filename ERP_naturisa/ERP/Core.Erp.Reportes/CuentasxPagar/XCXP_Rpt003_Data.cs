using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt003_Data
    {
        public List<XCXP_Rpt003_Info> consultar_data(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble_Ogiro, ref String mensaje)
       {
           try
           {
               List<XCXP_Rpt003_Info> listadedatos = new List<XCXP_Rpt003_Info>();
               using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
               {
                   var select = from h in facturaProvee.vwCXP_Rpt003
                                where h.IdEmpresa == IdEmpresa
                                && h.IdTipoCbte_Ogiro == IdTipoCbte
                                && h.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                select h;
                    foreach (var item in select)                      
                       {
                                            
                          XCXP_Rpt003_Info itemInfo = new XCXP_Rpt003_Info();
                           itemInfo.clave_cuenta = item.clave_cuenta;

                           DateTime Fecha = Convert.ToDateTime(item.co_FechaContabilizacion);                         
                           Fecha = Convert.ToDateTime(Fecha.ToShortDateString());
                           itemInfo.co_FechaContabilizacion = Fecha;
                                           
                           itemInfo.co_FechaFactura = item.co_FechaFactura;
                           itemInfo.co_FechaFactura_vct = item.co_FechaFactura_vct;
                           itemInfo.Codigo = item.Codigo;
                           itemInfo.CodTipoCbte = item.CodTipoCbte;
                           itemInfo.dc_Observacion = item.dc_Observacion;
                           itemInfo.dc_Valor = Convert.ToDouble(item.dc_Valor);
                           itemInfo.Detalle = item.Detalle;
                           itemInfo.Fecha = item.Fecha;
                           itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                           itemInfo.IdCentroCosto = item.IdCentroCosto;
                           itemInfo.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                           itemInfo.IdCtaCble = item.IdCtaCble;
                           itemInfo.IdEmpresa = item.IdEmpresa;
                           itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                           itemInfo.IdProveedor = item.IdProveedor;
                           itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                           itemInfo.nom_comprobante = item.nom_comprobante;
                           itemInfo.nom_cuenta = item.nom_cuenta;
                           itemInfo.nom_proveedor = item.nom_proveedor;
                           itemInfo.num_comprobante = item.num_comprobante;
                           itemInfo.secuencia = Convert.ToInt32(item.secuencia);
                           itemInfo.tc_TipoCbte = item.tc_TipoCbte;

                           itemInfo.debe = item.valor_debe == 0 ? "" : Convert.ToString(item.valor_debe);
                           itemInfo.haber = item.valor_haber == 0 ? "" : Convert.ToString(item.valor_haber);
                       
                           itemInfo.em_nombre = item.em_nombre;

                           listadedatos.Add(itemInfo);
                       }
               }
               return listadedatos;
           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt003_Info>();
           }
	   }
    }
}

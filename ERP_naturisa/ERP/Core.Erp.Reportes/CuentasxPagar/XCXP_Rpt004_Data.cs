using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt004_Data
    {
        public List<XCXP_Rpt004_Info> consultar_data(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble_Ogiro, ref string mensaje)
        {
            try
            {
                List<XCXP_Rpt004_Info> listadedatos = new List<XCXP_Rpt004_Info>();
                using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
                {
                    var select = from h in facturaProvee.vwCXP_Rpt004
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdTipoCbte_Ogiro == IdTipoCbte_OG
                                 && h.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                 select h;
                    foreach (var item in select)
                    {
                        XCXP_Rpt004_Info itemInfo = new XCXP_Rpt004_Info();
                        itemInfo.clave_cuenta = item.clave_cuenta;
                        itemInfo.co_FechaFactura = item.co_FechaFactura;
                        itemInfo.Codigo = item.Codigo;
                        itemInfo.CodTipoCbte = item.CodTipoCbte;
                        itemInfo.dc_Observacion = item.dc_Observacion;
                        itemInfo.dc_Valor = Convert.ToDouble(item.dc_Valor);
                        itemInfo.Detalle = item.Detalle;
                        DateTime Fecha = Convert.ToDateTime(item.Fecha);
                        Fecha = Convert.ToDateTime(Fecha.ToShortDateString());
                        itemInfo.Fecha = Fecha;

                        itemInfo.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdRetencion = item.IdRetencion;
                        itemInfo.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        itemInfo.nom_comprobante = item.nom_comprobante;
                        itemInfo.nom_cuenta = item.nom_cuenta;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.num_comprobante = item.num_comprobante;
                        itemInfo.secuencia = Convert.ToInt32(item.secuencia);
                        itemInfo.tc_TipoCbte = item.tc_TipoCbte;

                        
                        itemInfo.debe = item.valor_debe == 0 ? "" : Convert.ToString(item.valor_debe);
                        itemInfo.haber = item.valor_haber == 0 ? "" : Convert.ToString(item.valor_haber);



                        itemInfo.Serie_Ret = item.Serie_Ret;
                        itemInfo.NumRetencion = item.NumRetencion;
                        itemInfo.Num_Auto_Reten= item.Num_Auto_Reten;
                        itemInfo.Fecha_Reten= item.Fecha_Reten;
                        itemInfo.Observacion_Reten= item.Observacion_Reten;
                        itemInfo.Tiene_RTIva= item.Tiene_RTIva;
                        itemInfo.Tiene_RTFte= item.Tiene_RTFte;
                        itemInfo.IdTipoCbte_Ret= item.IdTipoCbte_Ret;
                        itemInfo.IdCbteCble_Ret= item.IdCbteCble_Ret;
                        itemInfo.nom_TipoCbte_Ret= item.nom_TipoCbte_Ret;
                        itemInfo.IdEmpresa_Ret = item.IdEmpresa_Ret;





                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;

            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt004_Info>();
            }
	}
    }
}

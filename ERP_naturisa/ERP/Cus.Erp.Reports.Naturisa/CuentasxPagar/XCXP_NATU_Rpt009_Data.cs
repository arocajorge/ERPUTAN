using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt009_Data
    {
        public List<XCXP_NATU_Rpt009_Info> Get_Lista_Orden_Giro(int idEmpresa, decimal IdCteCble_OG, int IdTipoCbte_OG)
        {
            try
            {
                List<XCXP_NATU_Rpt009_Info> Lst_Orden_Giro = new List<XCXP_NATU_Rpt009_Info>();

                using (EntitiesCXP_Rpt_Naturisa Conexion = new EntitiesCXP_Rpt_Naturisa())
                {
                    Lst_Orden_Giro = (from q in Conexion.vwCXP_NATU_Rpt009
                                      where idEmpresa == q.IdEmpresa
                                      && IdCteCble_OG == q.IdCbteCble_Ogiro
                                      && IdTipoCbte_OG == q.IdTipoCbte_Ogiro
                                      select new XCXP_NATU_Rpt009_Info
                                      {
                                          Codigo = q.Codigo,
                                          Descripcion = q.Descripcion,
                                          IdEmpresa = q.IdEmpresa,
                                          IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                          IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                          codigoSRI = q.codigoSRI,
                                          co_descripcion = q.co_descripcion,
                                          em_nombre = q.em_nombre,
                                          Su_Descripcion = q.Su_Descripcion,
                                          pr_nombre = q.pr_nombre,
                                          nom_CentroCosto = q.nom_CentroCosto,
                                          IdIden_credito = q.IdIden_credito,
                                          IdProveedor = q.IdProveedor,
                                          nom_CentroCosto_sub_centro_costo = q.nom_CentroCosto_sub_centro_costo,
                                          co_fechaOg = q.co_fechaOg,
                                          co_serie = q.co_serie,
                                          co_factura = q.co_factura,
                                          co_FechaFactura = q.co_FechaFactura,
                                          co_FechaFactura_vct = q.co_FechaFactura_vct,
                                          co_observacion = q.co_observacion,
                                          co_subtotal_iva = q.co_subtotal_iva,
                                          co_subtotal_siniva = q.co_subtotal_siniva,
                                          co_baseImponible = q.co_baseImponible,
                                          co_total = q.co_total,
                                          co_valorpagar = q.co_valorpagar,
                                          secuencia = q.secuencia,
                                          IdCtaCble = q.IdCtaCble,
                                          pc_Cuenta = q.pc_Cuenta,
                                          idCentroCosto = q.idCentroCosto,
                                          idCentroCosto_sub_centro_costo = q.idCentroCosto_sub_centro_costo,
                                          dc_Valor = q.dc_Valor,
                                          dc_Observacion = q.dc_Observacion,
                                          IdPunto_cargo = q.IdPunto_cargo,
                                          nom_punto_cargo = q.nom_punto_cargo,
                                          IdPunto_cargo_grupo = q.IdPunto_cargo_grupo,
                                          nom_punto_cargo_grupo = q.nom_punto_cargo_grupo

                                      }).ToList();
                    foreach (var item in Lst_Orden_Giro)
                    {
                        if (item.dc_Valor > 0)
                        {
                            item.dc_Valor_D = Math.Round(item.dc_Valor, 2);
                        }
                        else
                            item.dc_Valor_H = Math.Round(item.dc_Valor, 2) * -1;

                        item.pr_nombre = "[" + item.IdProveedor.ToString() + "] " + item.pr_nombre;
                        item.Descripcion = "[" + item.Codigo.ToString() + "] " + item.Descripcion;
                        item.co_descripcion = "[" + item.codigoSRI.ToString() + "] " + item.co_descripcion;
                    }

                }
                return Lst_Orden_Giro;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt022_Data
    {
        public List<XCXP_Rpt022_Info> Get_Lista_Nota_Credito(int idEmpresa, int idTipoCbte_cxp, decimal idCbteCble_cxp)
        {
            try
            {
                List<XCXP_Rpt022_Info> Lista = new List<XCXP_Rpt022_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    Lista = (from q in Conexion.vwCXP_Rpt022
                             where idEmpresa == q.IdEmpresa
                             && idTipoCbte_cxp == q.IdTipoCbte_cxp
                             && idCbteCble_cxp == q.IdCbteCble_cxp
                             select new XCXP_Rpt022_Info
                             {
                                 IdEmpresa_cxp = q.IdEmpresa_cxp,
                                 IdTipoCbte_cxp = q.IdTipoCbte_cxp,
                                 IdCbteCble_cxp = q.IdCbteCble_cxp,
                                 IdEmpresa=q.IdEmpresa,
                                 IdCbteCble_Nota = q.IdCbteCble_Nota,
                                 IdTipoCbte_Nota = q.IdTipoCbte_Nota,
                                 DebCre = q.DebCre,
                                 IdProveedor = q.IdProveedor,
                                 IdSucursal = q.IdSucursal,
                                 cn_fecha = q.cn_fecha,
                                 cn_FechaNota = q.cn_fecha,
                                 cn_serie1 = q.cn_serie1,
                                 cn_serie2 = q.cn_serie2,
                                 cn_Nota = q.cn_Nota,
                                 cn_observacion = q.cn_observacion,
                                 secuencia = q.secuencia,
                                 IdCtaCble = q.IdCtaCble,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 dc_Valor = q.dc_Valor,
                                 dc_Observacion = q.dc_Observacion,
                                 nom_Centro_costo = q.nom_Centro_costo,
                                 nom_sucCentro_costo = q.nom_sucCentro_costo,
                                 IdTipoNota = q.IdTipoNota,
                                 nom_cuenta = q.nom_cuenta,
                                 cn_subtotal_iva = q.cn_subtotal_iva,
                                 cn_subtotal_siniva = q.cn_subtotal_siniva,
                                 cn_baseImponible = q.cn_baseImponible,
                                 cn_total = q.cn_total

                             }).ToList();
                }

                foreach (var item in Lista)
                {
                    item.dc_Observacion =item.cn_serie1+"-"+item.cn_serie2+"-"+item.cn_Nota+" "+ item.dc_Observacion ;

                    if (item.dc_Valor > 0)
                    {
                        item.dc_Valor_Debe = item.dc_Valor;
                    }else
                        item.dc_Valor_Haber = (item.dc_Valor)*-1;
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

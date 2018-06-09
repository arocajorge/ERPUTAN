using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt024_Data
    {
        public List<XCXP_Rpt024_Info> Get_Lista_Sub_Reporte(int idEmpresa,int IdTipoCbte_Ogiro, decimal idOrdenGiro)
        {
            try
            {
                List<XCXP_Rpt024_Info> Lista = new List<XCXP_Rpt024_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    Lista = (from q in Conexion.vwCXP_Rpt024
                             where idEmpresa == q.IdEmpresa
                             && idOrdenGiro == q.IdCbteCble_Ogiro
                             && q.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                             select new XCXP_Rpt024_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdRetencion = q.IdRetencion,
                                 serie = q.serie,
                                 NumRetencion = q.NumRetencion,
                                 NAutorizacion = q.NAutorizacion,
                                 fecha = q.fecha,
                                 observacion = q.observacion,
                                 IdEmpresa_Ogiro = q.IdEmpresa_Ogiro,
                                 IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                 Idsecuencia = q.Idsecuencia,
                                 re_tipoRet = q.re_tipoRet,
                                 re_baseRetencion = q.re_baseRetencion,
                                 IdCodigo_SRI = q.IdCodigo_SRI,
                                 re_Codigo_impuesto = q.re_Codigo_impuesto,
                                 re_Porcen_retencion = (q.re_Porcen_retencion/100),
                                 re_valor_retencion = q.re_valor_retencion
                             }).ToList();
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

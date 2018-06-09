using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt023_Data
    {
        public List<XCXP_Rpt023_Info> Get_Lista_Comprobante_Retencion(int idEmpresa, decimal IdCbteCble_Ogiro)
        {
            try
            {
                List<XCXP_Rpt023_Info> Lista = new List<XCXP_Rpt023_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    Lista = (from q in Conexion.vwCXP_Rpt023
                             where idEmpresa == q.IdEmpresa
                             && IdCbteCble_Ogiro == q.IdCbteCble_Ogiro
                             select new XCXP_Rpt023_Info
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
                                 IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                 Idsecuencia = q.Idsecuencia,
                                 re_tipoRet = q.re_tipoRet,
                                 re_baseRetencion = q.re_baseRetencion,
                                 IdCodigo_SRI = q.IdCodigo_SRI,
                                 re_Codigo_impuesto = q.re_Codigo_impuesto,
                                 re_Porcen_retencion = q.re_Porcen_retencion,
                                 re_valor_retencion = q.re_valor_retencion,
                                 IdProveedor = q.IdProveedor,
                                 pe_apellido = q.pe_apellido,
                                 pe_nombre = q.pe_nombre,
                                 IdTipoDocumento = q.IdTipoDocumento,
                                 pe_cedulaRuc = q.pe_cedulaRuc,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 pe_direccion = q.pe_direccion,
                                 CodTipoDocumento = q.CodTipoDocumento,
                                 Descripcion = q.Descripcion,
                                 co_factura = q.co_factura,
                                 co_serie = q.co_serie,
                                 Num_Autorizacion = q.Num_Autorizacion,
                             }).ToList();
                }

                foreach (var item in Lista)
                {
                    item.num_Comprobante = "S. "+item.serie + item.NumRetencion;
                    item.num_Comprobante_venta = item.co_serie + item.co_factura;
                    item.re_Porcen_retencion =  item.re_Porcen_retencion /100;
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

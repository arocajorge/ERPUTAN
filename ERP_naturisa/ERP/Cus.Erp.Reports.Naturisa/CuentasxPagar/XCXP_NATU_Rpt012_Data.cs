using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt012_Data
    {
        public List<XCXP_NATU_Rpt012_Info> Get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_agrupado)
        {
            try
            {
                List<XCXP_NATU_Rpt012_Info> Lista = new List<XCXP_NATU_Rpt012_Info>();
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                using (EntitiesCXP_Rpt_Naturisa Context = new EntitiesCXP_Rpt_Naturisa())
                {
                    var lst = from q in Context.spCXP_NATU_Rpt012(IdEmpresa,Fecha_ini,Fecha_fin,Mostrar_agrupado)
                              select q;

                    foreach (var item in lst)
                    {
                        XCXP_NATU_Rpt012_Info info = new XCXP_NATU_Rpt012_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info.Codigo = item.Codigo;
                        info.Descripcion = item.Descripcion;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_nombre = item.pr_nombre;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.serie_fact = item.serie_fact;
                        info.num_factura = item.num_factura;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.subtotal_iva = item.subtotal_iva;
                        info.subtotal_sin_iva = item.subtotal_sin_iva;
                        info.valor_iva = item.valor_iva;
                        info.NAutorizacion = item.NAutorizacion;
                        info.serie_ret = item.serie_ret;
                        info.NumRetencion = item.NumRetencion;
                        info.re_baseRetencion = item.re_baseRetencion;
                        info.re_Porcen_retencion = item.re_Porcen_retencion;
                        info.re_valor_retencion = item.re_valor_retencion;
                        info.re_Codigo_impuesto = item.re_Codigo_impuesto;
                        info.RIVA_0 = item.RIVA_0;
                        info.RIVA_10 = item.RIVA_10;
                        info.RIVA_20 = item.RIVA_20;
                        info.RIVA_30 = item.RIVA_30;
                        info.RIVA_70 = item.RIVA_70;
                        info.RIVA_100 = item.RIVA_100;
                        info.RTF_0 = item.RTF_0;
                        info.RTF_0_1 = item.RTF_0_1;
                        info.RTF_1 = item.RTF_1;
                        info.RTF_2 = item.RTF_2;
                        info.RTF_8 = item.RTF_8;
                        info.RTF_10 = item.RTF_10;
                        info.RTF_100 = item.RTF_100;
                        info.Documento = item.Documento;
                        info.descripcion_cod_sri = item.descripcion_cod_sri;
                        info.re_tipoRet = item.re_tipoRet;
                        info.Num_Autorizacion_OG = item.Num_Autorizacion_OG;

                        Lista.Add(info);
                    }
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

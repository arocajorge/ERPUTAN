using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt008_Data
    {
        public List<XCXP_Rpt008_Info> Get_list(int IdEmpresa, int IdClase_prov, decimal IdProveedor,  DateTime Fecha_fin, bool Mostrar_anuladas, bool Mostrar_saldo_0)
        {
            try
            {
                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 99999 : IdProveedor;

                int IdClase_ini = IdClase_prov;
                int IdClase_fin = IdClase_prov == 0 ? 9999 : IdClase_prov;
                
                Fecha_fin = Fecha_fin.Date;

                List<XCXP_Rpt008_Info> Lista = new List<XCXP_Rpt008_Info>();

                using (EntitiesCXP_General Context = new EntitiesCXP_General())
                {
                    IEnumerable<spCXP_Rpt008_Result> lst;

                    if (Mostrar_anuladas && Mostrar_saldo_0)
                    {
                        lst = from q in Context.spCXP_Rpt008(IdEmpresa, IdClase_ini, IdClase_fin, IdProveedor_ini, IdProveedor_fin, Fecha_fin)                              
                              select q;
                    }else
                        if (!Mostrar_anuladas && Mostrar_saldo_0)
                        {
                            lst = from q in Context.spCXP_Rpt008(IdEmpresa,IdClase_ini,IdClase_fin,IdProveedor_ini,IdProveedor_fin,Fecha_fin)
                                  where q.Estado == "A" 
                                  select q;
                                  
                        }else
                            if (!Mostrar_anuladas && !Mostrar_saldo_0)
                            {
                                lst = from q in Context.spCXP_Rpt008(IdEmpresa, IdClase_ini, IdClase_fin, IdProveedor_ini, IdProveedor_fin, Fecha_fin)
                                      where q.Total != 0
                                      && q.Estado == "A"
                                      select q;
                            }else
                                {
                                    lst = from q in Context.spCXP_Rpt008(IdEmpresa, IdClase_ini, IdClase_fin, IdProveedor_ini, IdProveedor_fin, Fecha_fin)
                                          where q.Total != 0
                                          select q;
                                }
                     

                    foreach (var item in lst)
                    {
                        XCXP_Rpt008_Info info = new XCXP_Rpt008_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_factura = item.co_factura;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_nombre = item.pr_nombre;
                        info.IdClaseProveedor = item.IdClaseProveedor;
                        info.cod_clase_proveedor = item.cod_clase_proveedor;
                        info.descripcion_clas_prove = item.descripcion_clas_prove;
                        info.valor_fa = item.valor_fa;
                        info.valor_nc = item.valor_nc;
                        info.valor_ba = item.valor_ba;
                        info.valor_ret = item.valor_ret;
                        info.Total = item.Total;
                        info.Estado = item.Estado;
                        info.Documento = item.Documento;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}

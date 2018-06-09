using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt013_Data
    {
        public List<XCXP_NATU_Rpt013_Info> Get_list(int IdEmpresa, int IdClaseProveedor, decimal IdProveedor, DateTime Fecha_ini, DateTime Fecha_fin, bool mostrar_cuenta)
        {
            try
            {
                List<XCXP_NATU_Rpt013_Info> Lista = new List<XCXP_NATU_Rpt013_Info>();
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                int IdClaseProveedor_ini = IdClaseProveedor;
                int IdClaseProveedor_fin = IdClaseProveedor == 0 ? 9999 : IdClaseProveedor;

                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 99999 : IdProveedor;

                using (EntitiesCXP_Rpt_Naturisa Context = new EntitiesCXP_Rpt_Naturisa())
                {
                    Context.SetCommandTimeOut(3000);

                    var lst = from q in Context.spCXP_NATU_Rpt013(IdEmpresa, IdClaseProveedor_ini, IdClaseProveedor_fin, IdProveedor_ini, IdProveedor_fin, Fecha_ini, Fecha_fin)
                              select q;

                    foreach (var item in lst)
                    {
                        XCXP_NATU_Rpt013_Info info = new XCXP_NATU_Rpt013_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbte = item.IdTipoCbte;
                        info.IdCbteCble = item.IdCbteCble;
                        info.secuencia = item.secuencia;
                        info.IdCtaCble = item.IdCtaCble;
                        info.pc_Cuenta = item.pc_Cuenta;
                        info.cb_Fecha = item.cb_Fecha;
                        //Muestra la cuenta en la línea de la observación
                        if (mostrar_cuenta)
                            info.co_observacion = item.IdCtaCble == null ? "" : ("["+item.IdCtaCble+"] "+item.pc_Cuenta);
                        else
                            info.co_observacion = item.co_observacion;

                        info.IdClaseProveedor = item.IdClaseProveedor;
                        info.descripcion_clas_prove = item.descripcion_clas_prove;
                        info.IdProveedor = item.IdProveedor;
                        info.pr_nombre = item.pr_nombre;
                        info.IdCtaCble_CXP_clase = item.IdCtaCble_CXP_clase;
                        info.IdCtaCble_CXP_provee = item.IdCtaCble_CXP_provee;
                        info.CodTipoCbte = item.CodTipoCbte;
                        info.tc_TipoCbte = item.tc_TipoCbte;
                        info.pr_codigo = item.pr_codigo;
                        info.Saldo_inicial = item.Saldo_inicial;
                        info.Debe = item.Debe;
                        info.Haber = item.Haber;
                        info.dc_Valor = item.dc_Valor;
                        info.Saldo = item.Saldo;
                        info.referencia = item.referencia;
                        info.Secuencia_rpt = item.Secuencia_rpt;
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


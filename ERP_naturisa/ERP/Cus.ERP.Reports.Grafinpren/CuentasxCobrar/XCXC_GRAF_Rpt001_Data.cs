using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt001_Data
    {
        public List<XCXC_GRAF_Rpt001_Info> Get_list_x_empresa(int IdEmpresa, int IdVendedor, DateTime Fecha_ini, DateTime Fecha_fin, List<string> lst_TipoCobro)
        {
            try
            {
                int IdVendedorIni, IdVendedorFin;

                IdVendedorIni = (IdVendedor == 0) ? 0 : IdVendedor;
                IdVendedorFin = (IdVendedor == 0) ? 999999999 : IdVendedor;
                List<XCXC_GRAF_Rpt001_Info> Lista = new List<XCXC_GRAF_Rpt001_Info>();

                using (EntitiesCuentasxCobrar_GRAF_Rpt Context = new EntitiesCuentasxCobrar_GRAF_Rpt())
                {
                    var lst = from q in Context.vwCXC_GRAF_Rpt001
                              where q.IdEmpresa_cbr == IdEmpresa 
                              && q.IdVendedor >= IdVendedorIni
                              && q.IdVendedor <= IdVendedorFin
                              && Fecha_ini <= q.cr_fechaCobro 
                              && q.cr_fechaCobro <= Fecha_fin
                              && lst_TipoCobro.Contains(q.IdCobro_tipo)
                              select q;

                    foreach (var item in lst)
                    {
                        XCXC_GRAF_Rpt001_Info info = new XCXC_GRAF_Rpt001_Info();
                        info.IdEmpresa_cbr = item.IdEmpresa_cbr;
                        info.IdSucursal_cbr = item.IdSucursal_cbr;
                        info.IdCobro_cbr = item.IdCobro_cbr;
                        info.Secuencial_cbr = item.Secuencial_cbr;
                        info.porc_comision = item.porc_comision == null ? 0 : (double)item.porc_comision;
                        info.Porc_pagado = item.Porc_pagado == null ? 0 : (double)item.Porc_pagado;
                        info.Valor_pagado = item.Valor_pagado == null ? 0 : (double)item.Valor_pagado;
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.cr_fechaCobro = item.cr_fechaCobro;
                        info.Pago = item.Pago;
                        info.IdEmpresa_fact = item.IdEmpresa_fact;
                        info.IdSucursal_fact = item.IdSucursal_fact;
                        info.IdBodega_fact = item.IdBodega_fact;
                        info.IdCbteVta_fact = item.IdCbteVta_fact;
                        info.IdVendedor = item.IdVendedor;
                        info.Ve_Vendedor = item.Ve_Vendedor;
                        info.fecha_fact = item.fecha_fact;
                        info.fecha_vcto_fact = item.fecha_vcto_fact;
                        info.nom_Cliente = item.nom_Cliente;
                        info.Fa_total = item.Fa_total;
                        info.Dias_atraso = item.Dias_atraso;
                        info.Base_com = item.Base_com;
                        info.IdCliente = item.IdCliente;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.Dias_Vct = item.Dias_Vct;
                        info.com_negociada = item.com_negociada;
                        info.Esta_en_base = item.Esta_en_base == null ? false : (bool)item.Esta_en_base;
                        info.num_op = item.num_op;
                        info.num_cotizacion = item.num_cotizacion;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}

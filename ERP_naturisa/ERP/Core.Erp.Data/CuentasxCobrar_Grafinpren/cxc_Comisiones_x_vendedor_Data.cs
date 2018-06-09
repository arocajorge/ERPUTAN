using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxCobrar_Grafinpren;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxCobrar_Grafinpren
{
    public class cxc_Comisiones_x_vendedor_Data
    {
        public List<cxc_Comisiones_x_vendedor_Info> Get_list_x_empresa(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, List<string> lst_TipoCobro, int IdVendedor)
        {
            try
            {
                int IdVendedor_ini = IdVendedor;
                int IdVendedor_fin = IdVendedor == 0 ? 9999 : IdVendedor;
                List<cxc_Comisiones_x_vendedor_Info> Lista = new List<cxc_Comisiones_x_vendedor_Info>();

                using (EntitiesCuentas_x_Cobrar_Grafinpren Context = new EntitiesCuentas_x_Cobrar_Grafinpren())
                {
                    var lst = from q in Context.vwcxc_Comisiones_x_vendedor
                              where q.IdEmpresa_cbr == IdEmpresa &&
                              Fecha_ini <= q.cr_fechaCobro && q.cr_fechaCobro <= Fecha_fin
                              && lst_TipoCobro.Contains(q.IdCobro_tipo)
                              && IdVendedor_ini <= q.IdVendedor 
                              && q.IdVendedor <= IdVendedor_fin 
                              select q;

                    foreach (var item in lst)
                    {
                        cxc_Comisiones_x_vendedor_Info info = new cxc_Comisiones_x_vendedor_Info();
                        info.IdEmpresa = item.IdEmpresa_cbr;
                        info.IdSucursal = item.IdSucursal_cbr;
                        info.IdCobro = item.IdCobro_cbr;
                        info.Secuencia = item.Secuencial_cbr;
                        info.Porc_pactado = item.porc_comision == null ? 0 : (double)item.porc_comision;
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
                        info.Fa_total = item.Fa_total == null ? 0 : (double)item.Fa_total;
                        info.Dias_atraso = item.Dias_atraso;
                        info.Base_com = item.Base_com;
                        info.IdCliente = item.IdCliente;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.Dias_Vct = item.Dias_Vct;
                        info.Esta_en_base = item.Esta_en_base == null ? false : (bool)item.Esta_en_base;
                        info.com_negociada = item.com_negociada == null ? 0 : (double)item.com_negociada;
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

        public bool GuardarDB(cxc_Comisiones_x_vendedor_Info info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar_Grafinpren context = new EntitiesCuentas_x_Cobrar_Grafinpren())
                {
                    cxc_Comisiones_x_vendedor Entity = new cxc_Comisiones_x_vendedor();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdCobro = info.IdCobro;
                    Entity.Secuencia = info.Secuencia;
                    Entity.Porc_pagado = info.Porc_pagado;
                    Entity.Valor_pagado = info.Valor_pagado;                    
                    context.cxc_Comisiones_x_vendedor.Add(Entity);
                    context.SaveChanges();
                }
                return true;
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

        public bool ModificarDB(cxc_Comisiones_x_vendedor_Info info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar_Grafinpren context = new EntitiesCuentas_x_Cobrar_Grafinpren())
                {
                    cxc_Comisiones_x_vendedor Entity = context.cxc_Comisiones_x_vendedor.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdCobro == info.IdCobro && q.Secuencia == info.Secuencia);
                    if (Entity!=null)
                    {
                        Entity.Porc_pagado = info.Porc_pagado;
                        Entity.Valor_pagado = info.Valor_pagado;
                        context.SaveChanges();    
                    }
                }
                return true;
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

        public bool GuardarDB(List<cxc_Comisiones_x_vendedor_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    if (item.Esta_en_base)
                    { ModificarDB(item); }
                    else { GuardarDB(item); }
                }
                return true;
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

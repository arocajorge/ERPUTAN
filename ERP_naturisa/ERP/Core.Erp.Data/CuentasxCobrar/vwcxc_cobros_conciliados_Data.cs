using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxCobrar
{
    public class vwcxc_cobros_conciliados_Data
    {

        public List<vwcxc_cobros_conciliados_Info> Get_List_cobros_conciliados(int IdEmpresa, int IdSucursal, decimal IdConciliacion, string tipoConciliacion, ref string mensaje)
        {
            try
            {
                List<vwcxc_cobros_conciliados_Info> lstCobroConciliado = new List<vwcxc_cobros_conciliados_Info>();
                EntitiesCuentas_x_Cobrar CXC = new EntitiesCuentas_x_Cobrar();

                var lista = from q in CXC.vwcxc_cobros_conciliados
                            where q.IdEmpresa == IdEmpresa  && q.IdSucursal == IdSucursal
                            && q.IdConciliacion == IdConciliacion   && q.IdTipoConciliacion == tipoConciliacion                                 
                            select q;

                foreach (var item in lista)
                {
                    vwcxc_cobros_conciliados_Info info = new vwcxc_cobros_conciliados_Info();

                    info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    info.IdSucursal = Convert.ToInt32(item.IdSucursal);
                    info.IdBodega = Convert.ToInt32(item.IdBodega);
                    info.IdConciliacion = item.IdConciliacion;
                    info.Tipo = item.Tipo;
                    info.IdNota = Convert.ToDecimal(item.IdNota);
                    info.CreDeb = item.CreDeb;
                    info.Serie1 = item.Serie1;
                    info.Serie2 = item.Serie2;
                    info.NumNota_Impresa = item.NumNota_Impresa;
                    info.IdCliente = Convert.ToDecimal(item.IdCliente);
                    info.NomSucursal = item.NomSucursal;
                    info.Nom_Bodega = item.Nom_Bodega;
                    info.no_fecha = Convert.ToDateTime(item.no_fecha);
                    info.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                    info.sc_observacion = item.sc_observacion;
                    info.Nom_Cliente = item.Nom_Cliente;
                    info.Motivo_Nota = item.Motivo_Nota;
                    info.Referencia = item.Referencia;
                    info.sc_total = Convert.ToDouble(item.sc_total);
                    info.Saldo = Convert.ToDouble(item.Saldo);
                    info.saldoAUX_CreDeb = Convert.ToDouble(item.Saldo);
                    info.IdTipoConciliacion = item.IdTipoConciliacion;
                    info.IdCobro = Convert.ToDecimal(item.IdCobro);
                    info.IdCobro_Tipo = item.IdCobro_Tipo;
                    info.IdTipoNota = Convert.ToInt32(item.IdTipoNota);
                    info.IdCaja = Convert.ToInt32(item.IdCaja);
                    info.NombreCompleto = "[" + item.IdCliente + "] -" + "[" + item.Nom_Cliente + "]";
                    lstCobroConciliado.Add(info);
                }

                return lstCobroConciliado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}

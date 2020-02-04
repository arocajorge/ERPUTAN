using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt002_Data
    {
        public List<XCXC_GRAF_Rpt002_Info> Get_list_reporte(int IdEmpresa, decimal IdCliente, decimal IdVendedor, DateTime FechaCorte, bool Mostrar_solo_vencidas)
        {
            try
            {
                decimal IdClienteIni = IdCliente;
                decimal IdClienteFin = IdCliente == 0 ? 99999 : IdCliente;

                decimal IdVendedorIni = IdVendedor;
                decimal IdVendedorFin = IdVendedor == 0 ? 99999 : IdVendedor;

                List<XCXC_GRAF_Rpt002_Info> Lista = new List<XCXC_GRAF_Rpt002_Info>();

                using (EntitiesCuentasxCobrar_GRAF_Rpt Context = new EntitiesCuentasxCobrar_GRAF_Rpt())
                {
                    var lst = from q in Context.spCXC_GRAF_Rpt002(IdEmpresa, IdClienteIni, IdClienteFin, IdVendedorIni, IdVendedorFin, FechaCorte)
                              select q;

                    if (Mostrar_solo_vencidas)
                    {
                        lst = lst.Where(q => q.Dias_vcdos > 0);
                    }

                    foreach (var item in lst)
                    {
                        XCXC_GRAF_Rpt002_Info info = new XCXC_GRAF_Rpt002_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.vt_Subtotal = item.vt_Subtotal;
                        info.vt_iva = item.vt_iva;
                        info.vt_total = item.vt_total;
                        info.vt_por_iva = item.vt_por_iva;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.dc_ValorPago = item.dc_ValorPago;
                        info.Saldo = item.Saldo;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fech_venc = item.vt_fech_venc;
                        info.Ve_Vendedor = item.Ve_Vendedor;
                        info.IdVendedor = item.IdVendedor;
                        info.CodCbteVta = item.CodCbteVta;
                        info.Dias_vcdos = item.Dias_vcdos;
                        info.pe_telefonoOfic = item.pe_telefonoOfic;
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

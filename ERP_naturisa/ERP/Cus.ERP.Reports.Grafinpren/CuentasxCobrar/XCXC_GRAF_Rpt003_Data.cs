using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt003_Data
    {
        public List<XCXC_GRAF_Rpt003_Info> Get_list_reporte(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<XCXC_GRAF_Rpt003_Info> Lista = new List<XCXC_GRAF_Rpt003_Info>();

                using (EntitiesCuentasxCobrar_GRAF_Rpt Context = new EntitiesCuentasxCobrar_GRAF_Rpt())
                {
                    var lst = from q in Context.vwCXC_GRAF_Rpt003
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCliente == IdCliente
                              select q;

                    foreach (var item in lst)
                    {
                        XCXC_GRAF_Rpt003_Info info = new XCXC_GRAF_Rpt003_Info();
                        info.IdRow = item.IdRow;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.CodCbteVta = item.CodCbteVta;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.vt_total = item.vt_total;
                        info.dc_ValorPago = item.dc_ValorPago;
                        info.Saldo = item.Saldo;
                        info.vt_fecha = item.vt_fecha;
                        info.vt_fech_venc = item.vt_fech_venc;
                        info.Dias_en_credito = item.Dias_en_credito;
                        info.Dias_vencido = item.Dias_vencido;
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

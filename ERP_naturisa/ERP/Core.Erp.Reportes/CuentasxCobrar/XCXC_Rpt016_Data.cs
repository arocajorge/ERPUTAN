using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.CuentasxCobrar
{
   public class XCXC_Rpt016_Data
    {

        string mensaje = "";

        public List<XCXC_Rpt016_Info> Get_Data_Reporte(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota, string CodDocumentoTipo)
        {
            try
            {

                List<XCXC_Rpt016_Info> lstRpt = new List<XCXC_Rpt016_Info>();
                
                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.vwCXC_Rpt016
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal==IdSucursal
                                 && q.IdBodega_Cbte==IdBodega_Cbte
                                 && q.IdCbte_vta_nota==IdCbte_vta_nota
                                 && q.CodDocumentoTipo == CodDocumentoTipo
                                 select q;

                    foreach (var item in select)
                    {
                        XCXC_Rpt016_Info Info = new XCXC_Rpt016_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdCobro = item.IdCobro;
                        Info.secuencial = item.secuencial;
                        Info.IdBodega_Cbte = item.IdBodega_Cbte;
                        Info.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        Info.IdCobro_tipo = item.IdCobro_tipo;
                        Info.CodDocumentoTipo = item.CodDocumentoTipo;
                        Info.Serie1 = item.Serie1;
                        Info.Serie2 = item.Serie2;
                        Info.NumNota_Impresa = item.NumNota_Impresa;
                        Info.IdCliente = item.IdCliente;
                        Info.nom_cliente = item.nom_cliente;
                        Info.sc_observacion = item.sc_observacion;
                        Info.cr_fecha = item.cr_fecha;
                        Info.tc_descripcion = item.tc_descripcion;
                        Info.PorcentajeRet = item.PorcentajeRet;
                        Info.dc_ValorPago = item.dc_ValorPago;
                        Info.cr_NumDocumento = item.cr_NumDocumento;
                        Info.Base = item.Base;
                        Info.num_documento = item.num_documento;

                        Info.sc_subtotal = item.sc_subtotal;
                        Info.sc_iva = item.sc_iva;
                        Info.sc_total = item.sc_total;

                        lstRpt.Add(Info);
                    }
                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt016_Info>();
            }
        }
    }
}

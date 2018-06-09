using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt005_Data
    {

        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt005_Info> getDatosRpt_NDC_NDB_Producto(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago, string IdTipoDoc, int IdTipoNotaIni, int IdTipoNotaFin)
        {
            try
            {
                List<XFAC_Rpt005_Info> lstReport = new List<XFAC_Rpt005_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {

                    var select = from q in ListadoDocu.vwFAC_Rpt005
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.no_fecha >= FechaIni && q.no_fecha <= FechaHasta
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && q.IdTipoDocumento == IdTipoDoc
                                 && q.IdTipoNota >= IdTipoNotaIni && q.IdTipoNota <= IdTipoNotaFin
                                 select q;

                    if (TipoPago == "PENDI")
                    {
                        select = select.Where(q => q.Saldo > 0);
                    }
                    else
                    {
                        if (TipoPago == "PAGAD")
                        {
                            select = select.Where(q => q.Saldo <= 0);
                        }
                    }

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {

                        XFAC_Rpt005_Info itemInfo = new XFAC_Rpt005_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = Convert.ToInt32(item.IdBodega);
                        itemInfo.IdTipoDocumento = item.IdTipoDocumento;
                        itemInfo.numDocumento = item.numDocumento;
                        itemInfo.Referencia = item.Referencia;
                        itemInfo.IdComprobante = item.IdComprobante;
                        itemInfo.CodComprobante = item.CodComprobante;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.nombreCliente = item.nombreCliente;
                        itemInfo.no_fecha = item.no_fecha;
                        itemInfo.vt_total = Convert.ToDouble(item.vt_total);
                        itemInfo.Saldo = Convert.ToDouble(item.Saldo);
                        itemInfo.TotalCobrado = Convert.ToDouble(item.TotalCobrado);
                        itemInfo.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                        itemInfo.vt_iva = Convert.ToDouble(item.vt_iva);
                        itemInfo.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.nombreProducto = item.nombreProducto;
                        itemInfo.Logo = Cbt.em_logo_Image;
                        itemInfo.sc_cantidad = Convert.ToDouble(item.sc_cantidad);
                        itemInfo.sc_precioFinal = Convert.ToDouble(item.sc_precioFinal);
                        itemInfo.CodTipoNota = item.CodTipoNota;
                        itemInfo.IdTipoNota = item.IdTipoNota;
                        itemInfo.Plazo = Convert.ToInt32(item.Plazo);
                        itemInfo.IdUsuario = item.IdUsuario;
                        lstReport.Add(itemInfo);

                    }
                }
                return lstReport;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XFAC_Rpt005_Info>();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt004_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt004_Info> getDatosRpt_NDC_NDB(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago, string IdTipoDoc, List<int> IdTipoNota, string TipoNota)
        {
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());

                #region Optengo el resumen

                List<XFAC_Rpt004_Info> lstDetalle = new List<XFAC_Rpt004_Info>();

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {
                    var select_detalle = from q in ListadoDocu.vwFAC_Rpt004_Detalle
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.no_fecha >= FechaIni && q.no_fecha <= FechaHasta
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && q.IdTipoDocumento == IdTipoDoc
                                 && IdTipoNota.Contains(q.IdTipoNota)
                                 && q.NaturalezaNota.Contains(TipoNota)

                                 select q;

                    if (TipoPago == "PENDI")
                    {
                        select_detalle = select_detalle.Where(q => q.Saldo > 0);
                    }
                    else
                    {
                        if (TipoPago == "PAGAD")
                        {
                            select_detalle = select_detalle.Where(q => q.Saldo <= 0);
                        }
                    }

                    foreach (var item_detalle in select_detalle)
                    {

                        XFAC_Rpt004_Info itemInfo_detalle = new XFAC_Rpt004_Info();

                        itemInfo_detalle.IdEmpresa = item_detalle.IdEmpresa;
                        itemInfo_detalle.IdSucursal = item_detalle.IdSucursal;
                        itemInfo_detalle.IdTipoDocumento = item_detalle.IdTipoDocumento;
                        itemInfo_detalle.IdComprobante = item_detalle.IdNota.ToString();
                        itemInfo_detalle.IdCliente = item_detalle.IdCliente;
                        itemInfo_detalle.no_fecha = item_detalle.no_fecha;
                        itemInfo_detalle.SubTotal = item_detalle.sc_subtotal;
                        itemInfo_detalle.vt_iva = item_detalle.sc_iva;
                        itemInfo_detalle.total = item_detalle.sc_total;
                        itemInfo_detalle.vt_total = item_detalle.sc_total;
                        itemInfo_detalle.IdCod_Impuesto_Iva = item_detalle.IdCod_Impuesto_Iva;

                        itemInfo_detalle.Saldo = item_detalle.Saldo;
                        itemInfo_detalle.TotalCobrado = item_detalle.TotalCobrado;

                        itemInfo_detalle.IdTipoNota = item_detalle.IdTipoNota;


                        itemInfo_detalle.NaturalezaNota = item_detalle.NaturalezaNota;
                        lstDetalle.Add(itemInfo_detalle);
                    }
                }

                //agrupando para encontrar el resumen



                //var TdebitosxCta = from Cb in lmcbi
                //                   where Cb._cbteCble_det_info.dc_Valor > 0
                //                   orderby Cb._cbteCble_det_info.IdCtaCble
                //                   group Cb by new { Cb.IdEmpresa, Cb._cbteCble_det_info.IdCtaCble }
                //                       into grouping
                //                       select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p._cbteCble_det_info.dc_Valor) };


                var Resume_x_NC = from G in lstDetalle
                                  group G by new { G.IdCod_Impuesto_Iva }
                                      into grouping
                                      select new { grouping.Key, SubTotal = grouping.Sum(p => p.SubTotal),Iva=grouping.Sum(p=>p.vt_iva),Total=grouping.Sum(p=>p.total)};

                List<XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info> listResumen_x_NC = new List<XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info>();


                foreach (var item_res_x_NC in Resume_x_NC)
                {
                    XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info Info_res_x_NC= new XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info();

                    Info_res_x_NC.Detalle = "Totales Notas x ";
                    Info_res_x_NC.sc_subtotal = item_res_x_NC.SubTotal;
                    Info_res_x_NC.sc_iva = (item_res_x_NC.Iva==null)?0:Convert.ToDouble(item_res_x_NC.Iva);
                    Info_res_x_NC.sc_total = (item_res_x_NC.Total==null)?0:Convert.ToDouble(item_res_x_NC.Total);
                    Info_res_x_NC.IdCod_Impuesto_Iva = item_res_x_NC.Key.IdCod_Impuesto_Iva;
                    listResumen_x_NC.Add(Info_res_x_NC);
                }

                #endregion


                List<XFAC_Rpt004_Info> lstReport = new List<XFAC_Rpt004_Info>();

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {
                    var select = from q in ListadoDocu.vwFAC_Rpt004
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.no_fecha >= FechaIni && q.no_fecha <= FechaHasta
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && q.IdTipoDocumento == IdTipoDoc
                                 && IdTipoNota.Contains(q.IdTipoNota)
                                 && q.NaturalezaNota.Contains(TipoNota)
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
                        XFAC_Rpt004_Info itemInfo = new XFAC_Rpt004_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdTipoDocumento = item.IdTipoDocumento;
                        itemInfo.numDocumento = item.numDocumento;
                        itemInfo.Referencia = item.Referencia;
                        itemInfo.IdComprobante = item.IdComprobante;
                        itemInfo.CodComprobante = item.CodComprobante;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.nombreCliente = item.nombreCliente;
                        itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        itemInfo.no_fecha = item.no_fecha;
                        itemInfo.vt_total = item.vt_total;
                        itemInfo.Saldo = item.Saldo;
                        itemInfo.TotalCobrado = item.TotalCobrado;
                        itemInfo.SubTotal_0 = item.SubTotal_0;
                        itemInfo.SubTotal_Iva = item.SubTotal_Iva;
                        itemInfo.vt_iva = item.vt_iva;
                        itemInfo.total = item.total;
                        itemInfo.no_fecha_venc = item.no_fecha_venc;
                        itemInfo.IdTipoNota = item.IdTipoNota;
                        itemInfo.CodTipoNota = item.CodTipoNota;
                        itemInfo.No_Descripcion = item.No_Descripcion;
                        itemInfo.Plazo = item.Plazo;
                        itemInfo.IdUsuario = item.IdUsuario;
                        itemInfo.em_nombre = item.em_nombre;
                        itemInfo.NaturalezaNota = item.NaturalezaNota;

                        itemInfo.list_resumen_x_Subtotal = listResumen_x_NC;




                        


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
                return new List<XFAC_Rpt004_Info>();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt002_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt002_Info> getDatosReporteVentas(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago)
        {
            try
            {
                List<XFAC_Rpt002_Info> lstReport = new List<XFAC_Rpt002_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());
                
                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {

                    var select = from q in ListadoDocu.vwFAC_Rpt002
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaHasta
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 select q;

                    if (TipoPago == "PENDI")
                    {
                        select = select.Where(q => q.Saldo > 0);
                    }
                    else {
                         if (TipoPago == "PAGAD")
                         {
                             select = select.Where(q => q.Saldo <= 0);
                         }
                    }                    

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {

                        XFAC_Rpt002_Info itemInfo = new XFAC_Rpt002_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = Convert.ToInt32(item.IdBodega);
                        itemInfo.vt_tipoDoc = item.vt_tipoDoc;
                        itemInfo.vt_NunDocumento = item.vt_NunDocumento;
                        itemInfo.Referencia = item.Referencia;
                        itemInfo.IdComprobante = item.IdComprobante;
                        itemInfo.CodComprobante = item.CodComprobante;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.nombreCliente = item.nombreCliente.Trim();
                        itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        itemInfo.vt_fecha = item.vt_fecha;
                        itemInfo.vt_total = Convert.ToDouble(item.vt_total);
                        itemInfo.Saldo = Convert.ToDouble(item.Saldo);
                        itemInfo.TotalCobrado = item.TotalCobrado;
                        itemInfo.vt_Subtotal = Convert.ToDouble(item.vt_Subtotal);
                        itemInfo.vt_iva = Convert.ToDouble(item.vt_iva);
                        itemInfo.vt_fech_venc = item.vt_fech_venc;
                        itemInfo.dc_ValorRetFu = item.dc_ValorRetFu;
                        itemInfo.dc_ValorRetIva = item.dc_ValorRetIva;
                        itemInfo.Logo = Cbt.em_logo_Image;
                        itemInfo.vt_plazo = item.vt_plazo;
                        itemInfo.IdUsuario = item.IdUsuario;
                        itemInfo.SubTotal_0 = item.SubTotal_0;
                        itemInfo.SubTotal_Iva = item.SubTotal_Iva;
                        itemInfo.IdFormaPago = item.IdFormaPago;
                        itemInfo.nom_FormaPago = item.IdFormaPago == null ? "" : "["+item.IdFormaPago.ToString()+"] "+ item.nom_FormaPago;
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
                return new List<XFAC_Rpt002_Info>();
            }
        }

    }
} 

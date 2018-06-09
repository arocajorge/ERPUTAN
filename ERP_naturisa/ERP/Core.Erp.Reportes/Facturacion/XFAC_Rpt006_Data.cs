using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt006_Data
    {

        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt006_Info> getDevolucionVentas(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta)
        {
            try
            {
                List<XFAC_Rpt006_Info> lstReport = new List<XFAC_Rpt006_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaHasta = Convert.ToDateTime(FechaHasta.ToShortDateString());

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {

                    var select = from q in ListadoDocu.vwFAC_Rpt006
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.dv_fecha >= FechaIni && q.dv_fecha <= FechaHasta
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin                                 
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {

                        XFAC_Rpt006_Info itemInfo = new XFAC_Rpt006_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdBodega = Convert.ToInt32(item.IdBodega);
                        itemInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                        itemInfo.IdDevolucion = item.IdDevolucion;
                        itemInfo.CodDevolucion = item.CodDevolucion;
                        itemInfo.IdNota = item.IdNota;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.IdVendedor = item.IdVendedor;
                        itemInfo.IdCbteVta = item.IdCbteVta;
                        itemInfo.dv_fecha = item.dv_fecha;
                        itemInfo.Estado = item.Estado;
                        itemInfo.dv_Observacion = item.dv_Observacion;
                        itemInfo.IdUsuario = item.IdUsuario;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.bo_Descripcion = item.bo_Descripcion;
                        itemInfo.dv_total = Convert.ToDouble(item.dv_total);
                        itemInfo.dv_iva = Convert.ToDouble(item.dv_iva);
                        itemInfo.dv_subtotal = Convert.ToDouble(item.dv_subtotal);       
                        itemInfo.Ve_Vendedor = item.Ve_Vendedor;
                        itemInfo.vt_NumFactura = item.vt_NumFactura;
                        itemInfo.Logo = Cbt.em_logo_Image;

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
                return new List<XFAC_Rpt006_Info>();
            }
        }

    }
}

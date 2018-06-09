using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt007_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt007_Info> get_SoporteFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<XFAC_Rpt007_Info> lstRpt = new List<XFAC_Rpt007_Info>();
                
                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {
                    var select = from q in ListadoDocu.vwFAC_Rpt007
                                 where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                 && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XFAC_Rpt007_Info infoRpt = new XFAC_Rpt007_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.CodCbteVta = item.CodCbteVta;
                        infoRpt.vt_tipoDoc = item.vt_tipoDoc;
                        infoRpt.numComprobante = item.numComprobante;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdVendedor = item.IdVendedor;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Ve_Vendedor = item.Ve_Vendedor;
                        infoRpt.vt_fecha = item.vt_fecha;
                        infoRpt.vt_fech_venc = item.vt_fech_venc;
                        infoRpt.vt_plazo = item.vt_plazo;
                        infoRpt.vt_tipo_venta = item.vt_tipo_venta;
                        infoRpt.vt_Observacion = item.vt_Observacion;
                        infoRpt.IdPeriodo = item.IdPeriodo;
                        infoRpt.vt_anio = item.vt_anio;
                        infoRpt.vt_mes = item.vt_mes;
                        infoRpt.vt_Flete = item.vt_Flete;
                        infoRpt.vt_interes = item.vt_interes;
                        infoRpt.vt_cantidad = item.vt_cantidad;
                        infoRpt.vt_Precio = item.vt_Precio;
                        infoRpt.vt_Subtotal = item.vt_Subtotal;
                        infoRpt.vt_iva = item.vt_iva;
                        infoRpt.vt_total = item.vt_total;
                        infoRpt.IdProducto = item.IdProducto;
                        infoRpt.nombreProducto = item.nombreProducto;
                        infoRpt.vt_autorizacion = item.vt_autorizacion;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.bo_Descripcion = item.bo_Descripcion;
                        infoRpt.Logo = Cbt.em_logo_Image;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;

                        lstRpt.Add(infoRpt);
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
                return new List<XFAC_Rpt007_Info>();
            }
        }

    }
}

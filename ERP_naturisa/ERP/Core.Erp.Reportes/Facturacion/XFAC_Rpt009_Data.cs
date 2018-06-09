using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt009_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt009_Info> get_Soporte_NC_ND(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                List<XFAC_Rpt009_Info> lstRpt = new List<XFAC_Rpt009_Info>();

                using (EntitiesFacturacion_Reportes listado = new EntitiesFacturacion_Reportes())
                {
                    var select = from q in listado.vwFAC_Rpt009
                                 where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                 && q.IdBodega == IdBodega && q.IdNota == IdNota
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XFAC_Rpt009_Info infoRpt = new XFAC_Rpt009_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdNota = item.IdNota;
                        infoRpt.Secuencia = item.Secuencia;
                        infoRpt.CodTipoNota = item.CodTipoNota;
                        infoRpt.IdTipoDocumento = item.IdTipoDocumento;
                        infoRpt.numDocumento = item.numDocumento;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdVendedor = item.IdVendedor;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Ve_Vendedor = item.Ve_Vendedor;
                        infoRpt.no_fecha = item.no_fecha;
                        infoRpt.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                        infoRpt.Plazo = Convert.ToInt32(item.Plazo);
                        infoRpt.IdTipoNota = item.IdTipoNota;
                        infoRpt.sc_observacion = item.sc_observacion;
                        infoRpt.IdDevolucion = Convert.ToDecimal(item.IdDevolucion);
                        infoRpt.interes = Convert.ToDouble(item.interes);
                        infoRpt.sc_cantidad = item.sc_cantidad;
                        infoRpt.sc_Precio = item.sc_Precio;
                        infoRpt.sc_subtotal = item.sc_subtotal;
                        infoRpt.sc_iva = item.sc_iva;
                        infoRpt.sc_total = item.sc_total;
                        infoRpt.IdProducto = item.IdProducto;
                        infoRpt.bo_Descripcion = item.bo_Descripcion;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.valorFlete = Convert.ToDouble(item.valorFlete);
                        infoRpt.IdCaja = item.IdCaja;
                        infoRpt.Caja = item.Caja;
                        infoRpt.Logo = Cbt.em_logo_Image;
                        infoRpt.nombreProducto = item.nombreProducto;
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
                return new List<XFAC_Rpt009_Info>();
            }
        }

    }
}

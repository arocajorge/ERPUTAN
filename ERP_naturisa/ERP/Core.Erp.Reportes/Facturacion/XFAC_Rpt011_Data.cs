using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt011_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt011_Info> get_ImpresionDevolucion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion)
        {
            try
            {
                List<XFAC_Rpt011_Info> lstRpt = new List<XFAC_Rpt011_Info>();

                using (EntitiesFacturacion_Reportes listado = new EntitiesFacturacion_Reportes())
                {

                    var select = from q in listado.vwFAC_Rpt011
                                 where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                 && q.IdBodega == IdBodega && q.IdDevolucion == IdDevolucion
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XFAC_Rpt011_Info infoRpt = new XFAC_Rpt011_Info();

                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdDevolucion = item.IdDevolucion;
                        infoRpt.CodDevolucion = item.CodDevolucion;
                        infoRpt.IdNota = item.IdNota;
                        infoRpt.IdCbteVta = item.IdCbteVta;
                        infoRpt.numDocumento = item.numDocumento;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdVendedor = item.IdVendedor;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_telefonoCasa = item.pe_telefonoCasa;
                        infoRpt.pe_direccion = item.pe_direccion;
                        infoRpt.Ve_Vendedor = item.Ve_Vendedor;
                        infoRpt.dv_fecha = item.dv_fecha;
                        infoRpt.dv_Observacion = item.dv_Observacion;
                        infoRpt.dv_interes = Convert.ToDouble(item.dv_interes);
                        infoRpt.dv_cantidad = item.dv_cantidad;
                        infoRpt.dv_valor = item.dv_valor;
                        infoRpt.dv_subtotal = item.dv_subtotal;
                        infoRpt.dv_iva = item.dv_iva;
                        infoRpt.dv_total = item.dv_total;
                        infoRpt.IdProducto = item.IdProducto;
                        infoRpt.nombreProducto = item.nombreProducto;
                        infoRpt.bo_Descripcion = item.bo_Descripcion;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.valorFlete = Convert.ToDouble(item.valorFlete);
                        infoRpt.Logo = Cbt.em_logo_Image;

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
                return new List<XFAC_Rpt011_Info>();
            }
        }

    }
}

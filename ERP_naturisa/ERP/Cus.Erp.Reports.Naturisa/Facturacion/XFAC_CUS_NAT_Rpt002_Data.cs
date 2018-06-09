using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Cus.Erp.Reports.Naturisa.Facturacion
{
    public class XFAC_CUS_NAT_Rpt002_Data
    {
        string mensaje = "";
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XFAC_CUS_NAT_Rpt002_Info> get_List_Facturas_x_Motivo(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, int IdMotivo_VtaIni, int IdMotivo_VtaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XFAC_CUS_NAT_Rpt002_Info> lstInfo = new List<XFAC_CUS_NAT_Rpt002_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                using (EntitiesFacturacion_Natu_Rpt listado = new EntitiesFacturacion_Natu_Rpt())
                {
                    var select = from q in listado.vwFAC_CUS_NAT_Rpt002
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.IdCliente >= IdClienteIni && q.IdCliente <= IdClienteFin
                                 && q.IdMotivo_Vta >= IdMotivo_VtaIni && q.IdMotivo_Vta <= IdMotivo_VtaFin
                                 && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                 select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XFAC_CUS_NAT_Rpt002_Info Info = new XFAC_CUS_NAT_Rpt002_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.Secuencia = item.Secuencia;
                        Info.IdProducto = item.IdProducto;
                        Info.vt_cantidad = item.vt_cantidad;
                        Info.vt_Precio = item.vt_Precio;
                        Info.vt_PorDescUnitario = item.vt_PorDescUnitario;
                        Info.vt_DescUnitario = item.vt_DescUnitario;
                        Info.vt_PrecioFinal = item.vt_PrecioFinal;
                        Info.vt_Subtotal = item.vt_Subtotal;
                        Info.vt_iva = item.vt_iva;
                        Info.vt_total = item.vt_total;
                        Info.vt_estado = item.vt_estado;
                        Info.vt_tieneIVA = item.vt_tieneIVA;
                        Info.vt_detallexItems = item.vt_detallexItems;
                        Info.vt_Peso = item.vt_Peso;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.vt_tipoDoc = item.vt_tipoDoc;
                        Info.vt_serie1 = item.vt_serie1;
                        Info.vt_serie2 = item.vt_serie2;
                        Info.vt_NumFactura = item.vt_NumFactura;
                        Info.IdCliente = item.IdCliente;
                        Info.IdVendedor = item.IdVendedor;
                        Info.vt_fecha = item.vt_fecha;
                        Info.vt_plazo = item.vt_plazo;
                        Info.vt_fech_venc = item.vt_fech_venc;
                        Info.vt_tipo_venta = item.vt_tipo_venta;
                        Info.vt_Observacion = item.vt_Observacion;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.Su_Descripcion = item.Su_Descripcion;
                        Info.bo_Descripcion = item.bo_Descripcion;
                        Info.Ve_Vendedor = item.Ve_Vendedor;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.vt_autorizacion = item.vt_autorizacion;
                        Info.IdTipoDocumento = item.IdTipoDocumento;
                        Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        Info.IdCaja = item.IdCaja;
                        Info.IdMotivo_Vta = item.IdMotivo_Vta;
                        Info.descripcion_motivo_vta = item.descripcion_motivo_vta;
                        Info.NomEmpresa = infoEmp.NombreComercial;
                        Info.Logo = infoEmp.em_logo_Image;
                        Info.num_Factura = item.vt_serie1 + "-" + item.vt_serie2 + "-" + item.vt_NumFactura;

                        lstInfo.Add(Info);
                    }
                }

                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}

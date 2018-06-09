using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt014_Data
    {
        public List<XFAC_FJ_Rpt014_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, int numero_lineas)
        {
            try
            {
                List<XFAC_FJ_Rpt014_Info> Lista = new List<XFAC_FJ_Rpt014_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt014
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdCbteVta == IdCbteVta
                              select q;

                    int RELLENAR = 0;

                    RELLENAR = numero_lineas - lst.Count();                    
                    int contador = 0;
                    XFAC_FJ_Rpt014_Info info_relleno = new XFAC_FJ_Rpt014_Info();

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt014_Info info = new XFAC_FJ_Rpt014_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.Secuencia = item.Secuencia;
                        info.vt_tipoDoc = item.vt_tipoDoc;
                        info.vt_serie1 = item.vt_serie1;
                        info.vt_serie2 = item.vt_serie2;
                        info.vt_NumFactura = item.vt_NumFactura;
                        info.vt_fecha = item.vt_fecha;
                        info.Estado = item.Estado;
                        info.IdProducto = item.IdProducto;
                        info.pr_descripcion = item.pr_descripcion;
                        info.vt_cantidad = item.vt_cantidad;
                        info.vt_PrecioFinal = item.vt_PrecioFinal;
                        info.vt_Subtotal = item.vt_Subtotal;
                        info.Atencion_a = item.Atencion_a;
                        info.num_oc = item.num_oc;
                        info.IdPunto_Cargo = item.IdPunto_Cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Observacion_x_item = item.Observacion_x_item;
                        info.IdCliente = item.IdCliente;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.pe_direccion = item.pe_direccion;
                        info.pe_telefonoOfic = item.pe_telefonoOfic;
                        info.Observacion_central = item.Observacion_central;
                        info.dia = item.dia;
                        info.mes = item.mes;
                        info.anio = item.anio;
                        info.vt_iva = item.vt_iva;
                        info.subtotal_0 = item.subtotal_0;
                        info.subtotal_iva = item.subtotal_iva;
                        info.vt_total = item.vt_total;
                        info.nom_producto = item.nom_producto;
                        info.forma_pago_CHEQUE_TRANSFERENCIA = item.forma_pago_CHEQUE_TRANSFERENCIA;
                        info.forma_pago_DINERO_ELECTRONICO = item.forma_pago_DINERO_ELECTRONICO;
                        info.forma_pago_EFECTIVO = item.forma_pago_EFECTIVO;
                        info.forma_pago_TARJETA_CRE_DEB = item.forma_pago_TARJETA_CRE_DEB;
                        info.descto = item.descto;
                        info.vt_por_iva = item.vt_por_iva;
                        info.pr_descripcion_2 = item.pr_descripcion_2;
                        Lista.Add(info);
                        contador++;

                        
                        info_relleno.IdEmpresa = item.IdEmpresa;
                        info_relleno.IdSucursal = item.IdSucursal;
                        info_relleno.IdBodega = item.IdBodega;
                        info_relleno.IdCbteVta = item.IdCbteVta;
                        info_relleno.Secuencia = item.Secuencia;
                        info_relleno.vt_tipoDoc = item.vt_tipoDoc;
                        info_relleno.vt_serie1 = item.vt_serie1;
                        info_relleno.vt_serie2 = item.vt_serie2;
                        info_relleno.vt_NumFactura = item.vt_NumFactura;
                        info_relleno.vt_fecha = item.vt_fecha;
                        info_relleno.Estado = item.Estado;
                        info_relleno.IdProducto = item.IdProducto;
                        info_relleno.Atencion_a = item.Atencion_a;
                        info_relleno.num_oc = item.num_oc;
                        info_relleno.IdPunto_Cargo = item.IdPunto_Cargo;
                        info_relleno.nom_punto_cargo = item.nom_punto_cargo;
                        info_relleno.IdCliente = item.IdCliente;
                        info_relleno.pe_nombreCompleto = item.pe_nombreCompleto;
                        info_relleno.pe_cedulaRuc = item.pe_cedulaRuc;
                        info_relleno.pe_direccion = item.pe_direccion;
                        info_relleno.pe_telefonoOfic = item.pe_telefonoOfic;
                        info_relleno.Observacion_central = item.Observacion_central;
                        info_relleno.dia = item.dia;
                        info_relleno.mes = item.mes;
                        info_relleno.anio = item.anio;
                        info_relleno.vt_por_iva = item.vt_por_iva;
                    }

                    for (int i = 0; i < RELLENAR; i++)
                    {                        
                        Lista.Add(info_relleno);
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

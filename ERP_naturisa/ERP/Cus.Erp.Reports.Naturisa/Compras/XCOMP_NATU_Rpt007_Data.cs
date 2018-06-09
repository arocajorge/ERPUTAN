using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt007_Data
    {
        public List<XCOMP_NATU_Rpt007_Info> consultar_data(int idempresa, int idsucursal, decimal idordencompra)
        {
            try
            {
                List<XCOMP_NATU_Rpt007_Info> listadatos = new List<XCOMP_NATU_Rpt007_Info>();
                using (EntitiesCompras_natu_rpt ECompras = new EntitiesCompras_natu_rpt())
                {
                    var select = from q in ECompras.vwCOMP_NATU_Rpt007
                                 where q.IdEmpresa == idempresa
                                 && q.IdSucursal == idsucursal
                                 && q.IdOrdenCompra == idordencompra
                                 select q;

                    foreach (var item in select)
                    {
                        XCOMP_NATU_Rpt007_Info itemInfo = new XCOMP_NATU_Rpt007_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.cantidad = item.cantidad;
                        itemInfo.cod_producto = item.cod_producto;
                        itemInfo.departamento = item.departamento;
                        itemInfo.empresa = item.empresa;
                        itemInfo.Estado = item.Estado;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.Flete = item.Flete;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                        // itemInfo.idPersona_Comprador = Convert.ToDecimal(item.IdPersona_comprador);
                        //itemInfo.IdPersona_Sol = Convert.ToDecimal(item.IdPersona_Sol);
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdProveedor = Convert.ToDecimal(item.IdProveedor);
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdTerminoPago = item.IdTerminoPago;
                        itemInfo.iva = item.iva;
                        //itemInfo.logo_empresa = item.logo_empresa;
                        itemInfo.Nom_comprador = item.Nom_comprador;
                        itemInfo.nom_producto = item.nom_producto;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.nom_solicitante = item.nom_solicitante;
                        itemInfo.Observacion = item.Observacion;
                        itemInfo.oc_NumDocumento = item.oc_NumDocumento;
                        itemInfo.peso = item.peso;
                        itemInfo.Plazo = item.Plazo;
                        itemInfo.por_desc = item.por_desc;
                        itemInfo.precio = item.precio;
                        itemInfo.ruc_empresa = item.ruc_empresa;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.subtotal = item.subtotal;
                        itemInfo.sucursal = item.sucursal;
                        itemInfo.Tipo = item.Tipo;
                        itemInfo.total = item.total;
                        itemInfo.valor_descuento = item.valor_descuento;
                        itemInfo.ced_ruc_provee = item.ced_ruc_provee;
                        itemInfo.telef_provee = item.telef_provee;
                        itemInfo.direc_provee = item.direc_provee;
                        itemInfo.NomUnidad = item.NomUnidad;
                        itemInfo.Nom_TerminoPago = item.Nom_TerminoPago;
                        itemInfo.nom_centro_costo = item.nom_centro_costo;
                        itemInfo.nom_sub_centro_costo = item.nom_sub_centro_costo;
                        itemInfo.Detalle_x_Items = item.Detalle_x_Items;
                        itemInfo.em_direccion = item.em_direccion;
                        //punto de cargo
                        itemInfo.IdPunto_cargo = item.IdPunto_cargo;
                        itemInfo.nom_punto_cargo = item.nom_punto_cargo;
                        //motivo de venta
                        itemInfo.Descripcion = item.Descripcion;
                        itemInfo.nom_EstadoCierre = item.nom_EstadoCierre;
                        itemInfo.pr_codigo = item.pr_codigo;
                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt007_Info>();
            }
        }
    }
}

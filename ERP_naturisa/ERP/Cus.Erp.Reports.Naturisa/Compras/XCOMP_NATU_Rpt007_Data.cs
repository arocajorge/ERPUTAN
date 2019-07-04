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
                    listadatos = (from q in ECompras.vwCOMP_NATU_Rpt007
                                  where q.IdEmpresa == idempresa
                                  && q.IdSucursal == idsucursal
                                  && q.IdOrdenCompra == idordencompra
                                  select new XCOMP_NATU_Rpt007_Info
                                  {
                                      IdEmpresa = q.IdEmpresa,
                                      cantidad = q.cantidad,
                                      cod_producto = q.cod_producto,
                                      departamento = q.departamento,
                                      empresa = q.empresa,
                                      Estado = q.Estado,
                                      Fecha = q.Fecha,
                                      Flete = q.Flete,
                                      IdOrdenCompra = q.IdOrdenCompra,
                                      IdProducto = q.IdProducto,
                                      IdProveedor = q.IdProveedor,
                                      IdSucursal = q.IdSucursal,
                                      IdTerminoPago = q.IdTerminoPago,
                                      iva = q.iva,
                                      // logo_empresa = q.logo_empresa,
                                      Nom_comprador = q.Nom_comprador,
                                      nom_producto = q.nom_producto,
                                      nom_proveedor = q.nom_proveedor,
                                      nom_solicitante = q.nom_solicitante,
                                      Observacion = q.Observacion,
                                      oc_NumDocumento = q.oc_NumDocumento,
                                      peso = q.peso,
                                      Plazo = q.Plazo,
                                      por_desc = q.por_desc,
                                      precio = q.precio,
                                      ruc_empresa = q.ruc_empresa,
                                      Secuencia = q.Secuencia,
                                      subtotal = q.subtotal,
                                      sucursal = q.sucursal,
                                      Tipo = q.Tipo,
                                      total = q.total,
                                      valor_descuento = q.valor_descuento,
                                      ced_ruc_provee = q.ced_ruc_provee,
                                      telef_provee = q.telef_provee,
                                      direc_provee = q.direc_provee,
                                      NomUnidad = q.NomUnidad,
                                      Nom_TerminoPago = q.Nom_TerminoPago,
                                      nom_centro_costo = q.nom_centro_costo,
                                      nom_sub_centro_costo = q.nom_sub_centro_costo,
                                      Detalle_x_Items = q.Detalle_x_Items,
                                      em_direccion = q.em_direccion,
                                      //punto de cargo
                                      IdPunto_cargo = q.IdPunto_cargo,
                                      nom_punto_cargo = q.nom_punto_cargo,
                                      //motivo de venta
                                      Descripcion = q.Descripcion,
                                      nom_EstadoCierre = q.nom_EstadoCierre,
                                      pr_codigo = q.pr_codigo,
                                      CodigoSucursal = q.CodigoSucursal,
                                      NombreUsuarioApro = q.NombreUsuarioApro
                                  }).ToList();
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

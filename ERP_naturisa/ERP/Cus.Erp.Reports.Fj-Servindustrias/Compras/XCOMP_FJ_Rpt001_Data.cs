using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Compras
{
    public class XCOMP_FJ_Rpt001_Data
    {

        public List<XCOMP_FJ_Rpt001_Info> Get_Orden_compra(int idEmpresa, int idSucursal, decimal idOrdenCompra)
        {
            try
            {
                List<XCOMP_FJ_Rpt001_Info> List = new List<XCOMP_FJ_Rpt001_Info>();

                using (ModelCompra_RptEntities Conexion = new ModelCompra_RptEntities())
                {
                    var query = from q in Conexion.vwCOMP_FJ_Rpt001
                                where idEmpresa == q.IdEmpresa
                                && idSucursal == q.IdSucursal
                                && idOrdenCompra == q.IdOrdenCompra
                                select q;

                    foreach (var item in query)
                    {     XCOMP_FJ_Rpt001_Info info=new XCOMP_FJ_Rpt001_Info();
                                            
                                  info.IdEmpresa = item.IdEmpresa;
                                  info.IdSucursal = item.IdSucursal;
                                  info.IdOrdenCompra = item.IdOrdenCompra;
                                  info.IdProveedor = item.IdProveedor;
                                  info.oc_NumDocumento = item.oc_NumDocumento;
                                  info.Tipo = item.Tipo;
                                  info.IdTerminoPago = item.IdTerminoPago;
                                  info.Plazo = item.Plazo;
                                  info.Fecha = item.Fecha;
                                  info.Observacion = item.Observacion;
                                  info.Estado = item.Estado;
                                  info.IdPersona_Sol = item.IdSolicitante;
                                  info.IdComprador = item.IdComprador;
                                  info.IdDepartamento = item.IdDepartamento;
                                  info.departamento = item.departamento;
                                  info.Secuencia = item.Secuencia;
                                  info.IdProducto = item.IdProducto;
                                  info.cantidad = item.cantidad;
                                  info.precio = item.precio;
                                  info.por_desc = item.por_desc;
                                  info.valor_descuento = item.valor_descuento;
                                  info.subtotal = item.subtotal;
                                  info.iva = item.iva;
                                  info.total = item.total;
                                  info.peso = item.peso;
                                  info.cod_producto = item.cod_producto;
                                  info.nom_producto = item.nom_producto;
                                  info.sucursal = item.sucursal;
                                  info.empresa = item.empresa;
                                 info.ruc_empresa = item.ruc_empresa;
                                 info.logo_empresa = item.logo_empresa;
                                 info.nom_proveedor = item.nom_proveedor;
                                 info.ced_ruc_provee = item.ced_ruc_provee;
                                 info.direc_provee = item.direc_provee;
                                 info.telef_provee = item.telef_provee;
                                 info.nom_sub_centro_costo = item.nom_sub_centro_costo;
                                 info.Detalle_x_Items = item.Detalle_x_Items;
                                 info.IdPunto_cargo = item.IdPunto_cargo;
                                 info.nom_punto_cargo = item.nom_punto_cargo;
                                 info.em_direccion = item.em_direccion;
                                 info.nom_solicitante = item.nom_solicitante;
                                 info.Descripcion = item.Descripcion;
                                 info.em_telefonos = item.em_telefonos;
                                 info.mail_empresa = item.mail_empresa;
                                 info.Direccion_sucu = item.Direccion_sucu;
                                 info.Telef_Sucursal = item.Telef_Sucursal;
                                 info.Contacto_Prov = item.Contacto_Prov;
                                 info.mail_prove = item.mail_prove;
                                 info.nom_centro_costo = item.nom_centro_costo;
                                 info.Nom_comprador = item.Nom_comprador;
                                 info.Nom_TerminoPago = item.Nom_TerminoPago;
                                 info.NomUnidad = item.NomUnidad;
                                 info.Flete = item.Flete;
                                 List.Add(info);
                        
                    }




                }
                return List;
            }
            catch (Exception ex)
            {
               return new List<XCOMP_FJ_Rpt001_Info>();
            }
        }

    }
}

using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_SeguimientoOrdenCompraContable_Data
    {
        public List<com_SeguimientoOrdenCompraContable_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<com_SeguimientoOrdenCompraContable_Info> Lista = new List<com_SeguimientoOrdenCompraContable_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.SPCOM_SeguimientoOrdenCompraContable(IdEmpresa, IdSucursal, IdOrdenCompra).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new com_SeguimientoOrdenCompraContable_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdOrdenCompra = item.IdOrdenCompra,
                            pe_nombreCompleto = item.pe_nombreCompleto,
                            CodigoOC = item.CodigoOC,
                            Secuencia = item.Secuencia,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            do_Cantidad = item.do_Cantidad,
                            do_precioFinal = item.do_precioFinal,
                            do_subtotal = item.do_subtotal,
                            do_iva = item.do_iva,
                            Por_Iva = item.Por_Iva,
                            do_total = item.do_total,
                            tm_descripcion = item.tm_descripcion,
                            Su_Descripcion = item.Su_Descripcion,
                            IdNumMovi = item.IdNumMovi,
                            cm_fecha = item.cm_fecha,
                            dm_cantidad_sinConversion = item.dm_cantidad_sinConversion,
                            IdAprobacion = item.IdAprobacion,
                            pe_nombrecompletoAprobacion = item.pe_nombrecompletoAprobacion,
                            Fecha_Factura = item.Fecha_Factura,
                            num_documento = item.num_documento,
                            UsuarioIngresa = item.UsuarioIngresa,

                            UsuarioAprobacion = item.UsuarioAprobacion,
                            ObservacionAprobacion = item.ObservacionAprobacion,
                        });
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

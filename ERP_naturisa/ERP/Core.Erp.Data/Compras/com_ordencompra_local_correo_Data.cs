using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_ordencompra_local_correo_Data
    {

        public com_ordencompra_local_correo_Info GetOC()
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_ordencompra_local_correo_Info info = db.vwcom_ordencompra_local_correo.Select(q => new com_ordencompra_local_correo_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSucursal = q.IdSucursal,
                        IdOrdenCompra = q.IdOrdenCompra,
                        CorreoComprador = q.CorreoComprador,
                        CorreoProveedor = q.pe_correo,
                        pe_cedulaRuc = q.pe_cedulaRuc,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        Codigo = q.Codigo
                    }).FirstOrDefault();

                    db.SaveChanges();

                    return info;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(com_ordencompra_local_correo_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var entity = db.com_ordencompra_local_correo.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdOrdenCompra == info.IdOrdenCompra).FirstOrDefault();
                    if (entity == null)
                        return false;

                    entity.FechaEnvio = DateTime.Now;
                    entity.Mensaje = info.Mensaje;
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

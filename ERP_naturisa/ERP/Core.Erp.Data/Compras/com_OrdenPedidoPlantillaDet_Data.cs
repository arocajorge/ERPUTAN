using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedidoPlantillaDet_Data
    {
        public List<com_OrdenPedidoPlantillaDet_Info> GetList(int IdEmpresa, decimal IdPlantilla)
        {
            try
            {
                List<com_OrdenPedidoPlantillaDet_Info> Lista;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_OrdenPedidoPlantillaDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdPlantilla == IdPlantilla).Select(q => new com_OrdenPedidoPlantillaDet_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdPlantilla = q.IdPlantilla,
                        Secuencia = q.Secuencia,
                        IdProducto = q.IdProducto,
                        pr_descripcion = q.pr_descripcion,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdSucursalOrigen = q.IdSucursalOrigen,
                        IdSucursalDestino = q.IdSucursalDestino,
                        IdPunto_cargo = q.IdPunto_cargo,
                        opd_Cantidad = q.opd_Cantidad,
                        opd_Detalle = q.opd_Detalle
                    }).ToList();
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

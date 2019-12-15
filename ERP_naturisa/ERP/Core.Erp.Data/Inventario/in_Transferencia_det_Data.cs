using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_Transferencia_det_Data
    {
        public List<in_transferencia_det_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {
            try
            {
                List<in_transferencia_det_Info> Lista = new List<in_transferencia_det_Info>();

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var lst = db.in_transferencia_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursalOrigen == IdSucursal && q.IdBodegaOrigen == IdBodega && q.IdTransferencia == IdTransferencia).ToList();

                    foreach (var item in lst)
                    {
                        Lista.Add(new in_transferencia_det_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdBodegaOrigen = item.IdBodegaOrigen,
                            IdTransferencia = item.IdTransferencia,
                            dt_secuencia = item.dt_secuencia,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            dt_cantidad = item.dt_cantidad,
                            tr_Observacion = item.tr_Observacion,
                            EnviarEnGuia = item.EnviarEnGuia ?? false,
                            IdUnidadMedida = item.IdUnidadMedida
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

        public List<in_transferencia_det_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<in_transferencia_det_Info> Lista = new List<in_transferencia_det_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.vwcom_ordencompra_local_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdOrdenCompra == IdOrdenCompra).ToList();

                    foreach (var item in lst)
                    {
                        Lista.Add(new in_transferencia_det_Info
                        {
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            dt_cantidad = item.do_Cantidad,
                            tr_Observacion = item.do_observacion,
                            IdUnidadMedida = item.IdUnidadMedida,
                            IdSucursal_oc = item.IdSucursal,
                            IdOrdenCompra = item.IdOrdenCompra,
                            Secuencia_oc = item.Secuencia
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

using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_SeguimientoEntrega_Data
    {
        public List<com_SeguimientoEntrega_Info> GetList(int IdEmpresa, string IdUsuario, int IdSolicitante, int IdComprador, decimal IdProducto, decimal IdProveedor, DateTime FechaIni, DateTime FechaFin, decimal IdOrdenPedido)
        {
            try
            {
                List<com_SeguimientoEntrega_Info> Lista = new List<com_SeguimientoEntrega_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.SPCOM_SeguimientoEntrega(IdEmpresa, IdUsuario, IdSolicitante, IdComprador, IdProducto, IdProveedor, FechaIni, FechaFin,IdOrdenPedido).ToList();

                    foreach (var item in lst)
                    {
                        Lista.Add(new com_SeguimientoEntrega_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdUsuario = item.IdUsuario,
                            IdOrdenPedido = item.IdOrdenPedido,
                            Secuencia = item.Secuencia,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            EstadoSolpe = item.EstadoSolpe,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            CodigoSucOrigen = item.CodigoSucOrigen,
                            NombreSucursalOrigen = item.NombreSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            CodigoSucDestino = item.CodigoSucDestino,
                            NombreSucursalDestino = item.NombreSucursalDestino,
                            EstadoDetalle = item.EstadoDetalle,
                            nom_solicitante = item.nom_solicitante,
                            op_Fecha = item.op_Fecha,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = item.opd_CantidadApro,
                            IdUsuarioCantidad = item.IdUsuarioCantidad,
                            FechaCantidad = item.FechaCantidad,
                            NombreUsuarioCantidad = item.NombreUsuarioCantidad,
                            NomUnidadMedida = item.NomUnidadMedida,
                            op_Observacion = item.op_Observacion,
                            ObservacionGA = item.ObservacionGA,
                            opd_Detalle = item.opd_Detalle,
                            IdSucursalOC = item.IdSucursalOC,
                            IdOrdenCompra = item.IdOrdenCompra,
                            SecuenciaOC = item.SecuenciaOC,
                            IdProveedor = item.IdProveedor,
                            pe_nombreCompleto = item.pe_nombreCompleto,
                            CodigoOC = item.CodigoOC,
                            CantidadOC = item.CantidadOC,
                            FechaOC = item.FechaOC,
                            FechaEntrega = item.FechaEntrega,
                            IdComprador = item.IdComprador,
                            NombreComprador = item.NombreComprador,
                            IB_UltIdNumMovi = item.IB_UltIdNumMovi,
                            IB_Cantidad = item.IB_Cantidad,
                            IB_Fecha = item.IB_Fecha,
                            AlertaEntrega = item.AlertaEntrega,
                            CantidadPendiente = item.CantidadPendiente,
                            DiasPendiente = item.DiasPendiente,
                            NombreSucursalTransferencia = item.NombreSucursalTransferencia,
                            NombreBodegaTransferencia = item.NombreBodegaTransferencia,
                            FechaTransferencia = item.FechaTransferencia,
                            FechaRecepcionTransferencia = item.FechaRecepcionTransferencia,
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.CuentasxPagar
{
    public class XCXP_FJ_Rpt001_Data
    {
        public List<XCXP_FJ_Rpt001_Info> Get_Lista_Reporte(int idEmpresa, decimal idTransferencia,decimal idGuia, int idSucursalOrigen, int idSucursalFin ,int idBodegaOrigen, int idBodegaFin)
        {
            try
            {
                List<XCXP_FJ_Rpt001_Info> Lista = new List<XCXP_FJ_Rpt001_Info>();

                using (EntitiesCxP_FJ Conexion = new EntitiesCxP_FJ())
                {
                    Lista = (from q in Conexion.vwCXP_FJ_Rpt001
                             where q.IdEmpresa == idEmpresa
                             //&& idTransferencia == q.IdTransferencia
                             && idGuia == q.IdGuia
                             //&& idSucursalOrigen == q.IdSucursalOrigen
                             //&& idSucursalFin == q.IdSucursalDest
                             //&& idBodegaOrigen == q.IdBodegaOrigen
                             //&& idBodegaFin == q.IdBodegaDest
                             select new XCXP_FJ_Rpt001_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursalOrigen = q.IdSucursalOrigen,
                                 IdBodegaOrigen = q.IdBodegaOrigen,
                                 IdTransferencia = q.IdTransferencia,
                                 IdSucursalDest = q.IdSucursalDest,
                                 IdBodegaDest = q.IdBodegaDest,
                                 Sucursal_Origen = q.Sucursal_Origen,
                                 Sucursal_Fin = q.Sucursal_Fin,
                                 Bodega_Ini = q.Bodega_Ini,
                                 Bodega_Fin = q.Bodega_Fin,
                                 observacion = q.observacion,
                                 cantidad = q.cantidad,
                                 dt_secuencia = q.dt_secuencia,
                                 NumGuia = q.NumGuia,
                                 IdGuia = q.IdGuia,
                                 Direc_sucu_Partida = q.Direc_sucu_Partida,
                                 Direc_sucu_Llegada = q.Direc_sucu_Llegada,
                                 Cedula = q.Cedula,
                                 Nombre = q.Nombre,
                                 Fecha = q.Fecha,
                                 Fecha_llegada = q.Fecha_llegada,
                                 Fecha_Traslado = q.Fecha_Traslado,
                                 Hora_Traslado = q.Hora_Traslado,
                                 Hora_Llegada = q.Hora_Llegada,
                                 pr_codigo = q.pr_codigo,
                                 IdProducto = q.IdProducto,
                                 pr_descripcion = q.pr_descripcion,
                                 Motivo_traslado = q.Motivo_traslado,
                                 IdMotivo_Traslado = q.IdMotivo_Traslado

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

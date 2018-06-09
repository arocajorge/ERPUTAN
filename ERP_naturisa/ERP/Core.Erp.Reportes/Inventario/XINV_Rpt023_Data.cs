using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt023_Data
    {
        public List<XINV_Rpt023_Info> Get_Lista_Reporte(int idEmpresa, decimal idDev_Inven)
        {
            try
            {
                List<XINV_Rpt023_Info> Lista = new List<XINV_Rpt023_Info>();

                using (Entities_Inventario_General Conexion = new Entities_Inventario_General())
                {
                    Lista = (from q in Conexion.vwINV_Rpt023
                             where idEmpresa == q.IdEmpresa
                             && idDev_Inven == q.IdDev_Inven
                             select new XINV_Rpt023_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdDev_Inven = q.IdDev_Inven,
                                 cod_Dev_Inven = q.cod_Dev_Inven,
                                 Fecha = q.Fecha,
                                 IdSucursal = q.IdSucursal,
                                 //IdBodega = q.IdBodega,
                                 IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                 IdNumMovi = q.IdNumMovi,
                                 IdProducto = q.IdProducto,
                                 cantidad_a_devolver = q.cantidad_a_devolver,
                                 dm_cantidad = q.dm_cantidad,
                                 mv_costo = q.mv_costo,
                                 pr_descripcion = q.pr_descripcion,
                                 Su_Descripcion = q.Su_Descripcion,
                                 //bo_Descripcion = q.bo_Descripcion,
                                 tm_descripcion = q.tm_descripcion,
                                 Secuencia_movi_inv = q.Secuencia_movi_inv,
                                 observacion = q.observacion

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

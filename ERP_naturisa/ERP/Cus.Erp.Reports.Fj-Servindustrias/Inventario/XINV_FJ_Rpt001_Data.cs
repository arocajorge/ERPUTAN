using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt001_Data
    {
        public List<XINV_FJ_Rpt001_Info> Get_OrdenSer_Info(int idEmpresa, int idSucursal, int idBodega, decimal idOrdenSer_x_Af)
        {
            try
            {
                List<XINV_FJ_Rpt001_Info> Lista = new List<XINV_FJ_Rpt001_Info>();
                using (EntitiesInventario_FJ_Rpt Conexion = new EntitiesInventario_FJ_Rpt())
                {
                    Lista = (from q in Conexion.vwINV_FJ_Rpt001
                             where q.IdEmpresa == idEmpresa && q.IdSucursal == idSucursal
                             && q.IdBodega == idBodega && q.IdOrdenSer_x_Af == idOrdenSer_x_Af
                             select new XINV_FJ_Rpt001_Info
                             {
                                 Secuencia = q.Secuencia,
                                 Cantidad = q.Cantidad,
                                 Costo = q.Costo,
                                 SubTotal = q.SubTotal,
                                 Iva = q.Iva,
                                 Total = q.Total,
                                 IdOrdenSer_x_Af = q.IdOrdenSer_x_Af,
                               //  Fecha = q.Fecha,
                                 Num_Fact = q.Num_Fact,
                                 Num_Documento = q.Num_Documento,
                                 Observacion = q.Observacion,
                                 Su_Descripcion = q.Su_Descripcion,
                                 bo_Descripcion = q.bo_Descripcion,
                                 pr_codigo = q.pr_codigo,
                                 pr_descripcion = q.pr_descripcion,
                                 IdSucursal = q.IdSucursal,
                                 IdEmpresa = q.IdEmpresa,
                                 IdBodega = q.IdBodega,
                                 pr_nombre = q.pr_nombre,
                                 Af_Nombre = q.Af_Nombre,
                                 em_nombre = q.em_nombre
                             }).ToList();
                }
                return Lista;
            }
            catch (Exception)
            {
                return new List<XINV_FJ_Rpt001_Info>();
            }
        }
    }
}

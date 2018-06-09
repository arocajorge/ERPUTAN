using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt021_Data
    {
        public List<XINV_Rpt021_Info> Get_Lista_Reporte(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, int idProductoIni, int idProductoFin, DateTime fechaDesde, DateTime fechaHasta, int diasStock, Boolean MostrarCero)
        {
            try
            {
                List<XINV_Rpt021_Info> lst = new List<XINV_Rpt021_Info>();

                using (Entities_Inventario_General Conexion = new Entities_Inventario_General())
                {
                    lst = (from q in Conexion.spINV_Rpt021(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, idProductoIni, idProductoFin, fechaDesde, fechaHasta, diasStock,MostrarCero)
                           select new XINV_Rpt021_Info
                           {
                               IdEmpresa = q.IdEmpresa,
                               IdSucursal = q.IdSucursal,
                               IdBodega = q.IdBodega,
                               Idproducto = q.Idproducto,
                               cod_producto = q.cod_producto,
                               nom_producto = q.nom_producto,
                               nom_sucursal = q.nom_sucursal,
                               nom_bodega = q.nom_bodega,
                               egresos = q.egresos,
                               stock_fecha_desde = q.stock_fecha_desde,
                               stock_fecha_hasta = q.stock_fecha_hasta,
                               promedio = q.promedio,
                               indice = q.indice,
                               stock_minimo = q.stock_minimo,
                               stock_hoy = q.stock_hoy,
                               cant_a_comprar = q.cant_a_comprar
                           }).ToList();
                }
                return lst;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}

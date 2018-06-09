using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt021_Bus
    {
        XINV_Rpt021_Data oData = new XINV_Rpt021_Data();

        public List<XINV_Rpt021_Info> Get_Lista_Reporte(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin, int idProductoIni, int idProductoFin, DateTime fechaDesde, DateTime fechaHasta, int diasStock, Boolean MostrarCero)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, idProductoIni, idProductoFin, fechaDesde, fechaHasta, diasStock,MostrarCero);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}

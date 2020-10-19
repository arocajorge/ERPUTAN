using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt014_Bus
    {
        XINV_Rpt014_Data odata = new XINV_Rpt014_Data();
        public List<XINV_Rpt014_Info> GetList(int IdEmpresa, decimal IdProducto, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdSucursal, int IdBodega)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdProducto, FechaIni, FechaFin, IdCentroCosto, IdSucursal, IdBodega);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

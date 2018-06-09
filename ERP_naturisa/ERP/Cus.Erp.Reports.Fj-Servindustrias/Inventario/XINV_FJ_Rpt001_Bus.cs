using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt001_Bus
    {
        XINV_FJ_Rpt001_Data Data = new XINV_FJ_Rpt001_Data();

        public List<XINV_FJ_Rpt001_Info> Get_OrdenSer_Info(int idEmpresa, int idSucursal, int idBodega, decimal idOrdenSer_x_Af)
        {
            try
            {
                return Data.Get_OrdenSer_Info(idEmpresa, idSucursal, idBodega, idOrdenSer_x_Af);
            }
            catch (Exception)
            {
                return new List<XINV_FJ_Rpt001_Info>();
            }
        }
    }
}

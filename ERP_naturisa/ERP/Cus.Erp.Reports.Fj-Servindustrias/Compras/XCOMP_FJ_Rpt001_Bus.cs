using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Compras
{
    public class XCOMP_FJ_Rpt001_Bus
    {
        XCOMP_FJ_Rpt001_Data Data = new XCOMP_FJ_Rpt001_Data();

        public List<XCOMP_FJ_Rpt001_Info> Get_Orden_compra(int idEmpresa, int idSucursal, decimal idOrdenCompra)
        {
            try
            {
                return Data.Get_Orden_compra(idEmpresa, idSucursal, idOrdenCompra);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_FJ_Rpt001_Info>();
            }
        }
    }
}

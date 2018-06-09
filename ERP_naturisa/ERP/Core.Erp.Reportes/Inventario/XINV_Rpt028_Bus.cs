using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt028_Bus
    {
        XINV_Rpt028_Data oData = new XINV_Rpt028_Data();

        public List<XINV_Rpt028_Info> Get_list(int IdEmpresa, decimal IdProducto, decimal IdProveedor, int IdSucursal, decimal IdOrdenCompra, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdProducto, IdProveedor,IdSucursal,IdOrdenCompra,Fecha_ini,Fecha_fin);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt028_Info>();
            }
        }
    }
}

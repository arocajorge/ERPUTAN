using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt005_Bus
    {
        XINV_NAT_Rpt005_Data oData = new XINV_NAT_Rpt005_Data();
        public List<XINV_NAT_Rpt005_Info> Get_list(int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string IdCentroCosto, List<string> lst_subcentro, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdSucursal, lst_bodega,IdProducto, IdCentroCosto, lst_subcentro, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

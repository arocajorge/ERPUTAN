using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt008_Bus
    {
        XCOMP_Rpt008_Data oData = new XCOMP_Rpt008_Data();

        public List<XCOMP_Rpt008_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProducto, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdProducto, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

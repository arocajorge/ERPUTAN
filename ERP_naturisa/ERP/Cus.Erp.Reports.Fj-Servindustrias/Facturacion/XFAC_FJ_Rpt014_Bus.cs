using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt014_Bus
    {
        XFAC_FJ_Rpt014_Data oData = new XFAC_FJ_Rpt014_Data();

        public List<XFAC_FJ_Rpt014_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, int numero_lineas)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, numero_lineas);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

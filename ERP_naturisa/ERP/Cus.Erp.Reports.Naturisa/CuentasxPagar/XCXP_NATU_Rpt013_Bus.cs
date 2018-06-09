using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt013_Bus
    {
        XCXP_NATU_Rpt013_Data oData = new XCXP_NATU_Rpt013_Data();
        public List<XCXP_NATU_Rpt013_Info> Get_list(int IdEmpresa, int IdClaseProveedor, decimal IdProveedor, DateTime Fecha_ini, DateTime Fecha_fin, bool mostrar_cuenta)
        {
            try
            {
                return oData.Get_list(IdEmpresa,IdClaseProveedor, IdProveedor, Fecha_ini, Fecha_fin,mostrar_cuenta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

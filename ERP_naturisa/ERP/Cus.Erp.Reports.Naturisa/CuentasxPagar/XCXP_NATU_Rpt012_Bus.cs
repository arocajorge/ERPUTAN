using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt012_Bus
    {
        XCXP_NATU_Rpt012_Data oData = new XCXP_NATU_Rpt012_Data();
        public List<XCXP_NATU_Rpt012_Info> Get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, bool Mostrar_agrupado)
        {
            try
            {
                return oData.Get_list(IdEmpresa, Fecha_ini, Fecha_fin, Mostrar_agrupado);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt013_Bus
    {
        XCXP_Rpt013_Data data = new XCXP_Rpt013_Data();
        public List<XCXP_Rpt013_Info> GetData(int IdEmpresa, DateTime Fechacorte, decimal IdProveedor)
        {
            return data.GetData(IdEmpresa, Fechacorte, IdProveedor);
        }
    }
}

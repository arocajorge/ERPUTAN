using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt014_Bus
    {
        XCXP_Rpt014Data data = new XCXP_Rpt014Data();
        public List<XCXP_Rpt014_Info> GetData(int IdEmpresa, DateTime Fechacorte, decimal IdProveedor)
        {
            return data.GetData(IdEmpresa, Fechacorte, IdProveedor);
        }
    }
}

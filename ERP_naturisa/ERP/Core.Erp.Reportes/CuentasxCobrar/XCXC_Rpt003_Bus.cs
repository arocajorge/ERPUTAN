using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt003_Bus
    {
        XCXC_Rpt003_Data dataRpt = new XCXC_Rpt003_Data();

        public List<XCXC_Rpt003_Info> get_ImpresionConciliacion(int IdEmpresa, int IdSucursal, decimal IdConciliacion)
        {
            try
            {
                return dataRpt.get_ImpresionConciliacion(IdEmpresa,  IdSucursal,  IdConciliacion);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt003_Info>();
            }
        }

        public XCXC_Rpt003_Bus()
        {

        }
    }
}

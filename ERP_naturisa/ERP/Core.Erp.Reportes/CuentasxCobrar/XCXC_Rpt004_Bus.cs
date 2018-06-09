using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt004_Bus
    {
        XCXC_Rpt004_Data dataRpt = new XCXC_Rpt004_Data();

        public List<XCXC_Rpt004_Info> get_ImpresionCobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return dataRpt.get_ImpresionCobro(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt004_Info>();
            }
        }


        public XCXC_Rpt004_Bus()
        {

        }
    }
}

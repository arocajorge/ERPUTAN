using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt002_Bus
    {
        XCXC_Rpt002_Data dataRpt = new XCXC_Rpt002_Data();

        public List<XCXC_Rpt002_Info> get_ImpresionAnticipo(int IdEmpresa, int IdSucursal, decimal IdAnticipo)
        {
            try
            {
                return dataRpt.get_ImpresionAnticipo(IdEmpresa, IdSucursal, IdAnticipo);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt002_Info>();
            }
        }


        public XCXC_Rpt002_Bus()
        {

        }
    }
}

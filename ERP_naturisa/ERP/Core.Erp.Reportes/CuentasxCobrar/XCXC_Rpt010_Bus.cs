using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt010_Bus
    {
        XCXC_Rpt010_Data dataRpt = new XCXC_Rpt010_Data();

        public List<XCXC_Rpt010_Info> get_DetalleDiasxVencer(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte)
        {
            try
            {
                return dataRpt.get_DetalleDiasxVencer(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte);
            }
            catch (Exception )
            {
                return new List<XCXC_Rpt010_Info>();
            }
        }


        public XCXC_Rpt010_Bus()
        {

        }
    }
}

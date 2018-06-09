using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt006_Bus
    {
        XCXP_Rpt006_Data NCPROVEE = new XCXP_Rpt006_Data();
        public List<XCXP_Rpt006_Info> consultar_data(int IdEmpresa, decimal IdCbteCble_Nota, ref string mensaje)
        {
            try
            {
                return NCPROVEE.consultar_data(IdEmpresa, IdCbteCble_Nota, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt006_Info>();
            }
        }
        public XCXP_Rpt006_Bus()
        {
        }

    }
}

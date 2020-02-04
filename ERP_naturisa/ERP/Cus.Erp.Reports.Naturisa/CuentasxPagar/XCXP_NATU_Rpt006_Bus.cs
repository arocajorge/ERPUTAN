using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Cus.Erp.Reports.Naturisa;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt006_Bus
    {
        XCXP_NATU_Rpt006_Data oData= new XCXP_NATU_Rpt006_Data();

        public List<XCXP_NATU_Rpt006_Info> consultaGeneral(int IdEmpresa, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                return oData.consultaGeneral(IdEmpresa, co_fechaOg_Ini, co_fechaOg_Fin);
            }
            catch (Exception ex)
            {

                return new List<XCXP_NATU_Rpt006_Info>();
            }
        }

    }
}

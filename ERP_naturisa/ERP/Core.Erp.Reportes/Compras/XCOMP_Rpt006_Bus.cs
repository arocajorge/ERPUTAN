using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt006_Bus
    {
        XCOMP_Rpt006_Data dataRpt = new XCOMP_Rpt006_Data();

        public List<XCOMP_Rpt006_Info> get_Presupuesto_Solicitud(List<XCOMP_Rpt006_Info> lstIdPresupuestoCompra)
        {
            try
            {
                return dataRpt.get_Presupuesto_Solicitud(lstIdPresupuestoCompra);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XCOMP_Rpt006_Bus()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt005_Bus
    {
        XCOMP_Rpt005_Data dataRpt = new XCOMP_Rpt005_Data();

        public List<XCOMP_Rpt005_Info> get_PreAprobacion_Solicitud(List<XCOMP_Rpt005_Info> lstIdSolicitudCompra)
        {
            try
            {
                return dataRpt.get_PreAprobacion_Solicitud(lstIdSolicitudCompra);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }


        public XCOMP_Rpt005_Bus()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt007_Bus
    {
        XACTF_Rpt007_Data dataRpt = new XACTF_Rpt007_Data();

        public List<XACTF_Rpt007_Info> get_RptVenta_AF(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_RptVenta_AF( IdEmpresa,  FechaIni,  FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }


        public XACTF_Rpt007_Bus()
        {

        }
    }
}

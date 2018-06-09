using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt009_Bus
    {
        XACTF_Rpt009_Data dataRpt = new XACTF_Rpt009_Data();

        public List<XACTF_Rpt009_Info> get_CodigoBarra(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                return dataRpt.get_CodigoBarra(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }


        public XACTF_Rpt009_Bus()
        {

        }
    }
}

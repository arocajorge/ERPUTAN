using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
  public  class XBAN_Rpt009_Bus
    {
        XBAN_Rpt009_Data dataRpt = new XBAN_Rpt009_Data();

        public List<XBAN_Rpt009_Info> get_ReporteSaldoBancos(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return dataRpt.get_ReporteSaldoBancos(IdEmpresa, Fecha_ini,Fecha_fin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }
    }
}

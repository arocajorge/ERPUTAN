using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt010_Bus
    {
        XACTF_Rpt010_Data dataRpt = new XACTF_Rpt010_Data();

        public List<XACTF_Rpt010_Info> get_CambioUbica_AF(int IdEmpresa, int IdActivoFijo, int IdActivoFijoTipo, DateTime FechaIni, DateTime FechaHasta)
        {
            try
            {
                return dataRpt.get_CambioUbica_AF(IdEmpresa, IdActivoFijo, IdActivoFijoTipo, FechaIni, FechaHasta);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt010_Bus()
        {

        }
    }
}

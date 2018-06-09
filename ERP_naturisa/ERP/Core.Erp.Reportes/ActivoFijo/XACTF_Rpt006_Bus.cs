using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt006_Bus
    {
        XACTF_Rpt006_Data dataRpt = new XACTF_Rpt006_Data();

        public List<XACTF_Rpt006_Info> get_MejoraBaja_ActivoFijo(int IdEmpresa, string Id_Tipo, int IdActivoFijo, string Estado, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_MejoraBaja_ActivoFijo( IdEmpresa, Id_Tipo, IdActivoFijo, Estado, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt006_Bus()
        {

        }
    }
}

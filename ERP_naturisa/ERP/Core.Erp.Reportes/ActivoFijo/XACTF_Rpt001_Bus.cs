using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt001_Bus
    {
        XACTF_Rpt001_Data dataRpt = new XACTF_Rpt001_Data();

        public List<XACTF_Rpt001_Info> get_BajaMejora_ActivoFijo(int IdEmpresaa, decimal Id_Baja_Mejora, string Id_Tipo)
        {
            try
            {
                return dataRpt.get_BajaMejora_ActivoFijo(IdEmpresaa, Id_Baja_Mejora, Id_Tipo);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt001_Bus()
        {

        }
    }
}
 
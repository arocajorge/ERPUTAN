using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt014_Bus
    {
        XCONTA_Rpt014_Data oData = new XCONTA_Rpt014_Data();
        public List<XCONTA_Rpt014_Info> Get_list_reporte(int IdEmpresa, List<string> IdGrupoCble, string IdCtaCble, string IdCentroCosto, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdGrupoCble, IdCtaCble, IdCentroCosto, FechaIni, FechaFin);
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

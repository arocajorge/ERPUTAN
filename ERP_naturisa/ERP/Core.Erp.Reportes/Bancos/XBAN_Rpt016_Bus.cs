using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt016_Bus
    {
        XBAN_Rpt016_Data oData = new XBAN_Rpt016_Data();

        public List<XBAN_Rpt016_Info> Get_Lista_Reporte(int idEmpresa, int idPersonaIni, int idPersonaFin, int idBancoIni, int idBancoFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idPersonaIni, idPersonaFin, idBancoIni, idBancoFin, FechaIni, FechaFin);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt004_Bus
    {
        XBAN_Rpt004_Data odata = new XBAN_Rpt004_Data();
        public List<XBAN_Rpt004_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte, /*string girado_A*/decimal IdPerona_Girado, string SchkImpreso, string Schkfacs)
        {
            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin, idBancoIni, idBancoFin, TipoCbte, /*girado_A*/IdPerona_Girado, SchkImpreso, Schkfacs);
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

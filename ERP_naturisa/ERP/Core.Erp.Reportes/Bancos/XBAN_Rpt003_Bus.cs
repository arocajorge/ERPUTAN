using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt003_Bus
    {
        XBAN_Rpt003_Data odata = new XBAN_Rpt003_Data();
        public List<XBAN_Rpt003_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte,/*string girado_A*/decimal IdPersona_Girado, string SchkImpreso, string Schkfacs, string Cheque)
        {
            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin, idBancoIni, idBancoFin, TipoCbte,/*girado_A*/IdPersona_Girado, SchkImpreso, Schkfacs, Cheque);
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

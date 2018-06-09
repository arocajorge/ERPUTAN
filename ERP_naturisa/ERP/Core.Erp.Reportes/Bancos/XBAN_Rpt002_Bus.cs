using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt002_Bus
    {
        XBAN_Rpt002_Data odata = new XBAN_Rpt002_Data();
        public List<XBAN_Rpt002_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte,decimal IdPersona_Girado)
        {
            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin, idBancoIni, idBancoFin, TipoCbte, IdPersona_Girado);
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

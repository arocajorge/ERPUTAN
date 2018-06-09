using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt007_saldos_Bus
    {

       XBAN_Rpt007_saldos_Data Objt = new XBAN_Rpt007_saldos_Data();

       public List<XBAN_Rpt007_saldos_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, String IdUsuario)
        {
            try
            {
                return Objt.Get_List(IdEmpresa, FechaIni, FechaFin, IdUsuario);
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

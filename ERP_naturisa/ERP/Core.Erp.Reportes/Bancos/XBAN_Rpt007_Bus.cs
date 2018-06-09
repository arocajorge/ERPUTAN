using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt007_Bus
    {

       XBAN_Rpt007_Data dataRpt = new XBAN_Rpt007_Data();

       public List<XBAN_Rpt007_Info> Get_list_reporte(int IdEmpresa, List<int> lst_IdTipoFlujo, DateTime FechaIni, DateTime FechaFin, bool Mostrar_detallado, int IdBanco, bool Mostrar_solo_conciliado, bool Mostrar_beneficiario)
        {
            try
            {
                return dataRpt.Get_list_reporte(IdEmpresa,lst_IdTipoFlujo, FechaIni, FechaFin,Mostrar_detallado, IdBanco,Mostrar_solo_conciliado, Mostrar_beneficiario);
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

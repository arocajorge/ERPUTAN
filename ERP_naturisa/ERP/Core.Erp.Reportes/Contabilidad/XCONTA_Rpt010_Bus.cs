using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
   public class XCONTA_Rpt010_Bus
    {

       XCONTA_Rpt010_Data oData = new XCONTA_Rpt010_Data();

       public List<XCONTA_Rpt010_Info> Get_list_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdPunto_cargo_grupo, bool Mostrar_Reg_Cero)
       {
            try
            {
                return oData.Get_list_Data(IdEmpresa, FechaIni, FechaFin, IdPunto_cargo_grupo, Mostrar_Reg_Cero);
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

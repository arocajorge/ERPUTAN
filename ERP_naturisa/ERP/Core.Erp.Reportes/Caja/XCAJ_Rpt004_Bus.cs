using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt004_Bus
    {
        XCAJ_Rpt004_Data Obj = new XCAJ_Rpt004_Data();
        public List<XCAJ_Rpt004_Info> Get_List(int IdEmpresa, decimal IdConciliacion_Caja)
        {
            try
            {
                return Obj.Get_List(IdEmpresa, IdConciliacion_Caja);
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

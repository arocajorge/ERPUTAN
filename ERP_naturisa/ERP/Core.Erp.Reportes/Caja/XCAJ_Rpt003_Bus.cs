using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt003_Bus
    {
        XCAJ_Rpt003_Data oData = new XCAJ_Rpt003_Data(); 

        public List<XCAJ_Rpt003_Info> Get_List_Conciliacion_Caja_X_Usuario(int IdEmpresa, decimal IdConciliacion_Caja)
        {
            try
            {
                return oData.Get_List_Conciliacion_Caja_X_Usuario(IdEmpresa, IdConciliacion_Caja);
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

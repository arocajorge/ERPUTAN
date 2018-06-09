using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt009_Bus
    {
        XCONTA_Rpt009_Data oData = new XCONTA_Rpt009_Data();

        public List<XCONTA_Rpt009_Info> Get_list_CbteCble_x_cp_Conciliacion_caja(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                return oData.Get_list_CbteCble_x_cp_Conciliacion_caja(IdEmpresa, IdConciliacion_caja);
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

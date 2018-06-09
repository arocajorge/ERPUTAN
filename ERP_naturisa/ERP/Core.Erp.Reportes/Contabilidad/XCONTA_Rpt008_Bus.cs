using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt008_Bus
    {
        XCONTA_Rpt008_Data oData = new XCONTA_Rpt008_Data();
        public List<XCONTA_Rpt008_Info> Get_List_Reporte(int IdEmpresa, Decimal IdOrdenPago)
        {
            try
            {
                return oData.Get_List_Reporte(IdEmpresa, IdOrdenPago);
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

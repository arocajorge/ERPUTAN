using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt016_Bus
    {
        XCONTA_Rpt016_Data oData = new XCONTA_Rpt016_Data();

        public List<XCONTA_Rpt016_Info> Get_list_reporte(List<ct_Periodo_Info> lst_periodos, int IdEmpresa, int anio, bool Mostrar_CC)
        {
            try
            {
                return oData.Get_list_reporte(lst_periodos, IdEmpresa, anio, Mostrar_CC);
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

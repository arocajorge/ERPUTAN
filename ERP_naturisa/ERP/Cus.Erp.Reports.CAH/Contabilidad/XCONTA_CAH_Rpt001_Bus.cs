using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.CAH.Contabilidad
{
    public class XCONTA_CAH_Rpt001_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        XCONTA_CAH_Rpt001_Data Odata = new XCONTA_CAH_Rpt001_Data();

        string mensaje = "";

        public List<XCONTA_CAH_Rpt001_Info> consultar_data(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref String mensaje)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdTipoCbte, IdCbteCble, ref  mensaje);
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

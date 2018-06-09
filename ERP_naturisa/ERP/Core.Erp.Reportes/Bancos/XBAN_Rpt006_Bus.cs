using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt006_Bus
    {
       

        XBAN_Rpt006_Data Odata = new XBAN_Rpt006_Data();

        public List<XBAN_Rpt006_Info> Get_Data_Reporte(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                return Odata.Get_Data_Reporte(IdEmpresa, IdTipoCbte, IdCbteCble, ref MensajeError);
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

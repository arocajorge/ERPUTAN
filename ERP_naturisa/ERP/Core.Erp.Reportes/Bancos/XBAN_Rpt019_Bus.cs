using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt019_Bus
    {
       XBAN_Rpt019_Data data = new XBAN_Rpt019_Data();
        public List<XBAN_Rpt019_Info> GetData(int IdEmpresa, int IdTipoComprobante ,decimal IdComprobante,  ref string MensajeError)
        {
            try
            {
                return data.GetData(IdEmpresa, IdTipoComprobante ,IdComprobante, ref  MensajeError);
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

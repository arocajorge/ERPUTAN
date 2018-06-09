using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Cus.Erp.Reports.Naturisa.Bancos
{
   public class XBAN_NAT_Rpt001_Bus
    {

        XBAN_NAT_Rpt001_Data Odata = new XBAN_NAT_Rpt001_Data();

        public List<XBAN_NAT_Rpt001_Info> Get_Data_Reporte(int IdEmpresa, int IdTipocbte, decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                return Odata.Get_Data_Reporte(IdEmpresa, IdTipocbte, IdCbteCble, ref MensajeError);
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

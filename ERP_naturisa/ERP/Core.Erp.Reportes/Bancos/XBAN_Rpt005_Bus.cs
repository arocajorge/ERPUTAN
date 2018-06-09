using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt005_Bus
    {
        XBAN_Rpt005_Data data = new XBAN_Rpt005_Data();
        public List<XBAN_Rpt005_Info> GetData(int IdEmpresa, decimal IdComprobante, int IdTipoComprobante, ref string MensajeError)
        {
            try
            {
                return data.GetData(IdEmpresa, IdComprobante, IdTipoComprobante, ref  MensajeError);
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

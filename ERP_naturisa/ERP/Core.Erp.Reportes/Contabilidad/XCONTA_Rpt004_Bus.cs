using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt004_Bus
    {

        
        string mensaje = "";

        private XCONTA_Rpt004_Data oData = new XCONTA_Rpt004_Data();

        public List<XCONTA_Rpt004_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, ref msg);
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

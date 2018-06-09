/*CLASE: XROL_Rpt007_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 24-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
   public  class XROL_Rpt007_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt007_Data oData = new XROL_Rpt007_Data();

        public List<XROL_Rpt007_Info> GetListPorIdActa(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito, ref string msg)
        {
            try
            {
                return oData.GetListPorIdActa(idEmpresa, idEmpleado, idActaFiniquito, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt007_Info>();
            }
        }




    }
}

/*CLASE: XROL_Rpt010_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
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
    public class XROL_Rpt010_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt010_Data oData = new XROL_Rpt010_Data();

        public List<XROL_Rpt010_Info> GetListPorEmpleado(int idEmpresa, decimal IdDepartamento, DateTime fechaInicial, DateTime fechaFinal, ref string msg)
        {
            try
            {
                return oData.GetListPorEmpleado(idEmpresa, IdDepartamento, fechaInicial, fechaFinal, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt010_Info>();
            }
        }
    
    
    
    }
}

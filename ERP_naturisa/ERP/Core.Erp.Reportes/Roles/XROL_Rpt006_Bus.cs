/*CLASE: XROL_Rpt006_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 18-06-2015
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
    public class XROL_Rpt006_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt006_Data oData = new XROL_Rpt006_Data();

        public List<XROL_Rpt006_Info> GetListPorNominaPeriodo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui,int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListPorNominaPeriodo(idEmpresa, idNominaTipo, idNominaTipoLiqui,idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt006_Info>();
            }
        }




    }
}

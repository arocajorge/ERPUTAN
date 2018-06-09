/*CLASE: XROL_Rpt011_Bus
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
    public class XROL_Rpt011_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt011_Data oData = new XROL_Rpt011_Data();

        public List<XROL_Rpt011_Info> GetListPorArchivo(int idEmpresa, int idnomina, int idnominatipo, int idperiodo)
        {
            try
            {
                return oData.GetListPorArchivo(idEmpresa, idnomina,idnominatipo,idperiodo);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt011_Info>();
            }
        }
        public List<XROL_Rpt011_Info> GetListPorArchivo(int idEmpresa, int idnomina, int idnominatipo, int idperiodo, int iddiviosn)
        {
            try
            {
                return oData.GetListPorArchivo(idEmpresa, idnomina, idnominatipo, idperiodo,iddiviosn);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt011_Info>();
            }
        }


    }
}

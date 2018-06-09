/*CLASE: XROL_Rpt003_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 04-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt003_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt003_Data oData = new XROL_Rpt003_Data();

        public List<XROL_Rpt003_Info> GetListConsultaGeneral(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt003_Info>();
            }    
        }

        public List<XROL_Rpt003_Info> GetListConsultaGeneral(int idEmpresa,int IdDepartamento, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,IdDepartamento, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt003_Info>();
            }
        }


    }
}


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
  public  class XROL_Rpt019_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt019_Data oData = new XROL_Rpt019_Data();

        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt019_Info>();
            }
        }

        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui,DateTime fi,DateTime ff, int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, fi,ff, iddepartamento, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt019_Info>();
            }
        }

        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, DateTime fi,DateTime ff, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, fi,ff, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt019_Info>();
            }
        }


    }
}


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
    public class XROL_Rpt025_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt025_Data oData = new XROL_Rpt025_Data();

        public List<XROL_Rpt025_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int idempleado, int iddepartamento, string IdRubro, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,idempleado,iddepartamento,IdRubro, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt025_Info>();
            }    
        
        
        }


        public List<XROL_Rpt025_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int iddepartamento, string IdRubro, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, iddepartamento,IdRubro, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt025_Info>();
            }


        }


    }
}

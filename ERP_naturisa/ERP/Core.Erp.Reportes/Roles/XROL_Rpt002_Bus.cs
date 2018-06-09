/*CLASE: XROL_Rpt002_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 23-03-2015
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
    public class XROL_Rpt002_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
   
        private XROL_Rpt002_Data oData = new XROL_Rpt002_Data();

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, ref string msg) {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, ref msg);
            }catch (Exception ex){
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }       
        }

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo,int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo,idNominaLiqui,idPeriodo,iddepartamento,  ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo, int IdDivision)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, idPeriodo, IdDivision);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, idPeriodo);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }


        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo,int IdDivision, int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, idNominaLiqui, idPeriodo,IdDivision, iddepartamento, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }

    }
}

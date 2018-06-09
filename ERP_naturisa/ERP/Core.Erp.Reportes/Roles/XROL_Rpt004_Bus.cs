/*CLASE: XROL_Rpt004_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA: 13-05-2015
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
    public class XROL_Rpt004_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt004_Data oData = new XROL_Rpt004_Data();

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,string idrubro,int idempleado,int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,idrubro,idempleado,iddepartamento, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }    
        
        
        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, string idrubro,int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, idrubro, iddepartamento, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int iddepartamento, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, iddepartamento, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,string idrubro,  ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,idrubro, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }


    }
}

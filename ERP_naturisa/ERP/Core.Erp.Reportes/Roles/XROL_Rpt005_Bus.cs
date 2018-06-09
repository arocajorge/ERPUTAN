/*CLASE: XROL_Rpt005_Bus
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
    public class XROL_Rpt005_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt005_Data oData = new XROL_Rpt005_Data();

        public List<XROL_Rpt005_Info> GetListConsultaPorPrestamo(int idEmpresa, decimal idPrestamo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorPrestamo(idEmpresa, idPrestamo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt005_Info>();
            }


        }


    }
}

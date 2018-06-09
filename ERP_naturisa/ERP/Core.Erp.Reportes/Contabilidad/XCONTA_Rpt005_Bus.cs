using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt005_Bus
    {
        XCONTA_Rpt005_Data odata = new XCONTA_Rpt005_Data();


        public List<XCONTA_Rpt005_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
        {


            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin);

            }
            catch (Exception ex)
            {

                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt013_Bus
    {
        XACTF_Rpt013_Data Odata = new XACTF_Rpt013_Data();
        public List<XACTF_Rpt013_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdActivoFijo, string mensaje)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdSucursal, IdActivoFijo, ref mensaje);
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

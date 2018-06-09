using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt002_Bus
    {
        XACTF_Rpt002_Data dataRpt = new XACTF_Rpt002_Data();

        public List<XACTF_Rpt002_Info> get_ReporteActivoFijo(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdTipoDepreciacion, int IdTipoActivo, string IdEstadoProceso, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_ReporteActivoFijo(IdEmpresa, IdSucursalIni, IdSucursalFin, IdTipoDepreciacion, IdTipoActivo, IdEstadoProceso, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt002_Bus()
        {

        }
    }
}

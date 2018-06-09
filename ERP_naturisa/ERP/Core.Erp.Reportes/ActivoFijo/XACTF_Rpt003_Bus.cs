using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt003_Bus
    {
        XACTF_Rpt003_Data dataRpt = new XACTF_Rpt003_Data();

        public List<XACTF_Rpt003_Info> get_Activo_Caracteristica(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdTipoDepreciacion, int IdTipoActivo, string IdEstadoProceso, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_Activo_Caracteristica(IdEmpresa, IdSucursalIni, IdSucursalFin, IdTipoDepreciacion, IdTipoActivo, IdEstadoProceso, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt003_Bus()
        {

        }
    }
}

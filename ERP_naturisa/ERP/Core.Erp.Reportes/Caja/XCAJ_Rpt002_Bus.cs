using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt002_Bus
    {
        XCAJ_Rpt002_Data oData = new XCAJ_Rpt002_Data();
        public List<XCAJ_Rpt002_Info> Get_List(int IdEmpresa, int IdCajaIni, int IdCajaFin, int IdTipoMoviIni, int IdTipoMoviFin, string TipoIngrEgr, DateTime FechaIni, DateTime FechaFin, decimal IdPersonaIni, decimal IdPersonaFin, decimal IdEntidadIni, decimal IdEntidadFin, int IdTipoFlujoIni, int IdTipoFlujoFin, string IdTipo_Persona)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdCajaIni, IdCajaFin, IdTipoMoviIni, IdTipoMoviFin, TipoIngrEgr, FechaIni, FechaFin, IdPersonaIni, IdPersonaFin, IdEntidadIni, IdEntidadFin, IdTipoFlujoIni, IdTipoFlujoFin, IdTipo_Persona);
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

using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt018_Bus
    {
        XCONTA_Rpt018_Data oData = new XCONTA_Rpt018_Data();

        public List<XCONTA_Rpt018_Info> Get_list_reporte(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_cargo_grupo, bool Mostrar_detalle)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, Fecha_ini, Fecha_fin, IdPunto_cargo_grupo, Mostrar_detalle);
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

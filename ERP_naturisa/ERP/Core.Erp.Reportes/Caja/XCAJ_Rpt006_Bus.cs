using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt006_Bus
    {
        XCAJ_Rpt006_Data oData = new XCAJ_Rpt006_Data();
        public List<XCAJ_Rpt006_Info> Get_list_reporte(int IdEmpresa, int IdCaja, int IdTipoMovi, decimal IdConciliacion, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_Cargo)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdCaja, IdTipoMovi, IdConciliacion, Fecha_ini, Fecha_fin, IdPunto_Cargo);
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

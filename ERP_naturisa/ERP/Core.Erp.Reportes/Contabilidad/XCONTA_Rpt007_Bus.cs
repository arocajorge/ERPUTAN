using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt007_Bus
    {
        XCONTA_Rpt007_Data oData = new XCONTA_Rpt007_Data();

        public List<XCONTA_Rpt007_Info> Get_List_Reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,string IdCentro_Costo
            , int IdPunto_Cargo_Grupo, int IdPunto_Cargo, bool Mostrar_Cero, bool MostrarCC, string IdUsuario)
        {
            try
            {
                return oData.Get_List_Reporte(IdEmpresa, FechaIni, FechaFin, IdCentro_Costo, IdPunto_Cargo_Grupo, IdPunto_Cargo, Mostrar_Cero, MostrarCC, IdUsuario);
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

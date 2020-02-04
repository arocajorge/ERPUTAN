using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    public class XCONTA_NATU_Rpt001_Bus
    {
        XCONTA_NATU_Rpt001_Data oData = new XCONTA_NATU_Rpt001_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public List<XCONTA_NATU_Rpt001_Info> Get_List_Reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,string IdCentro_Costo
            , int IdPunto_Cargo_Grupo, int IdPunto_Cargo, bool Mostrar_Cero, bool MostrarCC)
        {
            try
            {
                return oData.Get_List_Reporte(IdEmpresa, FechaIni, FechaFin,IdCentro_Costo,IdPunto_Cargo_Grupo, IdPunto_Cargo,Mostrar_Cero,MostrarCC, param.IdUsuario);
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

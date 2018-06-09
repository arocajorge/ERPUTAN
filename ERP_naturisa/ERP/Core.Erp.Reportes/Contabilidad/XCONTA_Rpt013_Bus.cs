using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt013_Bus
    {
        XCONTA_Rpt013_Data Odata = new XCONTA_Rpt013_Data();

        public List<XCONTA_Rpt013_Info> consultar_data(int IdEmpresa, int IdPeriodo_Actual, string IdCentroCosto, int IdNivel_a_mostrar
             , int IdPunto_cargo_grupo, int IdPunto_cargo, bool Mostrar_reg_Cero, bool Mostrar_CC,string IdUsuario, ref String mensaje)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdPeriodo_Actual, IdCentroCosto, IdNivel_a_mostrar,
                    IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero,Mostrar_CC,IdUsuario, ref mensaje);
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

using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt017_Bus
    {
        XCONTA_Rpt017_Data Odata = new XCONTA_Rpt017_Data();

        public List<XCONTA_Rpt017_Info> consultar_data(int IdEmpresa, List<ct_Periodo_Info> listPeriodo, string IdCentroCosto, int IdNivel_a_mostrar
    , int IdPunto_cargo_grupo
    , int IdPunto_cargo
    , bool Mostrar_reg_Cero
    , bool MostrarCC,string IdGrupoCble,string IdUsuario, ref String MensajeError)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, listPeriodo, IdCentroCosto, IdNivel_a_mostrar, 
                    IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, MostrarCC, IdGrupoCble,IdUsuario, ref MensajeError);
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

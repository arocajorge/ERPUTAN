using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt002_Bus
    {
        XCONTA_Rpt002_Data Odata = new XCONTA_Rpt002_Data();

        public List<XCONTA_Rpt002_Info> consultar_data(int IdEmpresa, DateTime FechaIni,DateTime FechaFin, string IdCentroCosto, int IdNivel_a_mostrar,  int IdPunto_cargo_grupo
           , int IdPunto_cargo, bool Mostrar_reg_en_cero, bool MostrarCC,bool Considerar_Asiento_cierre_anual ,string IdUsuario, ref String mensaje)
        {
            try
            {
                List<XCONTA_Rpt002_Info> lista = new List<XCONTA_Rpt002_Info>();
                ct_AnioFiscal_Bus bus = new ct_AnioFiscal_Bus();
                ct_AnioFiscal_Info info = new ct_AnioFiscal_Info();

                lista = Odata.consultar_data(IdEmpresa, FechaIni,FechaFin, IdCentroCosto, 
                    IdNivel_a_mostrar, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_en_cero,MostrarCC,Considerar_Asiento_cierre_anual  ,IdUsuario,  ref mensaje);

                return lista;
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XCONTA_Rpt002_Bus()
        {

        }
    }
}

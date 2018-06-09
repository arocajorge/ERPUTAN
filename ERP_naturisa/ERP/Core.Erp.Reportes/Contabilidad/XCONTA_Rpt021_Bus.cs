using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
   public  class XCONTA_Rpt021_Bus
    {
       XCONTA_Rpt021_Data Odata = new XCONTA_Rpt021_Data();

       public List<XCONTA_Rpt021_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdNivel_a_mostrar
            , int IdPunto_cargo_grupo, int IdPunto_cargo, bool Mostrar_reg_Cero, bool MostrarCC,bool Considerar_Asiento_cierre_anual,string IdUsuario, ref String mensaje)
       {
            try 
	        {
                return Odata.consultar_data(IdEmpresa, FechaIni, FechaFin,IdCentroCosto, IdNivel_a_mostrar, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero,MostrarCC,Considerar_Asiento_cierre_anual,IdUsuario, ref mensaje);
	        }
	        catch (Exception ex)
	        {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
		
       }
        
       public XCONTA_Rpt021_Bus()

       {
           

       }

    }
}

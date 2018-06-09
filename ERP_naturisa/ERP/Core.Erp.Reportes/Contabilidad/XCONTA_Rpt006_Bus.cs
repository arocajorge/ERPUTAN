using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Contabilidad
{
   public class XCONTA_Rpt006_Bus
    {

       XCONTA_Rpt006_Data Odata = new XCONTA_Rpt006_Data();


       public List<XCONTA_Rpt006_Info> Get_Data_Reporte(int IdEmpresa, string IdCtaCble, string IdCentro_Costo,
           DateTime FechaIni, DateTime FechaFin, int IdGrupo_Punto_Cargo, int IdPunto_Cargo,Boolean Mostrar_Asiento_cierre,
           ref string MensajeError)
       {
           try
           {
               return Odata.Get_Data_Reporte(IdEmpresa, IdCtaCble,IdCentro_Costo, FechaIni, FechaFin,IdGrupo_Punto_Cargo,IdPunto_Cargo,Mostrar_Asiento_cierre, ref MensajeError);
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

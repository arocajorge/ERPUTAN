using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
   public  class XBAN_Rpt010_Bus
    {
       XBAN_Rpt010_Data Odata = new XBAN_Rpt010_Data();


       public List<XBAN_Rpt010_Info> Get_Data_Reporte(int IdEmpresa, int IdBanco, DateTime FechaIni, DateTime FechaFin,ref string MensajeError)
       {
           try
           {
               return Odata.Get_Data_Reporte(IdEmpresa, IdBanco, FechaIni, FechaFin, ref MensajeError);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Caja
{
   public class XCAJ_Rpt005_Bus
   {
       XCAJ_Rpt005_Data Obj = new XCAJ_Rpt005_Data();
       public List<XCAJ_Rpt005_Info> Get_List(int IdEmpresa, int IdCaja, DateTime Fecha_inicio, DateTime Fecha_Fin)
       {
           try
           {
               return Obj.Get_List(IdEmpresa, IdCaja,Fecha_inicio,Fecha_Fin);
           }
           catch (Exception ex)
           {
               tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
               oLog.Log_Error(ex.ToString());
               throw new Exception(ex.ToString());
           }
       }
       public List<XCAJ_Rpt005_Info> Get_List(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
       {
           try
           {
               return Obj.Get_List(IdEmpresa, Fecha_inicio, Fecha_Fin);
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

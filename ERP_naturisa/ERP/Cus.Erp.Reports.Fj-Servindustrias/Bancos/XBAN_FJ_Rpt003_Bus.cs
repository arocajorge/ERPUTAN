using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cus.Erp.Reports.FJ.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt003_Bus
   {
       XBAN_FJ_Rpt003_Data data = new XBAN_FJ_Rpt003_Data();
       public List<XBAN_FJ_Rpt003_Info> Get_List_FlujoEreso(int idEmpresa, DateTime fi, DateTime ff)
       {
           try
           {
               return data.Get_List_FlujoEreso(idEmpresa, fi,ff);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);

           }
       }
    }
}

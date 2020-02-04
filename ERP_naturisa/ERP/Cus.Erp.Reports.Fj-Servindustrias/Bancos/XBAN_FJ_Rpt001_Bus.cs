using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt001_Bus
   {
       XBAN_FJ_Rpt001_Data oData = new XBAN_FJ_Rpt001_Data();
       public List<XBAN_FJ_Rpt001_Info> Get_List_Conciliacion(int idEmpresa, DateTime Fecha_I, DateTime Fecha_F)
       {
           try
           {
               return oData.Get_List_Conciliacion(idEmpresa, Fecha_I, Fecha_F);
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

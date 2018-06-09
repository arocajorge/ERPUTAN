using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;


namespace Core.Erp.Business.SeguridadAcceso
{
   public class seg_Menu_Item_Tipo_Bus
    {
       seg_Menu_Item_Tipo_Data Odata = new seg_Menu_Item_Tipo_Data();


       public List<seg_Menu_Item_Tipo_Info> Get_List_Menu_Item_Tipo()
       {
           try
           {
               return Odata.Get_List_Menu_Item_Tipo();
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

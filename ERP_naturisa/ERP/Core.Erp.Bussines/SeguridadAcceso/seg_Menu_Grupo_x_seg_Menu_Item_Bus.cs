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
   public class seg_Menu_Grupo_x_seg_Menu_Item_Bus
    {

       seg_Menu_Grupo_x_seg_Menu_Item_Data Odata = new seg_Menu_Grupo_x_seg_Menu_Item_Data();


       public List<seg_Menu_Grupo_x_seg_Menu_Item_Info> Get_List_Menu_Grupo_x_seg_Menu_Item()
       {
           try
           {
               return Odata.Get_List_Menu_Grupo_x_seg_Menu_Item();

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

       public Boolean GrabarDB(seg_Menu_Grupo_x_seg_Menu_Item_Info info, ref string MensajeError)
       {
           try
           {
               return Odata.GrabarDB(info,ref MensajeError);

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

       public Boolean ModificarDB(seg_Menu_Grupo_x_seg_Menu_Item_Info infoOrigen, seg_Menu_Grupo_x_seg_Menu_Item_Info infoDestino, ref string MensajeError)
       {
           try
           {
               return Odata.ModificarDB(infoOrigen, infoDestino, ref MensajeError);

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


       public Boolean EliminarDB(seg_Menu_Grupo_x_seg_Menu_Item_Info info, ref string MensajeError)
       {
           try
           {
               return Odata.EliminarDB(info,ref MensajeError);

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

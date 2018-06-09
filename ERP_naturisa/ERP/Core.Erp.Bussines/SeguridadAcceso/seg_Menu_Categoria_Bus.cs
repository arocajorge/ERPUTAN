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
   public class seg_Menu_Categoria_Bus
    {

       seg_Menu_Categoria_Data Odata = new seg_Menu_Categoria_Data();

       public List<seg_Menu_Categoria_Info> Get_List_Menu_Categoria()
       {
           try
           {

               return Odata.Get_List_Menu_Categoria();

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

       public Boolean GrabarDB(seg_Menu_Categoria_Info info,ref string Id, ref string MensajeError)
       {
           try
           {

               return Odata.GrabarDB(info,ref Id, ref MensajeError);

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

       public List<seg_Menu_Categoria_Info> Get_List_Menu_Categoria_Con_Pagina(string Cod_Categoria)
       {
           try
           {
               return Odata.Get_List_Menu_Categoria_Con_Pagina(Cod_Categoria);
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

       public Boolean EliminarDB(seg_Menu_Categoria_Info Info, ref string MensajeError)
       {
           try
           {
               return Odata.EliminarDB(Info, ref MensajeError);
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

       public Boolean ModificarDB(seg_Menu_Categoria_Info Info, ref string MensajeError)
       {
           try
           {
               return Odata.ModificarDB(Info, ref MensajeError);
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

       public Boolean Modificar_Posicion_Categoria(seg_Menu_Categoria_Info InfoOrigen, seg_Menu_Categoria_Info InfoDestino, ref string MensajeError)
       {
           try
           {
               return Odata.Modificar_Posicion_Categoria(InfoOrigen, InfoDestino, ref MensajeError);
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

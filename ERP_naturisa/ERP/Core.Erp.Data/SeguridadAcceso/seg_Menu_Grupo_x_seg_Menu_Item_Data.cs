using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.SeguridadAcceso
{
   public class seg_Menu_Grupo_x_seg_Menu_Item_Data
    {


       public List<seg_Menu_Grupo_x_seg_Menu_Item_Info> Get_List_Menu_Grupo_x_seg_Menu_Item()
       {
           try
           {
               List<seg_Menu_Grupo_x_seg_Menu_Item_Info> lista = new List<seg_Menu_Grupo_x_seg_Menu_Item_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Grupo_x_seg_Menu_Item
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Grupo_x_seg_Menu_Item_Info Info = new seg_Menu_Grupo_x_seg_Menu_Item_Info();

                       Info.Codigo_Item = item.Codigo_Item;
                       Info.Codigo_Grupo = item.Codigo_Grupo;
                       Info.observacion = item.observacion;
                       lista.Add(Info);
                   }
               }
               return lista;
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
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = new seg_Menu_Grupo_x_seg_Menu_Item();

                   contact.Codigo_Grupo = info.Codigo_Grupo;
                   contact.Codigo_Item = info.Codigo_Item;
                   contact.observacion = info.observacion;
                   context.seg_Menu_Grupo_x_seg_Menu_Item.Add(contact);
                   context.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.Message;
               return false;
           }
       }

       public Boolean ModificarDB(seg_Menu_Grupo_x_seg_Menu_Item_Info infoOrigen, seg_Menu_Grupo_x_seg_Menu_Item_Info infoDestino, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Grupo_x_seg_Menu_Item.FirstOrDefault(q => q.Codigo_Grupo == infoOrigen.Codigo_Grupo && q.Codigo_Item == infoOrigen.Codigo_Item);
                   if (contact!=null)
                   {
                       contact.Codigo_Grupo = infoDestino.Codigo_Grupo;
                       contact.Codigo_Item = infoDestino.Codigo_Item;
                       contact.observacion = infoDestino.observacion;
                       context.SaveChanges();    
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.Message;
               return false;
           }
       }

       public Boolean EliminarDB(seg_Menu_Grupo_x_seg_Menu_Item_Info info, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   context.Database.ExecuteSqlCommand("delete from seg_Menu_Grupo_x_seg_Menu_Item where Codigo_Grupo = '" + info.Codigo_Grupo + "' and Codigo_Item = '" + info.Codigo_Item+ "' ");                   
               }
               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.Message;
               return false;
           }
       }
    }
}

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
   public class seg_Menu_Grupo_Data
    {

       public List<seg_Menu_Grupo_Info> Get_List_Menu_Grupo(string CodPagina)
       {
           try
           {
               List<seg_Menu_Grupo_Info> lista = new List<seg_Menu_Grupo_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Grupo
                           where C.Codigo_Pagina == CodPagina
                           orderby C.position
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Grupo_Info Info = new seg_Menu_Grupo_Info();

                       Info.Codigo = item.Codigo_Grupo;
                       Info.Codigo_Grupo = item.Codigo_Grupo;
                       Info.Descripcion = item.Descripcion;
                       Info.AllowMinimize = item.AllowMinimize;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ShowCaptionButton = item.ShowCaptionButton;
                       Info.Visible = item.Visible;
                       Info.Codigo_Pagina = item.Codigo_Pagina;
                       Info.position = item.position;

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

       public Boolean GrabarDB(seg_Menu_Grupo_Info info,ref string Id, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                   var Q = from per in EDB.seg_Menu_Grupo
                           where per.Codigo_Grupo == info.Codigo_Grupo
                           select per;
                   if (Q.ToList().Count == 0)
                   {
                       var address = new seg_Menu_Grupo();

                       
                           address.Codigo_Grupo = info.Codigo_Grupo = Id=GetId(ref MensajeError);
                       

                       address.Descripcion = (info.Descripcion == null) ? "" : info.Descripcion;
                       address.Visible = (info.Visible == null) ? false : info.Visible;
                       address.Codigo_Pagina = info.Codigo_Pagina;
                       address.Visible = (info.Visible == null) ? false : info.Visible;
                       address.ImageIndex = (info.ImageIndex == null) ? 0 : info.ImageIndex;
                       address.position = (info.position == null) ? 0 : info.position;
                       context.seg_Menu_Grupo.Add(address);
                       context.SaveChanges();
                   }
                   else
                       return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.Message;
               return false;
           }
       }

       public string GetId(ref string MensajeError)
       {
           try
           {
               int Id;
               EntitiesSeguAcceso base_ = new EntitiesSeguAcceso();

               var q = from C in base_.seg_Menu_Grupo
                       select C;

               if (q.ToList().Count == 0)
                   return "G001";
               else
               {

                   var select_ = (from CbtCble in base_.seg_Menu_Grupo
                                  select CbtCble.Codigo_Grupo).Count();
                   Id = select_ + 1;

                   return "G" + Id.ToString();
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }

       public Boolean EliminarDB(seg_Menu_Grupo_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Grupo.FirstOrDefault(tbCbteCble => tbCbteCble.Codigo_Grupo == Info.Codigo_Grupo);
                   if (contact != null)
                   {
                       context.seg_Menu_Grupo.Remove(contact);
                       context.SaveChanges();
                       context.Dispose();
                   }
               }
               return true;
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

       public List<seg_Menu_Grupo_Info> Get_List_Menu_Grupo_ConItem(string CodGrupo)
       {
           try
           {
               List<seg_Menu_Grupo_Info> lista = new List<seg_Menu_Grupo_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Grupo
                           join D in DBBase.seg_Menu_Grupo_x_seg_Menu_Item
                           on new { C.Codigo_Grupo } equals new { D.Codigo_Grupo }
                           where D.Codigo_Grupo == CodGrupo
                           orderby C.position
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Grupo_Info Info = new seg_Menu_Grupo_Info();

                       Info.Codigo = item.Codigo_Grupo;
                       Info.Codigo_Grupo = item.Codigo_Grupo;
                       Info.Descripcion = item.Descripcion;
                       Info.AllowMinimize = item.AllowMinimize;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ShowCaptionButton = item.ShowCaptionButton;
                       Info.Visible = item.Visible;
                       Info.Codigo_Pagina = item.Codigo_Pagina;
                       Info.position = item.position;

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

       public Boolean ModificarDB(seg_Menu_Grupo_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Grupo.FirstOrDefault(dinfo => dinfo.Codigo_Grupo == Info.Codigo_Grupo);
                   if (contact != null)
                   {
                       contact.Descripcion = Info.Descripcion;
                       contact.AllowMinimize = Info.AllowMinimize;
                       contact.Codigo_Pagina = Info.Codigo_Pagina;
                       contact.ImageIndex = Info.ImageIndex;
                       contact.position = Info.position;
                       contact.ShowCaptionButton = Info.ShowCaptionButton;
                       contact.Visible = Info.Visible;
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

       public Boolean Modificar_Posicion_Grupo(seg_Menu_Grupo_Info InfoOrigen, seg_Menu_Grupo_Info InfoDestino, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Grupo.FirstOrDefault(dinfo => dinfo.Codigo_Grupo == InfoOrigen.Codigo_Grupo);
                   if (contact != null)
                   {
                       contact.position = InfoDestino.position;
                       contact.Codigo_Pagina = InfoDestino.Codigo_Pagina;
                       context.SaveChanges();
                   }
               }

               // cambio la posicion del destino con la posi del orige
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Grupo.FirstOrDefault(dinfo => dinfo.Codigo_Grupo == InfoDestino.Codigo_Grupo);
                   if (contact != null)
                   {
                       contact.position = InfoOrigen.position;
                       contact.Codigo_Pagina = InfoOrigen.Codigo_Pagina;
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

   
   }
}

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
   public class seg_Menu_Item_Data
    {
       public List<seg_Menu_Item_Info> Get_List_Menu_Item(string codGrupo)
       {
           try
           {
               List<seg_Menu_Item_Info> lista = new List<seg_Menu_Item_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Item
                           join D in DBBase.seg_Menu_Grupo_x_seg_Menu_Item
                           on new { C.Codigo_Item } equals new { D.Codigo_Item }
                           where D.Codigo_Grupo == codGrupo
                           orderby C.position
                           select C;
                           
                   
                   foreach (var item in q)
                   {
                       seg_Menu_Item_Info Info= new seg_Menu_Item_Info();

                       Info.Codigo_Item = item.Codigo_Item;
                       Info.Descripcion = item.Descripcion;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ItemShortcut = item.ItemShortcut;
                       Info.LargeImageIndex = item.LargeImageIndex;
                       Info.Enabled = item.Enabled;
                       Info.position = item.position;
                       Info.nom_Asembly = item.nom_Asembly;
                       Info.nom_Formulario = item.nom_Formulario;
                       Info.CodReporte = item.CodReporte;
                       Info.Tipo_Item = (eTipo_Item)Enum.Parse(typeof(eTipo_Item), item.IdTipo_Item);
                       Info.Se_muestra_menu_lateral = item.Se_muestra_menu_lateral;
                       Info.Se_muestra_menu_superior = item.Se_muestra_menu_superior;
                       Info.Tipo = item.Tipo;
                       Info.Visible = item.Visible;
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

       public List<seg_Menu_Item_Info> Get_List_Menu_Item()
       {
           try
           {
               List<seg_Menu_Item_Info> lista = new List<seg_Menu_Item_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso()) 
               {
                   var q = from C in DBBase.seg_Menu_Item
                           orderby C.position
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Item_Info Info = new seg_Menu_Item_Info();

                       Info.Codigo_Item = item.Codigo_Item;
                       Info.Descripcion = item.Descripcion;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ItemShortcut = item.ItemShortcut;
                       Info.LargeImageIndex = item.LargeImageIndex;
                       Info.Enabled = item.Enabled;
                       Info.position = item.position;
                       Info.nom_Asembly = item.nom_Asembly;
                       Info.nom_Formulario = item.nom_Formulario;
                       Info.CodReporte = item.CodReporte;
                       Info.Se_muestra_menu_lateral = item.Se_muestra_menu_lateral;
                       Info.Se_muestra_menu_superior = item.Se_muestra_menu_superior;
                       Info.Tipo = item.Tipo;
                       Info.Visible = item.Visible;
                       Info.Tipo_Item = (eTipo_Item)Enum.Parse(typeof(eTipo_Item), item.IdTipo_Item);


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

       public Boolean GrabarDB(seg_Menu_Item_Info info,ref string Id, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                   var Q = from per in EDB.seg_Menu_Item
                           where per.Codigo_Item == info.Codigo_Item
                           select per;

                   if (Q.ToList().Count == 0)
                   {
                       var address = new seg_Menu_Item();

                       
                       address.Codigo_Item = info.Codigo_Item  =  Id =GetId(ref MensajeError);
                       address.Descripcion = (info.Descripcion == null) ? "" : info.Descripcion;
                       address.ImageIndex = (info.ImageIndex == null) ? 0 : info.ImageIndex;
                       address.LargeImageIndex = (info.LargeImageIndex == null) ? 0 : info.LargeImageIndex;
                       address.ItemShortcut = (info.ItemShortcut == null) ? "" : info.ItemShortcut;
                       address.Enabled = (info.Enabled == null) ? false: info.Enabled;
                       address.position = (info.position == null) ? 0 : info.position;
                       address.IdTipo_Item = (info.Tipo_Item == null || info.Tipo_Item==0) ? "barButtonItem" : info.Tipo_Item.ToString();
                       address.CodReporte = info.CodReporte;
                       address.nom_Asembly = info.nom_Asembly;
                       address.nom_Formulario = info.nom_Formulario;
                       address.Se_muestra_menu_lateral = info.Se_muestra_menu_lateral;
                       address.Se_muestra_menu_superior = info.Se_muestra_menu_superior;
                       address.Tipo = info.Tipo;
                       address.Visible = info.Visible;
                       context.seg_Menu_Item.Add(address);
                       context.SaveChanges();
                   }
                   else
                       return false;
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

       public Boolean EliminarDB(seg_Menu_Item_Info Info, ref string MensajeError)
       {
           try
           {
               
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Item.FirstOrDefault(tbCbteCble => tbCbteCble.Codigo_Item == Info.Codigo_Item );
                   if (contact != null)
                   {
                       context.seg_Menu_Item.Remove(contact);
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

       public List<seg_Menu_Item_Info> Get_List_Menu_Item_x_Grupo_x_CodItem(string CodItem)
       {
           try
           {
               List<seg_Menu_Item_Info> lista = new List<seg_Menu_Item_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Item
                           join D in DBBase.seg_Menu_Grupo_x_seg_Menu_Item
                           on new { C.Codigo_Item } equals new { D.Codigo_Item }
                           where D.Codigo_Item == CodItem
                           orderby C.position
                           select C;
                   foreach (var item in q)
                   {
                       seg_Menu_Item_Info Info = new seg_Menu_Item_Info();

                       Info.Codigo_Item = item.Codigo_Item;
                       Info.Descripcion = item.Descripcion;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ItemShortcut = item.ItemShortcut;
                       Info.LargeImageIndex = item.LargeImageIndex;
                       Info.Enabled = item.Enabled;
                       Info.position = item.position;
                       Info.nom_Asembly = item.nom_Asembly;
                       Info.nom_Formulario = item.nom_Formulario;
                       Info.CodReporte = item.CodReporte;
                       Info.Se_muestra_menu_lateral = item.Se_muestra_menu_lateral;
                       Info.Se_muestra_menu_superior = item.Se_muestra_menu_superior;
                       Info.Tipo = item.Tipo;
                       Info.Visible = item.Visible;
                       Info.Tipo_Item = (eTipo_Item)Enum.Parse(typeof(eTipo_Item), item.IdTipo_Item);

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

       public string GetId(ref string MensajeError)
       {
           try
           {
               int Id;
               EntitiesSeguAcceso base_ = new EntitiesSeguAcceso();

               var q = from C in base_.seg_Menu_Item
                       select C;

               if (q.ToList().Count == 0)
                   return "T001";
               else
               {

                   var select_ = (from CbtCble in base_.seg_Menu_Item
                                  select CbtCble.Codigo_Item).Count();
                   Id = select_ + 1;

                   return "T" + Id.ToString("000");
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

       public Boolean Modificar_Posicion_Items(seg_Menu_Item_Info InfoOrigen, seg_Menu_Item_Info InfoDestino, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Item.FirstOrDefault(dinfo => dinfo.Codigo_Item == InfoOrigen.Codigo_Item);
                   if (contact != null)
                   {
                       contact.position = InfoDestino.position;
                       context.SaveChanges();
                   }
               }

               // cambio la posicion del destino con la posi del orige
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Item.FirstOrDefault(dinfo => dinfo.Codigo_Item == InfoDestino.Codigo_Item);
                   if (contact != null)
                   {
                       contact.position = InfoOrigen.position;
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

       public Boolean ModificarDB(seg_Menu_Item_Info Info,  ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Item.FirstOrDefault(dinfo => dinfo.Codigo_Item == Info.Codigo_Item);
                   if (contact != null)
                   {
                       contact.Descripcion = Info.Descripcion;
                       contact.Enabled = Info.Enabled;
                       contact.IdTipo_Item = Info.Tipo_Item.ToString();
                       contact.ImageIndex = Info.ImageIndex;
                       contact.ItemShortcut = Info.ItemShortcut;
                       contact.LargeImageIndex = Info.LargeImageIndex;
                       contact.position = Info.position;
                       contact.CodReporte = Info.CodReporte;
                       contact.nom_Asembly = Info.nom_Asembly;
                       contact.nom_Formulario = Info.nom_Formulario;
                       contact.Se_muestra_menu_lateral = Info.Se_muestra_menu_lateral;
                       contact.Se_muestra_menu_superior = Info.Se_muestra_menu_superior;
                       contact.Tipo = Info.Tipo;
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
    
   }
}

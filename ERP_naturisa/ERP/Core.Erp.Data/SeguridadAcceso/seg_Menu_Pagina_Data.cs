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
   public class seg_Menu_Pagina_Data
    {

       public List<seg_Menu_Pagina_Info> Get_List_Menu_Pagina(string IdCategoria)
       {
           try
           {
               List<seg_Menu_Pagina_Info> lista = new List<seg_Menu_Pagina_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Pagina
                           where C.Codigo_Categoria == IdCategoria
                           orderby C.position
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Pagina_Info Info = new seg_Menu_Pagina_Info();

                       Info.Codigo = item.Codigo_Pagina;
                       Info.Codigo_Pagina = item.Codigo_Pagina;
                       Info.Descripcion = item.Descripcion;
                       Info.Visible = item.Visible;
                       Info.Expanded = item.Expanded;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ImageAlign = item.ImageAlign;
                       Info.Codigo_Categoria = item.Codigo_Categoria;
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

       public List<seg_Menu_Pagina_Info> Get_List_Menu_Pagina_Con_Grupos(string CodPagina)
       {
           try
           {
               List<seg_Menu_Pagina_Info> lista = new List<seg_Menu_Pagina_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Pagina
                           join D in DBBase.seg_Menu_Grupo
                           on new { C.Codigo_Pagina } equals new { D.Codigo_Pagina }
                           where D.Codigo_Pagina == CodPagina
                           orderby C.position
                           select C;

                   

                   foreach (var item in q)
                   {
                       seg_Menu_Pagina_Info Info = new seg_Menu_Pagina_Info();


                       Info.Codigo_Pagina = item.Codigo_Pagina;
                       Info.Descripcion = item.Descripcion;
                       Info.Visible = item.Visible;
                       Info.Expanded = item.Expanded;
                       Info.ImageIndex = item.ImageIndex;
                       Info.ImageAlign = item.ImageAlign;
                       Info.Codigo_Categoria = item.Codigo_Categoria;
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

       public Boolean EliminarDB(seg_Menu_Pagina_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Pagina.FirstOrDefault(tbCbteCble => tbCbteCble.Codigo_Pagina == Info.Codigo_Pagina);
                   if (contact != null)
                   {
                       context.seg_Menu_Pagina.Remove(contact);
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

       public Boolean GrabarDB(seg_Menu_Pagina_Info info, ref string Id, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                   var Q = from per in EDB.seg_Menu_Pagina
                           where per.Codigo_Pagina == info.Codigo_Pagina
                           select per;
                   if (Q.ToList().Count == 0)
                   {
                       var address = new seg_Menu_Pagina();


                       address.Codigo_Pagina = info.Codigo_Pagina = Id = GetId(ref MensajeError);

                       address.Descripcion = (info.Descripcion == null) ? "" : info.Descripcion;
                       address.Visible = (info.Visible == null) ? false : info.Visible;
                       address.Expanded = (info.Expanded == null) ? false : info.Expanded;
                       address.ImageIndex = (info.ImageIndex == null) ? 0 : info.ImageIndex;

                       address.ImageAlign = (info.ImageAlign == null) ? "" : info.ImageAlign;
                       address.Codigo_Categoria = info.Codigo_Categoria;
                       address.position = (info.position == null) ? 0 : info.position;


                       context.seg_Menu_Pagina.Add(address);
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

               var q = from C in base_.seg_Menu_Pagina
                       select C;

               if (q.ToList().Count == 0)
                   return "P001";
               else
               {

                   var select_ = (from CbtCble in base_.seg_Menu_Pagina
                                  select CbtCble.Codigo_Pagina).Count();
                   Id = select_ + 1;

                   return "P" + Id.ToString();
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public Boolean ModificarDB(seg_Menu_Pagina_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Pagina.FirstOrDefault(dinfo => dinfo.Codigo_Pagina == Info.Codigo_Pagina);
                   if (contact != null)
                   {
                       contact.Descripcion = Info.Descripcion;
                       contact.Codigo_Categoria = Info.Codigo_Categoria;
                       contact.Expanded = Info.Expanded;
                       contact.ImageAlign = Info.ImageAlign;
                       contact.ImageIndex= Info.position;
                       contact.position = Info.position;
                       contact.Visible= Info.Visible;

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

       public Boolean Modificar_Posicion_Pagina(seg_Menu_Pagina_Info InfoOrigen, seg_Menu_Pagina_Info InfoDestino, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Pagina.FirstOrDefault(dinfo => dinfo.Codigo_Pagina == InfoOrigen.Codigo_Pagina);
                   if (contact != null)
                   {
                       contact.position = InfoDestino.position;
                       contact.Codigo_Categoria = InfoDestino.Codigo_Categoria; 
                       context.SaveChanges();
                   }
               }

               // cambio la posicion del destino con la posi del orige
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Pagina.FirstOrDefault(dinfo => dinfo.Codigo_Pagina == InfoDestino.Codigo_Pagina);
                   if (contact != null)
                   {
                       contact.position = InfoOrigen.position;
                       contact.Codigo_Categoria = InfoOrigen.Codigo_Categoria; 
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

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
   public class seg_Menu_Categoria_Data
    {

       public List<seg_Menu_Categoria_Info> Get_List_Menu_Categoria()
       {
           try
           {
               List<seg_Menu_Categoria_Info> lista = new List<seg_Menu_Categoria_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Categoria
                           select C;

                   foreach (var item in q)
                   {
                       seg_Menu_Categoria_Info Info = new seg_Menu_Categoria_Info();

                       Info.Codigo = item.Codigo_Categoria;
                       Info.Codigo_Categoria = item.Codigo_Categoria;
                       Info.Descripcion = item.Descripcion;
                       Info.Visible = item.Visible;
                       Info.Expanded = item.Expanded;
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

       public Boolean GrabarDB(seg_Menu_Categoria_Info info,ref string Id, ref string MensajeError)
       {
           try
           {
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                   var Q = from per in EDB.seg_Menu_Categoria
                           where per.Codigo_Categoria == info.Codigo_Categoria
                           select per;
                   if (Q.ToList().Count == 0)
                   {
                       var address = new seg_Menu_Categoria();

                       
                       address.Codigo_Categoria = info.Codigo_Categoria =Id = GetId(ref MensajeError);
                       address.Descripcion = info.Descripcion;
                       address.Expanded = info.Expanded;
                       address.position = info.position;
                       address.Visible=info.Visible;

                       context.seg_Menu_Categoria.Add(address);
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

       public string GetId( ref string MensajeError)
       {
           try
           {
               int Id;
               EntitiesSeguAcceso base_ = new EntitiesSeguAcceso();

               var q = from C in base_.seg_Menu_Categoria
                       select C;

               if (q.ToList().Count == 0)
                   return "M1";
               else
               {

                   var select_ = (from CbtCble in base_.seg_Menu_Categoria
                                  select CbtCble.Codigo_Categoria).Count();
                   Id = select_ + 1;

                   return "M" + Id.ToString();
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

       public List<seg_Menu_Categoria_Info> Get_List_Menu_Categoria_Con_Pagina(string CodCategoria)
       {
           try
           {
               List<seg_Menu_Categoria_Info> lista = new List<seg_Menu_Categoria_Info>();
               using (EntitiesSeguAcceso DBBase = new EntitiesSeguAcceso())
               {

                   var q = from C in DBBase.seg_Menu_Pagina
                           join D in DBBase.seg_Menu_Categoria
                           on new { C.Codigo_Categoria } equals new { D.Codigo_Categoria }
                           where D.Codigo_Categoria == CodCategoria
                           orderby C.position
                           select D;


                   foreach (var item in q)
                   {
                       seg_Menu_Categoria_Info Info = new seg_Menu_Categoria_Info();

                       Info.Codigo = item.Codigo_Categoria;
                       Info.Codigo_Categoria = item.Codigo_Categoria;
                       Info.Descripcion = item.Descripcion;
                       Info.Visible = item.Visible;
                       Info.Expanded = item.Expanded;
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

       public Boolean EliminarDB(seg_Menu_Categoria_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Categoria.FirstOrDefault(tbCbteCble => tbCbteCble.Codigo_Categoria == Info.Codigo_Categoria);
                   if (contact != null)
                   {
                       context.seg_Menu_Categoria.Remove(contact);
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


       public Boolean ModificarDB(seg_Menu_Categoria_Info Info, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Categoria.FirstOrDefault(dinfo => dinfo.Codigo_Categoria == Info.Codigo_Categoria);
                   if (contact != null)
                   {
                       contact.Descripcion = Info.Descripcion;
                       contact.Expanded = Info.Expanded;
                       contact.Expanded = Info.Expanded;
                       contact.position = Info.position;
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

       public Boolean Modificar_Posicion_Categoria(seg_Menu_Categoria_Info InfoOrigen, seg_Menu_Categoria_Info InfoDestino, ref string MensajeError)
       {
           try
           {

               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Categoria.FirstOrDefault(dinfo => dinfo.Codigo_Categoria == InfoOrigen.Codigo_Categoria);
                   if (contact != null)
                   {
                       contact.position = InfoDestino.position;
                       context.SaveChanges();
                   }
               }

               // cambio la posicion del destino con la posi del orige
               using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
               {
                   var contact = context.seg_Menu_Categoria.FirstOrDefault(dinfo => dinfo.Codigo_Categoria == InfoDestino.Codigo_Categoria);
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

   }
}

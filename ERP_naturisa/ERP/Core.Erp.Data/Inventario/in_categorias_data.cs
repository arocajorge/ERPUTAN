using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
// Version 1.0 23/04/2013  1701
namespace Core.Erp.Data.Inventario
{
   public class in_categorias_data
   {
       string mensaje = "";
       public List<in_categorias_Info> Get_List_categorias(int IdEmpresa)
       {
           try
           {
               in_categorias_Info Categoria_info = new in_categorias_Info();
               List<in_categorias_Info> ListadoCategoris = new List<in_categorias_Info>();
               EntitiesInventario OECbtecble_Info = new EntitiesInventario();
               var selectCbtecble = from C in OECbtecble_Info.in_categorias
                                    where C.IdEmpresa == IdEmpresa
                                    select C;

               //Categoria_info.IdCategoria="000";
               //Categoria_info.ca_Categoria = "TODOS";
               //ListadoCategoris.Add(Categoria_info);
               foreach (var item in selectCbtecble)
               {
                   Categoria_info = new in_categorias_Info();
                   Categoria_info.IdCategoria = item.IdCategoria;
                   Categoria_info.ca_nivel = item.ca_nivel;
                   Categoria_info.IdCategoriaPadre = item.IdCategoriaPadre;
                   Categoria_info.ca_Categoria = item.ca_Categoria;
                   Categoria_info.ca_indexIcono = item.ca_indexIcono;
                   Categoria_info.ca_Posicion = item.ca_Posicion;
                   Categoria_info.IdEmpresa = item.IdEmpresa;
                   Categoria_info.Estado = item.Estado;
                   Categoria_info.RutaPadre = item.RutaPadre;
                   Categoria_info.ca_nivel = item.ca_nivel;
                   Categoria_info.IdCtaCtble_Costo = item.IdCtaCtble_Costo;
                   Categoria_info.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                   Categoria_info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                   Categoria_info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                   Categoria_info.ca_Categoria2 = "[" + item.IdCategoria + "] " + item.ca_Categoria;


                   
                   ListadoCategoris.Add(Categoria_info);
               }
               return (ListadoCategoris);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GrabarDB(int IdEmpresa, in_categorias_Info info,ref string msg)
       {
           try
           {
               
               using (EntitiesInventario context = new EntitiesInventario())
               {
                   EntitiesInventario EDB = new EntitiesInventario();

                   
                   var Q = from per in EDB.in_categorias
                           where per.IdEmpresa == IdEmpresa && per.IdCategoria == info.IdCategoria 
                           select per;

                   if (Q.ToList().Count == 0)
                   {
                   
                       in_categorias address = new in_categorias();

                       
                       address.IdEmpresa = info.IdEmpresa;
                       address.IdCategoria = info.IdCategoria=(info.IdCategoria == null || info.IdCategoria == "" || info.IdCategoria == "0") ? getIdCategoria(info.IdEmpresa).ToString() : info.IdCategoria.Trim();
                       address.ca_Categoria = info.ca_Categoria.Trim();
                       address.IdCategoriaPadre = info.IdCategoriaPadre;
                       address.ca_Posicion = info.ca_Posicion;
                       address.ca_indexIcono = info.ca_indexIcono;
                       address.Estado = info.Estado;
                       address.ca_nivel = info.ca_nivel;
                       address.RutaPadre = (info.RutaPadre == null) ? "" : info.RutaPadre;
                       address.IdCtaCtble_Inve = info.IdCtaCtble_Inve;
                       address.IdCtaCtble_Costo = info.IdCtaCtble_Costo;
                       address.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;
                       address.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                       address.IdUsuario = (info.IdUsuario == null) ? "SysAdmin" : info.IdUsuario;
                       address.Fecha_Transac = DateTime.Now;
                       address.cod_categoria = info.cod_categoria;
                    
                       context.in_categorias.Add(address);
                       context.SaveChanges();

                       msg = "Grabacion ok..";
                   }
                   
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(int IdEmpresa, in_categorias_Info info, ref string msg)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {
                    var contact = context.in_categorias.FirstOrDefault(cat => cat.IdEmpresa == IdEmpresa && cat.IdCategoria == info.IdCategoria);
                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCategoria = info.IdCategoria;
                        contact.ca_Categoria = info.ca_Categoria;
                        contact.IdCategoriaPadre = info.IdCategoriaPadre;
                        contact.ca_Posicion = info.ca_Posicion;
                        contact.ca_indexIcono = info.ca_indexIcono;
                        contact.Estado = info.Estado;
                        contact.ca_nivel = info.ca_nivel;
                        contact.RutaPadre = info.RutaPadre;

                        contact.IdCtaCtble_Inve = info.IdCtaCtble_Inve;
                        contact.IdCtaCtble_Costo = info.IdCtaCtble_Costo;

                        contact.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;
                        contact.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                        contact.cod_categoria = info.cod_categoria;

                        context.SaveChanges();

                        msg = "Se actualizó la categoría con ID # " + info.IdCategoria;
                    }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
            throw new Exception(ex.ToString());}
       }

       public Boolean AnularDB(in_categorias_Info info, ref string msg)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {
                   var contact = context.in_categorias.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdCategoria == info.IdCategoria);
                   if (contact != null)
                   {
                       contact.Estado = "I";
                       contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                       contact.Fecha_UltAnu = info.Fecha_UltAnu;
                       contact.MotiAnula = info.MotiAnula;

                       context.SaveChanges();

                       msg = "Anulación ok..";
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public int getIdCategoria(int IdEmpresa)
       {

           try
           {
               int IdCategoria = 0;
               EntitiesInventario ODATA = new EntitiesInventario();
               var selecte = ODATA.in_categorias.Count(q => q.IdEmpresa == IdEmpresa );
               if (selecte == 0)
               {
                   IdCategoria = 1;
               }
               else
               {
                   ODATA = new EntitiesInventario();
                   var selectCategoria = (from linea in ODATA.in_categorias
                                      where linea.IdEmpresa == IdEmpresa
                                      select linea.IdCategoria).Count();

                   IdCategoria = Convert.ToInt32(selectCategoria.ToString()) + 1;
               }
               return IdCategoria;


               
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public in_categorias_Info Get_Info_categorias(int IdEmpresa, string IdCategoria)
	    {
			EntitiesInventario oEnti= new EntitiesInventario();
		    try
		    {
                in_categorias_Info Info = new in_categorias_Info() ;
			    var Objeto = oEnti.in_categorias.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdCategoria == IdCategoria);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdCategoria = Objeto.IdCategoria;
                    Info.ca_Categoria = Objeto.ca_Categoria;
                    Info.IdCategoriaPadre = Objeto.IdCategoriaPadre;
                    Info.ca_Posicion = Objeto.ca_Posicion;
                    Info.ca_indexIcono = Objeto.ca_indexIcono;
                    Info.Estado = Objeto.Estado;
                    Info.ca_nivel = Objeto.ca_nivel;
                    Info.RutaPadre = Objeto.RutaPadre;
                    Info.IdCtaCtble_Inve = Objeto.IdCtaCtble_Inve;
                    Info.IdCtaCtble_Costo = Objeto.IdCtaCtble_Costo;
                    Info.IdCentro_Costo_Costo = Objeto.IdCentro_Costo_Costo;
                    Info.IdCentro_Costo_Inventario = Objeto.IdCentro_Costo_Inventario;
                    Info.cod_categoria = Objeto.cod_categoria;
                }
			    return Info;
			}
		    catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public string Get_IdCategoria(int IdEmpresa, string Nom_Categoria)
       {
           EntitiesInventario oEnti = new EntitiesInventario();
           try
           {
               string IdCategoria = "";

               var Objeto = oEnti.in_categorias.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.ca_Categoria == Nom_Categoria);
               if (Objeto != null)
               {
                   IdCategoria = Objeto.IdCategoria;
               }
               return IdCategoria;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
    }
}

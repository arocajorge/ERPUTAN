using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class in_movi_inven_tipo_x_tb_bodega_Data
    {
       string mensaje = "";

       

       public Boolean ModificarDB(in_movi_inven_tipo_x_tb_bodega_Info lst, int IdEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
       {

           try
           {
               EntitiesInventario oege = new EntitiesInventario();

               using (EntitiesInventario contex = new EntitiesInventario())
               {
                   var address = new in_movi_inven_tipo_x_tb_bodega();
                   address.IdBodega = lst.IdBodega;
                   address.IdEmpresa = IdEmpresa;
                   address.IdCtaCble = lst.IdCtaCble;
                   address.IdMovi_inven_tipo = moviI.IdMovi_inven_tipo;
                   address.IdSucucursal = lst.IdSucucursal;
                   contex.in_movi_inven_tipo_x_tb_bodega.Add(address);
                   contex.SaveChanges();
                   contex.Dispose();
                   mensaje = "Guardado con exito";
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               mensaje = "Error ocurrido por: " + ex.ToString();
               throw new Exception(mensaje);
           }
       }

       public Boolean GrabarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, int idEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
       {
           try
           {
               foreach (var item in lst)
               {
                   GrabarDB(item, idEmpresa, moviI, ref mensaje);
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
               mensaje = "Error ocurrido por: " + ex.ToString().ToString();
               throw new Exception(mensaje);
           }
       }

       public Boolean GrabarDB(in_movi_inven_tipo_x_tb_bodega_Info lst, int idEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
       {
           try
           {
               EntitiesInventario oege = new EntitiesInventario();

               using (EntitiesInventario contex = new EntitiesInventario())
               {

                   var address = new in_movi_inven_tipo_x_tb_bodega();
                   address.IdBodega = lst.IdBodega;
                   address.IdEmpresa = idEmpresa;
                   if (lst.IdCtaCble != "")
                       address.IdCtaCble = lst.IdCtaCble;
                   address.IdMovi_inven_tipo = moviI.IdMovi_inven_tipo;
                   address.IdSucucursal = lst.IdSucucursal;


                   contex.in_movi_inven_tipo_x_tb_bodega.Add(address);
                   contex.SaveChanges();
                   contex.Dispose();

                   mensaje = "Guardado con exito";
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;

               try
               {
                   using (EntitiesInventario contex = new EntitiesInventario())
                   {
                       in_movi_inven_tipo_x_tb_bodega Consulta = new in_movi_inven_tipo_x_tb_bodega();
                       Consulta = contex.in_movi_inven_tipo_x_tb_bodega.FirstOrDefault(v => v.IdEmpresa == idEmpresa && v.IdSucucursal == lst.IdSucucursal && v.IdBodega == lst.IdBodega && v.IdMovi_inven_tipo == moviI.IdMovi_inven_tipo);
                       if (Consulta != null)
                       {
                           Consulta.IdCtaCble = lst.IdCtaCble;
                           contex.SaveChanges();
                       }
                       return true;
                   }
               }
               catch (Exception)
               {
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.ToString() + " " + ex.Message;
                   throw new Exception(mensaje);
               }
           }
       }

       public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_list_movi_inven_tipo_x_tb_bodega(int IdEmpresa)
       {

           try
           {
               List<in_movi_inven_tipo_x_tb_bodega_Info> ln = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
               EntitiesGeneral OEBodegaxSucursal = new EntitiesGeneral();

               var select = from c in OEBodegaxSucursal.tb_sucursal
                            join b in OEBodegaxSucursal.tb_bodega
                            on new { c.IdEmpresa, c.IdSucursal } equals new { b.IdEmpresa, b.IdSucursal }
                            where b.IdEmpresa == IdEmpresa
                            select new { c.Su_Descripcion, c.IdSucursal, b.bo_Descripcion, b.IdBodega };

               foreach (var item in select)
               {
                   in_movi_inven_tipo_x_tb_bodega_Info lst = new in_movi_inven_tipo_x_tb_bodega_Info();
                   lst.Bodega = item.bo_Descripcion;
                   lst.Sucursal = item.Su_Descripcion;
                   lst.IdBodega = item.IdBodega;
                   lst.IdSucucursal = item.IdSucursal;
                   ln.Add(lst);
               }
               return (ln);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }


       }

       public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_List_movi_inven_tipo_x_tb_bodega(in_movi_inven_tipo_Info moviI)
       {
           try
           {
               List<in_movi_inven_tipo_x_tb_bodega_Info> listado = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
               EntitiesInventario oEnt = new EntitiesInventario();
               var lista = from C in oEnt.in_movi_inven_tipo_x_tb_bodega
                           where C.IdEmpresa == moviI.IdEmpresa
                           && C.IdMovi_inven_tipo == moviI.IdMovi_inven_tipo
                           select C;
               foreach (var item in lista)
               {
                   in_movi_inven_tipo_x_tb_bodega_Info info = new in_movi_inven_tipo_x_tb_bodega_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucucursal = item.IdSucucursal;
                   info.IdBodega = item.IdBodega;
                   info.IdCtaCble = item.IdCtaCble;
                   info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   listado.Add(info);
               }

               return listado;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_List_movi_inven_tipo_x_tb_bodega(int idEmpresa, in_movi_inven_tipo_Info IdMovi_inven_tipo, int IdSucursal)
       {
           List<in_movi_inven_tipo_x_tb_bodega_Info> lst = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
           EntitiesInventario OEInvet = new EntitiesInventario();
           EntitiesGeneral OEGen = new EntitiesGeneral();
           try
           {
               var c = from q in OEInvet.in_movi_inven_tipo_x_tb_bodega
                       where q.IdEmpresa == idEmpresa && q.IdMovi_inven_tipo == IdMovi_inven_tipo.IdMovi_inven_tipo
                       && q.IdSucucursal == IdSucursal
                       select q;

               foreach (var item in c)
               {
                   in_movi_inven_tipo_x_tb_bodega_Info movibI = new in_movi_inven_tipo_x_tb_bodega_Info();
                   movibI.IdBodega = item.IdBodega;
                   movibI.IdCtaCble = item.IdCtaCble;
                   movibI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   movibI.IdSucucursal = item.IdSucucursal;
                   lst.Add(movibI);
               }
               return lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }



       public in_movi_inven_tipo_x_tb_bodega_Info Get_Info_movi_inven_tipo_x_tb_bodega(int IdEmpresa, int IdSucursal ,int IdBodega, int IdMovi_inven_tipo)
       {
          try
           {
               EntitiesInventario OEInvet = new EntitiesInventario();
               in_movi_inven_tipo_x_tb_bodega_Info movibI = new in_movi_inven_tipo_x_tb_bodega_Info();


               var c = from q in OEInvet.in_movi_inven_tipo_x_tb_bodega
                       where q.IdEmpresa == IdEmpresa
                       && q.IdSucucursal == IdSucursal
                       && q.IdBodega == IdBodega
                       && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                       select q;

               foreach (var item in c)
               {
                   movibI.IdEmpresa = item.IdEmpresa;
                   movibI.IdSucucursal = item.IdSucucursal;
                   movibI.IdBodega = item.IdBodega;
                   movibI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   movibI.IdCtaCble = item.IdCtaCble;
               }
               return movibI;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public Boolean ModificarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, int idEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
       {
           try
           {
               //  eliminarregistrotabla(lst, idEmpresa, moviI, ref mensaje);
               GrabarDB(lst, idEmpresa, moviI, ref mensaje);
               mensaje = "Acualizado Correctamente";
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               mensaje = "Error ocurrido por: " + ex.ToString();
               throw new Exception(mensaje);
           }
       }

       public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_List_movi_inven_tipo_x_tb_bodega(int IdEmpresa, int IdMoviInvenTipo)
       {
           try
           {
               EntitiesInventario Oen = new EntitiesInventario();

               string Querty = "select * from in_movi_inven_tipo_x_tb_bodega WHERE IdEmpresa =" + IdEmpresa + " and IdMovi_inven_tipo =" + IdMoviInvenTipo;

               return Oen.Database.SqlQuery<in_movi_inven_tipo_x_tb_bodega_Info>(Querty).ToList();
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public Boolean GrabarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, ref string mensaje)
       {
           try
           {
               foreach (var item in lst)
               {
                   using (EntitiesInventario contex = new EntitiesInventario())
                   {
                       var address = new in_movi_inven_tipo_x_tb_bodega();
                       address.IdBodega = item.IdBodega;
                       address.IdEmpresa = item.IdEmpresa;
                       address.IdCtaCble = item.IdCtaCble;
                       address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                       address.IdSucucursal = item.IdSucucursal;
                       contex.in_movi_inven_tipo_x_tb_bodega.Add(address);
                       contex.SaveChanges();
                       contex.Dispose();
                       mensaje = "Guardado con exito";
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
               mensaje = ex.Message + "::::::::::::::::::::" + ex.ToString();
               throw new Exception(mensaje);
           }

       }

       public Boolean ModificarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, ref string mensaje)
       {
           try
           {
               foreach (var item in lst)
               {
                   using (EntitiesInventario contex = new EntitiesInventario())
                   {
                       var address = contex.in_movi_inven_tipo_x_tb_bodega.FirstOrDefault(v => v.IdBodega == item.IdBodega && v.IdSucucursal == item.IdSucucursal && v.IdEmpresa == item.IdEmpresa && v.IdMovi_inven_tipo == item.IdMovi_inven_tipo);
                       if (address != null)
                       {
                           address.IdBodega = item.IdBodega;
                           address.IdEmpresa = item.IdEmpresa;
                           address.IdCtaCble = item.IdCtaCble;
                           address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                           address.IdSucucursal = item.IdSucucursal;
                           contex.SaveChanges();
                           contex.Dispose();
                           mensaje = "Guardado con exito";
                       }
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
               mensaje = ex.Message + "::::::::::::::::::::" + ex.ToString();
               throw new Exception(mensaje);
           }
       }
    }
}

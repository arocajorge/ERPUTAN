using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
   public class vwin_Ingr_Egr_Inven_det_Bus
    {
       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       vwin_Ing_Egr_Inven_det_Data odata = new vwin_Ing_Egr_Inven_det_Data();
       in_Ing_Egr_Inven_Bus busIng_Egr_Inv = new in_Ing_Egr_Inven_Bus();

       public List<vwin_Ing_Egr_Inven_det_Info> Get_List_in_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, string IdEstadoAproba)
       {
           try
           {
               return odata.Get_List_in_Ing_Egr_Inven_det(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdEstadoAproba);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrVariosDet", ex.Message), ex) { EntityType = typeof(vwin_Ingr_Egr_Inven_det_Bus) };              
           }                   
       }

       public List<vwin_Ing_Egr_Inven_det_Info> Get_List_in_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, string IdEstadoAproba, DateTime Fecha_ini, DateTime Fecha_fin)
       {
           try
           {
               return odata.Get_List_in_Ing_Egr_Inven_det(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdEstadoAproba,Fecha_ini,Fecha_fin);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrVariosDet", ex.Message), ex) { EntityType = typeof(vwin_Ingr_Egr_Inven_det_Bus) };
           }
       }

       public Boolean Modificar_Estado_IngEgr_Det(List<in_Ing_Egr_Inven_det_Info> lista, string tipo, ref string msgs)
       {
           try
           {
               Boolean res = true;
               if (Validar_objeto_IngEgr_Det(lista, ref  msgs))
               {
                   List<in_Ing_Egr_Inven_det_Info> listaAprobados = new List<in_Ing_Egr_Inven_det_Info>();
                   listaAprobados = lista.Where(q => q.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString()).ToList();

                   if (listaAprobados.Count() > 0)
                   {
                       var ingEgr_cab = from ing_ in listaAprobados
                                        group ing_ by new
                                        {
                                            ing_.IdEmpresa,
                                            ing_.IdSucursal,
                                            ing_.IdBodega,
                                            ing_.IdMovi_inven_tipo,
                                            ing_.IdNumMovi
                                        }
                                            into grouping
                                            select new { grouping.Key };

                       foreach (var item in ingEgr_cab)
                       {
                           in_Ing_Egr_Inven_Info info_in_Ing_Egr = new in_Ing_Egr_Inven_Info();

                           info_in_Ing_Egr = busIng_Egr_Inv.Get_Info_Ing_Egr_Inven(item.Key.IdEmpresa, item.Key.IdSucursal, item.Key.IdMovi_inven_tipo, item.Key.IdNumMovi);
                           info_in_Ing_Egr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                           info_in_Ing_Egr.listIng_Egr = lista.Where(q => q.IdEmpresa == item.Key.IdEmpresa && q.IdSucursal == item.Key.IdSucursal
                                                                        && q.IdMovi_inven_tipo == item.Key.IdMovi_inven_tipo
                                                                        && q.IdNumMovi == item.Key.IdNumMovi
                                                                        && q.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString()).ToList();


                           busIng_Egr_Inv.procesoGenerarMoviInve(info_in_Ing_Egr, item.Key.IdNumMovi,ref mensaje);
                       }
                   }
                   res= odata.Modificar_Estado_IngEgr_Det(lista, tipo, ref  msgs);
               }
               else
               {
                   res = false;                  
               }
               return res;
                             
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_IngEgr_Det", ex.Message), ex) { EntityType = typeof(vwin_Ingr_Egr_Inven_det_Bus) };

           }
      
       }

       public Boolean Validar_objeto_IngEgr_Det(List<in_Ing_Egr_Inven_det_Info> lista, ref string msg)
       {
           try
           {
               
               if (lista.Count == 0 || lista.Count == null)
               {
                   msg = "No existen detalles a Actualizar o No ha seleccionado algún item ";
                   return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_IngEgr_Det", ex.Message), ex) { EntityType = typeof(vwin_Ingr_Egr_Inven_det_Bus) };


           }

       }
    }
}

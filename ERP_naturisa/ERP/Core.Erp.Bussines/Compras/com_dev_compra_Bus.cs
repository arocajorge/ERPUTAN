using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;






namespace Core.Erp.Business.Compras
{
   public  class com_dev_compra_Bus
    {
       com_dev_compra_Data Odata = new com_dev_compra_Data();
       com_dev_compra_det_Bus Odata_det = new com_dev_compra_det_Bus();

       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       in_movi_inve_Bus MoviInven = new in_movi_inve_Bus();
       com_parametro_Bus ParamComBus = new com_parametro_Bus();
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       com_parametro_Info paramInfo = new com_parametro_Info();

       

       string mensaje = "";

       public com_dev_compra_Bus()
       {

       }

       public List<com_dev_compra_Info> Get_List_dev_compra(int idempresa, int idsucursal, DateTime fechaIni, DateTime fechaFin)
       {
           try
           {
               List<com_dev_compra_Info> lista = new List<com_dev_compra_Info>();
               lista = Odata.Get_List_dev_compra(idempresa,idsucursal,fechaIni,fechaFin);
       
               return lista;


           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_dev_compra", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
               
           }
       }

       public com_dev_compra_Info Get_Info_dev_compra(int IdEmpresa, int IdSucursal, decimal IdDevCompra)
       {
           try
           {
               com_dev_compra_Info oItem = new com_dev_compra_Info();

               oItem=Odata.Get_Info_dev_compra(IdEmpresa, IdSucursal, IdDevCompra);

               return oItem;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_dev_compra", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
               
           }

       }


       private Boolean validar_objeto(com_dev_compra_Info Info, ref string mensaje1)
       {
           try
           {
               if (Info.IdEmpresa == 0 && Info.IdSucursal == 0 && Info.IdBodega == 0)
               {
                   mensaje1 = "Hay un error en el Idempresa=" + Info.IdEmpresa + " IdSucursal=" + Info.IdSucursal + " IdBodega=" + Info.IdBodega;
                   return false;
               }

               if (Info.lista_detalle.Count == 0)
               {
                   mensaje1 = "No tiene detalles";
                   return false;
               }



               foreach (var item in Info.lista_detalle)
               {
                   item.IdEmpresa = Info.IdEmpresa;
                   item.IdSucursal = Info.IdSucursal;
                   item.IdBodega = Info.IdBodega;
                   item.IdDevCompra = Info.IdDevCompra;
               }


               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
           }
       }

       public Boolean GuardarDB(com_dev_compra_Info Info, ref decimal id, ref string mensaje1)
       {
           try
           {
              Boolean resGrabar=false;
               in_movi_inve_Info InfoMoviInve= new in_movi_inve_Info();
               decimal IdMoviInven=0;
               string msg_cbte="";
               string msg="";

              if (validar_objeto(Info, ref mensaje1))
              {
                  resGrabar = Odata.GuardarDB(Info, ref id, ref mensaje1);

                  if (resGrabar)
                  {
                      resGrabar = Odata_det.GuardarDB(Info.lista_detalle, ref mensaje1);

                      paramInfo=ParamComBus.Get_Info_parametro(param.IdEmpresa);



                      InfoMoviInve.IdEmpresa = Info.IdEmpresa;
                      InfoMoviInve.IdSucursal = Info.IdSucursal;
                      InfoMoviInve.IdBodega = Info.IdBodega;
                      InfoMoviInve.cm_anio = Info.dv_fecha.Year;
                      InfoMoviInve.cm_fecha = Info.dv_fecha;
                      InfoMoviInve.cm_mes = Info.dv_fecha.Month;
                      InfoMoviInve.cm_observacion = Info.dv_observacion;
                      InfoMoviInve.cm_tipo="+";
                      InfoMoviInve.Estado = "A";
                      InfoMoviInve.IdMovi_inven_tipo = paramInfo.IdMovi_inven_tipo_dev_compra;
                      InfoMoviInve.IdNumMovi=0;
                      InfoMoviInve.IdProvedor = Info.IdProveedor;
                      InfoMoviInve.IdUsuario = param.IdUsuario;
                      InfoMoviInve.IdUsuarioUltModi = Info.IdUsuarioUltMod;
                      InfoMoviInve.ip = param.ip;
                      InfoMoviInve.nom_pc = param.nom_pc;
                      InfoMoviInve.CodMoviInven = "DEVxCOM";


                      InfoMoviInve.listmovi_inve_detalle_Info = new List<in_movi_inve_detalle_Info>();

                      foreach (var item in Info.lista_detalle)
                      {
                          in_movi_inve_detalle_Info ItemInfo= new in_movi_inve_detalle_Info();


                          ItemInfo.cm_fecha = InfoMoviInve.cm_fecha;
                          ItemInfo.CodMoviInven = InfoMoviInve.CodMoviInven;
                          ItemInfo.dm_cantidad = item.dv_Cantidad;
                          ItemInfo.dm_observacion = item.dv_observacion;
                          ItemInfo.dm_precio = item.dv_precioCompra;
                          ItemInfo.dm_stock_actu = 0;
                          ItemInfo.dm_stock_ante = 0;
                          ItemInfo.IdBodega = item.IdBodega;
                          ItemInfo.IdEmpresa = item.IdEmpresa;
                          ItemInfo.IdMovi_inven_tipo = InfoMoviInve.IdMovi_inven_tipo;
                          ItemInfo.IdNumMovi = InfoMoviInve.IdNumMovi;
                          ItemInfo.IdProducto = item.IdProducto;
                          ItemInfo.IdSucursal = item.IdSucursal;
                          ItemInfo.mv_costo = 0;
                          ItemInfo.mv_tipo_movi = InfoMoviInve.cm_tipo;
                          ItemInfo.peso = item.dv_peso;
                          ItemInfo.Secuencia = item.Secuencia;
                          ItemInfo.mv_costo = item.dv_precioCompra;
                          InfoMoviInve.listmovi_inve_detalle_Info.Add(ItemInfo);
                          
                      }
                      


                    resGrabar=  MoviInven.GrabarDB(InfoMoviInve, ref IdMoviInven, ref msg_cbte, ref msg, true);


                  }
              }
              else
              {
                  resGrabar = false;
              }

               return resGrabar;


           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
           }
       }

       public Boolean ModificarDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {

               Boolean resGrabar = false;

               if (validar_objeto(Info, ref msg))
               {

                   if (Info.IdDevCompra > 0)
                   {

                       resGrabar = Odata.ModificarDB(Info, ref msg);

                       if (resGrabar)
                       {

                           resGrabar = Odata_det.EliminarDetalle(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdDevCompra, ref msg);
                           resGrabar = Odata_det.GuardarDB(Info.lista_detalle, ref msg);
                       }
                   }
                   else
                   {
                       msg = "No se puede actualizar por que no hay iddevolucion en compra";
                       resGrabar = false;
                   }
               }
               else
               {
                   resGrabar = false;
               }

               
               

               return resGrabar;

           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
               
           }

       }

       public decimal getId(int idempresa, int idsucursal)
       {
           try
           {
               return Odata.GetId(idempresa, idsucursal);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
           }

       }


       public Boolean AnularDB(com_dev_compra_Info Info, ref  string msg)
       {
           try
           {
               return Odata.AnularDB(Info, ref msg);


           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_dev_compra_Bus) };
               
           }
       }

    }


}

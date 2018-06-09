using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Business.Compras
{
  public  class com_solicitud_compra_Bus
  {
      #region Declaración de Variables
      string mensaje = "";
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
      com_solicitud_compra_Data odata = new com_solicitud_compra_Data();
      string msg = "";
      #endregion
      
      public Boolean AnularDB(com_solicitud_compra_Info info,ref string msg)
      {
          try
          {
              return odata.AnularDB(info,ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }
      
      public Boolean GuardarDB(com_solicitud_compra_Info info, ref string msg)
      {
          try
          {
              Boolean res = true;

              if (validarObjeto(info, ref msg))
              {
                  odata.GuardarDB(info);

              #region grabar en tabla com_solicitud_compra_det_aprobacion
                
                // consultar el detalle solicitud

                  com_solicitud_compra_det_Bus bus_DetSol = new com_solicitud_compra_det_Bus();
                  List<com_solicitud_compra_det_Info> lisDetSol = new List<com_solicitud_compra_det_Info>();
                  lisDetSol = bus_DetSol.Get_list_DetalleLstSolicitudCompra(info.IdEmpresa,info.IdSucursal,info.IdSolicitudCompra);

                  if (lisDetSol.Count()==0)
                  { res= false; }

                  List<com_solicitud_compra_det_aprobacion_Info> listDetApr = new List<com_solicitud_compra_det_aprobacion_Info>();

                  List<com_solicitud_compra_det_pre_aprobacion_Info> listDetPreApr = new List<com_solicitud_compra_det_pre_aprobacion_Info>();
                  
                  foreach (var item in lisDetSol)
                  {
                      com_solicitud_compra_det_aprobacion_Info infoDetApr = new com_solicitud_compra_det_aprobacion_Info();
                      infoDetApr.Checked = true;
                      infoDetApr.IdEmpresa = item.IdEmpresa;
                      infoDetApr.IdSucursal_SC = item.IdSucursal;
                      infoDetApr.IdSolicitudCompra = item.IdSolicitudCompra;
                      infoDetApr.Secuencia_SC = item.Secuencia;
                      infoDetApr.IdProducto_SC = item.IdProducto;
                      infoDetApr.NomProducto_SC = item.NomProducto;
                      infoDetApr.Cantidad_aprobada = item.do_Cantidad;

                      com_parametro_Bus bus_param = new com_parametro_Bus();
                      com_parametro_Info info_param = new com_parametro_Info();
                      info_param = bus_param.Get_Info_parametro(item.IdEmpresa);

                      infoDetApr.IdEstadoAprobacion = info_param.IdEstadoAprobacion_SolCompra;

                      infoDetApr.IdProveedor_SC = null;
                      infoDetApr.IdUsuarioAprueba = param.IdUsuario;
                      infoDetApr.FechaHoraAprobacion = param.Fecha_Transac;
                      infoDetApr.do_observacion = "El item: " + item.NomProducto + ", con ID: " + item.IdProducto + " y cantidad: " + item.do_Cantidad + ", fue grabado con estado : " + infoDetApr.IdEstadoAprobacion + "";
                  
                      listDetApr.Add(infoDetApr);


                      //preaprobacion

                      com_solicitud_compra_det_pre_aprobacion_Info infoDetPreApr = new com_solicitud_compra_det_pre_aprobacion_Info();
                      infoDetPreApr.IdEmpresa = item.IdEmpresa;
                      infoDetPreApr.IdSucursal_SC = item.IdSucursal;
                      infoDetPreApr.IdSolicitudCompra = item.IdSolicitudCompra;
                      infoDetPreApr.Secuencia_SC = item.Secuencia;
                      infoDetPreApr.IdEstadoAprobacion = info_param.IdEstadoAprobacion_SolCompra;
                      infoDetPreApr.IdUsuarioAprueba = param.IdUsuario;
                      infoDetPreApr.FechaHoraAprobacion = DateTime.Now;
                      infoDetPreApr.observacion = "**Pendiente**";

                      listDetPreApr.Add(infoDetPreApr);

                  }

                  com_solicitud_compra_det_aprobacion_Bus Bus_DetAproba = new com_solicitud_compra_det_aprobacion_Bus();
                  string validaMotivo = "";
                  if (Bus_DetAproba.Validar_objeto_AprobSolComp(listDetApr,  validaMotivo, ref  msg))
                  {
                      com_solicitud_compra_det_aprobacion_Data odataDetApr = new com_solicitud_compra_det_aprobacion_Data();
                      odataDetApr.GuardarDB(listDetApr);


                      com_solicitud_compra_det_pre_aprobacion_Data odataDetPreApr = new com_solicitud_compra_det_pre_aprobacion_Data();
                      odataDetPreApr.GuardarDB(listDetPreApr);
                  
                  }
                             
              #endregion

              #region grabar en tabla in_producto_x_tb_bodega

                  // 1. obtener el detalle solicitud compra

                  com_solicitud_compra_det_Bus bus_DetSoli = new com_solicitud_compra_det_Bus();
                  List<com_solicitud_compra_det_Info> listDetSoli = new List<com_solicitud_compra_det_Info>();
                  listDetSoli = bus_DetSoli.Get_list_DetalleLstSolicitudCompra(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra);

                 // 2. recorro el detalle solicitud
                  foreach (var item in lisDetSol)
                  {
                      in_producto_x_tb_bodega_Data DataInserte = new in_producto_x_tb_bodega_Data();
                     
                    // 3. Obtengo bodega Sucursal

                      int IdBodega = 0;
                    
                      tb_Bodega_Bus bus_Bodega = new tb_Bodega_Bus();
                      List<tb_Bodega_Info> listBod = new List<tb_Bodega_Info>();
                      listBod = bus_Bodega.Get_List_Bodega(item.IdEmpresa,item.IdSucursal);

                      if (listBod.Count() == 0)
                      {
                          // crear bodega Sucursal
                          tb_Bodega_Info infoBodega = new tb_Bodega_Info();
                          infoBodega.IdEmpresa = item.IdEmpresa;
                          infoBodega.IdSucursal = item.IdSucursal;
                          infoBodega.bo_Descripcion = "Bodega Principal";
                          infoBodega.Fecha_Transac = param.Fecha_Transac;

                         
                          int id=0;
                          string msg1="";
                          bus_Bodega.GrabarDB(infoBodega, ref id, ref msg1);
                          IdBodega = id;
                      }
                      else
                      {
                          tb_Bodega_Info infoBod = listBod.FirstOrDefault();
                          IdBodega = infoBod.IdBodega;                     
                      }
                                                                                 
                      //// 4. Verifico producto (in_producto_x_tb_bodega) 
                      //if (!DataInserte.VerificarExisteProductoXSucursalXBodega(item.IdEmpresa, item.IdSucursal, IdBodega, Convert.ToDecimal(item.IdProducto)))
                      //{
                      //    // 5. Obtengo producto (in_Producto)
                      //    in_Producto_data odataP = new in_Producto_data();
                      //    in_Producto_Info infoPro = new in_Producto_Info();
                      //    infoPro = odataP.BuscarProducto(Convert.ToDecimal(item.IdProducto), item.IdEmpresa);

                      //    in_producto_x_tb_bodega_Info infoProxBod = new in_producto_x_tb_bodega_Info();

                      //    infoProxBod.IdEmpresa = item.IdEmpresa;
                      //    infoProxBod.IdSucursal = item.IdSucursal;
                      //    infoProxBod.IdBodega = IdBodega;
                      //    infoProxBod.IdProducto = Convert.ToDecimal(item.IdProducto);
                      //    infoProxBod.pr_precio_publico = infoPro.pr_precio_publico;
                      //    infoProxBod.pr_precio_mayor = infoPro.pr_precio_mayor;
                      //    infoProxBod.pr_precio_puerta = 0;
                      //    infoProxBod.pr_precio_minimo = infoPro.pr_precio_minimo;
                      //    infoProxBod.pr_Por_descuento = infoPro.Porc_Descuento;
                      //    infoProxBod.pr_stock = infoPro.pr_stock;
                      //    infoProxBod.pr_stock_maximo = infoPro.pr_stock_maximo;
                      //    infoProxBod.pr_stock_minimo = infoPro.pr_stock_minimo;
                      //    infoProxBod.pr_costo_fob = infoPro.pr_costo_fob;
                      //    infoProxBod.pr_costo_CIF = infoPro.pr_costo_CIF;
                      //    infoProxBod.pr_costo_promedio = infoPro.pr_costo_promedio;

                      //    // 5. Inserto (in_producto_x_tb_bodega)
                      //    string mensajea = "";
                      //    DataInserte.GrabaDBUnItem(infoProxBod, info.IdEmpresa, ref mensajea);
                      //}
                      //else
                      //{
                                                           
                      //}
                  }
                  #endregion
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
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }
      
      public Boolean ModificarDB(com_solicitud_compra_Info info, ref string msg)
      {
          try
          {
              if (validarObjeto(info, ref msg))
              {
                  return odata.ModificarDB(info);
              }

              return false;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }

      public List<com_solicitud_compra_Info> Get_List_solicitud_compra_EstadoApro_SC()
      {
          try
          {
              return odata.Get_List_solicitud_compra_EstadoApro_SC();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_EstadoApro_SC", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }

      public List<com_solicitud_compra_Info> Get_List_Solicitud_x_OC(int IdEmpresa, int IdSucursal, string IdOrdenCompra)
      {
          try
          {
              return odata.Get_List_Solicitud_x_OC(IdEmpresa, IdSucursal, IdOrdenCompra);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarObjeto", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }

      public Boolean validarObjeto(com_solicitud_compra_Info info, ref string mensajeE)
      {
          try
          {
             

              if (info.IdEmpresa == 0 || info.IdEmpresa == null)
              {
                  mensajeE = "Uno de los Pk de la solicitud esta en cero IdEmpresa=" + info.IdEmpresa ;
                  return false;
              }

              if (info.IdSucursal == 0 || info.IdSucursal == null)
              {
                  mensajeE = "Ingrese la Sucursal ";
                  return false;
              }
         
              if (info.IdSolicitante == 0)
              {
                  mensajeE = "Ingrese el Solicitante";
                  return false;
              }
              if (info.IdComprador == 0)
              {
                  mensajeE = "Ingrese el Comprador";
                  return false;
              }
              if (info.IdDepartamento == 0)
              {
                  mensajeE = "Ingrese el Departamento";
                  return false;
              }
                   
              info.observacion = (info.observacion == null) ? "" : info.observacion;

              if (info.DetSolicitudCompra.Count == 0)
              {
                  mensajeE = "La solicitud no tiene detalle ";
                  return false;
              }

              foreach (var item in info.DetSolicitudCompra)
              {

                  if (item.do_Cantidad == 0 && item.IdProducto !=0)
                  {
                      mensajeE = "el producto :  [" + item.NomProducto + "] , tiene cantidad cero ";
                      return false;
                  }

                 
                  if ((item.NomProducto == "" || item.NomProducto == null) && item.do_Cantidad != 0)
                  {
                      mensajeE = "Ingrese la descripción del producto";
                      return false;
                  }
              }


              var qItems_Repetidos_x_PuntoCargo = from CB in info.DetSolicitudCompra
                                                  where CB.IdProducto>0
                                                  group CB by new { CB.IdEmpresa, CB.IdProducto, CB.IdPunto_cargo } into grouping
                                                  select new { grouping.Key, totalReg = grouping.Count()  };


             foreach (var item in qItems_Repetidos_x_PuntoCargo)
              {


                  int conta = item.totalReg;

                      if (conta > 1)
                      {
                          mensajeE = "Existen items repetidos en el Detalle por el mismo punto de cargo: Producto" + item.Key.IdProducto  ;
                          return false;
                      }

                  
              }
                         
              return true;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarObjeto", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }

      public List<com_solicitud_compra_Info> Get_List_solicitud_compra(int idempresa, int idsucursal, DateTime FechaIni, DateTime FechaFin
          ,string IdEstadoAprobacion="")
      {

          try
          {
              return odata.Get_List_solicitud_compra(idempresa, idsucursal, FechaIni, FechaFin , IdEstadoAprobacion);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }
     
      public Boolean ModificarDBEstadoAprobacion(com_solicitud_compra_Info info, ref string msg)
      {
          try
          {             
             return odata.ModificarDB_EstadoAprobacion(info);          
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB_EstadoAprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }

      public Boolean ModificarDBEstadoAprobacion(List<com_solicitud_compra_Info> listInfo,ref string msg)
      {
          try
          {
              foreach (var item in listInfo)
              {
                  odata.ModificarDB_EstadoAprobacion(item);
              }

              return true;

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDBEstadoAprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_Bus) };
          }
      }     
  }
}

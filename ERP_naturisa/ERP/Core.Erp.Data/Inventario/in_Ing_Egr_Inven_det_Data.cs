using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
  public  class in_Ing_Egr_Inven_det_Data
    {
      string mensaje = "";

      public Boolean GuardarDB(List<in_Ing_Egr_Inven_det_Info> LstInfo)
      {
          try
          {
              try
              {
                  int sec = 0;

                  foreach (var item in LstInfo)
                  {
                      using (EntitiesInventario Context = new EntitiesInventario())
                      {
                          sec = sec + 1;
                          var Address = new in_Ing_Egr_Inven_det();

                          Address.IdEmpresa = item.IdEmpresa;
                          Address.IdSucursal = item.IdSucursal;
                          Address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;

                          Address.IdBodega = Convert.ToInt32(item.IdBodega);
                          Address.IdNumMovi = item.IdNumMovi;
                          Address.Secuencia = sec;
                          Address.IdProducto = item.IdProducto;
                          Address.dm_stock_ante = item.dm_stock_ante;
                          Address.dm_stock_actu = item.dm_stock_actu;
                          Address.dm_observacion = item.dm_observacion == null ? "" : item.dm_observacion;
                          Address.dm_precio = item.dm_precio;

                          Address.dm_peso = item.dm_peso;
                          Address.IdCentroCosto = (item.IdCentroCosto == "") ? null : item.IdCentroCosto;
                          Address.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo == "") ? null : item.IdCentroCosto_sub_centro_costo;
                          Address.IdUnidadMedida = item.IdUnidadMedida;
                          Address.IdEmpresa_oc = item.IdEmpresa_oc == 0 ? null : item.IdEmpresa_oc;
                          Address.IdSucursal_oc = item.IdSucursal_oc == 0 ? null : item.IdSucursal_oc;
                          Address.IdOrdenCompra = item.IdOrdenCompra == 0 ? null : item.IdOrdenCompra;
                          Address.Secuencia_oc = item.Secuencia_oc == 0 ? null : item.Secuencia_oc;
                          Address.IdEmpresa_inv = item.IdEmpresa_inv == 0 ? null : item.IdEmpresa_inv;
                          Address.IdSucursal_inv = item.IdSucursal_inv == 0 ? null : item.IdSucursal_inv;
                          Address.IdBodega_inv = item.IdBodega_inv == 0 ? null : item.IdBodega_inv;
                          Address.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv == 0 ? null : item.IdMovi_inven_tipo_inv;
                          Address.IdNumMovi_inv = item.IdNumMovi_inv == 0 ? null : item.IdNumMovi_inv;
                          Address.secuencia_inv = item.secuencia_inv == 0 ? null : item.secuencia_inv;
                          Address.IdEstadoAproba = (item.IdEstadoAproba == null || item.IdEstadoAproba == "") ? "PEND" : item.IdEstadoAproba;
                          Address.Motivo_Aprobacion = item.Motivo_Aprobacion;

                          if (item.signo == "-")
                              Address.dm_cantidad = Math.Abs(item.dm_cantidad) * -1;
                          else
                              Address.dm_cantidad = Math.Abs(item.dm_cantidad);

                          if (item.signo == "-")
                              Address.dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion) * -1;
                          else
                              Address.dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion);

                          Address.mv_costo = item.mv_costo;
                          Address.mv_costo_sinConversion = item.mv_costo_sinConversion;
                          Address.IdUnidadMedida = item.IdUnidadMedida;
                          Address.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;

                          Address.IdMotivo_Inv = item.IdMotivo_Inv;
                          Address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                          Address.IdPunto_cargo = item.IdPunto_cargo == 0 ? null : item.IdPunto_cargo;
                          Context.in_Ing_Egr_Inven_det.Add(Address);
                          Context.SaveChanges();
                      }
                  }
                  return true;
              }
              catch (DbEntityValidationException ex)
              {
                  string arreglo = ToString();
                  tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                  oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                  mensaje = ex.ToString() + " " + ex.Message;
                  mensaje = "Error al Grabar" + ex.Message;
                  throw new Exception(ex.ToString());
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean EliminarDB(List<in_Ing_Egr_Inven_det_Info> lstInfo, ref string msgs)
      {
          try
          {              
              using (EntitiesInventario Context = new EntitiesInventario())
              {
                  foreach (var item in lstInfo)
                  {

                      string qry = "delete from in_Ing_Egr_Inven_det where  IdNumMovi = " + item.IdNumMovi + " and IdSucursal = "
                          + item.IdSucursal + " and IdBodega =" + item.IdBodega
                          + "  and IdEmpresa =" + item.IdEmpresa
                      + "  and IdMovi_inven_tipo =" + item.IdMovi_inven_tipo;
                      Context.Database.ExecuteSqlCommand(qry);
                      break;                      
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msgs = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
              throw new Exception(ex.ToString());
          }
      }

      public Boolean EliminarDB(int IdEmpresa,int IdSucursal,int IdBodega,decimal IdNumMovi,int IdMovi_inven_tipo,  ref string msgs)
      {
          try
          {

              using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_Ing_Egr_Inven_det where IdEmpresa=" 
                        + IdEmpresa + " and IdSucursal=" + IdSucursal 
                        + " and IdNumMovi= " + IdNumMovi
                        + " and IdMovi_inven_tipo= " + IdMovi_inven_tipo);
                }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msgs = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDetalle_IdMovi_Inven_x_IngEgr(List<in_Ing_Egr_Inven_det_Info> lista, ref string msgs)
      {
          try
          {
              foreach (var item in lista)
              {
                  using (EntitiesInventario context = new EntitiesInventario())
                  {
                      var contact = context.in_Ing_Egr_Inven_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa 
                          && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdMovi_inven_tipo==item.IdMovi_inven_tipo
                          && q.IdNumMovi == item.IdNumMovi && q.Secuencia==item.Secuencia);
                      if (contact != null)
                      {
                          contact.IdEmpresa_inv = item.IdEmpresa_inv;
                          contact.IdSucursal_inv = item.IdSucursal_inv;
                          contact.IdBodega_inv = item.IdBodega_inv;
                          contact.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                          contact.IdNumMovi_inv = item.IdNumMovi_inv;
                          contact.secuencia_inv = item.secuencia_inv;
                          context.SaveChanges();
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
              msgs = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal,int IdMovi_inven_tipo, decimal IdNumMovi)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

              var select = from q in OEInventario.in_Ing_Egr_Inven_det
                           join p in OEInventario.in_Producto
                           on new { q.IdEmpresa, q.IdProducto } equals new { p.IdEmpresa, p.IdProducto }
                           where q.IdEmpresa == IdEmpresa
                           && q.IdSucursal == IdSucursal
                           && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                           && q.IdNumMovi == IdNumMovi
                           select new
                           {
                               IdEmpresa = q.IdEmpresa,
                               IdSucursal = q.IdSucursal,
                               IdBodega = q.IdBodega,
                               IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                               IdNumMovi = q.IdNumMovi,
                               Secuencia = q.Secuencia,
                               IdProducto = q.IdProducto,
                               dm_stock_ante = q.dm_stock_ante,
                               dm_stock_actu = q.dm_stock_actu,
                               dm_observacion = q.dm_observacion,
                               dm_precio = q.dm_precio,
                               mv_costo = q.mv_costo,
                               dm_peso = q.dm_peso,
                               IdCentroCosto = q.IdCentroCosto,
                               IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                               //IdRegistro = q.IdCentroCosto == null || q.IdCentroCosto_sub_centro_costo == null ? null : q.IdCentroCosto + "-" + q.IdCentroCosto_sub_centro_costo,
                               IdUnidadMedida = q.IdUnidadMedida,
                               IdUnidadMedida_sinConversion = q.IdUnidadMedida_sinConversion,
                               mv_costo_sinConversion = q.mv_costo_sinConversion,
                               IdEmpresa_oc = q.IdEmpresa_oc,
                               IdSucursal_oc = q.IdSucursal_oc,
                               IdOrdenCompra = q.IdOrdenCompra,
                               Secuencia_oc = q.Secuencia_oc,
                               IdPunto_cargo_grupo = q.IdPunto_cargo_grupo,
                               IdPunto_cargo = q.IdPunto_cargo,
                               IdMotivo_Inv = q.IdMotivo_Inv,
                               IdEstadoAproba = q.IdEstadoAproba,
                               IdEmpresa_inv = q.IdEmpresa_inv,
                               IdSucursal_inv = q.IdSucursal_inv,
                               IdBodega_inv = q.IdBodega_inv,
                               IdMovi_inven_tipo_inv = q.IdMovi_inven_tipo_inv,
                               IdNumMovi_inv = q.IdNumMovi_inv,
                               secuencia_inv = q.secuencia_inv,
                               dm_cantidad_sinConversion = q.dm_cantidad_sinConversion,
                               dm_cantidad = q.dm_cantidad,
                               cod_producto = p.pr_codigo
                           };

              foreach (var item in select)
              {
                  in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursal;
                  info.pr_codigo = item.cod_producto;
                  info.IdBodega = item.IdBodega;
                  info.IdMovi_inven_tipo = (int)item.IdMovi_inven_tipo;
                  info.IdNumMovi = item.IdNumMovi;
                  info.Secuencia = item.Secuencia;
                  info.IdProducto = item.IdProducto;
                  info.dm_stock_ante = item.dm_stock_ante;
                  info.dm_stock_actu = item.dm_stock_actu;
                  info.dm_observacion = item.dm_observacion;
                  info.dm_precio = item.dm_precio;
                  info.mv_costo = item.mv_costo;
                  info.dm_peso = Convert.ToDouble(item.dm_peso);
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  info.IdRegistro = item.IdCentroCosto == null || item.IdCentroCosto_sub_centro_costo == null ? null : item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                  info.IdUnidadMedida = item.IdUnidadMedida == null ? item.IdUnidadMedida : item.IdUnidadMedida.Trim();
                  info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion == null ? item.IdUnidadMedida_sinConversion : item.IdUnidadMedida_sinConversion.Trim();
                  info.mv_costo_sinConversion = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);
                  info.IdEmpresa_oc = item.IdEmpresa_oc;
                  info.IdSucursal_oc = item.IdSucursal_oc;
                  info.IdOrdenCompra = item.IdOrdenCompra;
                  info.Secuencia_oc = item.Secuencia_oc;
                  info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  info.IdPunto_cargo = item.IdPunto_cargo;
                  info.IdMotivo_Inv = item.IdMotivo_Inv;
                  info.IdEstadoAproba = item.IdEstadoAproba;
                  info.IdEmpresa_inv = item.IdEmpresa_inv;
                  info.IdSucursal_inv = item.IdSucursal_inv;
                  info.IdBodega_inv = item.IdBodega_inv;
                  info.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                  info.IdNumMovi_inv = item.IdNumMovi_inv;
                  info.secuencia_inv = item.secuencia_inv;
                  info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                  info.dm_cantidad = item.dm_cantidad;

                  lM.Add(info);
              }          
              return lM;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_transferencia(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

              var select = from q in OEInventario.vwin_Transferencia_Detalle
                           where q.IdEmpresa == IdEmpresa
                           && q.IdSucursalOrigen == IdSucursalOrigen
                           && q.IdBodegaOrigen == IdBodegaOrigen
                           && q.IdTransferencia == IdTransferencia
                           select q;

              foreach (var item in select)
              {

                  in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursalOrigen;
                  info.IdBodega = item.IdBodegaOrigen;
                  info.Secuencia = item.dt_secuencia;

                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                  info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  info.IdPunto_cargo = item.IdPunto_cargo;

                  info.dm_cantidad_sinConversion = item.dt_cantidad;
                  info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                  
                  info.IdProducto = item.IdProducto;
                  info.dm_observacion = item.tr_Observacion;
                  info.dm_cantidad = item.dt_cantidad;
                  info.IdUnidadMedida = item.IdUnidadMedida;
                  info.cod_producto = item.pr_codigo;
                  info.Checked = true;
                  info.Info_Guia_x_traspaso_bodega_det.IdEmpresa = item.IdEmpresa_guia == null ? 0 : Convert.ToInt32(item.IdEmpresa_guia);
                  info.Info_Guia_x_traspaso_bodega_det.IdGuia = item.IdGuia_guia == null ? 0 : Convert.ToDecimal(item.IdGuia_guia);
                  info.Info_Guia_x_traspaso_bodega_det.secuencia = item.Secuencia_guia == null ? 0 : Convert.ToInt32(item.Secuencia_guia);

                  lM.Add(info);

              }
              return lM;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_agrupada(int IdEmpresa, int IdSucursal,int IdBodega, decimal IdNumMovi)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

              var query = from q in OEInventario.vwin_Ing_Egr_Inven_det_x_Producto
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          && q.IdBodega == IdBodega
                          && q.IdNumMovi == IdNumMovi
                          && q.IdNumMovi_inv!=null
                          select q;

              var query_agrupado = (from q in query
                                    group q by new { q.IdEmpresa_inv, q.IdSucursal_inv, q.IdBodega_inv, q.IdMovi_inven_tipo_inv, q.IdNumMovi_inv }
                                        into Lista_agrupada
                                        select new
                                        {
                                            Lista_agrupada.Key.IdEmpresa_inv,
                                            Lista_agrupada.Key.IdSucursal_inv,
                                            Lista_agrupada.Key.IdBodega_inv,
                                            Lista_agrupada.Key.IdMovi_inven_tipo_inv,
                                            Lista_agrupada.Key.IdNumMovi_inv
                                        });

              foreach (var item in query_agrupado)
              {
                  in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                  info.IdEmpresa_inv = item.IdEmpresa_inv;
                  info.IdSucursal_inv = item.IdSucursal_inv;
                  info.IdBodega_inv = item.IdBodega_inv;
                  info.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                  info.IdNumMovi_inv = item.IdNumMovi_inv;
                  lM.Add(info);
              }

              return lM;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_OrdenCompra(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

              var Query = from q in OEInventario.vwin_Ing_Egr_Inven_det
                          where q.IdEmpresa_oc == IdEmpresa
                          && q.IdSucursal_oc == IdSucursal
                          && q.IdOrdenCompra == IdOrdenCompra
                          select q;

              foreach (var item in Query)
              {

                  in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursal;
                  info.IdBodega = item.IdBodega;
                   info.IdMovi_inven_tipo =Convert.ToInt32(item.IdMovi_inven_tipo);
                  info.IdNumMovi = item.IdNumMovi;
                  info.Secuencia = item.Secuencia;
                  info.IdProducto = item.IdProducto;
                  info.dm_cantidad = item.dm_cantidad;
                  info.dm_stock_ante = item.dm_stock_ante;
                  info.dm_stock_actu = item.dm_stock_actu;
                  info.dm_observacion = item.dm_observacion;
                  info.dm_precio = item.dm_precio;
                  info.mv_costo = item.mv_costo;
                  info.dm_peso = Convert.ToDouble(item.dm_peso);
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
               
                  info.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                  info.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                  info.IdOrdenCompra = Convert.ToInt32(item.IdOrdenCompra);
                  info.Secuencia_oc = Convert.ToInt32(item.Secuencia_oc);
                  info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                  info.IdEstadoAproba = item.IdEstadoAproba;
                  info.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo);
                  info.IdEmpresa_inv = Convert.ToInt32(item.IdEmpresa_inv);
                  info.IdSucursal_inv = Convert.ToInt32(item.IdSucursal_inv);
                  info.IdBodega_inv = Convert.ToInt32(item.IdBodega_inv);
                  info.IdMovi_inven_tipo_inv = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
                  info.IdNumMovi_inv = item.IdNumMovi_inv;
                  info.secuencia_inv = item.secuencia_inv;

                  info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                  info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                  info.mv_costo_sinConversion = Convert.ToDouble(item.mv_costo_sinConversion);

                   /// campos para consulta
                   /// 

                    info.nom_sucu = item.nom_sucursal;
                    info.nom_bodega= item.nom_bodega;
                    info.nom_tipo_inv = item.nom_tipo_inv;
                    info.oc_fecha = Convert.ToDateTime(item.cm_fecha);
                    info.Fecha_registro = item.Fecha_registro;

                  
                  lM.Add(info);

              }
              return lM;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(int IdEmpresa, int IdSucursal,int IdMovi_inven_tipo, decimal IdNumMovi)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

              var Query = from q in OEInventario.vwin_Ing_Egr_Inven_det
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          && q.IdNumMovi == IdNumMovi
                          && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                          select q;

              foreach (var item in Query)
              {

                  in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdSucursal = item.IdSucursal;
                  info.IdBodega = item.IdBodega;
                  info.IdMovi_inven_tipo = (int)item.IdMovi_inven_tipo;
                  info.cod_producto = item.pr_codigo;
                  info.IdNumMovi = item.IdNumMovi;
                  info.Secuencia = item.Secuencia;
                  info.IdProducto = item.IdProducto;                  
                  info.dm_stock_ante = item.dm_stock_ante;
                  info.dm_stock_actu = item.dm_stock_actu;
                  info.dm_observacion = item.dm_observacion;
                  info.dm_precio = item.dm_precio;
                  info.mv_costo = item.mv_costo;
                  info.dm_peso = Convert.ToDouble(item.dm_peso);
                  info.IdCentroCosto = item.IdCentroCosto;
                  info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  info.IdRegistro = item.IdCentroCosto == null || item.IdCentroCosto_sub_centro_costo == null ? null : item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                  info.IdUnidadMedida = item.IdUnidadMedida == null ? item.IdUnidadMedida : item.IdUnidadMedida.Trim();
                  info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion == null ? item.IdUnidadMedida_sinConversion : item.IdUnidadMedida_sinConversion.Trim();
                  info.mv_costo_sinConversion = item.mv_costo_sinConversion == null ? 0 : Convert.ToDouble(item.mv_costo_sinConversion);
                  info.IdEmpresa_oc = item.IdEmpresa_oc;
                  info.IdSucursal_oc = item.IdSucursal_oc;
                  info.IdOrdenCompra = item.IdOrdenCompra;
                  info.Secuencia_oc = item.Secuencia_oc;

                  info.oc_fecha = (item.cm_fecha == null) ? DateTime.Now : Convert.ToDateTime(item.cm_fecha);
                  info.nom_medida = item.nom_medida;
                  info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  info.IdPunto_cargo = item.IdPunto_cargo;
                  info.IdMotivo_Inv = item.IdMotivo_Inv;
                  info.signo = item.signo;
                  info.IdEstadoAproba = item.IdEstadoAproba;
                  info.IdEmpresa_inv = item.IdEmpresa_inv;
                  info.IdSucursal_inv = item.IdSucursal_inv;
                  info.IdBodega_inv = item.IdBodega_inv;
                  info.IdMovi_inven_tipo = item.IdMovi_inven_tipo == null ? 0 : Convert.ToInt32(item.IdMovi_inven_tipo);
                  info.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                  info.IdNumMovi_inv = item.IdNumMovi_inv;
                  info.secuencia_inv = item.secuencia_inv;

                  info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;


                  info.dm_cantidad = item.dm_cantidad; 
                  info.nom_UnidadMedida = (item.signo == "+") ? item.nom_medida_sinConversion : item.nom_medida;

                  info.nom_sucu = item.nom_sucursal;
                  info.IdProveedor = item.IdProveedor;
                  info.nom_proveedor = item.nom_proveedor;
                  info.nom_producto = item.nom_producto;

                  if (item.IdOrdenCompra != null)
                      info.Ref_OC = "OC.# " + Convert.ToDecimal(item.IdOrdenCompra) + " Fecha:" + Convert.ToDateTime(item.cm_fecha); //+ " Proveedor:" + item.nom_proveedor == null ?  item.IdProveedor.ToString() : item.nom_proveedor.Trim();

                  info.do_descuento = Convert.ToDouble(item.do_descuento);
                  info.do_subtotal = Convert.ToDouble(item.do_subtotal);
                  info.do_iva = Convert.ToDouble(item.do_iva);
                  info.do_total = Convert.ToDouble(item.do_total);
                  info.Checked = true;
                  info.Fecha_registro = item.Fecha_registro;

                  info.Saldo_x_Ing_OC = item.dm_cantidad;
                  info.Saldo_x_Ing_OC_AUX = item.dm_cantidad;
                  lM.Add(info);
              }
              return lM;
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

      public in_Ing_Egr_Inven_det_Info Get_Info_Ing_Egr_Inven_det_x_Movi_Inven(int IdEmpresa_inv, int IdSucursal_inv, int IdBodega_Inv, int IdMovi_inven_tipo_inv ,decimal IdNumMovi)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();

              in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

              vwin_Ing_Egr_Inven_det item = OEInventario.vwin_Ing_Egr_Inven_det.FirstOrDefault(q => q.IdEmpresa_inv == IdEmpresa_inv && q.IdSucursal_inv == IdSucursal_inv
                          && q.IdBodega_inv == IdBodega_Inv
                          && q.IdMovi_inven_tipo_inv == IdMovi_inven_tipo_inv
                          && q.IdNumMovi_inv == IdNumMovi);
              if (item == null)
                  return info;

              info = new in_Ing_Egr_Inven_det_Info
              {
                  IdEmpresa = item.IdEmpresa,
                  IdSucursal = item.IdSucursal,
                  IdBodega = item.IdBodega,
                  IdMovi_inven_tipo = (int)item.IdMovi_inven_tipo,
                  IdNumMovi = item.IdNumMovi,
                  Secuencia = item.Secuencia,
              };  
              
              return info;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_det_x_OC_Agrupado(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
      {
          try
          {
              EntitiesInventario OEInventario = new EntitiesInventario();
              List<in_Ing_Egr_Inven_det_Info> lM = new List<in_Ing_Egr_Inven_det_Info>();

                      
             var result = from q in OEInventario.in_Ing_Egr_Inven_det
                           where q.IdEmpresa == IdEmpresa
                         && q.IdSucursal_oc == IdSucursal
                         && q.IdOrdenCompra == IdOrdenCompra

                           group q by new { q.IdEmpresa_oc,q.IdSucursal_oc,q.IdOrdenCompra } into g
                           select new
                           {
                               IdEmpresa_oc = g.Key.IdEmpresa_oc,
                               IdSucursal_oc = g.Key.IdSucursal_oc,
                               IdOrdenCompra = g.Key.IdOrdenCompra,
                               cant_tot = g.Sum(x => x.dm_cantidad_sinConversion)                              
                           };

             foreach (var item in result)
             {

                 in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                 
                 info.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                 info.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                 info.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                 info.dm_cantidad = item.cant_tot;

                 lM.Add(info);
             }                           
              return lM;
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

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_OrdenCompraDet(int IdEmpresa, int IdSucursal,int IdMovi_inven_tipo, decimal IdNumMovi)
      {                      
          try
          {
              List<in_Ing_Egr_Inven_det_Info> Lst = new List<in_Ing_Egr_Inven_det_Info>();
              EntitiesInventario oEnti = new EntitiesInventario();
                                                   
              var Query = from q in oEnti.vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal  
                              && q.IdNumMovi == IdNumMovi
                              && q.IdMovi_inven_tipo ==Convert.ToInt32( IdMovi_inven_tipo)
                              
                              select q;

                foreach (var item in Query)
                  {
                      in_Ing_Egr_Inven_det_Info Obj = new in_Ing_Egr_Inven_det_Info();

                      Obj.IdEmpresa = item.IdEmpresa;
                      Obj.IdSucursal = item.IdSucursal;
                      Obj.IdBodega = item.IdBodega;
                      Obj.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo);
                      Obj.IdNumMovi = item.IdNumMovi;
                      Obj.Secuencia= item.Secuencia;
                      Obj.IdProducto = item.IdProducto;
                      Obj.dm_cantidad = item.dm_cantidad;
                      Obj.dm_stock_ante= item.dm_stock_ante;
                      Obj.dm_stock_actu = item.dm_stock_actu;
                      Obj.dm_observacion= item.dm_observacion;
                      Obj.dm_precio = item.dm_precio;
                      Obj.dm_peso = Convert.ToDouble(item.dm_peso);
                    Obj.mv_costo = Convert.ToDouble((item.mv_costo==null)?0: item.mv_costo);
                      Obj.IdCentroCosto = item.IdCentroCosto;
                      Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;                     
                      Obj.IdEstadoAproba = item.IdEstadoAproba;        
                      Obj.IdUnidadMedida = item.IdUnidadMedida;

                      Obj.signo = item.signo;
                      Obj.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                      Obj.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                      Obj.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                      Obj.Secuencia_oc = Convert.ToInt32(item.Secuencia_oc);

                      Obj.nom_bodega = item.nom_bodega;
                      Obj.nom_sucu = item.nom_sucursal;
                      Obj.Nom_Motivo = item.nom_motivo;
                      Obj.nom_tipo_inv = item.nom_tipo_inv;
                      Obj.nom_medida = item.nom_medida;
                      Obj.nom_punto_cargo = item.nom_punto_cargo;

                     Obj.nom_producto = item.nom_producto;
                     Obj.IdPunto_cargo = item.IdPunto_cargo;

                     Obj.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                     Obj.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                                                  
                      Lst.Add(Obj);                                   
                   }

              return Lst;
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

      public Boolean ModificarDB(in_Ing_Egr_Inven_det_Info Info, ref  string msg)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_Ing_Egr_Inven_det.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa 
                      && obj.IdSucursal == Info.IdSucursal
                      && obj.IdBodega == Info.IdBodega
                      && obj.IdMovi_inven_tipo == Info.IdMovi_inven_tipo
                      && obj.IdNumMovi == Info.IdNumMovi);
                  if (contact != null)
                  {
                      contact.dm_observacion = Info.dm_observacion;
                      contact.dm_precio = Info.dm_precio;
                      contact.IdCentroCosto = Info.IdCentroCosto;
                      contact.IdCentroCosto_sub_centro_costo = Info.IdCentroCosto_sub_centro_costo;
                      contact.IdPunto_cargo_grupo = Info.IdPunto_cargo_grupo;
                      contact.IdPunto_cargo = Info.IdPunto_cargo;
                      contact.IdMotivo_Inv = Info.IdMotivo_Inv;
                      context.SaveChanges();
                      msg = "Se ha procedido a modificar el registro de Egreso Varios  #: " + Info.IdNumMovi.ToString() + " exitosamente";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;

              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
 
      public List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info> Get_List_Ing_Egr_x_Cbte_Cble(int IdEmpresa, int IdSucursal, int IdBodega,int IdMovi_inven_tipo, decimal IdNumMovi)
      {
          try
          {
              List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info> lstInfo = new List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info>();

              using (EntitiesInventario listado = new EntitiesInventario())
              {
                  var select_ = from q in listado.vwIn_Ing_Egr_Inven_det_x_Cbte_Cble
                               where q.IdEmpresa == IdEmpresa
                               && q.IdSucursal == IdSucursal 
                               && q.IdBodega == IdBodega
                               && q.IdNumMovi == IdNumMovi
                               && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                               select q;


                  var ingEgr_cab = from ing_ in select_
                                   group ing_ by new
                                   {
                                       ing_.IdEmpresa_CbteCble,
                                       ing_.IdTipoCbte,
                                       ing_.IdCbteCble,
                                       ing_.CodCbteCble,
                                       ing_.IdPeriodo,
                                       ing_.cb_Fecha,
                                       ing_.cb_Valor,
                                       ing_.cb_Observacion
                                   }
                                       into grouping
                                       select new { grouping.Key };

                  foreach (var item in ingEgr_cab)
                  {
                      vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info Info = new vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info();
                     
                      Info.IdEmpresa_CbteCble = item.Key.IdEmpresa_CbteCble;
                      Info.IdCbteCble = item.Key.IdCbteCble;
                      Info.IdTipoCbte = item.Key.IdTipoCbte;
                      Info.CodCbteCble = item.Key.CodCbteCble;
                      Info.IdPeriodo = item.Key.IdPeriodo;
                      Info.cb_Fecha = item.Key.cb_Fecha;
                      Info.cb_Valor = item.Key.cb_Valor;
                      Info.cb_Observacion = item.Key.cb_Observacion;

                      lstInfo.Add(Info);
                  }
              }
              return lstInfo;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean Modificar_Enserar_Campos_OC(List<in_Ing_Egr_Inven_det_Info> Lista)
      {
          try
          {
              foreach (var item in Lista)
              {
                  using (EntitiesInventario context = new EntitiesInventario())
                  {
                      var contact = context.in_Ing_Egr_Inven_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa
                          && q.IdSucursal == item.IdSucursal 
                          && q.IdBodega == item.IdBodega
                          && q.IdNumMovi == item.IdNumMovi
                          && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo 
                          && q.Secuencia == item.Secuencia);
                      if (contact != null)
                      {
                          contact.IdEmpresa_oc = null;
                          contact.IdSucursal_oc = null;
                          contact.IdOrdenCompra = null;
                          contact.Secuencia_oc = null;
                          context.SaveChanges();
                      }
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDB_proceso_cerrado(in_Ing_Egr_Inven_det_Info info)
      {
          try
          {
               using (EntitiesInventario context = new EntitiesInventario())
                  {
                      var contact = context.in_Ing_Egr_Inven_det.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                          && q.IdSucursal == info.IdSucursal
                          && q.IdNumMovi == info.IdNumMovi
                          && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo
                          && q.Secuencia == info.Secuencia);
                      if (contact != null)
                      {
                          contact.IdBodega = Convert.ToInt32(info.IdBodega);
                          context.SaveChanges();
                      }
                  }
               return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_det_x_Cat_lin_gru_sub_Centro_subcentro(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo, int IdSubgrupo, string IdCentroCosto, string IdCentroCosto_sub_centro_costo)
      {
          try
          {
              List<in_Ing_Egr_Inven_det_Info> Lista = new List<in_Ing_Egr_Inven_det_Info>();

              using (EntitiesInventario Context = new EntitiesInventario())
              {
                  var lst = from q in Context.vwin_Ing_Egr_Inven_det
                            where q.IdEmpresa == IdEmpresa 
                            && q.IdCategoria == IdCategoria
                            && q.IdLinea == IdLinea
                            && q.IdGrupo == IdGrupo
                            && q.IdSubgrupo == IdSubgrupo
                            && q.IdCentroCosto == IdCentroCosto
                            && q.IdCentroCosto_sub_centro_costo == IdCentroCosto_sub_centro_costo
                            select q;

                  foreach (var item in lst)
                  {
                      in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                                            
                      info.IdProducto = item.IdProducto;
                      info.nom_producto = "["+item.IdProducto.ToString()+"] "+ item.nom_producto;

                      info.IdCentroCosto = item.IdCentroCosto;
                      info.Centro_costo = "[" + item.IdCentroCosto.ToString() + "] " + item.nom_Centro_costo;

                      info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                      info.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.ToString() + "] " + item.nom_Centro_costo_sub_centro_costo;

                      info.IdCategoria = item.IdCategoria;
                      info.ca_Categoria = "[" + item.IdCategoria.ToString() + "] " + item.ca_Categoria;

                      info.IdLinea = item.IdLinea;
                      info.nom_linea = "[" + item.IdLinea.ToString() + "] " + item.nom_linea;

                      info.IdGrupo = item.IdGrupo;
                      info.nom_grupo = "[" + item.IdGrupo.ToString() + "] " + item.nom_grupo;

                      info.IdSubgrupo = item.IdSubgrupo;
                      info.nom_subgrupo = "[" + item.IdSubgrupo.ToString() + "] " + item.nom_subgrupo;

                      info.IdNumMovi = item.IdNumMovi;
                      
                      info.IdMovi_inven_tipo = item.IdMovi_inven_tipo == null ? 0 : Convert.ToInt32(item.IdMovi_inven_tipo);
                      info.nom_tipo_inv = "[" + info.IdMovi_inven_tipo.ToString() + "] " + item.nom_tipo_inv;
                      
                      info.IdSucursal = item.IdSucursal;
                      info.nom_sucu = "[" + item.IdSucursal.ToString() + "] " + item.nom_sucursal;

                      info.dm_cantidad = item.dm_cantidad;

                      info.IdBodega = item.IdBodega;
                      info.nom_bodega = "[" + item.IdBodega.ToString() + "] " + item.nom_bodega;
                      info.Fecha_registro = item.cm_fecha;

                      Lista.Add(info);
                  }
              }

              return Lista;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using System.Data.Objects;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Produc_Cirdesus;
namespace Core.Erp.Data.Inventario
{
   public  class in_movi_inve_detalle_Data
    {
       string mensaje = "";
        public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det(int IdEmpresa,DateTime FechaIni ,DateTime FechaFin, int TipoMoviIni, int TipoMoviFin)
        {
            try
            {
                List<in_movi_inve_detalle_Info> lM = new List<in_movi_inve_detalle_Info>();

                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_movi_inve_detalle
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdMovi_inven_tipo>=TipoMoviIni && C.IdMovi_inven_tipo<=TipoMoviFin
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();

                    moviI.dm_cantidad = item.dm_cantidad;
                    moviI.dm_observacion = item.dm_observacion;
                    moviI.dm_stock_actu = item.dm_stock_actu;
                    moviI.dm_stock_ante = item.dm_stock_ante;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdProducto = item.IdProducto;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.mv_costo = item.mv_costo;
                    moviI.peso = item.dm_peso;
                    moviI.mv_tipo_movi = item.mv_tipo_movi;
                    moviI.Secuencia = item.Secuencia;
                    moviI.IdPunto_Cargo = item.IdPunto_cargo;
                    lM.Add(moviI);
                }


                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }
        }

       public Boolean GrabarDB(in_movi_inve_detalle_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    
                    var Q = from per in EDB.in_movi_inve_detalle
                            where per.IdEmpresa == prI.IdEmpresa
                            && per.IdMovi_inven_tipo == prI.IdMovi_inven_tipo
                            && per.IdBodega == prI.IdBodega
                            && per.IdSucursal == prI.IdSucursal
                            && per.IdNumMovi == prI.IdNumMovi
                            select per;

                    if (Q.ToList().Count == 0)
                    {
                        
                        var address = new in_movi_inve_detalle();

                        address.IdEmpresa = prI.IdEmpresa;
                        address.IdSucursal = prI.IdSucursal;
                        address.IdBodega = prI.IdBodega;
                        address.IdMovi_inven_tipo = prI.IdMovi_inven_tipo;
                        address.IdNumMovi = prI.IdNumMovi;
                        address.mv_tipo_movi = prI.mv_tipo_movi;
                        
                        if (prI.mv_tipo_movi == "-")
                            address.dm_cantidad = Math.Abs(prI.dm_cantidad)*-1;
                        else
                            address.dm_cantidad = Math.Abs(prI.dm_cantidad);
                        
                        address.dm_observacion = prI.dm_observacion;
                        if (prI.dm_observacion.Length > 1000)
                        {
                            address.dm_observacion = prI.dm_observacion.Substring(0, 1000);
                        }
                        //address.dm_precio = (double)prI.dm_precio;
                        address.dm_stock_actu = (double)prI.dm_stock_actu;
                        address.dm_stock_ante = (double)prI.dm_stock_ante;
                        address.mv_costo = (double)prI.mv_costo;
                        address.dm_peso = prI.peso;
                        address.Secuencia = prI.Secuencia;
                        address.dm_peso = prI.peso;
                        address.IdPunto_cargo = (prI.IdPunto_Cargo == 0) ? null : prI.IdPunto_Cargo;
                        address.IdPunto_cargo_grupo = prI.IdPunto_cargo_grupo;
                        address.IdMotivo_Inv = prI.IdMotivo_Inv;
                        context.in_movi_inve_detalle.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";

                    }
                    else
                        return false;
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
                mensaje = "Error al Grabar .." + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

       public Boolean ModificarDB(in_movi_inve_detalle_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_movi_inve_detalle.FirstOrDefault(VMovi => VMovi.IdEmpresa == prI.IdEmpresa && VMovi.IdSucursal == prI.IdSucursal && VMovi.IdBodega == prI.IdBodega && VMovi.IdMovi_inven_tipo == prI.IdMovi_inven_tipo && VMovi.IdNumMovi == prI.IdNumMovi);
                    if (contact != null)
                    {
                        contact.dm_cantidad = prI.dm_cantidad;
                        contact.dm_peso = prI.peso;
                        contact.dm_observacion = prI.dm_observacion;
                        contact.dm_stock_actu = (double)prI.dm_stock_actu;
                        contact.dm_stock_ante = (double)prI.dm_stock_ante;
                        contact.IdProducto = prI.IdProducto;
                        contact.mv_costo = (double)prI.mv_costo;
                        contact.mv_tipo_movi = prI.mv_tipo_movi;

                        contact.IdCentroCosto = (prI.IdCentroCosto == "") ? null : prI.IdCentroCosto;
                        contact.IdCentroCosto_sub_centro_costo = (prI.IdCentroCosto_sub_centro_costo == "") ? null : prI.IdCentroCosto_sub_centro_costo;
                        contact.IdPunto_cargo = (prI.IdPunto_Cargo == 0) ? null : prI.IdPunto_Cargo;

                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }
        }

       public Boolean AnularDB(List< in_movi_inve_detalle_Info> ListMoviInfo, ref  string mensaje)
        {
            try
            {
                foreach (in_movi_inve_detalle_Info MoviInfo in ListMoviInfo)
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        var contact = context.in_movi_inve_detalle.FirstOrDefault(VMovi => VMovi.IdEmpresa == MoviInfo.IdEmpresa && VMovi.IdSucursal == MoviInfo.IdSucursal
                                                          && VMovi.IdBodega == MoviInfo.IdBodega && VMovi.IdMovi_inven_tipo == MoviInfo.IdMovi_inven_tipo
                                                           && VMovi.IdNumMovi == MoviInfo.IdNumMovi && VMovi.Secuencia == MoviInfo.Secuencia);
                        if (contact != null)
                        {
                            contact.dm_observacion = " ***ANULADO***" + contact.dm_observacion.Trim();
                            context.SaveChanges();
                            context.Dispose();
                        }
                    }
                }
                mensaje = "Anulacion Exitosa..";

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Anular:  " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public Boolean AnularDB(in_movi_inve_detalle_Info MoviInfo, ref  string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_movi_inve_detalle.FirstOrDefault(VMovi => VMovi.IdEmpresa == MoviInfo.IdEmpresa && VMovi.IdSucursal == MoviInfo.IdSucursal
                                                            && VMovi.IdBodega == MoviInfo.IdBodega && VMovi.IdMovi_inven_tipo == MoviInfo.IdMovi_inven_tipo
                                                             && VMovi.IdNumMovi == MoviInfo.IdNumMovi);
                    //no elimino el registro solo cambia el estado de activo a inactivo
                    if (contact != null)
                    {
                        contact.dm_observacion = " ***ANULADO***" + "Cant Ant.:" + contact.dm_cantidad.ToString();//+ " Precio Ant.:" + contact.dm_precio.ToString() + contact.dm_observacion.Trim();
                        contact.dm_cantidad = 0;
                        //contact.dm_precio = 0;
                        contact.dm_stock_actu = 0;
                        contact.dm_stock_ante = 0;
                        context.SaveChanges();
                        mensaje = "Anulacion Exitosa..";
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
                mensaje = "Error al Anular:  " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det(int IdEmpresa, int Idsucursal,int idbodega,
            int idTipoMovi ,decimal IdNumMovimiento)
        {
            try
            {
                List<in_movi_inve_detalle_Info> lM = new List<in_movi_inve_detalle_Info>();

                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_movi_inve_detalle
                                     join pr in OECbtecble_Info.vwin_producto_x_tb_bodega
                                     on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto } equals new { pr.IdEmpresa, pr.IdSucursal, pr.IdBodega, pr.IdProducto }
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdMovi_inven_tipo == idTipoMovi
                                     && C.IdSucursal == Idsucursal
                                     && C.IdBodega == idbodega
                                     && C.IdNumMovi == IdNumMovimiento
                                     select new 
                                     {
                                         pr.pr_peso,
                                         C.dm_cantidad,
                                         C.dm_observacion,
                                         C.dm_stock_actu,
                                         pr.pr_stock,
                                         C.IdEmpresa,
                                         C.IdMovi_inven_tipo,
                                         C.IdNumMovi,
                                         C.IdProducto,
                                         C.IdSucursal,
                                         C.mv_costo,
                                         C.mv_tipo_movi,
                                         C.Secuencia,
                                         C.IdBodega,
                                         C.IdCentroCosto,
                                         C.IdCentroCosto_sub_centro_costo,
                                         pr.pr_descripcion,pr.pr_codigo,
                                         C.dm_peso, C.IdUnidadMedida,
                                         C.IdUnidadMedida_sinConversion,
                                         C.dm_cantidad_sinConversion,
                                         C.mv_costo_sinConversion,
                                         C.IdPunto_cargo, 
                                         C.IdPunto_cargo_grupo,
                                         C.IdMotivo_Inv
                                     };

                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();

                    moviI.dm_cantidad = item.dm_cantidad;
                    moviI.dm_observacion = item.dm_observacion;
                    moviI.dm_stock_actu = item.dm_stock_actu;
                    moviI.dm_stock_ante = item.pr_stock;
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    moviI.IdNumMovi = item.IdNumMovi;
                    moviI.IdProducto = item.IdProducto;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.mv_costo = item.mv_costo;
                    moviI.IdBodega = item.IdBodega;
                    moviI.mv_tipo_movi = item.mv_tipo_movi;
                    moviI.Secuencia = item.Secuencia;
                    moviI.NomProducto = item.pr_descripcion;
                    moviI.CodProducto = item.pr_codigo;
                    moviI.peso = Convert.ToDouble(item.dm_peso);
                    moviI.nom_producto = item.pr_descripcion;
                    moviI.cod_producto = item.pr_codigo;
                    moviI.IdCentroCosto = item.IdCentroCosto;
                    moviI.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    moviI.IdUnidadMedida = item.IdUnidadMedida;
                    moviI.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                    moviI.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                    moviI.mv_costo_sinConversion = Convert.ToDouble(item.mv_costo_sinConversion);
                    moviI.IdPunto_Cargo = item.IdPunto_cargo;
                    moviI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    moviI.IdMotivo_Inv = item.IdMotivo_Inv;

                    lM.Add(moviI);
                }

                return (lM);
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

       public in_movi_inve_detalle_Info Get_info_Movi_inven_det(int IdEmpresa, int Idsucursal, int idbodega,
            int idTipoMovi, decimal IdNumMovimiento, int Secuencia)
       {
           try
           {
               in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();

               EntitiesInventario OECbtecble_Info = new EntitiesInventario();
               var selectCbtecble = from C in OECbtecble_Info.in_movi_inve_detalle
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdSucursal == Idsucursal
                                    && C.IdBodega == idbodega
                                    && C.IdMovi_inven_tipo == idTipoMovi
                                    && C.IdNumMovi == IdNumMovimiento
                                    select C;
                                   

               foreach (var item in selectCbtecble)
               {
                   

                   moviI.dm_cantidad = item.dm_cantidad;
                   moviI.dm_observacion = item.dm_observacion;
                   moviI.IdEmpresa = item.IdEmpresa;
                   moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   moviI.IdNumMovi = item.IdNumMovi;
                   moviI.IdProducto = item.IdProducto;
                   moviI.IdSucursal = item.IdSucursal;
                   moviI.mv_costo = item.mv_costo;
                   moviI.IdBodega = item.IdBodega;
                   moviI.mv_tipo_movi = item.mv_tipo_movi;
                   moviI.Secuencia = item.Secuencia;
                   moviI.peso = Convert.ToDouble(item.dm_peso);
                   moviI.IdCentroCosto = item.IdCentroCosto;
                   moviI.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                   moviI.IdUnidadMedida = item.IdUnidadMedida;
                   moviI.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                   moviI.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                   moviI.mv_costo_sinConversion = Convert.ToDouble(item.mv_costo_sinConversion);
                   moviI.IdPunto_Cargo = item.IdPunto_cargo;
                   moviI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   moviI.IdMotivo_Inv = item.IdMotivo_Inv;

                   
               }

               return (moviI);
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

       public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det_x_ing_egr(int IdEmpresa, int Idsucursal,
            int idTipoMovi, decimal IdNumMovimiento)
       {
           try
           {
               List<in_movi_inve_detalle_Info> lM = new List<in_movi_inve_detalle_Info>();

               EntitiesInventario OECbtecble_Info = new EntitiesInventario();
               var selectCbtecble = from C in OECbtecble_Info.vwin_movi_inve_detalle
                                    where C.IdEmpresa_ing_egr == IdEmpresa
                                    && C.IdSucursal_ing_egr == Idsucursal
                                    && C.IdMovi_inven_tipo_ing_egr == idTipoMovi
                                    && C.IdNumMovi_ing_egr == IdNumMovimiento
                                    select C;
                                    

               foreach (var item in selectCbtecble)
               {
                   in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();

                   moviI.dm_cantidad = item.dm_cantidad;
                   moviI.dm_observacion = item.dm_observacion;
                   moviI.dm_stock_actu = item.dm_stock_actu;
                   
                   moviI.IdEmpresa = item.IdEmpresa;
                   moviI.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   moviI.IdNumMovi = item.IdNumMovi;
                   moviI.IdProducto = item.IdProducto;
                   moviI.IdSucursal = item.IdSucursal;
                   moviI.mv_costo = item.mv_costo;
                   moviI.IdBodega = item.IdBodega;
                   moviI.mv_tipo_movi = item.mv_tipo_movi;
                   moviI.Secuencia = item.Secuencia;
                   moviI.NomProducto = item.pr_descripcion;
                   moviI.CodProducto = item.pr_codigo;
                   
                   moviI.nom_producto = item.pr_descripcion;
                   moviI.cod_producto = item.pr_codigo;
                   moviI.IdCentroCosto = item.IdCentroCosto;
                   moviI.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                   moviI.IdUnidadMedida = item.IdUnidadMedida;
                   moviI.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                   moviI.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                   moviI.mv_costo_sinConversion = Convert.ToDouble(item.mv_costo_sinConversion);
                   moviI.IdPunto_Cargo = item.IdPunto_cargo;
                   moviI.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   moviI.IdMotivo_Inv = item.IdMotivo_Inv;
                   moviI.nom_punto_cargo = item.nom_punto_cargo;
                   lM.Add(moviI);
               }

               return (lM);
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

       public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det_x_Ing_OrdenCompra_local(int IdEmpresa, int Idsucursal, int idbodega,
           int idTipoMovi, decimal IdNumMovimiento)
        {
            try
            {
                List<in_movi_inve_detalle_Info> lM = new List<in_movi_inve_detalle_Info>();
                         
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_movi_inve_detalle
                            
                                     join vi in OECbtecble_Info.vwin_movi_inve_x_Ing_Ordencompra_local
                                     on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdNumMovi, IdMovi = C.IdMovi_inven_tipo } equals new { vi.IdEmpresa, vi.IdSucursal, vi.IdBodega, vi.IdNumMovi, IdMovi = vi.IdTipoMoviInven }

                                     join pro in OECbtecble_Info.in_Producto
                                     on new { C.IdEmpresa, C.IdProducto } equals new { pro.IdEmpresa, pro.IdProducto }

                                     join cab in OECbtecble_Info.in_movi_inve
                                     on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdNumMovi, C.IdMovi_inven_tipo } equals new { cab.IdEmpresa, cab.IdSucursal, cab.IdBodega, cab.IdNumMovi, cab.IdMovi_inven_tipo }

                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdMovi_inven_tipo == idTipoMovi
                                     && C.IdSucursal == Idsucursal
                                     && C.IdBodega == idbodega
                                     && C.IdNumMovi == IdNumMovimiento
                                     select new
                                     {
                                         C.IdEmpresa,
                                         C.IdSucursal,
                                         C.IdBodega,
                                         vi.nom_sucursal,
                                        pro.pr_descripcion,
                                         C.dm_cantidad,
                                         C.IdCentroCosto,
                                         C.IdCentroCosto_sub_centro_costo,
                                         cab.cm_fecha,
                                         vi.nom_proveedor,
                                         C.IdPunto_cargo 
                                     };

                foreach (var item in selectCbtecble)
                {
                    in_movi_inve_detalle_Info moviI = new in_movi_inve_detalle_Info();
                   
                    moviI.IdEmpresa = item.IdEmpresa;
                    moviI.IdSucursal = item.IdSucursal;
                    moviI.IdBodega = item.IdBodega;
                    moviI.nom_sucu= item.nom_sucursal;
                    moviI.nom_proveedor = item.nom_proveedor;
                    moviI.nom_producto= item.pr_descripcion;
                    moviI.cantidad_ing_a_Inven = item.dm_cantidad;
                    moviI.IdCentroCosto = item.IdCentroCosto;
                    moviI.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;                
                    moviI.oc_fecha = item.cm_fecha;

                    moviI.nom_producto = item.pr_descripcion;
                    moviI.IdPunto_Cargo = item.IdPunto_cargo;
                    

                  
                    lM.Add(moviI);
                }

                return (lM);
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

       public Boolean GrabarDB(List<in_movi_inve_detalle_Info> list, ref string mensaje)
        {
            try
            {
                int c = 1;
                foreach (var item in list)
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        EntitiesInventario EDB = new EntitiesInventario();
                        var Q = from per in EDB.in_movi_inve_detalle
                                where per.IdEmpresa == item.IdEmpresa
                                && per.IdMovi_inven_tipo == item.IdMovi_inven_tipo
                                && per.IdBodega == item.IdBodega
                                && per.IdSucursal == item.IdSucursal
                                && per.IdNumMovi == item.IdNumMovi
                               && per.Secuencia==item.Secuencia
                                select per;

                        if (Q.ToList().Count == 0)
                        {
                            in_movi_inve_detalle address = new in_movi_inve_detalle();

                            address.IdEmpresa = item.IdEmpresa;
                            address.IdSucursal = item.IdSucursal;
                            address.IdBodega = item.IdBodega;                           
                            address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            address.IdNumMovi = item.IdNumMovi;
                            address.Secuencia = c;
                            item.Secuencia = c;
                            c++;
                            address.mv_tipo_movi = item.mv_tipo_movi;
                            address.IdProducto = item.IdProducto;
                            if (item.dm_stock_ante == null)
                                address.dm_stock_ante = (double)item.dm_stock_actu;
                            else
                                address.dm_stock_ante = (double)item.dm_stock_ante;
                            if (item.mv_tipo_movi == "-")
                                address.dm_cantidad = Math.Abs(item.dm_cantidad) * -1;
                            else
                                address.dm_cantidad = Math.Abs(item.dm_cantidad);
                            address.dm_stock_actu = (double)item.dm_stock_actu;
                            
                            address.mv_costo = (double)item.mv_costo;
                            if(item.dm_observacion == null)
                                address.dm_observacion = "";
                            else
                                address.dm_observacion = item.dm_observacion;
                            address.dm_peso = item.peso;

                            if (item.IdCentroCosto=="")
                            {
                                item.IdCentroCosto = null;
                            }
                            address.IdCentroCosto=item.IdCentroCosto;
                            if (item.IdCentroCosto_sub_centro_costo == "")
                            {
                                item.IdCentroCosto_sub_centro_costo = null;
                            }
                            address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                            address.IdUnidadMedida = item.IdUnidadMedida;
                            address.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                            address.mv_costo_sinConversion = item.mv_costo_sinConversion;
                            if (item.mv_tipo_movi == "-")
                                address.dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion) * -1;
                            else
                                address.dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion);

                            address.IdPunto_cargo = (item.IdPunto_Cargo == 0) ? null : item.IdPunto_Cargo;
                            address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            address.IdMotivo_Inv = item.IdMotivo_Inv;
                            //Campos para saber que movimiento esta devolviendose con este
                            address.IdEmpresa_dev = item.IdEmpresa_dev;
                            address.IdSucursal_dev = item.IdSucursal_dev;
                            address.IdBodega_dev = item.IdBodega_dev;
                            address.IdMovi_inven_tipo_dev = item.IdMovi_inven_tipo_dev;
                            address.IdNumMovi_dev = item.IdNumMovi_dev;
                            address.Secuencia_dev = item.Secuencia_dev;


                            context.in_movi_inve_detalle.Add(address);
                            context.SaveChanges();
                            mensaje = "Grabacion ok..";                                                                         
                        }
                        else
                            return false;
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
                mensaje = "Error al Grabar .." + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public Boolean ElminarDB(in_movi_inve_detalle_Info Info) 
        {
            try
            {
                string qry = "delete from in_movi_inve_detalle where IdMovi_inven_tipo = "+Info.IdMovi_inven_tipo+" and IdNumMovi = "+Info.IdNumMovi+" and IdSucursal = "+Info.IdSucursal+" and IdBodega ="+Info.IdBodega+"  and IdEmpresa ="+Info.IdEmpresa;
                using (EntitiesInventario oEnt = new EntitiesInventario()) 
                {
                    oEnt.Database.ExecuteSqlCommand(qry);
                
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

       public in_movi_inve_detalle_Info Get_Saldo_x_Prod_x_Fecha(int IdEmpresa, DateTime Fecha,  int IdSucursal, int IdBodega, decimal IdProducto, ref string msg)
        {
            try
            {
                
                //string query = "";
                DateTime date = Convert.ToDateTime(Fecha.ToShortDateString());
                in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {
                    var kardex = from Cab in oEnti.in_movi_inve
                                 join Det in oEnti.in_movi_inve_detalle
                                 on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                 equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                 where Cab.cm_fecha < date
                                 && Cab.IdEmpresa == IdEmpresa
                                 && Cab.IdSucursal == IdSucursal
                                 && Cab.IdBodega == IdBodega
                                 && Det.IdProducto == IdProducto
                                 group Det by new
                                 {
                                     Det.IdEmpresa,
                                     Det.IdSucursal,
                                     Det.IdBodega,
                                     Det.IdProducto                                     
                                 }
                                     into grouping
                                     select new
                                     {

                                         grouping.Key.IdEmpresa,
                                         grouping.Key.IdSucursal,
                                         grouping.Key.IdBodega,
                                         grouping.Key.IdProducto,
                                         existencia = grouping.Sum(Det => Det.dm_cantidad)
                                     };

                    foreach (var item in kardex)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.existencia = item.existencia;
                        info.IdProducto = item.IdProducto;
                    }
                }
                msg = "Consulta Correcta";
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

       public List<in_movi_inve_detalle_Info> Get_Kardex_x_Prod_x_Fecha(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega, decimal IdProducto, ref string msg)
        {
            try
            {
                List<in_movi_inve_detalle_Info> lista = new List<in_movi_inve_detalle_Info>();
                DateTime dateini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime datefin = Convert.ToDateTime(FechaFin.ToShortDateString());
                
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var kardex = from Cab in oEnti.in_movi_inve
                                 join Det in oEnti.in_movi_inve_detalle
                                 on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                 equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                 where Cab.cm_fecha <= datefin
                                 && Cab.cm_fecha >= dateini
                                 && Cab.IdEmpresa == IdEmpresa
                                 && Cab.IdSucursal == IdSucursal
                                 && Cab.IdBodega == IdBodega
                                 && Det.IdProducto == IdProducto
                                 group Det by new
                                 {
                                     Det.IdEmpresa,
                                     Det.IdSucursal,
                                     Det.IdBodega,
                                     Det.IdMovi_inven_tipo,
                                     Det.IdNumMovi,
                                     Det.IdProducto,
                                     Det.dm_cantidad,
                                     Det.dm_observacion,
                                     Det.Secuencia,
                                     Det.mv_tipo_movi,
                                     Cab.cm_fecha,
                                     Cab.Fecha_Transac 
                                 }
                                     into grouping
                                     orderby grouping.Key.cm_fecha , grouping.Key.Fecha_Transac ascending
                                     select new
                                     {

                                         grouping.Key.IdEmpresa,
                                         grouping.Key.IdSucursal,
                                         grouping.Key.IdBodega,
                                         grouping.Key.IdMovi_inven_tipo,
                                         grouping.Key.IdNumMovi,
                                         grouping.Key.mv_tipo_movi,
                                         grouping.Key.IdProducto,
                                         grouping.Key.dm_cantidad,
                                         grouping.Key.cm_fecha,
                                         grouping.Key.Secuencia,
                                         grouping.Key.dm_observacion
                                     };


                    foreach (var item in kardex)
                    {
                        in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                        info.dm_cantidad = item.dm_cantidad;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.mv_tipo_movi = item.mv_tipo_movi;
                        info.IdProducto = item.IdProducto;
                        info.Secuencia = item.Secuencia;
                        info.dm_observacion = item.dm_observacion;
                        lista.Add(info);
                    }


                } msg = "Consulta Correcta";
                return lista;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString().ToString());
            }


        }

       public List<in_movi_inve_detalle_Info> Get_List_StockAFecha(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha) 
        {
            try
            {
                List<in_movi_inve_detalle_Info> Lst = new List<in_movi_inve_detalle_Info>();
                using (EntitiesInventario Entity = new EntitiesInventario())
                {


                    ObjectResult<spIn_Inventario_Obtener_Stock_A_Fecha_Result> Consulta = Entity.spIn_Inventario_Obtener_Stock_A_Fecha(Fecha, IdEmpresa, IdSucursal, IdBodega);
                    foreach (var item in Consulta)
                    {
                        in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();
                        Obj.dm_cantidad = Convert.ToDouble(item.Cantidad);
                        Obj.IdProducto = item.IdProducto;
                        Lst.Add(Obj);
                    }
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

       public in_movi_inve_detalle_Info Get_Info_StockAFechaPorProduct(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha) 
        {
            try
            {
                in_movi_inve_detalle_Info det = new in_movi_inve_detalle_Info();
                using (EntitiesInventario entity = new EntitiesInventario())
                {

                    ObjectResult<spIn_ObtenerStockAFechaPorProducto_Result> result = entity.spIn_ObtenerStockAFechaPorProducto(IdEmpresa, IdBodega, IdSucursal, IdProducto, Fecha);

                    foreach (var item in result)
                    {
                        det = new in_movi_inve_detalle_Info();
                        det.IdProducto = item.IdProducto;
                        det.dm_cantidad = Convert.ToDouble(item.Cantidad);
                    }
                }
                return det;
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

       public List<in_movi_inve_detalle_Info> Get_List_CuerpoKardex(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime FechaIncial,DateTime FechaFinal ) 
        {
            try
            {
                List<in_movi_inve_detalle_Info> lst = new List<in_movi_inve_detalle_Info>();
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    ObjectResult<spIn_CuerpoDelCardex_Result> resultado = entity.spIn_CuerpoDelCardex(IdEmpresa, IdBodega, IdSucursal, IdProducto, FechaIncial, FechaFinal);
                    foreach (var item in resultado)
                    {
                        in_movi_inve_detalle_Info det = new in_movi_inve_detalle_Info();
                        det.Fecha = item.cm_fecha;
                        det.NomProducto = item.pr_descripcion;
                        det.Sucursal = item.Su_Descripcion;
                        det.Bodega = item.bo_Descripcion;
                        det.TipoMoviInven = item.Mov_Inv_Tipo;
                        det.mv_tipo_movi = item.mv_tipo_movi;
                        det.dm_cantidad = item.dm_cantidad;
                        det.peso = item.dm_peso;
                        lst.Add(det);
                    }
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
                throw new Exception(ex.ToString());
            }
        }

       
    }
}

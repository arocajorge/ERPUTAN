using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
////
namespace Core.Erp.Data.Inventario
{
    public class in_producto_x_tb_bodega_Data
    {
        string mensaje = "";

        public List<in_producto_x_tb_bodega_Info> Get_List_producto_x_tb_bodega_x_Transferencia(int IdEmpresa, int IdBodega, int IdSucursal, List<in_transferencia_det_Info> listdetalle, decimal IdTransferencia)
        {
            try
            {
                  List<in_producto_x_tb_bodega_Info> lst = new List<in_producto_x_tb_bodega_Info>();
                    EntitiesInventario oEnti = new EntitiesInventario();

                    var idProducto = from q in listdetalle
                                     select q.IdProducto;

                    var select = from q in oEnti.vwin_prt_transferencia
                                 where idProducto.Contains(q.IdProducto) 
                                 && q.IdBodegaOrigen == IdBodega 
                                 && q.IdEmpresa == IdEmpresa 
                                 && q.IdSucursalOrigen == IdSucursal 
                                 && q.IdTransferencia == IdTransferencia
                                 select q;

                    foreach (var item in select)
                    {
                        in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                        info.pr_descripcion = item.pr_descripcion;
                        info.pr_codigo = item.pr_codigo;
                        info.cantidad = item.dt_cantidad;
                        info.Nom_sucursal = item.Su_Descripcion;
                        info.Nom_bodega = item.bo_Descripcion;
                        info.sucursalDest = item.SucursalDestino;
                        info.bodegaDest = item.BodegaDestinno;
                        info.Nom_Empresa = item.em_nombre;
                        info.logo = item.em_logo;
                        info.em_direccion = item.em_direccion;
                        info.em_telefonos = item.em_telefonos;
                        info.StockAnterior = Convert.ToDecimal(item.dt_cantidad + item.pr_stock);

                        info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                        info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                        info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                        info.IdCtaCble_Vta = item.IdCtaCble_Vta;

                        info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                        info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                        info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                        info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                        info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                        info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                        info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                        info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;


                        info.pr_stock = item.pr_stock;

                        lst.Add(info);
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



        public List<in_producto_x_tb_bodega_Info> Get_List_Producto_x_Bodega_x_CtasCbles(int IdEmpresa,int IdSucursal,int IdBodega)
        {
            try
            {
                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin= (IdSucursal == 0) ? 99999 : IdSucursal;
                int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
                int IdBodegaFin = (IdBodega == 0) ? 99999 : IdBodega;



                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();


                var sql = from A in OEInventario.vwin_producto_x_tb_bodega_x_Ctas_cbles
                          where A.IdEmpresa == IdEmpresa
                          && A.IdSucursal >= IdSucursalIni && A.IdSucursal <= IdSucursalFin
                          && A.IdBodega >= IdBodegaIni && A.IdBodega <= IdBodegaFin
                          select A;

                foreach (var item in sql)
                {
                    in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;

                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;

                    info.Nom_sucursal = item.nom_sucursal;
                    info.Nom_bodega = item.nom_bodega;
                    info.pr_codigo = item.cod_producto;
                    info.pr_descripcion = item.nom_producto;
                    info.IdCategoria = item.IdCategoria;
                    info.nom_categoria = item.nom_categoria;
                    info.IdLinea = item.IdLinea;
                    info.nom_linea = item.nom_linea;
                    info.IdGrupo = item.IdGrupo;
                    info.nom_grupo = item.nom_grupo;
                    
                    

                    

                    lm.Add(info);
                }

                return lm;
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


        public List<in_producto_x_tb_bodega_Info> Get_List_Producto_x_Bodega(int IdEmpresa, int IdBodega)
        {
            try
            {
                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();


                var sql = from A in OEInventario.vwin_producto_x_tb_bodega 
                          where A.IdEmpresa == IdEmpresa && A.IdBodega == IdBodega
                          select A;

                foreach (var item in sql)
                {
                    in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_puerta = item.pr_precio_puerta;
                    info.pr_precio_minimo = item.pr_precio_minimo;

                    info.pr_stock = item.pr_stock;                    
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_pedidos = item.pr_Pedidos_inv;

                    info.pr_costo_fob = item.pr_costo_fob;
                    info.pr_costo_CIF = item.pr_costo_CIF;
                    info.pr_costo_promedio = item.pr_costo_promedio;


                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;

                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                    info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                    info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                    info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                    info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                    info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                    info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;

                    lm.Add(info);
                }

                return lm;
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

        public List<in_producto_x_tb_bodega_Info> Get_list_Productos_x_Bodega(int idempresa, decimal IdProducto)
        {
            try
            {
                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                var sql = from A in OEInventario.in_producto_x_tb_bodega
                          where A.IdEmpresa == idempresa && A.IdProducto == IdProducto
                          select A;

                foreach (var item in sql)
                {
                    in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.IdProducto = item.IdProducto;
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_puerta = item.pr_precio_puerta;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_Por_descuento = item.pr_Por_descuento;
                    info.pr_stock_maximo = item.pr_stock_maximo;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_costo_fob = item.pr_costo_fob;
                    info.pr_costo_CIF = item.pr_costo_CIF;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                  
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva ;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                  
                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                    info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                    info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                    info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                    info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                    info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                    info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                   
                    info.EstaEnBase = true;

                    info.Estado = item.Estado;
                    lm.Add(info);
                }

                return lm;
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

        public List<in_producto_x_tb_bodega_Info> Get_List_ProductoxBodega_existentes_y_NoExistentes(int idempresa, decimal IdProducto)
        {
            try
            {
                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                var sql = from A in OEInventario.in_producto_x_tb_bodega
                          where A.IdEmpresa == idempresa && A.IdProducto == IdProducto
                          select A;

                foreach (var item in sql)
                {
                    in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.IdProducto = item.IdProducto;
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_puerta = item.pr_precio_puerta;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_Por_descuento = item.pr_Por_descuento;
                    info.pr_stock_maximo = item.pr_stock_maximo;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_costo_fob = item.pr_costo_fob;
                    info.pr_costo_CIF = item.pr_costo_CIF;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                 
                    info.EstaEnBase = true;



                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                    info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                    info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                    info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                    info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                    info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                    info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;

                    info.Estado = item.Estado;
                    lm.Add(info);
                }

                return lm;
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

     
        
        public Boolean ModificarDB(List<fa_pedido_det_Info> lm)
        {
            try
            {
                foreach (var item in lm)
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        var contact = context.in_producto_x_tb_bodega.FirstOrDefault(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdBodega == item.IdBodega && obj.IdProducto == item.IdProducto && obj.IdSucursal ==item.IdSucursal);
                        if (contact != null)
                        {
                            context.SaveChanges();
                            context.Dispose();
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
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    
                    foreach (var item in ls)
                    {
                        if(EDB.in_producto_x_tb_bodega.Count(v=>v.IdEmpresa== item.IdEmpresa && v.IdSucursal == item.IdSucursal&& v.IdBodega== item.IdBodega && v.IdProducto == item.IdProducto)==0)
                        {
                            var address = new in_producto_x_tb_bodega();
                            address.IdEmpresa = idempresa;
                            address.IdSucursal = item.IdSucursal;
                            address.IdBodega = item.IdBodega;
                            address.IdProducto = item.IdProducto;

                            address.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                            address.pr_precio_mayor = item.pr_precio_mayor;
                            address.pr_precio_puerta = item.pr_precio_puerta;
                            address.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                            address.pr_Por_descuento = item.pr_Por_descuento;
                            address.pr_stock_maximo = item.pr_stock_maximo;
                            address.pr_stock_minimo = item.pr_stock_minimo;
                            address.pr_costo_fob = item.pr_costo_fob;
                            address.pr_costo_CIF = item.pr_costo_CIF;
                            address.pr_costo_promedio = item.pr_costo_promedio == null ? 0 : Convert.ToDouble(item.pr_costo_promedio);

                            address.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                            address.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                            address.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                            address.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                            address.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                            address.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                            address.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                            address.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                            address.IdCtaCble_Vta = item.IdCtaCble_Vta;
                            address.Estado = "A";
                
                        


                            address.IdCtaCble_Inven = item.IdCtaCble_Inven;
                            address.IdCtaCble_Costo = item.IdCtaCble_Costo;
                            address.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                            address.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                            address.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                            address.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                            address.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                            address.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                            address.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;


                            context.in_producto_x_tb_bodega.Add(address);
                            context.SaveChanges();
                        }

                    }
                    mensaje = "Grabacion ok..";
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
                mensaje = "Error en : public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje) ...  " + ex.ToString() + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabaDB_x_item(in_producto_x_tb_bodega_Info item, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                    
                        if (EDB.in_producto_x_tb_bodega.Count(v => v.IdEmpresa == item.IdEmpresa && v.IdSucursal == item.IdSucursal && v.IdBodega == item.IdBodega && v.IdProducto == item.IdProducto) == 0)
                        {
                            var address = new in_producto_x_tb_bodega();
                            address.IdEmpresa = idempresa;
                            address.IdSucursal = item.IdSucursal;
                            address.IdBodega = item.IdBodega;
                            address.IdProducto = item.IdProducto;

                            address.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                            address.pr_precio_mayor = item.pr_precio_mayor;
                            address.pr_precio_puerta = item.pr_precio_puerta;
                            address.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                            address.pr_Por_descuento = item.pr_Por_descuento;
                            address.pr_stock_maximo = item.pr_stock_maximo;
                            address.pr_stock_minimo = item.pr_stock_minimo;
                            address.pr_costo_fob = item.pr_costo_fob;
                            address.pr_costo_CIF = item.pr_costo_CIF;
                            address.pr_costo_promedio = item.pr_costo_promedio == null ? 0 : Convert.ToDouble(item.pr_costo_promedio);

                            address.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            address.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva == "" ? null : item.IdCtaCble_CosBaseIva;
                            address.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0 == "" ? null : item.IdCtaCble_CosBase0;
                            address.IdCtaCble_VenIva = item.IdCtaCble_VenIva == "" ? null : item.IdCtaCble_VenIva;
                            address.IdCtaCble_Ven0 = item.IdCtaCble_Ven0 == "" ? null : item.IdCtaCble_Ven0;
                            address.IdCtaCble_DesIva = item.IdCtaCble_DesIva == "" ? null : item.IdCtaCble_DesIva;
                            address.IdCtaCble_Des0 = item.IdCtaCble_Des0 == "" ? null : item.IdCtaCble_Des0;
                            address.IdCtaCble_DevIva = item.IdCtaCble_DevIva == "" ? null : item.IdCtaCble_DevIva;
                            address.IdCtaCble_Dev0 = item.IdCtaCble_Dev0 == "" ? null : item.IdCtaCble_Dev0;
                            address.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            address.IdCtaCble_Vta = item.IdCtaCble_Vta == "" ? null : item.IdCtaCble_Vta;
                            address.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            address.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            address.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp == "" ? null : item.IdCtaCble_Gasto_x_cxp;
                            
                            address.Estado = "A";




                            


                            address.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                            address.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                            address.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                            address.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                            address.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                            address.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;


                            context.in_producto_x_tb_bodega.Add(address);
                            context.SaveChanges();
                      

                    }
                    mensaje = "Grabacion ok..";
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
                mensaje = "Error en : public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje) ...  " + ex.ToString() + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean ModificarDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    foreach (in_producto_x_tb_bodega_Info item in ls)
                    {
                        var contac = Contex.in_producto_x_tb_bodega.FirstOrDefault(Obj => Obj.IdEmpresa == item.IdEmpresa && Obj.IdBodega == item.IdBodega && Obj.IdSucursal == item.IdSucursal && Obj.IdProducto == item.IdProducto);
                        if (contac != null)
                        {
                            contac.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                            contac.pr_precio_mayor = item.pr_precio_mayor;
                            contac.pr_precio_puerta = item.pr_precio_puerta;
                            contac.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                            contac.pr_Por_descuento = item.pr_Por_descuento;
                            contac.pr_stock_maximo = item.pr_stock_maximo;
                            contac.pr_stock_minimo = item.pr_stock_minimo;
                            contac.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            contac.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva == "" ? null : item.IdCtaCble_CosBaseIva;
                            contac.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0 == "" ? null : item.IdCtaCble_CosBase0;
                            contac.IdCtaCble_VenIva = item.IdCtaCble_VenIva == "" ? null : item.IdCtaCble_VenIva;
                            contac.IdCtaCble_Ven0 = item.IdCtaCble_Ven0 == "" ? null : item.IdCtaCble_Ven0;
                            contac.IdCtaCble_DesIva = item.IdCtaCble_DesIva == "" ? null : item.IdCtaCble_DesIva;
                            contac.IdCtaCble_Des0 = item.IdCtaCble_Des0 == "" ? null : item.IdCtaCble_Des0;
                            contac.IdCtaCble_DevIva = item.IdCtaCble_DevIva == "" ? null : item.IdCtaCble_DevIva;
                            contac.IdCtaCble_Dev0 = item.IdCtaCble_Dev0 == "" ? null : item.IdCtaCble_Dev0;
                            contac.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            contac.IdCtaCble_Vta = item.IdCtaCble_Vta == "" ? null : item.IdCtaCble_Vta;
                            contac.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            contac.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            contac.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp == "" ? null : item.IdCtaCble_Gasto_x_cxp;
                            contac.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                            contac.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                            contac.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;
                            contac.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                            contac.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                            contac.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                            contac.Estado = (item.Estado == null) ? "A" : item.Estado;
                            Contex.SaveChanges();
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
                mensaje = "Error en : public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje) ...  " + ex.ToString() + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean ModificarDB(in_producto_x_tb_bodega_Info item,  ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                        var contac = Contex.in_producto_x_tb_bodega.FirstOrDefault(Obj => Obj.IdEmpresa == item.IdEmpresa && Obj.IdBodega == item.IdBodega && Obj.IdSucursal == item.IdSucursal && Obj.IdProducto == item.IdProducto);
                        if (contac != null)
                        {
                            contac.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                            contac.pr_precio_mayor = item.pr_precio_mayor;
                            contac.pr_precio_puerta = item.pr_precio_puerta;
                            contac.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                            contac.pr_Por_descuento = item.pr_Por_descuento;
                            contac.pr_stock_maximo = item.pr_stock_maximo == null ? 0 : item.pr_stock_maximo;
                            contac.pr_stock_minimo = item.pr_stock_minimo == null ? 0 : item.pr_stock_minimo;
                            contac.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            contac.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva == "" ? null : item.IdCtaCble_CosBaseIva;
                            contac.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0 == "" ? null : item.IdCtaCble_CosBase0;
                            contac.IdCtaCble_VenIva = item.IdCtaCble_VenIva == "" ? null : item.IdCtaCble_VenIva;
                            contac.IdCtaCble_Ven0 = item.IdCtaCble_Ven0 == "" ? null : item.IdCtaCble_Ven0;
                            contac.IdCtaCble_DesIva = item.IdCtaCble_DesIva == "" ? null : item.IdCtaCble_DesIva;
                            contac.IdCtaCble_Des0 = item.IdCtaCble_Des0 == "" ? null : item.IdCtaCble_Des0;
                            contac.IdCtaCble_DevIva = item.IdCtaCble_DevIva == "" ? null : item.IdCtaCble_DevIva;
                            contac.IdCtaCble_Dev0 = item.IdCtaCble_Dev0 == "" ? null : item.IdCtaCble_Dev0;
                            contac.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            contac.IdCtaCble_Vta = item.IdCtaCble_Vta == "" ? null : item.IdCtaCble_Vta;
                            contac.IdCtaCble_Inven = item.IdCtaCble_Inven == "" ? null : item.IdCtaCble_Inven;
                            contac.IdCtaCble_Costo = item.IdCtaCble_Costo == "" ? null : item.IdCtaCble_Costo;
                            contac.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp == "" ? null : item.IdCtaCble_Gasto_x_cxp;
                            contac.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                            contac.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                            contac.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;
                            contac.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                            contac.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                            contac.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                            contac.Estado = item.Estado;
                            Contex.SaveChanges();
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
                mensaje = "Error en : public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje) ...  " + ex.ToString() + " ";
                throw new Exception(mensaje);
            }
        }


        public Boolean ActualizarStock_x_Bodega_con_moviInven(List<in_movi_inve_detalle_Info> listaMovi,ref string mensaje)
        {
            try
            {

                //using (EntitiesInventario Contex = new EntitiesInventario())
                //{
                //    foreach (var item in listaMovi)
                //    {
                //        var contac = Contex.in_producto_x_tb_bodega.FirstOrDefault(Obj => Obj.IdEmpresa == item.IdEmpresa && Obj.IdBodega == item.IdBodega && Obj.IdSucursal == item.IdSucursal && Obj.IdProducto == item.IdProducto);
                //        if (contac != null)
                //        {
                //            contac.pr_stock = contac.pr_stock + item.dm_cantidad;
                //            contac.pr_costo_promedio = Convert.ToDouble(item.mv_costo);
                //            Contex.SaveChanges();
                //        }
                //    }
                //}
               return true;
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

        public List<in_producto_x_tb_bodega_Info> Get_List_ProductoxBodegaxSucursal(int idempresa, int idbodega,int Idsucursal)
        {
            try
            {
                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                string query = "select * from vwin_producto_x_tb_bodega where IdBodega = " + idbodega + " and IdSucursal =" + Idsucursal + " and IdEmpresa =" + idempresa;
                var sql = OEInventario.Database.SqlQuery<in_producto_x_tb_bodega_Info>(query);
                          //select A;
                return sql.ToList();
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


        public List<in_producto_x_tb_bodega_Info> Get_List_ProductoxBodegaxSucursal_q_no_existen_en_sucu_bod(int idempresa, int idbodega, int Idsucursal,List<decimal> listProducto)
        {
            try
            {
                List<in_producto_x_tb_bodega_Info> lm = new List<in_producto_x_tb_bodega_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                List<decimal> listProductos_q_estan_en_prod_x_bod = new List<decimal>();


                var Qproductos = from q in OEInventario.in_producto_x_tb_bodega
                                 where listProducto.Contains(q.IdProducto)
                                 && q.IdEmpresa == idempresa
                                 && q.IdSucursal == Idsucursal
                                 && q.IdBodega == idbodega
                                 select q;

                foreach (var item in Qproductos)
                {
                    listProductos_q_estan_en_prod_x_bod.Add(item.IdProducto);                   
                }

                if (Qproductos.Count() == listProducto.Count())
                {
                    
                    return (from q in Qproductos
                            select new in_producto_x_tb_bodega_Info()
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdSucursal = q.IdSucursal,
                                IdBodega = q.IdBodega,
                                IdProducto = q.IdProducto,
                                pr_precio_publico = q.pr_precio_publico,
                                pr_precio_mayor = q.pr_precio_mayor,
                                pr_precio_puerta = q.pr_precio_puerta,
                                pr_precio_minimo = q.pr_precio_minimo,
                                pr_Por_descuento = q.pr_Por_descuento,
                                pr_stock_maximo = q.pr_stock_maximo,
                                pr_stock_minimo = q.pr_stock_minimo,
                                pr_costo_fob = q.pr_costo_fob,
                                pr_costo_CIF = q.pr_costo_CIF,
                                pr_costo_promedio = q.pr_costo_promedio,
                  
                                Estado = q.Estado,
                    
                                     
                                IdCtaCble_Inven = q.IdCtaCble_Inven,
                                IdCtaCble_Costo = q.IdCtaCble_Costo,
                                IdCtaCble_Gasto_x_cxp = q.IdCtaCble_Gasto_x_cxp,
                                IdCentro_Costo_Inventario = q.IdCentro_Costo_Inventario,
                                IdCentro_Costo_Costo = q.IdCentro_Costo_Costo,
                                IdCentroCosto_x_Gasto_x_cxp = q.IdCentroCosto_x_Gasto_x_cxp,
                                IdCentroCosto_sub_centro_costo_inv = q.IdCentroCosto_sub_centro_costo_inv,
                                IdCentroCosto_sub_centro_costo_cost = q.IdCentroCosto_sub_centro_costo_cost,
                                IdCentroCosto_sub_centro_costo_cxp = q.IdCentroCosto_sub_centro_costo_cxp                        

                            }).ToList();
                }
                else
                {
                   List<decimal> QproductosNoExisten = (from q in listProducto
                                                         where !listProductos_q_estan_en_prod_x_bod.Contains(q)
                                     select q).ToList();

                   var Qproductos_x_in_producto = from q in OEInventario.in_producto_x_tb_bodega
                                                   where QproductosNoExisten.Contains(q.IdProducto)
                                                  && q.IdEmpresa == idempresa
                                                   select q;
                   foreach (var item in QproductosNoExisten)
                    {
                        in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                        info.IdEmpresa = idempresa;
                        info.IdBodega = idbodega;
                        info.IdProducto = item;
                        info.IdSucursal = Idsucursal;
                        //info.pr_precio_publico = item.pr_precio_publico;
                        //info.pr_precio_mayor = item.pr_precio_mayor;
                        //info.pr_precio_puerta = item.pr_precio_puerta;
                        //info.pr_precio_minimo = item.pr_precio_minimo;
                        //info.pr_costo_fob = item.pr_costo_fob;
                        //info.pr_costo_CIF = item.pr_costo_CIF;
                        //info.pr_costo_promedio = item.pr_costo_promedio;
                        info.Estado = "A";

                        //info.IdCtaCble_Inven = item.IdCtaCble_Inven; ;
                        //info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        //info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                        //info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                        //info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                        //info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                        //info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                        //info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                        //info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                       

                        lm.Add(info);                       
                    }               
                }
             
                return lm;
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

        public in_producto_x_tb_bodega_Info Get_Info_Producto_x_Producto(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto)
	    {
			EntitiesInventario oEnti= new EntitiesInventario();
            try
            {
                in_producto_x_tb_bodega_Info Info = new in_producto_x_tb_bodega_Info();
                var Objeto = oEnti.in_producto_x_tb_bodega.FirstOrDefault(var => var.IdEmpresa == IdEmpresa 
                    && var.IdProducto == IdProducto);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdBodega = Objeto.IdBodega;
                    Info.IdProducto = Objeto.IdProducto;
                    Info.pr_precio_publico = Objeto.pr_precio_publico;
                    Info.pr_precio_mayor = Objeto.pr_precio_mayor;
                    Info.pr_precio_puerta = Objeto.pr_precio_puerta;
                    Info.pr_precio_minimo = Objeto.pr_precio_minimo;
                    Info.pr_Por_descuento = Objeto.pr_Por_descuento;
                    Info.pr_stock_maximo = Objeto.pr_stock_maximo;
                    Info.pr_stock_minimo = Objeto.pr_stock_minimo;
                    Info.pr_costo_fob = Objeto.pr_costo_fob;
                    Info.pr_costo_CIF = Objeto.pr_costo_CIF;
                    Info.pr_costo_promedio = Objeto.pr_costo_promedio;

                    Info.IdCtaCble_Vta = Objeto.IdCtaCble_Vta;
                    Info.IdCtaCble_CosBaseIva = Objeto.IdCtaCble_CosBaseIva;
                    Info.IdCtaCble_CosBase0 = Objeto.IdCtaCble_CosBase0;
                    Info.IdCtaCble_VenIva = Objeto.IdCtaCble_VenIva;
                    Info.IdCtaCble_Ven0 = Objeto.IdCtaCble_Ven0;
                    Info.IdCtaCble_DesIva = Objeto.IdCtaCble_DesIva;
                    Info.IdCtaCble_Des0 = Objeto.IdCtaCble_Des0;
                    Info.IdCtaCble_DevIva = Objeto.IdCtaCble_DevIva;
                    Info.IdCtaCble_Dev0 = Objeto.IdCtaCble_Dev0;
                    Info.Estado = Objeto.Estado;


                    Info.IdCtaCble_Inven = Objeto.IdCtaCble_Inven;
                    Info.IdCtaCble_Costo = Objeto.IdCtaCble_Costo;
                    Info.IdCtaCble_Gasto_x_cxp = Objeto.IdCtaCble_Gasto_x_cxp;


                    Info.IdCentro_Costo_Inventario = Objeto.IdCentro_Costo_Inventario;
                    Info.IdCentro_Costo_Costo = Objeto.IdCentro_Costo_Costo;
                    Info.IdCentroCosto_x_Gasto_x_cxp = Objeto.IdCentroCosto_x_Gasto_x_cxp;

                    Info.IdCentroCosto_sub_centro_costo_inv = Objeto.IdCentroCosto_sub_centro_costo_inv;
                    Info.IdCentroCosto_sub_centro_costo_cost = Objeto.IdCentroCosto_sub_centro_costo_cost;
                    Info.IdCentroCosto_sub_centro_costo_cxp = Objeto.IdCentroCosto_sub_centro_costo_cxp;
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
                throw new Exception(mensaje);
            }
	}


        public in_producto_x_tb_bodega_Info Get_Info_IdCtaCble_x_Producto_x_Bodega(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdProducto)
        {
            EntitiesInventario oEnti = new EntitiesInventario();
            try
            {


                in_producto_x_tb_bodega_Info Info = new in_producto_x_tb_bodega_Info();



                var Objeto = from A in oEnti.vwin_producto_x_tb_bodega_x_Ctas_cbles
                          where A.IdEmpresa == IdEmpresa
                          && A.IdSucursal == IdSucursal
                          && A.IdBodega == IdBodega
                          && A.IdProducto == IdProducto
                          select new { A.IdCtaCble_Inven, A.IdCtaCble_Vta, A.IdCtaCble_Costo, A.IdCtaCble_Des0,A.IdCtaCble_Dev0,A.IdCtaCble_Gasto_x_cxp };


    
                if (Objeto != null)
                {

                    foreach (var item in Objeto)
                    {

                    Info.IdEmpresa = IdEmpresa;
                    Info.IdSucursal = IdSucursal;
                    Info.IdBodega = IdBodega;
                    Info.IdProducto = IdProducto;
                    Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    Info.IdCtaCble_CosBaseIva = item.IdCtaCble_Costo;
                    Info.IdCtaCble_CosBase0 = item.IdCtaCble_Costo;
                    Info.IdCtaCble_VenIva = item.IdCtaCble_Vta;
                    Info.IdCtaCble_Ven0 = item.IdCtaCble_Vta;
                    Info.IdCtaCble_DesIva = item.IdCtaCble_Des0;
                    Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    Info.IdCtaCble_DevIva = item.IdCtaCble_Dev0;
                    Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    Info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    Info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;
                    }
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
                throw new Exception(mensaje);
            }
        }


        public double Get_Stock_Actual_x_Producto(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto)
        {
            EntitiesInventario oEnti = new EntitiesInventario();
            try
            {
                double Stock_Actual = 0;



                var TStock = from prod in oEnti.in_movi_inve_detalle
                             where prod.IdEmpresa == IdEmpresa
                             && prod.IdSucursal == IdSucursa
                             && prod.IdBodega == IdBodega
                             && prod.IdProducto == IdProducto
                             group prod by new { prod.IdEmpresa, prod.IdSucursal, prod.IdBodega, prod.IdProducto }
                                 into grouping
                                 select new { grouping.Key, StockTotal = grouping.Sum(p => p.dm_cantidad) };

                if (TStock != null)
                {
                    foreach (var item in TStock)
                    {
                        Stock_Actual = item.StockTotal;
                    }
                }

                return Stock_Actual;
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

        public double Get_stock_a_fecha_corte(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto, DateTime Fecha)
        {
            EntitiesInventario oEnti = new EntitiesInventario();
            try
            {
                double Stock_Actual = 0;



                var TStock = from det in oEnti.vwin_movi_inve_detalle_para_stock_a_la_fecha
                             where det.IdEmpresa == IdEmpresa
                             && det.IdSucursal == IdSucursa
                             && det.IdBodega == IdBodega
                             && det.IdProducto == IdProducto
                             && det.cm_fecha <= Fecha
                             group det by new { det.IdEmpresa, det.IdSucursal, det.IdBodega, det.IdProducto }
                                 into grouping
                                 select new { grouping.Key, StockTotal = grouping.Sum(p => p.dm_cantidad) };

                if (TStock != null)
                {
                    foreach (var item in TStock)
                    {
                        Stock_Actual = item.StockTotal;
                    }
                }

                return Stock_Actual;
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

        public Boolean VerificarExisteProductoXSucursalXBodega(int Idempresa, int IdSucursal, int IdBodega, decimal IdProducto)//,List<string> listProducto)
        {
            try
            {
                using (EntitiesInventario Oentities = new EntitiesInventario())
                {
                    var Existe = from q in Oentities.in_producto_x_tb_bodega
                                 where q.IdEmpresa == Idempresa 
                                 && q.IdSucursal == IdSucursal 
                                 && q.IdBodega == IdBodega 
                                 && q.IdProducto == IdProducto
                                 select q;

                    if (Existe.Count() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

              
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


        public Boolean GrabaDB(in_producto_x_tb_bodega_Info item, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                        in_producto_x_tb_bodega address = new in_producto_x_tb_bodega();
                        address.IdEmpresa = idempresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdBodega = item.IdBodega;
                        address.IdProducto = item.IdProducto;

                        address.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                        address.pr_precio_mayor = item.pr_precio_mayor;
                        address.pr_precio_puerta = item.pr_precio_puerta;
                        address.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                        address.pr_Por_descuento = item.pr_Por_descuento;
                        address.pr_stock_maximo = item.pr_stock_maximo;
                        address.pr_stock_minimo = item.pr_stock_minimo;
                        address.pr_costo_fob = item.pr_costo_fob;
                        address.pr_costo_CIF = item.pr_costo_CIF;
                        address.pr_costo_promedio = item.pr_costo_promedio == null ? 0 : Convert.ToDouble(item.pr_costo_promedio);

                        address.IdCtaCble_Vta = item.IdCtaCble_Vta;
                        address.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                        address.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                        address.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        address.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        address.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        address.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        address.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        address.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                        address.Estado = "A";

                  


                        address.IdCtaCble_Inven = item.IdCtaCble_Inven;
                        address.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        address.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;


                        address.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                        address.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                        address.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                        address.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                        address.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                        address.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;


                        context.in_producto_x_tb_bodega.Add(address);
                        context.SaveChanges();


                    
                    mensaje = "Grabacion Exitosa.";
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
                mensaje = "Error en : public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje) ...  " + ex.ToString() + " ";
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminarDB(in_producto_x_tb_bodega_Info item, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    var address = context.in_producto_x_tb_bodega.FirstOrDefault(A => A.IdEmpresa == idempresa&& A.IdSucursal == item.IdSucursal && A.IdBodega == item.IdBodega&& A.IdProducto== item.IdProducto);
                    if (address != null)
                    {
                        address.IdEmpresa = idempresa;
                        address.IdSucursal = item.IdSucursal;
                        address.IdBodega = item.IdBodega;
                        address.IdProducto = item.IdProducto;
                        
                        context.in_producto_x_tb_bodega.Remove(address);
                        context.SaveChanges();
                        mensaje = "Eliminado OK..";
                    }
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
                mensaje = "Error consulte con sistemas" + ex.ToString() + "";
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    entity.Database.ExecuteSqlCommand("delete in_producto_x_tb_bodega where IdEmpresa = " + IdEmpresa + " and IdProducto = " + IdProducto);
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
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                using (EntitiesInventario entity = new EntitiesInventario())
                {
                    entity.Database.ExecuteSqlCommand("delete in_producto_x_tb_bodega where IdEmpresa = " + IdEmpresa );
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
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminaRegistros(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    foreach (var item in ls)
                    {
                        var address = context.in_producto_x_tb_bodega.FirstOrDefault(A => A.IdEmpresa == idempresa);
                        if (address != null)
                        {
                            address.IdEmpresa = idempresa;
                            address.IdSucursal = item.IdSucursal;
                            address.IdBodega = item.IdBodega;
                            address.IdProducto = item.IdProducto;

                            address.pr_precio_publico = item.pr_precio_publico == null ? 0 : Convert.ToDouble(item.pr_precio_publico);
                            address.pr_precio_mayor = item.pr_precio_mayor;
                            address.pr_precio_puerta = item.pr_precio_puerta;
                            address.pr_precio_minimo = item.pr_precio_minimo == null ? 0 : Convert.ToDouble(item.pr_precio_minimo);
                            address.pr_Por_descuento = item.pr_Por_descuento;
                            address.pr_stock_maximo = item.pr_stock_maximo;
                            address.pr_stock_minimo = item.pr_stock_minimo;
                            address.pr_costo_fob = item.pr_costo_fob;
                            address.pr_costo_CIF = item.pr_costo_CIF;
                            address.pr_costo_promedio = item.pr_costo_promedio == null ? 0 : Convert.ToDouble(item.pr_costo_promedio);
                            address.IdCtaCble_Inven = item.IdCtaCble_Inven;
                            address.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                            address.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                            address.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                            address.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                            address.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                            address.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                            address.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                            address.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                            address.IdCtaCble_Vta = item.IdCtaCble_Vta;
                            address.Estado = item.Estado;

                            context.in_producto_x_tb_bodega.Remove(address);
                            context.SaveChanges();
                            mensaje = "Eliminado OK..";
                        }
                    }
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
                mensaje = "Error consulte con sistemas" + ex.ToString() + "";
                throw new Exception(mensaje);
            }
        }

        public bool Delete_Todos_Producto_x_bodega(int IdEmpresa, ref string MensajeError)
        {

            try
            {
                using (EntitiesCompras Entity = new EntitiesCompras())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from in_producto_x_tb_bodega where IdEmpresa=" + IdEmpresa);
                }
                MensajeError = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }


        }

        public in_producto_x_tb_bodega_Data() { }
    }
}

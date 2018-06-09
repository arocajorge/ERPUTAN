using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
    public class in_Producto_data
    {
        string MensajeError = "";
        
        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto
                                     where C.IdEmpresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Producto_Info prd = new in_Producto_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;                    
                   
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.nom_Categoria = item.ca_Categoria;
                    prd.nom_Linea = item.nom_linea;
                    prd.nom_Grupo = item.nom_grupo;
                    prd.nom_SubGrupo = item.nom_subgrupo;
                    prd.nom_Marca = item.Descripcion;
                    prd.nom_Tipo_Producto = item.tp_descripcion;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdEmpresa = item.IdEmpresa;

                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    
                    prd.pr_largo = item.pr_largo;
                    
                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_pedidos = item.pr_pedidos;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_stock = item.pr_stock;
                    prd.pr_descripcion_2 = "[" + item.pr_codigo + "]- " + item.pr_descripcion;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    

                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.ManejaKardex = item.ManejaKardex;

                    //prd.IdNaturaleza = item.IdNaturaleza;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();

                    prd.IdMotivo_Vta = Convert.ToInt32(item.IdMotivo_Vta);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;



                    lM.Add(prd);
                }
                return (lM);
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

        public bool Producto_maneja_inventario(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                bool res = false;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_producto
                              where q.IdEmpresa == IdEmpresa
                              && q.IdProducto == IdProducto
                              select q;

                    foreach (var item in lst)
                    {
                        res = item.tp_ManejaInven == "S" ? true : false;
                        if(res == false)return res;
                    }
                }

                return res;
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
   
        public List<in_Producto_Info> Get_list_Producto_ManejaSeries(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto
                                     where C.IdEmpresa == IdEmpresa
                                     && C.pr_ManejaSeries == "S"
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Producto_Info prd = new in_Producto_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.nom_Categoria = item.ca_Categoria;
                    prd.nom_Marca = item.Descripcion;
                    prd.nom_Tipo_Producto = item.tp_descripcion;


                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.PesoEspecifico;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                   

                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    
                    prd.pr_largo = item.pr_largo;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_pedidos = item.pr_pedidos;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_stock = item.pr_stock;
                    //prd.Producto = "[" + item.pr_codigo + "]- " + item.pr_descripcion;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.ManejaKardex = item.ManejaKardex;
                    //prd.IdNaturaleza = item.IdNaturaleza;

                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);


                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(prd);
                }
                return (lM);
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

        public string Get_Codigo_Producto(int IdEmpresa, decimal IdProducto)
        {
            string cod_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    cod_producto = item.pr_codigo;
                }
                return cod_producto;
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
        
        public string Get_Descripcion_Producto(int IdEmpresa, decimal IdProducto)
        {
            string Des_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    Des_producto = item.pr_descripcion;
                }
                return Des_producto;
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
        
        public string DescripcionTot_Producto(int IdEmpresa, decimal IdProducto)
        {
            string producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] [" + item.pr_descripcion + "]";
                }
                return producto;

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

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal

                                        select C;
              
                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "["+item.pr_codigo.Trim() + "]"+ item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;
                    
                    info.pr_peso = item.pr_peso;

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_pedidos = item.pr_Pedidos_inv;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;  
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.ManejaKardex = item.ManejaKardex;
                    info.pr_codigo = item.pr_codigo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Bodega = item.bo_Descripcion.Trim();
                    info.nom_Sucursal = item.Su_Descripcion;

                    info.nom_Categoria = item.nom_Categoria;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Tipo_Producto = item.nom_Tipo_Producto;



                    lM.Add(info);
                }



                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 ="["+ item.pr_codigo +  "] - "+ item.pr_descripcion;
                    
                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_pedidos = item.pr_pedidos;
                    
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;  
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    

                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;
                    

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                   lM.Add(info);
                }
                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.Aparece_modu_Compras == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_pedidos = item.pr_pedidos;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.IdProductoTipo = item.IdProductoTipo;
                    lM.Add(info);
                }
                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_pedidos = item.pr_pedidos;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.IdProductoTipo = item.IdProductoTipo;
                    lM.Add(info);
                }
                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal,int IdBodega)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.IdBodega==IdBodega
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(info);
                }
                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa 
                                        && C.IdSucursal == IdSucursal
                                        && IdBodega_ini <= C.IdBodega  && C.IdBodega <= IdBodega_fin
                                        && C.Aparece_modu_Inventario == true
                                        orderby C.IdEmpresa,C.IdSucursal,C.IdBodega,C.nom_Categoria,C.nom_linea
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;

                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_disponible = item.pr_Disponible;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(info);
                }
                return (lM);
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

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega, List<in_Producto_Info> listProducto)
        {
            try
            {
                var QIdProductosAfind = from P in listProducto
                                        select P.IdProducto;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal
                                        && QIdProductosAfind.Contains(C.IdProducto)
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;
                    info.nom_Bodega = item.bo_Descripcion.Trim();
                    info.pr_peso = item.pr_peso;

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.ManejaKardex = item.ManejaKardex;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;


                    lM.Add(info);
                }
                return (lM);
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

        public Boolean GrabarDB(in_Producto_Info prI, ref decimal IdProducto, ref string mensaje)
        {
            try
            {
                try
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        EntitiesInventario EDB = new EntitiesInventario();

                        if (prI.pr_codigo != "")
                        {
                            var existe = (from per in EDB.in_Producto
                                          where per.IdEmpresa == prI.IdEmpresa
                                          && per.pr_codigo == prI.pr_codigo
                                          select per).ToList().Count();
                            if (existe != 0)
                            {
                                mensaje = "El Código ingresado ya existe por favor ingresar uno distinto";
                                return false;
                            }
                        }

                        var Q = from per in EDB.in_Producto
                                where per.IdEmpresa == prI.IdEmpresa
                                && per.IdProducto == prI.IdProducto
                                select per;

                        if (Q.ToList().Count == 0)
                        {
                            var address = new in_Producto();

                            address.IdEmpresa = prI.IdEmpresa;
                            IdProducto = GetIdProducto(prI.IdEmpresa);
                            prI.IdProducto = IdProducto;
                            address.IdProducto = IdProducto;

                            if (string.IsNullOrWhiteSpace(prI.pr_codigo))
                            {    
                                address.pr_codigo = prI.pr_codigo= Convert.ToString(IdProducto) ;
                            }
                            else
                            {
                                address.pr_codigo= prI.pr_codigo.Trim();
                            }

                            address.pr_descripcion = prI.pr_descripcion.Trim();
                            address.pr_descripcion_2 = (prI.pr_descripcion_2==null) ? "" : prI.pr_descripcion_2;
                            address.IdProductoTipo = prI.IdProductoTipo;
                            address.IdMarca = prI.IdMarca;
                            address.IdPresentacion = Convert.ToString(prI.IdPresentacion);
                            address.IdCategoria = prI.IdCategoria;
                            address.IdLinea = prI.IdLinea;
                            address.IdGrupo = prI.IdGrupo;
                            address.IdSubGrupo = prI.IdSubGrupo;
                            address.IdUnidadMedida = prI.IdUnidadMedida;
                            address.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;
                            //Naturaleza
                            address.IdMotivo_Vta = prI.IdMotivo_Vta;
                            address.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                            address.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                            address.pr_precio_mayor = prI.pr_precio_mayor;//44
                            address.pr_precio_minimo = prI.pr_precio_minimo == null ? 0 : (double)prI.pr_precio_minimo;//45
                            address.pr_precio_publico = prI.pr_precio_publico == null ? 0 : (double)prI.pr_precio_publico;//46
                            address.pr_precio_puerta = prI.pr_precio_puerta == null ? 0 : prI.pr_precio_puerta;//59
                            address.pr_ManejaIva = prI.pr_ManejaIva == null ? "N" : prI.pr_ManejaIva;//37
                            address.pr_ManejaSeries = prI.pr_ManejaSeries == null ? "N" : prI.pr_ManejaSeries;//38

                            address.pr_costo_CIF = prI.pr_costo_CIF;//28
                            address.pr_costo_fob = prI.pr_costo_fob;//29
                            address.pr_costo_promedio = prI.pr_costo_promedio == null ? 0 : (double)prI.pr_costo_promedio;//30

                            address.pr_DiasAereo = prI.pr_DiasAereo;//32
                            address.pr_DiasMaritimo = prI.pr_DiasMaritimo;//33
                            address.pr_DiasTerrestre = prI.pr_DiasTerrestre;//34
                            address.pr_largo = prI.pr_largo;//36                        
                            address.pr_alto = prI.pr_alto;
                            address.pr_profundidad = prI.pr_profundidad;
                            address.pr_peso = prI.pr_peso == null ? 0 : (double)prI.pr_peso;//42
                            address.pr_imagen_Grande = prI.pr_imagen_Grande;//10
                            address.pr_imagenPeque = prI.pr_imagenPeque;//11
                            address.pr_partidaArancel = prI.pr_partidaArancel == null ? "" : prI.pr_partidaArancel;//40
                            address.pr_porcentajeArancel = prI.pr_porcentajeArancel;//43
                            address.pr_Por_descuento = prI.pr_Por_descuento == null ? 0 : prI.pr_Por_descuento;//60
                            address.pr_stock_maximo = prI.pr_stock_maximo;//49
                            address.pr_stock_minimo = prI.pr_stock_minimo;//50
                            address.IdUsuario = (prI.IdUsuario == null) ? "" : prI.IdUsuario.Trim();//20
                            address.Fecha_Transac = DateTime.Now;//5
                            address.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                            address.Fecha_UltMod = DateTime.Now;//7

                            //address.IdUsuarioUltAnu = (prI.IdUsuarioUltAnu == null) ? "" : prI.IdUsuarioUltAnu.Trim();//21
                            //address.Fecha_UltAnu = DateTime.Now;//6
                            //pr_motivoAnulacion

                            address.ip = (prI.ip == null) ? "" : prI.ip;//23
                            address.nom_pc = (prI.nom_pc == null) ? "" : prI.nom_pc;//24
                            address.Estado = prI.Estado;//4
                            address.PesoEspecifico = prI.PesoEspecifico;//2
                            address.AnchoEspecifico = prI.AnchoEspecifico;//3
                            address.ManejaKardex = (prI.ManejaKardex == null) ? "N" : "S";//56


                            address.IdCod_Impuesto_Iva = (prI.IdCod_Impuesto_Iva == null) ? "IVA0" : prI.IdCod_Impuesto_Iva;
                            address.IdCod_Impuesto_Ice = (prI.IdCod_Impuesto_Ice == null) ? "ICE0" : prI.IdCod_Impuesto_Ice;


                            address.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                            address.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                            address.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                            address.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;

                            context.in_Producto.Add(address);
                            context.SaveChanges();

                            mensaje = "Grabacion ok..";

                        }
                        else
                            return false;
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
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarNombreItem(int IdEmpresa, string NombreItem)
        {
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                 where q.IdEmpresa == IdEmpresa
                                 && q.pr_descripcion.Trim() == NombreItem.Trim()
                                 select q).Count();

                    if (select == 0)
                    {
                        return true;
                    }else{
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarNombreItem_x_TipoProducto(int IdEmpresa, string NombreItem, int IdTipoProducto)
        {       
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                  where q.IdEmpresa == IdEmpresa
                                  && q.pr_descripcion.Trim() == NombreItem.Trim()
                                  && q.IdProductoTipo == IdTipoProducto
                                  select q).Count();

                    if (select == 0)
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
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }


        public Boolean ModificarDB(List<fa_pedido_det_Info> lm, ref string mensaje)
        {
            try
            {
                //foreach (var item in lm)
                //{
                //    using (EntitiesInventario context = new EntitiesInventario())
                //    {
                //        var contact = context.in_Producto.FirstOrDefault(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdProducto == item.IdProducto);
                //        if (contact != null)
                //        {
                //            //contact.pr_pedidos += item.dp_cantidad;
                //            context.SaveChanges();
                //            context.Dispose();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);
                    if (contact != null)
                    {
                        contact.pr_descripcion_2 = prI.pr_descripcion_2;//1
                        contact.PesoEspecifico = prI.PesoEspecifico;//2
                        contact.AnchoEspecifico = prI.AnchoEspecifico;//3
                        contact.Estado = prI.Estado;//4
                        contact.Fecha_UltMod = DateTime.Now;//7
                        contact.IdCategoria = prI.IdCategoria;//8
                        contact.pr_descripcion = prI.pr_descripcion;//9
                        contact.pr_imagen_Grande = prI.pr_imagen_Grande;//10
                        contact.pr_imagenPeque = prI.pr_imagenPeque;//11
                        contact.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;//12
                        contact.IdEmpresa = prI.IdEmpresa;//13
                        contact.IdMarca = prI.IdMarca;//14
                        contact.IdPresentacion = Convert.ToString(prI.IdPresentacion);//15
                        contact.IdProductoTipo = prI.IdProductoTipo;//18
                        contact.IdUnidadMedida = prI.IdUnidadMedida;//19
                        contact.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                        contact.pr_alto = prI.pr_alto;//25
                        contact.pr_codigo = (prI.pr_codigo == null) ? Convert.ToString(contact.IdProducto) : prI.pr_codigo;//26
                        contact.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                        contact.pr_costo_CIF = prI.pr_costo_CIF;//28
                        contact.pr_costo_fob = prI.pr_costo_fob;//29
                        contact.pr_costo_promedio = prI.pr_costo_promedio == null ? 0 : (double)prI.pr_costo_promedio;//30
                        contact.pr_descripcion = prI.pr_descripcion;//31
                        contact.pr_DiasAereo = prI.pr_DiasAereo;//32
                        contact.pr_DiasMaritimo = prI.pr_DiasMaritimo;//33
                        contact.pr_DiasTerrestre = prI.pr_DiasTerrestre;//34
                        contact.pr_largo = prI.pr_largo;//36                        
                        contact.pr_ManejaIva = prI.pr_ManejaIva == null ? "N" : prI.pr_ManejaIva;//37
                        contact.pr_ManejaSeries = prI.pr_ManejaSeries == null ? "N" : prI.pr_ManejaSeries;//38
                        contact.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                        contact.pr_partidaArancel = prI.pr_partidaArancel == null ? "" : prI.pr_partidaArancel;//40

                        contact.pr_peso = prI.pr_peso == null ? 0 : (double)prI.pr_peso;//42
                        contact.pr_porcentajeArancel = prI.pr_porcentajeArancel;//43
                        contact.pr_precio_mayor = prI.pr_precio_mayor;//44
                        contact.pr_precio_minimo = prI.pr_precio_minimo == null ? 0 : (double)prI.pr_precio_minimo;//45
                        contact.pr_precio_publico = prI.pr_precio_publico == null ? 0 : (double)prI.pr_precio_publico;//46
                        contact.pr_profundidad = prI.pr_profundidad;//47
                        contact.pr_stock_maximo = prI.pr_stock_maximo;//49
                        contact.pr_stock_minimo = prI.pr_stock_minimo;//50

                        contact.IdLinea = prI.IdLinea;//53
                        contact.IdGrupo = prI.IdGrupo;//54
                        contact.IdSubGrupo = prI.IdSubGrupo;//55
                        contact.ManejaKardex = (prI.ManejaKardex == null) ? "N" : "S";//56

                        contact.IdMotivo_Vta = prI.IdMotivo_Vta;//58
                        contact.pr_precio_puerta = prI.pr_precio_puerta == null ? 0 : prI.pr_precio_puerta;//59
                        contact.pr_Por_descuento = prI.pr_Por_descuento == null ? 0 : prI.pr_Por_descuento;//60


                        contact.IdCod_Impuesto_Iva = prI.IdCod_Impuesto_Iva;
                        contact.IdCod_Impuesto_Ice = prI.IdCod_Impuesto_Ice;

                        contact.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                        contact.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                        contact.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                        contact.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;

                        contact.Fecha_UltMod = DateTime.Now;


                        
                        
                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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

        public decimal GetIdProducto(int IdEmpresa)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_Producto
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

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

        public decimal GetIdProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OEPrd = new EntitiesInventario();
                    var selectCbtecble = (from PrdxCat in OEPrd.in_Producto
                                          where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdCategoria == IdCategoria
                                          select PrdxCat.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

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

        public string GetCodProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                string CodPrdxCat;
                decimal iIdProducto_x_Categoria;

                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdCategoria == IdCategoria
                        select A;

                if (q.ToList().Count < 1)
                {
                    CodPrdxCat = "1";
                }
                else
                {

                    iIdProducto_x_Categoria = this.GetIdProducto_x_Categoria(IdEmpresa, IdCategoria) - 1;

                    OEPrd = new EntitiesInventario();
                    var selectPrdxCat = (from PrdxCat in OEPrd.in_Producto
                                         where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdProducto == iIdProducto_x_Categoria
                                          select PrdxCat.pr_codigo).ToArray();

                    CodPrdxCat = selectPrdxCat[0];
                }
                return CodPrdxCat;
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
                
        public Boolean AnularDB(in_Producto_Info ProductoInfo, ref  string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(prod1 => prod1.IdEmpresa == ProductoInfo.IdEmpresa && prod1.IdProducto == ProductoInfo.IdProducto);
                    if (contact != null)
                    {
                        //no elimino el registro solo cambia el estado de activo a inactivo

                        contact.Estado = "I"; //cambio el estado de activo por inactivo
                        contact.pr_observacion = " ***ANULADO***" + contact.pr_observacion;
                        contact.IdUsuarioUltAnu = ProductoInfo.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = ProductoInfo.IdUsuarioUltMod;
                        contact.pr_motivoAnulacion = ProductoInfo.pr_motivoAnulacion;
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

        public in_Producto_Info Get_Info_BuscarProducto(int IdEmpresa , decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;
                
                foreach (var item in selectCbtecble)
                {
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;


                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    prd.pr_largo = item.pr_largo;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    
                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;

                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.ManejaKardex = item.ManejaKardex;

                    
                    

                    prd.IdLinea =Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    
                }
                return (prd);
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

        public in_Producto_Info Get_info_Producto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {

                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.pr_precio_publico = item.pr_precio_publico;




                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.PesoEspecifico;
                    prd.ManejaKardex = item.ManejaKardex;
                    

                    
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdLinea =Convert.ToInt32( item.IdLinea);
                    prd.IdGrupo =Convert.ToInt32( item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;


                    
                }
                return (prd);
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

        public List<in_Producto_Info> Get_list_MateriaPrima(int IdEmpresa) 
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario  Oentities = new EntitiesInventario())
                {

                    string Query ="select * from in_producto where IdEmpresa ="+IdEmpresa+" and IdProductoTipo =" +
                                                "(select IdProductoTipo from in_productotipo where IdEmpresa =" + IdEmpresa + " and EsMateriaPrima = 'S' )";
                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                return   Producto.ToList();
                }
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

        public List<in_Producto_Info> Get_list_ProductosTerminados(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {
                    


                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new {t.IdEmpresa,t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         && t.EsProductoTerminado=="S"
                                         select C;

                      foreach (var item in selectCbtecble)
                      {
                          in_Producto_Info prd = new in_Producto_Info();
                          prd.IdEmpresa = item.IdEmpresa;
                          prd.Estado = item.Estado.Trim();
                          prd.Fecha_Transac = item.Fecha_Transac;
                          prd.Fecha_UltAnu = item.Fecha_UltAnu;
                          prd.Fecha_UltMod = item.Fecha_UltMod;
                          prd.IdCategoria = item.IdCategoria.Trim();
                          prd.pr_imagen_Grande = item.pr_imagen_Grande;
                          prd.pr_imagenPeque = item.pr_imagenPeque;
                          prd.IdPresentacion = item.IdPresentacion;
                          prd.pr_descripcion = item.pr_descripcion;
                          prd.PesoEspecifico = item.PesoEspecifico;
                          prd.AnchoEspecifico = item.AnchoEspecifico;
                          prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                          prd.IdEmpresa = item.IdEmpresa;
                          prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                          prd.IdProducto = item.IdProducto;
                          prd.IdProductoTipo = item.IdProductoTipo;

                          prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                          prd.IdUsuario = item.IdUsuario.Trim();
                          prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                          prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                          prd.ip = item.ip.Trim();
                          prd.nom_pc = item.nom_pc.Trim();
                          prd.pr_alto = item.pr_alto;
                          prd.pr_codigo = item.pr_codigo.Trim();
                          prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                          prd.pr_costo_CIF = item.pr_costo_CIF;
                          prd.pr_costo_fob = item.pr_costo_fob;
                          prd.pr_costo_promedio = item.pr_costo_promedio;
                          prd.pr_descripcion = item.pr_descripcion.Trim();
                          prd.pr_DiasAereo = item.pr_DiasAereo;
                          prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                          prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                          prd.pr_largo = item.pr_largo;
                          prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                          prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                          prd.pr_observacion = item.pr_observacion.Trim();
                          prd.pr_partidaArancel = item.pr_partidaArancel;
                          prd.pr_peso = item.pr_peso;
                          prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                          prd.pr_precio_mayor = item.pr_precio_mayor;
                          prd.pr_precio_minimo = item.pr_precio_minimo;
                          prd.pr_precio_publico = item.pr_precio_publico;
                          prd.pr_profundidad = item.pr_profundidad;
                          prd.pr_stock_maximo = item.pr_stock_maximo;
                          prd.pr_stock_minimo = item.pr_stock_minimo;
                          prd.IdProductoTipo = item.IdProductoTipo;

                          prd.IdLinea = Convert.ToInt32(item.IdLinea);
                          prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                          prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                          prd.IdProductoTipo = item.IdProductoTipo;
                          prd.ManejaKardex = item.ManejaKardex;

                          //prd.IdNaturaleza = item.IdNaturaleza;

                          prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                          prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                          prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                          prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                          prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                          prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                          

                          

                          lista.Add(prd);
                      }
                }
                    return lista;
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

        public List<in_Producto_Info> Get_list_ProductosTerminados_x_ListadoDiseno(int IdEmpresa, int IdListadoDiseno)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventarioEdehsa Oentities = new EntitiesInventarioEdehsa())
                {



                    var selectCbtecble = from C in Oentities.vwin_Producto_x_ListadoDiseno
                                       
                                         where C.IdEmpresa == IdEmpresa
                                         && C.EsProductoTerminado == "S"
                                         && C.IdListadoDiseno == IdListadoDiseno
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                        prd.pr_largo = item.pr_largo;
                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
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
        
        public Boolean ValidarProductExiste(string Nombre) 
        {
            try
            {
                EntitiesInventario oen = new EntitiesInventario();
                var Prod = from q in oen.in_Producto
                           where q.pr_descripcion == Nombre
                           select q;
                if (Prod.ToList().Count() > 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
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
       
        public in_Producto_Info Get_Info_ProductoXNombre(int IdEmpresa, string Descripcion)
        {
            try
            {
                using (EntitiesInventario Oenti = new EntitiesInventario())
                {
                    
                    in_Producto_Info Info = new in_Producto_Info();
                    string query = "select * from in_Producto where IdEmpresa = "+IdEmpresa+" and pr_descripcion like'"+Descripcion+"'";
                    var Consulta = Oenti.Database.SqlQuery<in_Producto_Info>(query);
                    Info = Consulta.First();

                    return Info;
                }
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

        public List<in_Producto_Info> Get_list_ProductosXModeloProduccion(int IdEmpresa, int IdModeloProduccion) 
        {
            try
            {   
                EntitiesInventario Oen = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProducto in"
                                +" (select  IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa = "+IdEmpresa+" and IdModeloProd ="+IdModeloProduccion+") "
                                +" and IdEmpresa = "+IdEmpresa;
                return Oen.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
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

        public List<in_Producto_Info> Get_list_MateriaPrimaModulosdeProduccion(int IdEmpresa) 
        {
            try
            {
                 List<in_Producto_Info> lista= new List<in_Producto_Info>();
                EntitiesInventario oent = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProductoTipo = "
                               + " (select  IdProductoTipo from in_ProductoTipo where IdEmpresa = " + IdEmpresa + " and EsMateriaPrima = 'S' ) and IdEmpresa =  "+IdEmpresa +
                                "    and IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa = "+IdEmpresa+")";

                return oent.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
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



        public List<in_Producto_Info> Get_list_ProductosMateriaPrima(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {



                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         && t.EsMateriaPrima == "S"
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                        prd.pr_largo = item.pr_largo;
                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
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

        public List<in_Producto_Info> Get_list_ProductosMateriaPrimaDimension(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventarioEdehsa Oentities = new EntitiesInventarioEdehsa())
                {



                    var selectCbtecble = from C in Oentities.vwin_ProductoDimension
                                         where C.IdEmpresa == IdEmpresa
                                         && C.EsMateriaPrima == "S"
                                         //&& C.IdProductoTipo == 
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                        prd.pr_largo = item.longitud;

                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
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

        public List<in_Producto_Info> Get_list_ProductosMateriaPrimaDimension_x_TipoProducto(int IdEmpresa, int IdTipoProducto)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventarioEdehsa Oentities = new EntitiesInventarioEdehsa())
                {



                    var selectCbtecble = from C in Oentities.vwin_ProductoDimension
                                         where C.IdEmpresa == IdEmpresa
                                         && C.EsMateriaPrima == "S"
                                         && C.IdProductoTipo == IdTipoProducto
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                        prd.pr_largo = item.longitud;

                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
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


        public List<in_Producto_Info> Get_list_Productos_x_TipoProducto(int IdEmpresa, int IdTipoProducto)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventarioEdehsa Oentities = new EntitiesInventarioEdehsa())
                {



                    var selectCbtecble = from C in Oentities.vwin_ProductoDimension
                                         where C.IdEmpresa == IdEmpresa
                                         && C.EsMateriaPrima == "S"
                                         && C.IdProductoTipo == IdTipoProducto
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                        prd.pr_largo = item.longitud;

                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                        


                        lista.Add(prd);
                    }
                }
                return lista;
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

        


        public List<in_Producto_Info> Get_list_MateriaPrima_X_ModeloDeProduccion(int IdEmpresa, int IdModeloProduccion) 
        {
            try
            {
                EntitiesInventario oEn = new EntitiesInventario();
                string Querty = " DECLARE @iDEMPRESA INT =  "+IdEmpresa+
                                " select * from in_Producto where IdProductoTipo = "+
                                " (select  IdProductoTipo from in_ProductoTipo where IdEmpresa = @iDEMPRESA and EsMateriaPrima = 'S' ) and IdEmpresa = @iDEMPRESA "+
                                " and IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa =@iDEMPRESA  )"+
                                " and IdProducto In(Select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =@iDEMPRESA and IdModeloProd =" + IdModeloProduccion+")";

                return oEn.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
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

        public List<in_Producto_Info> Get_list_ProductosSucursalXBodegaXModulodeProduccion(int IdEmpresa, int IdModeloProduccion,int IdBodega,int IdSucursa)
        {
            try
            {
                EntitiesInventario oEn = new EntitiesInventario();
                string Querty = "DECLARE @iDEMPRESA INT = " + IdEmpresa +
                                  "  select a.*,b.Tipo from in_Producto a " +
                                  "  inner join prod_ModeloProduccion_x_Producto_CusTal b on a.IdEmpresa =b.IdEmpresa and a.IdProducto = b.IdProducto  " +
                                  " where  a.IdEmpresa = @iDEMPRESA  " +
                                  "  and a.IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa =@iDEMPRESA and IdBodega ="+IdBodega+" and IdSucursal ="+IdSucursa+" ) " +
                                  "  and a.IdProducto In(Select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =@iDEMPRESA and IdModeloProd ="+IdModeloProduccion+") ";

                return oEn.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
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

        public List<in_Producto_Info> Get_list_Productos_X_Proveedor(int IdEmpresa, decimal IdProveedor, int IdEmpresa_x_Proveedor, string Esta = "") 
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();
                string NomPro = "";
                string Descrip = "";
                if (Esta == "")
                {
                    
                    NomPro = "  inner join in_producto_x_cp_proveedor D on A.IdProducto = D.IdProducto and A.IdEmpresa = D.IdEmpresa_prod" +
                                 "   and d.IdEmpresa_prov =" + IdEmpresa + " and d.IdProveedor =" + IdProveedor + " ";

                    Descrip = ", D.NomProducto_en_Proveedor as Producto ";
                }

                string Query = "   SELECT A.*, B.ca_Categoria, C.Descripcion as Marca " + Descrip +
                                   " FROM in_Producto AS A INNER JOIN "+
                                   " in_categorias AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdCategoria = B.IdCategoria INNER JOIN "+
                                   " in_Marca AS C ON A.IdEmpresa = C.IdEmpresa AND A.IdMarca = C.IdMarca "+NomPro+

                                   " where ( cast(A.IdEmpresa as varchar(10)) + cast(A.IdProducto as varchar(20)) ) " + Esta + " in  " +
                                   " ( "+
                                   " select cast(A.IdEmpresa_prod as varchar(10)) + cast(A.IdProducto as varchar(20)) "+
                                   " from in_producto_x_cp_proveedor A "+
                                   " where A.IdEmpresa_prov = " + IdEmpresa_x_Proveedor +
                                   " and A.IdProveedor = " + IdProveedor +
                                   " ) and A.IdEmpresa = "+IdEmpresa;

                lista = Oen.Database.SqlQuery<in_Producto_Info>(Query).ToList();

                return lista;
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

        public List<in_Producto_Info> Get_list_Productos_x_Empresa(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();

                var select = from q in Oen.vwin_in_Producto_x_tb_bodega_x_UnidadMedida
                             where q.IdEmpresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    in_Producto_Info Info = new in_Producto_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProducto = item.IdProducto;
                    Info.pr_codigo = item.pr_codigo;
                    Info.pr_descripcion = item.pr_descripcion;
                    Info.pr_codigo_barra = item.pr_codigo_barra;
                    Info.IdProductoTipo = item.IdProductoTipo;
                    Info.IdPresentacion = item.IdPresentacion;
                    Info.IdCategoria = item.IdCategoria;
                    Info.pr_observacion = item.pr_observacion;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    Info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;
                    Info.pr_ManejaIva = item.pr_ManejaIva;
                    Info.pr_costo_fob = item.pr_costo_fob;
                    Info.pr_ManejaSeries = item.pr_ManejaSeries;
                    Info.pr_costo_CIF = item.pr_costo_CIF;
                    Info.pr_costo_promedio = item.pr_costo_promedio_bodega;
                    Info.pr_peso = item.pr_peso;
                    Info.pr_stock_Bodega = item.pr_stock_Bodega;
                    Info.IdCtaCble_Inventario = item.IdCtaCble_Inven;
                    Info.pr_stock = item.pr_stock;
                    Info.pr_pedidos = item.pr_pedidos;
                    Info.pr_precio_publico = item.pr_precio_publico;
                    Info.pr_precio_minimo = item.pr_precio_minimo;
                    Info.IdLinea =Convert.ToInt32( item.IdLinea);
                    Info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    Info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                    Info.IdBodega = item.IdBodega;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMarca = item.IdMarca;
                    Info.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    Info.pr_DiasAereo = item.pr_DiasAereo;
                    Info.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    Info.pr_partidaArancel = item.pr_partidaArancel;
                    Info.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    Info.nom_pc = item.nom_pc;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuario = item.IdUsuario;
                    Info.pr_profundidad = item.pr_profundidad;
                    Info.pr_alto = item.pr_alto;
                    Info.pr_largo = item.pr_largo;
                    Info.pr_precio_mayor = item.pr_precio_mayor;


                    Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    

                    
                    
                    Info.ip = item.ip;
                    Info.Estado = item.Estado;
                    Info.pr_imagenPeque = item.pr_imagenPeque;
                    Info.pr_imagen_Grande = item.pr_imagen_Grande;
                    
                    Info.CodBarra = item.pr_codigo_barra;
                    
                    Info.IdPresentacion = item.IdPresentacion;

                    Info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                    Info.AnchoEspecifico = item.AnchoEspecifico;
                    Info.pr_stock_maximo = item.pr_stock_maximo;
                    Info.PesoEspecifico = item.PesoEspecifico;
                    Info.ManejaKardex = item.ManejaKardex;
                    Info.pr_stock_minimo = item.pr_stock_minimo;
                    Info.pr_descripcion_2 = item.pr_descripcion_2;
                    Info.pr_motivoAnulacion = item.pr_motivoAnulacion;

                    Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    Info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;


                    Info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    Info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    Info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    Info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lista.Add(Info);
                }

                return lista;
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
       

        public List<in_Producto_Info> Get_list_ProductoTerminado_X_ModeloDeProduccion(int IdEmpresa, int IdTipoModelo)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                using (EntitiesInventario Oen = new EntitiesInventario())
                {


                    string Query = "select * from in_Producto where IdProducto in (select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =" + IdEmpresa + " and IdModeloProd=" + IdTipoModelo + "and Tipo='PRODTERMI') and IdEmpresa =" + IdEmpresa;

                    var Consulta = Oen.Database.SqlQuery<in_Producto_Info>(Query);
                    lista = Consulta.ToList();
                }

                return lista;
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

        public bool Delete_Todos_Producto(int IdEmpresa, ref string  MensajeError)
        {

            try
            {
                using (EntitiesCompras Entity = new EntitiesCompras())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_producto where IdEmpresa = " + IdEmpresa  );
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

        public in_Producto_Info GetProducto(int IdEmpresa, string CodBarra)
        {
            try
            {
                //prueba    
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.in_Producto
                                        where C.IdEmpresa == IdEmpresa && C.pr_codigo_barra == CodBarra

                                        select C;
                in_Producto_Info info = new in_Producto_Info();
                foreach (var item in select_Inventario)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "[" + item.pr_codigo.Trim() + "]" + item.pr_descripcion.Trim();
                    info.pr_peso = item.pr_peso;
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;


                    info.ManejaKardex = item.ManejaKardex;
                    
                    
                    info.IdCategoria = item.IdCategoria;
                    info.IdLinea =Convert.ToInt32( item.IdLinea);
                    info.IdGrupo =Convert.ToInt32( item.IdGrupo);
                    info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;



                  
                    
                }
                return info;
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

        public List<in_Producto_Info> Get_list_Productos_not_exist_in_producto_x_bodega(int IdEmpresa, int Idsucursal, int idbodega)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {

                    string Query = " SELECT        Prod.IdEmpresa, Prod.IdProducto, Prod.pr_codigo, Prod.pr_descripcion, Prod.pr_descripcion_2, Prod.IdProductoTipo, Prod.IdMarca, Prod.IdPresentacion, Prod.IdCategoria, Prod.IdLinea, Prod.IdGrupo,  ";
                    Query = Query + " Prod.IdSubGrupo, Prod.IdUnidadMedida, Prod.IdUnidadMedida_Consumo, Prod.IdNaturaleza, Prod.IdMotivo_Vta, Prod.IdCod_Impuesto_Iva, Prod.IdCod_Impuesto_Ice, Prod.Aparece_modu_Ventas, ";
                    Query = Query + " Prod.Aparece_modu_Compras, Prod.Aparece_modu_Inventario, Prod.Aparece_modu_Activo_F, Prod.Estado, prodT.tp_descripcion AS nom_Tipo_Producto, cat.ca_Categoria AS nom_Categoria, ";
                    Query = Query + " L.nom_linea AS nom_Linea";
                    Query = Query + " FROM            in_linea AS L INNER JOIN ";
                    Query = Query + " in_categorias AS cat ON L.IdEmpresa = cat.IdEmpresa AND L.IdCategoria = cat.IdCategoria INNER JOIN ";
                    Query = Query + " in_Producto AS Prod INNER JOIN ";
                    Query = Query + " in_ProductoTipo AS prodT ON Prod.IdEmpresa = prodT.IdEmpresa AND Prod.IdProductoTipo = prodT.IdProductoTipo ON L.IdEmpresa = Prod.IdEmpresa AND L.IdCategoria = Prod.IdCategoria AND  ";
                    Query = Query + " L.IdLinea = Prod.IdLinea ";
                    Query = Query + " where  ";
                    Query = Query + " not exists( ";
                    Query = Query + " select A.IdProducto from  in_producto_x_tb_bodega A  ";
                    Query = Query + " where A.IdEmpresa = " + IdEmpresa;
                    Query = Query + " and A.IdBodega =  " + idbodega;
                    Query = Query + " and A.IdSucursal =  " + Idsucursal;
                    Query = Query + " and A.IdProducto = Prod.IdProducto ";
                    Query = Query + " and A.IdEmpresa=Prod.IdEmpresa ";
                    Query = Query + " )";
                    Query = Query + " and Prod.IdEmpresa=" + IdEmpresa;
                    
                   
                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                    return Producto.ToList();
                }
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
    }
}


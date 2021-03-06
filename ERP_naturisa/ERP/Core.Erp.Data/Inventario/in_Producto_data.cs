﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace Core.Erp.Data.Inventario
{
    public class in_Producto_data
    {
        string MensajeError = "";

        public bool ValidaExisteMovimiento(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    int Cont =  db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdProducto == IdProducto).Count();
                    if (Cont > 0)
                        return true;
                }

                return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_Producto_Combo> GetListCombo(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Combo> Lista = new List<in_Producto_Combo>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdProducto, a.pr_codigo, a.pr_descripcion, b.fa_Descripcion, a.IdUnidadMedida, a.IdCod_Impuesto_Iva, a.IdUnidadMedida_Consumo from in_producto as a left join in_familia as b on a.IdEmpresa = b.IdEmpresa and a.IdFamilia = b.IdFamilia where a.Estado = 'A' AND a.IdEmpresa = "+IdEmpresa.ToString();
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new in_Producto_Combo
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_codigo = Convert.ToString(reader["pr_codigo"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            fa_Descripcion = Convert.ToString(reader["fa_Descripcion"]),
                            IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                            IdCod_Impuesto_Iva = Convert.ToString(reader["IdCod_Impuesto_Iva"]),
                            IdUnidadMedida_Consumo = Convert.ToString(reader["IdUnidadMedida_Consumo"])
                        });
                    }
                    reader.Close();
                }
                
                return Lista;
            }
            catch (Exception)
            {
                return new List<in_Producto_Combo>();
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.IdEmpresa, a.IdProducto, a.pr_codigo, a.pr_descripcion, a.IdProductoTipo, a.IdCategoria, b.ca_Categoria, a.IdLinea, c.nom_linea, a.IdGrupo, d.nom_grupo, a.Estado,"
                                        +" a.IdFamilia, e.fa_Descripcion, a.IdUnidadMedida, f.Descripcion as NomUnidadMedidaCompra, a.IdUnidadMedida_Consumo, g.Descripcion as NomUnidadMedidaConsumo,"
                                        +" a.IdSubGrupo, a.IdMarca, h.tp_descripcion, a.pr_codigo_barra, a.IdCod_Impuesto_Iva, a.IdCod_Impuesto_Ice,"
                                        +" Aparece_modu_Activo_F, a.Aparece_modu_Compras, a.Aparece_modu_Inventario, a.Aparece_modu_Ventas, a.mobile_cod_produccion,"
                                        + " '['+cast(a.IdProducto as varchar)+'] '+a.pr_descripcion  pr_descripcion_2, a.IdPresentacion"
                                        +" from in_producto as a left join"
                                        +" in_categorias as b on a.idempresa = b.idempresa and a.IdCategoria = b.IdCategoria left join"
                                        +" in_linea as c on a.IdEmpresa = c.idempresa and a.IdCategoria = c.IdCategoria and a.IdLinea = c.IdLinea left join"
                                        +" in_grupo as d on a.IdEmpresa = d.IdEmpresa and a.IdCategoria = d.IdCategoria and a.IdLinea = d.IdLinea and a.IdGrupo = d.IdGrupo left join"
                                        +" in_Familia as e on a.IdEmpresa = e.IdEmpresa and a.IdFamilia = e.IdFamilia left join"
                                        +" in_UnidadMedida as f on a.IdUnidadMedida = f.IdUnidadMedida left join"
                                        +" in_UnidadMedida as g on a.IdUnidadMedida_Consumo = g.IdUnidadMedida left join"
                                        +" in_ProductoTipo as h on a.IdEmpresa = h.IdEmpresa and a.IdProductoTipo = h.IdProductoTipo"
                                        +" where a.IdEmpresa = "+IdEmpresa.ToString();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new in_Producto_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_codigo = Convert.ToString(reader["pr_codigo"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            IdProductoTipo = Convert.ToInt32(reader["IdProductoTipo"]),
                            IdCategoria = Convert.ToString(reader["IdCategoria"]),
                            nom_Categoria = Convert.ToString(reader["ca_Categoria"]),
                            IdLinea = Convert.ToInt32(reader["IdLinea"]),
                            nom_Linea = Convert.ToString(reader["nom_linea"]),
                            IdGrupo = Convert.ToInt32(reader["IdGrupo"]),
                            nom_Grupo = Convert.ToString(reader["nom_grupo"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            IdFamilia = reader["IdFamilia"] == DBNull.Value ? null : (int?)(reader["IdFamilia"]),
                            fa_Descripcion = Convert.ToString(reader["fa_Descripcion"]),
                            IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                            nom_UnidadMedida = Convert.ToString(reader["NomUnidadMedidaCompra"]),
                            IdUnidadMedida_Consumo = Convert.ToString(reader["IdUnidadMedida_Consumo"]),
                            nom_UnidadMedida_Consumo = Convert.ToString(reader["NomUnidadMedidaConsumo"]),
                            IdSubGrupo = Convert.ToInt32(reader["IdSubGrupo"]),
                            IdMarca = reader["IdMarca"] == DBNull.Value ? 0 : (int)(reader["IdMarca"]),
                            nom_Tipo_Producto = Convert.ToString(reader["tp_descripcion"]),
                            pr_codigo_barra = Convert.ToString(reader["pr_codigo_barra"]),
                            IdCod_Impuesto_Iva = Convert.ToString(reader["IdCod_Impuesto_Iva"]),
                            IdCod_Impuesto_Ice = Convert.ToString(reader["IdCod_Impuesto_Ice"]),
                            Aparece_modu_Activo_F = reader["Aparece_modu_Activo_F"] == DBNull.Value ? false : Convert.ToBoolean(reader["Aparece_modu_Activo_F"]),
                            Aparece_modu_Compras = reader["Aparece_modu_Compras"] == DBNull.Value ? false : Convert.ToBoolean(reader["Aparece_modu_Compras"]),
                            Aparece_modu_Inventario = reader["Aparece_modu_Inventario"] == DBNull.Value ? false : Convert.ToBoolean(reader["Aparece_modu_Inventario"]),
                            Aparece_modu_Ventas = reader["Aparece_modu_Ventas"] == DBNull.Value ? false : Convert.ToBoolean(reader["Aparece_modu_Ventas"]),
                            mobile_cod_produccion = Convert.ToString(reader["mobile_cod_produccion"]),
                            pr_descripcion_2 = Convert.ToString(reader["pr_descripcion_2"]),
                            IdPresentacion = Convert.ToString(reader["IdPresentacion"])
                        });
                    }
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

                List<in_Producto_Info> lM = new List<in_Producto_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select b.IdEmpresa, b.IdSucursal, b.IdBodega, b.IdProducto, a.pr_codigo, a.pr_descripcion, '['+cast(a.IdProducto as varchar)+'] '+a.pr_descripcion as pr_descripcion2,"
                                +" a.IdUnidadMedida, a.IdUnidadMedida_Consumo, a.IdCod_Impuesto_Iva"
                                +" from in_Producto as a inner join"
                                +" in_producto_x_tb_bodega as b on a.IdEmpresa = b.IdEmpresa and a.IdProducto = b.IdProducto"
                                +" where a.IdEmpresa = "+IdEmpresa.ToString()+" and b.IdSucursal = "+IdSucursal.ToString()+" and b.IdBodega = "+IdBodega.ToString()+" and a.Aparece_modu_Inventario = 1 and a.Estado = 'A'";
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new in_Producto_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdBodega = Convert.ToInt32(reader["IdBodega"]),
                            IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                            pr_codigo = Convert.ToString(reader["pr_codigo"]),
                            pr_descripcion = Convert.ToString(reader["pr_descripcion"]),
                            pr_descripcion_2 = Convert.ToString(reader["pr_descripcion2"]),
                            IdUnidadMedida = Convert.ToString(reader["IdUnidadMedida"]),
                            IdUnidadMedida_Consumo = Convert.ToString(reader["IdUnidadMedida_Consumo"]),
                            IdCod_Impuesto_Iva = Convert.ToString(reader["IdCod_Impuesto_Iva"])
                        });
                    }
                    reader.Close();
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
                            address.IdUsuarioUltMod = prI.IdUsuario;
                            address.Fecha_UltMod = DateTime.Now;
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
                            address.IdUsuario = prI.IdUsuario;
                            address.Fecha_Transac = DateTime.Now;//5

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
                            address.IdFamilia = prI.IdFamilia;
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

        public bool ValidarStock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, double Cantidad, double CantidadAnterior, ref string pr_descripcion)
        {
            try
            {
                double Cont = 0;
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var producto = db.in_Producto.Where(q => q.IdEmpresa == IdEmpresa && q.IdProducto == IdProducto).FirstOrDefault();
                    if (producto == null)
                        return false;

                    pr_descripcion = producto.pr_descripcion;

                    if (db.in_Ing_Egr_Inven_det.Include("in_Ing_Egr_Inven").Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdProducto == IdProducto && q.in_Ing_Egr_Inven.Estado == "A" && q.in_Ing_Egr_Inven.in_Motivo_Inven.Genera_Movi_Inven == "S").Count() > 0)
                    {
                        Cont = db.in_Ing_Egr_Inven_det.Include("in_Ing_Egr_Inven").Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdProducto == IdProducto && q.in_Ing_Egr_Inven.Estado == "A" && q.in_Ing_Egr_Inven.in_Motivo_Inven.Genera_Movi_Inven=="S").Sum(q => q.dm_cantidad);    
                    }
                    double Final = Math.Round((CantidadAnterior + Cont) - Cantidad,2,MidpointRounding.AwayFromZero);
                    if (Final < 0)
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
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
                        contact.IdFamilia = prI.IdFamilia;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = prI.IdUsuarioUltMod;


                        
                        
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

        public Boolean ModificarDBProcesoCerrado(in_Producto_Info prI)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_Producto.Where(q => q.IdEmpresa == prI.IdEmpresa && q.IdProducto == prI.IdProducto).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    Entity.IdCategoria = prI.IdCategoria;
                    Entity.IdGrupo = prI.IdGrupo;
                    Entity.IdLinea = prI.IdLinea;
                    Entity.IdSubGrupo = prI.IdSubGrupo;
                    Entity.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;
                    Entity.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                    Entity.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                    Entity.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                    Entity.IdFamilia = prI.IdFamilia;

                    Entity.IdUsuarioUltMod = prI.IdUsuario;
                    Entity.Fecha_UltMod = DateTime.Now;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
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

        public List<in_Producto_Info> GetListProductoCombo(int IdEmpresa, Cl_Enumeradores.eModulos Modulo)
        {
            try
            {
                List<in_Producto_Info> Lista = new List<in_Producto_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string sql = "select IdEmpresa,IdProducto,pr_descripcion,IdUnidadMedida,IdUnidadMedida_Consumo ";
                    sql += "from in_Producto where IdEmpresa = " + IdEmpresa.ToString() + " and Estado = 'A' ";

                    switch (Modulo)
                    {
                        case Cl_Enumeradores.eModulos.COMP:
                            sql += " AND Aparece_modu_Compras = 1";
                            break;
                        case Cl_Enumeradores.eModulos.FAC:
                            sql += " AND Aparece_modu_Ventas = 1";
                            break;
                        case Cl_Enumeradores.eModulos.INV:
                            sql += " AND Aparece_modu_Inventario = 1";
                            break;
                        default:
                            break;
                    }

                    SqlCommand command = new SqlCommand(sql, connection);
                     SqlDataReader reader = command.ExecuteReader();
                     while (reader.Read())
                     {
                         Lista.Add(new in_Producto_Info
                         {
                             IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                             IdProducto = Convert.ToDecimal(reader["IdProducto"]),
                             pr_descripcion = reader["pr_descripcion"].ToString(),
                             IdUnidadMedida = reader["IdUnidadMedida"].ToString(),
                             IdUnidadMedida_Consumo = reader["IdUnidadMedida_Consumo"].ToString(),
                             pr_descripcion_2 = "[" + reader["IdProducto"].ToString()+"] "+reader["pr_descripcion"].ToString()
                         });
                     }
                }
            
                return Lista;
            }
            catch (Exception)
            {
                
                throw;
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

        public double GetStockProductoPorEmpresa(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                double Stock = 0;

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var query = db.in_movi_inve_detalle.Where(q => q.IdEmpresa == IdEmpresa && q.IdProducto == IdProducto).GroupBy(q => new { q.IdEmpresa, q.IdProducto }).Select(q => q.Sum(v => v.dm_cantidad)).FirstOrDefault();
                    if (query != null)
                        Stock = query;
                }

                return Stock;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<in_Producto_Info> GetListStockPorBodega(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                List<in_Producto_Info> Lista;

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.SetCommandTimeOut(3000);
                    Lista = db.SPINV_Stock(IdEmpresa, IdProducto).Select(q => new in_Producto_Info
                    {
                        IdEmpresa = q.idempresa,
                        nom_Sucursal = q.Su_Descripcion,
                        nom_Bodega = q.bo_Descripcion,
                        pr_stock = q.Stock
                    }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_Producto_ComprasAnteriores> GetListCompras(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                List<in_Producto_ComprasAnteriores> Lista;

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.SetCommandTimeOut(3000);
                    Lista = db.SPINV_ComprasAnteriores(IdEmpresa, IdProducto).Select(q => new in_Producto_ComprasAnteriores
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSucursal = q.IdSucursal,
                        IdOrdenCompra = q.IdOrdenCompra,
                        Secuencia = q.Secuencia,
                        IdProducto = q.IdProducto,
                        IdProveedor = q.IdProveedor,
                        pr_descripcion = q.pr_descripcion,
                        do_precioCompra = q.do_precioCompra,
                        do_porc_des = q.do_porc_des,
                        do_descuento = q.do_descuento,
                        do_precioFinal = q.do_precioFinal,
                        oc_fecha = q.oc_fecha,
                        Codigo = q.Codigo,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        NomUnidadMedida = q.NomUnidadMedida
                    }).OrderByDescending(q=> q.oc_fecha).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                return new List<in_Producto_ComprasAnteriores>();
            }
        }
    }
}


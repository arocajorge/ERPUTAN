using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Inventario
{
    public class in_producto_busqueda_Dat
    {
        string mensaje = "";
        public List<in_Producto_Info> obtenerListProducto(List<in_categorias_Info> listCategoria, int IdEmpresa,int IdSucursal,int IdBodega)
        {





            try
            {


            //    List<in_Producto_Info> lst = new List<in_Producto_Info>();
                in_categorias_data CatD = new in_categorias_data();
            //    EntitiesInventario OEINVENTARIOS = new EntitiesInventario();
            //    EntitiesGeneral OEGeneral = new EntitiesGeneral();




                if (listCategoria.Count == 0)
                {
                    listCategoria = CatD.Get_List_categorias(IdEmpresa);
                }


                var qcat = from cat in listCategoria
                           select cat.IdCategoria;

                //var sucursal = from suc in oegeneral.tb_sucursal
                //             select suc;
           
                    

                  


            //        var select = from C in OEINVENTARIOS.vwin_producto_x_tb_bodega
            //                     //join P in OEINVENTARIOS.in_Marca
            //                     //on new { C.IdEmpresa, C.IdMarca } equals new { P.IdEmpresa, P.IdMarca }
            //                     //join Ca in OEINVENTARIOS.in_categorias
            //                     //on new { C.IdEmpresa, C.IdCategoria } equals new { Ca.IdEmpresa, Ca.IdCategoria }
            //                     //join Tp in OEINVENTARIOS.in_ProductoTipo
            //                     //on new { C.IdEmpresa, C.IdProductoTipo } equals new { Tp.IdEmpresa, Tp.IdProductoTipo}
            //                     //join Pr in OEINVENTARIOS.vwIn_Presentacion
            //                     //on new {  } equals new { }
            //                     //join Umd in OEINVENTARIOS.vwIn_UnidadMedida
            //                     //on new {  } equals new { }
            //                     where C.IdEmpresa == IdEmpresa  && C.IdSucursal ==IdSucursal
            //                     && C.IdBodega == IdBodega
            //                     //&& qCat.Contains(C.IdCategoria)
            //                     //&& C.IdPresentacion == Pr.CodPresentacion
            //                     //&& C.IdUnidadMedida == Umd.CodUnidad
            //                     select new
            //                     {
            //                         C.pr_codigo,
            //                         C.pr_descripcion,
            //                         C.IdCategoria,
            //                         C.pr_peso,
            //                         C.IdSucursal,
            //                         C.IdBodega,
            //                         C.IdMarca,
            //                       //  NomMarca = P.Descripcion,
            //                         C.IdProducto,
            //                         C.pr_precio_publico,
            //                         C.pr_precio_mayor,
            //                         C.pr_precio_minimo,
            //                         C.pr_ManejaIva,
            //                         //Ca.RutaPadre,
            //                         C.bo_Descripcion,
            //                         C.Su_Descripcion,
            //                         C.IdProductoTipo,
            //                         C.IdUnidadMedida,
            //                         C.IdPresentacion,
            //                         C.pr_stock,
            //                         C.pr_pedidos,
            //                        //ProdTipo = Tp.tp_descripcion,
            //                       //Pr.NomPresentacion,
            //                        //Umd.NomUnidad
                                    
                                     

            //                     };
            //        /////////////////////////////////////////////////////////
            //        foreach (var item1 in select)
            //        {

            //            in_Producto_Info pr = new in_Producto_Info();
            //            pr.IdProducto = item1.IdProducto;
            //            pr.pr_codigo = item1.pr_codigo;
            //            pr.pr_descripcion = item1.pr_descripcion;
            //            pr.IdCategoria = item1.IdCategoria;
            //            pr.pr_peso = item1.pr_peso;
            //            pr.IdSucursal = item1.IdSucursal;
            //            pr.IdBodega = item1.IdBodega;
            //            pr.IdMarca = item1.IdMarca;
            //            //pr.Marca = item1.NomMarca;
            //            pr.pr_precio_publico = item1.pr_precio_publico;
            //            pr.pr_precio_minimo = item1.pr_precio_minimo;
            //            pr.pr_precio_mayor = item1.pr_precio_mayor;
            //            pr.pr_ManejaIva = item1.pr_ManejaIva;
            //            //pr.RutaPadre = item1.RutaPadre;
            //            pr.Bodega = item1.bo_Descripcion;
            //            pr.Sucursal = item1.Su_Descripcion;
            //            pr.IdProductoTipo = item1.IdProductoTipo;
            //            pr.IdUnidadMedida = item1.IdUnidadMedida;
            //            pr.IdPresentacion=item1.IdPresentacion;
            //            //pr.Tipo_Producto = item1.ProdTipo;
            //            //pr.Presentacion = item1.NomPresentacion;
            //            //pr.UndadMedida = item1.NomUnidad;
            //            pr.pr_stock = item1.pr_stock;
            //            pr.pr_pedidos = item1.pr_pedidos;
                        
                       
                       
            //                lst.Add(pr);



            //        }
            //        //////////////////////////////////////////////////////////
            //        OEINVENTARIOS.Dispose();
                    

                    List<in_Producto_Info> lst = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega  where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal   select C;      
               
                var Marcas = from q in OEInventario.in_Marca  select q;

                var Categorias = from Ca in OEInventario.in_categorias select Ca;

                var join = (from C in select_Inventario
                           
                           select C).ToList();

                foreach (var item1 in join)
                {
                    in_Producto_Info pr = new in_Producto_Info();
                    pr.IdProducto = item1.IdProducto;
                    pr.pr_codigo = item1.pr_codigo;
                    pr.pr_descripcion = item1.pr_descripcion;
                   // pr.IdCategoria = item1.IdCategoria;
                    pr.pr_peso = item1.pr_peso;
                    pr.IdSucursal = item1.IdSucursal;
                    pr.IdBodega = item1.IdBodega;
                    pr.IdMarca = Convert.ToInt32(item1.IdMarca);
                    //pr.Marca = item1.NomMarca;
                    pr.pr_precio_publico = item1.pr_precio_publico;
                    pr.pr_precio_minimo = item1.pr_precio_minimo;
                    pr.pr_precio_mayor = item1.pr_precio_mayor;
                    pr.pr_ManejaIva = item1.pr_ManejaIva;
                    //pr.RutaPadre = item1.RutaPadre;
                    pr.Bodega = item1.bo_Descripcion;
                    pr.Sucursal = item1.Su_Descripcion;
                    pr.IdProductoTipo = item1.IdProductoTipo;
                    pr.IdUnidadMedida = item1.IdUnidadMedida;
                    pr.IdPresentacion = item1.IdPresentacion;
                    //pr.Tipo_Producto = item1.ProdTipo;
                    //pr.Presentacion = item1.NomPresentacion;
                    //pr.UndadMedida = item1.NomUnidad;
                    pr.pr_stock = item1.pr_stock;
                    pr.pr_pedidos = item1.pr_pedidos;


                    lst.Add(pr);
                }


                 return (lst);

                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public List<in_Producto_Info> Stokc_X_Bodeta(in_Producto_Info prd)
        {

            try
            {
                   EntitiesInventario OEINVENTARIOS = new EntitiesInventario();
                   List<in_Producto_Info> lst = new List<in_Producto_Info>();
                   var select = from c in OEINVENTARIOS.vwin_producto_x_tb_bodega
                                where c.IdProducto == prd.IdProducto
                                select new { c.pr_codigo, c.pr_descripcion, c.Su_Descripcion, c.bo_Descripcion, c.pr_pedidos, c.pr_precio_publico,
                                                c.pr_stock, c.IdBodega , c.IdSucursal,c.IdProducto};
                   foreach (var item in select)
                   {
                       in_Producto_Info producto = new in_Producto_Info();
                       producto.pr_codigo = item.pr_codigo;
                       producto.pr_descripcion = item.pr_descripcion;
                       producto.Sucursal = item.Su_Descripcion;
                       producto.Bodega = item.bo_Descripcion;
                       producto.pr_precio_publico = item.pr_precio_publico;
                       producto.pr_pedidos = item.pr_pedidos;
                       producto.pr_stock = item.pr_stock;
                       producto.IdBodega = item.IdBodega;
                       producto.IdSucursal = item.IdSucursal;
                       producto.IdProducto = item.IdProducto;
                       lst.Add(producto);

                   }
                   return (lst);

             }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Data.Inventario_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//verssion 24062013 1625
namespace Core.Erp.Data.Inventario_Cidersus
{
    public class in_movi_inve_detalle_x_Producto_CusCider_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstInfo, ref string msg)
        { //---------------------
            try
            {
                int sec = 0;
                foreach (var item in LstInfo)
                {
                    sec = sec + 1;
                    List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                    using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                    {
                        var Address = new in_movi_inve_detalle_x_Producto_CusCider();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdBodega = item.IdBodega;
                        Address.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Address.IdNumMovi =  item.IdNumMovi;
                        Address.mv_Secuencia = item.mv_Secuencia; 
                        Address.Secuencia = sec;
                        Address.IdProducto = item.IdProducto;
                        Address.CodigoBarra = (item.CodigoBarra == "" || item.CodigoBarra == null) ?
                             ("E" + item.IdEmpresa + "S" + item.IdSucursal +
                             "B" + item.IdBodega + "T" + item.IdMovi_inven_tipo + "M" + item.IdNumMovi +
                             "P" + item.IdProducto + "I" + sec)
                             : item.CodigoBarra;
                        Address.mv_tipo_movi = item.mv_tipo_movi;
                        Address.dm_cantidad = item.dm_cantidad;
                        Address.dm_observacion = (item.dm_observacion == null) ? "" : item.dm_observacion;
                        Address.dm_precio = item.dm_precio;
                        Address.mv_costo = item.mv_costo;
                        Address.et_IdEmpresa = item.IdEmpresa;
                        Address.et_IdProcesoProductivo = item.et_IdProcesoProductivo;
                        Address.et_IdEtapa = null;
                        Address.ot_IdEmpresa = item.IdEmpresa;
                        Address.ot_IdSucursal = item.IdSucursal;
                        Address.ot_CodObra = item.ot_CodObra;
                        Address.ot_IdOrdenTaller = item.ot_IdOrdenTaller;

                        Address.CodObra_preasignada = item.CodObra_preasignada;
                        Address.IdOrdenTaller_preasignada = item.IdOrdenTaller_preasignada;

                        Address.Alto = item.pr_alto;
                        Address.Largo = item.pr_largo;

                        Address.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                        Address.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                        Address.NumFacturaProveedor = item.NumFacturaProveedor;

                        Context.in_movi_inve_detalle_x_Producto_CusCider.Add(Address);
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }


        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Get_List_in_movi_inve_detalle_x_Producto_CusCider(int idempresa, int idsucursal, int idbodega, decimal idnunmovi, int idinv_movitipo)
       {
           try
           {
			List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>() ;
			EntitiesProduccion_Cidersus oEnti= new EntitiesProduccion_Cidersus();
			var Query = from q in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                        where q.IdEmpresa == idempresa 
                                && q.IdSucursal == idsucursal
                                && q.IdBodega == idbodega 
                                && q.IdNumMovi == idnunmovi 
                                && q.IdMovi_inven_tipo == idinv_movitipo
                                
				        select q;

			 foreach (var item in Query)
             {
			
				in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info() ;
					Obj.IdEmpresa= item.IdEmpresa;
					Obj.IdSucursal= item.IdSucursal;
					Obj.IdBodega= item.IdBodega;
					Obj.IdMovi_inven_tipo= item.IdMovi_inven_tipo;
					Obj.IdNumMovi= item.IdNumMovi;
                    Obj.mv_Secuencia = item.mv_Secuencia;
					Obj.Secuencia= item.Secuencia;
					Obj.IdProducto= item.IdProducto;
					Obj.CodigoBarra= item.CodigoBarra;
					Obj.mv_tipo_movi= item.mv_tipo_movi;
					Obj.dm_cantidad= item.dm_cantidad;
					Obj.dm_observacion= item.dm_observacion;
					Obj.dm_precio= item.dm_precio;
					Obj.mv_costo= item.mv_costo;
					Obj.et_IdEmpresa= Convert.ToInt32(item.et_IdEmpresa);
                    Obj.et_IdProcesoProductivo = Convert.ToInt32(item.et_IdProcesoProductivo);
					Obj.et_IdEtapa=Convert.ToInt32( item.et_IdEtapa);
					Obj.ot_IdEmpresa= Convert.ToInt32(item.ot_IdEmpresa);
					Obj.ot_IdSucursal= Convert.ToInt32(item.ot_IdSucursal);
					Obj.ot_CodObra= item.ot_CodObra;
					Obj.ot_IdOrdenTaller= Convert.ToDecimal(item.ot_IdOrdenTaller);
                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

				Lst.Add(Obj);
             }
			return Lst;
           }
		catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString() + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Get_List_in_movi_inve_detalle_x_Producto_CusCider(int idempresa, int idsucursal, int idbodega, decimal idnunmovi, int idinv_movitipo, decimal IdProducto)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                            where q.IdEmpresa == idempresa
                                    && q.IdSucursal == idsucursal
                                    && q.IdBodega == idbodega
                                    && q.IdNumMovi == idnunmovi
                                    && q.IdMovi_inven_tipo == idinv_movitipo
                                    && q.IdProducto == IdProducto 
                            select q;

                foreach (var item in Query)
                {

                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.mv_Secuencia = item.mv_Secuencia;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.mv_tipo_movi = item.mv_tipo_movi;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.dm_observacion = item.dm_observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.mv_costo;
                    Obj.et_IdEmpresa = Convert.ToInt32(item.et_IdEmpresa);
                    Obj.et_IdProcesoProductivo = Convert.ToInt32(item.et_IdProcesoProductivo);
                    Obj.et_IdEtapa = Convert.ToInt32(item.et_IdEtapa);
                    Obj.ot_IdEmpresa = Convert.ToInt32(item.ot_IdEmpresa);
                    Obj.ot_IdSucursal = Convert.ToInt32(item.ot_IdSucursal);
                    Obj.ot_CodObra = item.ot_CodObra;
                    Obj.ot_IdOrdenTaller = Convert.ToDecimal(item.ot_IdOrdenTaller);

                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        
        public void GenerarRpt(int IdEmpresa, int IdSucursal, int IdBodega,  int  IdMovi_inven_tipo, decimal IdNumMovi,string IdUsuario, string nom_pc)
        {
            try
            {
                using (EntitiesProduccion_Cidersus base_ = new EntitiesProduccion_Cidersus())
                {
                    string query = "exec  spPRD_Rpt_RPRD001 " + IdEmpresa + " , " + IdSucursal + " , '"
                        + IdBodega + "', '" + IdMovi_inven_tipo + "', '" + IdNumMovi + "', '"
                        + IdUsuario + "', '" + nom_pc + "'";
                    base_.Database.ExecuteSqlCommand(query);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Get_List_in_movi_inve_detalle_x_Producto_CusCider(int idempresa, decimal idproducto)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                            where q.IdEmpresa == idempresa
                            && q.IdProducto == idproducto
                            select q;

                foreach (var item in Query)
                {

                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.mv_Secuencia = item.mv_Secuencia;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.mv_tipo_movi = item.mv_tipo_movi;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.dm_observacion = item.dm_observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.mv_costo;
                    Obj.et_IdEmpresa = Convert.ToInt32(item.et_IdEmpresa);
                    Obj.et_IdProcesoProductivo = Convert.ToInt32(item.et_IdProcesoProductivo);
                    Obj.et_IdEtapa = Convert.ToInt32(item.et_IdEtapa);
                    Obj.ot_IdEmpresa = Convert.ToInt32(item.ot_IdEmpresa);
                    Obj.ot_IdSucursal = Convert.ToInt32(item.ot_IdSucursal);
                    Obj.ot_CodObra = item.ot_CodObra;
                    Obj.ot_IdOrdenTaller = Convert.ToDecimal (item.ot_IdOrdenTaller);

                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public in_movi_inve_detalle_x_Producto_CusCider_Info Get_Info_in_movi_inve_detalle_x_Producto_CusCider(string codbarra, int IdEmpresa)
        {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos
                            where q.CodigoBarra == codbarra 
                            && q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in Query)
                {

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.pr_peso = item.pr_peso;
                    Obj.longitud = item.longitud;
                    Obj.alto = item.alto;
                    Obj.pr_descripcion = item.pr_descripcion;

                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

                    Obj.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                    
                }
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public in_movi_inve_detalle_x_Producto_CusCider_Info Get_Info_in_movi_inve_detalle_x_Producto_CusCider_UltMov(string codbarra, int IdEmpresa, string TipoMovimiento)
        {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                EntitiesInventarioEdehsa oEnti = new EntitiesInventarioEdehsa();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov
                            where q.CodigoBarra == codbarra
                            && q.IdEmpresa == IdEmpresa
                            && q.mv_tipo_movi == TipoMovimiento
                            select q;

                foreach (var item in Query)
                {

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.pr_peso = item.pr_peso;
                    Obj.longitud = item.longitud;
                    Obj.alto = item.alto;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

                    Obj.dm_cantidad = Convert.ToDouble(item.dm_cantidad);

                }
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> TraeProductoSobrante(int IdTipoMovimiento)
        {
            try
             {
                
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

                EntitiesInventarioEdehsa oEnti = new EntitiesInventarioEdehsa();
                //var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov
                //            where q.IdMovi_inven_tipo == IdTipoMovimiento
                //            select q;

                var summary = from p in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_UltMov
                              let k = new
                              {
                                  //try this if you need a date field 
                                  //   p.SaleDate.Date.AddDays(-1 *p.SaleDate.Day - 1)
                                  IdProduct = p.IdProducto,
                                  Product = p.pr_descripcion,
                                  bodega = p.bodega,
                                  largo_conversion = p.largo_conversion,
                                  alto_conversion = p.alto_conversion
                              }
                              where p.IdMovi_inven_tipo == IdTipoMovimiento
                              group p by k into t
                              select new
                              {
                                  IdProduct = t.Key.IdProduct,
                                  Product = t.Key.Product,
                                  bodega = t.Key.bodega,
                                  largo_conversion = t.Key.largo_conversion,
                                  alto_conversion = t.Key.alto_conversion,
                                  Qty = t.Sum(p => p.dm_cantidad)
                              };



                foreach (var item in summary)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    //Obj.IdEmpresa = item.IdEmpresa;
                    //Obj.IdSucursal = item.IdSucursal;
                    //Obj.IdBodega = item.IdBodega;
                    //Obj.IdProducto = item.IdProducto;
                    //Obj.CodigoBarra = item.CodigoBarra;
                    //Obj.pr_peso = item.pr_peso;
                    Obj.IdProducto = item.IdProduct;
                    Obj.largo_conversion = item.largo_conversion;
                    Obj.alto_conversion = item.alto_conversion;

                    Obj.pr_descripcion = item.Product;

                    Obj.bo_descripcion = item.bodega;
                   

                    Obj.dm_cantidad = Convert.ToDouble(item.Qty);
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }



        public in_movi_inve_detalle_x_Producto_CusCider_Info Get_Info_in_movi_inve_detalle_x_Producto_CusCider_(string codbarra, int IdEmpresa)
     {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();



                //EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                //var Query = from q in oEnti.vwin_Producto_a_Cortar_CusCider
                //          where q.CodigoBarra == codbarra 
                //          && q.IdEmpresa == IdEmpresa
                //        select q;
                //foreach (var item in Query)
                //{
                //    Obj.IdEmpresa = item.IdEmpresa;
                //    Obj.IdSucursal = item.IdSucursal;
                //    Obj.IdBodega = item.IdBodega;
                //    Obj.IdProducto = item.IdProducto;
                //    Obj.CodigoBarra = item.CodigoBarra;
                //    Obj.dm_cantidad = Convert.ToDouble(item.dm_cantidad);
                //    Obj.pr_descripcion = item.pr_descripcion;
                //    Obj.pr_alto = item.pr_alto;
                //    Obj.pr_largo = item.pr_largo;
                //    Obj.pr_profundidad = item.pr_profundidad;
                //    Obj.pr_peso = item.pr_peso;
                //    Obj.pr_Observacion = item.pr_observacion;
                //    Obj.bo_descripcion = item.bo_Descripcion;
                //    Obj.su_descripcion = item.Su_Descripcion;
                //    Obj.ca_Categoria = item.ca_Categoria;
                //    Obj.tp_descripcion = item.tp_descripcion;
                //    Obj.pr_Observacion = item.pr_observacion;
                //    Obj.pr_codigo = item.pr_codigo;
                //    Obj.Marca = item.Descripcion;
                //    Obj.ot_IdOrdenTaller = item.ot_IdOrdenTaller;
                //    Obj.ot_CodObra = item.ot_CodObra;
                //    Obj.et_IdProcesoProductivo = item.et_IdProcesoProductivo;
                //}                            
                return Obj;
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<in_movi_inve_detalle_Info> Get_List_in_movi_inve_detalle(in_movi_inve_Info Info)
        {
            try
            {
                List<in_movi_inve_detalle_Info> Lst = new List<in_movi_inve_detalle_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_Movi_Inven_x_CodBarra_CusCider
                            where q.IdEmpresa == Info.IdEmpresa
                            && q.IdSucursal == Info.IdSucursal
                            && q.IdBodega == Info.IdBodega
                            && q.IdMovi_inven_tipo==Info.IdMovi_inven_tipo
                            && q.IdNumMovi==Info.IdNumMovi
                            select q;
            
                
                           foreach (var item in Query)
                           {  
                               
                               in_movi_inve_detalle_Info InfoAdd= new in_movi_inve_detalle_Info();
                               InfoAdd.IdEmpresa = item.IdBodega;
                               InfoAdd.IdSucursal = item.IdSucursal;
                               InfoAdd.IdBodega = item.IdBodega;
                               InfoAdd.IdProducto = item.IdProducto;
                               InfoAdd.pr_descripcion = item.pr_descripcion;
                               InfoAdd.CodigoBarra = item.CodigoBarra;
                               InfoAdd.observacion = item.cm_observacion;
                               InfoAdd.ot_CodObra = item.ot_CodObra;
                               InfoAdd.ot_IdordenTaller =Convert.ToInt32( item.ot_IdOrdenTaller);
                               InfoAdd.et_IdProcesoProductivo = item.et_IdProcesoProductivo;

                               Lst.Add(InfoAdd);
                          }
              return Lst;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra(int idempresa, DateTime Fecha,int IdBodega, int IdSucursal)
        {
            try
            {

               Fecha= Convert.ToDateTime(Fecha.ToShortDateString());

                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> Lst = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos
                            where q.IdEmpresa == idempresa
                            //&& q.Fecha_Transac == Fecha
                            && q.IdSucursal==IdSucursal
                            && q.IdBodega==IdBodega
                                                        
                            select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.CodigoProducto =item.pr_codigo;
                    Obj.observacion = item.observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.dm_precio;
                  
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra_x_Obra_x_OT(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string Codobra_preasignada, decimal IdOrdenTaller_preasignada)
        {
            try
            {

                Fecha = Convert.ToDateTime(Fecha.ToShortDateString());

                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> Lst = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos
                            where q.IdEmpresa == idempresa
                                //&& q.Fecha_Transac == Fecha
                            && q.IdSucursal == IdSucursal
                            && q.IdBodega == IdBodega
                            && q.CodObra_preasignada == Codobra_preasignada
                            && q.IdOrdenTaller_preasignada == IdOrdenTaller_preasignada

                            select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.CodigoProducto = item.pr_codigo;
                    Obj.observacion = item.observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.dm_precio;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarra_x_Obra(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string Codobra_preasignada)
        {
            try
            {

                Fecha = Convert.ToDateTime(Fecha.ToShortDateString());

                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> Lst = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos
                            where q.IdEmpresa == idempresa
                                //&& q.Fecha_Transac == Fecha
                            && q.IdSucursal == IdSucursal
                            && q.IdBodega == IdBodega
                            && q.CodObra_preasignada == Codobra_preasignada
                            select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.CodigoProducto = item.pr_codigo;
                    Obj.observacion = item.observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.dm_precio;

                    Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                    Obj.NumFacturaProveedor = item.NumFacturaProveedor;

                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> SaldosxItemsxCodBarraxOT(int idempresa, DateTime Fecha, int IdSucursal, int IdBodega, string ot_Codobra, decimal ot_IdOrdenTaller)
        {
            try
            {

                Fecha = Convert.ToDateTime(Fecha.ToShortDateString());

                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> Lst = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos
                            where q.IdEmpresa == idempresa
                                //&& q.Fecha_Transac == Fecha
                            && q.IdSucursal == IdSucursal
                            && q.IdBodega == IdBodega
                            && q.ot_CodObra == ot_Codobra
                            && q.ot_IdOrdenTaller == ot_IdOrdenTaller

                            select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.CodigoProducto = item.pr_codigo;
                    Obj.observacion = item.observacion;
                    Obj.dm_precio = item.dm_precio;
                    Obj.mv_costo = item.dm_precio;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info SaldosxItemsxCodBarra(in_movi_inve_detalle_x_Producto_CusCider_Info Info  )
        {
            try
            {
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var item = oEnti.vwin_movi_inve_detalle_x_Producto_CusCider_Saldos.First( q=>
                            q.IdEmpresa == Info.IdEmpresa
                            && q.IdSucursal == Info.IdSucursal
                            && q.IdBodega == Info.IdBodega
                            && q.IdProducto == Info.IdProducto
                            && q.CodigoBarra == Info.CodigoBarra );
                            

                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    
                return Obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }




        
        public List<in_movi_inve_detalle_Info> ValidarProdxCodBarra(List<in_movi_inve_detalle_Info> LstMovDet)
        {
            try
            {
                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> Lst = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                Lst = SaldosxItemsxCodBarra(LstMovDet[0].IdEmpresa,DateTime.Now,1,1);

                var temporal = from C in LstMovDet
                               join B in Lst
                               on new { C.IdEmpresa, C.IdSucursal, C.IdBodega, C.IdProducto }
                               equals new { B.IdEmpresa, B.IdSucursal, B.IdBodega, B.IdProducto }
                               select new {
                                   C.IdEmpresa,
                                   C.IdSucursal,
                                   C.IdBodega,
                                   C.IdMovi_inven_tipo,
                                   C.IdNumMovi,
                                   C.Secuencia,
                                   C.mv_tipo_movi,
                                   C.IdProducto,
                                   C.dm_cantidad,
                                   C.dm_stock_ante,
                                   C.dm_stock_actu,
                                   C.dm_observacion,
                                   C.dm_precio,
                                   C.mv_costo,
                                   B.CodigoBarra,
                                   C.CodBarra

                               };

                LstMovDet = new List<in_movi_inve_detalle_Info>();
                foreach (var item in temporal)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    info.IdNumMovi = item.IdNumMovi;
                    info.Secuencia = item.Secuencia;
                    info.mv_tipo_movi = item.mv_tipo_movi;
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = item.dm_cantidad;
                    info.dm_stock_ante = item.dm_stock_ante;
                    info.dm_stock_actu = item.dm_stock_actu;
                    info.dm_observacion = item.dm_observacion;
                    info.dm_precio = item.dm_precio;
                    info.mv_costo = item.mv_costo;
                    info.CodBarra = item.CodBarra ;
                    if (item.CodigoBarra == item.CodigoBarra )
                    {
                        
                        info.valida = true;
                    }
                    else
                    {
                        
                        info.valida = false;
                        LstMovDet.Add(info);
                        break;
                    }
                    LstMovDet.Add(info);
                }
               

                return LstMovDet;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        
        }
        
        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> ObtenerMateriaPrima(int IdEmpresa, int Idsucursal, int Idbodega, int ot_IdSucursal,decimal ot_IdOrdenTaller, string ot_Codobra, int ot_IdEmpresa)      
        {
            try
            {
                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> lista = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oent = new EntitiesProduccion_Cidersus();

               var Query = from q in oent.vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == Idsucursal
                            && q.IdBodega == Idbodega
                           select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.observacion = item.pr_descripcion;
                    lista.Add(Obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        
        }
  
        public Boolean AnularDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMovi_inven_tipo, ref  string msg)
        {

            try
            {


                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    string Query = "update in_movi_inve_detalle_x_Producto_CusCider " +
                                    "set dm_observacion ='**ANULADO** cant. Ant.:'+ cast(dm_cantidad  as varchar(20)) + dm_observacion " +
                                    ",dm_cantidad =0 " +
                                     "where IdEmpresa =" + IdEmpresa + " and IdNumMovi =" + IdNumMovi + " and IdSucursal =" + IdSucursal + " and IdBodega = " + IdBodega + " and IdMovi_inven_tipo = " + IdMovi_inven_tipo;

                    var sad = context.Database.ExecuteSqlCommand(Query);

                }
                msg = "Proceso exitoso";


                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ObtenerProductosxEtapa(in_movi_inve_detalle_x_Producto_CusCider_Info Item) 
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                string Query = "select * from vwprd_ControlProduccion_Producto_x_Etapa where et_IdEmpresa = " + Item.et_IdEmpresa + " and et_IdProcesoProductivo= " + Item.et_IdProcesoProductivo + " and et_IdEtapa =" + Item .et_IdEtapa+ " and ot_IdEmpresa ="+Item.ot_IdEmpresa
                                                       + "and ot_IdSucursal = " + Item.ot_IdSucursal + " and ot_IdOrdenTaller=" + Item.ot_IdOrdenTaller + " and IdEmpresa =" + Item.IdEmpresa + " And IdSucursal =" + Item.IdSucursal + " And IdBodega =" + Item.IdBodega;
                using(EntitiesProduccion oent = new EntitiesProduccion())
	            {
                    var Consulta = oent.Database.SqlQuery<in_movi_inve_detalle_x_Producto_CusCider_Info>(Query);


                    lista = Consulta.ToList();
	            }

                


                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }



        public List<vwIn_Movi_Inven_CusCider_Cab_Info> ConsultaMovimientos(int idempresa, int idsucursal, int idbodega, decimal idnumMovi, int idMoviTipo)
        {
            try
            {
                List<vwIn_Movi_Inven_CusCider_Cab_Info> Lst = new List<vwIn_Movi_Inven_CusCider_Cab_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_Movi_Inven_CusCider_Cab
                            where q.IdEmpresa == idempresa
                            && q.IdSucursal == idsucursal
                            && q.IdBodega == idbodega
                            && q.IdNumMovi == idnumMovi
                            && q.IdMovi_inven_tipo == idMoviTipo
                            select q;
                foreach (var item in Query)
                {
                    vwIn_Movi_Inven_CusCider_Cab_Info Obj = new vwIn_Movi_Inven_CusCider_Cab_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.CodMoviInven = item.CodMoviInven;
                    Obj.cm_tipo = item.cm_tipo;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                    Obj.IdProvedor = Convert.ToDecimal(item.IdProvedor);
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.bo_Descripcion = item.bo_Descripcion;
                    Obj.Codigo = item.Codigo;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.pr_nombre = item.pr_nombre;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxEnsamblado(decimal en_IdEnsamblado, int en_idsucursal, int en_IdEmpresa)
        {
            try
            {
                List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> Lst = new List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_Movi_Inven_x_Ensamblado_CusCider_Cab
                            where q.en_IdEmpresa == en_IdEmpresa
                            && q.en_IdSucursal == en_idsucursal 
                            && q.en_IdEnsamblado == en_IdEnsamblado 
                            select q;
                foreach(var item in Query)
                {
                    vwIn_Movi_Inven_x_TI_CusCider_Cab_Info Obj = new vwIn_Movi_Inven_x_TI_CusCider_Cab_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.CodMoviInven = item.CodMoviInven;
                    Obj.cm_tipo = item.cm_tipo;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.IdProvedor = Convert.ToDecimal(item.IdProvedor);
                    Obj.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.bo_Descripcion = item.bo_Descripcion;
                    Obj.Codigo = item.Codigo;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.pr_nombre = item.pr_nombre;
                    Obj.en_IdEnsamblado = item.en_IdEnsamblado;
                    Obj.en_IdSucursal = item.en_IdSucursal;
                    Obj.en_IdEmpresa = item.en_IdEmpresa;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex) 
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxCtrlProd(decimal IdControlProd, int IdSucursal, int IdEmpresa, ref string msg)
        {
            try
            {
                List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> Lst = new List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_Movi_Inven_x_ControlProduccion_CusCider_Cab
                            where q.cp_IdControlProduccionObrero  == IdControlProd 
                            && q.cp_IdSucursal == IdSucursal 
                            && q.cp_IdEmpresa == IdEmpresa 
                            select q;
                foreach (var item in Query)
                {
                    vwIn_Movi_Inven_x_TI_CusCider_Cab_Info Obj = new vwIn_Movi_Inven_x_TI_CusCider_Cab_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.CodMoviInven = item.CodMoviInven;
                    Obj.cm_tipo = item.cm_tipo;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.IdProvedor = Convert.ToDecimal(item.IdProvedor);
                    Obj.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.bo_Descripcion = item.bo_Descripcion;
                    Obj.Codigo = item.Codigo;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.pr_nombre = item.pr_nombre;
                    Obj.cp_IdControlProduccionObrero  =item.cp_IdControlProduccionObrero;
                    Obj.cp_IdSucursal = item.cp_IdSucursal;
                    Obj.cp_IdEmpresa = item.cp_IdEmpresa;
                    Lst.Add(Obj);
                }
                msg = "Proceso exitoso";
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        public List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> ConsultaMovimienosxConversion(int IdEmpresa, decimal IdConversion, ref string msg)
        {
            try
            {
                List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> Lst = new List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_Movi_Inven_x_Conversion_CusCider_Cab 
                            where q.cv_IdEmpresa == IdEmpresa
                            && q.cv_IdConversion  == IdConversion
                            
                            select q;
                foreach (var item in Query)
                {
                    vwIn_Movi_Inven_x_TI_CusCider_Cab_Info Obj = new vwIn_Movi_Inven_x_TI_CusCider_Cab_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.CodMoviInven = item.CodMoviInven;
                    Obj.cm_tipo = item.cm_tipo;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.IdProvedor = Convert.ToDecimal(item.IdProvedor);
                    Obj.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                    Obj.Su_Descripcion = item.Su_Descripcion;
                    Obj.bo_Descripcion = item.bo_Descripcion;
                    Obj.Codigo = item.Codigo;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.pr_nombre = item.pr_nombre;
                    Obj.cv_IdEmpresa = item.cv_IdEmpresa;
                    Obj.cv_IdConversion = item.cv_IdConversion;
                   
                    Lst.Add(Obj);
                }
                msg = "Proceso exitoso";
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaSaldosxCtrlProd(int IdEmpresa, int et_IdEmpresa, int et_IdEtapa, int et_IdProcesoProductivo,
         int ot_IdEmpresa, int ot_IdSucursal, string ot_CodObra, decimal ot_IdOrdenTaller)
        {
            try
            {
                EntitiesProduccion_Cidersus oEnt = new EntitiesProduccion_Cidersus();
                string Querty = " select a.*,b.pr_descripcion from (select                a.IdEmpresa, a.IdSucursal, a.IdBodega,  a.IdProducto, a.CodigoBarra, "+
                                "           sum(a.dm_cantidad) as dm_cantidad, a.et_IdEmpresa, a.et_IdProcesoProductivo, a.et_IdEtapa, a.ot_IdEmpresa, a.ot_IdSucursal, "+
                                "           a.ot_CodObra, a.ot_IdOrdenTaller "+
                                " from in_movi_inve_detalle_x_Producto_CusCider a where et_IdEtapa is not null or et_IdEtapa<>0 "+
                                " group by a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdProducto, a.CodigoBarra, "+
                                "            a.et_IdEmpresa, a.et_IdProcesoProductivo, a.et_IdEtapa, a.ot_IdEmpresa, a.ot_IdSucursal, "+
                                "           a.ot_CodObra, a.ot_IdOrdenTaller )as a inner join in_Producto b on a.IdEmpresa = b.IdEmpresa and a.IdProducto = b.IdProducto "+
                                " where a.IdEmpresa = " + IdEmpresa + " and et_IdEmpresa = " + et_IdEmpresa + " and et_IdEtapa = " + et_IdEtapa + " and et_IdProcesoProductivo = " + et_IdProcesoProductivo +
                                " and ot_IdEmpresa = " + ot_IdEmpresa + " and ot_IdSucursal = " + ot_IdSucursal + " and ot_CodObra = '"+ot_CodObra+"' and ot_IdOrdenTaller =" + ot_IdOrdenTaller;
                                
                return oEnt.Database.SqlQuery<in_movi_inve_detalle_x_Producto_CusCider_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ConsultaSaldosxDespachoxObra( int IdEmpresa, int IdSucursal,int Idbodega, string IdObra)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                using (EntitiesProduccion_Cidersus oent = new EntitiesProduccion_Cidersus())
                {

                    var Query = from q in oent.vwprd_DespachoSaldo
                                where q.IdEmpresa == IdEmpresa                               
                                && q.IdSucursal == IdSucursal
                                && q.IdBodega==Idbodega
                                && q.CodObra==IdObra
                                select q;
                    foreach (var item in Query)
                    {
                        in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                        Obj.IdEmpresa =(Int32) item.IdEmpresa;
                        Obj.IdSucursal = item.IdSucursal;
                        Obj.IdBodega = item.IdBodega;
                        Obj.ot_CodObra = item.CodObra;
                        Obj.ot_IdOrdenTaller = item.IdOrdenTaller;
                        Obj.IdProducto = (Int32)item.IdProducto;
                        Obj.CodigoBarra = item.CodigoBarra;
                        Obj.ot_IdSucursal = (Int32)item.IdSucursal;
                        Obj.pr_descripcion = item.pr_descripcion;

                        Obj.pr_descripcion_2 = item.pr_descripcion_2;

                        Obj.CodigoBarra = item.CodigoBarra;
                        Obj.cm_fecha = item.FechaTransac;
                        Obj.dm_observacion = item.Observacion;
                        Obj.dm_precio = item.pr_precio_publico;
                       // Obj.pr_descripcion=item
                        lista.Add(Obj);

                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               // msg = ex.ToString() + " " + ex.Message;
               // oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
         }
        public List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> DisponiblesxReqOt(int ot_IdEmpresa, string ot_CodObra, int ot_IdSucursal, decimal ot_IdOrdenTaller,
            ref string msg)
        {
            try
            {
                List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info> lista = new List<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>();
                string Query = "select * from dbo.vwprd_Saldos_x_Req_x_OT_x_Consumo "
                    + "where oc_IdEmpresa = "+ot_IdEmpresa+" and ped_IdSuc = "+ot_IdSucursal
                    + "and ped_codobra = '"+ ot_CodObra+"' and ped_IdOT = " + ot_IdOrdenTaller;

                using (EntitiesProduccion oent = new EntitiesProduccion())
                {
                    var Consulta = oent.Database.SqlQuery<vwprd_Saldos_x_Req_x_OT_x_Consumo_Info>(Query);

                    lista = Consulta.ToList();
                }
                msg = "Consulta correcta.";
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString().ToString());
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ReimpresionCodigoBarra(string CodigoBarra, int idempresa)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vw_WSProduccionCidersus_Trazabilidad_IngresoEtapas
                            where q.CodigoBarra == CodigoBarra
                            && q.IdEmpresa  == idempresa                          
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdNumMovi = item.IdMovimiento;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.movilidadProducto = item.NombreEtapa; ;
                    Obj.pr_descripcion = item.DescripcionPieza;
                    Obj.ob_descripcion = item.Nombre;
                    Obj.cm_fecha =(DateTime) item.FechaTransaccion;

                    lista.Add(Obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ReimpresionCodigoBarra(int idempresa,DateTime Finicio,DateTime Ffin, int IdBodega,int IdSucursal,int CodProducto)
        {
            try
            {
                DateTime Fi, Ff;
                Fi = Convert.ToDateTime(Finicio.ToShortDateString());
                Ff = Convert.ToDateTime(Ffin.ToShortDateString());
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from  q in oEnti.vwin_Imprimir_Cod_Barra
                            where 
                                  q.IdEmpresa == idempresa
                                  && q.IdBodega==IdBodega
                                  && q.IdSucursal==IdSucursal
                                  && q.IdProducto == CodProducto
                                  && q.Fecha_Transac >= Fi
                                  && q.Fecha_Transac <= Ff
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.pr_descripcion = item.pr_descripcion; ;
                    Obj.dm_observacion = item.dm_observacion;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.cm_fecha = Convert.ToDateTime(item.Fecha_Transac);


                    lista.Add(Obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }


        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> GetConsUltaProductoCortados(int idempresa, int IdSucursal, int IdBodega, int IdTipoMov, int IdMovi)
        {
            try
            {


                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_prd_CidersusConsultaProductosCortados
                            where
                                  q.IdEmpresa == idempresa
                                  && q.IdBodega == IdBodega
                                  && q.IdSucursal == IdSucursal
                                  && q.IdMovi_inven_tipo == IdTipoMov
                                  && q.IdNumMovi == IdMovi
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.pr_Descripcion = item.pr_descripcion;
                    Obj.dm_observacion = item.dm_observacion;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                    Obj.Secuencia = item.Secuencia;
                    Obj.pr_alto = item.Alto;
                    Obj.pr_largo = item.Largo;
                    lista.Add(Obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }


        }
        public in_movi_inve_detalle_x_Producto_CusCider_Info Obtener_Saldo_x_Prod_x_Fecha(int idcompany, DateTime Fecha, int IdSucursal, int IdBodega, decimal IdProducto, string CodigoBarra, ref string msg)
        {
            try
            {

                in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                  
                using (EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus())
                {
                    EntitiesInventario OentiInv = new EntitiesInventario();
                    if (IdProducto == 0)
                    {
                        #region saldo filtrando solo por codigo de barra

                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha < Fecha
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Det.CodigoBarra == CodigoBarra
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha
                                     }
                                         into grouping
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,

                                             grouping.Key.CodigoBarra,
                                             existencia = grouping.Sum(Det => Det.dm_cantidad),
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };

                        foreach (var item in kardex)
                        {
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.existencia = item.existencia;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;


                        }
#endregion
                    }
                    else if (CodigoBarra != "" && CodigoBarra != "0")
                    {
                        #region saldo x cod barra y x producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha < Fecha
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Det.IdProducto == IdProducto
                                     && Det.CodigoBarra == CodigoBarra
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha
                                     }
                                         into grouping
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,

                                             grouping.Key.CodigoBarra,
                                             existencia = grouping.Sum(Det => Det.dm_cantidad),
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };

                        foreach (var item in kardex)
                        {
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.existencia = item.existencia;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;


                        }
                        #endregion
                    }
                    else
                    {
                        #region saldo x prod sin codbarra
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha < Fecha
                                     && Cab.IdEmpresa == idcompany
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
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha
                                     }
                                         into grouping
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,

                                             grouping.Key.CodigoBarra,
                                             existencia = grouping.Sum(Det => Det.dm_cantidad),
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };

                        foreach (var item in kardex)
                        {
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.existencia = item.existencia;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;


                        }
                        #endregion
                    }
                
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }

        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_Kardex_x_Prod_x_Fecha(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega, decimal IdProducto, string CodigoBarra, ref string msg)
        {
            try
            {

                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                using (EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus())
                {
                    EntitiesInventario OentiInv = new EntitiesInventario();
                    if (IdProducto == 0)
                    {
                        #region consulta filtra x cod barra sin filtro de producto 
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                         //&& Det.IdProducto == IdProducto
                                     && Det.CodigoBarra == CodigoBarra

                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;



                            lista.Add(info);
                        }
                        #endregion
                    }
                    else if (CodigoBarra != "" && CodigoBarra != "0")
                    {
                        #region consulta filtra x cod barra y x producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Det.IdProducto == IdProducto
                                     && Det.CodigoBarra == CodigoBarra

                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;

                            lista.Add(info);
                        }
                        #endregion
                    }
                    else
                    {
                        #region consulta filtra x producto sin filtro cod barra
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
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
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;

                            lista.Add(info);
                        }
                        #endregion
                    }
                    
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }

        
        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_CodBarrasReimpresion(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega, decimal IdProducto, int IdMovi_inven_tipo, string CodigoBarra, ref string msg)
        {
            try
            {

                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                using (EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus())
                {
                    EntitiesInventario OentiInv = new EntitiesInventario();
                    if (IdProducto == 0 &&( CodigoBarra == "" || CodigoBarra == "0") )
                    {
                        #region consulta sin filtrar cod barra ni producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 

                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado; 



                            lista.Add(info);
                        }
                        #endregion

                    }else if (IdProducto == 0)
                    {
                        #region consulta filtra x cod barra sin filtro de producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.CodigoBarra == CodigoBarra

                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 

                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 

                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;



                            lista.Add(info);
                        }
                        #endregion
                    }
                    else if (CodigoBarra != "" && CodigoBarra != "0")
                    {
                        #region consulta filtra x cod barra y x producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.IdProducto == IdProducto
                                     && Det.CodigoBarra == CodigoBarra

                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;

                            lista.Add(info);
                        }
                        #endregion
                    }
                    else
                    {
                        #region consulta filtra x producto sin filtro cod barra
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.IdProducto == IdProducto

                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;

                            lista.Add(info);
                        }
                        #endregion
                    }

                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }


        }
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> Obtener_CodBarrasReimpresion(int idcompany, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega, decimal IdProducto, int IdMovi_inven_tipo, decimal IdNumMovi, string CodigoBarra, ref string msg)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                using (EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus())
                {
                    EntitiesInventario OentiInv = new EntitiesInventario();
                    if (IdProducto == 0 && (CodigoBarra == "" || CodigoBarra == "0"))
                    {
                        #region consulta sin filtrar cod barra ni producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Cab.IdNumMovi == IdNumMovi 
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;



                            lista.Add(info);
                        }
                        #endregion

                    }
                    else if (IdProducto == 0)
                    {
                        #region consulta filtra x cod barra sin filtro de producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.CodigoBarra == CodigoBarra
                                     && Cab.IdNumMovi == IdNumMovi 
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;



                            lista.Add(info);
                        }
                        #endregion
                    }
                    else if (CodigoBarra != "" && CodigoBarra != "0")
                    {
                        #region consulta filtra x cod barra y x producto
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.IdProducto == IdProducto
                                     && Det.CodigoBarra == CodigoBarra
                                     && Cab.IdNumMovi == IdNumMovi 
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;
                            lista.Add(info);
                        }
                        #endregion
                    }
                    else
                    {
                        #region consulta filtra x producto sin filtro cod barra
                        var kardex = from Cab in OentiInv.in_movi_inve
                                     join Det in oEnti.in_movi_inve_detalle_x_Producto_CusCider
                                     on new { Cab.IdEmpresa, Cab.IdSucursal, Cab.IdBodega, Cab.IdMovi_inven_tipo, Cab.IdNumMovi }
                                     equals new { Det.IdEmpresa, Det.IdSucursal, Det.IdBodega, Det.IdMovi_inven_tipo, Det.IdNumMovi }
                                     where Cab.cm_fecha <= FechaFin
                                     && Cab.cm_fecha >= FechaIni
                                     && Cab.IdEmpresa == idcompany
                                     && Cab.IdSucursal == IdSucursal
                                     && Cab.IdBodega == IdBodega
                                     && Cab.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     && Det.IdProducto == IdProducto
                                     && Cab.IdNumMovi == IdNumMovi 
                                     group Det by new
                                     {
                                         Det.IdEmpresa,
                                         Det.IdSucursal,
                                         Det.IdBodega,
                                         Det.IdMovi_inven_tipo,
                                         Det.IdNumMovi,
                                         Det.IdProducto,
                                         Det.CodigoBarra,
                                         Det.dm_cantidad,
                                         Det.dm_observacion,
                                         Det.Secuencia,
                                         Det.mv_tipo_movi,
                                         Cab.cm_fecha,
                                         Cab.Fecha_Transac,
                                         Cab.Estado 
                                     }
                                         into grouping
                                         orderby grouping.Key.cm_fecha, grouping.Key.Fecha_Transac ascending
                                         select new
                                         {

                                             grouping.Key.IdEmpresa,
                                             grouping.Key.IdSucursal,
                                             grouping.Key.IdBodega,
                                             grouping.Key.IdMovi_inven_tipo,
                                             grouping.Key.IdNumMovi,
                                             grouping.Key.mv_tipo_movi,
                                             grouping.Key.IdProducto,
                                             grouping.Key.CodigoBarra,
                                             grouping.Key.dm_cantidad,
                                             grouping.Key.cm_fecha,
                                             grouping.Key.Secuencia,
                                             grouping.Key.dm_observacion,
                                             grouping.Key.Estado 
                                         };


                        foreach (var item in kardex)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                            info.CodigoBarra = item.CodigoBarra;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.mv_tipo_movi = item.mv_tipo_movi;
                            info.IdProducto = item.IdProducto;
                            info.Secuencia = item.Secuencia;
                            info.dm_observacion = item.dm_observacion;
                            info.Estado = item.Estado;

                            lista.Add(info);
                        }
                        #endregion
                    }

                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }


        }

        public List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> ObtenerMateriaPrima(int IdEmpresa, int Idsucursal, int Idbodega, int IdObra,int IdOrdenTaller)
        {//
            try
            {
                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> lista = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                EntitiesProduccion_Cidersus oent = new EntitiesProduccion_Cidersus();
               String IdO = Convert.ToString(IdObra);
                var Query = from q in oent.vwin_movi_inve_detalle_x_Producto_x_OT_CusCider_Saldos
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == Idsucursal
                            && q.IdBodega == Idbodega
                            && q.ot_CodObra == IdO
                            && q.ot_IdOrdenTaller==IdOrdenTaller
                            && q.dm_cantidad != -1
                            select q;
                foreach (var item in Query)
                {
                    vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info Obj = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdProducto = item.IdProducto;
                    Obj.CodigoBarra = item.CodigoBarra;
                     Obj.dm_cantidad = item.dm_cantidad;
                    Obj.pr_descripcion = item.pr_descripcion;
                   // Obj.CodigoProducto = item.COD;
                    Obj.observacion = item.pr_descripcion;
                    lista.Add(Obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
  




        //nuevo
        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> GetKardexConsultaCidersus(int IdEmpresa, int IdSucursal, int IdBodega, int IdProducto, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                DateTime dateini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime datefin = Convert.ToDateTime(FechaFin.ToShortDateString());

                using (EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus())
                {

                    var kardex = from Q in oEnti.vwin_prd_ConsultaKardex
                                 where Q.IdEmpresa == IdEmpresa
                                 && Q.IdSucursal == IdSucursal
                                 && Q.IdBodega == IdBodega
                                 && Q.IdProducto == IdProducto
                                 && Q.cm_fecha >= dateini
                                 && Q.cm_fecha <= datefin
                                 select Q;

                    foreach (var item in kardex)
                    {
                        in_movi_inve_detalle_x_Producto_CusCider_Info info = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.cm_fecha = Convert.ToDateTime(item.cm_fecha);
                        info.dm_cantidad = item.dm_cantidad;
                        info.IdMovi_inven_tipo = item.IdTipoMovimiento;
                        info.IdNumMovi = item.IdMovimiento;
                        info.mv_tipo_movi = item.mv_tipo_movi;
                        info.IdProducto = item.IdProducto;
                        info.Secuencia = item.Secuencia;
                        info.dm_observacion = item.dm_observacion;
                        info.pr_descripcion = item.pr_descripcion;
                        info.su_descripcion = item.Su_Descripcion;
                        info.bo_descripcion = item.bo_Descripcion;
                        info.CodigoBarra = item.CodigoBarra;
                        if (item.dm_cantidad > 0)
                        {
                            info.entrada = item.dm_cantidad;
                        }
                        else
                        {
                            info.salida = item.dm_cantidad;
                        }
                        lista.Add(info);
                    }


                }
                return lista;

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




        public List<in_movi_inve_detalle_x_Producto_CusCider_Info> ImpresionCBProductoTerminado(int idempresa, int IdSucursal, int IdEmsamblado)
        {
            try
            {
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> lista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.vwin_ReimpresionCodigoBarraProductoTerminado_CusCider
                            where
                                  q.IdEmpresa == idempresa
                                  && q.IdSucursal == IdSucursal
                                  && q.IdEnsamblado == IdEmsamblado
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info Obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.Logo = item.em_logo;
                    Obj.fa_Cliente = item.Cliente;
                    Obj.obra = item.Obra;
                    Obj.CodigoBarra = item.CodigoBarra;
                    Obj.pr_descripcion = item.pr_descripcion;
                    Obj.ot_CodObra = "(" + item.CodObra + ")";
                    lista.Add(Obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarCodObra_preasignada(in_movi_inve_detalle_x_Producto_CusCider_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.in_movi_inve_detalle_x_Producto_CusCider.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdSucursal == Info.IdSucursal && obj.IdMovi_inven_tipo == Info.IdMovi_inven_tipo && obj.IdNumMovi == Info.IdNumMovi
                        && obj.mv_Secuencia == Info.mv_Secuencia && obj.Secuencia == Info.Secuencia && obj.IdProducto == Info.IdProducto);

                    if (contact != null)
                    {
                        contact.CodObra_preasignada = Info.CodObra_preasignada;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar El Material #: " + Info.CodigoBarra.ToString() + " exitosamente.";
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
                mensaje = ex.InnerException + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean LiberarMP_de_Obra_preasignada(in_movi_inve_detalle_x_Producto_CusCider_Info Info)
        {
            string msg;
            try
            {
                
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    var contact = context.in_movi_inve_detalle_x_Producto_CusCider.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa
                        && obj.IdSucursal == Info.IdSucursal && obj.IdMovi_inven_tipo == Info.IdMovi_inven_tipo && obj.IdNumMovi == Info.IdNumMovi
                        && obj.mv_Secuencia == Info.mv_Secuencia && obj.Secuencia == Info.Secuencia && obj.IdProducto == Info.IdProducto);

                    if (contact != null)
                    {
                        contact.CodObra_preasignada = null;

                        context.SaveChanges();
                        //msg = "Se ha procedido actualizar El Material #: " + Info.CodigoBarra.ToString() + " exitosamente.";
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
                mensaje = ex.InnerException + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        //public Boolean ActualizarLstCodObra_preasignada(in_movi_inve_detalle_x_Producto_CusCider_Info Info, ref string msg)

    }
}

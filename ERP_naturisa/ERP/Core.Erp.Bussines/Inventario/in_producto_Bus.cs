using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using System.Data;


namespace Core.Erp.Business.Inventario
{


    public class in_producto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_Producto_data proD = new in_Producto_data();
        string CodProducto_x_Categoria = "";
        int SecuencialCodProducto_x_Categoria = 0;
        decimal Id_Producto = 0;

       

        public List<in_Producto_Info> Get_list_Producto_ManejaSeries(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_Producto_ManejaSeries(IdEmpresa);

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Obtener Lista Productos .." + ex.Message;
                throw new Exception(mensaje);

            }

        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_Producto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_listProducto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return proD.Get_list_Producto_modulo_x_compra(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Productos_x_Sucursal", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_Ventas(int IdEmpresa, int IdSucursal)
        {

            try
            {
                return proD.Get_list_Producto_modulo_x_ventas(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Productos_x_Sucursal", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_Ventas(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return proD.Get_list_Producto_modulo_x_ventas(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Productos_x_Sucursal", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return proD.Get_list_Producto_modulo_x_inventario(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Producto_modulo_x_inventario", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal)
        {

            try
            {
                return proD.Get_list_Producto(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Productos_x_Sucursal", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return proD.Get_list_Producto(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_Productos_x_Empresa(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_Producto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Todos_Productos_x_Empresa", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public in_Producto_Info Get_Info_Producto(int IdEmpresa, string CodBarra)
        {
            try
            {
                return proD.GetProducto(IdEmpresa, CodBarra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetProducto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public in_Producto_Info Get_Info_BuscarProducto(decimal IdProducto, int IdEmpresa)
        {
            try
            {
                return proD.Get_Info_BuscarProducto(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "BuscarProducto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }
        public bool Producto_maneja_inventario(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return proD.Producto_maneja_inventario(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_lst_producto_maneja_inventario", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };
            }
        }

        public in_Producto_Info Get_info_Product(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return proD.Get_info_Producto(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_lProd", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public Boolean GrabarDB(in_Producto_Info prI, ref decimal IdProducto, ref string mensaje)
        {

            try
            {
                Boolean res = false;

                if (ValidarObjeto(prI, ref mensaje) == true)
                {
                    res = proD.GrabarDB(prI, ref IdProducto, ref mensaje);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };


            }
        }

        public Boolean ValidarNombreItem(int IdEmpresa, string NombreItem)
        {
            try
            {
                return proD.ValidarNombreItem(IdEmpresa, NombreItem);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarNombreItem", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }
        public Boolean ValidarNombreItem_x_TipoProducto(int IdEmpresa, string NombreItem, int IdTipoProducto)
        {
            try
            {
                return proD.ValidarNombreItem_x_TipoProducto(IdEmpresa, NombreItem, IdTipoProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarNombreItem", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }
        public Boolean ModificarDB(in_Producto_Info prI, ref string mensaje)
        {

            try
            {
                Boolean res = false;

                if (ValidarObjeto(prI, ref mensaje) == true)
                {
                    res = proD.ModificarDB(prI, ref mensaje);
                }

                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };


            }


        }

        public decimal GetIdProducto(int idempresa)
        {

            try
            {

                return proD.GetIdProducto(idempresa);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdProducto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };


            }

        }

        public Boolean AnularDB(in_Producto_Info ProductoInfo, ref string mensaje)
        {

            try
            {

                return proD.AnularDB(ProductoInfo, ref mensaje);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };


            }


        }

        public string Get_Descripcion_Producto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return proD.Get_Descripcion_Producto(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Des_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public string Get_Codigo_Producto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_data proD = new in_Producto_data();

                return proD.Get_Codigo_Producto(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cod_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public string Get_Sec_Codigo_Producto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            SecuencialCodProducto_x_Categoria = 0;
            int posicion_guion=0;
            try
            {
                in_Producto_data proD = new in_Producto_data();
                CodProducto_x_Categoria = proD.GetCodProducto_x_Categoria(IdEmpresa, IdCategoria);

                if (CodProducto_x_Categoria == "1")
                {
                    //CodProducto_x_Categoria = proD.GetCodProducto_x_Categoria(IdEmpresa, IdCategoria);
                    SecuencialCodProducto_x_Categoria = Convert.ToInt32(CodProducto_x_Categoria);
                }
                else
                {
                    posicion_guion = proD.GetCodProducto_x_Categoria(IdEmpresa, IdCategoria).IndexOf("-");

                    CodProducto_x_Categoria = proD.GetCodProducto_x_Categoria(IdEmpresa, IdCategoria).Substring(posicion_guion+1);
                    if (CodProducto_x_Categoria != "")
                    {
                        SecuencialCodProducto_x_Categoria = Convert.ToInt32(CodProducto_x_Categoria) + 1;
                    }
                    else
                    {
                        SecuencialCodProducto_x_Categoria = 0;
                    }
                }
                return SecuencialCodProducto_x_Categoria.ToString();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cod_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrima(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_MateriaPrima(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_MateriaPrima", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_ProductosMateriaPrima(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_ProductosMateriaPrima(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_MateriaPrima", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_ProductosMateriaPrimaDimension(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_ProductosMateriaPrimaDimension(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_MateriaPrima", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }
        public List<in_Producto_Info> Get_list_ProductosMateriaPrimaDimension_x_TipoProducto(int IdEmpresa, int IdTipoProducto)
        {
            try
            {
                return proD.Get_list_ProductosMateriaPrimaDimension_x_TipoProducto(IdEmpresa, IdTipoProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_MateriaPrima", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }
        public List<in_Producto_Info> Get_list_Productos_x_TipoProducto(int IdEmpresa, int IdTipoProducto)
        {
            try
            {
                return proD.Get_list_Productos_x_TipoProducto(IdEmpresa, IdTipoProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_ProductoElemento", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_ProductosTerminados(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_ProductosTerminados(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_ProductosTerminados", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }


        }



        public List<in_Producto_Info> Get_list_ProductosTerminados_x_ListadoDiseno(int IdEmpresa, int IdListadoDiseno)
        {
            try
            {
                return proD.Get_list_ProductosTerminados_x_ListadoDiseno(IdEmpresa, IdListadoDiseno);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_ProductosTerminados", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }


        }
        public string Get_DescripcionTot_Producto(int p, decimal p_2)
        {
            try
            {
                return proD.Get_Descripcion_Producto(p, p_2);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "DescripcionTot_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_MateriaPrima_X_ModeloDeProduccion(int IdEmpresa, int IdTipoModelo)
        {
            try
            {
                return proD.Get_list_MateriaPrima_X_ModeloDeProduccion(IdEmpresa, IdTipoModelo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerMateriaPrima_X_ModeloDeProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public Boolean ValidarProductExiste(string Nombre)
        {
            try
            {
                return proD.ValidarProductExiste(Nombre);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarProductExiste", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

        public in_Producto_Info Get_Info_ProductoXNombre(int IdEmpresa, string Descripcion)
        {
            try
            {
                return proD.Get_Info_ProductoXNombre(IdEmpresa, Descripcion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductoXNombre", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_ProductosXModeloProduccio(int IdEmpresa, int IdModeloProduccion)
        {
            try
            {
                return proD.Get_list_ProductosXModeloProduccion(IdEmpresa, IdModeloProduccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductosXModeloProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_MateriaPrimaModulosdeProduccion(int IdEmpresa)
        {
            try
            {
                return proD.Get_list_MateriaPrimaModulosdeProduccion(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerMateriaPrimaModulosdeProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_MateriaPrimaPorModeloProduccion(int IdEmpresa, int IdModeloProduccion)
        {
            try
            {
                return proD.Get_list_MateriaPrima_X_ModeloDeProduccion(IdEmpresa, IdModeloProduccion);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_MateriaPrimaPorModeloProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_list_ProductosSucursalXBodegaXModulodeProduccion(int IdEmpresa, int IdModeloProduccion, int IdBodega, int IdSucursa)
        {
            try
            {
                return proD.Get_list_ProductosSucursalXBodegaXModulodeProduccion(IdEmpresa, IdModeloProduccion, IdBodega, IdSucursa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarProductosSucursalXBodegaXModulodeProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_Productos_X_Proveedor(int IdEmpresa, decimal IdProveedor, int IdEmpresa_x_Proveedor, string Esta = "")
        {
            try
            {
                return proD.Get_list_Productos_X_Proveedor(IdEmpresa, IdProveedor, IdEmpresa_x_Proveedor, Esta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Productos_X_Proveedor", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> Get_ProductoTerminado_X_ModeloDeProduccion(int IdEmpresa, int IdTipoModelo)
        {
            try
            {
                return proD.Get_list_ProductoTerminado_X_ModeloDeProduccion(IdEmpresa, IdTipoModelo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductoTerminado_X_ModeloDeProduccion", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public List<in_Producto_Info> ProcesarDataTablein_Producto_Info(DataTable ds, int IdEmpresa, ref string MensajeError)
        {
            List<in_Producto_Info> lista = new List<in_Producto_Info>();
            lista.Clear();
            try
            {
                //VALIDAR QUE TENGA MAS DE 12 COLUMNAS
                Id_Producto = proD.GetIdProducto(IdEmpresa);

                if (ds.Columns.Count <= 12)
                {
                    //RECORRE EL DATATABLE REGISTRO X REGISTRO
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            in_Producto_Info info = new in_Producto_Info();

                            info.IdEmpresa = IdEmpresa;

                            for (int col = 0; col < ds.Columns.Count + 1; col++)
                            {
                                switch (col)
                                {
                                    case 0://IdProducto
                                        info.IdProducto = Id_Producto;
                                        Id_Producto++;
                                        break;

                                    case 1://Codigo
                                        info.pr_codigo = Convert.ToString(row[col]);
                                        break;

                                    case 2://TIPO
                                        info.nom_Tipo_Producto = Convert.ToString(row[col]);
                                        if (info.nom_Tipo_Producto == "BIEN")
                                            info.IdProductoTipo = 1;
                                        else
                                            info.IdProductoTipo = 2;
                                        break;

                                    case 3://nom_producto
                                        info.pr_descripcion = Convert.ToString(row[col]);
                                        break;

                                    case 4://Precio
                                        info.pr_precio_publico = Convert.ToDouble(row[col]);
                                        break;

                                    case 5://Aplica_Iva
                                        info.pr_ManejaIva = Convert.ToString(row[col]);
                                        break;

                                    case 6://marca
                                        info.nom_Marca = Convert.ToString(row[col]);
                                        break;

                                    case 7://Presentacion
                                        info.nom_Presentacion = Convert.ToString(row[col]);
                                        break;

                                    case 8://Categoria
                                        info.nom_Categoria = Convert.ToString(row[col]);
                                        break;

                                    case 9://Linea
                                        info.nom_Linea = Convert.ToString(row[col]);
                                        break;

                                    case 10://Grupo
                                        info.nom_Grupo = Convert.ToString(row[col]);
                                        break;

                                    case 11://SubGrupo
                                        info.nom_SubGrupo = Convert.ToString(row[col]);
                                        break;

                                    default:
                                        break;
                                }
                            }
                            lista.Add(info);
                        }
                    }
                    else
                    {
                        MensajeError = "Por favor verifique que el archivo contenga Datos. ";
                        lista = new List<in_Producto_Info>();
                    }

                }
                else
                {
                    MensajeError = "Por favor verifique que el archivo tenga el formato correcto.\r Son 12 columnas y el archivo tiene: " + ds.Columns.Count.ToString();
                    lista = new List<in_Producto_Info>();
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.ToString();
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTablein_Producto_Info", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
            return lista;
        }

        public bool Delete_Todos_Producto(int IdEmpresa, ref string MensajeError)
        {

            try
            {
                return proD.Delete_Todos_Producto(IdEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Delete_Todos_Producto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }

        }

        public Boolean ValidarObjeto(in_Producto_Info _Info, ref string MensajeError)
        {

            try
            {

                Boolean res = true;


                if (_Info.IdEmpresa == 0)
                {
                    MensajeError = "el objeto esta errado los PK IdEmpresa , IdTipoCbte no pueden estar en cero";
                    return false;
                }

                if (_Info.IdLinea == 0 || _Info.IdLinea == null)
                {
                    MensajeError = "el IdLinea no puede ser 0 o null";
                    return false;
                }


                if (_Info.IdCategoria == "" || _Info.IdCategoria == null)
                {
                    MensajeError = "el IdCategoria no puede ser 0 o null";
                    return false;
                }


                if (_Info.IdGrupo == 0 || _Info.IdGrupo == null)
                {
                    MensajeError = "el IdGrupo no puede ser 0 o null";
                    return false;
                }

                if (_Info.IdSubGrupo == 0 || _Info.IdSubGrupo == null)
                {
                    MensajeError = "el IdSubGrupo no puede ser 0 o null";
                    return false;
                }

                if (_Info.IdMarca == 0 || _Info.IdMarca == null)
                {
                    MensajeError = "el IdMarca no puede ser 0 o null";
                    return false;
                }

                if (_Info.IdPresentacion == "" || _Info.IdPresentacion == null)
                {
                    MensajeError = "el IdPresentacion no puede ser 0 o null";
                    return false;
                }

                if (_Info.IdUnidadMedida == "" || _Info.IdUnidadMedida == null)
                {
                    MensajeError = "el IdUnidadMedida no puede ser 0 o null";
                    return false;
                }

                if (_Info.IdUnidadMedida_Consumo == "" || _Info.IdUnidadMedida_Consumo == null)
                {
                    MensajeError = "el IdUnidadMedida no puede ser 0 o espacio ni null";
                    return false;
                }

                if (_Info.pr_descripcion == "" || _Info.pr_descripcion == null)
                {
                    MensajeError = "el pr_descripcion no puede ser 0 o espacio ni null";
                    return false;
                }



                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };
            }


        }

        public List<in_Producto_Info> Get_list_Productos_not_exist_in_producto_x_bodega(int IdEmpresa, int Idsucursal, int idbodega)
        {
            try
            {
                return proD.Get_list_Productos_not_exist_in_producto_x_bodega(IdEmpresa, Idsucursal, idbodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Productos_not_exist_in_producto_x_bodega", ex.Message), ex) { EntityType = typeof(in_producto_Bus) };

            }
        }

    }
}

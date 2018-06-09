using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_producto_x_cp_proveedor_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        in_producto_x_cp_proveedor_Data data = new in_producto_x_cp_proveedor_Data();
        List<in_producto_x_cp_proveedor_Info> lM = new List<in_producto_x_cp_proveedor_Info>();


        public List<in_producto_x_cp_proveedor_Info> ObtenerProducto_Proveedor(int idempresa)
        {
            try
            {
                
                lM = data.Get_List_producto_x_cp_proveedor(idempresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProducto_Proveedor", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }
        }

        public Boolean ModificarDB(in_producto_x_cp_proveedor_Info pxp, ref string mensaje)
        {
            try
            {
                return data.ModificarDB(pxp, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }
        }

        public Boolean eliminarregistrotabla(List<in_producto_x_cp_proveedor_Info> lst, int idEmpresa, int idProducto, ref string mensaje)
        {
            try
            {
                
                return data.Eliminarregistro(lst, idEmpresa, idProducto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }
        }

        public Boolean eliminarRegistro_x_producto(int idEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                return data.EliminarRegistro(idEmpresa, IdProductoPadre, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarRegistro_x_producto", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }
        
        }
     
        public Boolean ModificarLIsta(List<in_producto_x_cp_proveedor_Info> lst, int idEmpresa, int idProducto, ref string mensaje)
        {
            try
            {
                return data.ModificarDB(lst, idEmpresa, idProducto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarLIsta", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }
        }

        public Boolean Grabar_Producto_Proveedor(in_producto_x_cp_proveedor_Info item, int idEmpresa, decimal idProducto, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(item, idEmpresa, idProducto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_Producto_Proveedor", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }

        }

        public Boolean Grabar_Producto_Proveedor_lista(List<in_producto_x_cp_proveedor_Info> Lista, int idEmpresa, decimal idProducto, ref string mensaje)
        {
            try
            {
                return data.GrabarDB(Lista, idEmpresa, idProducto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_Producto_Proveedor_lista", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }

        }

        public Boolean eliminarregistrotablaUno(in_producto_x_cp_proveedor_Info item, int idEmpresa, decimal idProducto, ref string mensaje)
        {
            try
            {

                return data.Eliminarregistro(item, idEmpresa, idProducto, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotablaUno", ex.Message), ex) { EntityType = typeof(in_producto_x_cp_proveedor_Bus) };

            }

        
        }
    }



}

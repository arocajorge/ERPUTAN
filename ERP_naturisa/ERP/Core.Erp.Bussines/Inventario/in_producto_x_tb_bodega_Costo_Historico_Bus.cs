using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_producto_x_tb_bodega_Costo_Historico_Bus
    {
        in_producto_x_tb_bodega_Costo_Historico_Data dataProd = new in_producto_x_tb_bodega_Costo_Historico_Data();

        public Boolean GuardarDB(in_producto_x_tb_bodega_Costo_Historico_Info Info ,  ref string msjError)
        {
            try
            {
                return dataProd.GuardarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Costo_Historico_Bus) };

            }
        }

        public in_producto_x_tb_bodega_Costo_Historico_Info get_UltimoCosto_x_Producto_Bodega(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha)
        {
            try
            {
                return dataProd.Get_UltimoCosto_x_Producto_Bodega(IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_UltimoCosto_x_Producto_Bodega", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Costo_Historico_Bus) };
            }
        }

        public in_producto_x_tb_bodega_Costo_Historico_Bus()
        {

        }

        public bool Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha_ini,  int Decimales)
        {
            try
            {
                return dataProd.Proceso_recosteo_y_correccion_contable_inv(IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha_ini, Decimales);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Proceso_recosteo_y_correccion_contable_inv", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Costo_Historico_Bus) };
            }
        }


        public bool Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin, int Decimales)
        {
            try
            {
                return dataProd.Proceso_recosteo_y_correccion_contable_inv(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Fecha_fin, Decimales);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Proceso_recosteo_y_correccion_contable_inv", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Costo_Historico_Bus) };
            }
        }

        public List<in_producto_x_tb_bodega_Costo_Historico_Info> Proceso_recosteo_y_correccion_contable_inv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, int Decimales)
        {
            try
            {
                return dataProd.Proceso_recosteo_y_correccion_contable_inv(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Decimales);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Proceso_recosteo_y_correccion_contable_inv", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Costo_Historico_Bus) };
            }
        }
    }
}

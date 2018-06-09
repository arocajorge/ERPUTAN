using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
namespace Core.Erp.Business.Inventario
{
    public class in_movi_inve_detalle_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_detalle_Data oData = new in_movi_inve_detalle_Data();

        public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det(int IdEmpresa, int Idsucursal, int IdBodega,int idTipoMovi, decimal IdNumMovimiento)
        {
            try
            {
              return oData.Get_list_Movi_inven_det(IdEmpresa, Idsucursal, IdBodega, idTipoMovi, IdNumMovimiento);
    
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_Movi_inven_det", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
          
        }


        public in_movi_inve_detalle_Info Get_info_Movi_inven_det(int IdEmpresa, int Idsucursal, int idbodega,
            int idTipoMovi, decimal IdNumMovimiento, int Secuencia)
        {
            try
            {
                return oData.Get_info_Movi_inven_det(IdEmpresa, Idsucursal, idbodega, idTipoMovi, IdNumMovimiento, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_list_Movi_inven_det", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };
            }
        }

        public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det_x_Ing_OrdenCompra_local(int IdEmpresa, int Idsucursal, int IdBodega,
          int idTipoMovi, decimal IdNumMovimiento)
        {
            try
            {
                return oData.Get_list_Movi_inven_det_x_Ing_OrdenCompra_local( IdEmpresa,  Idsucursal,  IdBodega,
           idTipoMovi, IdNumMovimiento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_list_Movi_inven_det", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };
            }
        }

        public Boolean GrabarDB(List<in_movi_inve_detalle_Info> list, ref string mensaje)
        {
            try
            {
                    return oData.GrabarDB(list, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }

        }


        public Boolean AnularDB(List<in_movi_inve_detalle_Info> ListMoviInfo, ref  string mensaje)
        {
            try
            {
                return oData.AnularDB(ListMoviInfo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
        }

        public in_movi_inve_detalle_Info Get_Saldo_x_Prod_x_Fecha(int IdEmpresa, DateTime Fecha, int IdSucursal, int IdBodega, decimal IdProducto, ref string msg)
        {
            try
            {
                return oData.Get_Saldo_x_Prod_x_Fecha(IdEmpresa, Fecha, IdSucursal, IdBodega, IdProducto, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Saldo_x_Prod_x_Fecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
        
        }


        public List<in_movi_inve_detalle_Info> Get_Kardex_x_Prod_x_Fecha(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega, decimal IdProducto, ref string msg)
        {
            try
            {
                return oData.Get_Kardex_x_Prod_x_Fecha(IdEmpresa, FechaIni , FechaFin , IdSucursal, IdBodega, IdProducto, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Kardex_x_Prod_x_Fecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };
            }
        }


        public List<in_movi_inve_detalle_Info> Get_List_StockAFecha(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha)
        {
            try
            {
                 return oData.Get_List_StockAFecha(IdEmpresa, IdSucursal, IdBodega, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObjtenerStockAFecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }

        }

        public List<in_movi_inve_detalle_Info> Get_list_Movi_inven_det_x_ing_egr(int IdEmpresa, int Idsucursal,
           int idTipoMovi, decimal IdNumMovimiento)
        {
            try
            {
                return oData.Get_list_Movi_inven_det_x_ing_egr(IdEmpresa, Idsucursal, idTipoMovi, IdNumMovimiento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Kardex_x_Prod_x_Fecha", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };
            }
        }

        public List<in_movi_inve_detalle_Info> Get_List_CuerpoKardex(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime FechaIncial, DateTime FechaFinal)
        {
            try
            {
                return oData.Get_List_CuerpoKardex(IdEmpresa, IdSucursal, IdBodega, IdProducto, FechaIncial, FechaFinal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCuerpoKardex", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
           
        }


        public in_movi_inve_detalle_Info Get_Info_StockAFechaPorProduct(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha)
        {
            try
            {
                    return oData.Get_Info_StockAFechaPorProduct(IdEmpresa, IdSucursal, IdBodega, IdProducto, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerStockAFechaPorProduct", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_Bus) };

            }
      
        }
    }
}

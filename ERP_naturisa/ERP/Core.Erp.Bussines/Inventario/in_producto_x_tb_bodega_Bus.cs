using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

///////////
namespace Core.Erp.Business.Inventario
{
    public class in_producto_x_tb_bodega_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_producto_x_tb_bodega_Data data = new in_producto_x_tb_bodega_Data();

         public List<in_producto_x_tb_bodega_Info> Get_List_Producto_x_Bodega_x_CtasCbles(int IdEmpresa,int IdSucursal,int IdBodega)
        {
            try
            {
                return data.Get_List_Producto_x_Bodega_x_CtasCbles(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Producto_x_Bodega_x_CtasCbles", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }


        public List<in_producto_x_tb_bodega_Info> Get_List_Producto_x_Bodega(int idempresa, int idbodega)
        {
          
            try
            {
               
                return data.Get_List_Producto_x_Bodega(idempresa, idbodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Producto_x_Bodega", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public List<in_producto_x_tb_bodega_Info> Get_list_Productos_x_Bodega(int idempresa, decimal IdProducto)
        {
            try
            {
                return data.Get_list_Productos_x_Bodega(idempresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Productos_x_Bodega", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public List<in_producto_x_tb_bodega_Info> Get_List_ProductoxBodegaxSucursal_q_no_existen_en_sucu_bod(int idempresa, int idbodega, int Idsucursal, List<decimal> listProducto)
        {
            try
            {
                 return data.Get_List_ProductoxBodegaxSucursal_q_no_existen_en_sucu_bod(idempresa,idbodega, Idsucursal,listProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ProductoxBodegaxSucursal_q_no_existen_en_sucu_bod", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

                
            }

        }

        public Boolean GrabaDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                return data.GrabaDB(ls, idempresa, ref mensaje);
            
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabaDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public Boolean GrabaDB(in_producto_x_tb_bodega_Info item, int idempresa, ref string mensaje)
        {
            try
            {
                return data.GrabaDB_x_item(item, idempresa, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabaDB_x_item", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public Boolean ModificarDB(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                
                return data.ModificarDB(ls, idempresa, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }



        public Boolean ModificarDB(in_producto_x_tb_bodega_Info Info, ref string mensaje)
        {
            try
            {

                return data.ModificarDB(Info, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }


         public bool Delete_Todos_Producto_x_bodega(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                return data.Delete_Todos_Producto_x_bodega(IdEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminaRegistros", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }


        public Boolean EliminaRegistros(List<in_producto_x_tb_bodega_Info> ls, int idempresa, ref string mensaje)
        {
            try
            {
                return data.EliminaRegistros(ls, idempresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminaRegistros", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public List<in_producto_x_tb_bodega_Info> Get_List_producto_x_tb_bodega_x_Transferencia(int idempresa, int idbodega, int idsucursa, List<in_transferencia_det_Info> listdetalle, decimal idtransferencia)
        {
            try
            {
               return data.Get_List_producto_x_tb_bodega_x_Transferencia(idempresa, idbodega, idsucursa, listdetalle, idtransferencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProduPedidos", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public Boolean ActualizarStock_x_Bodega_con_moviInven(List<in_movi_inve_detalle_Info> listaMovi, ref string mensaje)
        {
            try
            {
              return data.ActualizarStock_x_Bodega_con_moviInven(listaMovi, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarStock_x_Bodega_con_moviInven", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public List<in_producto_x_tb_bodega_Info> Get_List_ProductoxBodegaxSucursal_x_Bodega(int idempresa, int idbodega, int Idsucursal)
        {
            try
            {
               return data.Get_List_ProductoxBodegaxSucursal(idempresa, idbodega, Idsucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductoxBodegaxSucursal", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public double Get_stock_a_fecha_corte(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto, DateTime Fecha)
        {
            try
            {
                return data.Get_stock_a_fecha_corte(IdEmpresa, IdSucursa, IdBodega, IdProducto, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProductoxBodegaxSucursal", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public double Get_Stock_Actual_x_Producto(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto)
        {
            try
            {
                return data.Get_Stock_Actual_x_Producto(IdEmpresa, IdSucursa, IdBodega, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }
        }

        public in_producto_x_tb_bodega_Info Get_Info_Producto_x_Producto(int IdEmpresa, int IdSucursa, int IdBodega, Decimal IdProducto)
        {
            try
            {
              return data.Get_Info_Producto_x_Producto(IdEmpresa, IdSucursa, IdBodega, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }



        public in_producto_x_tb_bodega_Info Get_Info_IdCtaCble_x_Producto_x_Bodega(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdProducto)
        {


            try
            {
                return data.Get_Info_IdCtaCble_x_Producto_x_Bodega(IdEmpresa, IdSucursal, IdBodega, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }


        public Boolean EliminarDB(in_producto_x_tb_bodega_Info item, int idempresa, ref string mensaje)
        {
            try
            {
                  return data.EliminarDB(item, idempresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminaUnRegistros", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                  return data.EliminarDB(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                return data.EliminarDB(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };

            }

        }

        public Boolean VerificarExisteProductoXSucursalXBodega(int Idempresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {
                return data.VerificarExisteProductoXSucursalXBodega(Idempresa, IdSucursal, IdBodega, IdProducto);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_producto_x_tb_bodega_Bus) };
            }

        }


    }



}

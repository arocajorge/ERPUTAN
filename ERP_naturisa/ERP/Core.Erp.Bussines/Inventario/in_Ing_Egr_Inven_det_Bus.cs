using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
 public class in_Ing_Egr_Inven_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";

        in_Ing_Egr_Inven_det_Data odata = new in_Ing_Egr_Inven_det_Data();

        public Boolean GuardarDB(List<in_Ing_Egr_Inven_det_Info> LstInfo)
        {
            try
            {
                return odata.GuardarDB(LstInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };



            }
        }

        public Boolean EliminarDB(List<in_Ing_Egr_Inven_det_Info> lstInfo, ref string msgs)
        {
            try
            {
                return odata.EliminarDB(lstInfo, ref msgs);              
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }
        }

        public Boolean ModificarDetalle_IdMovi_Inven_x_IngEgr(List<in_Ing_Egr_Inven_det_Info> lista, ref string msgs)
        {
            try
            {
                return odata.ModificarDetalle_IdMovi_Inven_x_IngEgr(lista, ref  msgs);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDetalle_IdMovi_Inven_x_IngEgr", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }
        
        
        
        }


        public in_Ing_Egr_Inven_det_Info Get_Info_Ing_Egr_Inven_det_x_Movi_Inven(int IdEmpresa_inv, int IdSucursal_inv, int IdBodega_Inv,
             int IdMovi_inven_tipo_inv, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_Info_Ing_Egr_Inven_det_x_Movi_Inven(IdEmpresa_inv, IdSucursal_inv, IdBodega_Inv, IdMovi_inven_tipo_inv,IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven_det_x_Num_Movimiento", ex.Message), ex) { EntityType = typeof                              (in_Ing_Egr_Inven_det_Bus) };

            }

        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_det(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven_det", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(int Idempresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(Idempresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven_det_x_Num_Movimiento", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_transferencia(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_det_x_transferencia(IdEmpresa, IdSucursalOrigen, IdBodegaOrigen, IdTransferencia);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrDet_x_Transfe", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_agrupada(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_det_agrupada(IdEmpresa, IdSucursal, IdBodega, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven_det_agrupada", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_det_x_OC_Agrupado(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
      
        {
            try
            {
                return odata.Get_List_Ing_Egr_det_x_OC_Agrupado(IdEmpresa, IdSucursal, IdOrdenCompra);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrDet_x_OC_Agrupado", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };


            }
        
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_OrdenCompra(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {

            try
            {
                return odata.Get_List_Ing_Egr_Inven_det_x_OrdenCompra(IdEmpresa, IdSucursal, IdOrdenCompra);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrDet_x_OC", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }
        
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_Inven_det_x_OrdenCompraDet(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                  return odata.Get_List_Ing_Egr_Inven_det_x_OrdenCompraDet(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngEgrDet_x_OrdenCompraDet", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }
                       
        }


        public Boolean ModificarDB(in_Ing_Egr_Inven_det_Info Info, ref  string msg)
        {
            try
            {
                return odata.ModificarDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };

            }       
        
        }


        public List<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_Info> Get_List_Ing_Egr_x_Cbte_Cble(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_List_Ing_Egr_x_Cbte_Cble(IdEmpresa, IdSucursal,IdBodega, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Ing_Egr_x_Cbte_Cble", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ing_Egr_det_x_Cat_lin_gru_sub_Centro_subcentro(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo, int IdSubgrupo, string IdCentroCosto, string IdCentroCosto_sub_centro_costo)
        {
            try
            {
                return odata.Get_List_Ing_Egr_det_x_Cat_lin_gru_sub_Centro_subcentro(IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubgrupo, IdCentroCosto, IdCentroCosto_sub_centro_costo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_det_x_Cat_lin_gru_sub_Centro_subcentro", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }

        public Boolean Modificar_Enserar_Campos_OC(List<in_Ing_Egr_Inven_det_Info> Lista)
        {
            try
            {
                return odata.Modificar_Enserar_Campos_OC(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Ing_Egr_x_Cbte_Cble", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_det_Bus) };
            }
        }
    }
}

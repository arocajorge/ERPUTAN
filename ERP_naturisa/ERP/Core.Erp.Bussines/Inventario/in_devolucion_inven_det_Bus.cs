using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
   public class in_devolucion_inven_det_Bus
    {

        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_devolucion_inven_det_Data oDat = new in_devolucion_inven_det_Data();



        public Boolean GuardarDB(in_devolucion_inven_det_Info info, ref string mensaje)
        {
            try
            {
                return oDat.GuardarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }

        public double Get_cantidad_devuelta(int IdEmpresa_movi_inv, int IdSucursal_movi_inv, int IdBodega_movi_inv, int IdMovi_inven_tipo_movi_inv, decimal IdNumMovi_movi_inv
             , int Secuencia_movi_inv)
        {
            try
            {
                return oDat.Get_cantidad_devuelta(IdEmpresa_movi_inv, IdSucursal_movi_inv, IdBodega_movi_inv, IdMovi_inven_tipo_movi_inv, IdNumMovi_movi_inv, Secuencia_movi_inv);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_cantidad_devuelta", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }

        public Boolean GuardarDB(List<in_devolucion_inven_det_Info> Listinfo, ref string mensaje)
        {
            try
            {
                return oDat.GuardarDB(Listinfo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdDev_Inven, ref string msgs)
        {
            try
            {
                return oDat.EliminarDB(IdEmpresa,  IdDev_Inven,ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }

        public List<in_devolucion_inven_det_Info> Get_List_in_devolucion_inven_det(int IdEmpresa, decimal IdDev_Inven)
        {
            try
            {
                return oDat.Get_List_in_devolucion_inven_det(IdEmpresa, IdDev_Inven);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_in_devolucion_inven_det", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }

        public in_devolucion_inven_det_Info Get_Info_in_devolucion_inven(int IdEmpresa, decimal IdDev_Inven)
        {
            try
            {
                return oDat.Get_Info_in_devolucion_inven(IdEmpresa,  IdDev_Inven);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_in_devolucion_inven", ex.Message), ex) { EntityType = typeof(in_devolucion_inven_det_Bus) };

            }
        }


    }
}

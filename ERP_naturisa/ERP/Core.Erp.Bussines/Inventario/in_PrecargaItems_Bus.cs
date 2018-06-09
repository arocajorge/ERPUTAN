using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_PrecargaItems_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_PrecargaItems_Data data = new in_PrecargaItems_Data();
        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int idempresa)
        {
            try
            {
                return data.Get_List_PrecargaItems(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPrecarga", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }

        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int idempresa, string IdCentroCosto)
        {
            try
            {
                return data.Get_List_PrecargaItems(idempresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPrecarga_x_CentroCosto", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }

        public List<in_PrecargaItems_Info> Get_List_PrecargaItems(int IdEmpresa, int IdSucursal, decimal IdProveedor)
        {
            try
            {
                return data.Get_List_PrecargaItems(IdEmpresa, IdSucursal, IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPrecarga_x_Proveedor", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }

        public Boolean GrabarDB(int IdEmpresa, in_PrecargaItems_Info info, List<in_PrecargaItemsDetalle_Info> lmDetalleInfo, ref string msg, ref int idgenerada)
        {
            try
            {
                return data.GrabarDB(IdEmpresa, info, lmDetalleInfo, ref msg,ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarCabeceraDB", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }

        public Boolean ModificarDB(int idempresa, in_PrecargaItems_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }

        public Boolean AnularReactiva(int idempresa, in_PrecargaItems_Info info, ref string msg)
        {
            try
            {
                return data.AnularReactiva(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularReactiva", ex.Message), ex) { EntityType = typeof(in_PrecargaItems_Bus) };

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_TipoNota_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_TipoNota_Data data = new fa_TipoNota_Data();
        string mensaje = "";

        public List<fa_TipoNota_Info> Get_List_TipoNota(int idempresa)
        {
            try
            {                
                return data.Get_List_TipoNota(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoNota", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }

        public List<fa_TipoNota_Info> Get_List_TipoNota(int idempresa,string STipo)
        {
            try
            {
                return data.Get_List_TipoNota(idempresa, STipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoNota", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };

            }
        }
        public List<fa_TipoNota_Info> Get_List_TipoNota_Todos()
        {
            try
            {                
                return data.Get_List_TipoNota_Todos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoNotaTodos", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }

        public fa_TipoNota_Info Get_List_TipoNota(int idempresa, int idsucursal, int idtipoNota)
        {
            try
            {                
                return data.Get_List_TipoNota(idempresa,idsucursal,idtipoNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoNota_x_sucursal", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }


        

        public Boolean ModificarDB(fa_TipoNota_Info info, ref string msg)
        {
            try
            {                
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }

        public Boolean GrabarDB(fa_TipoNota_Info info, ref int id, ref string msg)
        {
            try
            {
                return data.GrabarDB(info,ref id,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }

        public Boolean EliminarDB(fa_TipoNota_Info info, ref  string msg)
        {
            try
            {
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
           
            }
        }


        public fa_TipoNota_Bus() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_ProductoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<in_ProductoTipo_Info> Obtener_ProductosTipos(int idempresa)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.Get_List_ProductosTipo(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_ProductosTipos", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }
        }

        public Boolean ModificarDB(in_ProductoTipo_Info info, ref string msg)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }
        }

        public int getId(int idempresa)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.GetId(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }

        }

        public Boolean GrabarDB(in_ProductoTipo_Info info, ref int id, ref string msg)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.GrabarDB(info,ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }
        }

        public Boolean EliminarDB(in_ProductoTipo_Info info, ref  string msg)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }
        }
        public in_ProductoTipo_Info BuscarTipo(int idtipo, int idempresa)
        {
            try
            {
                in_ProductoTipo_Data data = new in_ProductoTipo_Data();
                return data.BuscarTipo(idtipo, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "BuscarTipo", ex.Message), ex) { EntityType = typeof(in_ProductoTipo_Bus) };

            }
        }

        public in_ProductoTipo_Bus() { }
    }
}

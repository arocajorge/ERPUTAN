using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_ubicacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<tb_ubicacion_Info> Get_List_Ubicacion()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                lM = data.Get_List_Ubicacion();
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Ubicacion", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }

        public List<tb_ubicacion_Info> Get_List_Ciudad()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                lM = data.Get_List_Ciudad();
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cargar_Ciudad", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }

        public List<tb_ubicacion_Info> Get_List_Pais()
        {
            try
            {
                List<tb_ubicacion_Info> lM = new List<tb_ubicacion_Info>();
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                lM = data.Get_List_Pais();
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cargar_Pais", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }


        public Boolean ModificarDB(tb_ubicacion_Info info, ref string msg)
        {
            try
            {
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                return data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }

        public Boolean GrabarDB(tb_ubicacion_Info info, ref string id, ref string msg)
        {
            try
            {
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                return data.GrabarDB(info,ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }


        public Boolean EliminarDB(tb_ubicacion_Info info, ref  string msg)
        {
            try
            {
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           
            }
        }

        public tb_ubicacion_Info Get_Info_Ubicacion(string idUbicacion)
        {
            try
            {
                tb_ubicacion_Data data = new tb_ubicacion_Data();
                return data.Get_Info_Ubicacion(idUbicacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerUnaUbicacion", ex.Message), ex) { EntityType = typeof(tb_ubicacion_Bus) };
           

            }
        }

        public tb_ubicacion_Bus() {
           
        }
    }
}

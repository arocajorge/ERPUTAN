using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_tarjeta_parametro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_tarjeta_parametro_Data data = new tb_tarjeta_parametro_Data();

        public List<tb_tarjeta_parametro_Info> Get_List_tarjeta_parametro()
        {
            try
            {
                return data.Get_List_tarjeta_parametro();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaTarjetas", ex.Message), ex) { EntityType = typeof(tb_tarjeta_parametro_Bus) };
           
            }
        }
        public Boolean GuardarDB(tb_tarjeta_parametro_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(tb_tarjeta_parametro_Bus) };
           
            }

        }

        public Boolean ModificarDB(tb_tarjeta_parametro_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(tb_tarjeta_parametro_Bus) };
           
            }

        }

        public tb_tarjeta_parametro_Info Get_Info_tarjeta_parametro(int IdTarjeta, int IdEmpresa)
        {
            try
            {
                return data.Get_Info_tarjeta_parametro(IdTarjeta,IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerInfo", ex.Message), ex) { EntityType = typeof(tb_tarjeta_parametro_Bus) };
           
            }
        }

        public List<vwGe_tb_Tarjeta_tb_Parametro_Info> Get_list_tarjeta_parametro(int IdEmpresa)
        {
            try
            {
                return data.Get_list_tarjeta_parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaVista", ex.Message), ex) { EntityType = typeof(tb_tarjeta_parametro_Bus) };
           
            }
        }
    }
}

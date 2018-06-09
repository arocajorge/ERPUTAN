using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_transportista_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_transportista_Data Data = new tb_transportista_Data();
        public List<tb_transportista_Info> Get_List_transportista(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_transportista(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(tb_transportista_Bus) };
           
            }
        
        }

        

       
        public tb_transportista_Bus() {
       
        }

        public Boolean GuardarDB(tb_transportista_Info info,  ref decimal IdTransportista)
        {
            try
            {
                return Data.GuardarDB(info, ref IdTransportista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_transportista_Bus) };
           
            }
        }

        public Boolean ModificarDB(tb_transportista_Info info)
        {
            try
            {
                return Data.ModificarDB(info);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_transportista_Bus) };
           
            }
        }

        public Boolean AnularDB(tb_transportista_Info info)
        {
            try
            {
                return Data.AnularDB(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(tb_transportista_Bus) };
           
            }

        }

        public tb_transportista_Info Get_Info_Transportista(int IdEmpresa, string Cedula)
        {
            try
            {return Data.Get_Info_Transportista(IdEmpresa, Cedula);

            }
            catch (Exception ex)
            {
                
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransportistaPorCedula", ex.Message), ex) { EntityType = typeof(tb_transportista_Bus) };
           
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_tipoDocumento_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_tipoDocumento_Data data = new tb_sis_tipoDocumento_Data();
        public List<tb_sis_tipoDocumento_Info> Get_List_sis_tipoDocumento()
        {
            try
            {
                return data.Get_List_sis_tipoDocumento();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaTipoDoc", ex.Message), ex) { EntityType = typeof(tb_sis_tipoDocumento_Bus) };
           
            }
        }


        public List<tb_sis_tipoDocumento_Info> Get_List_sis_tipoDocumento(int IdEmpresa)
        {
            try
            {
                return data.Get_List_sis_tipoDocumento(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaTipoDocPorEmpresa", ex.Message), ex) { EntityType = typeof(tb_sis_tipoDocumento_Bus) };
           
            }
        
        }

        public Boolean GuardarDB(tb_sis_tipoDocumento_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(tb_sis_tipoDocumento_Bus) };
           
            }
        
        }

        public Boolean ModificarDB(tb_sis_tipoDocumento_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(tb_sis_tipoDocumento_Bus) };
           
            }
        }

        public tb_sis_tipoDocumento_Bus()
        {
            
        }
    }
}

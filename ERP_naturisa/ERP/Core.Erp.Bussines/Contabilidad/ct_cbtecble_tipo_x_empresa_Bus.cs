using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_cbtecble_tipo_x_empresa_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_cbtecble_tipo_x_empresa_Data oData = new ct_cbtecble_tipo_x_empresa_Data();

        public List<ct_cbtecble_tipo_x_empresa_Info> Get_list_cbtecble_tipo_x_empresa(int IdEmpresa)
        {
            try
            {
                  return oData.Get_list_cbtecble_tipo_x_empresa(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cbtecble_tipo_x_empresa", ex.Message), ex) { EntityType = typeof(ct_cbtecble_tipo_x_empresa_Bus) };
            }

        }
        
        public Boolean GuardarDB(ct_cbtecble_tipo_x_empresa_Info Info)
        {
            try
            {
                 return oData.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_tipo_x_empresa_Bus) };
            }

        }
        
        public Boolean EliminarDB(ct_cbtecble_tipo_x_empresa_Info Info)
        {
            try
            {
                  return oData.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_tipo_x_empresa_Bus) };
            }

        }

        public ct_cbtecble_tipo_x_empresa_Info Get_Info_cbtecble_tipo_x_empresa(int IdEmpresa, int IdTipoCbte)
        {
            try
            {
                 return oData.Get_Info_cbtecble_tipo_x_empresa(IdEmpresa, IdTipoCbte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_cbtecble_tipo_x_empresa", ex.Message), ex) { EntityType = typeof(ct_cbtecble_tipo_x_empresa_Bus) };
            }

        }
    }
}

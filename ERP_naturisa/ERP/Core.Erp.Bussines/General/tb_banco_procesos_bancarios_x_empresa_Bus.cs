using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.General
{
    public class tb_banco_procesos_bancarios_x_empresa_Bus
    {
        tb_banco_procesos_bancarios_x_empresa_Data oData = new tb_banco_procesos_bancarios_x_empresa_Data();

        public List<tb_banco_procesos_bancarios_x_empresa_Info> Get_list_procesos_bancarios_x_empresa(int IdEmpresa)
        {
            try
            {
                return oData.Get_list_procesos_bancarios_x_empresa(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_procesos_bancarios_x_empresa", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }

        public List<tb_banco_procesos_bancarios_x_empresa_Info> Get_list_procesos_bancarios_x_empresa(int IdEmpresa, int IdBanco_Financiero)
        {
            try
            {
                return oData.Get_list_procesos_bancarios_x_empresa(IdEmpresa, IdBanco_Financiero);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_procesos_bancarios_x_empresa", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }

        public tb_banco_procesos_bancarios_x_empresa_Info Get_info_proceso_bancario_x_empresa(int IdEmpresa, string IdProceso_bancario)
        {
            try
            {
                return oData.Get_info_proceso_bancario_x_empresa(IdEmpresa, IdProceso_bancario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_proceso_bancario_x_empresa", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }

        public bool GuardarDB(tb_banco_procesos_bancarios_x_empresa_Info Info)
        {
            try
            {
                return oData.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }

        public bool GuardarDB(List<tb_banco_procesos_bancarios_x_empresa_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }

        public bool EliminarDB(int IdEmpresa, int IdBanco)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_x_empresa_Bus) };
            }
        }
    }
}

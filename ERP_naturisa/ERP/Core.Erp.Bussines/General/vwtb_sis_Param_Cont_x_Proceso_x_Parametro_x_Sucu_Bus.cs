using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data data = new vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data();
        public List<vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Get_List_tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu(int IdEmpresa, string IdProcesoConta)
        {
            try
            {
                return data.Get_List_tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu(IdEmpresa, IdProcesoConta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus) };
            }
        }
    }
}

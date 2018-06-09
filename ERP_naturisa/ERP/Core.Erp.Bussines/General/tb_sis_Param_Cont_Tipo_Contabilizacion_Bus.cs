using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_Param_Cont_Tipo_Contabilizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Param_Cont_Tipo_Contabilizacion_Data data = new tb_sis_Param_Cont_Tipo_Contabilizacion_Data();
        public List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info> ConsultarParamConta() {
            try
            {
                return data.ConsultarParamConta();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarParamConta", ex.Message), ex) { EntityType = typeof(tb_sis_Param_Cont_Tipo_Contabilizacion_Bus) };
                   
            }
        }

        public String ConsEspeParamConta(String idConta) {
            try
            {
                return data.ConsEspeParamConta(idConta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsEspeParamConta", ex.Message), ex) { EntityType = typeof(tb_sis_Param_Cont_Tipo_Contabilizacion_Bus) };
                   
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.SRI;
using Core.Erp.Info.SRI;
using Core.Erp.Business.General;

namespace Core.Erp.Business.SRI
{
    public class sri_provincia_Bus
    {
        sri_provincia_Data Data = new sri_provincia_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<sri_provincia_Info> ConsultaGeneralProv()
        {
            try
            {
                return Data.ConsultaGeneralProv();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralProv", ex.Message), ex) { EntityType = typeof(sri_provincia_Bus) };
            }

        }
    }
}

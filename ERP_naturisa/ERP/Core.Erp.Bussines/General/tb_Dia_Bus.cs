using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_Dia_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        tb_Dia_Data dbDia = new tb_Dia_Data();
        public List<tb_Dia_Info> Get_List_Dia()
        {
            try
            {
                 return dbDia.Get_List_Dia();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralDia", ex.Message), ex) { EntityType = typeof(tb_Dia_Bus) };
                ;
            }

        }
    }
}

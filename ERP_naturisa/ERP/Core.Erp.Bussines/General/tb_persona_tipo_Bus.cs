using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
  public  class tb_persona_tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

      tb_persona_tipo_Data odata = new tb_persona_tipo_Data();

      public List<tb_persona_tipo_Info> Get_List_persona_tipo()
      {
          try
          {
              return odata.Get_List_persona_tipo();
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaLista_PersonaTipo", ex.Message), ex) { EntityType = typeof(tb_persona_tipo_Bus) };
         
          }
      }
    }
}

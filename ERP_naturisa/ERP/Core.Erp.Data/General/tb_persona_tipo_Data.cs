using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
  public  class tb_persona_tipo_Data
    {
      string mensaje = "";

      public List<tb_persona_tipo_Info> Get_List_persona_tipo()
      {
          try
          {
              List<tb_persona_tipo_Info> List = new List<tb_persona_tipo_Info>();

              EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
              var selectPersoTipo = from C in OEselecEmpresa.tb_persona_tipo
                                    select C;



              foreach (var item in selectPersoTipo)
              {
                  tb_persona_tipo_Info info = new tb_persona_tipo_Info();

                  info.IdTipo_Persona = item.IdTipo_Persona;
                  info.Descripcion = item.Descricpion;

                  List.Add(info);
              }
              return (List);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}

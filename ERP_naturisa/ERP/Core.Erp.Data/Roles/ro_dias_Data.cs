using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
  public  class ro_dias_Data
  {
      string mensaje = "";

      public List<ro_dias_Info> Get_Dias()
      {
         List< ro_dias_Info >Lis_Dias =new List< ro_dias_Info>();

          EntitiesRoles EORoles = new EntitiesRoles();
          try
          {

              var select = from C in EORoles.ro_dias
                           
                           select C;
              foreach (var item in select)
              {
                  ro_dias_Info info_Dias = new ro_dias_Info();

                  info_Dias.Id_dia = item.Id_dia;
                  info_Dias.sdia = item.sdia;
                  info_Dias.nemonico = item.nemonico;
                  info_Dias.sdia_completo_a_partir_de = item.sdia_completo_a_partir_de;
                  Lis_Dias.Add(info_Dias);
              }
              return Lis_Dias;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.InnerException.ToString());
          }
      }
    }
}

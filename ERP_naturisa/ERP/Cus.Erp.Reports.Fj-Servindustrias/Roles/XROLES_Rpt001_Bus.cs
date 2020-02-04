using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt001_Bus
    {
      XROLES_Rpt001_Data data = new XROLES_Rpt001_Data();
      public List<XROLES_Rpt001_Info> Get_list_Horas_Extras(int IdEmpresa, int IdNomina_Tipo, int IdNomina_tipo_Liq, int IdPerido)
      {
      
          try
          {
              return data.Get_list_Horas_Extras(IdEmpresa,IdNomina_Tipo,IdNomina_tipo_Liq,IdPerido);
          }
          catch (Exception ex)
          {
              

                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);          }
      }
    }
}

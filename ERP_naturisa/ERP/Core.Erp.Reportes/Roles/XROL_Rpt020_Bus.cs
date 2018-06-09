
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;
namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt020_Bus
  {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      XROL_Rpt020_Data oData = new XROL_Rpt020_Data();
      public List<XROL_Rpt020_Info> GetListConsultaGeneral(int idEmpresa, int IdDepartamento,int idnomina_tipo, DateTime fi, DateTime ff)
      {
          try
          {
              return oData.GetListConsultaGeneral(idEmpresa, IdDepartamento,idnomina_tipo, fi, ff);
          }
          catch (Exception ex)
          {
              oLog.Log_Error(ex.ToString());
              mensaje = "Error.." + ex.Message;
              return new List<XROL_Rpt020_Info>();
          }
      }

      public List<XROL_Rpt020_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, DateTime fi, DateTime ff)
      {
          try
          {
              return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo, fi, ff);
          }
          catch (Exception ex)
          {
              oLog.Log_Error(ex.ToString());
              mensaje = "Error.." + ex.Message;
              return new List<XROL_Rpt020_Info>();
          }
      }

    }
}

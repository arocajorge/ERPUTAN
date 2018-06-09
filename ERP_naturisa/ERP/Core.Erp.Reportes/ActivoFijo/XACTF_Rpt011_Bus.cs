using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
  public  class XACTF_Rpt011_Bus
    {

      XACTF_Rpt011_Data odata = new XACTF_Rpt011_Data();
      
      public List<XACTF_Rpt011_Info> consultar_data(int IdEmpresa,int IdPeriodo, ref string mensaje)
      {
          try
          {
              return odata.consultar_data(IdEmpresa, IdPeriodo,ref  mensaje);
          }
          catch (Exception ex)
          {

              tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
              oLog.Log_Error(ex.ToString());
              throw new Exception(ex.ToString());
          }
      
      
      
      }
    }
}

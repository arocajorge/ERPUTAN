using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public   class XCXP_Rpt010_Bus
    {
      XCXP_Rpt010_Data NBPROVEE = new XCXP_Rpt010_Data();
      public List<XCXP_Rpt010_Info> consultar_data(int IdEmpresa, decimal ProveedorIni,decimal ProveedorFin,DateTime FechaIni,DateTime FechaFin, ref string mensaje)
      {
          try
          {
              return NBPROVEE.consultar_data(IdEmpresa, ProveedorIni, ProveedorFin,FechaIni,FechaFin, ref mensaje);
          }
          catch (Exception ex)
          {


              return new List<XCXP_Rpt010_Info>();
          }
      }

      public XCXP_Rpt010_Bus()
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
  public  class XCXC_Rpt013_Bus
    {
      XCXC_Rpt013_Data Odata = new XCXC_Rpt013_Data();

      public List<XCXC_Rpt013_Info> Get_Data_Reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,
          bool Mostrar_fact_sin_rt,XCXC_Rpt013_Data.eFiltro_Fecha_Busqueda Fecha_Busqueda,decimal IdCliente)
      {
          try
          {
              return Odata.Get_Data_Reporte(IdEmpresa, FechaIni, FechaFin, Mostrar_fact_sin_rt, Fecha_Busqueda, IdCliente);
          }
          catch (Exception ex)
          {
              return new List<XCXC_Rpt013_Info>();
          }
      }

    }
}

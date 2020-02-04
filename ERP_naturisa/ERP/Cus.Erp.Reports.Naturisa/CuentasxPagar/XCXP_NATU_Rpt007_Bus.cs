using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
  public  class XCXP_NATU_Rpt007_Bus
    {
        XCXP_NATU_Rpt007_Data Natu_Rpt_Data = new XCXP_NATU_Rpt007_Data();
        public List<XCXP_NATU_Rpt007_Info> consultar_Data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin
            ,ref List<XCXP_NATU_Rpt007_Resumen_Info> list_Resumen_ret 
            ,ref string mensaje)
        {
            try
            {
                return Natu_Rpt_Data.consultar_Data(IdEmpresa, ProveedorIni, ProveedorFin, FechaIni, FechaFin,ref list_Resumen_ret, ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt007_Info>();
            }
        }
    }
}

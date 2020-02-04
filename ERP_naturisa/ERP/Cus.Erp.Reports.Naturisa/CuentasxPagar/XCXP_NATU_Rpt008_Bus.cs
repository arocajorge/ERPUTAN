using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
   public class XCXP_NATU_Rpt008_Bus
    {
        XCXP_NATU_Rpt008_Data Natu_Rpt_Data = new XCXP_NATU_Rpt008_Data();
        public List<XCXP_NATU_Rpt008_Info> consultar_Data(int IdEmpresa, decimal ClaseProveedorIni, decimal ClaseProveedorFin, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin, bool Mostrar_saldo_cero, ref string mensaje)
        {
            try
            {
                return Natu_Rpt_Data.consultar_Data(IdEmpresa, ClaseProveedorIni, ClaseProveedorFin,IdProveedorIni,IdProveedorFin, FechaIni, FechaFin,Mostrar_saldo_cero, ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt008_Info>();
            }
        }
    }
}

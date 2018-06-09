using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt017_Bus
    {
       XCXP_Rpt017_Data dataRpt = new XCXP_Rpt017_Data();

       public List<XCXP_Rpt017_Info> get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(int IdEmpresa, DateTime FechaCorte, decimal IdProveedorIni, decimal IdProveedorFin)
        {
            try
            {
                return dataRpt.get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin);
            }
            catch (Exception)
            {
                return new List<XCXP_Rpt017_Info>();
            }
        }
    }
}

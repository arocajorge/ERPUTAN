using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt004_Bus
    {

        XCXP_NATU_Rpt004_Data Natu_Rpt_Data = new XCXP_NATU_Rpt004_Data();
        public List<XCXP_NATU_Rpt004_Info> consultar_Data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje, int IdClaseProveedor, string IdUsuario)
        {
            try
            {
                return Natu_Rpt_Data.consultar_Data(IdEmpresa, ProveedorIni,ProveedorFin, FechaIni, FechaFin, ref mensaje,IdClaseProveedor, IdUsuario);
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt004_Info>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt015_Bus
    {
        XCXC_Rpt015_Data dataRpt = new XCXC_Rpt015_Data();

        public List<XCXC_Rpt015_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdCliente, int IdSucursalIni, int IdSucursalFin, DateTime fechaIni, DateTime fechaFin, int IdTipocliente)
        {
            try
            {
                return dataRpt.get_DetalleCarteraVencida(IdEmpresa,IdCliente, IdSucursalIni, IdSucursalFin, fechaIni, fechaFin, IdTipocliente);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt015_Info>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt007_Bus
    {
        XCXC_Rpt007_Data dataRpt = new XCXC_Rpt007_Data();

        public List<XCXC_Rpt007_Info> get_ReporteCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdCliente, DateTime FechaCorte, bool solo_cbtes_con_saldo)
        {
            try
            {
                return dataRpt.get_ReporteCarteraVencida(IdEmpresa, IdSucursalIni, IdSucursalFin, IdCliente, FechaCorte, solo_cbtes_con_saldo);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt007_Info>();
            }
        }



        public XCXC_Rpt007_Bus()
        {

        }

    }
}

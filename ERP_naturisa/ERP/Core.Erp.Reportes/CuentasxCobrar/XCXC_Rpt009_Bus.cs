using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt009_Bus
    {
        XCXC_Rpt009_Data dataRpt = new XCXC_Rpt009_Data();

        public List<XCXC_Rpt009_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte, int cliente_legal)
        {
            try
            {
                return dataRpt.get_DetalleCarteraVencida(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte, cliente_legal);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt009_Info>();
            }
        }

        public List<XCXC_Rpt009_Info> get_DetalleCarteraVencida(int IdEmpresa, int IdCliente, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte, int IdTipoCliente)
        {
            try
            {
                return dataRpt.get_DetalleCarteraVencida(IdEmpresa, IdCliente, IdSucursalIni, IdSucursalFin, FechaCorte, IdTipoCliente);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt009_Info>();
            }
        }

        public XCXC_Rpt009_Bus()
        {
                
        }
    }
}

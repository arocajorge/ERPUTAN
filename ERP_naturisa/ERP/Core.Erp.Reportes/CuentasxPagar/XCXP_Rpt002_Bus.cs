using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt002_Bus
    {
        XCXP_Rpt002_Data estadodata = new XCXP_Rpt002_Data();
        public List<XCXP_Rpt002_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedor, DateTime Fecha_Ini, DateTime Fecha_Fin, int IdClaseProveedorIni, int IdClaseProveedorFin, ref String mensaje)
        {
            try
            {
                return estadodata.consultar_data(IdEmpresa, IdProveedor, Fecha_Ini, Fecha_Fin, IdClaseProveedorIni, IdClaseProveedorFin, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt002_Info>();
            }
        }
        public XCXP_Rpt002_Bus()
        {
        }
    }
}

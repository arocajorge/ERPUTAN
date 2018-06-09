using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt002_Bus
    {
        XCOMP_NATU_Rpt002_Data Ocdata = new XCOMP_NATU_Rpt002_Data();
        public List<XCOMP_NATU_Rpt002_Info> consultar_data(int IdEmpresa, int IdSucursal, Decimal IdProveedorIni, Decimal IdProveedorFin
            , DateTime Fecha_OC_Ini, DateTime Fecha_OC_Fin, ref String mensaje)
        {
            try
            {
                return Ocdata.Consultar_Data(IdEmpresa, IdSucursal, IdProveedorIni, IdProveedorFin, Fecha_OC_Ini, Fecha_OC_Fin, ref  mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt002_Info>();
            }

        }

        public XCOMP_NATU_Rpt002_Bus()
        {

        }

    }
}

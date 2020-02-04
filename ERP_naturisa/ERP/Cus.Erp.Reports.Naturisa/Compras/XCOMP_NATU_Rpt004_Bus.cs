using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
   public class XCOMP_NATU_Rpt004_Bus
    {

       XCOMP_NATU_Rpt004_Data Ocdata = new XCOMP_NATU_Rpt004_Data();
        public List<XCOMP_NATU_Rpt004_Info> consultar_data
            (int IdEmpresa, int IdSucursal, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin,decimal IdProductoIni, decimal IdProductoFin, ref string mensaje)
        {
            try
            {
                return Ocdata.consultar_data
                    (IdEmpresa, IdSucursal, IdProveedorIni,
                    IdProveedorFin,
                    FechaIni, FechaFin,IdProductoIni,  IdProductoFin, ref  mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt004_Info>();
            }

        }


       public  XCOMP_NATU_Rpt004_Bus(){}
    }
}

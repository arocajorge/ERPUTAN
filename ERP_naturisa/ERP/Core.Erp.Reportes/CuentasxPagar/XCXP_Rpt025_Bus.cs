using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt025_Bus
    {
        XCXP_Rpt025_Data oData = new XCXP_Rpt025_Data();

        public List<XCXP_Rpt025_Info> Get_Lista_Reporte(int idEmpresa, string idCentroCosto, string idSubcentroCosto, DateTime fechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idCentroCosto, idSubcentroCosto,fechaIni, FechaFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

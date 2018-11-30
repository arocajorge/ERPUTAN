using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt023_Bus
    {
        XCONTA_Rpt023_Data odata = new XCONTA_Rpt023_Data();
        public List<XCONTA_Rpt023_Info> GetList(int IdEmpresa, string IdCentroCosto, int Nivel, DateTime FechaFin, string IdUsuario, string Balance, bool MostrarSaldo0)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdCentroCosto, Nivel, FechaFin, IdUsuario, Balance, MostrarSaldo0);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt017_Bus
    {
        XCXC_Rpt017_Data oData = new XCXC_Rpt017_Data();
        public List<XCXC_Rpt017_Info> Get_lst_reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_lst_reporte(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}

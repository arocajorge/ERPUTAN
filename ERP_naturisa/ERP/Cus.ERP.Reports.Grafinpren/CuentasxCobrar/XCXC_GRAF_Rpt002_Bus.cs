using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt002_Bus
    {
        XCXC_GRAF_Rpt002_Data oData = new XCXC_GRAF_Rpt002_Data();
        public List<XCXC_GRAF_Rpt002_Info> Get_list_reporte(int IdEmpresa, decimal IdCliente, decimal IdVendedor, DateTime FechaCorte, bool Mostrar_solo_vencidas)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdCliente, IdVendedor, FechaCorte,Mostrar_solo_vencidas);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

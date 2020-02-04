using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt001_Bus
    {
        XCXP_NATU_Rpt001_Data clasedata = new XCXP_NATU_Rpt001_Data();

        public List<XCXP_NATU_Rpt001_Info> consultar_data(int IdEmpresa, string TipoPersona, Decimal IdProveedorIni, Decimal IdProveedorFin, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try 
            {	        
                return clasedata.consultar_data( IdEmpresa, TipoPersona,  IdProveedorIni, IdProveedorFin,co_fechaOg_Ini,co_fechaOg_Fin, ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt001_Info>();
            }
        }

        public XCXP_NATU_Rpt001_Bus()
        {

        }
    }
}
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt003_Bus
    {
        XCXP_NATU_Rpt003_Data estadodata = new XCXP_NATU_Rpt003_Data();
        public List<XCXP_NATU_Rpt003_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedor, string Tipo_Persona, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                return estadodata.consultar_data(IdEmpresa, IdProveedor, Tipo_Persona, co_fechaOg_Ini, co_fechaOg_Fin, ref  mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_NATU_Rpt003_Info>();
            }
        }

        public XCXP_NATU_Rpt003_Bus()
        {
        }
    }
}

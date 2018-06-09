using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt005_Bus
    {
        
        XCXP_Rpt005_Data OrdenPago = new XCXP_Rpt005_Data();

        public List<XCXP_Rpt005_Info> consultar_data(int IdEmpresa, decimal IdOrdenPago, decimal IdEntidad, ref string mensaje)
        {
            try
            {
                return OrdenPago.consultar_data(IdEmpresa, IdOrdenPago, IdEntidad, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt005_Info>();
            }
        }
        public XCXP_Rpt005_Bus()
        {
	}

    }
}

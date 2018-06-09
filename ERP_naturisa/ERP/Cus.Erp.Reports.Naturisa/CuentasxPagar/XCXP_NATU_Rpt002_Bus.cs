using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt002_Bus
    {
        XCXP_NATU_Rpt002_Data saldoProvedata = new XCXP_NATU_Rpt002_Data();
        public List<XCXP_NATU_Rpt002_Info> consultar_data
        (int IdEmpresa, Decimal IdProveedorIni, Decimal IdProveedorFin, DateTime Fecha_Ini, DateTime Fecha_Fin, int IdClaseProveedorIni, int IdClaseProveedorFin, bool Filtrar_fecha_emi, ref String mensaje)
        {
            try 
	{	        
		return saldoProvedata.consultar_data(IdEmpresa, IdProveedorIni, IdProveedorFin, Fecha_Ini, Fecha_Fin, IdClaseProveedorIni, IdClaseProveedorFin,Filtrar_fecha_emi, ref mensaje);
	}
	catch (Exception ex)
	{
		
		return new List<XCXP_NATU_Rpt002_Info>();
	}
    }
        public XCXP_NATU_Rpt002_Bus()
        {
        
        }
    }
}

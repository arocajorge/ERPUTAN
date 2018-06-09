using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt008_Bus
    {
        XCXP_Rpt008_Data oData = new XCXP_Rpt008_Data();
        public List<XCXP_Rpt008_Info> Get_list(int IdEmpresa, int IdClase_prov, decimal IdProveedor,  DateTime Fecha_fin, bool Mostrar_anuladas, bool Mostrar_saldo_0)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdClase_prov, IdProveedor, Fecha_fin, Mostrar_anuladas,Mostrar_saldo_0);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_proveedor_microempresa_Bus
    {
        cp_proveedor_microempresa_Data odata = new cp_proveedor_microempresa_Data();

        public cp_proveedor_microempresa_Info GetInfo(string Ruc)
        {
            try
            {
                return odata.GetInfo(Ruc);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

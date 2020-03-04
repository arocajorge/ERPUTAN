using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_giro_det_Bus
    {
        cp_orden_giro_det_Data odata = new cp_orden_giro_det_Data();

        public List<cp_orden_giro_det_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCle)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdTipoCbte, IdCbteCle);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

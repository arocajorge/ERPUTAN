using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_reembolso_Bus
    {
       cp_reembolso_Data odata = new cp_reembolso_Data();
       public List<cp_reembolso_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
       {
           try
           {
               return odata.GetList(IdEmpresa, IdTipoCbte, IdCbteCble);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}

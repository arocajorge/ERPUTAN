using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_orden_pago_formapago_Info
    {
       public bool check { get; set; }
       public string IdFormaPago	{set;get;}
       public string descripcion {set;get;}	
       public string IdTipoTransaccion	{set;get;}
       public string CodModulo {set;get;}
       public Nullable<int> IdTipoMovi_caj { set; get; }

      public cp_orden_pago_formapago_Info() { }


    }
}

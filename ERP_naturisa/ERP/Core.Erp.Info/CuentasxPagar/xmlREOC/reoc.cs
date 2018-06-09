using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar.xmlATS;

namespace Core.Erp.Info.CuentasxPagar.xmlREOC
{
    public class reoc
    {

        public string numeroRuc { get; set; }
        public int anio { get; set; }
        public string mes { get; set; }
        public List<detalleCompras> compras { get; set; }
         public reoc(){ }

    }
}

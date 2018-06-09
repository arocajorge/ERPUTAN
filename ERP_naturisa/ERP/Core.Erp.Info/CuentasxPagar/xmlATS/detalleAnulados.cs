using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlATS
{
    public class detalleAnulados
    {

        public string tipoComprobante { get; set; }

        public string establecimiento { get; set; }

        public string puntoEmision { get; set; }

        public string secuencialInicio { get; set; }

        public string secuencialFin { get; set; }

        public string autorizacion { get; set; }

        public detalleAnulados(){}
    }
}

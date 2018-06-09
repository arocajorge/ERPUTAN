using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlATS
{
    public class reembolso
    {
        public string tipoComprobanteReemb { get; set; }
        public string tpIdProvReemb { get; set; }
        public string idProvReemb { get; set; }
        public string establecimientoReemb { get; set; }
        public string puntoEmisionReemb { get; set; }
        public string secuencialReemb { get; set; }
        public string fechaEmisionReemb { get; set; }
        public string autorizacionReemb { get; set; }
        public string baseImponibleReemb { get; set; }
        public string baseImpGravReemb { get; set; }
        public string baseNoGraIvaReemb { get; set; }
        public string montoIceRemb { get; set; }
        public string montoIvaRemb { get; set; }

        public reembolso(){}
    }
}

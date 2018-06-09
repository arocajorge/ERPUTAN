using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlATS
{
    public class iva
    {
        public string TipoIDInformante { get; set; } //
        public string IdInformante { get; set; }
        public string razonSocial { get; set; }
        public int Anio { get; set; }
        public string Mes { get; set; }
        public string numEstabRuc { get; set; } //
        public string totalVentas { get; set; } //
        public string codigoOperativo { get; set; } //

        public List<detalleCompras> compras { get; set; }
        public List<detalleVentas> ventas { get; set; }
        public List<ventaEst>ventasEstablecimiento { get; set; }
        public List<detalleAnulados> anulados { get; set; }
         
       public iva(){ }
    }
}

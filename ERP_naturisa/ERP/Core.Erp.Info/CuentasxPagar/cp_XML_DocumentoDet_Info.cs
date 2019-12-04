using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_XML_DocumentoDet_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDocumento { get; set; }
        public int Secuencia { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<double> Precio { get; set; }
        public Nullable<double> PorcentajeIVA { get; set; }
        public Nullable<double> ValorIva { get; set; }
        public Nullable<double> Total { get; set; }
    }
}

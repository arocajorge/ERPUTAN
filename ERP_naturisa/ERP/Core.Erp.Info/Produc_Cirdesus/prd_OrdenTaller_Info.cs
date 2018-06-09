using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_OrdenTaller_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal  IdOrdenTaller { get; set; }
        public string CodObra { get; set; }
        public int NumeroOT { get; set; }
        public decimal IdProducto { get; set; }
        public decimal CantidadPieza { get; set; }
        public decimal TotalPeso { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string Codigo { get; set; }
        public decimal PesoUnitario { get; set; }
        public DateTime FechaReg { get; set; }
        public string ca_categorias { get; set; }
        public string NomProducto { get; set; }
        public decimal IdCliente { get; set; }

        public string ob_descripcion { get; set; }
        public string NomSucursal { get; set; }

        public string Referencia { get; set; }

        public Nullable<decimal> IdListadoDiseno { get; set; }
        public string ListadoDiseno { get; set; }

        public Nullable<decimal> TotalLongitud { get; set; }
        public Nullable<decimal> LongitudUnitaria { get; set; }

        public Nullable<double> longitudProducto { get; set; }

        public prd_OrdenTaller_Info() { }
    }
}

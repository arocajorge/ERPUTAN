using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_venta_telefonica_det_Info
    {
        public int IdEmpresa {get; set;}
        public int IdSucursal{get; set;}
        public decimal IdVenta_tel { get; set;}
        public Nullable<int> Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Base { get; set; }

        public fa_venta_telefonica_det_Info() { }
    }
}

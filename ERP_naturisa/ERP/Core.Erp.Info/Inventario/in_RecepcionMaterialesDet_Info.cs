using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_RecepcionMaterialesDet_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdRecepcionMaterial { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double re_CantRecibida { get; set; }
        public double re_Saldo { get; set; }

        public in_RecepcionMaterialesDet_Info() { }
    }
}

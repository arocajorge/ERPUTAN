using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_AjusteFisico_Detalle_Info

    {

        public int IdEmpresa { get; set; }
        public decimal IdAjusteFisico { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double StockSistema { get; set; }
        public double CantidadAjustada { get; set; }
        public double StockFisico { get; set; }
        public string IdCentroCosto { get; set; }
        public in_AjusteFisico_Detalle_Info() { }

    }
}

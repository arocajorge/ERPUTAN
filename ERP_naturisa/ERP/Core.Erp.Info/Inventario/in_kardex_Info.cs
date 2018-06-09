using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_kardex_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public double kr_saldoInicial { get; set; }
        public double kr_saldoFinal { get; set; }
        public double kr_TotalIngresos { get; set; }
        public double kr_TotalEgresos { get; set; }
        public double kr_TotalMovimientos { get; set; }
        public double kr_costoInicial { get; set; }
        public double kr_costoFinal { get; set; }
        public double kr_stockActual { get; set; }

        public List<in_kardex_det_info> detalleKardex { get; set; }



        public in_kardex_Info() { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_Producto_Composicion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProductoPadre { get; set; }
        public decimal IdProductoHijo { get; set; }
        public string NomProdcutoHijo { get; set; }
        public double Cantidad { get; set; }

        public in_Producto_Composicion_Info() { }
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN22
/// </summary>
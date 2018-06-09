using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produccion_Talme
{
    public class prod_ProgramaProd_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProgramaProd { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdProducto { get; set; }
        public string IdCategoria { get; set; }
        public decimal Unidad { get; set; }
        public decimal Peso { get; set; }
        public decimal Toneladas { get; set; }
        public int Pedidos { get; set; }
        public string Estado { get; set; }

        public string  Producto{ get; set; }
        public string Turno { get; set; }

        public prod_ProgramaProd_Info()
        {
        }

    }
}

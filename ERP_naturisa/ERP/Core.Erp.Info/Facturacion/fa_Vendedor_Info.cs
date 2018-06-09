using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_Vendedor_Info
    {
        public int IdEmpresa { get; set; }
        public int IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
        public string  Estado { get; set; }
        public double Ve_Comision { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string SEstado { get; set; }
        public string ve_cedula { get; set; }

        public fa_Vendedor_Info() { }
    }
}

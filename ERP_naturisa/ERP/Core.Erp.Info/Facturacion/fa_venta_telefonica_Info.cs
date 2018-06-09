using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_venta_telefonica_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdVenta_tel { get; set;}
        public decimal IdCliente  { get; set; }
        public DateTime Fecha  { get; set; }
        public string Observacion  { get; set; }
        public string IdMotivo  { get; set; }
        public string Contactar_futuro {get; set;}
        public string IdUsuario {get; set;}
        public string Estado {get; set;}
        public Nullable<DateTime> Fecha_Transac  { get; set; }
        public string IdUsuarioUltMod {get; set;}
        public Nullable<DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc {get; set;}
        public string ip {get; set;}

        public fa_venta_telefonica_Info() { }
       
    }
}

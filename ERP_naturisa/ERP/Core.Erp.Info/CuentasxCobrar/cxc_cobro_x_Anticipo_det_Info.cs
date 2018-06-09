using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAnticipo { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public int? IdEmpresa_Cobro { get; set; }
        public int? IdSucursal_cobro { get; set; }
        public decimal? IdCobro_cobro { get; set; }
        //04022014 Derek Mejía Soria
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public int IdFila { get; set; }



        public cxc_cobro_x_Anticipo_det_Info() { }

    }
}

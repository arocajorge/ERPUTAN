using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_EstadoCobro_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public int Secuencia { get; set; }
        public string IdEstadoCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public DateTime Fecha { get; set; }
        public Nullable<int> nt_IdSucursal { get; set; }
        public Nullable<int> nt_IdBodega { get; set; }
        public Nullable<decimal> nt_IdNota { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> IdCbte_vta_nota { get; set; }
        public int posicion { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public cxc_cobro_x_EstadoCobro_Info(){}
    }
}

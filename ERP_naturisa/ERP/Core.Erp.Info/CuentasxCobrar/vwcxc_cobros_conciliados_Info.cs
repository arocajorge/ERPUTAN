using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cobros_conciliados_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdConciliacion { get; set; }
        public string Tipo { get; set; }
        public decimal IdCobro { get; set; }
        public decimal IdNota { get; set; }
        public string CreDeb { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumNota_Impresa { get; set; }
        public decimal IdCliente { get; set; }
        public string NomSucursal { get; set; }
        public string Nom_Bodega { get; set; }
        public DateTime no_fecha { get; set; }
        public DateTime no_fecha_venc { get; set; }
        public string sc_observacion { get; set; }
        public string Nom_Cliente { get; set; }
        public string Motivo_Nota { get; set; }
        public string Referencia { get; set; }
        public double sc_total { get; set; }
        public double Saldo { get; set; }
        public string IdTipoConciliacion { get; set; }
        public string IdCobro_Tipo { get; set; }
        public int IdTipoNota { get; set; }
        public int IdCaja { get; set; }
        public double saldoAUX_CreDeb { get; set; }
        public string NombreCompleto { get; set; }
    }
}

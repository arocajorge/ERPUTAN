using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string Observacion { get; set; }
        public double ValorAPagar { get; set; }
        public double TotalPagado { get; set; }
        public double Saldo { get; set; }
        public string TipoRegistro { get; set; }
        public int IdCalendario { get; set; }
        public string NombreCortoFecha { get; set; }
        public string NombreMes { get; set; }
        public int? IdMes { get; set; }
        public int? AnioFiscal { get; set; }
    }
}

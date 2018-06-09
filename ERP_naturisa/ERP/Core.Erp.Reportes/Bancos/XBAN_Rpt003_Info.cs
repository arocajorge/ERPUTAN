using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public string Tipo_Cbte { get; set; }
        public decimal Num_Cbte { get; set; }
        public int IdBanco { get; set; }
        public string Banco { get; set; }
        public DateTime Fch_Cbte { get; set; }
        public string Observacion { get; set; }
        public double Valor { get; set; }
        public string Cheque { get; set; }
        public string Chq_Girado_A { get; set; }
        public decimal? IdTipoFlujo { get; set; }
        public string Tipo_Flujo { get; set; }
        public int? IdTipoNota { get; set; }
        public string Tipo_Nota { get; set; }
        public string Fch_PostFechado { get; set; }
        public string Es_Chq_Impreso { get; set; }
        public DateTime? Fch_Chq { get; set; }
        public string Cta_Cble_Banco { get; set; }
        public int IdCalendario { get; set; }
        public int? AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreCortoFecha { get; set; }
        public int? IdMes { get; set; }
        public string pc_Cuenta { get; set; }

        public double MontoAplicado { get; set; }
        public decimal? IdOrdenPago_op { get; set; }
        public int? Secuencia_op { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha_Venc_Fac_Prov { get; set; }
        public string Observacion_FP { get; set; }
        public string TipoRegistro { get; set; }


        public double? debe { get; set; }
        public double? haber { get; set; }
        public double saldo { get; set; }
        public decimal? IdPersona_Girado_a { get; set; }
    }
}

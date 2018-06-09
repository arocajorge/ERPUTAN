using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
        public string tc_TipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cod_Cbtecble { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public decimal cb_secuencia { get; set; }
        public double cb_Valor { get; set; }
        public string ValorEnLetras { get; set; }
        public string cb_Cheque { get; set; }
        public DateTime? cb_FechaCheque { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public string cb_giradoA { get; set; }
        public string cb_ciudadChq { get; set; }
        public string nom_ciudadChq { get; set; }

        public decimal? IdCbteCble_Anulacion { get; set; }
        public int? IdTipoCbte_Anulacion { get; set; }
        public decimal? IdTipoFlujo { get; set; }
        public int? IdTipoNota { get; set; }
        public string NomTipoNota { get; set; }
        public string Por_Anticipo { get; set; }
        public string PosFechado { get; set; }
        public decimal? IdPersona_Girado_a { get; set; }
    }
}

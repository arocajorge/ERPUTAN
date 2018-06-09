using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cod_Cbtecble { get; set; }
        public int IdPeriodo { get; set; }
        public int IdBanco { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public decimal cb_secuencia { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Cheque { get; set; }
        public string cb_ChequeImpreso { get; set; }
        public Nullable<System.DateTime> cb_FechaCheque { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public Nullable<decimal> IdPersona_Girado_a { get; set; }
        public string cb_giradoA { get; set; }
        public string cb_ciudadChq { get; set; }
        public Nullable<decimal> IdCbteCble_Anulacion { get; set; }
        public Nullable<int> IdTipoCbte_Anulacion { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public string IdTransaccion { get; set; }
        public string Por_Anticipo { get; set; }
        public string PosFechado { get; set; }
        public string ValorEnLetras { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Tipo_Conciliacion { get; set; }
        public string ba_descripcion { get; set; }
    }
}

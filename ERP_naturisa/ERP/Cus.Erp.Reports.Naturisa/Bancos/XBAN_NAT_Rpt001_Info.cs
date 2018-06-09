using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cus.Erp.Reports.Naturisa.Bancos
{
    public class XBAN_NAT_Rpt001_Info
    {

        public int IdEmpresa { get; set; }
        public string nom_empresa { get; set; }
        public string ruc_empresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public int IdBanco { get; set; }
        public string nom_banco { get; set; }
        public string ba_Num_Cuenta { get; set; }
        public string IdCtaCble_ban { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public int IdPeriodo { get; set; }
        public string cb_Observacion { get; set; }
        public Nullable<double> cb_Valor { get; set; }
        public string Estado { get; set; }
        public string ValorEnLetras { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public string cb_Cheque { get; set; }
        public string dc_Observacion { get; set; }
        public Nullable<double> debito { get; set; }
        public Nullable<double> credito { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string clave_cta { get; set; }
        public string cb_giradoA { get; set; }

    }
}

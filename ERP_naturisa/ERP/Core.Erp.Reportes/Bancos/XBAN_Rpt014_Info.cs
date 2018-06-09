using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt014_Info
    {

        public int IdEmpresa { get; set; }
        public string nom_empresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public int IdBanco { get; set; }
        public string nom_banco { get; set; }
        public string ba_Num_Cuenta { get; set; }
        public string IdCtaCble_ban { get; set; }
        public DateTime cb_Fecha { get; set; }
        public int IdPeriodo { get; set; }
        public string cb_Observacion { get; set; }
        public double cb_Valor { get; set; }
        public string Estado { get; set; }
        public string ValorEnLetras { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public double debito { get; set; }
        public double credito { get; set; }
        public string dc_Observacion { get; set; }
        public string ruc_empresa { get; set; }

    }
}

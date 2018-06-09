using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt009_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public double Saldo_anterior { get; set; }
        public Nullable<double> Ingreso { get; set; }
        public Nullable<double> Egreso { get; set; }
        public Nullable<double> Saldo_final { get; set; }
        public System.DateTime fecha_ini { get; set; }
        public System.DateTime fecha_fin { get; set; }
        public string nom_Banco { get; set; }
    }
}

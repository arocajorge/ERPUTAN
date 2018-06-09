using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public int IdNivelCta { get; set; }
        public string GrupoCble { get; set; }
        public int ? OrderGrupoCble { get; set; }
        public string IdCtaCblePadre { get; set; }
        public Nullable<double> Saldo_Inicial { get; set; }
        public Nullable<double> Debito_Mes { get; set; }
        public Nullable<double> Credito_Mes { get; set; }
        public Nullable<double> Saldo { get; set; }

        public Nullable<double> Saldo_inicial_x_Movi { get; set; }
        public Nullable<double> Debito_Mes_x_Movi { get; set; }
        public Nullable<double> Credito_Mes_x_Movi { get; set; }
        public Nullable<double> Saldo_x_Movi { get; set; }
        

        public int? IdPuntoCargo { get; set; }
        public int? IdPuntoCargo_Grupo { get; set; }
        public string IdCentroCosto { get; set; }

        public string nom_PuntoCargo { get; set; }
        public string nom_PuntoCargo_Grupo { get; set; }
        public string nom_CentroCosto { get; set; }
        public string nom_empresa { get; set; }


        public string pc_EsMovimiento { get; set; }
    }
}

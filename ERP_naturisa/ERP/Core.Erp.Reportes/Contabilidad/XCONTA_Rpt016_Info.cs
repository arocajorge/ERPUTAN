using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> nivel { get; set; }
        public Nullable<int> orden { get; set; }
        public int IdTipo_Gasto { get; set; }
        public Nullable<int> orden_tipo_gasto { get; set; }
        public string nom_tipo_Gasto { get; set; }
        public string nom_tipo_Gasto_padre { get; set; }
        public double dc_Valor { get; set; }
        public string IdCta { get; set; }
        public string nom_cuenta { get; set; }
        public string nom_grupo_CC { get; set; }

        public double Saldo { get; set; }
        public string nom_periodo { get; set; }
        public int IdPeriodo { get; set; }

        public string nom_Periodo_1 { get; set; }
        public string nom_Periodo_2 { get; set; }
        public string nom_Periodo_3 { get; set; }
        public string nom_Periodo_4 { get; set; }
        public string nom_Periodo_5 { get; set; }
        public string nom_Periodo_6 { get; set; }
        public string nom_Periodo_7 { get; set; }
        public string nom_Periodo_8 { get; set; }
        public string nom_Periodo_9 { get; set; }
        public string nom_Periodo_10 { get; set; }
        public string nom_Periodo_11 { get; set; }
        public string nom_Periodo_12 { get; set; }

        public double Saldo_Periodo_1 { get; set; }
        public double Saldo_Periodo_2 { get; set; }
        public double Saldo_Periodo_3 { get; set; }
        public double Saldo_Periodo_4 { get; set; }
        public double Saldo_Periodo_5 { get; set; }
        public double Saldo_Periodo_6 { get; set; }
        public double Saldo_Periodo_7 { get; set; }
        public double Saldo_Periodo_8 { get; set; }
        public double Saldo_Periodo_9 { get; set; }
        public double Saldo_Periodo_10 { get; set; }
        public double Saldo_Periodo_11 { get; set; }
        public double Saldo_Periodo_12 { get; set; }
    }
}

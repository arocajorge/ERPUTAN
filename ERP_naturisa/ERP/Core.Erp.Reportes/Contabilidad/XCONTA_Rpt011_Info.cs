using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
   public class XCONTA_Rpt011_Info
    {

        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public int IdNivelCta { get; set; }
        public string GrupoCble { get; set; }
        public int OrderGrupoCble { get; set; }
        public string gc_estado_financiero { get; set; }
        public string IdCtaCblePadre { get; set; }
        public string pc_EsMovimiento { get; set; }




        public double? Porcen_Periodo1 { get; set; }
        public double? Saldo_Periodo_act { get; set; }
        public double? Saldo_x_Movi_Periodo_act { get; set; }
        public double? Porcen_Periodo2 { get; set; }
        public double? Saldo_Periodo_ant { get; set; }
        public double? Saldo_x_Movi_Periodo_ant { get; set; }
        public double? Variacion { get; set; }
        public double? Porcen_Variacion { get; set; }

        public int? IdPuntoCargo { get; set; }
        public int? IdPuntoCargo_Grupo { get; set; }
        public string IdCentroCosto { get; set; }

        public string nom_PuntoCargo { get; set; }
        public string nom_PuntoCargo_Grupo { get; set; }
        public string nom_CentroCosto { get; set; }
        public string nom_empresa { get; set; }
        public string nom_Periodo_ant { get; set; }
        public string nom_Periodo_act { get; set; }

        public string IdGrupo_Mayor { get; set; }
        public string nom_grupo_mayor { get; set; }
        public Nullable<int> order_grupo_mayor { get; set; }
        public int orden_fila { get; set; }
        public Nullable<bool> Reg_x_CC { get; set; }
    }
}

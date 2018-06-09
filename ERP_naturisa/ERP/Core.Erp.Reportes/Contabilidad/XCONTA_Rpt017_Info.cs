using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt017_Info
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


        public int IdPeriodo_0_SI { get; set; }
        public string nom_Periodo_0_SI { get; set; }
        public double? Saldo_Periodo_0_SI { get; set; }


        public int IdPeriodo_1 { get; set; }
        public string nom_Periodo_1 { get; set; }
        public double? Saldo_Periodo_1 { get; set; }

        public int IdPeriodo_2 { get; set; }
        public string nom_Periodo_2 { get; set; }
        public double? Saldo_Periodo_2 { get; set; }

        public int IdPeriodo_3 { get; set; }
        public string nom_Periodo_3 { get; set; }
        public double? Saldo_Periodo_3 { get; set; }

        public int IdPeriodo_4 { get; set; }
        public string nom_Periodo_4 { get; set; }
        public double? Saldo_Periodo_4 { get; set; }

        public int IdPeriodo_5 { get; set; }
        public string nom_Periodo_5 { get; set; }
        public double? Saldo_Periodo_5 { get; set; }

        public int IdPeriodo_6 { get; set; }
        public string nom_Periodo_6 { get; set; }
        public double? Saldo_Periodo_6 { get; set; }

        public int IdPeriodo_7 { get; set; }
        public string nom_Periodo_7 { get; set; }
        public double? Saldo_Periodo_7 { get; set; }

        public int IdPeriodo_8 { get; set; }
        public string nom_Periodo_8 { get; set; }
        public double? Saldo_Periodo_8 { get; set; }

        public int IdPeriodo_9 { get; set; }
        public string nom_Periodo_9 { get; set; }
        public double? Saldo_Periodo_9 { get; set; }

        public int IdPeriodo_10 { get; set; }
        public string nom_Periodo_10 { get; set; }
        public double? Saldo_Periodo_10 { get; set; }

        public int IdPeriodo_11 { get; set; }
        public string nom_Periodo_11 { get; set; }
        public double? Saldo_Periodo_11 { get; set; }

        public int IdPeriodo_12 { get; set; }
        public string nom_Periodo_12 { get; set; }
        public double? Saldo_Periodo_12 { get; set; }
        public string Periodos_mostrados { get; set; }

        public string IdGrupo_Mayor { get; set; }
        public string nom_grupo_mayor { get; set; }
        public Nullable<int> order_grupo_mayor { get; set; }
        public int orden_fila { get; set; }
        public Nullable<bool> Reg_x_CC { get; set; }
        #region cabecara



        public int? IdPuntoCargo { get; set; }
        public int? IdPuntoCargo_Grupo { get; set; }
        public string IdCentroCosto { get; set; }

        public string nom_PuntoCargo { get; set; }
        public string nom_PuntoCargo_Grupo { get; set; }
        public string nom_CentroCosto { get; set; }
        public string nom_empresa { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Plancta_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public string pc_Cuenta2 { get; set; }
        public string IdCtaCblePadre { get; set; }
        public decimal IdCatalogo { get; set; }
        public string pc_Naturaleza { get; set; }
        public int IdNivelCta { get; set; }
        public string IdGrupoCble { get; set; }
        public string Nom_GrupoCble { get; set; }
        public string gc_estado_financiero { get; set; }


        public string pc_Estado { get; set; }
        public string pc_EsMovimiento { get; set; }
        public string pc_es_flujo_efectivo { get; set; }
        public string pc_clave_corta { get; set; }
        public int OrderGrupoCble { get; set; }


        public string IdTipoCtaCble { get; set; }

        public string SEstado { get; set; }
        
        
        public ct_Plancta_nivel_Info _Plancta_nivel_Info { get; set; }
        public Boolean Check { get; set; }
        public string CuentaPadre { get; set; }


        public string em_nombre { get; set; }


        public DateTime ? Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime ? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime ? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }


        public string IdGrupo_Mayor { get; set; }
        public string nom_grupo_mayor { get; set; }
        public int orden { get; set; }
        public Nullable<int> IdTipo_Gasto { get; set; }
        
        //Propiedades para asiento de cierre
        public double Saldo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int? IdPunto_cargo { get; set; }
        public int? IdPunto_cargo_grupo { get; set; }

        public ct_Plancta_Info() { }
    }
}

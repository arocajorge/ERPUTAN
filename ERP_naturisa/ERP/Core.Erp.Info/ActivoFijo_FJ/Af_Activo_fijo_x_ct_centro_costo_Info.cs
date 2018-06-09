using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo_FJ
{
    public class Af_Activo_fijo_x_ct_centro_costo_Info
    {
        public int IdEmpresa_AF { get; set; }
        public int IdActivoFijo_AF { get; set; }
        public int IdEmpresa_cc { get; set; }
        public string IdCentroCosto_cc { get; set; }
        public bool Estado { get; set; }

        public bool Asignado { get; set; }

        //Campos vista
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_punto_cargo { get; set; }
        public Nullable<bool> Estado_Ubicación { get; set; }
        public Nullable<int> IdEmpresa_cli { get; set; }
        public Nullable<decimal> IdCliente_cli { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<int> IdEmpresa_PC { get; set; }
        public Nullable<int> IdPunto_cargo_PC { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_UnidadFact { get; set; }
    }
}

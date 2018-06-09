using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_CambioUbicacion_Activo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCambioUbicacion { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<int> IdSucursal_Actu { get; set; }
        public Nullable<int> IdDepartamento_Actu { get; set; }
        public string IdTipoCatalogo_Ubicacion_Actu { get; set; }
        public string IdCentroCosto_Actu { get; set; }
        public Nullable<int> IdSucursal_Ant { get; set; }
        public Nullable<int> IdDepartamento_Ant { get; set; }
        public string IdTipoCatalogo_Ubicacion_Ant { get; set; }
        public string IdCentroCosto_Ant { get; set; }
        public DateTime FechaCambio { get; set; }
        public string MotivoCambio { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<decimal> IdEncargado_Ant { get; set; }
        public Nullable<decimal> IdEncargado_Actu { get; set; }
        public string IdCentroCosto_sub_centro_costo_Actu { get; set; }
        public string IdCentroCosto_sub_centro_costo_Ant { get; set; }

        public string nom_Centro_costo_cliente_Actu { get; set; }
        public string nom_Encargado_Ant { get; set; }
        public string nom_Encargado_Actu { get; set; }
        

        public Af_CambioUbicacion_Activo_Info()
        {

        }
    }
}

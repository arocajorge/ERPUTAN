using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAf_CambioUbicacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCambioUbicacion { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public int? IdSucursal_Actu { get; set; }
        public int? IdSucursal_Ant { get; set; }       
        public string IdTipoCatalogo_Ubicacion_Actu { get; set; }
        public string nom_ubicacion_act { get; set; }
        public string IdTipoCatalogo_Ubicacion_Ant { get; set; }
        public string nom_ubicacion_dest { get; set; }
        public DateTime FechaCambio { get; set; }
        public string MotivoCambio { get; set; }

        public int? IdDepartamento_Actu { get; set; }
        public string nom_departamento_Act { get; set; }
        public int? IdDepartamento_Ant { get; set; }
        public string nom_departamento_Ant { get; set; }
        public string IdCentroCosto_Actu { get; set; }
        public string nom_CentroCosto_Actu { get; set; }
        public string IdCentroCosto_Ant { get; set; }
        public string nom_CentroCosto_Ant { get; set; }

        public Nullable<decimal> IdCliente_Ant { get; set; }

        public string nom_Cliente_Ant { get; set; }
        public Nullable<decimal> IdCliente_Actu { get; set; }
        public Nullable<decimal> IdEncargado_Ant { get; set; }
        public Nullable<decimal> IdEncargado_Actu { get; set; }
        public string nom_Cliente_Actu { get; set; }
        public string nom_Encargado_Actu { get; set; }
        public string nom_Encargado_Ant { get; set; }
        public string IdCentroCosto_sub_centro_costo_Actu { get; set; }
        public string IdCentroCosto_sub_centro_costo_Ant { get; set; }
        public string nom_Centro_costo_sub_centro_costo_Actu { get; set; }
        public string nom_Centro_costo_sub_centro_costo_Ant { get; set; }
        public vwAf_CambioUbicacion_Info()
        {

        }
    }
}

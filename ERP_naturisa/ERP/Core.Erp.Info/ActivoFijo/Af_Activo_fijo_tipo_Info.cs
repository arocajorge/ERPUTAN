using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Activo_fijo_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijoTipo { get; set; }
        public string IdCtaCble_Activo { get; set; }
        public string IdCtaCble_Gastos_Depre { get; set; }
        public string IdCtaCble_Dep_Acum { get; set; }
        public string IdCentroCosto_Activo { get; set; }
        public string IdCentroCosto_Dep_Acum { get; set; }
        public string IdCentroCosto_Gasto_Depre { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Descripcion { get; set; }
        public string Af_Descripcion2 { get; set; }
        public Nullable<bool> Se_Deprecia { get; set; }

        public double Af_Porcentaje_depre { get; set; }
        public int Af_anio_depreciacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public String Estado { get; set; }
        public string MotiAnula { get; set; }


        


        
        public Af_Activo_fijo_tipo_Info() { }
    }
}

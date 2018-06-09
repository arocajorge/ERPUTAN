using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajoDetalle_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string CodObra { get; set; }
        public decimal IdGrupotrabajo { get; set; }
        public int Secuencia { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Observacion { get; set; }

     
         // campos nuevos para movimiento puente grua
        public int IdEtapa { get; set; }
        public int IdProcesoProductivo { get; set; }
        public string Pe_NombreCompeto { get; set; }
        public string Observacion_operador { get; set; }
        public string Descripcion { get; set; }

        public prd_SubGrupoTrabajoDetalle_Info(){}
    }
}

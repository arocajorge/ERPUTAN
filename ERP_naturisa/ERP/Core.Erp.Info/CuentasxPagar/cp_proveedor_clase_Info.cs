using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_clase_Info
    {
        public int IdEmpresa { get; set; }
        public int IdClaseProveedor { get; set; }
        public string cod_clase_proveedor { get; set; }

        public string descripcion_clas_prove { get; set; }
        public string descripcion_clas_prove2 { get; set; }

        public string IdCtaCble_Anticipo { get; set; }
        public string IdCtaCble_gasto { get; set; }


        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }

        public string IdCtaCble_CXP { get; set; }

        
        public cp_proveedor_clase_Info()
        {

        }


    }
}

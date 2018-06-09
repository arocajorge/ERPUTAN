using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras_Edehsa
{
    public class com_ListadoElementos_x_OT_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdListadoElementos_x_OT { get; set; }

        public int IdSucursal { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string CodObra { get; set; }
        public DateTime FechaReg { get; set; }
        public string Estado { get; set; }
        public string su_descripcion { get; set; }
        public string ot_descripcion { get; set; }
        public string ob_descripcion { get; set; }
        public string Usuario { get; set; }
        public string Motivo { get; set; }
        public string lm_Observacion { get; set; }

        public com_ListadoElementos_x_OT_Info() { }
    }
}

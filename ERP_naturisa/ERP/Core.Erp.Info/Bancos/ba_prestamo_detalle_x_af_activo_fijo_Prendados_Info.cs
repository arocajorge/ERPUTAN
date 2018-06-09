using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
 public   class ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPrestamo { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<double> Garantia_Bancaria { get; set; }
        public double valor_cancelado { get; set; }
        public double valor_pendiente { get; set; }
        public double Af_costo_compra { get; set; }
        public double porcentaje_prestamo_x_activo { get; set; }
     


    }
}

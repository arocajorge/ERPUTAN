using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{    //VERSION:13052013
    public class imp_ordencompra_ext_det_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double di_cantidad { get; set; }
        public double di_costo { get; set; }
        public double di_pordesc { get; set; }
        public double di_desc { get; set; }
        public double di_subtotal { get; set; }
        public double di_costoPromedio { get; set; }
        public double di_cambio { get; set; }
        public double di_prec_cam { get; set; }
        public string  descripcion { get; set; }
        public string IdCategoria { get; set; }



        public imp_ordencompra_ext_det_Info() { }
    }
}

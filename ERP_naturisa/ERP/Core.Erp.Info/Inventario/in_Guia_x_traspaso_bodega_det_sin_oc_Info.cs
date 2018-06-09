using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
  public  class in_Guia_x_traspaso_bodega_det_sin_oc_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public int secuencia { get; set; }
        public string Num_Fact { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string nom_producto { get; set; }
        public double Cantidad_enviar { get; set; }
        public string observacion { get; set; }

        
     
      public  in_Guia_x_traspaso_bodega_det_sin_oc_Info(){}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
  public   class in_Guia_x_traspaso_bodega_det_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_OC { get; set; }
        public int IdSucursal_OC { get; set; }
        public decimal IdOrdenCompra_OC { get; set; }
        public int Secuencia_OC { get; set; }
        public string observacion { get; set; }
        public double Cantidad_enviar { get; set; }
        public double Cantidad_OC { get; set; }
        public double Cantidad_Saldo { get; set; }
        public double Cantidad_Saldo_Auxi { get; set; }
        
      //nuevo campo para naturisa
        public string Referencia { get; set; }



        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }

        public decimal IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string pr_nombre { get; set; }

        public string observacion_det_gui { get; set; }
        public Boolean Check_OG { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public double do_precioCompra { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string pr_codigo { get; set; }

      public string cod_producto { get; set; }
      public string nom_producto { get; set; }
      public string obs_OCompra { get; set; }
      public string MyProperty { get; set; }
      public decimal IdOrdenCompra { get; set; }





      public in_Guia_x_traspaso_bodega_det_Info(){}
    }
}

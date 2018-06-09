using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public  class com_dev_compra_det_Info
    {
       public com_dev_compra_det_Info()
       {

       }

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dv_Cantidad { get; set; }

        public double saldo_x_devolver { get; set; }
        public double cant_devuelta { get; set; }
        public double cant_pedida_x_OC { get; set; }




        public double dv_precioCompra { get; set; }
        public double dv_CostoCompra { get; set; }
        public double dv_porc_des { get; set; }
        public double dv_descuento { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_iva { get; set; }
        public double dv_total { get; set; }
       
        public bool dv_ManejaIva { get; set; }
       
       public string dv_Costeado { get; set; }
        public double dv_peso { get; set; }
        public string dv_observacion { get; set; }

        public int ? ocdet_IdEmpresa { get; set; }
        public int ? ocdet_IdSucursal { get; set; }
        public decimal ? ocdet_IdOrdenCompra { get; set; }
        public int ? ocdet_Secuencia { get; set; }

        public string nom_producto { get; set; }
        public string cod_producto { get; set; }
        public string Esta_en_base { get; set; }

    }
}

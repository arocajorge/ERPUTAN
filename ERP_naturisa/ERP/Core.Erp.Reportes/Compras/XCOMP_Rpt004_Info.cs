using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Compras
{
   public  class XCOMP_Rpt004_Info
    {

       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public decimal IdOrdenCompra { get; set; }
       public DateTime oc_fecha { get; set; }
       public decimal IdProveedor { get; set; }
       public string nom_proveedor { get; set; }
       public string documento { get; set; }
       public string oc_observacion { get; set; }
       public decimal IdComprador { get; set; }
       public string nom_comprador { get; set; }
       public int IdMotivo { get; set; }
       public string Nom_motivo_oc { get; set; }
       public decimal IdProducto { get; set; }
       public string nom_producto { get; set; }
       public double do_Cantidad { get; set; }
       public double precio { get; set; }
       public double do_subtotal { get; set; }
       public int MyProperty { get; set; }
       public double do_iva { get; set; }
       public double do_total { get; set; }
       public int ? IdPunto_cargo { get; set; }
       public string nom_punto_cargo { get; set; }
       public string IdCentroCosto { get; set; }
       public string Centro_costo { get; set; }
       public string IdCentroCosto_sub_centro_costo { get; set; }
       public string sub_centro_costo { get; set; }


       public XCOMP_Rpt004_Info()
       {
       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
  public  class in_Ingreso_varios_det_Info
    {
      public int IdEmpresa { get; set; }
      public int IdSucursal { get; set; }
      public int IdBodega { get; set; }
      public int IdMovi_inven_tipo { get; set; }
      public decimal IdNumMovi { get; set; }
      public int Secuencia { get; set; }
      public decimal IdProducto { get; set; }
      public double dm_cantidad { get; set; }
      public double dm_stock_ante { get; set; }
      public double dm_stock_actu { get; set; }
      public string dm_observacion { get; set; }
      public double dm_precio { get; set; }
      public double mv_costo { get; set; }
      public double dm_peso { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }

      public string IdEstadoAproba { get; set; }
      public string IdUnidadMedida { get; set; }


      // campos in_Producto

      public string pr_codigo { get; set; }
      public string pr_descripcion { get; set; }


       public  in_Ingreso_varios_det_Info(){}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Cidersus
{
  public  class com_GenerOCompra_Det
    {
       public int IdEmpresa { get; set; }
       public decimal IdTransaccion { get; set; }
       public int IdDetTrans { get; set; }
       public decimal ?IdProveedor { get; set; }
       public string CodObra { get; set; }
       public decimal IdOrdenTaller { get; set; }
       public string Motivo { get; set; }
       public decimal IdProducto { get; set; }
       public double Cantidad { get; set; }
       public double Kg { get; set; }
       public string IdEstadoAprob { get; set; }
       public DateTime FechaRequer { get; set; }
       public decimal IdListadoMateriales { get; set; }
       public int IdDetalle { get; set; }
       public double precio { get; set; }
       public int oc_IdEmpresa { get; set; }
       public decimal ?oc_IdOrdenCompra { get; set; }
       public string usuariosolicitante { get; set; }




    }
}

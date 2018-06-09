using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
   public  class com_dev_compra_Info
    {
       public com_dev_compra_Info()
       {
           lista_detalle = new List<com_dev_compra_det_Info>();
       }


    public int IdEmpresa { get; set; }
    public int IdSucursal { get; set; }
    public int IdBodega { get; set; }
    public decimal IdDevCompra { get; set; }
    public decimal IdProveedor { get; set; }
    public string Tipo { get; set; }
    public DateTime dv_fecha { get; set; }
    public double dv_flete { get; set; }
    public string dv_observacion { get; set; }
    public string Estado { get; set; }
    public DateTime ? Fecha_Transac { get; set; }	
    public DateTime ? Fecha_UltMod { get; set; }	
    public string IdUsuarioUltMod { get; set; }
    public DateTime ? FechaHoraAnul	 { get; set; }
    public string IdUsuarioUltAnu { get; set; }
    public string AfectaCosto { get; set; }
    public string MotivoAnulacion { get; set; }

    public string nom_sucursal { get; set; }
    public string nom_bodega { get; set; }
    public string nom_Proveedor { get; set; }
    public string cod_proveedor { get; set; }



    public List<com_dev_compra_det_Info>  lista_detalle { get; set; }



       

    }
}

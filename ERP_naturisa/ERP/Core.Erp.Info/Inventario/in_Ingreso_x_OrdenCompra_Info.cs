using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_Ingreso_x_OrdenCompra_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdIngreso_x_oc { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string codigo { get; set; }
        public string Referencia { get; set; }
        public DateTime Fecha_ing_bod { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdMotivo { get; set; }
        public string Observacion { get; set; }
        public string Tipo_local_ext { get; set; }
        public int? IdEmpresa_mIinv { get; set; }
        public int? IdSucursal_mInv { get; set; }
        public int? IdBodega_mInv { get; set; }
        public int? IdMovi_inven_tipo_mInv { get; set; }
        public decimal? IdNumMovi_mInv { get; set; }

        public string Estado { get; set; }


        //campos de la vista vwin_Ingreso_x_OrdenCompra
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_proveedor { get; set; }
        public string nom_motivo { get; set; }
        public string tm_descripcion { get; set; }

        public List<in_Ingreso_x_OrdenCompra_det_Info> listIngxOrdComDet { get; set; }

         public  in_Ingreso_x_OrdenCompra_Info()
         {
             listIngxOrdComDet = new List<in_Ingreso_x_OrdenCompra_det_Info>();
         
         }
    }
}

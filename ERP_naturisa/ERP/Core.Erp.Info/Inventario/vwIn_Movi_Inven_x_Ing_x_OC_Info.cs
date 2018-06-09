using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public  class vwIn_Movi_Inven_x_Ing_x_OC_Info
    {
        public int IdEmpresa { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Tipo_Movi_Inven { get; set; }
        public decimal IdNumMovi { get; set; }
        public string    cm_observacion { get; set; }       
        public DateTime cm_fecha { get; set; }
        public string Sucursal_OC { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }	
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string Estado { get; set; }



       public vwIn_Movi_Inven_x_Ing_x_OC_Info()
       {

       }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.Compras
{
   public class XCOMP_NATU_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdEmpresa_ing { get; set; }
        public Nullable<int> IdSucursal_ing { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing { get; set; }
        public Nullable<decimal> IdNumMovi_ing { get; set; }
        public Nullable<int> Secuencia_ing { get; set; }
        public decimal IdProducto { get; set; }
        public double cant_oc { get; set; }
        public Nullable<double> cant_ing { get; set; }
        public Nullable<double> cant { get; set; }
        public double do_precioFinal { get; set; }
        public Nullable<double> total { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string co_factura { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string Estado { get; set; }
        public decimal IdProveedor { get; set; }
        public string cod_proveedor { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<System.DateTime> fecha_ing { get; set; }
        public string Su_Descripcion { get; set; }
        public XCOMP_NATU_Rpt003_Info(){}
    }
}

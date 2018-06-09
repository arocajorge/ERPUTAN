using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info
    {
        public bool Checked { get; set; }
        //public int IdEmpresa{ get; set; } 
        //public int IdSucursal{ get; set;} 
        //public int IdBodega{ get; set;} 
        //public decimal IdProducto{ get; set;} 
        //public string  CodigoBarra{ get; set;} 
		//public double? dm_cantidad{ get; set;}
        public string CodigoProducto { get; set; } 
       

        //public decimal IdNumMovi { get; set; }
        //public int mv_Secuencia { get; set; }
        //public int Secuencia { get; set; }
        public double Saldo { get; set; }
        //public string ot_CodObra { get; set; }
        //public decimal ot_IdOrdenTaller { get; set; }
        //public string pr_descripcion { get; set; }
        //public string observacion { get; set; }

        //public double dm_precio { get; set; }
        //public double mv_costo { get; set; }


        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoBarra { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public double longitud { get; set; }
        public double espesor { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public double ceja { get; set; }
        public double diametro { get; set; }
        public string descripcion_corta { get; set; }
        public int densidad { get; set; }
        public int Secuencia { get; set; }
        public int mv_Secuencia { get; set; }
        public string dm_observacion { get; set; }
        public decimal IdNumMovi { get; set; }
        public string ot_CodObra { get; set; }
        public Nullable<decimal> ot_IdOrdenTaller { get; set; }
        public double pr_peso { get; set; }
        public Nullable<double> PesoEspecifico { get; set; }

        public Nullable<decimal> ocd_IdOrdenCompra { get; set; }
        public string NumDocumentoRelacionadoProveedor { get; set; }
        public string NumFacturaProveedor { get; set; }

        public vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info() { }

    }
}

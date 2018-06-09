using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Compras
{
   public class com_solicitud_compra_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal? IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public string do_observacion { get; set; }
        public string NomProducto { get; set; }
        public decimal pr_stock { get; set; }
        public string pr_descripcion { get; set; }
        public Boolean Checked { get; set; }

        public string DetallexItems { get; set; }



        //otros campos consulta
              
        public double Peso { get; set; }    
        public double Precio { get; set; }
        public double Porc_Descuento { get; set; }
        public double Descuento { get; set; }
        public double PrecioFinal { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public Boolean Paga_Iva { get; set; }
        

        public string IdCentroCosto { get; set; }
        public string NomCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string Nomsub_centro_costo { get; set; }


        public string nom_punto_cargo { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto_princ { get; set; }

        public int? IdPunto_cargo_grupo { get; set; }
        public int ? IdPunto_cargo { get; set; }

        public string IdUnidadMedida { get; set; }

        public DateTime fecha { get; set; }

        public string nom_Unidad { get; set; }
        public string nom_Sucursal { get; set; }
    



        public string IdEstadoAprobacion { get; set; }
        public string IdEstadoAprobacion_AUX { get; set; }

        public Bitmap Ico1 { get; set; }

        public com_solicitud_compra_det_Info(){}
    }
}

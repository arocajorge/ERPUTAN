using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.Facturacion
{
    public class Tabla_pedido_det_Info
    { 
        public decimal IdProducto { get; set; }
        public string Codigo_Producto { get; set; }
        public string Producto { get; set; }
        public double Peso { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Porc_Descuento { get; set; }
        public double Descuento { get; set; }
        public double PrecioFinal { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public Boolean Paga_Iva { get; set; }
        public string DetallexItems { get; set; }
        public double Costo { get; set; }
        public double Stock { get; set; }
        public double Cant_Venta { get; set; }
        public double Cant_Dev { get; set; }
        public Boolean chek { get; set; }

        public string Esta_en_base { get; set; }
        public string Tiene_Movi_Inven { get; set; }
        public string Tiene_despacho { get; set; }

        public string IdUnidadMedida { get; set; }

        public Bitmap Ico1 { get; set; }

        //actualizacion prog Kati Franco
        public int Secuencia { get; set; }
        //

        // consulta otros campos
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public string pr_ManejaIva { get; set; }

        public string Nomsub_centro_costo { get; set; }
     

        public List<fa_factura_det_otros_campos_Info> DetOtrosCampos { get; set; }

        public int IdPunto_cargo { get; set; }
        public double Precio_Iva { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }

        public string Descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public string IdTipoConsumo { get; set; }

        public Tabla_pedido_det_Info() 
        {
            DetOtrosCampos = new List<fa_factura_det_otros_campos_Info>();
        }
    }
}

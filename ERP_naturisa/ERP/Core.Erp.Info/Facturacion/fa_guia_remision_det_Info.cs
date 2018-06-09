using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_guia_remision_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double gi_cantidad { get; set; }
        public double gi_cantidadAux { get; set; }
        public double gi_Precio { get; set; }
        public double gi_PorDescUnitario { get; set; }
        public double gi_DescUnitario { get; set; }
        public double gi_PrecioFinal { get; set; }
        public double Subtotal { get; set; }
        public double gi_iva { get; set; }
        public double gi_total { get; set; }
        public double gi_costo { get; set; }
        public string gi_tieneIVA { get; set; }
        public string gi_detallexItems { get; set; }
        public decimal od_IdOrdenDespacho { get; set; }
        public double? gi_peso { get; set; }
        public bool TieneIva { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_descripcion_2 { get; set; }
        public fa_guia_remision_det_Info() { }
    }
}

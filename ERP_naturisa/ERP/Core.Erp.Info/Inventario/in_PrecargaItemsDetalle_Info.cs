using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_PrecargaItemsDetalle_Info :in_PrecargaItems_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdPrecarga { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dpr_Cantidad { get; set; }
        public double dpr_costo { get; set; }
        public double dpr_porc_des { get; set; }
        public double dpr_descuento { get; set; }
        public double dpr_subtotal { get; set; }
        public double dpr_iva { get; set; }
        public double dpr_total { get; set; }
        public string dpr_ManejaIva { get; set; }
        public string dpr_Costeado { get; set; }
        public double dpr_costo_promedio_hist { get; set; }
        public double dpr_peso { get; set; }
        public string dpr_observacion { get; set; }
        public string EstadoProcesado { get; set; }
        public bool EstadoProcesadoBool { get; set; }

        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }

        public in_PrecargaItemsDetalle_Info() { }
    }
}

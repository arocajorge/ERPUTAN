using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string CodigoOC { get; set; }
        public int Secuencia { get; set; }
        public string pr_descripcion { get; set; }
        public DateTime oc_fecha { get; set; }
        public DateTime cm_fecha { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public string NomUnidadMedida { get; set; }
        public double Costo_uni { get; set; }
        public double Descuento { get; set; }
        public double SubTotal { get; set; }
        public double valor_Iva { get; set; }
        public double Total { get; set; }
        public string SucursalIngreso { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public string co_factura { get; set; }
        public double re_valor_retencion { get; set; }
        public double ValorAPagar { get; set; }
        public decimal IdNumMovi_Ing_Egr_Inv { get; set; }
    }
}

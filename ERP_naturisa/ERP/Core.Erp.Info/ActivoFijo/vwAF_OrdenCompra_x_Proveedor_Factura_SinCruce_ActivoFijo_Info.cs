using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public double dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public double dm_precio { get; set; }
        public string dm_observacion { get; set; }
        public DateTime Fecha_Ing_Bod { get; set; }
        public string nom_bodega { get; set; }
        public int IdEmpresa_oc { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia_oc { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public decimal IdAprobacion { get; set; }
        public string numDocumento { get; set; }
        public DateTime Fecha_Factura { get; set; }

        public double Cantidad { get; set; }
        public double Costo_uni { get; set; }
        public double SubTotal { get; set; }
        public double PorIva { get; set; }
        public double valor_Iva { get; set; }
        public double Total { get; set; }

        public int IdEmpresa_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string IdCtaCble_IVA { get; set; }
        public double Saldo_Factu { get; set; }



        public vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info()
        {

        }

    }
}

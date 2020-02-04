using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdProducto { get; set; }
        public string em_nombre { get; set; }
        public string pr_nombre { get; set; }
        public int oc_plazo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string pr_codigo { get; set; }
        public double do_Cantidad { get; set; }
        public string IdUnidadMedida { get; set; }
        public string pr_descripcion { get; set; }
        public double do_precioCompra { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public double do_descuento { get; set; }
        public double do_porc_des { get; set; }
        public int Secuencia { get; set; }

        public string oc_NumDocumento { get; set; }

        public bool pr_contribuyenteEspecial { get; set; }
        public string proveedor_es_contribuyente_especial { get; set; }
        public string proveedor_no_es_contribuyente_especial { get; set; }

        public string Usuario_Aprueba { get; set; }
        public string Usuario_Solicitante { get; set; }

        public string TerminoPago { get; set; }
        public int DiasTerminoPago { get; set; }
        public string escontado { get; set; }
        public string escredito { get; set; }

        public string UnidadMedidaConsumo { get; set; }
    }
}

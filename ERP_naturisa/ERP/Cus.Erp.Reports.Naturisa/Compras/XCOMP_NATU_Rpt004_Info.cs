using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Compras
{
  public class XCOMP_NATU_Rpt004_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string Tipo { get; set; }
        public string IdTerminoPago { get; set; }
        public int Plazo { get; set; }
        public DateTime Fecha_oc { get; set; }
        public string Observacion_oc { get; set; }
        public string Estado { get; set; }
        public string EstadoRecepcion { get; set; }
        
      //public double Total { get; set; }

        public string nom_proveedor { get; set; }      
        public string nom_sucursal { get; set; }
        public string Termino_pago { get; set; }
        
       public DateTime FechaDesde_Fil { get; set; }
       public DateTime FechaHasta_Fil { get; set; }
       public double total { get; set; }

       public decimal IdProducto { get; set; }
       public double Cantidad { get; set; }
       public double Precio { get; set; }
       public double Subtotal { get; set; }
       public double Iva { get; set; }
       public string nom_producto { get; set; }
       public string do_observacion { get; set; }

       public string fecha { get; set; }
                                                                 
       public  XCOMP_NATU_Rpt004_Info(){}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
  public  class XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Detalle { get; set; }

        public string IdCod_Impuesto_Iva { get; set; }
        public double  sc_subtotal { get; set; }
        public double  sc_iva { get; set; }
        public double sc_total { get; set; }
        public XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info()
        {

        }

    }
}

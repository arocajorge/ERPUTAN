using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_Grafinpren
{
    public class fa_factura_graf_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string num_op { get; set; }
        public DateTime fecha_op { get; set; }
        public string num_cotizacion { get; set; }
        public DateTime fecha_cotizacion { get; set; }
        public double porc_comision { get; set; }
        public int IdEquipo { get; set; }

        //campos adicionales
        public string pe_direccion { get; set; }
        public string Observacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
   public class fa_factura_x_fa_TerminoPago_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string IdTerminoPago { get; set; }
        public int Secuencia { get; set; }
        public DateTime Fecha{ get; set; }
        public DateTime Fecha_vct { get; set; }
        public int Dias_Plazo { get; set; }
        public double Por_Distribucion { get; set; }
        public double Valor { get; set; }



    }
}

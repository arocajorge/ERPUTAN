using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
   public class fa_pedido_x_formaPago_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public decimal IdPedido { get; set; }
       public string IdTipoFormaPago { get; set; }
       public int Secuencia { get; set; }
       public DateTime Fecha { get; set; }
       public DateTime Fecha_vtc { get; set; }
       public int Dias_Plazo { get; set; }

       public double Por_Distribucion { get; set; }
       public double Valor { get; set; }
       


        public fa_pedido_x_formaPago_Info(){}
    }
}

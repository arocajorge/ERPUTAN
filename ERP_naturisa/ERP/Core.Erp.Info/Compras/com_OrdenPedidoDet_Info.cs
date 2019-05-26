using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_OrdenPedidoDet_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdSucursalDestino { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public double opd_Cantidad { get; set; }
        public double opd_CantidadApro { get; set; }
        public string opd_EstadoProceso { get; set; }
        public string opd_Detalle { get; set; }
    }
}

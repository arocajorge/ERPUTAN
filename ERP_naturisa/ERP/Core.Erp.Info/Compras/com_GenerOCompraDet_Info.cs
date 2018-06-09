using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_GenerOCompraDet_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTransaccion { get; set; }
        public int IdDetTrans { get; set; }
        public decimal IdProveedor { get; set; }
        public string CodObra { get; set; }
        public int IdOrdenTaller { get; set; }
        public string Motivo { get; set; }
        public int IdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Kg { get; set; }
        public string IdEstadoAprob { get; set; }
        public com_GenerOCompraDet_Info() { }

    }
}

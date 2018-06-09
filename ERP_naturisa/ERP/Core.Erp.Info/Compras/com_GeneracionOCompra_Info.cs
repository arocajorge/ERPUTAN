using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_GeneracionOCompra_Info
    {
        public bool check { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public int IdSucursal { get; set; }
        public DateTime FechaReg { get; set; }
        public string Usuario { get; set; }
        public string g_ocObservacion { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioAnula { get; set; }
        public DateTime FechaAnula { get; set; }
        public string MotivoAnulacion { get; set; }

        public  com_GeneracionOCompra_Info(){}

    }
}

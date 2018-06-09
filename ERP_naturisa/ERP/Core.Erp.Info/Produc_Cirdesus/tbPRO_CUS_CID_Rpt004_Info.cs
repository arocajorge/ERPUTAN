using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public double? valorunitario { get; set; }
        public double? valortotal { get; set; }
        public double? ivaxreg { get; set; }
        public DateTime oc_fecha { get; set; }
        public string fecha { get; set; }
        public string pr_nombre { get; set; }
        public string Solicitante { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public double? pesoxreg { get; set; }
        public double? pr_peso { get; set; }
        public decimal IdProducto { get; set; }
        public int? Secuencia { get; set; }
        public double? cantidad { get; set; }

        public double subtotal { get; set; }
        public double totaiva { get; set; }
        public double  total { get; set; }

        public tbPRO_CUS_CID_Rpt004_Info()
        {

        }
    }
}

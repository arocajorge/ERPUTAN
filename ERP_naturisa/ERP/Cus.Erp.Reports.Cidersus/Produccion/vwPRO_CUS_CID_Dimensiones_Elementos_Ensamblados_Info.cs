using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public decimal IdEnsamblado { get; set; }
        public string orden_taller { get; set; }
        public string cb_producto_final { get; set; }
        public string cb_producto_elemento { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public Nullable<double> Alto { get; set; }
        public Nullable<double> ancho { get; set; }
        public Nullable<double> diametro { get; set; }
        public Nullable<double> ceja { get; set; }
        public Nullable<double> espesor { get; set; }
        public Nullable<double> Largo { get; set; }

        public string NumDocumentoRelacionadoProveedor { get; set; }
        public string NumFacturaProveedor { get; set; }

        public double pesoSubpieza { get; set; }
        public double pesoProductoFinal { get; set; }



    }
}

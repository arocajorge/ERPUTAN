using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class XPRO_CUS_CID_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string CodObra { get; set; }
        public decimal IdEnsamblado { get; set; }
        public string orden_taller { get; set; }
        public string producto_final { get; set; }
        public string cb_producto_final { get; set; }
        public int IdEtapaInicio { get; set; }
        public string cb_producto_elemento { get; set; }
        public string proveedor { get; set; }
        public string subgrupo { get; set; }
        public Nullable<System.DateTime> fecha_movi_fin { get; set; }
        public Nullable<System.DateTime> fecha_movi_inicio { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public Nullable<double> Alto { get; set; }
        public Nullable<double> ancho { get; set; }
        public double diametro { get; set; }
        public double ceja { get; set; }
        public double espesor { get; set; }
        public Nullable<double> Largo { get; set; }
        public string lider { get; set; }
        public string Chofer { get; set; }
        public string Placa { get; set; }
        public string TipoTransporte { get; set; }
        public System.DateTime fecha_despacho { get; set; }

        public string NumDocumentoRelacionadoProveedor { get; set; }
        public string NumFacturaProveedor { get; set; }

        public double pesoSubpieza { get; set; }
        public double pesoProductoFinal { get; set; }

    }
}

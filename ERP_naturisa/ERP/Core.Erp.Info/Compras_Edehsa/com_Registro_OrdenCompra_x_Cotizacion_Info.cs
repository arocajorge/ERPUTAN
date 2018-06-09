using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras_Edehsa
{
    public class com_Registro_OrdenCompra_x_Cotizacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdCotizacion { get; set; }
        public bool estado { get; set; }
        public decimal SecuenciaDetalleCotizacion { get; set; }
        public decimal IdListadoMateriales { get; set; }

        public com_Registro_OrdenCompra_x_Cotizacion_Info() { }
    }
}
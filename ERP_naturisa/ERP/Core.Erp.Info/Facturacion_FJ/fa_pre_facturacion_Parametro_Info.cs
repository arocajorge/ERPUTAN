using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_Parametro_Info
    {
        public int IdEmpresa { get; set; }
        public Boolean Se_Cobra_Iva { get; set; }
        public string Tipo_Cobro_Poliza_X { get; set; }
        public int IdSucursal_para_facturar { get; set; }
        public int IdBodega_para_facturar { get; set; }
        public bool Liquidar_x_grupo { get; set; }
        public Nullable<decimal> Margen_Ganancia_por_MO { get; set; }
        public Nullable<decimal> Margen_Ganancia_por_BS { get; set; }
        public List< fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lis_param_x_fuerza { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Observacion { get; set; }
        public string IdEstado_Proceso { get; set; }
        public System.DateTime fecha { get; set; }
        public string estado { get; set; }

        public int pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string nom_EstadoProceso { get; set; }

        public List<fa_pre_facturacion_det_Activo_fijo_Info> lst_det_Activo_fijo{ get; set; }
        public List<fa_pre_facturacion_det_egr_x_bod_Info> lst_det_egr_x_bod{ get; set; }
        public List<fa_pre_facturacion_det_cobro_x_Poliza_Info> lst_det_poliza { get; set; }
        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> lst_det_fact { get; set; }
        public List<fa_pre_facturacion_det_cobro_x_Movilizacion_Info> lst_det_Movi { get; set; }
        public List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> lst_det_Depreciacion { get; set; }
        public List<fa_pre_facturacion_det_cobro_x_Unidades_Consumidas_Info> lst_det_Unidades { get; set; }
        public List<fa_pre_facturacion_det_Otros_Info> lst_det_Otros { get; set; }
        public List<fa_pre_facturacion_det_gasto_Interes_Banc_Info> list_Intereses { get; set; }
        
    }
}

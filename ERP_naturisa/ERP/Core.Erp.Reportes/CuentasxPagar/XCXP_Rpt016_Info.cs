using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt016_Info
    {
    
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public string num_factura { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public string co_observacion { get; set; }
        public int IdSucursal { get; set; }
        public DateTime co_fechaOg { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public string nom_tipo_Documento { get; set; }
        public string nom_proveedor { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string IdTipo_op { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public decimal IdTipoFlujo { get; set; }
        public string nom_flujo { get; set; }
        public decimal IdPersona { get; set; }
        public string cod_Documento { get; set; }
        public string nom_Estado_Aproba { get; set; }
        public string Su_Descripcion { get; set; }

    }
}

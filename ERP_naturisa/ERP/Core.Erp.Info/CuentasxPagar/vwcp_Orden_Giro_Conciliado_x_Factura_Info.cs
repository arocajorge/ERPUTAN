using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_Orden_Giro_Conciliado_x_Factura_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public DateTime co_fechaOg { get; set; }
        public string co_factura { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_baseImponible { get; set; }
        public double co_total { get; set; }
        public string Estado { get; set; }
        public int IdEmpresa_ret { get; set; }
        public decimal IdRetencion { get; set; }
        public string re_serie { get; set; }
        public string re_NumRetencion { get; set; }
        public string re_EstaImpresa { get; set; }
        public string TipoFlujo { get; set; }
        public Boolean Checked { get; set; }

        public int IdIden_credito { get; set; }
        public string Serie { get; set; }
        public string Serie2 { get; set; }
        public string numDocFactura { get; set; }
        public string Num_Autorizacion { get; set; }
        public string Num_Autorizacion_Imprenta { get; set; }
        public double co_OtroValor_a_descontar { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public DateTime fecha_autorizacion { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string IdCtaCble_IVA { get; set; }

        public int IdEmpresa_Apro_Ing { get; set; }
        public decimal IdAprobacion_Apro_Ing { get; set; }
        public decimal IdConciliacion { get; set; }
        public int IdEmpresaConciliacion { get; set; }
        

        public vwcp_Orden_Giro_Conciliado_x_Factura_Info()
        {

        }
    }
}

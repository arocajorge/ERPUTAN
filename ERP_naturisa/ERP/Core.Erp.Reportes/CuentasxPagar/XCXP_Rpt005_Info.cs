using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt005_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public string Observacion { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdEntidad { get; set; }
        public DateTime Fecha { get; set; }
        public string IdEstadoAprobacion{ get; set; }
        public string IdFormaPago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public int IdBanco { get; set; }
        public string Estado { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_cxp { get; set; }
        public decimal IdCbteCble_cxp { get; set; }
        public int IdTipoCbte_cxp { get; set; }
        public double Valor_a_pagar { get; set; }
        public string Referencia { get; set; }
        public string IdTipo_op { get; set; }
        public string nom_Banco { get; set; }
        public string nom_PagoTipo { get; set; }
        public string nom_FormaPago { get; set; }
        public string nom_beneficiario { get; set; }
        public string nom_EstadoAprobacion { get; set; }
        public string IdUsuario_Aprobacion { get; set; }
        public DateTime fecha_hora_Aproba { get; set; }
        public string Motivo_aproba { get; set; }
        public string num_CuentaBanco { get; set; }
        public double valor_factura	{ get; set; }
        public double saldo	 { get; set; }
        public double co_total { get; set; }
        public double Total_Retencion { get; set; }

        public string em_nombre { get; set; }

        public XCXP_Rpt005_Info()
        { 

        }
    }
}

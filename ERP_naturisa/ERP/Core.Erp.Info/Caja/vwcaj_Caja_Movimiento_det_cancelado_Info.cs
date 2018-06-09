using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Caja
{
    public class vwcaj_Caja_Movimiento_det_cancelado_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public double cr_Valor { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public Nullable<System.DateTime> cr_fechaDocu { get; set; }
        public Nullable<int> IdEmpresa_OP { get; set; }
        public Nullable<decimal> IdOrdenPago_OP { get; set; }
        public string IdTipo_op { get; set; }
        public string Referencia { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<int> Secuencia_OP { get; set; }
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public System.DateTime Fecha_OP { get; set; }
        public System.DateTime Fecha_Fa_Prov { get; set; }
        public System.DateTime Fecha_Venc_Fac_Prov { get; set; }
        public string Observacion { get; set; }
        public string Nom_Beneficiario { get; set; }
        public string Girar_Cheque_a { get; set; }
        public double Valor_a_pagar { get; set; }
        public double Valor_estimado_a_pagar_OP { get; set; }
        public double Total_cancelado_OP { get; set; }
        public double Saldo_x_Pagar_OP { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdFormaPago { get; set; }
        public Nullable<System.DateTime> Fecha_Pago { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<decimal> Cbte_cxp { get; set; }
        public string Estado { get; set; }
        public string Nom_Beneficiario_2 { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSubCentro_Costo { get; set; }

        public vwcaj_Caja_Movimiento_det_cancelado_Info()
        {

        }



    }
}

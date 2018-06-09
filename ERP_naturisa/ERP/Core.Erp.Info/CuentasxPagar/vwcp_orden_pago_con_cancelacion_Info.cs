using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_orden_pago_con_cancelacion_Info
    {

        public int IdEmpresa { get; set; }
        public string IdTipo_op { get; set; }
        public string Referencia { get; set; }
        public decimal ? IdOrdenPago { get; set; }
        public int ? Secuencia_OP { get; set; }
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public decimal ? IdEntidad { get; set; }
        public DateTime Fecha_OP { get; set; }
        public DateTime Fecha_Fa_Prov { get; set; }
        public DateTime Fecha_Venc_Fac_Prov { get; set; }
        public string Observacion { get; set; }
        public string Nom_Beneficiario	 { get; set; }
        public string Girar_Cheque_a { get; set; }
        public double Valor_a_pagar { get; set; }
        public double Valor_estimado_a_pagar_OP { get; set; }
        public double Total_cancelado_OP { get; set; }
        public double Saldo_x_Pagar_OP { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdFormaPago { get; set; }
        public DateTime? Fecha_Pago { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSubCentro_Costo { get; set; }
        public decimal? Cbte_cxp { get; set; }
        public double Valor_aplicado { get; set; }
        public Boolean Check { get; set; }
        public decimal IdAprobacion { get; set; }
        public string Estado { get; set; }
        public string Nom_Beneficiario_2 { get; set; }
        public int? IdEmpresa_cxp { get; set; }
        public int? IdTipoCbte_cxp { get; set; }
        public decimal? IdCbteCble_cxp { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public Boolean Check_aux { get; set; }
        public string IdEstadoAprobacion_AUX { get; set; }


        //JAROCA Campos para pago a proveedores
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public string tipo_cbte_pago { get; set; }
        public Nullable<decimal> Secuencial_reg_x_proceso { get; set; }
        public int Secuencia_ar { get; set; }
        

        //DEREK MEJIA 07/03/2014
        public double Saldo_x_Pagar2 { get; set; }
        public string Estado_Transferencia { get; set; }
        public string Referencia2 { get; set; }
        public vwtb_persona_beneficiario_Info Beneficiario { get; set; }
        public Nullable<int> IdBanco_acreditacion { get; set; }
        public string CodigoLegal { get; set; }
        public Nullable<int> dias_vencido { get; set; }
        public vwcp_orden_pago_con_cancelacion_Info()
        {
            Beneficiario = new vwtb_persona_beneficiario_Info();
        }
    }
}


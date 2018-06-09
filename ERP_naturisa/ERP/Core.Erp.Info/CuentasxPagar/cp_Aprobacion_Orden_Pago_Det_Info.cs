using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Det_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_OP { get; set; }
        public decimal? IdOrdenPago_OP { get; set; }
        public int? Secuencia_OP { get; set; }
        public DateTime Fecha_OP { get; set; }
        public string Nom_Beneficiario { get; set; }
        public string Referencia { get; set; }
        public DateTime? Fecha_Pago { get; set; }
        public double Saldo_x_Pagar_OP { get; set; }
        public double Valor_estimado_a_pagar_OP { get; set; }
        public string IdFormaPago { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string Observacion { get; set; }
        public Boolean check { get; set; }
        public string Motivo { get; set; }
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public decimal? IdEntidad { get; set; }
        public double TotalCancelado { get; set; }
        public string Usuario { get; set; }
        public int MyProperty { get; set; }



        public cp_Aprobacion_Orden_Pago_Det_Info()
        {
            
        }
    }
}

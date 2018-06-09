using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_Aprobacion_Ing_Bod_x_OC_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public DateTime Fecha_aprobacion { get; set; }

        public int? IdEmpresa_Ogiro { get; set; }
        public decimal? IdCbteCble_Ogiro { get; set; }
        public int? IdTipoCbte_Ogiro { get; set; }

        public string IdOrden_giro_Tipo { get; set; }
        public int IdIden_credito { get; set; }

        public decimal IdProveedor { get; set; }
        public string Observacion { get; set; }
        public string Serie { get; set; }
        public string Serie2 { get; set; }
        public string num_documento { get; set; }
        public string num_auto_Proveedor { get; set; }
        public string num_auto_Imprenta { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public DateTime Fecha_vcto { get; set; }

        public int co_plazo { get; set; }

        public DateTime? co_FechaContabilizacion { get; set; }

        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double Descuento { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }

        public string IdCtaCble_Gasto { get; set; }
        public string IdCtaCble_CXP { get; set; }
        public string pa_ctacble_iva { get; set; }

        public string IdCentroCosoto_CXP { get; set; }
        public DateTime fecha_autorizacion { get; set; }

        public string nom_proveedor { get; set; }

        //campos de auditoria anulacion
        public DateTime Fecha_Anulacion { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string Motivo_Anu { get; set; }
        public Nullable<System.DateTime> co_FechaVctoAutorizacion { get; set; }
        public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> listDetalle { get; set; }

        public cp_Aprobacion_Ing_Bod_x_OC_Info()
        {
            listDetalle = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
        }
    }
}

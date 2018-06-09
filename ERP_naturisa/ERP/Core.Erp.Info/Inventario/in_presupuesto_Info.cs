using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_presupuesto_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdPresupuesto { get; set; }
        public string Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public int pr_plazo { get; set; }
        public DateTime pr_fecha { get; set; }
        public double pr_subtotal { get; set; }
        public double pr_iva { get; set; }
        public double pr_descuento { get; set; }
        public int pr_pordesc { get; set; }
        public double pr_flete { get; set; }
        public double pr_total { get; set; }
        public double pr_Base_conIva { get; set; }
        public double pr_Base_sinIva { get; set; }
        public string pr_observacion { get; set; }
        public DateTime Fechreg { get; set; }
        public string Estado { get; set; }
        public string pr_NumDocumento { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public DateTime? co_fecha_aprobacion { get; set; }
        public int? IdTerminoPago { get; set; }
        public DateTime? co_FechaFactProv { get; set; }
        public int? co_DiasFecFacProv { get; set; }
        public DateTime? co_fecha_salida { get; set; }
        public DateTime? co_fecha_llegada { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public DateTime? co_fechaReproba { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public double? pr_PesoTotal { get; set; }
        public DateTime? pr_fecha_emision { get; set; }
        public string IdUsuarioSolicitante { get; set; }
        public string IdUsuario_Emicion { get; set; }

        public string NomSucursal { get; set; }
        public string NomProveedor { get; set; }
        public string NomTermPago { get; set; }
        public string IdCentroCosto { get; set; }
        public string CodCentroCosto { get; set; }
        public string NomCentroCosto { get; set; }
        public int IdObra { get; set; }

        public in_presupuesto_Info(){}
    }
}

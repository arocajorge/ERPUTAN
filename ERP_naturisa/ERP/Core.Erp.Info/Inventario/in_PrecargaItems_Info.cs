using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_PrecargaItems_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdPrecarga { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdOrdenTaller { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime pre_fecha { get; set; }
        public double pre_subtotal { get; set; }
        public double pre_iva { get; set; }
        public double pre_descuento { get; set; }
        public int pre_pordesc { get; set; }
        public double pre_total { get; set; }
        public double pre_Base_conIva { get; set; }
        public double pre_Base_sinIva { get; set; }
        public string pre_observacion { get; set; }
        public DateTime Fechreg { get; set; }
        public string Estado { get; set; }
        public string pre_NumDocumento { get; set; }
        public double? pre_PesoTotal { get; set; }
        public DateTime? pre_fecha_emision { get; set; }

        public string NomSucursal { get; set; }
        public string NomProveedor { get; set; }
        public string NomTermPago { get; set; }
        public string CodCentroCosto { get; set; }
        public string NomCentroCosto { get; set; }

        public string CodOrdenTaller { get; set; }
        public int NumeroOT { get; set; }

        public string Referencia { get; set; }
        public string ReferenciaOC { get; set; }

        public in_PrecargaItems_Info() { }
    }
}

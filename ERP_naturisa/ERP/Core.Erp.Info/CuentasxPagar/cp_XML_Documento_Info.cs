using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_XML_Documento_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDocumento { get; set; }
        public string Comprobante { get; set; }
        public string XML { get; set; }
        public string Tipo { get; set; }
        public string emi_RazonSocial { get; set; }
        public string emi_NombreComercial { get; set; }
        public string emi_Ruc { get; set; }
        public string emi_DireccionMatriz { get; set; }
        public string ClaveAcceso { get; set; }
        public string CodDocumento { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string rec_RazonSocial { get; set; }
        public string rec_Identificacion { get; set; }
        public Nullable<double> Subtotal0 { get; set; }
        public Nullable<double> SubtotalIVA { get; set; }
        public Nullable<double> Porcentaje { get; set; }
        public Nullable<double> ValorIVA { get; set; }
        public Nullable<double> Total { get; set; }
        public string FormaPago { get; set; }
        public Nullable<int> Plazo { get; set; }

        public int Imagen { get; set; }
    }
}

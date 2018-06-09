using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public string CodPrestamo { get; set; }
        public int IdBanco { get; set; }
        public string IdMetCalc { get; set; }
        public string IdMotivo_Prestamo { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha { get; set; }
        public double MontoSol { get; set; }
        public double TasaInteres { get; set; }
        public double TotalPrestamo { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> TotalCuota { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<double> Interes { get; set; }
        public Nullable<int> Plazo { get; set; }
        public string RazonSocial { get; set; }
        public string ba_descripcion { get; set; }
        public Nullable<double> Deuda_CortoPlazo { get; set; }
        public Nullable<double> Deuda_LargoPlazo { get; set; }

    }
}

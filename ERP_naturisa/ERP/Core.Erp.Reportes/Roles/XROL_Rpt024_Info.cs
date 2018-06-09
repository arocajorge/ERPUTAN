
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt024_Info
    {

        public string CedulaRuc { get; set; }
        public string NombreCompleto { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPrestamo { get; set; }
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public string NominaDescripcion { get; set; }
        public string EstadoPrestamo { get; set; }
        public System.DateTime Fecha { get; set; }
        public double MontoSol { get; set; }
        public double TasaInteres { get; set; }
        public double TotalPrestamo { get; set; }
        public int NumCuotas { get; set; }
        public string Observacion { get; set; }
        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double Interes { get; set; }
        public double AbonoCapital { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public string ObservacionCuota { get; set; }
        public string RubroDescripcion { get; set; }
        public string CodigoEmpleado { get; set; }
        public string tp_Descripcion { get; set; }
        public string EstadoCuota { get; set; }
        public double Canceladas { get; set; }
        public double Pendientes { get; set; }
        public Image Logo { get; set; }

        public XROL_Rpt024_Info() { }

    }
}

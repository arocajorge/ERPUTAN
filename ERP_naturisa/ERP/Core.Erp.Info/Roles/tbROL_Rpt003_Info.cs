using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
   public class tbROL_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int IdNomina_Tipo { get; set; }
        public string nomi_descripcion { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string IdRubro { get; set; }
        public string ru_descripcion { get; set; }
        public decimal IdEmpleado_Aprueba { get; set; }
        public string pe_nombre_apru { get; set; }
        public string pe_apellido_apru { get; set; }
        public string codigo { get; set; }
        public string ca_descripcion { get; set; }
        public string estado { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoSol { get; set; }
        public double TasaInteres { get; set; }
        public int NumCuotas { get; set; }
        public string cod_pago { get; set; }
        public string peri_pago { get; set; }
        public DateTime Fecha_PriPago { get; set; }
        public string Observacion { get; set; }
        public double TotalPrestado { get; set; }
        public double TotalCobrado { get; set; }
        public double SaldoPrestado { get; set; }
        public int NumCuotaDet { get; set; }
        public double SaldoInicial { get; set; }
        public double Interes { get; set; }
        public double AbonoCapital { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public string Observacion_det { get; set; }
        public string Estado_Det { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }


        public tbROL_Rpt003_Info() { }
    }
}

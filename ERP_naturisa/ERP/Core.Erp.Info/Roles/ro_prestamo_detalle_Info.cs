using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_prestamo_detalle_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double Interes { get; set; }
        public double AbonoCapital { get; set; }
        public double TotalCuota { get; set; }
        public Nullable<int> IdNominaTipoLiqui { get; set; }

        public double Saldo { get; set; }
        public DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public string Estado { get; set; }
        public string Observacion_det { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }


        //DATOS DE LA VISTA
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public string ru_codRolGen { get; set; }
        public string ru_descripcion { get; set; }
        public string EstadoPrestamo { get; set; }
        public string EstadoDetalle { get; set; }
        
        public ro_prestamo_detalle_Info() { 
        
        }
    }
}

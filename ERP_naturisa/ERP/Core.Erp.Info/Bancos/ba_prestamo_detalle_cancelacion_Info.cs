using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
     ///
     *
     * Programador : Ing Katiuska Franco T
     * Ultima Version  a unificar 0801 2014 hora 1500 
     * 
     * 
     */
namespace Core.Erp.Info.Bancos
{
    public class ba_prestamo_detalle_cancelacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int NumCuota { get; set; }
        public int Secuencia { get; set; }
        public double Monto_Canc { get; set; }
        public double Saldo { get; set; }
        public DateTime FechaPago { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }

        public ba_prestamo_detalle_cancelacion_Info()
        {

        }
    }
}

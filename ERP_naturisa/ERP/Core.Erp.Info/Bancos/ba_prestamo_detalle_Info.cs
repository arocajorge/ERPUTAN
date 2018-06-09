using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Core.Erp.Info.Contabilidad;
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
    public class ba_prestamo_detalle_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }

        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double Interes { get; set; }
        public double AbonoCapital { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public string NomEstadoPago { get; set; }
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
        public string CodPrestamo { get; set; }
        public string NomBanco { get; set; }
        public Nullable<int> Secuencia { get; set; }
        public string NomMotivo_Prestamo { get; set; }
        public string MetodoCalculo { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> Monto_Canc { get; set; }
        public Nullable<double> Monto_x_Canc{ get; set; }
        public Nullable<double> Saldo_Canc { get; set; }
        public Boolean Check { get; set; }
        public Nullable<DateTime>  Fecha_Canc { get; set; }
        public Bitmap btnAnular { get; set; }
        public Bitmap btnEditar { get; set; }
        public string Observacion_canc { get; set; }
        public string numcuota_numpago { get; set; }
        public int DiasPlazo { get; set; }
        public List<ct_Cbtecble_Info> Lista_CbteCble { get; set; }
        public List<ba_Cbte_Ban_Info> Lista_CbteBan { get; set; }


        public ct_Cbtecble_Info Info_CbteCble { get; set; }
        public ba_Cbte_Ban_Info Info_CbteBan { get; set; }

        public int chek_aux { get; set; }

       // public string Banco { get; set; }
        public int IdBanco { get; set; }

        public string IdCtaCble_Prestamo { get; set; }
        public string IdCtaCble_Banco { get; set; }


        public ba_prestamo_detalle_Info()
        {
            Lista_CbteCble = new List<ct_Cbtecble_Info>();
            Lista_CbteBan = new List<ba_Cbte_Ban_Info>();
        }
    }
}

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
    public class ba_prestamo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public string CodPrestamo { get; set; }
        public int IdBanco { get; set; }
        public string IdMotivo_Prestamo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoSol { get; set; }
        public double TasaInteres { get; set; }
        public double TotalPrestamo { get; set; }
        public int NumCuotas { get; set; }
        public string IdTipo_Pago { get; set; }
        public DateTime Fecha_PriPago { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        
        public string NomBanco { get; set; }
        public string NomMotivo_Prestamo { get; set; }
        public string MetodoCalculo { get; set; }
        public string IdPeriPago { get; set; }
        public string IdMetCalc { get; set; }

        public decimal? IdTipoFlujo { get; set; }
        public Nullable<decimal> IdCliente { get; set; }

        public string IdCtaCble { get; set; }
        public string IdCtaCble_Banco { get; set; }
        public Nullable<double> Pago_contado { get; set; }
        public List<ba_prestamo_detalle_Info> lista_detalle { get; set; }
        public List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> lista_activos_prendados { get; set; }
        
        public ba_prestamo_Info()
        {
            lista_detalle = new List<ba_prestamo_detalle_Info>();
            lista_activos_prendados = new List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info>();

        }
    }
}

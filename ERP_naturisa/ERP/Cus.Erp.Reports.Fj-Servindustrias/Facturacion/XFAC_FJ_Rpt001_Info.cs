using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public string codOrdenTrabajo_Pla { get; set; }
        public decimal IdCliente { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string serie { get; set; }
        public double km_salida { get; set; }
        public double km_llegada { get; set; }
        public string con_atencion_a { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string nom_Cliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public int secuencia { get; set; }
        public string descrip_equipo_movi { get; set; }
        public string punto_partida { get; set; }
        public string punto_llegada { get; set; }
        public Nullable<System.TimeSpan> hora_ini { get; set; }
        public Nullable<System.TimeSpan> hora_fin { get; set; }
        public double Valor { get; set; }
    }
}

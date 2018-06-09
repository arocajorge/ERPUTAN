using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_registro_unidades_x_equipo_Info
    {
        public int IdEmpresa { get; set; }
        public Decimal IdRegistro { get; set; }
        public int IdPeriodo { get; set; }
        public string IdCentroCosto { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string IdEstadoRegistro_cat { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        
        public string nom_Centro_costo { get; set; }
        public string nom_Cliente { get; set; }
        public string smes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string nom_EstadoRegistro_cat { get; set; }
        public List<fa_registro_unidades_x_equipo_det_Info> Lst_det { get; set; }
        public List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lst_det_x_Af_ini { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_orden_trabajo_plataforma_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public int secuencia { get; set; }
        public string descrip_equipo_movi { get; set; }
        public string punto_partida { get; set; }
        public string punto_llegada { get; set; }
        public Nullable<System.TimeSpan> hora_ini { get; set; }
        public Nullable<System.TimeSpan> hora_fin { get; set; }
        public DateTime hora_ini_D { get; set; }
        public DateTime hora_fin_D { get; set; }
        public double Valor { get; set; }
    }
}

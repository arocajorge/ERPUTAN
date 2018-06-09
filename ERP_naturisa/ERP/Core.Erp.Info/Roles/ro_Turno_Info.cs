using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_turno_Info
    {
        public int IdEmpresa { get; set; }
        public decimal  IdTurno { get; set; }
        public string tu_descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<bool> es_jornada_desfasada { get; set; }
        public List<ro_turno_x_tb_dia_Info> Detalle {get;set;}
        public ro_turno_Info()
        {
            Detalle = new List<ro_turno_x_tb_dia_Info>();
        }
    }
}

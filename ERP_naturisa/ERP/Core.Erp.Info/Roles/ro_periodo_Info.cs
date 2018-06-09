using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_periodo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int pe_anio { get; set; }
        public int pe_mes { get; set; }
        public DateTime pe_FechaIni { get; set; }
        public DateTime pe_FechaFin { get; set; }
        public string pe_Descripcion { get; set; }
        public string pe_estado { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public bool check { get; set; }
        //public ro_periodo_Info()
        //{
        //}

    }
}

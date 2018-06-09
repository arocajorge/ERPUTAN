using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Periodo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public string nom_periodo { get; set; }
        public int IdanioFiscal { get; set; }
        public int pe_mes { get; set; }
        public DateTime pe_FechaIni { get; set; }
        public DateTime pe_FechaFin { get; set; }
        public string pe_cerrado { get; set; }
        public string smes { get; set; }
        public string pe_estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }



        public ct_Periodo_Info() { }

    }
}

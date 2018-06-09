using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_codigoSRIGrid_Info
    {
        public int id { get; set; }
        public DateTime Vigente_Desde { get; set; }
        public DateTime Vigente_Hasta { get; set; }
        public string Tipo_Codigo { get; set;}
        public string Codigo_SRI { get; set; }
        public string Codigo_Base { get; set; }
        public string Descripcion { get; set; }
        public double Pro_Retencion { get; set; }
       
        public string Estado { get; set; }

        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

        public string IdCtaCble { get; set; }



        public cp_codigo_SRI_Info _codigoSRI { get; set; }

        public cp_codigoSRIGrid_Info() { }
        

    }
}

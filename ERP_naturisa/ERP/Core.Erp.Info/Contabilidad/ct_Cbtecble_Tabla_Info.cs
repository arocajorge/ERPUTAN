using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Cbtecble_Tabla_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public string TipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime Fecha { get; set; }
        public double Valor { get; set; }
        public string Observacion { get; set; }
        public decimal Secuencia { get; set; }
        public string Estado { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string cb_MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime cb_FechaAnu { get; set; }
        public DateTime cb_FechaTransac { get; set; }
        public DateTime? cb_FechaUltModi { get; set; }
        public string Mayorizado { get; set; }
        //public ct_Cbtecble_det_Info _cbteCble_det_info { get; set; }
        //public List<ct_Cbtecble_det_Info> _cbteCble_det_lista_info { get; set; }
       

    }
}

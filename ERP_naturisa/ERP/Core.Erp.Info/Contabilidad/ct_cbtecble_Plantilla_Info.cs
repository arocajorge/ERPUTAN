using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_cbtecble_Plantilla_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdPlantilla { get; set; }
        public DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string cb_MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime? cb_FechaAnu { get; set; }
        public DateTime cb_FechaTransac { get; set; }
        public DateTime? cb_FechaUltModi { get; set; }

        public List<ct_cbtecble_Plantilla_det_Info> LstDet { get; set; }

        public ct_cbtecble_Plantilla_Info(){}
    }
}

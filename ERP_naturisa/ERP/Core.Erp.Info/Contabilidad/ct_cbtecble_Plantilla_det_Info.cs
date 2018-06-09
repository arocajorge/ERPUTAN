using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_cbtecble_Plantilla_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdPlantilla { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public double Debe_Aux { get; set; }
        public double Haber_Aux { get; set; }
        public int? IdPunto_cargo { get; set; }
        public int? IdPunto_cargo_grupo { get; set; }

        public ct_cbtecble_Plantilla_det_Info(){}
    }
}

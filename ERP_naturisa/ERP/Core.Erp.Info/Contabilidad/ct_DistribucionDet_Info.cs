using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_DistribucionDet_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdRegistro { get; set; }
        public string IdCtaCble { get; set; }
        public double F1 { get; set; }
        public double F2 { get; set; }
        public double Valor { get; set; }
    }
}

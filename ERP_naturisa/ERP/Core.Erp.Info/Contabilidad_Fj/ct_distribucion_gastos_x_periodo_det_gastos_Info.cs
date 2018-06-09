using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_gastos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public int Secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public double Saldo { get; set; }
        public bool Checked { get; set; }
        //Vista
        public string pc_Cuenta { get; set; }
    }
}

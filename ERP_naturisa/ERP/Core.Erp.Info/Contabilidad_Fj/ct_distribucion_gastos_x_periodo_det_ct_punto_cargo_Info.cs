using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_ct_punto_cargo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public int Secuencia { get; set; }
        public int IdPunto_cargo { get; set; }
        public double Porcentaje { get; set; }
        public bool Checked { get; set; }
        //Vistas
        public string nom_punto_cargo { get; set; }
    }
}

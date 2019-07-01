using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_solicitante_aprobador_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdSolicitante { get; set; }
        public int Secuencia { get; set; }
        public string IdUsuario { get; set; }
        public decimal IdDepartamento { get; set; }
        public double MontoMin { get; set; }
        public double MontoMax { get; set; }
    }
}

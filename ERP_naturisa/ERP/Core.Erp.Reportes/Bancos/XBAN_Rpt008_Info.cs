using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
  public class XBAN_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public decimal? idTipoFlujo { get; set; }
        public string descripcion_flujo { get; set; }
        public string  ba_descripcion { get; set; }
        public string ba_Num_Cuenta { get; set; }
        public string Des_tipo_cbte { get; set; }
        public double? dc_Valor { get; set; }
        public int Orden { get; set; }
        public int? id_Des_tipo_cbte { get; set; }
    }
}

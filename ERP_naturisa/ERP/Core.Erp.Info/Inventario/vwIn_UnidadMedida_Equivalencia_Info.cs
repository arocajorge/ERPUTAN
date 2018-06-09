using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwIn_UnidadMedida_Equivalencia_Info
    {
        public string IdUnidadMedida { get; set; }
        public string IdUnidadMedida_equiva { get; set; }
        public string cod_alterno { get; set; }
        public string Descripcion { get; set; }
        public double valor_equiv { get; set; }
        public string interpretacion { get; set; }

        public string cod_alterno_Padre { get; set; }
        public string Descripcion_Padre { get; set; }

        public vwIn_UnidadMedida_Equivalencia_Info()
        {

        }
    }
}

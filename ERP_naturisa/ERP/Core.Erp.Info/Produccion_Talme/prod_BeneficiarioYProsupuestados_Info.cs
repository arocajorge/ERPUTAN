using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produccion_Talme
{
    public class prod_BeneficiarioYProsupuestados_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdBeneficiario { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public prod_BeneficiarioYProsupuestados_Info()
        {
        }

    }
}

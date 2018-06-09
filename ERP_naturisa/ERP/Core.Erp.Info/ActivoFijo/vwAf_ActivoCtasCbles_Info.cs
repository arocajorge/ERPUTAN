using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAf_ActivoCtasCbles_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdTipoCuenta { get; set; }
        public string Descripcion { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string Observacion { get; set; }


        public vwAf_ActivoCtasCbles_Info()
        {

        }
    }
}

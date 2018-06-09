using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt003_Info
    {
        public int IdEmpresa_AF { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCentroCosto_Scc { get; set; }
        public string IdCentroCosto_sub_centro_costo_Scc { get; set; }
        public int IdCategoriaAF { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public int IdActivoFijo { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Subcentro_Costo { get; set; }
        public string Centro_costo { get; set; }
        public string Af_Nombre { get; set; }
        public string CodActivoFijo { get; set; }
        public string Estado { get; set; }
        public string Af_DescripcionCorta { get; set; }


        public byte[] em_logo { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }

    }
}

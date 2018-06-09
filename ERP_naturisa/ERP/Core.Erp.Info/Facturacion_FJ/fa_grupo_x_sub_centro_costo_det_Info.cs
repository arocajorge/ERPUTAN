using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_grupo_x_sub_centro_costo_det_Info
    {
        public int IdEmpresa { get; set; }
        public Decimal IdGrupo { get; set; }
        public int Secuencia { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCentroCosto { get; set; }

        //campos para la vista
        public string cod_subcentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string pc_Estado { get; set; }
        public string IdCtaCble { get; set; }
    }
}

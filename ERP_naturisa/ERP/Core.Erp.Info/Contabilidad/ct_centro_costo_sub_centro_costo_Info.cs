using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_centro_costo_sub_centro_costo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string cod_subcentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Centro_costo2 { get; set; }
        public string pc_Estado { get; set; }
        public string IdCtaCble { get; set; }
        public string NomSubCentroCosto { get; set; }
        public string IdRegistro { get; set; }

        public string nom_cuenta{ get; set; }
        public string pc_clave_corta { get; set; }
        public string nom_Centro_costo { get; set; }

        public ct_centro_costo_sub_centro_costo_Info() { }

    }
}

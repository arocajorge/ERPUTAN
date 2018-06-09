using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_tipo_nota_Info
    {

        public int IdEmpresa { get; set; }
        public int IdTipoNota { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string pc_Cuenta { get; set; }
        public string Centro_costo { get; set; }
        public string nom_CtaCble { get; set; }
        public string nom_CentroCosto { get; set; }
        public string Estado { get; set; }

        public ba_tipo_nota_Info()
        {

        }

    }
}

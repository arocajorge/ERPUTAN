using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Produc_Cirdesus
{
  public  class prd_GruposTrabajo_PorPP_Info
  {
        public int IdEmpresa { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdEtapa { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public int IdSubgrupo { get; set; }

        public string NombreSubgrupo { get; set; }
        public string NombreGrupos { get; set; }
        public string ProcesoProductivo { get; set; }
        public string NombreEtapa { get; set; }

    }
}

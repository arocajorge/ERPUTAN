using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_x_prd_obra_Info
    {
        public int IdEmpresa { get; set; }
        public string CodObra { get; set; }
        
        public int IdEmpresa_Pr { get; set; }
        public int IdProcesoProductivo { get; set; }
        public string NombreModelo { get; set; }

        public prd_ProcesoProductivo_x_prd_obra_Info(){}
    }
}

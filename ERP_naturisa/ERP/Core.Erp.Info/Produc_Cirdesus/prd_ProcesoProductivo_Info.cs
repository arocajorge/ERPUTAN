using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProcesoProductivo { get; set; }
        public string Nombre { get; set; }
        public Boolean Estado { get; set; }

        public string EstadoCadena { get; set; }

        public string CodObra { get; set; }
        public string ob_descripcion { get; set; }
        public string Referencia { get; set; }

    //    public prd_ProcesoProductivo_Info() {}
    }
}

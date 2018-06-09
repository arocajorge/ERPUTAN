using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwprd_MovPteGruaSaldo_Info
    {
        public int et_IdEmpresa { get; set; }
        public int et_IdProcesoProductivo { get; set; }
        public int et_IdEtapa { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string ot_CodObra { get; set; }
        public decimal ot_IdOrdenTaller { get; set; }
        public string mv_tipo_movi { get; set; }
        public int mpg_cant { get; set; }
        public string mpg_codbarra { get; set; }
     

        public vwprd_MovPteGruaSaldo_Info() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class tbPRO_CUS_CID_Rpt010_Info
    {
        public int? IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public int IdProcesoProductivo { get; set; }
        public string ProcProd { get; set; }
        public string CodObra { get; set; }
        public string obra { get; set; }
        public int IdEtapa { get; set; }
        public string NombreEtapa { get; set; }
        public double PorcentajeEtapa { get; set; }
        public double totalporcentaje { get; set; }

        public tbPRO_CUS_CID_Rpt010_Info()
        {

        }
    }
}

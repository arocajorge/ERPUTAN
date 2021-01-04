using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_DistribucionDetDistribuido_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdRegistro { get; set; }
        public string IdCtaCble { get; set; }
        public decimal F1 { get; set; }
        public decimal F2 { get; set; }
        public int Secuencia { get; set; }
        public string Observacion { get; set; }

        #region Campos que no existen en la base
        public decimal F3 { get; set; }
        #endregion        
    }
}

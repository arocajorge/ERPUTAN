using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Parametros_Info
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> IdSucursal_fact { get; set; }
        public Nullable<int> IdBodega_fact { get; set; }
        public Nullable<int> IdPuntoVta_fact { get; set; }
        public Nullable<int> IdCaja_fact { get; set; }
        public int IdInstitucion { get; set; }
    }
}

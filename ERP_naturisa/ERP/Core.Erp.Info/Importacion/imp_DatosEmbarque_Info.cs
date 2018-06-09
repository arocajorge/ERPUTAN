using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
   public class imp_DatosEmbarque_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public int cp_secuencia { get; set; }
        public string cp_TipoEmbarque { get; set; }
        public string cp_TipoConten { get; set; }
        public double cp_cantidad { get; set; }
        public double cp_Kiligramo { get; set; }
        public double cp_MCubicos { get; set; }
        public double cp_ValorFlete { get; set; }

        public imp_DatosEmbarque_Info()
        {

        }
    }
}

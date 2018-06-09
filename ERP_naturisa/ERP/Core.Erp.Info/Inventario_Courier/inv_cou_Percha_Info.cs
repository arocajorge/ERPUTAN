using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Courier
{
    public class inv_cou_Percha_Info
    {

        public int IdEmpresa { get; set; }
        public int IdPercha { get; set; }
        public string Descripcion { get; set; }
        public string CodPercha { get; set; }
        public string estado { get; set; }
        public string MotiAnulacion { get; set; }

        public inv_cou_Percha_Info()
        {

        }
    }
}

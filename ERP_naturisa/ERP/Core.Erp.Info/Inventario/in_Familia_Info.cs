using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Familia_Info
    {
        public int IdEmpresa { get; set; }
        public int IdFamilia { get; set; }
        public string fa_Codigo { get; set; }
        public string fa_Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_Edehsa
{
    public class in_Categoria_x_Formula_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCategoria { get; set; }
        public string descripcion_corta { get; set; }
        public Nullable<bool> tiene_longitud { get; set; }
        public Nullable<bool> tiene_espesor { get; set; }
        public Nullable<bool> tiene_ancho { get; set; }
        public Nullable<bool> tiene_alto { get; set; }
        public Nullable<bool> tiene_ceja { get; set; }
        public Nullable<bool> tiene_diametro { get; set; }
        public int densidad { get; set; }
        public string formula { get; set; }
        public bool estado { get; set; }

        public in_Categoria_x_Formula_Info() { }

    }
}

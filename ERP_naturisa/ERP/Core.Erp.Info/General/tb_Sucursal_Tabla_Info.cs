using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_Sucursal_Tabla_Info
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public Boolean Su_Estado { get; set; }

        public tb_Sucursal_Tabla_Info() { }
    }
}

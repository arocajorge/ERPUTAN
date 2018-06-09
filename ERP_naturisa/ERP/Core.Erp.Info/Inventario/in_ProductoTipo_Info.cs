using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_ProductoTipo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProductoTipo { get; set; }
        public string tp_descripcion { get; set; }
        public string tp_EsCombo { get; set; }
        public string tp_ManejaInven { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string EsMateriaPrima { get; set; }
        public string EsProductoTerminado { get; set; }
        public string MotivoAnulacion { get; set; }
        public in_ProductoTipo_Info() { }
    }
}

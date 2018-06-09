using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_movi_inven_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string Codigo { get; set; }
        public string tm_descripcion { get; set; }
        public string cm_tipo_movi { get; set; }
        public string cm_interno { get; set; }
        public string cm_descripcionCorta { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Boolean Chek { get; set; }
        public string tm_descripcion2 { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public Boolean? Genera_Movi_Inven { get; set; }
        public Boolean ? Genera_Diario_Contable { get; set; }


        public in_movi_inven_tipo_Info() { }
    }
}

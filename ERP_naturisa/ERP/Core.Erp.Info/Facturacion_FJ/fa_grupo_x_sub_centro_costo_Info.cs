using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_grupo_x_sub_centro_costo_Info
    {
        //campos de la tabla
        public int IdEmpresa { get; set; }
        public Decimal IdGrupo { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_Grupo { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        //detalle
        public List<fa_grupo_x_sub_centro_costo_det_Info> List_Detalle = new List<fa_grupo_x_sub_centro_costo_det_Info>();

        //campos adicionales para la vista.
        public string nom_Centro_costo { get; set; }
        public string nom_Cliente { get; set; }
    }
}

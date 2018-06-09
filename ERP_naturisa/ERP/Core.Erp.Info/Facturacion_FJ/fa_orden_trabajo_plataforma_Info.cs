using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_orden_trabajo_plataforma_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public string codOrdenTrabajo_Pla { get; set; }
        public decimal IdCliente { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string serie { get; set; }
        public System.DateTime Fecha { get; set; }
        public double km_salida { get; set; }
        public double km_llegada { get; set; }
        public string con_atencion_a { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
       

        public string nom_Cliente { get; set; }

        public List<fa_orden_trabajo_plataforma_det_Info> lst_Det_Orden { get; set; }
    }
}

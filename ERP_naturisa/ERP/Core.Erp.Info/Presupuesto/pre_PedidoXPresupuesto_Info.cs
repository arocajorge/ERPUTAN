using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Presupuesto
{
    public class pre_PedidoXPresupuesto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPedidoXPre { get; set; }
        public int? IdDepartamento { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public decimal? IdProveedor1 { get; set; }
        public decimal? IdProveedor2 { get; set; }
        public decimal? IdProveedor3 { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public List<pre_PedidoXPresupuesto_det_Info> Lst_PedidoXPre_D { get; set; }
        public string MotivoAnulacion { get; set; }
        
        public pre_PedidoXPresupuesto_Info(){}
    }
}

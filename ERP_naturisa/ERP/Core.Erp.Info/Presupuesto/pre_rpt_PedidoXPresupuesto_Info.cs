using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Presupuesto
{
    public class pre_rpt_PedidoXPresupuesto_Info
    {
      
        public int IdEmpresa { get; set; }
        public decimal IdPedidoXPre { get; set; }
        public string Departamento { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Proveedor1 { get; set; }
        public string Proveedor2 { get; set; }
        public string Proveedor3 { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }

        public List<pre_PedidoXPresupuesto_det_Info> Lst_PedidoXPre_D { get; set; }
        public tb_Empresa_Info Empresa { get; set; }

        public pre_rpt_PedidoXPresupuesto_Info(){}
    }
}

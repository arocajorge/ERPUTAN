using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_pedido
    {
        public tb_Empresa_Info InfoEmpresa { get; set; }
        public fa_pedido_Info InfoPedido { get; set; }
        public List<fa_pedido_det_Info> ListaDetalle{ get; set; }


        public fa_rpt_pedido()
        {
            InfoEmpresa = new tb_Empresa_Info();
            InfoPedido = new fa_pedido_Info();
            ListaDetalle = new List<fa_pedido_det_Info>();
        }
    }
}

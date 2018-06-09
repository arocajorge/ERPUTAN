using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Info.Inventario
{
    public class in_rpt_AjusteFisico
    {

        public tb_Empresa_Info InfoEmpresa { get; set; }
        public in_ajusteFisico_Info InfoAjusteFisico { get; set; }
      //  public List<in_AjusteFisico_Detalle_Info> listDetalleAjuste { get; set; }
        public List<in_Producto_Info> ListaProducto{ get; set; }

        public in_rpt_AjusteFisico() 
        {
            InfoAjusteFisico = new in_ajusteFisico_Info();
            ListaProducto = new List<in_Producto_Info>();
            InfoEmpresa = new tb_Empresa_Info();
        }
    }
}

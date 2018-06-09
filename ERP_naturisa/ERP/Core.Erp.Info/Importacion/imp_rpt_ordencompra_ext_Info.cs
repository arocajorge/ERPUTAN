using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
namespace Core.Erp.Info.Importacion
{
    public class imp_rpt_ordencompra_ext_Info
    {
        public  tb_Empresa_Info InfoEmpresa { get; set; }
        public imp_ordencompra_ext_Info InfoOrdeCompra { get; set; }
        public List<imp_ordencompra_ext_det_Info> ListaDetalle { get; set; }


        public imp_rpt_ordencompra_ext_Info()
        {
            InfoEmpresa = new tb_Empresa_Info();
            InfoOrdeCompra = new imp_ordencompra_ext_Info();
            ListaDetalle = new List<imp_ordencompra_ext_det_Info>();
        }
    }
}

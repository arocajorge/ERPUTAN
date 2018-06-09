using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_Factura_Info
    {
        public tb_Empresa_Info infoEmp { get; set; }

        public List<fa_factura_det_info> listaP { get; set; }
        public fa_factura_Info factura { get; set; }

        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string idUsuario { get; set; }
        public string Producto { get; set; }
        public decimal STotal0 { get; set; }
        public decimal STotalImp { get; set; }
        public decimal Total { get; set; }

        public fa_rpt_Factura_Info() { 
            infoEmp = new tb_Empresa_Info();
            listaP = new List<fa_factura_det_info>();
            factura = new fa_factura_Info();
        }
    }
}

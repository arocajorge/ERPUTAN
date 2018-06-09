using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

///

namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_devol_venta_Info
    {
        public tb_Empresa_Info infoEmp { get; set; }

        public List<fa_devol_venta_det_Info> listaP { get; set; }
        public fa_devol_venta_Info Devolucion { get; set; }

        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string idUsuario { get; set; }
        public decimal Total { get; set; }
        public decimal Total0 { get; set; }
        public decimal TotalI { get; set; }
        public string NumeroFac { get; set; }

        public fa_rpt_devol_venta_Info()
        { 
            infoEmp = new tb_Empresa_Info();
            listaP = new List<fa_devol_venta_det_Info>();
            Devolucion = new fa_devol_venta_Info();
        }
    }
}

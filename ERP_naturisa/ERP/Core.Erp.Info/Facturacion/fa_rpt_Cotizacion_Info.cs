using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_Cotizacion_Info
    {
        public tb_Empresa_Info infoEmp { get; set; }

        public List<fa_cotizacion_det_info> listaP { get; set; }
        public fa_cotizacion_info cotizacion { get; set; }

        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string idUsuario { get; set; }
        public string Producto { get; set; }
        public decimal IdCotizacion { get; set; }
        public decimal STotal0 { get; set; }
        public decimal STotalImp { get; set; }
        
        public fa_rpt_Cotizacion_Info()
        {
            infoEmp = new tb_Empresa_Info();
            listaP = new List<fa_cotizacion_det_info>();
            cotizacion = new fa_cotizacion_info();
        }

    }
}

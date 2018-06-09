using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Inventario
{
    public class in_OrdenCompraLocalReporte_Info
    {
        
        public in_OrdenCompraLocal_Info OC_CabeceraInfo { get; set; }
        public List<in_OrdenCompraLocalDetalle_Info> OC_DetalleInfo { get; set; }
        public cp_proveedor_Info Proveedor { get; set; }
        public tb_Empresa_Info Empresa { get; set; }
        public tb_persona_Info Persona { get; set; }
        public in_OrdenCompraLocalEstado_Info EstadoOC { get; set; }

        public in_OrdenCompraLocalReporte_Info() { }
    }
}

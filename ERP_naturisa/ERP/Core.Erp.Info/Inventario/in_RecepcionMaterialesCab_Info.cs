using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_RecepcionMaterialesCab_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdRecepcionMaterial { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado { get; set; }
        public String EstadoRecepcion { get; set; }

        public string CodObra { get; set; }
        public string NumOC { get; set; }
        public string NomSucursal { get; set; }
        public string NomProveedor { get; set; }
        public string Referencia { get; set; }
        public string NumRecepcion { get; set; }
        public string NomCentroCosto { get; set; }
        public string Observacion { get; set; }

        public in_RecepcionMaterialesCab_Info() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_Obra_Info
    {
        public string CodObra { get; set; }
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string Descripcion { get; set; }
        public string DetalleObra { get; set; }
        public string Estado { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime? FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime? FechaUltModi { get; set; }
        public string cl_RazonSocial { get; set; }
        public Nullable<decimal> PesoObra { get; set; }
        public string Referencia { get; set; }

        public prd_Obra_Info() { }

    }
}

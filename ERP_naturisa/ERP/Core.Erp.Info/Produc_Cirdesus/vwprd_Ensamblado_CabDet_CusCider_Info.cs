using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwprd_Ensamblado_CabDet_CusCider_Info
    {
        public int IdBodega { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public decimal cab_IdProducto { get; set; }
        public string CBMaestro { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }
        public string cab_Estado { get; set; }
        public string cab_observacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdEnsamblado { get; set; }
        public int Secuencia { get; set; }
        public decimal det_IdProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string det_observacion { get; set; }
        public int en_cantidad { get; set; }

        public vwprd_Ensamblado_CabDet_CusCider_Info() { }
    }
}

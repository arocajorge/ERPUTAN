using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_Ensamblado_CusCider_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string  su_descripcion { get; set; }
        public decimal IdEnsamblado { get; set; }
        public int IdBodega { get; set; }
        public string bo_descripcion { get; set; }
        public decimal IdGrupoTrabajo { get; set; }
        public string gt_descripcion { get; set; }
        public decimal IdProducto { get; set; }
        public string  CodigoBarra { get; set; }
        public string Producto { get; set; }
        public string CodObra { get; set; }
        public string  ob_descripcion { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string CodOT { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> IdDespacho { get; set; }

        //campos para consulta vwprd_ensamblado_CusCider
        
		
		
        public int IdProcesoProductivo { get; set; }
        public int IdEtapa { get; set; } 
        public prd_Ensamblado_CusCider_Info() { }
    }
}

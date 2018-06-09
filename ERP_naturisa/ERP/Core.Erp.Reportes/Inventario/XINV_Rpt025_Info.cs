using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt025_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public string dm_observacion { get; set; }
        public string cm_observacion { get; set; }
        public double mv_costo { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAproba { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public double total { get; set; }
        public string CodMoviInven { get; set; }
        public string signo { get; set; }
    }
}

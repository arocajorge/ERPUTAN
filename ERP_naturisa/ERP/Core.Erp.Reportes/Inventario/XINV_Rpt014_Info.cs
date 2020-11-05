using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public int IdBodega { get; set; }
        public DateTime cm_fecha { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string NomCentroCosto { get; set; }
        public string NomSubcentro { get; set; }
        public string IdEstadoAproba { get; set; }
        public string Su_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public double dm_cantidad { get; set; }
        public string NomUnidadMedida { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public string nom_empresa { get; set; }
        public int IdSucursal { get; set; }
        public string nom_sucursal { get; set; }
        public int IdBodega { get; set; }
        public string nom_bodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string nom_Movi_inven_tipo { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_Producto { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_CentroCosto { get; set; }
        public string IdSubCentro_Costo { get; set; }
        public string nom_subCentroCosto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_UnidadMedida { get; set; }
        public double dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public double SubTotal { get; set; }
        public decimal IdNumMovi { get; set; }
        public DateTime Fecha { get; set; }
        public string cm_tipo_movi { get; set; }
    }
}

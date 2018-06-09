using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt024_Info
    {
        public int IdEmpresa { get; set; }
        public string nom_empresa { get; set; }
        public int IdSucursal { get; set; }
        public string nom_sucursal { get; set; }
        public int IdBodega { get; set; }
        public string nom_bodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string cod_tipo_movi { get; set; }
        public string nom_tipo_movi { get; set; }
        public string Tipo { get; set; }
        public DateTime cm_fecha { get; set; }
        public string cm_observacion { get; set; }
        public string Estado { get; set; }
        public int Secuencia { get; set; }
        public string cod_producto { get; set; }
        public Decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_UnidadMedida { get; set; }
        public Double cantidad { get; set; }
        public Double costo_uni { get; set; }
        public Double Costo_Total { get; set; }
        public string dm_observacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_tipo { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }

        public double dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public double costo_x_unidades { get; set; }
        public double SubTotal { get; set; }

        public string dm_observacion { get; set; }        
        public string nom_empresa { get; set; }
        public string ruc_empresa { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string nom_tipo_inven { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_centro_costo { get; set; }
        public string nom_subcentro_costo { get; set; }
        public string IdSubcentro_costo { get; set; }
        public string IdCentro_costo { get; set; }
    }
}

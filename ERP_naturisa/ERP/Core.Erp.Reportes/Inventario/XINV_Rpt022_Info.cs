using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt022_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public string cod_Dev_Inven { get; set; }
        public DateTime Fecha { get; set; }
        public string estado { get; set; }
        public string cm_tipo { get; set; }
        public string observacion_inven { get; set; }
        public int IdEmpresa_movi_inv { get; set; }
        public int IdSucursal_movi_inv { get; set; }
        public int IdBodega_movi_inv { get; set; }
        public int IdMovi_inven_tipo_movi_inv { get; set; }
        public decimal IdNumMovi_movi_inv { get; set; }
        public int Secuencia_movi_inv { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad_Inv { get; set; }
        public double cantidad_devuelta { get; set; }
        public double mv_costo { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_tipo_movi_inv { get; set; }
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_empresa { get; set; }

        public XINV_Rpt022_Info()
        {

        }
    }
}

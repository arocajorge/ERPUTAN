using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC_Ing
    {

        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int IdEmpresaConciliacion { get; set; }
        public decimal IdConciliacion { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_Ing_Egr_Inv { get; set; }
        public int IdSucursal_Ing_Egr_Inv { get; set; }
        public decimal IdNumMovi_Ing_Egr_Inv { get; set; }
        public int Secuencia_Ing_Egr_Inv { get; set; }
        public int IdBodega { get; set; }
        public DateTime Fecha_Ing_Bod { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_medida { get; set; }
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public double Cantidad { get; set; }
        public double Costo_uni { get; set; }
        public double do_porc_des { get; set; }
        public string do_ManejaIva { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public decimal IdOrdenCompra { get; set; }

        public vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC_Ing()
        {

        }
    }
}

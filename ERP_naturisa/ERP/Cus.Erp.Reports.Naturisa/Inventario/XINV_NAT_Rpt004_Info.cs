using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public String cm_tipo { get; set; }
        public String cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public String Estado { get; set; }
        //public String nom_sucursal { get; set; }
        //public String nom_bodega { get; set; }
        public String TipoMovi_Inven { get; set; }
        public decimal IdProducto { get; set; }
        public String cod_producto { get; set; }
        // public String nom_producto { get; set; }
        public Double dm_cantidad { get; set; }
        public String dm_observacion { get; set; }
        public Double dm_precio { get; set; }
        public Double mv_costo { get; set; }
        public Double dm_peso { get; set; }
        public String emp_nombre { get; set; }
        public String emp_ruc { get; set; }
        public String emp_tele { get; set; }
        public String emp_direccion { get; set; }
        public Image emp_logo { get; set; }
        public decimal IdProveedor { get; set; }
        // public string nom_proveedor { get; set; }
        public Boolean do_ManejaIva { get; set; }
        public String IVA { get; set; }
        //public Double calculoIva { get; set; }
        //public Double calculototal { get; set; }
        public Double Subtotal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_unidad { get; set; }
        public string pr_descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string pr_nombre { get; set; }
        public string pr_codigo { get; set; }

        public int IdMotivo_Inv { get; set; }
        public string Desc_mov_inv { get; set; }

        public XINV_NAT_Rpt004_Info()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt001_Info
    {
        public decimal IdOrdenSer_x_Af { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Num_Fact { get; set; }
        public string Num_Documento { get; set; }
        public string Observacion { get; set; }
        public int IdSucursal { get; set; }
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public string bo_Descripcion { get; set; }
        public string em_nombre { get; set; }
        public string Su_Descripcion { get; set; }
        public string Af_Nombre { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public string pr_nombre { get; set; }
    }
}

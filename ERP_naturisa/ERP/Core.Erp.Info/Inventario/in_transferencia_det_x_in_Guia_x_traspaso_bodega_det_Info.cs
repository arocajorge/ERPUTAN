using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info
    {
        public int IdEmpresa_trans { get; set; }
        public int IdSucursalOrigen_trans { get; set; }
        public int IdBodegaOrigen_trans { get; set; }
        public decimal IdTransferencia_trans { get; set; }
        public int Secuencia_trans { get; set; }
        public int IdEmpresa_guia { get; set; }
        public decimal IdGuia_guia { get; set; }
        public int Secuencia_guia { get; set; }
        public string Observacion { get; set; }

        public string cod_sucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string cod_bodega { get; set; }
        public string bo_Descripcion { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
    }
}
